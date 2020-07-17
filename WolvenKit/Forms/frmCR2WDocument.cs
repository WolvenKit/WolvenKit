using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Model;
using WolvenKit.App.ViewModels;
using WolvenKit.Common;
using WolvenKit.CR2W;
using WolvenKit.Services;

namespace WolvenKit
{
    public partial class frmCR2WDocument : DockContent, IThemedContent
    {
        private readonly DocumentViewModel vm;

        public frmChunkList chunkList;
        public frmChunkProperties propertyWindow;
        public frmEmbeddedFiles embeddedFiles;
        public frmChunkFlowDiagram flowDiagram;
        public frmJournalEditor JournalEditor;
        public frmImagePreview ImageViewer;
        public Render.frmRender RenderViewer;
        

        public DockPanel FormPanel => dockPanel;
        public CR2WFile File => vm.File;
        public string FileName => vm.FileName;

        public frmCR2WDocument(DocumentViewModel documentViewModel)
        {
            vm = documentViewModel;
            vm.ClosingRequest += (sender, e) => this.Close();
            vm.ActivateRequest += (sender, e) => this.Activate();
            vm.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();
            
            try
            {
                dockPanel.LoadFromXml(
                    Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "cr2wdocument_layout.xml"),
                    DeserializeDockContent);
            }
            catch { }
            ApplyCustomTheme();

            chunkList = new frmChunkList
            {
                File = vm.File,
                DockAreas = DockAreas.Document
            };
            chunkList.Show(dockPanel, DockState.Document);
            chunkList.OnSelectChunk += frmCR2WDocument_OnSelectChunk;
            propertyWindow = new frmChunkProperties();
            propertyWindow.Show(dockPanel, DockState.DockBottom);
            propertyWindow.OnItemsChanged += PropertyWindow_OnItemsChanged;

            chunkList.Activate();

            // kinda stupid because the viewmodel lives before the form exists derp
            UpdateFormText(vm.FormText);
        }


        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(vm.FormText))
            {
                Invoke(new strDelegate(UpdateFormText), (vm.FormText));
            }
        }
        private delegate void strDelegate(string t);
        protected void UpdateFormText(string val) => this.Text = val;

        private void PropertyWindow_OnItemsChanged(object sender, EventArgs e)
        {
            var args = (e as BrightIdeasSoftware.CellEditEventArgs);
            if (args != null)
            {
                if (args.ListViewItem.Text == "Parent")
                    chunkList.UpdateList();
            }
        }

        //private CR2WFile file;
        //public CR2WFile File
        //{
        //    get { return file; }
        //    set
        //    {
        //        file = value;

        //        if (chunkList != null && !chunkList.IsDisposed)
        //        {
        //            chunkList.File = file;
        //        }

        //        if (flowDiagram != null && !flowDiagram.IsDisposed)
        //        {
        //            flowDiagram.File = file;
        //        }

        //        if (JournalEditor != null && !JournalEditor.IsDisposed)
        //        {
        //            JournalEditor.File = file;
        //        }

        //        if (ImageViewer != null && !ImageViewer.IsDisposed)
        //        {
        //        }

        //        if (RenderViewer != null && !RenderViewer.IsDisposed)
        //        {
        //            RenderViewer.MeshFile = file;
        //        }


        //        if (embeddedFiles != null && !embeddedFiles.IsDisposed)
        //        {
        //            embeddedFiles.File = file;

        //            if (file.embedded.Count > 0)
        //            {
        //                embeddedFiles.Show(dockPanel, DockState.Document);
        //            }
        //        }
        //    }
        //}

        public DocumentViewModel GetViewModel() => vm;

        public void frmCR2WDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath),
                "cr2wdocument_layout.xml"));

            if (propertyWindow != null && !propertyWindow.IsDisposed)
            {
                propertyWindow.Close();
            }
        }

        public IDockContent DeserializeDockContent(string persistString)
        {
            return null;
        }

        public void frmCR2WDocument_OnSelectChunk(object sender, SelectChunkArgs e)
        {
            if (propertyWindow == null || propertyWindow.IsDisposed)
            {
                propertyWindow = new frmChunkProperties();
                propertyWindow.Show(dockPanel, DockState.DockBottom);
            }

            propertyWindow.Chunk = e.Chunk;
        }


        public void ApplyCustomTheme()
        {
            var theme = UIController.Get().GetTheme();
            this.dockPanel.Theme = theme;
            dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath),
                "cr2wdocument_layout.xml"));
        }
    }
}