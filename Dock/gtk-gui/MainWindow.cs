
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action undoAction;
	private global::Gtk.Action QuitAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar3;
	private global::Gtk.Toolbar toolbar1;
	private global::MonoDevelop.Components.Docking.DockFrame theDockFrame;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.undoAction = new global::Gtk.Action ("undoAction", null, null, "gtk-undo");
		w1.Add (this.undoAction, null);
		this.QuitAction = new global::Gtk.Action ("QuitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, null);
		this.QuitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
		w1.Add (this.QuitAction, "<Primary><Mod2>q");
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar3'><menu name='FileAction' action='FileAction'><menuitem name='QuitAction' action='QuitAction'/></menu></menubar></ui>");
		this.menubar3 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar3")));
		this.menubar3.Name = "menubar3";
		this.vbox1.Add (this.menubar3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar3]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='undoAction' action='undoAction'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.vbox1.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.theDockFrame = new global::MonoDevelop.Components.Docking.DockFrame ();
		this.theDockFrame.Name = "theDockFrame";
		this.theDockFrame.CompactGuiLevel = 0;
		this.theDockFrame.HandleSize = 0;
		this.theDockFrame.HandlePadding = 0;
		this.theDockFrame.DefaultItemWidth = 0;
		this.theDockFrame.DefaultItemHeight = 0;
		this.theDockFrame.AutoShowDelay = ((uint)(0));
		this.theDockFrame.AutoHideDelay = ((uint)(0));
		this.vbox1.Add (this.theDockFrame);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.theDockFrame]));
		w4.Position = 2;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.QuitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
	}
}
