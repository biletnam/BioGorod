
// This file has been generated by the GUI designer. Do not modify.
namespace BioGorod.Dialogs.Client
{
	public partial class CounterpartyDlg
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.Button buttonCancel;
		
		private global::QSWidgetLib.MenuButton menuActions;
		
		private global::Gtk.HSeparator hseparator1;
		
		private global::Gtk.HBox hbox19;
		
		private global::Gtk.RadioButton radioInfo;
		
		private global::Gtk.RadioButton radioContacts;
		
		private global::Gtk.RadioButton radioDetails;
		
		private global::Gtk.RadioButton radioContactPersons;
		
		private global::Gtk.RadioButton radioContracts;
		
		private global::Gtk.RadioButton radioDeliveryPoint;
		
		private global::Gtk.Notebook notebook1;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow4;
		
		private global::Gtk.Table table1;
		
		private global::QSOrmProject.yLegalName datalegalname1;
		
		private global::Gamma.GtkWidgets.yEntry entryFIO;
		
		private global::Gamma.GtkWidgets.yEntry entryFullName;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow6;
		
		private global::Gamma.GtkWidgets.yTextView dataComment;
		
		private global::Gtk.HBox hbox17;
		
		private global::Gamma.GtkWidgets.yCheckButton ycheckIsArchived;
		
		private global::Gtk.Label label31;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.Label labelFIO;
		
		private global::Gtk.Label labelFullName;
		
		private global::Gtk.Label labelShort;
		
		private global::Gtk.VBox vboxCooperation;
		
		private global::Gamma.GtkWidgets.yCheckButton checkCustomer;
		
		private global::Gamma.GtkWidgets.yCheckButton checkSupplier;
		
		private global::Gamma.GtkWidgets.yCheckButton checkPartner;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Table datatable2;
		
		private global::QSContacts.EmailsView emailsView;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.Label label18;
		
		private global::QSContacts.PhonesView phonesView;
		
		private global::Gtk.Label label20;
		
		private global::Gtk.VBox vbox6;
		
		private global::Gtk.Table datatable4;
		
		private global::Gamma.GtkWidgets.yEntry entryJurAddress;
		
		private global::Gtk.Label label17;
		
		private global::Gtk.Label label27;
		
		private global::Gtk.Label label28;
		
		private global::Gtk.Label label29;
		
		private global::Gtk.Label label32;
		
		private global::Gtk.Label label7;
		
		private global::Gamma.Widgets.yValidatedEntry validatedINN;
		
		private global::Gamma.Widgets.yValidatedEntry validatedKPP;
		
		private global::Gamma.GtkWidgets.yEntry yentrySignBaseOf;
		
		private global::Gamma.GtkWidgets.yEntry yentrySignFIO;
		
		private global::Gamma.GtkWidgets.yEntry yentrySignPost;
		
		private global::QSBanks.AccountsView accountsView;
		
		private global::Gtk.Label label21;
		
		private global::BioGorod.Dialogs.Client.CounterpartyContactsView contactsview1;
		
		private global::Gtk.Label label24;
		
		private global::BioGorod.Dialogs.Client.CounterpartyContractsView counterpartyContractsView;
		
		private global::Gtk.Label label34;
		
		private global::Gtk.VBox vbox9;
		
		private global::BioGorod.Dialogs.Client.CounterpartyAddressesView deliveryPointView;
		
		private global::Gtk.Label label40;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BioGorod.Dialogs.Client.CounterpartyDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BioGorod.Dialogs.Client.CounterpartyDlg";
			// Container child BioGorod.Dialogs.Client.CounterpartyDlg.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.HeightRequest = 400;
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-floppy", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отмена");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox1.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.menuActions = new global::QSWidgetLib.MenuButton ();
			this.menuActions.CanFocus = true;
			this.menuActions.Name = "menuActions";
			this.menuActions.UseUnderline = true;
			this.menuActions.UseMarkup = false;
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Vodovoz.icons.buttons.menu.png");
			this.menuActions.Image = w5;
			this.hbox1.Add (this.menuActions);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.menuActions]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator1]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox19 = new global::Gtk.HBox ();
			this.hbox19.Name = "hbox19";
			this.hbox19.Spacing = 6;
			// Container child hbox19.Gtk.Box+BoxChild
			this.radioInfo = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Информация"));
			this.radioInfo.CanFocus = true;
			this.radioInfo.Name = "radioInfo";
			this.radioInfo.DrawIndicator = false;
			this.radioInfo.UseUnderline = true;
			this.radioInfo.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.hbox19.Add (this.radioInfo);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.radioInfo]));
			w9.Position = 0;
			// Container child hbox19.Gtk.Box+BoxChild
			this.radioContacts = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Контакты"));
			this.radioContacts.CanFocus = true;
			this.radioContacts.Name = "radioContacts";
			this.radioContacts.DrawIndicator = false;
			this.radioContacts.UseUnderline = true;
			this.radioContacts.Group = this.radioInfo.Group;
			this.hbox19.Add (this.radioContacts);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.radioContacts]));
			w10.Position = 1;
			// Container child hbox19.Gtk.Box+BoxChild
			this.radioDetails = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Реквизиты"));
			this.radioDetails.CanFocus = true;
			this.radioDetails.Name = "radioDetails";
			this.radioDetails.DrawIndicator = false;
			this.radioDetails.UseUnderline = true;
			this.radioDetails.Group = this.radioInfo.Group;
			this.hbox19.Add (this.radioDetails);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.radioDetails]));
			w11.Position = 2;
			// Container child hbox19.Gtk.Box+BoxChild
			this.radioContactPersons = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Контактные лица"));
			this.radioContactPersons.CanFocus = true;
			this.radioContactPersons.Name = "radioContactPersons";
			this.radioContactPersons.DrawIndicator = false;
			this.radioContactPersons.UseUnderline = true;
			this.radioContactPersons.Group = this.radioInfo.Group;
			this.hbox19.Add (this.radioContactPersons);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.radioContactPersons]));
			w12.Position = 3;
			// Container child hbox19.Gtk.Box+BoxChild
			this.radioContracts = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Договора"));
			this.radioContracts.CanFocus = true;
			this.radioContracts.Name = "radioContracts";
			this.radioContracts.DrawIndicator = false;
			this.radioContracts.UseUnderline = true;
			this.radioContracts.Group = this.radioInfo.Group;
			this.hbox19.Add (this.radioContracts);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.radioContracts]));
			w13.Position = 4;
			// Container child hbox19.Gtk.Box+BoxChild
			this.radioDeliveryPoint = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Адреса объектов"));
			this.radioDeliveryPoint.CanFocus = true;
			this.radioDeliveryPoint.Name = "radioDeliveryPoint";
			this.radioDeliveryPoint.DrawIndicator = false;
			this.radioDeliveryPoint.UseUnderline = true;
			this.radioDeliveryPoint.Group = this.radioInfo.Group;
			this.hbox19.Add (this.radioDeliveryPoint);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.radioDeliveryPoint]));
			w14.Position = 5;
			this.vbox2.Add (this.hbox19);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox19]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			global::Gtk.Viewport w16 = new global::Gtk.Viewport ();
			w16.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(7)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.datalegalname1 = new global::QSOrmProject.yLegalName ();
			this.datalegalname1.Events = ((global::Gdk.EventMask)(256));
			this.datalegalname1.Name = "datalegalname1";
			this.table1.Add (this.datalegalname1);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.datalegalname1]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(4));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryFIO = new global::Gamma.GtkWidgets.yEntry ();
			this.entryFIO.CanFocus = true;
			this.entryFIO.Name = "entryFIO";
			this.entryFIO.IsEditable = true;
			this.entryFIO.InvisibleChar = '●';
			this.table1.Add (this.entryFIO);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryFIO]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.LeftAttach = ((uint)(1));
			w18.RightAttach = ((uint)(4));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryFullName = new global::Gamma.GtkWidgets.yEntry ();
			this.entryFullName.CanFocus = true;
			this.entryFullName.Name = "entryFullName";
			this.entryFullName.IsEditable = true;
			this.entryFullName.MaxLength = 300;
			this.entryFullName.InvisibleChar = '●';
			this.table1.Add (this.entryFullName);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryFullName]));
			w19.TopAttach = ((uint)(3));
			w19.BottomAttach = ((uint)(4));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow6 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow6.Name = "GtkScrolledWindow6";
			this.GtkScrolledWindow6.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow6.Gtk.Container+ContainerChild
			this.dataComment = new global::Gamma.GtkWidgets.yTextView ();
			this.dataComment.CanFocus = true;
			this.dataComment.Name = "dataComment";
			this.GtkScrolledWindow6.Add (this.dataComment);
			this.table1.Add (this.GtkScrolledWindow6);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkScrolledWindow6]));
			w21.TopAttach = ((uint)(6));
			w21.BottomAttach = ((uint)(7));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox17 = new global::Gtk.HBox ();
			this.hbox17.Name = "hbox17";
			this.hbox17.Spacing = 6;
			// Container child hbox17.Gtk.Box+BoxChild
			this.ycheckIsArchived = new global::Gamma.GtkWidgets.yCheckButton ();
			global::Gtk.Tooltips w22 = new Gtk.Tooltips ();
			w22.SetTip (this.ycheckIsArchived, "Больше не работаем с этим клиентом", "Больше не работаем с этим клиентом");
			this.ycheckIsArchived.CanFocus = true;
			this.ycheckIsArchived.Name = "ycheckIsArchived";
			this.ycheckIsArchived.Label = global::Mono.Unix.Catalog.GetString ("Архивный");
			this.ycheckIsArchived.DrawIndicator = true;
			this.ycheckIsArchived.UseUnderline = true;
			this.hbox17.Add (this.ycheckIsArchived);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox17 [this.ycheckIsArchived]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			this.table1.Add (this.hbox17);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox17]));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label31 = new global::Gtk.Label ();
			this.label31.Name = "label31";
			this.label31.Xalign = 1F;
			this.label31.LabelProp = global::Mono.Unix.Catalog.GetString ("Внутренний\nкомментарий:");
			this.label31.Justify = ((global::Gtk.Justification)(1));
			this.table1.Add (this.label31);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.label31]));
			w25.TopAttach = ((uint)(6));
			w25.BottomAttach = ((uint)(7));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Тип контрагента:");
			this.table1.Add (this.label9);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1 [this.label9]));
			w26.TopAttach = ((uint)(4));
			w26.BottomAttach = ((uint)(5));
			w26.LeftAttach = ((uint)(2));
			w26.RightAttach = ((uint)(3));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelFIO = new global::Gtk.Label ();
			this.labelFIO.Name = "labelFIO";
			this.labelFIO.Xalign = 1F;
			this.labelFIO.LabelProp = global::Mono.Unix.Catalog.GetString ("Ф.И.О.:");
			this.table1.Add (this.labelFIO);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelFIO]));
			w27.TopAttach = ((uint)(1));
			w27.BottomAttach = ((uint)(2));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelFullName = new global::Gtk.Label ();
			this.labelFullName.Name = "labelFullName";
			this.labelFullName.Xalign = 1F;
			this.labelFullName.LabelProp = global::Mono.Unix.Catalog.GetString ("Полное наименование:");
			this.table1.Add (this.labelFullName);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelFullName]));
			w28.TopAttach = ((uint)(3));
			w28.BottomAttach = ((uint)(4));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelShort = new global::Gtk.Label ();
			this.labelShort.Name = "labelShort";
			this.labelShort.Xalign = 1F;
			this.labelShort.LabelProp = global::Mono.Unix.Catalog.GetString ("Наименование:");
			this.table1.Add (this.labelShort);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelShort]));
			w29.TopAttach = ((uint)(2));
			w29.BottomAttach = ((uint)(3));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.vboxCooperation = new global::Gtk.VBox ();
			this.vboxCooperation.Name = "vboxCooperation";
			this.vboxCooperation.Spacing = 1;
			// Container child vboxCooperation.Gtk.Box+BoxChild
			this.checkCustomer = new global::Gamma.GtkWidgets.yCheckButton ();
			this.checkCustomer.CanFocus = true;
			this.checkCustomer.Name = "checkCustomer";
			this.checkCustomer.Label = global::Mono.Unix.Catalog.GetString ("Покупатель");
			this.checkCustomer.DrawIndicator = true;
			this.checkCustomer.UseUnderline = true;
			this.vboxCooperation.Add (this.checkCustomer);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vboxCooperation [this.checkCustomer]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child vboxCooperation.Gtk.Box+BoxChild
			this.checkSupplier = new global::Gamma.GtkWidgets.yCheckButton ();
			this.checkSupplier.CanFocus = true;
			this.checkSupplier.Name = "checkSupplier";
			this.checkSupplier.Label = global::Mono.Unix.Catalog.GetString ("Поставщик");
			this.checkSupplier.DrawIndicator = true;
			this.checkSupplier.UseUnderline = true;
			this.vboxCooperation.Add (this.checkSupplier);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vboxCooperation [this.checkSupplier]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vboxCooperation.Gtk.Box+BoxChild
			this.checkPartner = new global::Gamma.GtkWidgets.yCheckButton ();
			this.checkPartner.CanFocus = true;
			this.checkPartner.Name = "checkPartner";
			this.checkPartner.Label = global::Mono.Unix.Catalog.GetString ("Партнер");
			this.checkPartner.DrawIndicator = true;
			this.checkPartner.UseUnderline = true;
			this.vboxCooperation.Add (this.checkPartner);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vboxCooperation [this.checkPartner]));
			w32.Position = 2;
			w32.Expand = false;
			w32.Fill = false;
			this.table1.Add (this.vboxCooperation);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1 [this.vboxCooperation]));
			w33.TopAttach = ((uint)(4));
			w33.BottomAttach = ((uint)(6));
			w33.LeftAttach = ((uint)(3));
			w33.RightAttach = ((uint)(4));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(0));
			w16.Add (this.table1);
			this.GtkScrolledWindow4.Add (w16);
			this.notebook1.Add (this.GtkScrolledWindow4);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Информация");
			this.notebook1.SetTabLabel (this.GtkScrolledWindow4, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.datatable2 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.datatable2.Name = "datatable2";
			this.datatable2.RowSpacing = ((uint)(6));
			this.datatable2.ColumnSpacing = ((uint)(6));
			this.datatable2.BorderWidth = ((uint)(6));
			// Container child datatable2.Gtk.Table+TableChild
			this.emailsView = new global::QSContacts.EmailsView ();
			this.emailsView.Events = ((global::Gdk.EventMask)(256));
			this.emailsView.Name = "emailsView";
			this.datatable2.Add (this.emailsView);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.datatable2 [this.emailsView]));
			w37.TopAttach = ((uint)(1));
			w37.BottomAttach = ((uint)(2));
			w37.LeftAttach = ((uint)(1));
			w37.RightAttach = ((uint)(2));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable2.Gtk.Table+TableChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Общий e-mail:");
			this.datatable2.Add (this.label11);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.datatable2 [this.label11]));
			w38.TopAttach = ((uint)(1));
			w38.BottomAttach = ((uint)(2));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable2.Gtk.Table+TableChild
			this.label18 = new global::Gtk.Label ();
			this.label18.Name = "label18";
			this.label18.Xalign = 1F;
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("Общие телефоны:");
			this.datatable2.Add (this.label18);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.datatable2 [this.label18]));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable2.Gtk.Table+TableChild
			this.phonesView = new global::QSContacts.PhonesView ();
			this.phonesView.Events = ((global::Gdk.EventMask)(256));
			this.phonesView.Name = "phonesView";
			this.datatable2.Add (this.phonesView);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.datatable2 [this.phonesView]));
			w40.LeftAttach = ((uint)(1));
			w40.RightAttach = ((uint)(2));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.datatable2);
			global::Gtk.Notebook.NotebookChild w41 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.datatable2]));
			w41.Position = 1;
			// Notebook tab
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("Контакты");
			this.notebook1.SetTabLabel (this.datatable2, this.label20);
			this.label20.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			this.vbox6.BorderWidth = ((uint)(6));
			// Container child vbox6.Gtk.Box+BoxChild
			this.datatable4 = new global::Gtk.Table (((uint)(3)), ((uint)(4)), false);
			this.datatable4.Name = "datatable4";
			this.datatable4.RowSpacing = ((uint)(6));
			this.datatable4.ColumnSpacing = ((uint)(6));
			// Container child datatable4.Gtk.Table+TableChild
			this.entryJurAddress = new global::Gamma.GtkWidgets.yEntry ();
			this.entryJurAddress.CanFocus = true;
			this.entryJurAddress.Name = "entryJurAddress";
			this.entryJurAddress.IsEditable = true;
			this.entryJurAddress.InvisibleChar = '●';
			this.datatable4.Add (this.entryJurAddress);
			global::Gtk.Table.TableChild w42 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.entryJurAddress]));
			w42.TopAttach = ((uint)(2));
			w42.BottomAttach = ((uint)(3));
			w42.LeftAttach = ((uint)(1));
			w42.RightAttach = ((uint)(2));
			w42.XOptions = ((global::Gtk.AttachOptions)(4));
			w42.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.Xalign = 1F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("В лице:");
			this.datatable4.Add (this.label17);
			global::Gtk.Table.TableChild w43 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.label17]));
			w43.TopAttach = ((uint)(1));
			w43.BottomAttach = ((uint)(2));
			w43.LeftAttach = ((uint)(2));
			w43.RightAttach = ((uint)(3));
			w43.XOptions = ((global::Gtk.AttachOptions)(4));
			w43.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.label27 = new global::Gtk.Label ();
			this.label27.Name = "label27";
			this.label27.Xalign = 1F;
			this.label27.LabelProp = global::Mono.Unix.Catalog.GetString ("ИНН:");
			this.datatable4.Add (this.label27);
			global::Gtk.Table.TableChild w44 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.label27]));
			w44.XOptions = ((global::Gtk.AttachOptions)(4));
			w44.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.label28 = new global::Gtk.Label ();
			this.label28.Name = "label28";
			this.label28.Xalign = 1F;
			this.label28.LabelProp = global::Mono.Unix.Catalog.GetString ("КПП:");
			this.datatable4.Add (this.label28);
			global::Gtk.Table.TableChild w45 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.label28]));
			w45.TopAttach = ((uint)(1));
			w45.BottomAttach = ((uint)(2));
			w45.XOptions = ((global::Gtk.AttachOptions)(4));
			w45.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.label29 = new global::Gtk.Label ();
			this.label29.Name = "label29";
			this.label29.Xalign = 1F;
			this.label29.LabelProp = global::Mono.Unix.Catalog.GetString ("Юр. адрес:");
			this.datatable4.Add (this.label29);
			global::Gtk.Table.TableChild w46 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.label29]));
			w46.TopAttach = ((uint)(2));
			w46.BottomAttach = ((uint)(3));
			w46.XOptions = ((global::Gtk.AttachOptions)(4));
			w46.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.label32 = new global::Gtk.Label ();
			this.label32.Name = "label32";
			this.label32.Xalign = 1F;
			this.label32.LabelProp = global::Mono.Unix.Catalog.GetString ("На основании:");
			this.datatable4.Add (this.label32);
			global::Gtk.Table.TableChild w47 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.label32]));
			w47.TopAttach = ((uint)(2));
			w47.BottomAttach = ((uint)(3));
			w47.LeftAttach = ((uint)(2));
			w47.RightAttach = ((uint)(3));
			w47.XOptions = ((global::Gtk.AttachOptions)(4));
			w47.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("ФИО для договора:");
			this.datatable4.Add (this.label7);
			global::Gtk.Table.TableChild w48 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.label7]));
			w48.LeftAttach = ((uint)(2));
			w48.RightAttach = ((uint)(3));
			w48.XOptions = ((global::Gtk.AttachOptions)(4));
			w48.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.validatedINN = new global::Gamma.Widgets.yValidatedEntry ();
			this.validatedINN.CanFocus = true;
			this.validatedINN.Name = "validatedINN";
			this.validatedINN.IsEditable = true;
			this.validatedINN.MaxLength = 12;
			this.validatedINN.InvisibleChar = '●';
			this.datatable4.Add (this.validatedINN);
			global::Gtk.Table.TableChild w49 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.validatedINN]));
			w49.LeftAttach = ((uint)(1));
			w49.RightAttach = ((uint)(2));
			w49.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.validatedKPP = new global::Gamma.Widgets.yValidatedEntry ();
			this.validatedKPP.CanFocus = true;
			this.validatedKPP.Name = "validatedKPP";
			this.validatedKPP.IsEditable = true;
			this.validatedKPP.MaxLength = 9;
			this.validatedKPP.InvisibleChar = '●';
			this.datatable4.Add (this.validatedKPP);
			global::Gtk.Table.TableChild w50 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.validatedKPP]));
			w50.TopAttach = ((uint)(1));
			w50.BottomAttach = ((uint)(2));
			w50.LeftAttach = ((uint)(1));
			w50.RightAttach = ((uint)(2));
			w50.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.yentrySignBaseOf = new global::Gamma.GtkWidgets.yEntry ();
			this.yentrySignBaseOf.CanFocus = true;
			this.yentrySignBaseOf.Name = "yentrySignBaseOf";
			this.yentrySignBaseOf.IsEditable = true;
			this.yentrySignBaseOf.InvisibleChar = '●';
			this.datatable4.Add (this.yentrySignBaseOf);
			global::Gtk.Table.TableChild w51 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.yentrySignBaseOf]));
			w51.TopAttach = ((uint)(2));
			w51.BottomAttach = ((uint)(3));
			w51.LeftAttach = ((uint)(3));
			w51.RightAttach = ((uint)(4));
			w51.XOptions = ((global::Gtk.AttachOptions)(4));
			w51.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.yentrySignFIO = new global::Gamma.GtkWidgets.yEntry ();
			this.yentrySignFIO.CanFocus = true;
			this.yentrySignFIO.Name = "yentrySignFIO";
			this.yentrySignFIO.IsEditable = true;
			this.yentrySignFIO.InvisibleChar = '●';
			this.datatable4.Add (this.yentrySignFIO);
			global::Gtk.Table.TableChild w52 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.yentrySignFIO]));
			w52.LeftAttach = ((uint)(3));
			w52.RightAttach = ((uint)(4));
			w52.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable4.Gtk.Table+TableChild
			this.yentrySignPost = new global::Gamma.GtkWidgets.yEntry ();
			this.yentrySignPost.CanFocus = true;
			this.yentrySignPost.Name = "yentrySignPost";
			this.yentrySignPost.IsEditable = true;
			this.yentrySignPost.InvisibleChar = '●';
			this.datatable4.Add (this.yentrySignPost);
			global::Gtk.Table.TableChild w53 = ((global::Gtk.Table.TableChild)(this.datatable4 [this.yentrySignPost]));
			w53.TopAttach = ((uint)(1));
			w53.BottomAttach = ((uint)(2));
			w53.LeftAttach = ((uint)(3));
			w53.RightAttach = ((uint)(4));
			w53.XOptions = ((global::Gtk.AttachOptions)(4));
			w53.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox6.Add (this.datatable4);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.datatable4]));
			w54.Position = 0;
			w54.Expand = false;
			w54.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.accountsView = new global::QSBanks.AccountsView ();
			this.accountsView.Events = ((global::Gdk.EventMask)(256));
			this.accountsView.Name = "accountsView";
			this.vbox6.Add (this.accountsView);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.accountsView]));
			w55.Position = 1;
			this.notebook1.Add (this.vbox6);
			global::Gtk.Notebook.NotebookChild w56 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox6]));
			w56.Position = 2;
			// Notebook tab
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("Реквизиты");
			this.notebook1.SetTabLabel (this.vbox6, this.label21);
			this.label21.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.contactsview1 = new global::BioGorod.Dialogs.Client.CounterpartyContactsView ();
			this.contactsview1.Events = ((global::Gdk.EventMask)(256));
			this.contactsview1.Name = "contactsview1";
			this.notebook1.Add (this.contactsview1);
			global::Gtk.Notebook.NotebookChild w57 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.contactsview1]));
			w57.Position = 3;
			// Notebook tab
			this.label24 = new global::Gtk.Label ();
			this.label24.Name = "label24";
			this.label24.LabelProp = global::Mono.Unix.Catalog.GetString ("Контактные лица");
			this.notebook1.SetTabLabel (this.contactsview1, this.label24);
			this.label24.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.counterpartyContractsView = new global::BioGorod.Dialogs.Client.CounterpartyContractsView ();
			this.counterpartyContractsView.Events = ((global::Gdk.EventMask)(256));
			this.counterpartyContractsView.Name = "counterpartyContractsView";
			this.notebook1.Add (this.counterpartyContractsView);
			global::Gtk.Notebook.NotebookChild w58 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.counterpartyContractsView]));
			w58.Position = 4;
			// Notebook tab
			this.label34 = new global::Gtk.Label ();
			this.label34.Name = "label34";
			this.label34.LabelProp = global::Mono.Unix.Catalog.GetString ("Договор");
			this.notebook1.SetTabLabel (this.counterpartyContractsView, this.label34);
			this.label34.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			this.vbox9.BorderWidth = ((uint)(6));
			// Container child vbox9.Gtk.Box+BoxChild
			this.deliveryPointView = new global::BioGorod.Dialogs.Client.CounterpartyAddressesView ();
			this.deliveryPointView.Events = ((global::Gdk.EventMask)(256));
			this.deliveryPointView.Name = "deliveryPointView";
			this.vbox9.Add (this.deliveryPointView);
			global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.deliveryPointView]));
			w59.Position = 0;
			this.notebook1.Add (this.vbox9);
			global::Gtk.Notebook.NotebookChild w60 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.vbox9]));
			w60.Position = 5;
			// Notebook tab
			this.label40 = new global::Gtk.Label ();
			this.label40.Name = "label40";
			this.label40.LabelProp = global::Mono.Unix.Catalog.GetString ("Точки доставки");
			this.notebook1.SetTabLabel (this.vbox9, this.label40);
			this.label40.ShowAll ();
			this.vbox2.Add (this.notebook1);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.notebook1]));
			w61.Position = 3;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.radioInfo.Toggled += new global::System.EventHandler (this.OnRadioInfoToggled);
			this.radioContacts.Toggled += new global::System.EventHandler (this.OnRadioContactsToggled);
			this.radioDetails.Toggled += new global::System.EventHandler (this.OnRadioDetailsToggled);
			this.radioContactPersons.Toggled += new global::System.EventHandler (this.OnRadioContactPersonsToggled);
			this.radioContracts.Toggled += new global::System.EventHandler (this.OnRadioContractsToggled);
			this.radioDeliveryPoint.Toggled += new global::System.EventHandler (this.OnRadioDeliveryPointToggled);
			this.yentrySignPost.FocusInEvent += new global::Gtk.FocusInEventHandler (this.OnYentrySignPostFocusInEvent);
			this.yentrySignBaseOf.FocusInEvent += new global::Gtk.FocusInEventHandler (this.OnYentrySignBaseOfFocusInEvent);
		}
	}
}
