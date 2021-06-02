
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            if (ext is ".wem" or ".mesh" or ".xbm")
            {
                AdvancedOptionsVis.SetCurrentValue(VisibilityProperty, System.Windows.Visibility.Visible);
                AdvancedOptionsExtension.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, ext );
                AdvancedOptionsFileName.SetCurrentValue(System.Windows.Controls.TextBlock.TextProperty, simplename);
            }

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
