using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Models;
using WolvenKit.Models.Docking;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED4.CR2W;
using WolvenKit.ViewModels.Shell;
using ModTools = WolvenKit.Modkit.RED4.ModTools;

namespace WolvenKit.ViewModels.Editor
{
    public class DocumentViewModel : PaneViewModel, IDocumentViewModel
    {
        #region fields

        private static ImageSourceConverter ISC = new ImageSourceConverter();
        
        private string _initialPath;
        private bool _isInitialized;

        private readonly IGameControllerFactory _gameControllerFactory;
        private readonly IProjectManager _projectManager;
        private readonly ILoggerService _loggerService;
        private readonly Red4ParserService _wolvenkitFileService;
        private readonly ModTools _modTools;

        private ICommand _saveAsCommand = null;
        private ICommand _saveCommand = null;
        public ReactiveCommand<Unit, Unit> Close { get; set; }
        #endregion fields

        #region ctors

        public DocumentViewModel(
            FileModel model)
            : this()
        {
            var fileinfo = model;
            _initialPath = fileinfo.FullName;

            Title = Path.GetFileName(fileinfo.FullName);
            Header = Title;

            ContentId = fileinfo.FullName;
        }

        private DocumentViewModel()
        {
            State = DockState.Document;

            _loggerService = Locator.Current.GetService<ILoggerService>();
            _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
            _projectManager = Locator.Current.GetService<IProjectManager>();
            _modTools = Locator.Current.GetService<ModTools>();
            _wolvenkitFileService = Locator.Current.GetService<Red4ParserService>();

            OpenEditorCommand = new RelayCommand(ExecuteOpenEditor);
            OpenBufferCommand = new RelayCommand(ExecuteOpenBuffer);
            OpenImportCommand = new DelegateCommand<ICR2WImport>(ExecuteOpenImport);
            OpenImportCommand = new RelayCommand(ExecuteViewImports, CanViewImports);
            Close = ReactiveCommand.Create(() => { });
        }

        #endregion ctors

        #region commands



        public ICommand ViewImportsCommand { get; private set; }
        private bool CanViewImports() => true;
        private void ExecuteViewImports()
        {
            // TODO: Handle command logic here
        }

        private bool CanOpenBuffer() => true;

        private bool CanOpenEditor() => true;


        public ICommand OpenBufferCommand { get; private set; }
        public ICommand OpenEditorCommand { get; private set; }
        public ICommand OpenImportCommand { get; private set; }

        /// <summary>Gets a command to save this document's content into another file in the file system.</summary>
        public ICommand SaveAsCommand
        {
            get
            {
                if (_saveAsCommand == null)
                {
                    _saveAsCommand = new DelegateCommand<object>((p) => OnSaveAs(p), (p) => CanSaveAs(p));
                }

                return _saveAsCommand;
            }
        }

        /// <summary>Gets a command to save this document's content into the file system.</summary>
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new DelegateCommand<object>((p) => OnSave(p), (p) => CanSave(p));
                }

                return _saveCommand;
            }
        }

        

        private void ExecuteOpenBuffer()
        {
            // TODO: Handle command logic here
        }

        private void ExecuteOpenEditor()
        {
            // TODO: Handle command logic here
        }

        private void ExecuteOpenImport(ICR2WImport input)
        {
            var depotpath = input.DepotPathStr;
            var key = FNV1A64HashAlgorithm.HashString(depotpath);
            var foundItems = new List<IGameFile>();
            foreach (var manager in _gameControllerFactory.GetController().GetArchiveManagers(false)
                .Where(manager => manager.Items.ContainsKey(key)))
            {
                foundItems.AddRange(manager.Items[key]);
            }

            var itemToImport = foundItems.FirstOrDefault();
            if (itemToImport != null)
            {
                _gameControllerFactory.GetController().AddToMod(itemToImport);
            }
        }

        #endregion commands

        #region Properties

        /// <summary>
        /// Gets or sets the editable File.
        /// </summary>
        [Reactive] public IWolvenkitFile File { get; set; }

        //private IWolvenkitFile File { get; set; }

        /// <summary>
        /// Bound to the View
        /// </summary>
        public List<ICR2WBuffer> Buffers => File.Buffers;

        /// <summary>
        /// Bound to the View
        /// </summary>
        public List<ChunkViewModel> Chunks => File.Chunks
            .Where(_ => _.VirtualParentChunk == null)
            .Select(_ => new ChunkViewModel(_)).ToList();

        /// <summary>
        /// Bound to the View
        /// </summary>
        public List<EditorViewModel> Editors => GetEditorsForFile(File);

        /// <summary>Gets the current filename of the file being managed in this document viewmodel.</summary>
        public string FileName
        {
            get
            {
                if (FilePath == null)
                {
                    return "Noname" + (IsDirty ? "*" : "");
                }

                return Path.GetFileName(FilePath) + (IsDirty ? "*" : "");
            }
        }

        /// <summary>
        /// Bound to the View
        /// </summary>
        public List<ICR2WImport> Imports => File.Imports;

        public void SetIsDirty(bool b) => IsDirty = b;

        /// <summary>
        /// Gets the current path of the file being managed in this document viewmodel.
        /// </summary>
        [Reactive] public string FilePath { get; set; }

        /// <summary>
        /// Gets/sets whether the documents content has been changed without saving into file system or not.
        /// </summary>
        [Reactive] public bool IsExistingInFileSystem { get; set; }

        /// <summary>
        /// Bound to the View via TreeViewBehavior.cs
        /// </summary>
        [Reactive] public ChunkViewModel SelectedChunk { get; set; }

        [Reactive] public ICR2WImport SelectedImport { get; set; }

        [Reactive] public bool IsDirty { get; private set; }

        private List<EditorViewModel> GetEditorsForFile(IWolvenkitFile file) => new();

        #endregion Properties

        #region methods

        /// <summary>
        /// Attempts to read the contents of a text file and assigns it to
        /// text content of this viewmodel.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>True if file read was successful, otherwise false</returns>
        public async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            try
            {
                // This is the same default buffer size as
                // <see cref="StreamReader"/> and <see cref="FileStream"/>.
                // int DefaultBufferSize = 4096;

                // Indicates that
                // 1. The file is to be used for asynchronous reading.
                // 2. The file is to be accessed sequentially from beginning to end.
                // FileOptions DefaultOptions = FileOptions.Asynchronous | FileOptions.SequentialScan;

                _loggerService.Info("Opening file: " + path + "...");

                //TODO
                await using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using var reader = new BinaryReader(stream);

                    if (Path.GetExtension(path) == ".srt")
                    {
                        //File = new Srtfile()
                        //{
                        //    FileName = path
                        //};
                        //errorcode = await File.Read(reader);

                    }
                    else
                    {
                        // check game
                        switch (_projectManager.ActiveProject)
                        {
                            case Cp77Project cp77proj:
                                var cr2w = _wolvenkitFileService.TryReadCr2WFile(reader);
                                if (cr2w == null)
                                {
                                    _loggerService.Error($"Failed to read cr2w file {path}");
                                    return false;
                                }
                                cr2w.FileName = path;

                                File = cr2w;

                                // events
                                

                                break;

                            case Tw3Project tw3proj:
                                throw new NotImplementedException();

                            default:
                                _isInitialized = false;
                                return false;
                        }
                    }
                }

                ContentId = path;
                FilePath = path;
                IsDirty = false;
                Title = FileName;
                _isInitialized = true;

                return true;
            }
            catch (Exception)
            {
                // Not processing this catch in any other way than rejecting to initialize this
                _isInitialized = false;
            }

            return false;
        }

        /// <summary>
        /// Attempts to read the contents of a text file fined via initialPath
        /// and assigns it to text content of this viewmodel.
        /// </summary>
        /// <returns>True if file read was successful, otherwise false</returns>
        public async Task<bool> OpenFileWithInitialPathAsync()
        {
            if (string.IsNullOrEmpty(_initialPath) && _isInitialized == false)
            {
                return false;
            }

            if (_isInitialized)
            {
                return true;
            }

            var result = await OpenFileAsync(_initialPath);

            if (result == true)
            {
                _initialPath = null;
            }

            return result;
        }

        private bool CanClose() => true;

        private bool CanSave(object parameter) => IsDirty;

        private bool CanSaveAs(object parameter) => IsDirty;

        private void OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new BinaryWriter(fs);
            File.Write(bw);
        }

        private void OnSaveAs(object parameter)
        {
            throw new NotImplementedException();
        }

        #endregion methods

        
    }

    public class EditorViewModel
    {
        #region Constructors

        public EditorViewModel()
        {
        }

        #endregion Constructors

        #region Properties

        public string Name { get; } = "TBA";

        #endregion Properties
    }
}
