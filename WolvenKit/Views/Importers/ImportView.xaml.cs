using System;
using System.IO;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.Importers;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Helpers;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.Views.Exporters;

namespace WolvenKit.Views.Importers;

public partial class ImportView : ReactiveUserControl<ImportViewModel>
{
    public ImportView()
    {
        InitializeComponent();

        ImportGrid.FilterRowCellRenderers.Add("TextBoxExt", new GridFilterRowTextBoxRendererExt());
        ImportGrid.FilterChanged += Datagrid_FilterChanged;

        this.WhenActivated(disposables =>
        {
            if (DataContext is ImportViewModel viewModel)
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
                    x => x.ImportGrid.ItemsSource)
                .DisposeWith(disposables);

            this.Bind(ViewModel,
                   x => x.SelectedObject,
                   x => x.ImportGrid.SelectedItem)
               .DisposeWith(disposables);
        });
    }

    private void RefreshFilter(object sender, EventArgs e) => Datagrid_FilterChanged(ImportGrid, null);

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

    // TODO refactor this and move to ViewModel
    private void ShowSettings()
    {
        var mod = Locator.Current.GetService<IProjectManager>().NotNull().ActiveProject;
        if (mod is null)
        {
            return;
        }

        if (ImportGrid.SelectedItem is not ImportExportItemViewModel selectedImport ||
            !Enum.TryParse(selectedImport.Extension.TrimStart('.'), out ERawFileFormat rawExtension) || rawExtension != ERawFileFormat.re)
        {
            return;
        }

        var animsets = Directory.GetFiles(mod.ModDirectory, "*.anims", SearchOption.AllDirectories);
        var depotPaths = animsets.Select(x => x[(mod.ModDirectory.Length + 1)..]);

        // UI actions
        AddSettingsRe.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        AnimsetComboBox.SetCurrentValue(ItemsControl.ItemsSourceProperty, depotPaths);

        // set defaults if no change in selection
        if (selectedImport.Properties is not ReImportArgs args)
        {
            return;
        }

        if (AnimsetComboBox.SelectedItem is not string selectedItem || string.IsNullOrEmpty(selectedItem))
        {
            return;
        }

        args.Animset = selectedItem;

        if (AnimNameComboBox.SelectedItem is not string selectedName || string.IsNullOrEmpty(selectedName))
        {
            return;
        }

        args.AnimationToRename = selectedName;
    }

    // TODO refactor this and move to ViewModel
    private void AnimsetComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        var mod = Locator.Current.GetService<IProjectManager>().NotNull().ActiveProject;
        if (mod is null ||
            ImportGrid.SelectedItem is not ImportableItemViewModel { Properties: ReImportArgs args } ||
            AnimsetComboBox.SelectedItem is not string selectedItem)
        {
            return;
        }

        args.Animset = selectedItem;

        // parse animset and populate the animnameBox
        var path = Path.Combine(mod.ModDirectory, selectedItem);
        if (!File.Exists(path))
        {
            return;
        }

        using var fs = new FileStream(path, FileMode.Open);
        var parser = Locator.Current.GetService<Red4ParserService>();
        if (!parser.TryReadRed4File(fs, out var originalFile) || originalFile.RootChunk is not animAnimSet animset)
        {
            return;
        }

        var animnames = animset.Animations.Select(x => x.Chunk.Animation.Chunk.Name.ToString());
        AnimNameComboBox.SetCurrentValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty, animnames);
    }

    // TODO refactor this and move to ViewModel
    private void AnimNameComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        if (ImportGrid.SelectedItem is ImportableItemViewModel selectedImport && selectedImport.Properties is ReImportArgs args)
        {
            if (AnimNameComboBox.SelectedItem is not string selectedItem)
            {
                return;
            }

            args.AnimationToRename = selectedItem;
        }
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
            default:
                break;
        }

        if (ViewModel?.SelectedObject?.Properties is XbmImportArgs { })
        {
            if (e.DisplayName == "Use existing file")
            {
                e.Cancel = true;
                return;
            }
        }

        // Generate special editors for certain properties
        // we need the callback function
        // we need the propertyname
        // we need the type of the arguments
        if (e.OriginalSource is not PropertyItem propertyItem || sender is not PropertyGrid pg ||
            pg.SelectedObject is not ImportArgs args)
        {
            return;
        }

        switch (propertyItem.DisplayName)
        {
            case nameof(GltfImportArgs.Rig):
            case nameof(GltfImportArgs.BaseMesh) when ViewModel is not null:
                propertyItem.Editor = new CustomCollectionEditor(ViewModel!.InitCollectionEditor,
                    new CallbackArguments(args, propertyItem.DisplayName));
                break;
            default:
                break;
        }
    }

    private void ImportGrid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
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
            if (item is GridRowInfo { RowData: ImportExportItemViewModel vm } && !e.AddedItems.Contains(item))
            {
                vm.IsChecked = false;
            }
        }

        ViewModel?.ProcessSelectedCommand.NotifyCanExecuteChanged();
        ViewModel?.CopyArgumentsTemplateToCommand.NotifyCanExecuteChanged();
        ViewModel?.PasteArgumentsTemplateToCommand.NotifyCanExecuteChanged();
        ViewModel?.ImportSettingsCommand.NotifyCanExecuteChanged();
        ViewModel?.DefaultSettingsCommand.NotifyCanExecuteChanged();

        // toggle additional options
        ShowSettings();
    }
    

}
