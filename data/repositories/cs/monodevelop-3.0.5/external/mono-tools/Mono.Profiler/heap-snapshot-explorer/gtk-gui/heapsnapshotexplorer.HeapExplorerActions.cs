// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace heapsnapshotexplorer
{


public partial class HeapExplorerActions
{

    private Gtk.Action LoadDataAction;

    private Gtk.Action FilterByClassAction;

    private Gtk.Action FilterByClassOfReferencedObjectAction;

    private Gtk.Action FilterByClassOfReferencingObjectAction;

    public virtual void Build()
    {
        // Action group heapsnapshotexplorer.HeapExplorerActions
        this.LoadDataAction = new Gtk.Action("LoadDataAction", Mono.Unix.Catalog.GetString("Load data"), null, "gtk-add");
        this.LoadDataAction.ShortLabel = Mono.Unix.Catalog.GetString("Load data");
        this.Add(this.LoadDataAction, null);
        this.FilterByClassAction = new Gtk.Action("FilterByClassAction", Mono.Unix.Catalog.GetString("Filter by class"), null, null);
        this.FilterByClassAction.ShortLabel = Mono.Unix.Catalog.GetString("Filter by class");
        this.Add(this.FilterByClassAction, null);
        this.FilterByClassOfReferencedObjectAction = new Gtk.Action("FilterByClassOfReferencedObjectAction", Mono.Unix.Catalog.GetString("Filter by class of referenced object"), null, null);
        this.FilterByClassOfReferencedObjectAction.ShortLabel = Mono.Unix.Catalog.GetString("Filter by class of referenced object");
        this.Add(this.FilterByClassOfReferencedObjectAction, null);
        this.FilterByClassOfReferencingObjectAction = new Gtk.Action("FilterByClassOfReferencingObjectAction", Mono.Unix.Catalog.GetString("Filter by class of referencing object"), null, null);
        this.FilterByClassOfReferencingObjectAction.ShortLabel = Mono.Unix.Catalog.GetString("Filter by class of referencing object");
        this.Add(this.FilterByClassOfReferencingObjectAction, null);
    }
}
}
