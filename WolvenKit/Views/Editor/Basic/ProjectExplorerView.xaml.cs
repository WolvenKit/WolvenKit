using System.Windows;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models;
using WolvenKit.RED4.MeshFile;
using WolvenKit.Views.Dialogs;

namespace WolvenKit.Views.Editor
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView
    {
        #region Constructors

        public ProjectExplorerView()
        {
            InitializeComponent();

            //ControlzEx.Theming.ThemeManager.Current.ChangeTheme(this, "Dark.Blue");
        }

        #endregion Constructors

        #region Methods

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Project Explorer");
            }
        }

        #endregion Methods

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (TreeView.SelectedItem != null)
            {
                var z = TreeView.SelectedItem as FileSystemInfoModel;
                if (z.FullName.Contains(".mesh", System.StringComparison.OrdinalIgnoreCase))
                {

                    var q = MESH.ExportMeshWithoutRigPreviewer(z.FullName);
                    if (q.Length > 0)
                    {
                        var meshexporter = new SimpleMeshExporterDialog(TreeView.SelectedItem);
                        meshexporter.LoadModel(q);
                        meshexporter.Show();
                    }
                }

            }


        }
    }
}
