using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using System.Windows.Controls;
using ReactiveUI;
using Splat;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.App.ViewModels.Dialogs;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.Importers;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core;
using WolvenKit.Functionality.Services;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Dialogs;
using WolvenKit.ViewModels.Tools;
using WolvenKit.Views.Exporters;
using YamlDotNet.Core;

namespace WolvenKit.Views.Importers;

public partial class TextureImportView : ReactiveUserControl<TextureImportViewModel>
{
    public TextureImportView()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            if (DataContext is TextureImportViewModel viewModel)
            {
                SetCurrentValue(ViewModelProperty, viewModel);
            }

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

    // TODO refactor this and move to ViewModel
    private void ShowSettings()
    {
        if (ImportGrid.SelectedItem is ImportExportItemViewModel selectedImport && Enum.TryParse(selectedImport.Extension.TrimStart('.'), out ERawFileFormat rawExtension) && rawExtension == ERawFileFormat.re)
        {
            var mod = ViewModel.GetActiveProject();
            var animsets = Directory.GetFiles(mod.ModDirectory, "*.anims", SearchOption.AllDirectories);
            var depotPaths = animsets.Select(x => x[(mod.ModDirectory.Length + 1)..]);

            // UI actions
            AddSettingsRe.SetCurrentValue(VisibilityProperty, Visibility.Visible);
            AnimsetComboBox.SetCurrentValue(ItemsControl.ItemsSourceProperty, depotPaths);

            // set defaults if no change in selection
            if (selectedImport.Properties is ReImportArgs args)
            {
                if (AnimsetComboBox.SelectedItem is not string selectedItem)
                {
                    return;
                }
                if (string.IsNullOrEmpty(selectedItem))
                {
                    return;
                }

                args.Animset = selectedItem;

                if (AnimNameComboBox.SelectedItem is not string selectedName)
                {
                    return;
                }
                if (string.IsNullOrEmpty(selectedName))
                {
                    return;
                }

                args.AnimationToRename = selectedName;
            }

        }
    }

    // TODO refactor this and move to ViewModel
    private void AnimsetComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
    {
        if (ImportGrid.SelectedItem is ImportableItemViewModel selectedImport && selectedImport.Properties is ReImportArgs args)
        {
            if (AnimsetComboBox.SelectedItem is not string selectedItem)
            {
                return;
            }

            args.Animset = selectedItem;

            // parse animset and populate the animnameBox
            var path = Path.Combine(ViewModel.GetActiveProject().ModDirectory, selectedItem);
            if (File.Exists(path))
            {
                using var fs = new FileStream(path, FileMode.Open);
                var parser = Locator.Current.GetService<Red4ParserService>();
                if (parser.TryReadRed4File(fs, out var originalFile))
                {
                    if (originalFile.RootChunk is animAnimSet animset)
                    {
                        var animnames = animset.Animations.Select(x => x.Chunk.Animation.Chunk.Name.ToString());
                        AnimNameComboBox.SetCurrentValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty, animnames);
                    }
                }
            }
        }
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
        }

        if (ViewModel.SelectedObject?.Properties is XbmImportArgs { })
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
        if (e.OriginalSource is PropertyItem { } propertyItem && sender is PropertyGrid pg && pg.SelectedObject is ImportArgs args)
        {
            switch (propertyItem.DisplayName)
            {
                case nameof(GltfImportArgs.Rig):
                case nameof(GltfImportArgs.BaseMesh):
                    propertyItem.Editor = new CustomCollectionEditor(ViewModel.InitCollectionEditor, new CallbackArguments(args, propertyItem.DisplayName));
                    break;
            }
        }
    }

    private void ImportGrid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
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
        ViewModel.DefaultSettingsCommand.NotifyCanExecuteChanged();

        // toglle additional options
        ShowSettings();
    }

}
