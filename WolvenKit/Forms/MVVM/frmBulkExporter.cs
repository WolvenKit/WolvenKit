using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Commands;
using WolvenKit.App.ViewModels;
using WolvenKit.Common.Services;
using WolvenKit.Extensions;
using WolvenKit.Services;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace WolvenKit.Forms
{
    public partial class frmBulkExporter : DockContent, IThemedContent
    {
        private readonly BulkExportViewModel viewModel;

        public frmBulkExporter()
        {
            InitializeComponent();

            // initialize Viewmodel
            viewModel = MockKernel.Get().GetBulkExportViewModel();

            viewModel.PropertyChanged += ViewModel_PropertyChanged;
            viewModel.PerformStep += (sender, e) => this.PerformStep();

            geometryComboBox.SelectedIndex = 1;
            textureComboBox.SelectedIndex = 2;

            ApplyCustomTheme();
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(viewModel.ProgressReport))
            {
                if (this.progressBar1.IsHandleCreated)
                {
                    Invoke(new intDelegate(SetMinProgressInternal), viewModel.ProgressReport.Min);
                    Invoke(new intDelegate(SetMaxProgressInternal), viewModel.ProgressReport.Max);
                    Invoke(new intDelegate(SetValProgressInternal), viewModel.ProgressReport.Value);
                }
            }
        }
        private void PerformStep()
        {
            if (/*this.IsHandleCreated || */this.progressBar1.IsHandleCreated)
            {
                Invoke(new voidDelegate(PerformStepInternal));
            }
        }

        public void ApplyCustomTheme()
        {
            var theme = UIController.GetTheme();
            UIController.Get().ToolStripExtender.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);

        }

        private void tsbtnRun_Click(object sender, EventArgs e)
        {
            viewModel.InputPath = this.inputTextBox.Text;
            viewModel.ExportPath = this.exportTextBox.Text;
            viewModel.GeometryType = this.geometryComboBox.SelectedItem.ToString();
            viewModel.TextureType = this.textureComboBox.SelectedItem.ToString();
            viewModel.MergeMeshes = this.mergeCheckBox.Checked;

            viewModel.RunCommand.SafeExecute();
        }


        private delegate void intDelegate(int v);
        private void SetMaxProgressInternal(int v) => this.progressBar1.Maximum = v;
        private void SetMinProgressInternal(int v) => this.progressBar1.Minimum = v;
        private void SetValProgressInternal(int v) => this.progressBar1.Value = v;

        private delegate void voidDelegate();
        private void PerformStepInternal() => this.progressBar1.PerformStep();

        private void InputFolder_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog() { Title = "Select input folder" };
            dlg.IsFolderPicker = true;
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                this.inputTextBox.Text = dlg.FileName;
            }

        }

        private void ExportFolder_Click(object sender, EventArgs e)
        {
            var dlg = new CommonOpenFileDialog() { Title = "Select export folder" };
            dlg.IsFolderPicker = true;
            dlg.InitialDirectory = MainController.Get().Configuration.InitialFileDirectory;
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                this.exportTextBox.Text = dlg.FileName;
            }

        }
    }
}
