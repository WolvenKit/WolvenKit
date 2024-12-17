using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Splat;
using WolvenKit.App.Factories;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models.Nodify;
using WolvenKit.App.Services;
using WolvenKit.App.ViewModels.Documents;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.ViewModels.Tools.EditorDifficultyLevel;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public partial class ResourcePathWrapper : ObservableObject, INode<ReferenceSocket>
{
    private readonly AppViewModel _appViewModel;
    private readonly IChunkViewmodelFactory _chunkViewmodelFactory;
    private readonly ISettingsManager? _settingsManager;

    public ResourcePathWrapper(/*RDTDataViewModel vm, */ReferenceSocket socket, AppViewModel appViewModel, IChunkViewmodelFactory chunkViewmodelFactory)
    {
        _appViewModel = appViewModel;
        _chunkViewmodelFactory = chunkViewmodelFactory;
        _settingsManager = Locator.Current.GetService<ISettingsManager>();

        //DataViewModel = vm;
        _socket = socket;
        
    }


    //public CName CName => Socket.File;

    [ObservableProperty]
    private System.Windows.Point _location;



    public double Width { get; set; }

    public double Height { get; set; }

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(OpenRefCommand))]
    [NotifyCanExecuteChangedFor(nameof(LoadRefCommand))]
    private ReferenceSocket _socket;
    

    public IList<ReferenceSocket> Inputs
    {
        get => new List<ReferenceSocket>(new ReferenceSocket[] { Socket });
        set
        {

        }
    }

    public IList<ReferenceSocket> Outputs { get; set; } = new List<ReferenceSocket>();

    //public RDTDataViewModel DataViewModel { get; set; }


    private bool CanOpenRef() => !ResourcePath.IsNullOrEmpty(Socket.File)
        //&& DataViewModel.Parent.RelativePath != Socket.File
        ;
    [RelayCommand(CanExecute = nameof(CanOpenRef))]
    private void OpenRef()
    {
        _appViewModel.OpenFileFromDepotPath(Socket.File.ToString().NotNull());
    }

    private bool CanLoadRef() => Socket.File != ResourcePath.Empty;
    [RelayCommand(CanExecute = nameof(CanLoadRef))]
    private void LoadRef()
    {
        //if (Socket.File.GetResolvedText() is not string path || ArchiveXlHelper.GetFirstExistingPath(path) is not string existingPath)
        //{
        //    return;
        //}

        //var cr2w = DataViewModel.Parent.GetFileFromDepotPathOrCache(existingPath);
        //if (cr2w is not { RootChunk: not null })
        //{
        //    return;
        //}

        //var chunk = _chunkViewmodelFactory.ChunkViewModel(cr2w.RootChunk, Socket, _appViewModel,
        //    _settingsManager?.DefaultEditorDifficultyLevel ?? EditorDifficultyLevel.Easy);
        //chunk.Location = Location;
        //DataViewModel.Nodes.Remove(this);
        //DataViewModel.Nodes.Add(chunk);
        //DataViewModel.LookForReferences(chunk);
    }
}
