using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Input;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using Syncfusion.UI.Xaml.ScrollAxis;
using WolvenKit.Common.Interfaces;

namespace WolvenKit.Layout
{
    public class RowSelectionController : GridSelectionController
    {
        public RowSelectionController(SfDataGrid dataGrid)
            : base(dataGrid)
        {
        }

        protected override void ProcessPointerReleased(MouseButtonEventArgs args, RowColumnIndex rowColumnIndex)
        {
            if (rowColumnIndex.ColumnIndex == 0)
            {
                var Selection = new List<object>();

                foreach (var gri in SelectedRows)
                {
                    Selection.Add(gri);
                }

                base.ProcessPointerReleased(args, rowColumnIndex);

                // Was the current row in the selection before?
                var griCurrent = Selection.SingleOrDefault(item => ((GridRowInfo)item).RowIndex == rowColumnIndex.RowIndex);

                if (griCurrent != null)
                {
                    Selection.Remove(griCurrent);
                }
                else
                {
                    griCurrent = SelectedRows.SingleOrDefault(item => item.RowIndex == rowColumnIndex.RowIndex);

                    if (griCurrent != null)
                    {
                        Selection.Add(griCurrent);
                    }
                }

                ClearSelections(false);

                if (Selection.Count > 0)
                {
                    AddSelection(Selection, SelectionReason.SelectedItemsChanged);
                }
            }
            else
            {
                base.ProcessPointerReleased(args, rowColumnIndex);

                var SelectedRows = this.SelectedRows.FindAll(item => item.RowIndex == rowColumnIndex.RowIndex);
                if (SelectedRows.Count == 0)
                {
                    var row = DataGrid.GetRecordAtRowIndex(rowColumnIndex.RowIndex);
                    (row as ISelectableViewModel).IsChecked = false;
                }
                else
                {
                    (SelectedRows[0].RowData as ISelectableViewModel).IsChecked = true;
                }
            }

            args.Handled = true;

            DataGrid.Focus();
        }

        protected override void ProcessSelectedItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            base.ProcessSelectedItemsChanged(e);

            if (e.Action == NotifyCollectionChangedAction.Reset)
            {
                if (DataGrid.SelectedItem is ISelectableViewModel m)
                {
                    m.IsChecked = false;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (ISelectableViewModel o in e.NewItems)
                {
                    o.IsChecked = true;
                }
            }
            else if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (ISelectableViewModel o in e.OldItems)
                {
                    o.IsChecked = false;
                }
            }
            else
            {
                if (e.NewItems != null)
                {
                    foreach (ISelectableViewModel o in e.NewItems)
                    {
                        o.IsChecked = true;
                    }
                }

                if (e.OldItems != null)
                {
                    foreach (ISelectableViewModel o in e.OldItems)
                    {
                        o.IsChecked = false;
                    }
                }
            }
        }
    }
}
