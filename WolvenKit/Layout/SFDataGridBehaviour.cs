using System.Windows.Interactivity;
using Syncfusion.UI.Xaml.Grid;

namespace WolvenKit.Layout
{
    public class Behaviour : Behavior<SfDataGrid>
    {
        protected override void OnAttached() => AssociatedObject.SelectionController = new RowSelectionController(AssociatedObject);
    }
}
