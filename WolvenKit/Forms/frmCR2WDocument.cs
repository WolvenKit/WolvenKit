using System;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.CR2W;
using WolvenKit.Services;

namespace WolvenKit
{
    public partial class frmCR2WDocument : DockContent, IThemedContent
    {
        public frmChunkList chunkList;
        public frmChunkProperties propertyWindow;
        public frmEmbeddedFiles embeddedFiles;
        public frmChunkFlowDiagram flowDiagram;
        public frmJournalEditor JournalEditor;
        public frmImagePreview ImageViewer;
        public Render.frmRender RenderViewer;
        private CR2WFile file;

        public DockPanel FormPanel => dockPanel;

        public frmCR2WDocument()
        {
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
                File = File,
                DockAreas = DockAreas.Document
            };
            chunkList.Show(dockPanel, DockState.Document);
            chunkList.OnSelectChunk += frmCR2WDocument_OnSelectChunk;
            propertyWindow = new frmChunkProperties();
            propertyWindow.Show(dockPanel, DockState.DockBottom);
            propertyWindow.OnItemsChanged += PropertyWindow_OnItemsChanged;

            chunkList.Activate();
        }

        private void PropertyWindow_OnItemsChanged(object sender, EventArgs e)
        {
            var args = (e as BrightIdeasSoftware.CellEditEventArgs);
            if (args != null)
            {
                if (args.ListViewItem.Text == "Parent")
                    chunkList.UpdateList();
            }
        }

        public CR2WFile File
        {
            get { return file; }
            set
            {
                file = value;

                if (chunkList != null && !chunkList.IsDisposed)
                {
                    chunkList.File = file;
                }

                if (flowDiagram != null && !flowDiagram.IsDisposed)
                {
                    flowDiagram.File = file;
                }

                if (JournalEditor != null && !JournalEditor.IsDisposed)
                {
                    JournalEditor.File = file;
                }

                if (ImageViewer != null && !ImageViewer.IsDisposed)
                {
                    ImageViewer.File = file;
                }

                if (RenderViewer != null && !RenderViewer.IsDisposed)
                {
                    RenderViewer.MeshFile = file;
                }
                

                if (embeddedFiles != null && !embeddedFiles.IsDisposed)
                {
                    embeddedFiles.File = file;

                    if (file.embedded.Count > 0)
                    {
                        embeddedFiles.Show(dockPanel, DockState.Document);
                    }
                }
            }
        }

        public string FileName
        {
            get { return File.FileName; }
            set { File.FileName = value; }
        }

        public object SaveTarget { get; set; }
        public event EventHandler<FileSavedEventArgs> OnFileSaved;

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

        public void LoadFile(string filename)
        {
            using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                loadFile(fs, filename);

                fs.Close();
            }
        }

        public void LoadFile(string filename, Stream stream)
        {
            loadFile(stream, filename);
        }

        private void loadFile(Stream stream, string filename)
        {
            Text = Path.GetFileName(filename) + " [" + filename + "]";

            using (var reader = new BinaryReader(stream))
            {
                File = new CR2WFile(reader)
                {
                    FileName = filename,
                    EditorController = MainController.Get(),
                    LocalizedStringSource = MainController.Get()
                };
            }
        }

        public void SaveFile()
        {
            if (SaveTarget == null)
            {
                saveToFileName();
            }
            else
            {
                saveToMemoryStream();
            }
        }

        private void saveToMemoryStream()
        {
            using (var mem = new MemoryStream())
            {
                using (var writer = new BinaryWriter(mem))
                {
                    File.Write(writer);

                    if (OnFileSaved != null)
                    {
                        OnFileSaved(this, new FileSavedEventArgs {FileName = FileName, Stream = mem, File = File});
                    }
                }
            }
        }

        private void saveToFileName()
        {
            try
            {
                using (var mem = new MemoryStream())
                {
                    using (var writer = new BinaryWriter(mem))
                    {
                        File.Write(writer);
                        mem.Seek(0, SeekOrigin.Begin);

                        using (var fs = new FileStream(FileName, FileMode.Create, FileAccess.Write))
                        {
                            mem.WriteTo(fs);

                            OnFileSaved?.Invoke(this, new FileSavedEventArgs { FileName = FileName, Stream = fs, File = File });
                            fs.Close();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MainController.Get().QueueLog("Failed to save the file(s)! They are probably in use.\n" + e.ToString());
            }
        }

        public void ApplyCustomTheme()
        {
            var theme = MainController.Get().GetTheme();
            this.dockPanel.Theme = theme;
            dockPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath),
                "cr2wdocument_layout.xml"));
        }
    }
}