using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.App.Helpers;
using WolvenKit.Common;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.App.Services;

/// <summary>
/// Its single responsibility is loading the archive manager.
/// </summary>
public sealed class ArchiveManagerLoader: IArchiveManagerLoader
{
    private readonly IArchiveManager _archiveManager;
    private readonly ISettingsManager _settingsManager;
    private readonly IProgressService<double> _progressService;
    private readonly Red4ParserService _parserService;
    private readonly ILoggerService _loggerService;

    public ArchiveManagerLoader(IArchiveManager archiveManager, ISettingsManager settingsManager,
        IProgressService<double> progressService, Red4ParserService parserService, ILoggerService loggerService)
    {
        _archiveManager = archiveManager;
        _settingsManager = settingsManager;
        _progressService = progressService;
        _parserService = parserService;
        _loggerService = loggerService;
    }

    /// <summary>
    /// Loads the basegame + EP1 archives on a background thread.
    /// While loading, a 100ms repeating timer forces the global ProgressService
    /// into Running/Indeterminate state. This mitigates the problem that there is
    /// only a single global "Ready/Running" state — other code can (and does)
    /// call Completed() or set IsIndeterminate=false while this long job is still
    /// in progress.
    /// </summary>
    public async Task LoadArchiveManagerAsync()
    {
        // Fast path checks — do NOT start the loading indicator if there's nothing to do.
        if (_archiveManager.IsManagerLoaded)
        {
            return;
        }

        if (_settingsManager.CP77ExecutablePath is null)
        {
            _loggerService.Warning("Cyberpunk 2077 executable path is not set. Skipping Archive Manager load.");
            return;
        }

        using var loadingIndicator = BeginLoadingIndicator();

        try
        {
            await Task.Run(() =>
            {
                // Keep priority low so the UI stays responsive during the (potentially long)
                // first-time scan of dozens of large .archive files.
                Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;
                Thread.CurrentThread.IsBackground = true;

                _loggerService.Info("Loading Archive Manager ... ");

                _archiveManager.LoadGameArchives(new FileInfo(_settingsManager.CP77ExecutablePath));

                // Custom hash population needs the archives to be loaded, so do it here on the same thread.
                LoadCustomHashes();
            });

            _loggerService.Success("Finished loading Archive Manager.");
        }
        catch (Exception e)
        {
            _loggerService.Error(e);
            throw;
        }
    }

    /// <summary>
    /// Starts the archive-loading progress heartbeat and returns a scope that releases it.
    ///
    /// The heartbeat is reference counted on <see cref="ArchiveLoadingPurpose"/>, so overlapping
    /// loads — RED4Controller is registered transient, so the app view model, the asset browser
    /// and the materials dialog each hold their own instance — share a single timer. The
    /// indicator is only reset to Ready once the last loader disposes its scope, rather than
    /// whichever loader happens to finish first.
    /// </summary>
    private IDisposable BeginLoadingIndicator() =>
        DispatcherHelper.StartRepeatingAction(
            purpose: IArchiveManagerLoader.ArchiveLoadingPurpose,
            () =>
            {
                _progressService.IsIndeterminate = true;
                _progressService.Status = EStatus.Running;
            },
            TimeSpan.FromMilliseconds(100),
            onCancelled: () =>
            {
                _progressService.IsIndeterminate = false;
                _progressService.Status = EStatus.Ready;
            }
        );

    private void LoadCustomHashes()
    {
        ResourcePath physMatLibPath = "base\\physics\\physicsmaterials.physmatlib";
        ResourcePath presetPath = "engine\\physics\\collision_presets.json";

        var physMatLib = _archiveManager.Lookup(physMatLibPath);
        if (physMatLib.HasValue)
        {
            using MemoryStream ms = new();
            physMatLib.Value.Extract(ms);
            ms.Position = 0;

            if (_parserService.TryReadRed4File(ms, out var fileMaybeNull) && fileMaybeNull is { } file)
            {
                var root = (physicsMaterialLibraryResource)file.RootChunk;

                foreach (var physMat in root.MaterialNames)
                {
                    if (!physMat.IsResolvable)
                    {
                        continue;
                    }

                    CNamePool.AddOrGetHash(physMat.GetResolvedText()!);
                }
            }
        }

        var preset = _archiveManager.Lookup(presetPath);
        if (preset.HasValue)
        {
            using MemoryStream ms = new();
            preset.Value.Extract(ms);
            ms.Position = 0;

            if (_parserService.TryReadRed4File(ms, out var fileMaybeNull) && fileMaybeNull is { } file)
            {
                var root = (JsonResource)file.RootChunk;
                var res = (physicsCollisionPresetsResource)root.Root.Chunk.NotNull();

                foreach (var presetEntry in res.Presets)
                {
                    if (presetEntry is not { Name: { IsResolvable: true } name })
                    {
                        continue;
                    }

                    CNamePool.AddOrGetHash(name.GetResolvedText()!);
                }
            }
        }
    }
}
