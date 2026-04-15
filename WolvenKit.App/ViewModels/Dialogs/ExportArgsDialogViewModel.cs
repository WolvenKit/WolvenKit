using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.App.ViewModels.Shell;
using WolvenKit.App.Helpers;
using WolvenKit.App.Interaction;
using WolvenKit.App.ViewModels.Exporters;
using WolvenKit.App.ViewModels.Tools;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Archive;


namespace WolvenKit.App.ViewModels.Dialogs;

public class ExportArgsDialogViewModel : DialogViewModel
{
    private TaskCompletionSource<bool> _tcs = new();
    private readonly AppViewModel _appViewModel;
    private readonly IArchiveManager _archiveManager;
    private readonly INotificationService _notificationService;
    public ExportArgsWrapper ArgsWrapper { get; set; }
    public bool UserCanceled { get; set; } = false;

    public ExportArgsDialogViewModel(AppViewModel appViewModel, IArchiveManager archiveManager, INotificationService notificationService, ExportArgsWrapper argsWrapper)
    {
        ArgsWrapper = argsWrapper;

        _appViewModel = appViewModel;
        _archiveManager = archiveManager;
        _notificationService = notificationService;
    }

    public Task WaitAsync() => _tcs.Task;

    public void Close()
    {
        _appViewModel.CloseModalCommand.Execute(null);
        _tcs.SetResult(true);
    }

    public Task InitCollectionEditor(CallbackArguments args)
    {
        if (args.Arg is not ExportArgs exportArgs)
        {
            return Task.CompletedTask;
        }

        switch (exportArgs)
        {
            case MeshExportArgs meshExportArgs:
            {
                InitMeshCollectionEditor(args, meshExportArgs);
                break;
            }
            case OpusExportArgs opusExportArgs:
            {
                InitOpusCollectionEditor(args, opusExportArgs);
                break;
            }

            default:
                break;
        }

        return Task.CompletedTask;
    }

    private void InitOpusCollectionEditor(CallbackArguments args, OpusExportArgs opusExportArgs)
    {
        List<uint> selectedEntries = new();
        switch (args.PropertyName)
        {
            case nameof(OpusExportArgs.SelectedForExport):
                selectedEntries = opusExportArgs.SelectedForExport;
                break;
            default:
                break;
        }
        // TODO init collectionEditor with this
        List<CollectionItemViewModel<uint>> selectedItems = new();
        if (selectedEntries is not null)
        {
            selectedItems = selectedEntries.Select(x => new CollectionItemViewModel<uint>(x)).ToList();
        }


        var info = OpusTools.GetOpusInfo(_archiveManager, opusExportArgs.UseProject);
        if (info == null)
        {
            return;
        }

        var availableItems = info.OpusHashes.Select(x => new CollectionItemViewModel<uint>(x));

        // open dialogue
        var result = Interactions.ShowCollectionView((availableItems, selectedItems));
        if (result is not null)
        {
            switch (args.PropertyName)
            {
                case nameof(OpusExportArgs.SelectedForExport):
                    opusExportArgs.SelectedForExport = result.Cast<CollectionItemViewModel<uint>>()
                        .Select(_ => _.Model)
                        .ToList();
                    _notificationService.Success($"Selected opus items were added.");
                    break;
                default:
                    break;
            }

        }
    }

    private void InitMeshCollectionEditor(CallbackArguments args, MeshExportArgs meshExportArgs)
    {
        var fetchExtension = ERedExtension.mesh;
        List<FileEntry> selectedEntries = [];
        switch (args.PropertyName)
        {
            case nameof(MeshExportArgs.MultiMeshMeshes):
                selectedEntries = meshExportArgs.MultiMeshMeshes;
                fetchExtension = ERedExtension.mesh;
                break;

            case nameof(MeshExportArgs.MultiMeshRigs):
                selectedEntries = meshExportArgs.MultiMeshRigs;
                fetchExtension = ERedExtension.rig;
                break;

            case nameof(MeshExportArgs.Rig):
                selectedEntries = meshExportArgs.Rig;
                fetchExtension = ERedExtension.rig;
                break;

            default:
                break;
        }

        IEnumerable<CollectionItemViewModel<FileEntry>>? selectedItems = null;
        if (selectedEntries is not null)
        {
            selectedItems = selectedEntries.Select(_ => new CollectionItemViewModel<FileEntry>(_));
        }

        var availableItems = _archiveManager
            .GetGroupedFiles(ArchiveManagerScope.Everywhere)[$".{fetchExtension}"]
            .Select(x => (FileEntry)x)
            .Select(_ => new CollectionItemViewModel<FileEntry>(_));

        // open dialogue
        var result = Interactions.ShowCollectionView((availableItems, selectedItems));
        if (result is null)
        {
            return;
        }

        switch (args.PropertyName)
        {
            case nameof(MeshExportArgs.MultiMeshMeshes):
                var meshes = result.Cast<CollectionItemViewModel<FileEntry>>()
                    .Select(_ => _.Model)
                    .ToList();

                meshExportArgs.MultiMeshMeshes.Clear();
                if (meshes.Count != 0)
                {
                    meshExportArgs.MultiMeshMeshes.AddRange(meshes);
                    meshExportArgs.meshExportType = MeshExportType.Multimesh;

                    _notificationService.Success($"Changed selection of Meshes in MultiMesh.");
                }
                else
                {
                    _notificationService.Success("Cleared MultiMesh.");
                }

                break;

            case nameof(MeshExportArgs.MultiMeshRigs):
                var rigs = result.Cast<CollectionItemViewModel<FileEntry>>()
                    .Select(_ => _.Model)
                    .ToList();

                meshExportArgs.MultiMeshRigs.Clear();
                if (rigs.Count != 0)
                {
                    meshExportArgs.MultiMeshRigs.AddRange(rigs);
                    meshExportArgs.meshExportType = MeshExportType.Multimesh;

                    _notificationService.Success($"Changed selection of Rigs in MultiMesh.");
                }
                else
                {
                    _notificationService.Success($"Cleared Rigs.");
                }

                break;

            case nameof(MeshExportArgs.Rig):
                var rig = result.Cast<CollectionItemViewModel<FileEntry>>()
                    .Select(_ => _.Model)
                    .FirstOrDefault();

                meshExportArgs.Rig.Clear();
                if (rig is not null)
                {
                    meshExportArgs.Rig.Add(rig);
                    meshExportArgs.meshExportType = MeshExportType.WithRig;

                    _notificationService.Success($"Selected WithRig \"{rig.Name}\".");
                }
                else
                {
                    _notificationService.Success($"Cleared WithRig.");
                }

                break;

            default:
                break;
        }
    }
}
