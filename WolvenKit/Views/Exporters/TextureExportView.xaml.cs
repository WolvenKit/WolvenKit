using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.Importers;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Views.Exporters;
/// <summary>
/// Interaction logic for TextureExportView.xaml
/// </summary>
public partial class TextureExportView : ReactiveUserControl<TextureExportViewModel>
{
    public TextureExportView()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            if (DataContext is TextureExportViewModel viewModel)
            {
                SetCurrentValue(ViewModelProperty, viewModel);
            }

            this.OneWayBind(ViewModel,
                    x => x.SelectedObject.Properties,
                    x => x.OverlayPropertyGrid.SelectedObject)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                        x => x.ExportableItems,
                        x => x.ExportGrid.ItemsSource)
                    .DisposeWith(disposables);

            this.Bind(ViewModel,
                   x => x.SelectedObject,
                   x => x.ExportGrid.SelectedItem)
               .DisposeWith(disposables);
            this.Bind(ViewModel,
                   x => x.SelectedItems,
                   x => x.ExportGrid.SelectedItems)
               .DisposeWith(disposables);

        });
    }

    private void OverlayPropertyGrid_AutoGeneratingPropertyGridItem(object sender, AutoGeneratingPropertyGridItemEventArgs e)
    {
        switch (e.DisplayName)
        {
            case nameof(ReactiveObject.Changed):
            case nameof(ReactiveObject.Changing):
            case nameof(ReactiveObject.ThrownExceptions):
                e.Cancel = true;
                return;
        }
    }

    private void ExportGrid_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
    {
        foreach (var item in e.AddedItems)
        {
            if (item is GridRowInfo info && info.RowData is ImportExportItemViewModel vm)
            {
                vm.IsChecked = true;

                //RightFileView.ScrollInView(new RowColumnIndex(info.RowIndex, 0));
            }
        }

        foreach (var item in e.RemovedItems)
        {
            if (item is GridRowInfo info && info.RowData is ImportExportItemViewModel vm)
            {
                vm.IsChecked = false;
            }
        }


        ViewModel.ProcessSelectedCommand.NotifyCanExecuteChanged();
        ViewModel.CopyArgumentsTemplateToCommand.NotifyCanExecuteChanged();
        ViewModel.PasteArgumentsTemplateToCommand.NotifyCanExecuteChanged();
        ViewModel.ImportSettingsCommand.NotifyCanExecuteChanged();
    }
}
