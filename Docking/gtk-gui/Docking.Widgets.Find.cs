
// This file has been generated by the GUI designer. Do not modify.
namespace Docking.Widgets
{
	public partial class Find
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button buttonLast;
		
		private global::Gtk.Entry entryFind;
		
		private global::Gtk.Label labelStatus;
		
		private global::Gtk.Button buttonPrev;
		
		private global::Gtk.Button buttonNext;
		
		private global::Gtk.Button buttonClear;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Docking.Widgets.Find
			global::Stetic.BinContainer.Attach (this);
			this.Events = ((global::Gdk.EventMask)(3072));
			this.Name = "Docking.Widgets.Find";
			// Container child Docking.Widgets.Find.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonLast = new global::Gtk.Button ();
			this.buttonLast.CanFocus = true;
			this.buttonLast.Name = "buttonLast";
			this.buttonLast.UseUnderline = true;
			this.buttonLast.Label = "~";
			this.hbox1.Add (this.buttonLast);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonLast]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryFind = new global::Gtk.Entry ();
			this.entryFind.CanFocus = true;
			this.entryFind.Name = "entryFind";
			this.entryFind.IsEditable = true;
			this.entryFind.InvisibleChar = '●';
			this.hbox1.Add (this.entryFind);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryFind]));
			w2.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelStatus = new global::Gtk.Label ();
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.LabelProp = "status";
			this.labelStatus.Justify = ((global::Gtk.Justification)(2));
			this.hbox1.Add (this.labelStatus);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labelStatus]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonPrev = new global::Gtk.Button ();
			this.buttonPrev.CanFocus = true;
			this.buttonPrev.Name = "buttonPrev";
			this.buttonPrev.UseUnderline = true;
			this.buttonPrev.Label = "<";
			this.hbox1.Add (this.buttonPrev);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonPrev]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonNext = new global::Gtk.Button ();
			this.buttonNext.CanFocus = true;
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.UseUnderline = true;
			this.buttonNext.Label = ">";
			this.hbox1.Add (this.buttonNext);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonNext]));
			w5.Position = 4;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonClear = new global::Gtk.Button ();
			this.buttonClear.CanFocus = true;
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.UseUnderline = true;
			this.buttonClear.Label = "*";
			this.hbox1.Add (this.buttonClear);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonClear]));
			w6.Position = 5;
			w6.Expand = false;
			w6.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
