using System;
using System.ComponentModel;
using System.IO;
using System.Reactive.Disposables;
using System.Text.RegularExpressions;
using System.Windows;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Commands;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Views.Tools
{
    public partial class ImportExportView : ReactiveUserControl<ImportExportViewModel>
    {
        private object _selectedObject;

        /// <summary>
        /// Constructor I/E Tool.
        /// </summary>
        public ImportExportView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<ImportExportViewModel>();
            DataContext = ViewModel;

            this.WhenActivated(disposables =>
            {
                //SelectedObject="{Binding SelectedObject.Properties, Mode=OneWay}"
                this.OneWayBind(ViewModel,
                        x => x.SelectedObject.Properties,
                        x => x.OverlayPropertyGrid.SelectedObject)
                    .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.ExportableItems,
                        x => x.ExportGrid.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                       x => x.SelectedExport,
                       x => x.ExportGrid.SelectedItem)
                   .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.ImportableItems,
                        x => x.ImportGrid.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                       x => x.SelectedImport,
                       x => x.ImportGrid.SelectedItem)
                   .DisposeWith(disposables);

                this.Bind(ViewModel,
                        x => x.ConvertableItems,
                        x => x.ConvertGrid.ItemsSource)
                    .DisposeWith(disposables);
                this.Bind(ViewModel,
                       x => x.SelectedConvert,
                       x => x.ConvertGrid.SelectedItem)
                   .DisposeWith(disposables);

            });


        }

        /// <summary>
        /// Item Double Clicked ExportGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDataGrid_CellDoubleTapped(object sender, Syncfusion.UI.Xaml.Grid.GridCellDoubleTappedEventArgs e)
        {
            if (ViewModel is not { } vm)
            {
                return;
            }

            _selectedObject = vm.SelectedObject.Properties;

            if (vm.IsImportsSelected)
            {
                if (ImportGrid.SelectedItem is ImportExportItemViewModel selectedImport)
                {
                    if (Enum.TryParse(selectedImport.Extension.TrimStart('.'), out ERawFileFormat _))
                    {
                        XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                        XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedImport.Extension);
                        XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedImport.Name);

                        selectedImport.Properties.PropertyChanged += OnPropertyValueChanged;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            if (vm.IsExportsSelected)
            {
                if (ExportGrid.SelectedItem is ImportExportItemViewModel selectedExport)
                {
                    if (Enum.TryParse(selectedExport.Extension.TrimStart('.'), out ECookedFileFormat _))
                    {
                        XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                        XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedExport.Extension);
                        XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedExport.Name);

                        selectedExport.Properties.PropertyChanged += OnPropertyValueChanged;
                    }
                    else
                    { throw new ArgumentOutOfRangeException(); }
                }
            }
            if (vm.IsConvertsSelected)
            {
                if (ConvertGrid.SelectedItem is ImportExportItemViewModel selectedconvert)
                {
                    if (Enum.TryParse(selectedconvert.Extension.TrimStart('.'), out EConvertableFileFormat _))
                    {
                        XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                        XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedconvert.Extension);
                        XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedconvert.Name);

                        selectedconvert.Properties.PropertyChanged += OnPropertyValueChanged;
                    }
                    else
                    { throw new ArgumentOutOfRangeException(); }
                }

            }

        }

        private void OnPropertyValueChanged(object sender, PropertyChangedEventArgs e)
        {
            _selectedObject = sender;

            OverlayPropertyGrid.RefreshPropertygrid();
        }

        /// <summary>
        /// Confirm Button (Advanced Options)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is ImportExportViewModel vm)
            {
                if (ApplyToAllCheckbox.IsChecked != null && ApplyToAllCheckbox.IsChecked.Value)
                {
                    vm.CopyArgumentsTemplateToCommand.SafeExecute("All in Grid");
                    ApplyToAllCheckbox.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, false);
                }
            }
            XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        }

        /// <summary>
        /// Cancel Button (Select additional files)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSelectingClick(object sender, RoutedEventArgs e) => XAML_FileSelectingOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

        private PropertyItem _propertyItem;

        /// <summary>
        /// Override PG Collection Editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PropertyGrid_CollectionEditorOpening(object sender, Syncfusion.Windows.PropertyGrid.CollectionEditorOpeningEventArgs e)
        {
            if (ViewModel is ImportExportViewModel vm && sender is PropertyGrid pg)
            {
                _propertyItem = pg.SelectedPropertyItem;
                vm.SetCollectionCommand.SafeExecute(_propertyItem.Name);
            }

            e.Cancel = true;
            XAML_FileSelectingOverlay.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

        private void Button_Click(object sender, RoutedEventArgs e) => HelpOverlay.SetCurrentValue(VisibilityProperty, Visibility.Visible);

        private void Button_Click_1(object sender, RoutedEventArgs e) => HelpOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

        private void ConfirmCollectionEditorSelection_OnClick(object sender, RoutedEventArgs e)
        {
            XAML_FileSelectingOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
            if (ViewModel is ImportExportViewModel vm)
            {
                vm.ConfirmCollectionCommand.SafeExecute(_propertyItem.Name);
            }
        }

        private void AddItemsButtonClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is ImportExportViewModel vm)
            {
                vm.AddItemsCommand.SafeExecute(FileSelectionDataGrid.SelectedItems);
            }
        }

        private void RemoveItemsButtonClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel is ImportExportViewModel vm)
            {
                vm.RemoveItemsCommand.SafeExecute(SelectedFilesGrid.SelectedItems);
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

            if (_selectedObject is XbmImportArgs xbmImportArgs)
            {
                if (e.DisplayName == "Use existing file")
                {
                    e.Cancel = true;
                    return;
                }

                if (xbmImportArgs.Keep)
                {
                    if (e.Category == "Image Import Settings" || e.Category == "XBM Import Settings")
                    {
                        e.ReadOnly = true;
                        return;
                    }
                }
            }
        }

        private bool FileExists()
        {
            if (_selectedObject is XbmImportArgs xbmImportArgs)
            {
                if (ViewModel?.SelectedObject.GetModFile("xbm") != null)
                {
                    return true;
                }

                if (ViewModel?.SelectedObject.GetArchiveFile("xbm") != null)
                {
                    return true;
                }

                return false;
            }

            return true;
        }

        private void ResetSelectedSettings_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel != null)
            {
                foreach (var importableItem in ViewModel.ImportableItems)
                {
                    if (!importableItem.IsChecked)
                    {
                        continue;
                    }

                    importableItem.Properties = (ImportExportArgs)System.Activator.CreateInstance(importableItem.Properties.GetType());
                }
            }
        }

        private void LoadSelectedSettings_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel != null)
            {
                var logger = Locator.Current.GetService<ILoggerService>();
                var parser = Locator.Current.GetService<Red4ParserService>();
                var gammaRegex = new Regex(".*_[de][0-9]*$");

                foreach (var importableItem in ViewModel.ImportableItems)
                {
                    if (!importableItem.IsChecked)
                    {
                        continue;
                    }

                    if (importableItem.Properties is not XbmImportArgs xbmImportArgs)
                    {
                        continue;
                    }

                    if (parser != null)
                    {
                        if (importableItem.GetModFile("xbm") is { } modFile)
                        {
                            using var fs = File.OpenRead(modFile);

                            if (parser.TryReadRed4File(fs, out var cr2w) && cr2w.RootChunk is CBitmapTexture bitmap)
                            {
                                xbmImportArgs.RawFormat = bitmap.Setup.RawFormat;
                                xbmImportArgs.Compression = bitmap.Setup.Compression;
                                xbmImportArgs.HasMipchain = bitmap.Setup.HasMipchain;
                                xbmImportArgs.IsGamma = bitmap.Setup.IsGamma;
                                xbmImportArgs.TextureGroup = bitmap.Setup.Group;
                                xbmImportArgs.IsStreamable = bitmap.Setup.IsStreamable;
                                xbmImportArgs.PlatformMipBiasPC = bitmap.Setup.PlatformMipBiasPC;
                                xbmImportArgs.PlatformMipBiasConsole = bitmap.Setup.PlatformMipBiasConsole;
                                xbmImportArgs.AllowTextureDowngrade = bitmap.Setup.AllowTextureDowngrade;
                                xbmImportArgs.AlphaToCoverageThreshold = bitmap.Setup.AlphaToCoverageThreshold;

                                logger?.Info($"Load settings for \"{importableItem.Name}\": Loaded from project file");

                                continue;
                            }

                            logger?.Warning($"Load settings for \"{importableItem.Name}\": Project file couldn't be read");
                        }

                        if (importableItem.GetArchiveFile("xbm") is { } archiveFile)
                        {
                            using var ms = new MemoryStream();
                            archiveFile.Extract(ms);

                            if (parser.TryReadRed4File(ms, out var cr2w) && cr2w.RootChunk is CBitmapTexture bitmap)
                            {
                                xbmImportArgs.RawFormat = bitmap.Setup.RawFormat;
                                xbmImportArgs.Compression = bitmap.Setup.Compression;
                                xbmImportArgs.HasMipchain = bitmap.Setup.HasMipchain;
                                xbmImportArgs.IsGamma = bitmap.Setup.IsGamma;
                                xbmImportArgs.TextureGroup = bitmap.Setup.Group;
                                xbmImportArgs.IsStreamable = bitmap.Setup.IsStreamable;
                                xbmImportArgs.PlatformMipBiasPC = bitmap.Setup.PlatformMipBiasPC;
                                xbmImportArgs.PlatformMipBiasConsole = bitmap.Setup.PlatformMipBiasConsole;
                                xbmImportArgs.AllowTextureDowngrade = bitmap.Setup.AllowTextureDowngrade;
                                xbmImportArgs.AlphaToCoverageThreshold = bitmap.Setup.AlphaToCoverageThreshold;

                                logger?.Info($"Load settings for \"{importableItem.Name}\": Loaded from archive file");

                                continue;
                            }

                            logger?.Warning($"Load settings for \"{importableItem.Name}\": Archive file couldn't be read");
                        }
                    }

                    xbmImportArgs.IsGamma = gammaRegex.IsMatch(Path.GetFileNameWithoutExtension(importableItem.Name));

                    logger?.Info($"Load settings for \"{importableItem.Name}\": Parsed filename");
                }
            }
        }
    }
}
