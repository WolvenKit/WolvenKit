using System.Diagnostics;
using System.IO;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using Syncfusion.UI.Xaml.TreeView;
using Syncfusion.UI.Xaml.TreeView.Engine;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models;
using WolvenKit.RED4.MeshFile;
using WolvenKit.RED4.MorphTargetFile;
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

            TreeView.NotificationSubscriptionMode = NotificationSubscriptionMode.PropertyChange;
            //TreeView.NodePopulationMode = TreeNodePopulationMode.Instant;
            //TreeView.ExpandActionTrigger = ExpandActionTrigger.Node;
            //TreeView.ItemTemplateDataContextType = ItemTemplateDataContextType.Item;
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
                //var z = TreeView.SelectedItem as FileViewModel;
                //if (z.FullName.Contains(".mesh", System.StringComparison.OrdinalIgnoreCase))
                //{

                //    var q = MESH.ExportMeshWithoutRigPreviewer(z.FullName);
                //    if (q.Length > 0)
                //    {
                //        var meshexporter = new SimpleMeshExporterDialog(TreeView.SelectedItem);
                //        meshexporter.LoadModel(q);
                //        meshexporter.Show();
                //    }
                //}



            }


        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (TreeView.SelectedItem != null)
            {
                //var z = TreeView.SelectedItem as FileViewModel;
                //if (z.FullName.Contains(".morphtarget", System.StringComparison.OrdinalIgnoreCase))
                //{
                //    // EXPORT Morphtarget
                //    string outp;

                //    using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
                //    {
                //        dialog.IsFolderPicker = true;
                //        dialog.Multiselect = false;
                //        if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                //        {
                //            outp = dialog.FileName;

                //            var TargetStream = new FileStream(z.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                //            var xa = new FileInfo(outp + "\\" + z.Name);
                //            Trace.WriteLine(xa);
                //            TARGET.ExportTargets(TargetStream, xa);
                //        }
                //    }




                //}
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (TreeView.SelectedItem != null)
            {
                //var z = TreeView.SelectedItem as FileViewModel;
                //if (z.FullName.Contains(".wem", System.StringComparison.OrdinalIgnoreCase))
                //{
                //    // EXPORT WEM
                //    string outp;
                //    using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
                //    {
                //        dialog.IsFolderPicker = true;
                //        dialog.Multiselect = false;
                //        if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                //        {
                //            outp = dialog.FileName;


                //            //Clean directory


                //            var outf = Path.Combine(outp, Path.GetFileNameWithoutExtension(z.FullName) + ".wav");
                //            var arg = z.FullName + " -o " + outf;
                //            var si = new ProcessStartInfo(
                //                    "vgmstream\\test.exe",
                //                    arg
                //                )
                //            {
                //                CreateNoWindow = true,
                //                WindowStyle = ProcessWindowStyle.Hidden,
                //                UseShellExecute = false
                //            };
                //            var proc = Process.Start(si);
                //            proc.WaitForExit();



                //        }
                //    }


                //}
            }


        }
    }
}
