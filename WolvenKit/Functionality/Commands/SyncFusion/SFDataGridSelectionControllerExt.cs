using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System.Collections.ObjectModel;
using Syncfusion.UI.Xaml.Utility;
using System.Windows.Threading;
using Syncfusion.UI.Xaml.ScrollAxis;
using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid.Cells;
using Syncfusion.Windows.Shared;
using System.Collections.Specialized;
using WolvenKit.ViewModels.Editor;
using Catel.IoC;

namespace WolvenKit
{
    public class RowSelectionController : GridSelectionController
    {
        public RowSelectionController(SfDataGrid dataGrid)
            : base(dataGrid)
        { }

        protected override void ProcessPointerReleased(MouseButtonEventArgs args, RowColumnIndex rowColumnIndex)
        {
            var IEVM = ServiceLocator.Default.ResolveType<ImportExportViewModel>();

            if (rowColumnIndex.ColumnIndex == 0)
            {
                List<object> Selection = new List<object>();

                foreach (GridRowInfo gri in this.SelectedRows)
                    Selection.Add(gri);

                base.ProcessPointerReleased(args, rowColumnIndex);

                // Was the current row in the selection before?
                object griCurrent = Selection.SingleOrDefault(item => ((GridRowInfo)item).RowIndex == rowColumnIndex.RowIndex);

                if (griCurrent != null)
                {
                    Selection.Remove(griCurrent);
                }
                else
                {
                    griCurrent = this.SelectedRows.SingleOrDefault(item => item.RowIndex == rowColumnIndex.RowIndex);

                    if (griCurrent != null)
                        Selection.Add(griCurrent);
                }

                this.ClearSelections(false);

                if (Selection.Count > 0)
                    this.AddSelection(Selection, SelectionReason.SelectedItemsChanged);
            }
            else
            {
                base.ProcessPointerReleased(args, rowColumnIndex);

                var SelectedRows = this.SelectedRows.FindAll(item => item.RowIndex == rowColumnIndex.RowIndex);
                if (SelectedRows.Count == 0)
                {
                    var row = this.DataGrid.GetRecordAtRowIndex(rowColumnIndex.RowIndex);
                    if (IEVM.IsImportsSelected)
                    {
                        (row as ImportableItemViewModel).IsChecked = false;
                    }
                    else
                    {
                        (row as ExportableItemViewModel).IsChecked = false;
                    }
                }
                else
                {
                    if (IEVM.IsImportsSelected)
                    {
                        (SelectedRows[0].RowData as ImportableItemViewModel).IsChecked = true;
                    }
                    else
                    {
                        (SelectedRows[0].RowData as ExportableItemViewModel).IsChecked = true;
                    }
                }
            }

            var collectioncount = (IEVM).ExportableItems.Count;
            var selecteditemcount = DataGrid.SelectedItems.Count;

            if (selecteditemcount == collectioncount)
                (IEVM).IsHeaderChecked = true;
            else if (selecteditemcount == 0)
                (IEVM).IsHeaderChecked = false;
            else
                (IEVM).IsHeaderChecked = null;

            args.Handled = true;

            DataGrid.Focus();
        }

        protected override void ProcessSelectedItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            base.ProcessSelectedItemsChanged(e);
            var IEVM = ServiceLocator.Default.ResolveType<ImportExportViewModel>();

            if (IEVM != null)
            {
                if (e.Action == NotifyCollectionChangedAction.Reset)
                {
                    if (IEVM.IsImportsSelected)
                    {
                        foreach (ImportableItemViewModel o in (IEVM).ImportableItems)
                            o.IsChecked = false;
                    }
                    else
                    {
                        foreach (ExportableItemViewModel o in (IEVM).ExportableItems)
                            o.IsChecked = false;
                    }
                }
                else if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    if (IEVM.IsImportsSelected)
                    {
                        foreach (ImportableItemViewModel o in e.NewItems)
                            o.IsChecked = true;
                    }
                    else
                    {
                        foreach (ExportableItemViewModel o in e.NewItems)
                            o.IsChecked = true;
                    }
                }
                else if (e.Action == NotifyCollectionChangedAction.Remove)
                {
                    if (IEVM.IsImportsSelected)
                    {
                        foreach (ImportableItemViewModel o in e.OldItems)
                            o.IsChecked = false;
                    }
                    else
                    {
                        foreach (ExportableItemViewModel o in e.OldItems)
                            o.IsChecked = false;
                    }
                }
                else
                {
                    if (IEVM.IsImportsSelected)
                    {
                        if (e.NewItems != null)
                            foreach (ExportableItemViewModel o in e.NewItems)
                                o.IsChecked = true;

                        if (e.OldItems != null)
                            foreach (ExportableItemViewModel o in e.OldItems)
                                o.IsChecked = false;
                    }
                    else
                    {
                        if (e.NewItems != null)
                            foreach (ExportableItemViewModel o in e.NewItems)
                                o.IsChecked = true;

                        if (e.OldItems != null)
                            foreach (ExportableItemViewModel o in e.OldItems)
                                o.IsChecked = false;
                    }
                }
            }
        }
    }
}
