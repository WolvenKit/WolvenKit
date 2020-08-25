using BrightIdeasSoftware;
using ScintillaNET;
using ScintillaNET_FindReplaceDialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Commands;
using WolvenKit.App.ViewModels;
using WolvenKit.Common.Services;
using WolvenKit.Radish.Model;
using WolvenKit.Services;

namespace WolvenKit.Forms
{
    public partial class frmRadish : DockContent, IThemedContent
    {
        private readonly RadishViewModel viewModel;

        public frmRadish()
        {
            // initialize Viewmodel
            viewModel = MockKernel.Get().GetRadishViewModel();
            if (viewModel.IsCorrupt)
                this.Close();

            InitializeComponent();
            ApplyCustomTheme();

            // Set control objects
            WorkflowobjectListView.SetObjects(RadishController.Get().Configuration.Workflows);
            
            PropertyGrid.SelectedObject = viewModel.CurrentWorkflow;
            PropertyGridSettings.SelectedObject = RadishController.GetConfig();
        }

        #region Methods
        public void ApplyCustomTheme()
        {
            var theme = UIController.Get().GetTheme();
            UIController.Get().ToolStripExtender.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, theme);

            // objectListView
            HeaderFormatStyle hfs = new HeaderFormatStyle()
            {
                Normal = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.DockTarget.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Hot = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.OverflowButtonHovered.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                },
                Pressed = new HeaderStateStyle()
                {
                    BackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background,
                    ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text,
                }
            };

            // WorkflowobjectListView
            this.WorkflowobjectListView.BackColor = theme.ColorPalette.ToolWindowTabSelectedInactive.Background;
            this.WorkflowobjectListView.AlternateRowBackColor = theme.ColorPalette.OverflowButtonHovered.Background;
            this.WorkflowobjectListView.ForeColor = theme.ColorPalette.CommandBarMenuDefault.Text;
            this.WorkflowobjectListView.HeaderFormatStyle = hfs;
            WorkflowobjectListView.UnfocusedSelectedBackColor = theme.ColorPalette.CommandBarToolbarButtonPressed.Background;
        }
        #endregion  

        private void tsb_LaunchQuestEditor_Click(object sender, EventArgs e) => viewModel.LaunchQuestEditorCommand.SafeExecute();
        private void tsb_FullRebuild_Click(object sender, EventArgs e) => viewModel.FullRebuildCommand.SafeExecute();
        private void tsb_RunSelected_Click(object sender, EventArgs e) => viewModel.RunSelectedCommand.SafeExecute();
        private void tsb_BuildUntilPack_Click(object sender, EventArgs e) => viewModel.BuildUntilPackCommand.SafeExecute();
        private void tsb_Pack_Click(object sender, EventArgs e) => viewModel.PackCommand.SafeExecute();
        private void tsb_ReCreateLinks_Click(object sender, EventArgs e) => viewModel.ReCreateLinksCommand.SafeExecute();
        private void tsb_StartGame_Click(object sender, EventArgs e) => viewModel.StartGameCommand.SafeExecute();

        private void AddtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newworkflow = new RadishWorkflow("New Workflow");
            RadishController.Get().Configuration.Workflows.Add(newworkflow);
            WorkflowobjectListView.SetObjects(RadishController.Get().Configuration.Workflows);

            WorkflowobjectListView.SelectedObject = newworkflow;
            viewModel.CurrentWorkflow = newworkflow;
            PropertyGrid.SelectedObject = newworkflow;
        }

        private void RemovetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedItem = (RadishWorkflow)WorkflowobjectListView.SelectedObject;
            if (selectedItem != null)
            {
                RadishController.Get().Configuration.Workflows.Remove(selectedItem);
                WorkflowobjectListView.SetObjects(RadishController.Get().Configuration.Workflows);
            }
        }



        private void frmRadish_FormClosing(object sender, FormClosingEventArgs e)
        {
            RadishController.Get().Configuration.Save();
        }

        private void WorkflowcontextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            var selectedItem = (RadishWorkflow)WorkflowobjectListView.SelectedObject;
            if (selectedItem != null)
            {
                RemovetoolStripMenuItem.Enabled = !(selectedItem.Name == "All" ||
                    selectedItem.Name == "Rebuild until pack" ||
                    selectedItem.Name == "Pack");
            }  
        }
        private void WorkflowobjectListView_SelectionChanged(object sender, EventArgs e)
        {
            var selectedItem = (RadishWorkflow)WorkflowobjectListView.SelectedObject;
            if (selectedItem != null)
            {
                viewModel.CurrentWorkflow = selectedItem;
                PropertyGrid.SelectedObject = viewModel.CurrentWorkflow;
            }
        }

        private void PropertyGridSettings_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

        }

        private void PropertyGridSettings_SelectedObjectsChanged(object sender, EventArgs e)
        {

        }


    }
}
