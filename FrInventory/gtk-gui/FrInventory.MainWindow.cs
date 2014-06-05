
// This file has been generated by the GUI designer. Do not modify.
namespace FrInventory
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action openAction;

		private global::Gtk.Action indexAction;

		private global::Gtk.Action sortAscendingAction;

		private global::Gtk.Action dialogInfoAction;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Toolbar btn_OpenDB;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Image image1;

		private global::Gtk.Entry tbox_Search;

		private global::Gtk.HBox hbox4;

		private global::Gtk.VBox vbox4;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView LocationsGrid;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Entry tbox_Location;

		private global::Gtk.Button btn_AddLocation;

		private global::Gtk.Button btn_RemoveLocation;

		private global::Gtk.VBox vbox5;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gtk.TreeView ContainersGrid;

		private global::Gtk.HBox hbox7;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Entry tbox_container;

		private global::Gtk.Button btn_AddContainer;

		private global::Gtk.Button btn_RemoveContainer;

		private global::Gtk.VBox vbox6;

		private global::Gtk.ScrolledWindow GtkScrolledWindow2;

		private global::Gtk.TreeView ItemsGrid;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Entry tbox_item;

		private global::Gtk.Button btn_AddItem;

		private global::Gtk.Button btn_RemoveItem;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget FrInventory.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("Open DB"), global::Mono.Unix.Catalog.GetString ("Open DB"), "gtk-open");
			this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open DB");
			w1.Add (this.openAction, null);
			this.indexAction = new global::Gtk.Action ("indexAction", global::Mono.Unix.Catalog.GetString ("Compact DB"), global::Mono.Unix.Catalog.GetString ("Compact DB"), "gtk-index");
			this.indexAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Compact DB");
			w1.Add (this.indexAction, null);
			this.sortAscendingAction = new global::Gtk.Action ("sortAscendingAction", global::Mono.Unix.Catalog.GetString ("Import iOwn DB"), global::Mono.Unix.Catalog.GetString ("Import iOwn DB"), "gtk-sort-ascending");
			this.sortAscendingAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Import iOwn DB");
			w1.Add (this.sortAscendingAction, null);
			this.dialogInfoAction = new global::Gtk.Action ("dialogInfoAction", global::Mono.Unix.Catalog.GetString ("info"), global::Mono.Unix.Catalog.GetString ("Info"), "gtk-dialog-info");
			this.dialogInfoAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("info");
			w1.Add (this.dialogInfoAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "FrInventory.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("FrInventory Alpha");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "stock_weather-snow", global::Gtk.IconSize.SmallToolbar);
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Container child FrInventory.MainWindow.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><toolbar name='btn_OpenDB'><toolitem name='openAction' action='openAction'/><toolitem name='indexAction' action='indexAction'/><toolitem name='sortAscendingAction' action='sortAscendingAction'/><toolitem name='dialogInfoAction' action='dialogInfoAction'/></toolbar></ui>");
			this.btn_OpenDB = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/btn_OpenDB")));
			this.btn_OpenDB.Name = "btn_OpenDB";
			this.btn_OpenDB.ShowArrow = false;
			this.btn_OpenDB.ToolbarStyle = ((global::Gtk.ToolbarStyle)(0));
			this.hbox3.Add (this.btn_OpenDB);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.btn_OpenDB]));
			w2.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.image1 = new global::Gtk.Image ();
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-find", global::Gtk.IconSize.Menu);
			this.hbox5.Add (this.image1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.image1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.tbox_Search = new global::Gtk.Entry ();
			this.tbox_Search.CanFocus = true;
			this.tbox_Search.Name = "tbox_Search";
			this.tbox_Search.IsEditable = true;
			this.tbox_Search.InvisibleChar = '•';
			this.hbox5.Add (this.tbox_Search);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.tbox_Search]));
			w4.Position = 1;
			this.hbox3.Add (this.hbox5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.hbox5]));
			w5.Position = 1;
			this.vbox3.Add (this.hbox3);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Homogeneous = true;
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.LocationsGrid = new global::Gtk.TreeView ();
			this.LocationsGrid.CanFocus = true;
			this.LocationsGrid.Name = "LocationsGrid";
			this.GtkScrolledWindow.Add (this.LocationsGrid);
			this.vbox4.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.GtkScrolledWindow]));
			w8.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.tbox_Location = new global::Gtk.Entry ();
			this.tbox_Location.CanFocus = true;
			this.tbox_Location.Name = "tbox_Location";
			this.tbox_Location.IsEditable = true;
			this.tbox_Location.InvisibleChar = '•';
			this.hbox9.Add (this.tbox_Location);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.tbox_Location]));
			w9.Position = 0;
			// Container child hbox9.Gtk.Box+BoxChild
			this.btn_AddLocation = new global::Gtk.Button ();
			this.btn_AddLocation.CanFocus = true;
			this.btn_AddLocation.Name = "btn_AddLocation";
			this.btn_AddLocation.UseUnderline = true;
			// Container child btn_AddLocation.Gtk.Container+ContainerChild
			global::Gtk.Alignment w10 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w11 = new global::Gtk.HBox ();
			w11.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w11.Add (w12);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w14 = new global::Gtk.Label ();
			w11.Add (w14);
			w10.Add (w11);
			this.btn_AddLocation.Add (w10);
			this.hbox9.Add (this.btn_AddLocation);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.btn_AddLocation]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.btn_RemoveLocation = new global::Gtk.Button ();
			this.btn_RemoveLocation.CanFocus = true;
			this.btn_RemoveLocation.Name = "btn_RemoveLocation";
			this.btn_RemoveLocation.UseUnderline = true;
			// Container child btn_RemoveLocation.Gtk.Container+ContainerChild
			global::Gtk.Alignment w19 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w20 = new global::Gtk.HBox ();
			w20.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w20.Add (w21);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w23 = new global::Gtk.Label ();
			w20.Add (w23);
			w19.Add (w20);
			this.btn_RemoveLocation.Add (w19);
			this.hbox9.Add (this.btn_RemoveLocation);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.btn_RemoveLocation]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox4.Add (this.hbox9);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox9]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox4.Add (this.vbox4);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox4]));
			w29.Position = 0;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ContainersGrid = new global::Gtk.TreeView ();
			this.ContainersGrid.CanFocus = true;
			this.ContainersGrid.Name = "ContainersGrid";
			this.GtkScrolledWindow1.Add (this.ContainersGrid);
			this.vbox5.Add (this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.GtkScrolledWindow1]));
			w31.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.tbox_container = new global::Gtk.Entry ();
			this.tbox_container.CanFocus = true;
			this.tbox_container.Name = "tbox_container";
			this.tbox_container.IsEditable = true;
			this.tbox_container.InvisibleChar = '•';
			this.hbox1.Add (this.tbox_container);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.tbox_container]));
			w32.Position = 0;
			this.hbox7.Add (this.hbox1);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.hbox1]));
			w33.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.btn_AddContainer = new global::Gtk.Button ();
			this.btn_AddContainer.CanFocus = true;
			this.btn_AddContainer.Name = "btn_AddContainer";
			this.btn_AddContainer.UseUnderline = true;
			// Container child btn_AddContainer.Gtk.Container+ContainerChild
			global::Gtk.Alignment w34 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w35 = new global::Gtk.HBox ();
			w35.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w36 = new global::Gtk.Image ();
			w36.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w35.Add (w36);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w38 = new global::Gtk.Label ();
			w35.Add (w38);
			w34.Add (w35);
			this.btn_AddContainer.Add (w34);
			this.hbox7.Add (this.btn_AddContainer);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.btn_AddContainer]));
			w42.Position = 1;
			w42.Expand = false;
			w42.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.btn_RemoveContainer = new global::Gtk.Button ();
			this.btn_RemoveContainer.CanFocus = true;
			this.btn_RemoveContainer.Name = "btn_RemoveContainer";
			this.btn_RemoveContainer.UseUnderline = true;
			// Container child btn_RemoveContainer.Gtk.Container+ContainerChild
			global::Gtk.Alignment w43 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w44 = new global::Gtk.HBox ();
			w44.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w45 = new global::Gtk.Image ();
			w45.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w44.Add (w45);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w47 = new global::Gtk.Label ();
			w44.Add (w47);
			w43.Add (w44);
			this.btn_RemoveContainer.Add (w43);
			this.hbox7.Add (this.btn_RemoveContainer);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.btn_RemoveContainer]));
			w51.Position = 2;
			w51.Expand = false;
			w51.Fill = false;
			this.vbox5.Add (this.hbox7);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.hbox7]));
			w52.Position = 1;
			w52.Expand = false;
			w52.Fill = false;
			this.hbox4.Add (this.vbox5);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox5]));
			w53.Position = 1;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.ItemsGrid = new global::Gtk.TreeView ();
			this.ItemsGrid.CanFocus = true;
			this.ItemsGrid.Name = "ItemsGrid";
			this.GtkScrolledWindow2.Add (this.ItemsGrid);
			this.vbox6.Add (this.GtkScrolledWindow2);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.GtkScrolledWindow2]));
			w55.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.tbox_item = new global::Gtk.Entry ();
			this.tbox_item.CanFocus = true;
			this.tbox_item.Name = "tbox_item";
			this.tbox_item.IsEditable = true;
			this.tbox_item.InvisibleChar = '•';
			this.hbox8.Add (this.tbox_item);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.tbox_item]));
			w56.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btn_AddItem = new global::Gtk.Button ();
			this.btn_AddItem.CanFocus = true;
			this.btn_AddItem.Name = "btn_AddItem";
			this.btn_AddItem.UseUnderline = true;
			// Container child btn_AddItem.Gtk.Container+ContainerChild
			global::Gtk.Alignment w57 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w58 = new global::Gtk.HBox ();
			w58.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w59 = new global::Gtk.Image ();
			w59.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w58.Add (w59);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w61 = new global::Gtk.Label ();
			w58.Add (w61);
			w57.Add (w58);
			this.btn_AddItem.Add (w57);
			this.hbox8.Add (this.btn_AddItem);
			global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.btn_AddItem]));
			w65.Position = 1;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btn_RemoveItem = new global::Gtk.Button ();
			this.btn_RemoveItem.CanFocus = true;
			this.btn_RemoveItem.Name = "btn_RemoveItem";
			this.btn_RemoveItem.UseUnderline = true;
			// Container child btn_RemoveItem.Gtk.Container+ContainerChild
			global::Gtk.Alignment w66 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w67 = new global::Gtk.HBox ();
			w67.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w68 = new global::Gtk.Image ();
			w68.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			w67.Add (w68);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w70 = new global::Gtk.Label ();
			w67.Add (w70);
			w66.Add (w67);
			this.btn_RemoveItem.Add (w66);
			this.hbox8.Add (this.btn_RemoveItem);
			global::Gtk.Box.BoxChild w74 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.btn_RemoveItem]));
			w74.Position = 2;
			w74.Expand = false;
			w74.Fill = false;
			this.vbox6.Add (this.hbox8);
			global::Gtk.Box.BoxChild w75 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.hbox8]));
			w75.Position = 1;
			w75.Expand = false;
			w75.Fill = false;
			this.hbox4.Add (this.vbox6);
			global::Gtk.Box.BoxChild w76 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox6]));
			w76.Position = 2;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w77 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
			w77.Position = 1;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 851;
			this.DefaultHeight = 485;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.openAction.Activated += new global::System.EventHandler (this.OnOpenActionActivated);
			this.dialogInfoAction.Activated += new global::System.EventHandler (this.OnDialogInfoActionActivated);
			this.tbox_Search.TextInserted += new global::Gtk.TextInsertedHandler (this.OnTboxSearchTextInserted);
			this.tbox_Search.TextDeleted += new global::Gtk.TextDeletedHandler (this.OnTboxSearchTextDeleted);
			this.LocationsGrid.CursorChanged += new global::System.EventHandler (this.OnLocationsGridCursorChanged);
			this.LocationsGrid.FocusInEvent += new global::Gtk.FocusInEventHandler (this.OnLocationsGridFocusInEvent);
			this.btn_AddLocation.Clicked += new global::System.EventHandler (this.OnBtnAddLocationClicked);
			this.btn_RemoveLocation.Clicked += new global::System.EventHandler (this.OnBtnRemoveLocationClicked);
			this.ContainersGrid.CursorChanged += new global::System.EventHandler (this.OnContainersGridCursorChanged);
			this.ContainersGrid.FocusInEvent += new global::Gtk.FocusInEventHandler (this.OnContainersGridFocusInEvent);
			this.btn_AddContainer.Clicked += new global::System.EventHandler (this.OnBtnAddContainerClicked);
			this.btn_RemoveContainer.Clicked += new global::System.EventHandler (this.OnBtnRemoveContainerClicked);
			this.ItemsGrid.FocusInEvent += new global::Gtk.FocusInEventHandler (this.OnItemsGridFocusInEvent);
			this.ItemsGrid.CursorChanged += new global::System.EventHandler (this.OnItemsGridCursorChanged);
			this.btn_AddItem.Clicked += new global::System.EventHandler (this.OnBtnAddItemClicked);
			this.btn_RemoveItem.Clicked += new global::System.EventHandler (this.OnBtnRemoveItemClicked);
		}
	}
}