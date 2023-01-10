using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Reflection;
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
using WolvenKit.Controls;
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
    private PropertyItem _propertyItem;

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
                        x => x.Items,
                        x => x.ExportGrid.ItemsSource)
                    .DisposeWith(disposables);

            this.Bind(ViewModel,
                   x => x.SelectedObject,
                   x => x.ExportGrid.SelectedItem)
               .DisposeWith(disposables);
        });

        //// Custom Collection Editors
        //var customEditorCollection = new CustomEditorCollection();
        //var editor1 = new CustomEditor
        //{
        //    Editor = new CustomCollectionEditor()
        //};
        //editor1.Properties.Add(nameof(MeshExportArgs.Rig));
        ////editor1.
        //customEditorCollection.Add(editor1);
        //OverlayPropertyGrid.CustomEditorCollection = customEditorCollection;
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

        // Generate special editors for the properties for which default is not ok
        if (e.OriginalSource is PropertyItem { } propertyItem)
        {
            switch (propertyItem.DisplayName)
            {
                case nameof(ISettingsManager.MaterialRepositoryPath):
                    propertyItem.Editor = new SingleFolderPathEditor();
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

    private async void PropertyGrid_CollectionEditorOpening(object sender, CollectionEditorOpeningEventArgs e)
    {
        e.Cancel = true;

        if (sender is PropertyGrid pg)
        {
            _propertyItem = pg.SelectedPropertyItem;
            await ViewModel.ExecuteSetCollection(_propertyItem.Name);
        }
    }
}
