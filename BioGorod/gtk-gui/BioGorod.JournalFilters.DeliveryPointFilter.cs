
// This file has been generated by the GUI designer. Do not modify.
namespace BioGorod.JournalFilters
{
	public partial class DeliveryPointFilter
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.CheckButton checkOnlyNotFoundOsm;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BioGorod.JournalFilters.DeliveryPointFilter
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BioGorod.JournalFilters.DeliveryPointFilter";
			// Container child BioGorod.JournalFilters.DeliveryPointFilter.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.checkOnlyNotFoundOsm = new global::Gtk.CheckButton ();
			this.checkOnlyNotFoundOsm.CanFocus = true;
			this.checkOnlyNotFoundOsm.Name = "checkOnlyNotFoundOsm";
			this.checkOnlyNotFoundOsm.Label = global::Mono.Unix.Catalog.GetString ("Только не найденные в OSM");
			this.checkOnlyNotFoundOsm.DrawIndicator = true;
			this.checkOnlyNotFoundOsm.UseUnderline = true;
			this.table1.Add (this.checkOnlyNotFoundOsm);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.checkOnlyNotFoundOsm]));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.checkOnlyNotFoundOsm.Toggled += new global::System.EventHandler (this.OnCheckOnlyNotFoundOsmToggled);
		}
	}
}
