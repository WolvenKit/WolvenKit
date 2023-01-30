using System.Collections.Generic;
using System.Reactive.Linq;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WolvenKit.Core.Interfaces;
using WolvenKit.Functionality.Services;
using WolvenKit.Interaction;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using Splat;
using WolvenKit.Functionality.Controllers;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.CR2W;
using WolvenKit.Modkit.RED4;
using WolvenKit.Common.Services;

namespace WolvenKit.ViewModels.Documents
{
    public abstract partial class RedDocumentTabViewModel : ObservableObject
    {
        protected readonly ISettingsManager _settingsManager;
        protected readonly IGameControllerFactory _gameController;
        protected readonly ILoggerService _loggerService;
        protected readonly Red4ParserService _parser;
        protected readonly ModTools _modTools;
        protected readonly GeometryCacheService _geometryCacheService;

        protected RedDocumentTabViewModel(RedDocumentViewModel parent, string header)
        {
            _settingsManager = Locator.Current.GetService<ISettingsManager>().NotNull();
            _gameController = Locator.Current.GetService<IGameControllerFactory>().NotNull();
            _loggerService = Locator.Current.GetService<ILoggerService>().NotNull();
            _parser = Locator.Current.GetService<Red4ParserService>().NotNull();
            _modTools = Locator.Current.GetService<ModTools>().NotNull();
            _geometryCacheService = Locator.Current.GetService<GeometryCacheService>().NotNull();

            _file = parent;
            FilePath = parent.FilePath;
            Header = header;
        }

        public abstract ERedDocumentItemType DocumentItemType { get; }
        public string Header { get; set; }
        public string FilePath { get; set; }

        [ObservableProperty] private RedDocumentViewModel _file;

        [ObservableProperty] private bool _canClose;

        public static IRedType? CopiedChunk;

        public static List<IRedType> CopiedChunks = new();

        private bool CanDeleteEmbeddedFile() => this is RDTDataViewModel data && data.IsEmbeddedFile;
        [RelayCommand(CanExecute =nameof(CanDeleteEmbeddedFile))]
        private void DeleteEmbeddedFile()
        {
            if (this is RDTDataViewModel datavm)
            {
                for (var i = 0; i < File.Cr2wFile.EmbeddedFiles.Count; i++)
                {
                    var file = File.Cr2wFile.EmbeddedFiles[i];
                    if (file.Content == datavm.GetData())
                    {
                        File.Cr2wFile.EmbeddedFiles.Remove(file);
                        break;
                    }
                }
                for (var i = 0; i < File.TabItemViewModels.Count; i++)
                {
                    var vm = File.TabItemViewModels[i];
                    if (vm == this)
                    {
                        File.TabItemViewModels.Remove(this);
                        File.SetIsDirty(true);
                        break;
                    }
                }
            }
        }

        private bool CanRenameEmbeddedFile() => this is RDTDataViewModel data && data.IsEmbeddedFile;
        [RelayCommand(CanExecute = nameof(CanRenameEmbeddedFile))]
        private async void RenameEmbeddedFile()
        {
            if (this is RDTDataViewModel datavm)
            {
                CR2WEmbedded? embeddedFile = null;
                for (var i = 0; i < File.Cr2wFile.EmbeddedFiles.Count; i++)
                {
                    var file = File.Cr2wFile.EmbeddedFiles[i];
                    if (file.Content == datavm.GetData())
                    {
                        embeddedFile = (CR2WEmbedded)file;
                    }
                }
                if (embeddedFile != null)
                {
                    var newfilename = await Interactions.Rename.Handle(embeddedFile.FileName);

                    if (string.IsNullOrEmpty(newfilename))
                    {
                        return;
                    }

                    datavm.FilePath = newfilename;
                    embeddedFile.FileName = newfilename;
                    File.SetIsDirty(true);
                }
            }
        }

        public virtual void OnSelected()
        {

        }
    }
}
