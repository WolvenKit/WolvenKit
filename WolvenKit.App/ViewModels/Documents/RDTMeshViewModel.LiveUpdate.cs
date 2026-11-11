using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Documents;

/// <summary>
/// Live material update: once materials were generated, the preview follows edits.
/// - edits in the open document (mesh materials, embedded files): every change marks the
///   document dirty (DocumentViewModel.ContentModified), the materials are rebuilt from the
///   in-memory mesh;
/// - saved project files (.mi, .mlsetup, .mlmask, .mltemplate, .xbm, .hp, .gradient, .mesh, .mt,
///   or any other file the materials were read from): a file
///   watcher on the project's archive folder drops them from the file cache.
/// Changes are collected for a moment (typing in a field changes the value on every key),
/// then one generation runs; unchanged materials stay cached (bake stamps include values
/// and file times), so only the edited ones are rebuilt.
/// </summary>
public partial class RDTMeshViewModel
{
    private const int LiveUpdateDelayMs = 700;

    private static readonly HashSet<string> s_liveExtensions = new(StringComparer.OrdinalIgnoreCase)
    {
        ".mi", ".mt", ".mlsetup", ".mlmask", ".mltemplate", ".xbm", ".mesh", ".hp", ".gradient",
    };

    private static bool s_liveMaterialUpdate = true;

    /// <summary>Follow edits of the mesh and its material files (shared by all preview tabs).</summary>
    public bool LiveMaterialUpdate
    {
        get => s_liveMaterialUpdate;
        set => SetProperty(ref s_liveMaterialUpdate, value);
    }

    private bool _liveHooked;
    private DocumentViewModel? _liveDocument;
    private FileSystemWatcher? _liveWatcher;
    private string? _liveModDirectory;
    private Timer? _liveTimer;
    private SynchronizationContext? _liveContext;
    private volatile bool _liveDocumentChanged;
    private readonly ConcurrentQueue<string> _liveChangedFiles = new();

    /// <summary>Hooks the document and the project folder once, after the first generation.</summary>
    private void EnsureLiveMaterialUpdate()
    {
        if (_liveHooked || _disposed)
        {
            return;
        }

        _liveHooked = true;
        _liveContext = SynchronizationContext.Current;

        if (Parent is DocumentViewModel document)
        {
            _liveDocument = document;
            document.ContentModified += OnLiveDocumentModified;
        }

        try
        {
            var modDirectory = Parent?.GetActiveProject()?.ModDirectory;
            if (!string.IsNullOrEmpty(modDirectory) && Directory.Exists(modDirectory))
            {
                _liveModDirectory = modDirectory;
                _liveWatcher = new FileSystemWatcher(modDirectory)
                {
                    IncludeSubdirectories = true,
                    NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Size,
                };
                _liveWatcher.Changed += OnLiveFileChanged;
                _liveWatcher.Created += OnLiveFileChanged;
                _liveWatcher.Renamed += OnLiveFileChanged;
                _liveWatcher.EnableRaisingEvents = true;
            }
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Debug($"[Preview] live update: no file watcher ({ex.Message})");
        }
    }

    private void StopLiveMaterialUpdate()
    {
        if (_liveDocument != null)
        {
            _liveDocument.ContentModified -= OnLiveDocumentModified;
            _liveDocument = null;
        }

        if (_liveWatcher != null)
        {
            _liveWatcher.EnableRaisingEvents = false;
            _liveWatcher.Dispose();
            _liveWatcher = null;
        }

        _liveTimer?.Dispose();
        _liveTimer = null;
    }

    private void OnLiveDocumentModified(object? sender, EventArgs e)
    {
        _liveDocumentChanged = true;
        ScheduleLiveUpdate();
    }

    private void OnLiveFileChanged(object sender, FileSystemEventArgs e)
    {
        // Known material file types, or any file the materials were built from (it is in the
        // file cache), so a type missing from the list (e.g. a new resource kind) still counts.
        if (!s_liveExtensions.Contains(Path.GetExtension(e.FullPath)) && !IsLoadedProjectFile(e.FullPath))
        {
            return;
        }

        _liveChangedFiles.Enqueue(e.FullPath);
        ScheduleLiveUpdate();
    }

    private bool IsLoadedProjectFile(string fullPath)
    {
        try
        {
            if (_liveModDirectory == null || !fullPath.StartsWith(_liveModDirectory, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return _fileCache.ContainsKey((ResourcePath)Path.GetRelativePath(_liveModDirectory, fullPath));
        }
        catch
        {
            return false;
        }
    }

    /// <summary>(Re)starts the delay; the update runs on the UI thread when it expires.</summary>
    private void ScheduleLiveUpdate()
    {
        if (!LiveMaterialUpdate || !_materialsGenerated || _disposed)
        {
            return;
        }

        _liveTimer ??= new Timer(_ =>
        {
            if (_liveContext != null)
            {
                _liveContext.Post(_ => _ = RunLiveUpdateAsync(), null);
            }
        }, null, Timeout.Infinite, Timeout.Infinite);
        _liveTimer.Change(LiveUpdateDelayMs, Timeout.Infinite);
    }

    private async Task RunLiveUpdateAsync()
    {
        if (_disposed || !LiveMaterialUpdate)
        {
            return;
        }

        if (IsLoadingMaterials)
        {
            ScheduleLiveUpdate(); // try again after the running generation
            return;
        }

        var filesChanged = false;
        while (_liveChangedFiles.TryDequeue(out var fullPath))
        {
            filesChanged = true;
            if (_liveModDirectory != null && fullPath.StartsWith(_liveModDirectory, StringComparison.OrdinalIgnoreCase))
            {
                var relative = Path.GetRelativePath(_liveModDirectory, fullPath);
                _fileCache.TryRemove((ResourcePath)relative, out _);
            }
        }

        if (filesChanged)
        {
            _templateCache.Clear();
        }

        var documentChanged = _liveDocumentChanged;
        _liveDocumentChanged = false;
        if (!filesChanged && !documentChanged)
        {
            return;
        }

        try
        {
            await GenerateMaterials(clearCache: false, refreshFromDisk: false, rebuildMaterials: true);
        }
        catch (Exception ex)
        {
            Parent?.GetLoggerService()?.Warning($"[Preview] live update: {ex.Message}");
        }
    }
}
