using BrightIdeasSoftware;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Commands;
using WolvenKit.App.Model;
using WolvenKit.App.ViewModels;
using WolvenKit.Common.Wcc;
using WolvenKit.Services;

namespace WolvenKit.Forms
{
    public partial class frmImportUtility : DockContent, IThemedContent
    {
        private readonly ImportViewModel viewModel;

        public frmImportUtility()
        {
            // initialize Viewmodel
            viewModel = MockKernel.Get().GetImportViewModel();

            InitializeComponent();
            ApplyCustomTheme();

            viewModel.PropertyChanged += ViewModel_PropertyChanged;
            this.objectListView.SetObjects(viewModel.Importableobjects);
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(viewModel.Importableobjects))
            {
                if (objectListView.IsDisposed)
                {

                }
                else
                    this.objectListView.SetObjects(viewModel.Importableobjects);
            }
        }

        #region Methods
        public void ApplyCustomTheme()
        {
            UIController.Get().ToolStripExtender.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, UIController.GetTheme());

            this.objectListView.BackColor = UIController.GetBackColor();
            this.objectListView.AlternateRowBackColor = UIController.GetPalette().OverflowButtonHovered.Background;
            this.objectListView.ForeColor = Color.Black;
            this.objectListView.HeaderFormatStyle = UIController.GetHeaderFormatStyle();
            objectListView.UnfocusedSelectedBackColor = UIController.GetPalette().CommandBarToolbarButtonPressed.Background;
        }

        #endregion

        #region Commands
        private void toolStripButtonOpenFolder_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var importableexts = Enum.GetNames(typeof(EImportable)).Select(_ => $".{_}").ToList();
                var importablefiles = (from file in Directory.GetFiles(dialog.FileName, "*.*")
                                       from ext in importableexts
                                       where file.Contains(ext)
                                       select file).ToList();
                viewModel.AddObjects(importablefiles, dialog.FileName);
            }
        }
        private void toolStripButtonLocalResources_Click(object sender, EventArgs e) => viewModel.UseLocalResourcesCommand.SafeExecute();
        private void toolStripButtonRefresh_Click(object sender, EventArgs e) => viewModel.TryGetTextureGroupsCommand.SafeExecute();
        private void toolStripButtonImport_Click(object sender, EventArgs e) => viewModel.ImportCommand.SafeExecute();
        #endregion

        #region Control Events
        private void objectListView_FormatRow(object sender, FormatRowEventArgs e)
        {
            ImportableFile importable = (ImportableFile)e.Model;
            switch (importable.GetState())
            {
                case ImportableFile.EObjectState.NoTextureGroup:
                    e.Item.BackColor = Color.LightSalmon;
                    break;
                case ImportableFile.EObjectState.Ready:
                    e.Item.BackColor = Color.LightGreen;
                    break;
                case ImportableFile.EObjectState.Error:
                    e.Item.BackColor = Color.OrangeRed;
                    break;
                default:
                    e.Item.BackColor = Color.Orange;
                    break;
            }
        }

        private void objectListView_CellEditFinished(object sender, CellEditEventArgs e)
        {
            if (e.NewValue.GetType() == typeof(ETextureGroup))
            {
                ETextureGroup textureGroup = (ETextureGroup)e.NewValue;
                if (textureGroup != ETextureGroup.None)
                {
                    (e.RowObject as ImportableFile).SetState(ImportableFile.EObjectState.Ready);
                }
            }
        }
        #endregion

    }
}
