using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using IrrlichtLime;
using WeifenLuo.WinFormsUI.Docking;
using WolvenKit.App;
using WolvenKit.App.Model;
using WolvenKit.App.ViewModels;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
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
        

        public CR2WFile File => (CR2WFile)vm.File;
        public string Cr2wFileName => vm.Cr2wFileName;
        public DocumentViewModel GetViewModel() => vm;

        private frmProgress ProgressForm { get; set; }
        private LoggerService docLoggerService;
        #endregion




        public frmCR2WDocument(DocumentViewModel documentViewModel)
        {
            vm = documentViewModel;
            vm.ClosingRequest += (sender, e) => this.Close();
            vm.ActivateRequest += (sender, e) => this.Activate();
            vm.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();
            ApplyCustomTheme();

            chunkList = new frmChunkList(vm)
            {
                DockAreas = DockAreas.Document
            };
            propertyWindow = new frmChunkProperties();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);

            docLoggerService = new LoggerService();
            docLoggerService.PropertyChanged += LoggerUpdated;
        }

        #region Backgroundworker
        Func<object, DoWorkEventArgs, object> workerAction;
        //Func<object, object> workerCompletedAction;
        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bwAsync = sender as BackgroundWorker;
            e.Result = workerAction(sender, e);

            // add a result
            //e.Result
        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressForm?.SetProgressBarValue(e.ProgressPercentage, e.UserState);
        }
        //IWolvenkitDocument HACK_bwform = null;
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // has errors
            if (e.Error != null)
            {
                // do not continue to the completed action
            }
            else // has completed successfully
            {
                //if (workerCompletedAction != null)
                //{
                //    HACK_bwform = (IWolvenkitDocument)workerCompletedAction(e.Result);
                //}
                //workerCompletedAction = null;
            }

            ProgressForm.Close();
            docLoggerService.PropertyChanged -= LoggerUpdated;
        }

        private delegate void StrDelegate(string t);
        private delegate void LogDelegate(string t, Logtype type);
        /// <summary>
        /// Deprecated. Use MainController.QueueLog 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoggerUpdated(object sender, PropertyChangedEventArgs e)
        {
            var Logger = (LoggerService) sender;

            switch (e.PropertyName)
            {
                case "Progress":
                {
                    if (backgroundWorker1 != null)
                    {
                        if (string.IsNullOrEmpty(Logger.Progress.Item2))
                            backgroundWorker1.ReportProgress((int)Logger.Progress.Item1);
                        else
                            backgroundWorker1.ReportProgress((int)Logger.Progress.Item1, Logger.Progress.Item2);
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// Setup the backgroundworker and progress forms (Main thread)
        /// </summary>
        /// <param name="args"></param>
        public void WorkerLoadFileSetup(LoadFileArgs args)
        {
            MainController.Get().ProjectStatus = "Busy";

            this.Text = Path.GetFileName(args.Filename) + " [" + args.Filename + "]";

            if (!backgroundWorker1.IsBusy)
            {

                ProgressForm = new frmProgress()
                {
                    Text = "Loading File...",
                    StartPosition = FormStartPosition.CenterScreen,
                    FormBorderStyle = FormBorderStyle.None
                };

                workerAction = WorkerLoadFile;
                backgroundWorker1.RunWorkerAsync(args);
                var dr = ProgressForm.ShowDialog(this);


            }
            else
                MainController.LogString("The background worker is currently busy.\r\n", Logtype.Error);

            MainController.Get().ProjectStatus = "Ready";
        }

        /// <summary>
        /// This runs on a worker thread in the background and 
        /// returns the LoadFileArgs it reveived if succesfull, null otherwise.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private object WorkerLoadFile(object sender, DoWorkEventArgs e)
        {
            var arg = e.Argument;
            if (arg is LoadFileArgs args)
            {

                switch (vm.LoadFile(args.Filename, UIController.Get(), docLoggerService, args.Stream))
                {
                    case EFileReadErrorCodes.NoError:
                        break;
                    case EFileReadErrorCodes.NoCr2w:
                    case EFileReadErrorCodes.UnsupportedVersion:
                    {
                        this.Close();
                        //OpenDocuments.Remove(documentViewModel);
                        return null;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                //workerCompletedAction = WorkerLoadFileCompleted;
                return args;
            }

            throw new NotImplementedException();
        }
        #endregion


        #region UI Methods
        public bool GetIsDisposed() => this.IsDisposed;

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
        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(vm.File):
                    chunkList.UpdateList();
                    break;
            }
        }


        private void PropertyWindow_OnRequestUpdate(object sender, EventArgs e) => chunkList.UpdateList();

        private void PropertyWindow_OnRequestChunk(object sender, SelectChunkArgs e) => chunkList.SelectChunk(e.Chunk);

        private void EmbeddedWindow_OnRequestOpen(object sender, RequestEmbeddedFileOpenArgs e)
        {
            var embeddedwrapper = e.Embeddedfile;
            var relativePath = embeddedwrapper.Handle;

            // check if already open
            var opendocs = FormPanel.Documents
                .Where( _ => _.GetType() == typeof(frmCR2WDocument))
                .Cast<frmCR2WDocument>()
                .Where(_ => _.Cr2wFileName == relativePath)
                .ToList();

            if (opendocs.Count > 0)
            {
                opendocs.FirstOrDefault()?.Activate();
                return;
            }

            // else: open and dock new form
            var doc = new frmCR2WDocument(new DocumentViewModel())
            {
                Text = Path.GetFileName(relativePath) + " [" + relativePath + "]"
            };
            using (var ms = new MemoryStream(embeddedwrapper.GetRawEmbeddedData()))
            {
                switch (doc.vm.LoadFile(relativePath, UIController.Get(), docLoggerService, ms))
                {
                    case EFileReadErrorCodes.NoError:
                        break;
                    case EFileReadErrorCodes.NoCr2w:
                    case EFileReadErrorCodes.UnsupportedVersion:
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            PostLoadFile(relativePath);

            doc.Show(FormPanel, DockState.Document);
            doc.vm.SaveTarget = embeddedwrapper;
            //doc.FormClosed += vm.RemoveEmbedded;
            doc.FormClosed += (sender2, e2) => vm.RemoveEmbedded(sender2, e2, doc.vm);

            if (vm.OpenEmbedded.ContainsKey(relativePath))
                throw new NullReferenceException();
            vm.OpenEmbedded.Add(relativePath, doc.vm);
        }

        private void frmCR2WDocument_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close all float windows

            FormPanel.SaveAsXml(Path.Combine(Path.GetDirectoryName(Configuration.ConfigurationPath), "cr2wdocument_layout.xml"));

            if (propertyWindow != null && !propertyWindow.IsDisposed)
            {
                propertyWindow.Close();
            }

            // needed?
            vm.PropertyChanged -= ViewModel_PropertyChanged;
        }


        private void frmCR2WDocument_OnSelectChunk(object sender, SelectChunkArgs e)
        {
            if (propertyWindow == null || propertyWindow.IsDisposed)
            {
                propertyWindow = new frmChunkProperties();
                propertyWindow.Show(FormPanel, DockState.DockRight);
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


        private void frmCR2WDocument_Shown(object sender, EventArgs e)
        {
           
        }

        private void frmCR2WDocument_Load(object sender, EventArgs e)
        {
           

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
                    propertyWindow.Show(FormPanel, DockState.DockRight);
                    

                    Console.WriteLine(exception);
                }
            }
            else
            {
                chunkList.Show(FormPanel, DockState.Document);
                propertyWindow.Show(FormPanel, DockState.DockRight);
            }


            chunkList.OnSelectChunk += frmCR2WDocument_OnSelectChunk;
            propertyWindow.OnRequestUpdate += PropertyWindow_OnRequestUpdate;
            propertyWindow.OnChunkRequest += PropertyWindow_OnRequestChunk;

            chunkList.Activate();

            if (File.embedded.Count > 0)
            {
                embeddedFiles = new frmEmbeddedFiles
                {
                    File = File,
                    DockAreas = DockAreas.DockLeft
                };
                embeddedFiles.Show(FormPanel, DockState.DockLeftAutoHide);

                embeddedFiles.RequestFileOpen += EmbeddedWindow_OnRequestOpen;
            }
        }

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="openrenderer"></param>
        public void PostLoadFile(string filename = "", bool openrenderer = false)
        {
            #region SetupFile
            // Backgroundwork Start
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            switch (Path.GetExtension(filename))
            {
                case ".w2scene":
                case ".w2quest":
                case ".w2phase":
                    {
                        this.flowDiagram = new frmChunkFlowDiagram();
                        this.flowDiagram.OnOutput += MainController.LogString;
                        this.flowDiagram.File = this.File;
                        this.flowDiagram.DockAreas = DockAreas.Document;
                        this.flowDiagram.OnSelectChunk += this.frmCR2WDocument_OnSelectChunk;
                        this.flowDiagram.Show(this.FormPanel, DockState.Document);
                        break;
                    }

                case ".journal":
                    {
                        this.JournalEditor = new frmJournalEditor
                        {
                            File = this.File,
                            DockAreas = DockAreas.Document
                        };
                        this.JournalEditor.Show(this.FormPanel, DockState.Document);
                        break;
                    }
                case ".xbm":
                    {
                        this.ImageViewer = new frmImagePreview
                        {
                            DockAreas = DockAreas.Document
                        };
                        this.ImageViewer.Show(this.FormPanel, DockState.Document);
                        CR2WExportWrapper imagechunk = this.File?.chunks?.FirstOrDefault(_ => _.data.REDType.Contains("CBitmapTexture"));
                        this.ImageViewer.SetImage(imagechunk);
                        break;
                    }
                case ".redswf":
                    {
                        this.ImageViewer = new frmImagePreview
                        {
                            DockAreas = DockAreas.Document
                        };
                        this.ImageViewer.Show(this.FormPanel, DockState.Document);
                        CR2WExportWrapper imagechunk = this.File?.chunks?.FirstOrDefault(_ => _.data is CBitmapTexture);
                        this.ImageViewer.SetImage(imagechunk);
                        break;
                    }
                case ".w2mesh":
                    {
                        if (openrenderer)
                        {
                            try
                            {
                                // add all dependencies
                                MockKernel.Get().GetMainViewModel().AddAllImports(filename, true, true);

                                this.RenderViewer = new Render.frmRender
                                {
                                    LoadDocument = LoadDocumentAndGetFile,
                                    MeshFile = this.File,
                                    DockAreas = DockAreas.Document,
                                    renderHelper = new Render.RenderHelper(MainController.Get().ActiveMod, MainController.Get().Logger)
                                };
                                this.RenderViewer.Show(this.FormPanel, DockState.Document);
                            }
                            catch (Exception ex)
                            {
                                MainController.LogString(ex.ToString(), Logtype.Error);
                            }
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            

            var output = new StringBuilder();

            if (this.File.UnknownTypes.Any())
            {
                //ShowConsole();
                //ShowOutput();

                output.Append(this.Cr2wFileName + ": contains " + this.File.UnknownTypes.Count + " unknown type(s):\n");
                foreach (var unk in this.File.UnknownTypes)
                {
                    output.Append("\"" + unk + "\", \n");
                }

                output.Append("-------\n\n");
            }

            var hasUnknownBytes = false;

            foreach (var t in this.File.chunks.Where(t => t.unknownBytes?.Bytes != null && t.unknownBytes.Bytes.Length > 0))
            {
                output.Append(t.REDName + " contains " + t.unknownBytes.Bytes.Length + " unknown bytes. \n");
                hasUnknownBytes = true;
            }

            if (hasUnknownBytes)
                output.Append("-------\n\n");

            output.Append($"CR2WFile {filename} loaded in: {stopwatch.Elapsed}\n\n");
            stopwatch.Stop();

            MainController.LogString(output.ToString(), Logtype.Important);
            #endregion

            CR2WFile LoadDocumentAndGetFile(string path)
            {
                throw new NotImplementedException();
                //foreach (var t in MockKernel.Get().GetMainViewModel().OpenDocuments.Where(_ => _.File is CR2WFile).Where(t => t.Cr2wFileName == path))
                //    return t.File as CR2WFile;

                ////var activedoc = vm.OpenDocuments.FirstOrDefault(d => d.IsActivated);
                //var doc2 = LoadDocument(path) as frmCR2WDocument;
                ////activedoc.Activate();
                //return doc2?.File;
            }
        }
    }
}