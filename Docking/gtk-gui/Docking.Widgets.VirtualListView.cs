
// This file has been generated by the GUI designer. Do not modify.
namespace Docking.Widgets
{
	public partial class VirtualListView
	{
		private global::Gtk.VBox vbox1;
		
		private global::Docking.Widgets.Find findwidget;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.DrawingArea drawingarea;
		
		private global::Gtk.VScrollbar vscrollbar1;
		
		private global::Gtk.HScrollbar hscrollbar1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Docking.Widgets.VirtualListView
			global::Stetic.BinContainer.Attach (this);
			this.Events = ((global::Gdk.EventMask)(3072));
			this.ExtensionEvents = ((global::Gdk.ExtensionMode)(1));
			this.Name = "Docking.Widgets.VirtualListView";
			// Container child Docking.Widgets.VirtualListView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.findwidget = new global::Docking.Widgets.Find ();
			this.findwidget.Events = ((global::Gdk.EventMask)(256));
			this.findwidget.Name = "findwidget";
			this.vbox1.Add (this.findwidget);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.findwidget]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.drawingarea = new global::Gtk.DrawingArea ();
			this.drawingarea.CanFocus = true;
			this.drawingarea.Events = ((global::Gdk.EventMask)(2116868));
			this.drawingarea.ExtensionEvents = ((global::Gdk.ExtensionMode)(1));
			this.drawingarea.Name = "drawingarea";
			this.hbox2.Add (this.drawingarea);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.drawingarea]));
			w2.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vscrollbar1 = new global::Gtk.VScrollbar (null);
			this.vscrollbar1.Name = "vscrollbar1";
			this.vscrollbar1.Adjustment.Upper = 100D;
			this.vscrollbar1.Adjustment.PageIncrement = 10D;
			this.vscrollbar1.Adjustment.PageSize = 10D;
			this.vscrollbar1.Adjustment.StepIncrement = 1D;
			this.hbox2.Add (this.vscrollbar1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vscrollbar1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w4.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hscrollbar1 = new global::Gtk.HScrollbar (null);
			this.hscrollbar1.Name = "hscrollbar1";
			this.hscrollbar1.Adjustment.Upper = 100D;
			this.hscrollbar1.Adjustment.PageIncrement = 10D;
			this.hscrollbar1.Adjustment.PageSize = 10D;
			this.hscrollbar1.Adjustment.StepIncrement = 1D;
			this.vbox1.Add (this.hscrollbar1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hscrollbar1]));
			w5.Position = 2;
			w5.Expand = false;
			w5.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.drawingarea.ExposeEvent += new global::Gtk.ExposeEventHandler (this.OnDrawingareaExposeEvent);
			this.vscrollbar1.ValueChanged += new global::System.EventHandler (this.OnVscrollbar1ValueChanged);
			this.hscrollbar1.ValueChanged += new global::System.EventHandler (this.OnHscrollbar1ValueChanged);
		}
	}
}
