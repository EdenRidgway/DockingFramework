
// This file has been generated by the GUI designer. Do not modify.
namespace Docking.Components
{
 public partial class NewLayout
 {
  private global::Gtk.VBox vbox2;
  private global::Gtk.HBox hbox1;
  private global::Gtk.Label label1;
  private global::Gtk.Entry entryLayoutName;
  private global::Gtk.RadioButton radiobuttonCopy;
  private global::Gtk.RadioButton radiobuttonEmpty;
  private global::Gtk.Button buttonCancel;
  private global::Gtk.Button buttonOk;

  protected virtual void Build ()
  {
   global::Stetic.Gui.Initialize (this);
   // Widget Docking.Components.NewLayout
   this.Events = ((global::Gdk.EventMask)(65536));
   this.Name = "Docking.Components.NewLayout";
   this.WindowPosition = ((global::Gtk.WindowPosition)(4));
   // Internal child Docking.Components.NewLayout.VBox
   global::Gtk.VBox w1 = this.VBox;
   w1.Name = "dialog1_VBox";
   w1.BorderWidth = ((uint)(10));
   // Container child dialog1_VBox.Gtk.Box+BoxChild
   this.vbox2 = new global::Gtk.VBox ();
   this.vbox2.Name = "vbox2";
   this.vbox2.Spacing = 6;
   // Container child vbox2.Gtk.Box+BoxChild
   this.hbox1 = new global::Gtk.HBox ();
   this.hbox1.Name = "hbox1";
   this.hbox1.Spacing = 6;
   // Container child hbox1.Gtk.Box+BoxChild
   this.label1 = new global::Gtk.Label ();
   this.label1.Name = "label1";
   this.label1.LabelProp = "Layout Name:";
   this.hbox1.Add (this.label1);
   global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
   w2.Position = 0;
   w2.Expand = false;
   w2.Fill = false;
   // Container child hbox1.Gtk.Box+BoxChild
   this.entryLayoutName = new global::Gtk.Entry ();
   this.entryLayoutName.CanFocus = true;
   this.entryLayoutName.Name = "entryLayoutName";
   this.entryLayoutName.IsEditable = true;
   this.entryLayoutName.ActivatesDefault = true;
   this.entryLayoutName.InvisibleChar = '●';
   this.hbox1.Add (this.entryLayoutName);
   global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryLayoutName]));
   w3.Position = 1;
   this.vbox2.Add (this.hbox1);
   global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
   w4.Position = 0;
   w4.Expand = false;
   w4.Fill = false;
   // Container child vbox2.Gtk.Box+BoxChild
   this.radiobuttonCopy = new global::Gtk.RadioButton ("Copy from current layout");
   this.radiobuttonCopy.CanFocus = true;
   this.radiobuttonCopy.Name = "radiobuttonCopy";
   this.radiobuttonCopy.Active = true;
   this.radiobuttonCopy.DrawIndicator = true;
   this.radiobuttonCopy.UseUnderline = true;
   this.radiobuttonCopy.Group = new global::GLib.SList (global::System.IntPtr.Zero);
   this.vbox2.Add (this.radiobuttonCopy);
   global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.radiobuttonCopy]));
   w5.Position = 1;
   w5.Expand = false;
   w5.Fill = false;
   // Container child vbox2.Gtk.Box+BoxChild
   this.radiobuttonEmpty = new global::Gtk.RadioButton ("Empty layout");
   this.radiobuttonEmpty.CanFocus = true;
   this.radiobuttonEmpty.Name = "radiobuttonEmpty";
   this.radiobuttonEmpty.DrawIndicator = true;
   this.radiobuttonEmpty.UseUnderline = true;
   this.radiobuttonEmpty.Group = this.radiobuttonCopy.Group;
   this.vbox2.Add (this.radiobuttonEmpty);
   global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.radiobuttonEmpty]));
   w6.Position = 2;
   w6.Expand = false;
   w6.Fill = false;
   w1.Add (this.vbox2);
   global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
   w7.Position = 0;
   w7.Expand = false;
   w7.Fill = false;
   // Internal child Docking.Components.NewLayout.ActionArea
   global::Gtk.HButtonBox w8 = this.ActionArea;
   w8.Name = "dialog1_ActionArea";
   w8.Spacing = 10;
   w8.BorderWidth = ((uint)(5));
   w8.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
   // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
   this.buttonCancel = new global::Gtk.Button ();
   this.buttonCancel.CanDefault = true;
   this.buttonCancel.CanFocus = true;
   this.buttonCancel.Name = "buttonCancel";
   this.buttonCancel.UseStock = true;
   this.buttonCancel.UseUnderline = true;
   this.buttonCancel.Label = "gtk-cancel";
   this.AddActionWidget (this.buttonCancel, -6);
   global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.buttonCancel]));
   w9.Expand = false;
   w9.Fill = false;
   // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
   this.buttonOk = new global::Gtk.Button ();
   this.buttonOk.Sensitive = false;
   this.buttonOk.CanDefault = true;
   this.buttonOk.CanFocus = true;
   this.buttonOk.Name = "buttonOk";
   this.buttonOk.UseStock = true;
   this.buttonOk.UseUnderline = true;
   this.buttonOk.Label = "gtk-ok";
   this.AddActionWidget (this.buttonOk, -5);
   global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w8 [this.buttonOk]));
   w10.Position = 1;
   w10.Expand = false;
   w10.Fill = false;
   if ((this.Child != null)) {
    this.Child.ShowAll ();
   }
   this.DefaultWidth = 406;
   this.DefaultHeight = 141;
   this.buttonOk.HasDefault = true;
   this.Show ();
   this.entryLayoutName.Changed += new global::System.EventHandler (this.OnEntryLayoutNameChanged);
   this.radiobuttonEmpty.Toggled += new global::System.EventHandler (this.OnRadiobuttonEmptyToggled);
  }
 }
}
