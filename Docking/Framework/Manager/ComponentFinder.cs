using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Docking;
using Gtk;
using System.Diagnostics;

namespace Docking.Components
{
   public class ComponentFinder
   {
      private List<Type> mTypes = new List<Type>();

      private List<ComponentFactoryInformation> mComponents = new List<ComponentFactoryInformation>();

      public ComponentFactoryInformation[] ComponentInfos { get { return mComponents.ToArray(); } }

      public ComponentFactoryInformation FindEntryPoint(Type t)
      {
         foreach (ComponentFactoryInformation info in mComponents)
         {
            if (t == info.ComponentType)
               return info;
         }
         return null;
      }

      public ComponentFactoryInformation FindComponent(String typename)
      {
         foreach (ComponentFactoryInformation info in mComponents)
            if (typename == info.ComponentType.ToString())
               return info;
         return null;
      }

      Component CreateInstance(ComponentFactoryInformation info, ComponentManager cm)
      {
         Component component = info.CreateInstance(cm);
         return component;
      }

      public Widget FindInstance(Type type)
      {
         foreach (ComponentFactoryInformation info in mComponents)
         {
            Type t = info.ComponentType;
            if (t != null)
            {
               if (t == type)
               {
                  return info.DockWidget;
               }
               Type[] myInterfaces = t.FindInterfaces(mTypeFilter, type);
               if (myInterfaces.Length > 0 && info.DockWidget != null)
               {
                  return info.DockWidget;
               }
            }
         }
         return null;
      }

      TypeFilter mTypeFilter = new TypeFilter(InterfaceFilterCallback);

      private static bool InterfaceFilterCallback(Type typeObj, System.Object criteriaObj)
      {
         return typeObj == (Type)criteriaObj;
      }

      void SearchComponents()
      {
         // find all non-abstract classes which inherit from interface 'IComponentFactory'
         Type[] factories = SearchForTypes(typeof(IComponentFactory));

         foreach (Type t in factories)
         {
            try
            {
               IComponentFactory cf = Activator.CreateInstance(t) as IComponentFactory;
               if(cf==null)
                  continue;
               mComponents.Add(new ComponentFactoryInformation(cf, true));
            }
            catch(InvalidCastException /*e*/)
            {
               // Console.WriteLine("{0}", e.ToString());
            }
            catch(MissingMethodException /*e*/)
            {
               // Console.WriteLine("{0}", e.ToString());
            }
            catch(ReflectionTypeLoadException /*e*/)
            {
               // Console.WriteLine("{0}", e.ToString());
            }
            catch(Exception /*e*/)
            {
               // Console.WriteLine("{0}", e.ToString());
            }
         }
      }

      public void SearchForComponents(String search)
      {
         SearchForComponents(new String[] { search });
      }

      public void SearchForComponents(String[] search)
      {
         List<String> componentFiles = new List<string>();
         foreach (String s in search)
         {
            String folder = Path.GetDirectoryName(s);
            String name = Path.GetFileName(s);

            string[] files = Directory.GetFiles(folder, name);
            componentFiles.AddRange(files);
         }
         foreach (String s in componentFiles)
            CollectTypes(Path.GetFullPath(s));

         SearchComponents();
      }

      void CollectTypes(String filename)
      {
         try
         {
            Assembly asm = Assembly.LoadFrom(filename);
            Type[] types = asm.GetExportedTypes();
            mTypes.AddRange(types);
         }
         catch (FileNotFoundException) { } // cheap            
         catch (BadImageFormatException) { } // cheap
         catch (ReflectionTypeLoadException) { } // cheap
         catch (MissingMethodException) { } // cheap
         catch (TypeLoadException) { } // cheap
         catch (Exception) // runtime expensive! avoid getting here to have a speedy start!
         {
            //Console.WriteLine(e.ToString());
         }
      }

      /// <summary>
      /// Searches for requested type in all available components DLLs
      /// The searched type could be a class, an abstract class or an interface
      /// </summary>

      public Type[] SearchForTypes(Type search)
      {
         TypeFilter TypeFilter = new TypeFilter(InterfaceFilterCallback);
         List<Type> theList = new List<Type>();
         foreach (Type type in mTypes)
         {
            if (!type.IsAbstract && type.IsClass)
            {
               // check if requested interface implemented
               if (search.IsInterface)
               {
                  if (type.FindInterfaces(TypeFilter, search).Length > 0)
                  {
                     if (!theList.Contains(type)) // avoid duplicates
                        theList.Add(type);
                  }
               }

               // test current type and search also in the base class tree
               else
               {
                  for (Type t = type; t != null; t = t.BaseType)
                  {
                     if (t.Name == search.Name)
                     {
                        if (!theList.Contains(type)) // avoid duplicates
                           theList.Add(type);
                        break;
                     }
                  }
               }

            }
         }
         return theList.ToArray();
      }


      public List<ComponentFactoryInformation> GetAutoCreateList(ComponentManager cm)
      {
         List<ComponentFactoryInformation> result = new List<ComponentFactoryInformation>();
         foreach (ComponentFactoryInformation info in mComponents)
            if(info.AutoCreate)
               result.Add(info);
         return result;
      }
   }

   public class ComponentFactoryInformation
   {
      public ComponentFactoryInformation(IComponentFactory factory, bool active)
      {
         Debug.Assert(factory != null);
         ComponentFactory = factory;
         Active = active;
      }

      public Component CreateInstance(ComponentManager cm)
      {
         if(cm==null)
            return null;
         Component component;
         try { component = Activator.CreateInstance(ComponentType) as Component; }
         catch (Exception e)
         {
            cm.MessageWriteLine(e.ToString());
            return null;
         }
         if(component==null)
         {
            cm.MessageWriteLine("Error: class '{0}' does not inherit from 'Component'", ComponentType.ToString());
            return null;
         }
         component.ComponentManager = cm;
         return component;
      }

      public Type   FactoryType    { get { return ComponentFactory.GetType(); } }
      public Type   ComponentType  { get { return ComponentFactory.TypeOfInstance; } }
      public String Comment        { get { return ComponentFactory.Comment; } }
      public String MenuPath       { get { return ComponentFactory.MenuPath; } }
      public String LicenseGroup   { get { return ComponentFactory.LicenseGroup; } }

      public bool   MultiInstance  { get { return (ComponentFactory.Options & Mode.MultiInstance )!=0; } }
      public bool   AutoCreate     { get { return (ComponentFactory.Options & Mode.AutoCreate    )!=0; } }
      public bool   HideOnCreate   { get { return (ComponentFactory.Options & Mode.HideOnCreate  )!=0; } }
      public bool   PreventClosing { get { return (ComponentFactory.Options & Mode.PreventClosing)!=0; } }

      public Gdk.Pixbuf Icon { get { return ComponentFactory.Icon; } }

      public IComponentFactory ComponentFactory { get; set; }

      public bool Active { get; set; }

      public Widget DockWidget { get; set; }
   }
}
