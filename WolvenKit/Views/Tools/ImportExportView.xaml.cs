using System;
using System.Linq;
using System.IO;
using System.ComponentModel;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Services;
using WolvenKit.ProjectManagement.Project;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.ViewModels.Tools;

namespace WolvenKit.Views.Tools
{
    public partial class ImportExportView : ReactiveUserControl<ImportExportViewModel>
    {

        private PropertyItem _propertyItem;
        private readonly IProjectManager projectManager;
        private readonly Red4ParserService parser;
        private ISettingsManager _settingsManager;

        /// <summary>
        /// Constructor I/E Tool.
        /// </summary>
        public ImportExportView()
        {
            InitializeComponent();

            _settingsManager = Locator.Current.GetService<ISettingsManager>();

            ViewModel = Locator.Current.GetService<ImportExportViewModel>();
            DataContext = ViewModel;

            projectManager = Locator.Current.GetService<IProjectManager>();
            parser = Locator.Current.GetService<Red4ParserService>();


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

            this.WhenAnyValue(x => x.ViewModel.SelectedObject)
                .Buffer(2, 1)
                .Subscribe(x =>
                {
                    if (x[0] is { } oldValue)
                    {
                        oldValue.Properties.PropertyChanged -= OnPropertyValueChanged;
                    }

                    if (x[1] is { } newValue)
                    {
                        newValue.Properties.PropertyChanged += OnPropertyValueChanged;
                    }
                });

            this.WhenAnyValue(x => x._settingsManager.ShowAdvancedOptions)
                .Subscribe(_ =>
                {
                    OverlayPropertyGrid.RefreshPropertygrid();
                });
        }

        /// <summary>
        /// Item Double Clicked ExportGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDataGrid_CellDoubleTapped(object sender, Syncfusion.UI.Xaml.Grid.GridCellDoubleTappedEventArgs e) => ShowSettings();

        private void ShowSettings_OnClick(object sender, RoutedEventArgs e) => ShowSettings();

        private void ShowSettings()
        {
            if (ViewModel == null)
            {
                return;
            }

            if (ViewModel.IsImportsSelected)
            {
                if (ImportGrid.SelectedItem is ImportExportItemViewModel selectedImport)
                {
                    if (Enum.TryParse(selectedImport.Extension.TrimStart('.'), out ERawFileFormat rawExtension))
                    {
                        XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                        XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedImport.Extension);
                        XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedImport.Name);

                        if (rawExtension == ERawFileFormat.re)
                        {
                            var mod = projectManager.ActiveProject;
                            var animsets = Directory.GetFiles(mod.ModDirectory, "*.anims", SearchOption.AllDirectories);
                            var depotPaths = animsets.Select(x => x.Substring(mod.ModDirectory.Length + 1));

                            AddSettingsRe.SetCurrentValue(VisibilityProperty, Visibility.Visible);

                            AnimsetComboBox.SetCurrentValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty, depotPaths);

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
                                //args.Output = Path.ChangeExtension(selectedItem, "cooked.anims");

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
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }

            if (ViewModel.IsExportsSelected)
            {
                if (ExportGrid.SelectedItem is ImportExportItemViewModel selectedExport)
                {
                    if (Enum.TryParse(selectedExport.Extension.TrimStart('.'), out ECookedFileFormat _))
                    {
                        XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                        XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedExport.Extension);
                        XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedExport.Name);
                    }
                    else
                    { throw new ArgumentOutOfRangeException(); }
                }
            }

            if (ViewModel.IsConvertsSelected)
            {
                if (ConvertGrid.SelectedItem is ImportExportItemViewModel selectedconvert)
                {
                    if (Enum.TryParse(selectedconvert.Extension.TrimStart('.'), out EConvertableFileFormat _))
                    {
                        XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                        XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedconvert.Extension);
                        XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedconvert.Name);
                    }
                    else
                    { throw new ArgumentOutOfRangeException(); }
                }
            }
        }

        private void OnPropertyValueChanged(object sender, PropertyChangedEventArgs e) => OverlayPropertyGrid.RefreshPropertygrid();

        /// <summary>
        /// Confirm Button (Advanced Options)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (ViewModel != null)
            {
                if (ApplyToAllCheckbox.IsChecked != null && ApplyToAllCheckbox.IsChecked.Value)
                {
                    ViewModel.CopyArgumentsTemplateToCommand.SafeExecute("All in Grid");
                    ApplyToAllCheckbox.SetCurrentValue(System.Windows.Controls.Primitives.ToggleButton.IsCheckedProperty, false);
                }

                ViewModel.SaveSettings();
            }
            XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        }

        /// <summary>
        /// Cancel Button (Select additional files)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelSelectingClick(object sender, RoutedEventArgs e) => XAML_FileSelectingOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

        

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

            if (ViewModel?.SelectedObject.Properties is XbmImportArgs)
            {
                if (e.DisplayName == "Use existing file")
                {
                    e.Cancel = true;
                    return;
                }

                if (!_settingsManager.ShowAdvancedOptions)
                {
                    if (e.Category is "Image Import Settings" or "XBM Import Settings")
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void AnimsetComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ViewModel is not ImportExportViewModel vm)
            {
                return;
            }
            if (vm.IsImportsSelected
                && ImportGrid.SelectedItem is ImportableItemViewModel selectedImport
                && selectedImport.Properties is ReImportArgs args)
            {
                if (AnimsetComboBox.SelectedItem is not string selectedItem)
                {
                    return;
                }

                args.Animset = selectedItem;
                //args.Output = Path.ChangeExtension(selectedItem, "cooked.anims");

                // parse animset and populate the animnameBox
                var path = Path.Combine(projectManager.ActiveProject.ModDirectory, selectedItem);
                if (File.Exists(path))
                {
                    using var fs = new FileStream(path, FileMode.Open);
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

        private void AnimNameComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ViewModel is not ImportExportViewModel vm)
            {
                return;
            }
            if (vm.IsImportsSelected
                && ImportGrid.SelectedItem is ImportableItemViewModel selectedImport
                && selectedImport.Properties is ReImportArgs args)
            {
                if (AnimNameComboBox.SelectedItem is not string selectedItem)
                {
                    return;
                }

                args.AnimationToRename = selectedItem;
            }
        }
    }
}
