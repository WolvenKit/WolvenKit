
using System;
using System.Linq;
using WolvenKit.Common.DDS;

namespace WolvenKit.Views.Editor
{
    public partial class ImportExportView
    {
        public ImportExportView()
        {
            InitializeComponent();
            GridComboBoxColumnX.ItemsSource =  Enum.GetValues(typeof(EUncookExtension)).Cast<EUncookExtension>();
        }


        private void DragNDropBorder_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Multiselect = true;
            openFileDlg.Filter = "All files (*.*)|*.*";
            Nullable<bool> result = openFileDlg.ShowDialog();
            if (result == true)
            {

                //ImporterList.items.Text = openFileDlg.FileName;

            }
        }
    }
}
