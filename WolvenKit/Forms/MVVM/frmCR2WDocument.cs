using System;
using System.Collections;
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
using WolvenKit.Forms.Editors;
using WolvenKit.Services;

namespace WolvenKit
{
    public partial class frmCR2WDocument : DockContent, IThemedContent, IWolvenkitView
    {
        #region Fields
        private frmChunkList chunkList;
        private readonly CR2WDocumentViewModel vm;
        private DeserializeDockContent m_deserializeDockContent;

        private frmChunkProperties propertyWindow;
        private frmEmbeddedFiles embeddedFiles;
        private frmCsvEditor csvEditor;
        private frmChunkFlowDiagram flowDiagram;
        private frmJournalEditor JournalEditor;
        private frmImagePreview ImageViewer;
        private Render.frmRender RenderViewer;

        private CR2WFile File => (CR2WFile)vm.File;

        private frmProgress ProgressForm;
        private readonly LoggerService docLoggerService;
        #endregion

        #region Properties
        public string FileName => vm.FileName;
        public IDocumentViewModel GetViewModel() => vm;



        #endregion

        public frmCR2WDocument(CR2WDocumentViewModel documentViewModel)
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
            propertyWindow = new frmChunkProperties(vm);

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            m_deserializeDockContent = new DeserializeDockContent(GetContentFromPersistString);

            docLoggerService = new LoggerService();
            docLoggerService.PropertyChanged += LoggerUpdated;
            docLoggerService.OnStringLogged += (sender, e) => MainController.LogString(e.Message, e.Logtype);
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
        //IWolvenkitView HACK_bwform = null;
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
                //    HACK_bwform = (IWolvenkitView)workerCompletedAction(e.Result);
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
            var logger = (LoggerService) sender;

            switch (e.PropertyName)
            {
                case nameof(logger.Progress):
                {
                    if (backgroundWorker1 != null)
                    {
                        if (string.IsNullOrEmpty(logger.Progress.Item2))
                            backgroundWorker1.ReportProgress((int)logger.Progress.Item1);
                        else
                            backgroundWorker1.ReportProgress((int)logger.Progress.Item1, logger.Progress.Item2);
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
            MainController.Get().ProjectStatus = EProjectStatus.Busy;

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

            MainController.Get().ProjectStatus = EProjectStatus.Ready;
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
        public void ApplyCustomTheme()
        {
            // check for float windows
            foreach (var window in FormPanel.FloatWindows.ToList())
            {
                window.Dispose();
                window.Close();
            }

            this.FormPanel.Theme = UIController.GetThemeBase();
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
                case nameof(vm.SelectedChunks):
                    if (propertyWindow == null || propertyWindow.IsDisposed)
                    {
                        propertyWindow = new frmChunkProperties(vm);
                        propertyWindow.Show(FormPanel, DockState.DockRight);
                    }

                    if (vm.SelectedChunks.Count > 0)
                    {
                        if (vm.SelectedChunks.First().data is CBitmapTexture xbm)
                        {
                            if (ImageViewer == null || ImageViewer.IsDisposed)
                            {
                                ImageViewer = new frmImagePreview();
                                ImageViewer.Show(FormPanel, DockState.Document);
                            }

                            ImageViewer.SetImage(vm.SelectedChunks.First());
                        }
                    }

                    break;
            }
        }


        private void ChunkWindowRequestChunkViewUpdate(object sender, EventArgs e) => chunkList.UpdateList();

        private void PropertyWindowOnRequestBytesOpen(object sender, RequestByteArrayFileOpenArgs e)
        {
            if (e.Variable is IByteSource source)
            {
                var bytes = source.GetBytes();
                if (bytes == null) return;

                byte[] Magic = { (byte)'C', (byte)'R', (byte)'2', (byte)'W' };
                var isCr2wFile = bytes.Take(4).SequenceEqual(Magic);
                if (isCr2wFile)
                {
                    OpenEmbeddedFile(e.Variable.GetFullDependencyStringName(), bytes, e.Variable);
                }
                else
                {
                    //TODO: Handle xbms here?
                    UIController.OpenHexEditorFor(e.Variable);
                }
            }
            else if (e.Variable is IArrayAccessor iarray)
            {
                Type InnerType = iarray.GetType().GetGenericArguments().Single();
                if (InnerType.GetInterface(nameof(IREDPrimitive)) == null) return;

                // check if open
                if (csvEditor == null || csvEditor.IsDisposed)
                {
                    csvEditor = new frmCsvEditor()
                    {
                        parentref = this,
                        WrappedArray = iarray,
                        DockAreas = DockAreas.Document
                    };
                    csvEditor.Show(FormPanel, DockState.Document);
                }
                else
                {
                    csvEditor.WrappedArray = iarray;
                    csvEditor.Activate();
                }

                
            }
        }

        private void EmbeddedWindow_OnRequestOpen(object sender, RequestEmbeddedFileOpenArgs e)
        {
            var embeddedwrapper = e.Embeddedfile;
            var relativePath = embeddedwrapper.Handle;

            OpenEmbeddedFile(relativePath, embeddedwrapper.GetRawEmbeddedData(), embeddedwrapper);
        }

        private void OpenEmbeddedFile(string key, byte[] bytesource, object saveTarget)
        {
            // check if already open
            var opendocs = FormPanel.Documents
                .Where(_ => _.GetType() == typeof(frmCR2WDocument))
                .Cast<frmCR2WDocument>()
                .Where(_ => _.FileName == key)
                .ToList();

            if (opendocs.Count > 0)
            {
                opendocs.FirstOrDefault()?.Activate();
                return;
            }

            // else: open and dock new form
            var doc = new frmCR2WDocument(new CR2WDocumentViewModel(UIController.Get().WindowFactory))
            {
                Text = Path.GetFileName(key) + " [" + key + "]"
            };
            using (var ms = new MemoryStream(bytesource))
            {
                switch (doc.vm.LoadFile(key, UIController.Get(), docLoggerService, ms))
                {
                    case EFileReadErrorCodes.NoError:
                        break;
                    case EFileReadErrorCodes.NoCr2w:
                    case EFileReadErrorCodes.UnsupportedVersion:
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            PostLoadFile(key);

            doc.Show(FormPanel, DockState.Document);
            doc.vm.SaveTarget = saveTarget;
            //doc.FormClosed += vm.RemoveEmbedded;
            doc.FormClosed += (sender2, e2) => vm.RemoveEmbedded(sender2, e2, doc.vm);

            if (vm.OpenEmbedded.ContainsKey(key))
                throw new NullReferenceException();
            vm.OpenEmbedded.Add(key, doc.vm);
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
            

            // Update Selected Chunk in the ViewModel
            vm.SelectedChunks = new List<CR2WExportWrapper>() { e.Chunk };

            
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
                    // if anything went wrong
                    if (FormPanel.DockWindows.Count < 2)
                    {
                        chunkList.Show(FormPanel, DockState.Document);
                        propertyWindow.Show(FormPanel, DockState.DockRight);
                    }
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

            //propertyWindow .RequestChunkViewUpdate += ChunkWindowRequestChunkViewUpdate;
            propertyWindow.RequestBytesOpen += PropertyWindowOnRequestBytesOpen;



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

        public void RefreshObject(IEditableVariable model) => propertyWindow.RefreshObject(model);

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
                        CR2WExportWrapper imagechunk = this.File?.chunks?.FirstOrDefault(_ => _.data is CBitmapTexture);
                        if (imagechunk != null)
                        {
                            this.ImageViewer = new frmImagePreview
                            {
                                DockAreas = DockAreas.Document
                            };
                            this.ImageViewer.Show(this.FormPanel, DockState.Document);
                            this.ImageViewer.SetImage(imagechunk);
                        }
                        break;
                    }
                case ".w2mesh":
                    {
                        if (openrenderer)
                        {
                            try
                            {
                                // add all dependencies

                                UIController.Get().Window.PauseMonitoring();
                                MockKernel.Get().GetMainViewModel().AddAllImports(filename, true, false);
                                UIController.Get().Window.ResumeMonitoring();

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

                output.Append(this.FileName + ": contains " + this.File.UnknownTypes.Count + " unknown type(s):\n");
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

            //output.Append($"CR2WFile {filename} loaded in: {stopwatch.Elapsed}\n\n");
            stopwatch.Stop();

            MainController.LogString(output.ToString(), Logtype.Important);
            #endregion

            CR2WFile LoadDocumentAndGetFile(string path)
            {
                throw new NotImplementedException();
                //foreach (var t in MockKernel.Get().GetMainViewModel().OpenDocuments.Where(_ => _.File is CR2WFile).Where(t => t.FileName == path))
                //    return t.File as CR2WFile;

                ////var activedoc = vm.OpenDocuments.FirstOrDefault(d => d.IsActivated);
                //var doc2 = LoadDocument(path) as frmCR2WDocument;
                ////activedoc.Activate();
                //return doc2?.File;
            }
        }
    }
}