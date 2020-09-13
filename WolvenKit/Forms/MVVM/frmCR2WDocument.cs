using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Model;
using WolvenKit.App.ViewModels;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.SRT;
using WolvenKit.CR2W.Types;
using WolvenKit.Forms;
using WolvenKit.Services;

namespace WolvenKit
{
    public partial class frmCR2WDocument : DockContent, IThemedContent, IWolvenkitDocument
    {
        #region Fields
        private frmChunkList chunkList;
        private readonly DocumentViewModel vm;
        private DeserializeDockContent m_deserializeDockContent;


        #endregion

        #region Properties

        public frmChunkProperties propertyWindow;
        public frmEmbeddedFiles embeddedFiles;
        public frmChunkFlowDiagram flowDiagram;
        public frmJournalEditor JournalEditor;
        public frmImagePreview ImageViewer;
        public Render.frmRender RenderViewer;
        public DockPanel FormPanel { get; private set; }

        public CR2WFile File => (CR2WFile)vm.Cr2wFile;
        public string Cr2wFileName => vm.Cr2wFileName;
        public DocumentViewModel GetViewModel() => vm;

        #endregion




        public frmCR2WDocument(DocumentViewModel documentViewModel)
        {
            vm = documentViewModel;
            vm.ClosingRequest += (sender, e) => this.Close();
            vm.ActivateRequest += (sender, e) => this.Activate();
            vm.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();

            chunkList = new frmChunkList
            {
                File = (CR2WFile)vm.Cr2wFile,
                DockAreas = DockAreas.Document
            };
            propertyWindow = new frmChunkProperties();

            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);
        }


        #region UI Methods
        public bool GetIsDisposed() => this.IsDisposed;

        private void UpdateFormText(string val) => this.Text = val;

        public IDockContent DeserializeDockContent(string persistString)
        {
            return null;
        }

        public void ApplyCustomTheme()
        {
            // check for float windows
            foreach (var window in FormPanel.FloatWindows.ToList())
            {
                window.Dispose();
                window.Close();
            }

            this.FormPanel.Theme = UIController.GetTheme();
            //FormPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "cr2wdocument_layout.xml"));
        }

        private IDockContent GetContentFromPersistString(string persistString)
        {
            if (persistString == typeof(frmChunkList).ToString())
                return chunkList;
            else if (persistString == typeof(frmChunkProperties).ToString())
                return propertyWindow;
            
            //else
            //{
            //    // DummyDoc overrides GetPersistString to add extra information into persistString.
            //    // Any DockContent may override this value to add any needed information for deserialization.

            //    string[] parsedStrings = persistString.Split(new char[] { ',' });
            //    if (parsedStrings.Length != 3)
            //        return null;

            //    if (parsedStrings[0] != typeof(DummyDoc).ToString())
            //        return null;

            //    DummyDoc dummyDoc = new DummyDoc();
            //    if (parsedStrings[1] != string.Empty)
            //        dummyDoc.FileName = parsedStrings[1];
            //    if (parsedStrings[2] != string.Empty)
            //        dummyDoc.Text = parsedStrings[2];

            //    return dummyDoc;
            //}
            else
                return null;
        }
        #endregion

        #region Events
        private delegate void strDelegate(string t);
        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(vm.FormText))
            {
                Invoke(new strDelegate(UpdateFormText), (vm.FormText));
            }
        }


        private void PropertyWindow_OnRequestUpdate(object sender, EventArgs e) => chunkList.UpdateList();

        private void PropertyWindow_OnRequestChunk(object sender, SelectChunkArgs e) => chunkList.SelectChunk(e.Chunk);


        private void frmCR2WDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close all float windows


            FormPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "cr2wdocument_layout.xml"));

            if (propertyWindow != null && !propertyWindow.IsDisposed)
            {
                propertyWindow.Close();
            }
        }


        public void frmCR2WDocument_OnSelectChunk(object sender, SelectChunkArgs e)
        {
            if (propertyWindow == null || propertyWindow.IsDisposed)
            {
                propertyWindow = new frmChunkProperties();
                propertyWindow.Show(FormPanel, DockState.DockBottom);
            }

            propertyWindow.Chunk = e.Chunk;

            if (e.Chunk.data is CBitmapTexture xbm)
            {
                if (ImageViewer == null || ImageViewer.IsDisposed)
                {
                    ImageViewer = new frmImagePreview();
                    ImageViewer.Show(FormPanel, DockState.Document);
                }

                ImageViewer.SetImage(e.Chunk);
            }
        }

        #endregion

        private void frmCR2WDocument_Shown(object sender, EventArgs e)
        {
           
        }

        private void frmCR2WDocument_Load(object sender, EventArgs e)
        {
            ApplyCustomTheme();

            string config = Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "cr2wdocument_layout.xml");
            if (System.IO.File.Exists(config))
            {
                try
                {
                    FormPanel.LoadFromXml(config, m_deserializeDockContent);
                }
                catch (Exception exception)
                {
                    chunkList.Show(FormPanel, DockState.Document);
                    propertyWindow.Show(FormPanel, DockState.DockBottom);
                    Console.WriteLine(exception);
                }
            }
            else
            {
                chunkList.Show(FormPanel, DockState.Document);
                propertyWindow.Show(FormPanel, DockState.DockBottom);
            }


            chunkList.OnSelectChunk += frmCR2WDocument_OnSelectChunk;
            propertyWindow.OnRequestUpdate += PropertyWindow_OnRequestUpdate;
            propertyWindow.OnChunkRequest += PropertyWindow_OnRequestChunk;

            chunkList.Activate();

            // kinda stupid because the viewmodel lives before the form exists derp
            UpdateFormText(vm.FormText);
        }
    }
}