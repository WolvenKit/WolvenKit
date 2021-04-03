using Microsoft.WindowsAPICodePack.Dialogs;
using WolvenKit.RED4.MeshFile.Materials;

namespace WolvenKit.Views.Dialogs
{
    /// <summary>
    /// Interaction logic for MaterialsRepositoryDialog.xaml
    /// </summary>
    public partial class MaterialsRepositoryDialog : HandyControl.Controls.Window
    {
        public MaterialsRepositoryDialog()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MaterialRepository.Generate(new System.IO.DirectoryInfo(archivestext.Text), new System.IO.DirectoryInfo(Materialsrepotext.Text), Common.DDS.EUncookExtension.dds);

        }

        private void matsbutton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Materialsrepotext.SetCurrentValue(System.Windows.Controls.TextBox.TextProperty, dialog.FileName);
            }
        }

        private void archivespathbutt_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                archivestext.SetCurrentValue(System.Windows.Controls.TextBox.TextProperty, dialog.FileName);
            }
        }
    }
}
