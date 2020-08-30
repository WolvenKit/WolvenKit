using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Model;
using WolvenKit.App.ViewModels;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.SRT;
using WolvenKit.CR2W.Types;
using WolvenKit.Services;

namespace WolvenKit
{
    public partial class frmCR2WDocument : DockContent, IThemedContent, IWolvenkitDocument
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
        public CR2WFile File => (CR2WFile)vm.File;
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
                File = (CR2WFile)vm.File,
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

        public DocumentViewModel GetViewModel() => vm;

        public void frmCR2WDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close all float windows


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

            if (e.Chunk.data is CBitmapTexture xbm)
            {
                if (ImageViewer == null || ImageViewer.IsDisposed)
                {
                    ImageViewer = new frmImagePreview();
                    ImageViewer.Show(dockPanel, DockState.Document);
                }

                ImageViewer.SetImage(e.Chunk);
            }
        }

        public void ApplyCustomTheme()
        {
            this.dockPanel.Theme = UIController.GetTheme();
            dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath),
                "cr2wdocument_layout.xml"));
        }

        public bool GetIsDisposed() => this.IsDisposed;
    }
}