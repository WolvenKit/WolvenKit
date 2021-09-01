using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI.Fody.Helpers;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Functionality.Services;
using WolvenKit.MVVM.Model.ProjectManagement.Project;
using WolvenKit.RED4.CR2W;
using WolvenKit.ViewModels.Shell;

namespace WolvenKit.ViewModels.Documents
{
    public class RedDocumentViewModel : DocumentViewModel
    {
        private readonly IGameControllerFactory _gameControllerFactory;
        private readonly IProjectManager _projectManager;
        private readonly ILoggerService _loggerService;
        private readonly Red4ParserService _wolvenkitFileService;
        private readonly IArchiveManager _archiveManager;


        public RedDocumentViewModel(string path) : base(path)
        {
            _loggerService = Locator.Current.GetService<ILoggerService>();
            _gameControllerFactory = Locator.Current.GetService<IGameControllerFactory>();
            _projectManager = Locator.Current.GetService<IProjectManager>();
            _wolvenkitFileService = Locator.Current.GetService<Red4ParserService>();
            _archiveManager = Locator.Current.GetService<IArchiveManager>();


            OpenEditorCommand = new RelayCommand(ExecuteOpenEditor);
            OpenBufferCommand = new RelayCommand(ExecuteOpenBuffer);
            OpenImportCommand = new DelegateCommand<ICR2WImport>(ExecuteOpenImport);
        }

        public ICommand OpenBufferCommand { get; private set; }
        private bool CanOpenBuffer() => true;
        private void ExecuteOpenBuffer()
        {
            // TODO: Handle command logic here
        }

        public ICommand OpenEditorCommand { get; private set; }
        private bool CanOpenEditor() => true;
        private void ExecuteOpenEditor()
        {
            // TODO: Handle command logic here
        }



        public ICommand OpenImportCommand { get; private set; }
        private void ExecuteOpenImport(ICR2WImport input)
        {
            var depotpath = input.DepotPathStr;
            var key = FNV1A64HashAlgorithm.HashString(depotpath);

            var itemToImport = _archiveManager.Items.Lookup(key).Value;
            if (itemToImport != null)
            {
                _gameControllerFactory.GetController().AddToMod(itemToImport);
            }
        }

        #region properties

        /// <summary>
        /// Gets or sets the editable File.
        /// </summary>
        [Reactive] public IWolvenkitFile File { get; set; }

        /// <summary>
        /// Bound to the View
        /// </summary>
        public List<ICR2WImport> Imports => File.Imports;

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
        /// Bound to the View via TreeViewBehavior.cs
        /// </summary>
        [Reactive] public ChunkViewModel SelectedChunk { get; set; }

        [Reactive] public ICR2WImport SelectedImport { get; set; }

        #endregion


        #region methods

        public override void OnSave(object parameter)
        {
            using var fs = new FileStream(FilePath, FileMode.Create, FileAccess.ReadWrite);
            using var bw = new BinaryWriter(fs);
            File.Write(bw);
        }


        public override async Task<bool> OpenFileAsync(string path)
        {
            _isInitialized = false;

            try
            {
                await using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using var reader = new BinaryReader(stream);

                    var cr2w = _wolvenkitFileService.TryReadCr2WFile(reader);
                    if (cr2w == null)
                    {
                        _loggerService.Error($"Failed to read cr2w file {path}");
                        return false;
                    }
                    cr2w.FileName = path;

                    File = cr2w;

                    ContentId = path;
                    FilePath = path;
                    IsDirty = false;
                    Title = FileName;
                    _isInitialized = true;
                }

                return true;
            }
            catch (Exception)
            {
                // Not processing this catch in any other way than rejecting to initialize this
                _isInitialized = false;
            }

            return false;
        }

        #endregion


    }
}
