using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Catel.IoC;
using CP77.CR2W;
using Microsoft.WindowsAPICodePack.Dialogs;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.TreeGrid;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Functionality.Ab4d;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Models;
using WolvenKit.Modkit.RED4.MeshFile;
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
        public static ProjectExplorerView GlobalPEView;

        public ProjectExplorerView()
        {
            InitializeComponent();
            GlobalPEView = this;

        }

        protected override void OnViewModelPropertyChanged(PropertyChangedEventArgs e)
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }

            var name = e.PropertyName;
            switch (name)
            {
                case nameof(viewModel.IsTreeBeingEdited):
                    if (viewModel.IsTreeBeingEdited)
                    {
                        TreeGrid.View.BeginInit(TreeViewRefreshMode.DeferRefresh);
                    }
                    else
                    {
                        TreeGrid.View.EndInit();
                    }
                    break;
            }
        }

        #endregion Constructors


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (this.TreeGrid.SelectedItem == null)
            {
                return;
            }

            var z = TreeGrid.SelectedItem as FileModel;
            if (!z.FullName.Contains(".mesh", System.StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            var q = ServiceLocator.Default.ResolveType<MeshTools>().ExportMeshWithoutRigPreviewer(z.FullName);
            if (q.Length <= 0)
            {
                return;
            }

            var meshexporter = new SimpleMeshExporterDialog(TreeGrid.SelectedItem);
            meshexporter.LoadModel(q);
            meshexporter.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (TreeGrid.SelectedItem == null)
            {
                return;
            }

            var z = TreeGrid.SelectedItem as FileModel;
            if (!z.FullName.Contains(".morphtarget", System.StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            // EXPORT Morphtarget

            using var dialog = new CommonOpenFileDialog { IsFolderPicker = true, Multiselect = false };
            if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

            var outp = dialog.FileName;

            var targetStream = new FileStream(z.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            var xa = new FileInfo(outp + "\\" + z.Name);
            Trace.WriteLine(xa);
            ServiceLocator.Default.ResolveType<TargetTools>().ExportTargets(targetStream, xa);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (TreeGrid.SelectedItem == null)
            {
                return;
            }

            var z = TreeGrid.SelectedItem as FileModel;
            if (!z.FullName.Contains(".wem", System.StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            // EXPORT WEM
            string outp;
            using var dialog = new CommonOpenFileDialog { IsFolderPicker = true, Multiselect = false };
            if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                return;
            }

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
        public void ExpandChildren()
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }

            var model = viewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.ExpandAllNodes(node);
        }

        private void ExpandChildren_OnClick(object sender, RoutedEventArgs e) => ExpandChildren();

        public void CollapseChildren()
        {
            if (ViewModel is not ProjectExplorerViewModel viewModel)
            {
                return;
            }

            var model = viewModel.SelectedItem;
            var node = TreeGrid.View.Nodes.GetNode(model);
            TreeGrid.CollapseAllNodes(node);
        }

        private void CollapseChildren_OnClick(object sender, RoutedEventArgs e) => CollapseChildren();


        public void ExpandAll() => TreeGrid.ExpandAllNodes();

        public void CollapseAll() => TreeGrid.CollapseAllNodes();

        private void ExpandAll_OnClick(object sender, RoutedEventArgs e) => ExpandAll();

        private void CollapseAll_OnClick(object sender, RoutedEventArgs e) => CollapseAll();

        
    }
}
