
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using Catel.IoC;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Functionality.Helpers;
using WolvenKit.ViewModels.Editor;

namespace WolvenKit.Views.Editor
{
    public partial class ImportExportView
    {

        /// <summary>
        /// Constructor I/E Tool.
        /// </summary>
        public ImportExportView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Item Double Clicked ExportGrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfDataGrid_CellDoubleTapped(object sender, Syncfusion.UI.Xaml.Grid.GridCellDoubleTappedEventArgs e)
        {
            var m_LocalViewModel = ViewModel as ImportExportViewModel;
            if (m_LocalViewModel.IsImportsSelected)
            {
                var m_ImportSelected = ImportGrid.SelectedItem as ImportExportItemViewModel;
                var m_EnumParsedSuccesfully = Enum.TryParse(m_ImportSelected.Extension.TrimStart('.'), out ERawFileFormat RawExtension);
                if (m_EnumParsedSuccesfully)
                {
                    XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                    XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, m_ImportSelected.Extension);
                    XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, m_ImportSelected.Name);
                }
                else{throw new ArgumentOutOfRangeException();}
            }
            else
            {
                var m_ExportSelected = ExportGrid.SelectedItem as ImportExportItemViewModel;
                var m_EnumParsedSuccesfully = Enum.TryParse(m_ExportSelected.Extension.TrimStart('.'), out ECookedFileFormat Extension);
                if (m_EnumParsedSuccesfully)
                {
                    XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                    XAML_AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, m_ExportSelected.Extension);
                    XAML_AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, m_ExportSelected.Name);
                }
                else{throw new ArgumentOutOfRangeException();}
            }
        }

        /// <summary>
        /// Confirm Button (Advanced Options)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) => XAML_AdvancedOptionsOverlay.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

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
            e.Cancel=true;
            XAML_FileSelectingOverlay.SetCurrentValue(VisibilityProperty, Visibility.Visible);
        }

    }
}

