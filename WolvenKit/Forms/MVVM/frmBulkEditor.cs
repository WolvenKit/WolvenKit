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

namespace WolvenKit.Forms
{
    public partial class frmBulkEditor : DockContent, IThemedContent
    {
        private readonly BulkEditorViewModel viewModel;

        public frmBulkEditor()
        {
            viewModel = MockKernel.Get().GetBulkEditorViewModel();
            viewModel.PropertyChanged += ViewModel_PropertyChanged;
            viewModel.PerformStep += (sender, e) => this.PerformStep();

            InitializeComponent();

            ApplyCustomTheme();

            propertyGrid.SelectedObject = viewModel.Options;
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(viewModel.ProgressReport))
            {
                if (progressBar1.InvokeRequired)
                {
                    progressBar1.BeginInvoke(new intDelegate(SetMinProgressInternal), viewModel.ProgressReport.Min);
                    progressBar1.BeginInvoke(new intDelegate(SetMaxProgressInternal), viewModel.ProgressReport.Max);
                    progressBar1.BeginInvoke(new intDelegate(SetValProgressInternal), viewModel.ProgressReport.Value);
                }
                else
                {
                    progressBar1.Minimum = viewModel.ProgressReport.Min;
                    progressBar1.Maximum = viewModel.ProgressReport.Max;
                    progressBar1.Value = viewModel.ProgressReport.Value;
                }
            }
        }
        private void PerformStep()
        {
            if (progressBar1.InvokeRequired)
                Invoke(new voidDelegate(PerformStepInternal));
            else
                this.progressBar1.PerformStep();
        }

        public void ApplyCustomTheme()
        {
            var theme = UIController.Get().GetTheme();
            UIController.Get().ToolStripExtender.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);

        }

        private void tsbtnRun_Click(object sender, EventArgs e) => viewModel.RunCommand.SafeExecute();


        private delegate void intDelegate(int v);
        private void SetMaxProgressInternal(int v) => this.progressBar1.Maximum = v;
        private void SetMinProgressInternal(int v) => this.progressBar1.Minimum = v;
        private void SetValProgressInternal(int v) => this.progressBar1.Value = v;

        private delegate void voidDelegate();
        private void PerformStepInternal() => this.progressBar1.PerformStep();

    }
}
