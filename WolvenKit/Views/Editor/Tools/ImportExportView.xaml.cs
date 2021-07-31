using System;
using System.Windows;
using ReactiveUI;
using Splat;
using Syncfusion.Windows.PropertyGrid;
using WolvenKit.Common;
using WolvenKit.Functionality.Commands;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.Views.Editor
{
    public partial class ImportExportView : ReactiveUserControl<ImportExportViewModel>
    {
        /// <summary>
        /// Constructor I/E Tool.
        /// </summary>
        public ImportExportView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<ImportExportViewModel>();
            DataContext = ViewModel;
        }

        /// <summary>
        /// Item Double Clicked ExportGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDataGrid_CellDoubleTapped(object sender, Syncfusion.UI.Xaml.Grid.GridCellDoubleTappedEventArgs e)
        {
            if (ViewModel is not ImportExportViewModel vm)
            {
                return;
            }
            if (vm.IsImportsSelected)
            {
                if (ImportGrid.SelectedItem is ImportExportItemViewModel selectedImport)
                {
                    if (Enum.TryParse(selectedImport.Extension.TrimStart('.'), out ERawFileFormat _))
                    {
                        XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                        XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedImport.Extension);
                        XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, selectedImport.Name);
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
                    }
                    else
                    { throw new ArgumentOutOfRangeException(); }
                }

            }

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
    }
}
