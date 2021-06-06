
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

            var q = ExportGrid.SelectedItem as ImportExportItemViewModel;
            var simplename = Path.GetFileName(q.FullName);
            var ext = Path.GetExtension(q.FullName).ToString();

            _ = Enum.TryParse(ext.TrimStart('.'), out ECookedFileFormat Extension);
            switch (Extension)
            {
                case ECookedFileFormat.mesh:
                case ECookedFileFormat.xbm:
                case ECookedFileFormat.wem:
                case ECookedFileFormat.csv:
                case ECookedFileFormat.json:
                case ECookedFileFormat.mlmask:
                case ECookedFileFormat.cubemap:
                case ECookedFileFormat.envprobe:
                case ECookedFileFormat.texarray:
                case ECookedFileFormat.morphtarget:
                    AdvancedOptionsVis.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                    AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, ext);
                    AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, simplename);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }



        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            AdvancedOptionsVis.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);
        }

        private bool SelectionLocked = false;
        private void ExportGrid_SelectionChanged(object sender, Syncfusion.UI.Xaml.Grid.GridSelectionChangedEventArgs e)
        {
            if (!SelectionLocked)
            {
                var q = ExportGrid.SelectedItem as ImportExportItemViewModel;
                var simplename = Path.GetFileName(q.FullName);

                var prestring = "Selected : ";


                var IEVM = ServiceLocator.Default.ResolveType<ImportExportViewModel>();

                IEVM.CurrentSelectedInGridName =prestring + simplename;

            }


        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            SelectionLocked = true;
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            SelectionLocked = false;
        }
    }
}



//private void DragNDropBorder_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
//{
//    Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
//    openFileDlg.Multiselect = true;
//    openFileDlg.Filter = "All files (*.*)|*.*";
//    Nullable<bool> result = openFileDlg.ShowDialog();
//    if (result == true)
//    {

//        //ImporterList.items.Text = openFileDlg.FileName;

//    }
//}
