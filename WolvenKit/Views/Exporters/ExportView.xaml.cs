using System;
using System.Linq;
using System.Reactive.Disposables;
using ReactiveUI;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Helpers;

namespace WolvenKit.Views.Exporters;

/// <summary>
/// Interaction logic for ExportView.xaml
/// </summary>
public partial class ExportView : ReactiveUserControl<ExportViewModel>
{
    public ExportView()
    {
        InitializeComponent();

        ExportGrid.FilterRowCellRenderers.Add("TextBoxExt", new GridFilterRowTextBoxRendererExt());
        ExportGrid.FilterChanged += Datagrid_FilterChanged;

        this.WhenActivated(disposables =>
        {
            if (DataContext is ExportViewModel viewModel)
            {
                SetCurrentValue(ViewModelProperty, viewModel);
            }

            ViewModel.OnRefresh += RefreshFilter;

            this.OneWayBind(ViewModel,
                    x => x.SelectedObject.Properties,
                    x => x.OverlayPropertyGrid.SelectedObject)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                        x => x.Items,
                        x => x.ExportGrid.ItemsSource)
                    .DisposeWith(disposables);

            this.Bind(ViewModel,
                   x => x.SelectedObject,
                   x => x.ExportGrid.SelectedItem)
               .DisposeWith(disposables);
        });
    }


    private void RefreshFilter(object sender, EventArgs e) => Datagrid_FilterChanged(ExportGrid, null);
    private void Datagrid_FilterChanged(object sender, GridFilterEventArgs e)
    {
        if (sender is not SfDataGrid grid || ViewModel is null)
        {
            return;
        }

        ViewModel.VisibleItemPaths = grid.View.Records
            .Select(record => record.Data).OfType<ImportExportItemViewModel>()
            .Select(m => m.BaseFile)
            .ToList();
    }

    private void OverlayPropertyGrid_AutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
    {
        if (e.DisplayName is
            nameof(ReactiveObject.Changed) or
            nameof(ReactiveObject.Changing) or
            nameof(ReactiveObject.ThrownExceptions)
           )
        {
            e.Cancel = true;
            return;
        }
        
        // Generate special editors for certain properties
        // we need the callback function
        // we need the propertyname
        // we need the type of the arguments
        if (ViewModel is null ||
            e.OriginalSource is not PropertyItem propertyItem ||
            sender is not PropertyGrid { SelectedObject: ExportArgs args })
        {
            return;
        }

        switch (propertyItem.DisplayName)
        {
            case nameof(MeshExportArgs.Rig):
            case nameof(MeshExportArgs.MultiMeshMeshes):
            case nameof(MeshExportArgs.MultiMeshRigs):
            case nameof(OpusExportArgs.SelectedForExport):
                propertyItem.Editor = new CustomCollectionEditor(ViewModel.InitCollectionEditor,
                    new CallbackArguments(args, propertyItem.DisplayName));
                break;
            default:
                break;
        }
    }

    private void ExportGrid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
    {
        foreach (var item in e.AddedItems)
        {
            if (item is GridRowInfo { RowData: ImportExportItemViewModel vm })
            {
                vm.IsChecked = true;
            }
        }

        foreach (var item in e.RemovedItems)
        {
            if (item is GridRowInfo { RowData: ImportExportItemViewModel vm } &&
                !e.AddedItems.Contains(item))
            {
                vm.IsChecked = false;
            }
        }

        ViewModel?.ProcessSelectedCommand.NotifyCanExecuteChanged();
        ViewModel?.CopyArgumentsTemplateToCommand.NotifyCanExecuteChanged();
        ViewModel?.PasteArgumentsTemplateToCommand.NotifyCanExecuteChanged();
        ViewModel?.ImportSettingsCommand.NotifyCanExecuteChanged();
    }
}

