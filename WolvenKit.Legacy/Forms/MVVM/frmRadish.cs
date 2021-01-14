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
using WolvenKit;
using WolvenKit.Commands;
using WolvenKit.ViewModels;
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

            this.Icon = new Icon(UIController.GetIconByKey(EAppIcons.Radish), new Size(16, 16));
        }

        #region Methods
        public void ApplyCustomTheme()
        {
            UIController.Get().ToolStripExtender.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, UIController.GetThemeBase());

            Color background = UIController.GetBackColor();
            Color highlight = UIController.GetHighlightColor();
            Color textStyle = UIController.GetForeColor();


            // propertygrid 1
            // backgrounds
            PropertyGrid.HelpBackColor = background;
            PropertyGrid.ViewBackColor = background;
            PropertyGrid.HelpForeColor = textStyle;
            PropertyGrid.ViewForeColor = textStyle;
            PropertyGrid.CategoryForeColor = textStyle;
            // highlighted
            PropertyGrid.BackColor = highlight;
            PropertyGrid.CategorySplitterColor = highlight;
            PropertyGrid.LineColor = highlight;

            // propertygrid 2
            // backgrounds
            PropertyGridSettings.HelpBackColor = background;
            PropertyGridSettings.ViewBackColor = background;
            PropertyGridSettings.HelpForeColor = textStyle;
            PropertyGridSettings.ViewForeColor = textStyle;
            PropertyGridSettings.CategoryForeColor = textStyle;
            // highlighted
            PropertyGridSettings.BackColor = highlight;
            PropertyGridSettings.CategorySplitterColor = highlight;
            PropertyGridSettings.LineColor = highlight;

            // WorkflowobjectListView
            this.WorkflowobjectListView.BackColor = UIController.GetBackColor();
            this.WorkflowobjectListView.AlternateRowBackColor = UIController.GetPalette().OverflowButtonHovered.Background;
            this.WorkflowobjectListView.ForeColor = UIController.GetForeColor();
            this.WorkflowobjectListView.HeaderFormatStyle = UIController.GetHeaderFormatStyle();
            WorkflowobjectListView.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;
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
