using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;
using Syncfusion.UI.Xaml.Grid;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models;
using WolvenKit.RED4.MeshFile;
using WolvenKit.RED4.MorphTargetFile;
using WolvenKit.ViewModels.Editor;
using WolvenKit.Views.Dialogs;

namespace WolvenKit.Views.Editor
{
    /// <summary>
    /// Interaction logic for ProjectExplorerView.xaml
    /// </summary>
    public partial class ProjectExplorerView
    {
        #region Constructors

        private ProjectExplorerViewModel _viewModel => ViewModel as ProjectExplorerViewModel;

        public ProjectExplorerView()
        {
            InitializeComponent();
        }

        #endregion Constructors

        private void UserControl_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                DiscordHelper.SetDiscordRPCStatus("Project Explorer");
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (this.TreeGrid.SelectedItem != null)
            {
                var z = TreeGrid.SelectedItem as FileModel;
                if (z.FullName.Contains(".mesh", System.StringComparison.OrdinalIgnoreCase))
                {

                    var q = (new MESH()).ExportMeshWithoutRigPreviewer(z.FullName);
                    if (q.Length > 0)
                    {
                        var meshexporter = new SimpleMeshExporterDialog(TreeGrid.SelectedItem);
                        meshexporter.LoadModel(q);
                        meshexporter.Show();
                    }
                }



            }


        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (TreeGrid.SelectedItem != null)
            {
                var z = TreeGrid.SelectedItem as FileModel;
                if (z.FullName.Contains(".morphtarget", System.StringComparison.OrdinalIgnoreCase))
                {
                    // EXPORT Morphtarget
                    string outp;

                    using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
                    {
                        dialog.IsFolderPicker = true;
                        dialog.Multiselect = false;
                        if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                        {
                            outp = dialog.FileName;

                            var TargetStream = new FileStream(z.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                            var xa = new FileInfo(outp + "\\" + z.Name);
                            Trace.WriteLine(xa);
                            (new TARGET()).ExportTargets(TargetStream, xa);
                        }
                    }




                }
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (TreeGrid.SelectedItem != null)
            {
                var z = TreeGrid.SelectedItem as FileModel;
                if (z.FullName.Contains(".wem", System.StringComparison.OrdinalIgnoreCase))
                {
                    // EXPORT WEM
                    string outp;
                    using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
                    {
                        dialog.IsFolderPicker = true;
                        dialog.Multiselect = false;
                        if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                        {
                            outp = dialog.FileName;


                            //Clean directory


                            var outf = Path.Combine(outp, Path.GetFileNameWithoutExtension(z.FullName) + ".wav");
                            var arg = z.FullName + " -o " + outf;
                            var si = new ProcessStartInfo(
                                    "vgmstream\\test.exe",
                                    arg
                                )
                            {
                                CreateNoWindow = true,
                                WindowStyle = ProcessWindowStyle.Hidden,
                                UseShellExecute = false
                            };
                            var proc = Process.Start(si);
                            proc.WaitForExit();



                        }
                    }


                }
            }


        }

        private void ExpandChildren_OnClick(object sender, RoutedEventArgs e)
        {
            var model = _viewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.ExpandAllNodes(node);
        }

        private void CollapseChildren_OnClick(object sender, RoutedEventArgs e)
        {
            var model = _viewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.CollapseAllNodes(node);
        }

        private void ExpandAll_OnClick(object sender, RoutedEventArgs e) => TreeGrid.ExpandAllNodes();

        private void CollapseAll_OnClick(object sender, RoutedEventArgs e) => TreeGrid.CollapseAllNodes();

        private void TreeGrid_OnSelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            if (StaticReferences.GlobalPropertiesView != null)
            {

                StaticReferences.GlobalPropertiesView.ExplorerBind.SetCurrentValue(VisibilityProperty, Visibility.Visible);
                StaticReferences.GlobalPropertiesView.AssetsBind.SetCurrentValue(VisibilityProperty, Visibility.Collapsed);

                StaticReferences.GlobalPropertiesView.fish.SetValue(Panel.DataContextProperty, DataContext);
            }
        }
    }
}
