﻿
// This file has been generated by the GUI designer. Do not modify.
namespace Docking.Components
{
	public partial class PropertyViewer
	{
		private global::MonoDevelop.Components.PropertyGrid.PropertyGrid propertygrid1;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Docking.Components.PropertyViewer
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Docking.Components.PropertyViewer";
			// Container child Docking.Components.PropertyViewer.Gtk.Container+ContainerChild
			this.propertygrid1 = new global::MonoDevelop.Components.PropertyGrid.PropertyGrid ();
			this.propertygrid1.Name = "propertygrid1";
			this.propertygrid1.ShowToolbar = true;
			this.propertygrid1.ShowHelp = true;
			this.Add (this.propertygrid1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
