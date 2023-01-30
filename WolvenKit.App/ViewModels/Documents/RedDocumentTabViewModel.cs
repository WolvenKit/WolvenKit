using System.Collections.Generic;
using System.Reactive.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Splat;
using WolvenKit.App.Controllers;
using WolvenKit.App.Interaction;
using WolvenKit.App.Services;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Modkit.RED4;
using WolvenKit.Modkit.Scripting;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

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

        _parent = parent;
        FilePath = parent.FilePath;
        Header = header;

        this.PropertyChanged += RedDocumentTabViewModel_PropertyChanged;
    }

    private void RedDocumentTabViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(RDTDataViewModel.IsEmbeddedFile))
        {
            DeleteEmbeddedFileCommand.NotifyCanExecuteChanged();
            RenameEmbeddedFileCommand.NotifyCanExecuteChanged();
        }
    }

    public abstract ERedDocumentItemType DocumentItemType { get; }
    public string Header { get; set; }
    public string FilePath { get; set; }

    [ObservableProperty] private RedDocumentViewModel _parent;

    [ObservableProperty] private bool _canClose;

    public static IRedType? CopiedChunk;

    public static List<IRedType> CopiedChunks = new();

    private bool CanDeleteEmbeddedFile() => this is RDTDataViewModel data && data.IsEmbeddedFile;
    [RelayCommand(CanExecute = nameof(CanDeleteEmbeddedFile))]
    private void DeleteEmbeddedFile()
    {
        if (this is RDTDataViewModel datavm)
        {
            for (var i = 0; i < Parent.Cr2wFile.EmbeddedFiles.Count; i++)
            {
                var file = Parent.Cr2wFile.EmbeddedFiles[i];
                if (file.Content == datavm.GetData())
                {
                    Parent.Cr2wFile.EmbeddedFiles.Remove(file);
                    break;
                }
            }
            for (var i = 0; i < Parent.TabItemViewModels.Count; i++)
            {
                var vm = Parent.TabItemViewModels[i];
                if (vm == this)
                {
                    Parent.TabItemViewModels.Remove(this);
                    Parent.SetIsDirty(true);
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
            for (var i = 0; i < Parent.Cr2wFile.EmbeddedFiles.Count; i++)
            {
                var file = Parent.Cr2wFile.EmbeddedFiles[i];
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
                Parent.SetIsDirty(true);
            }
        }
    }

    public virtual void OnSelected()
    {

    }
}
