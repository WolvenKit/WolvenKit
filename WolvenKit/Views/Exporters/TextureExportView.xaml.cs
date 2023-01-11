using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Windows.Controls;
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
using WolvenKit.Functionality.Services;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Tools;
using static WolvenKit.Converters.PropertyGridEditors;

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

                //// Custom Collection Editors
                //var customEditorCollection = new CustomEditorCollection();
                //var editor1 = new CustomEditor
                //{
                //    Editor = new CustomCollectionEditor(ViewModel.OpenCollectionView)
                //};
                //editor1.Properties.Add(nameof(MeshExportArgs.Rig));
                ////editor1.
                //customEditorCollection.Add(editor1);
                //OverlayPropertyGrid.SetCurrentValue(PropertyGrid.CustomEditorCollectionProperty, customEditorCollection);
            }

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

        // Generate special editors for certain properties
        // we need the callback function
        // we need the propertyname
        // we need the type of the arguments
        if (e.OriginalSource is PropertyItem { } propertyItem && sender is PropertyGrid pg && pg.SelectedObject is ExportArgs args)
        {
            switch (propertyItem.DisplayName)
            {
                case nameof(MeshExportArgs.Rig):
                case nameof(MeshExportArgs.MultiMeshMeshes):
                case nameof(MeshExportArgs.MultiMeshRigs):
                case nameof(OpusExportArgs.SelectedForExport):
                    propertyItem.Editor = new CustomCollectionEditor(ViewModel.InitCollectionEditor, new CallbackArguments(args, propertyItem.DisplayName));
                    break;
            }
        }
    }

    private void ExportGrid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
    {
        foreach (var item in e.AddedItems)
        {
            if (item is GridRowInfo info && info.RowData is ImportExportItemViewModel vm)
            {
                vm.IsChecked = true;
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

