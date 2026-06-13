using SwiftXStateWinBridgeInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;

namespace WolvenKit.App.ViewModels.Tools;

public partial class ProjectExplorerViewModel
{
    // The single source of truth for the project explorer's two grids. Their ItemsSource
    // collections (FileTree, FileList) live on this object, and it runs the GridFlow machine that
    // says what mode the UI is in. It's constructed here and handed to the WatcherService, so there
    // is exactly one owner of those collections rather than the watcher minting its own.
    private readonly GridGuard _gridGuard = new();

    /// <summary>The grid source-of-truth: owns FileTree/FileList and runs the GridFlow machine.</summary>
    public GridGuard Guard => _gridGuard;

    /// <summary>
    /// True while a high-level operation owns the grids (the machine is not in Ready). External
    /// writers should check this before touching the grids or the models behind their ItemsSource.
    /// </summary>
    public bool GridsLocked => _gridGuard.GridsLocked;
}

public static class GridFlow
{
    public enum State { Ready, MakingChangesToFiles, AwaitingRedrawsOfGrids }

    public enum Event
    {
        ChangeRequestReceived,
        ChangeRequestDenialSent,
        ChangeRequestApprovalSent,
        ChangeRequestCarriedOut,
        RequestedChangesConfirmedMade,
        GridUpdateConfirmedCompleted,
    }

    // THE machine, fully typed. This is the only place transitions live; the JSON is generated from it,
    // so the bridge can never see a state/event that isn't in these enums. Self-targets are "legal here
    // but no mode change" (the machine still validates them).
    private static readonly Dictionary<State, Dictionary<Event, State>> Table = new()
    {
        [State.Ready] = new()
        {
            [Event.ChangeRequestReceived]    = State.Ready,
            [Event.ChangeRequestDenialSent]  = State.Ready,
            [Event.ChangeRequestApprovalSent] = State.MakingChangesToFiles,
        },
        [State.MakingChangesToFiles] = new()
        {
            [Event.ChangeRequestCarriedOut]       = State.MakingChangesToFiles,
            [Event.RequestedChangesConfirmedMade] = State.AwaitingRedrawsOfGrids,
        },
        [State.AwaitingRedrawsOfGrids] = new()
        {
            [Event.GridUpdateConfirmedCompleted] = State.Ready,
        },
    };

    public const State Initial = State.Ready;
    private const string MachineId = "gridGuard";

    // Wire string = the enum name with a lowercase first letter (e.g. MakingChangesToFiles ->
    // "makingChangesToFiles"). One conversion, used both ways.
    public static string Wire<T>(T value) where T : Enum
    {
        var name = value.ToString();
        return char.ToLowerInvariant(name[0]) + name.Substring(1);
    }

    public static bool TryParseState(string wire, out State state) =>
        Enum.TryParse(wire, ignoreCase: true, out state);   // "ready" -> State.Ready, etc.

    // Built once; the XState JSON the bridge expects, generated from Table.
    public static readonly string DefinitionJson = BuildJson();

    private static string BuildJson()
    {
        var states = new Dictionary<string, object>();
        foreach (var (state, transitions) in Table)
        {
            var on = new Dictionary<string, string>();
            foreach (var (evt, target) in transitions)
                on[Wire(evt)] = Wire(target);
            states[Wire(state)] = new { on };
        }
        var definition = new { id = MachineId, initial = Wire(Initial), states };
        return JsonSerializer.Serialize(definition);
    }
}

/// <summary>
/// GridGuard is the single source of truth for ProjectExplorerView's two grids: the hierarchical
/// TreeGrid (<see cref="FileTree"/>) and the flat DataGrid (<see cref="FileList"/>).
///
/// It has two jobs:
///   1. It OWNS the node objects the grids bind to. These are CLONES — separate FileSystemModel
///      instances from the "domain" models the watcher builds and the rest of the app mutates. The
///      grids never bind to the wild domain models, so when other code renames a model, clears its
///      Children, or removes one, the grids don't see it and don't corrupt. The watcher reports each
///      approved domain change here via the Project* intents, and the shim re-applies it to the
///      clones on the UI thread. One owner, one truth.
///   2. It runs the GridFlow state machine (in Swift, over the C bridge) tracking what the UI is
///      doing right now: Ready, MakingChangesToFiles, or AwaitingRedrawsOfGrids. Writers gate on
///      that mode instead of poking the grids whenever they feel like it.
///
/// The mode maps onto how the project explorer already behaves:
///   Ready                  - the watcher is live, the grids are safe to read and redraw.
///   MakingChangesToFiles   - a high-level operation suspended the watcher and is changing files.
///   AwaitingRedrawsOfGrids - the change is done; the grids are reconciling (the DeferRefresh window).
///
/// Clones are keyed by FullName (the absolute path), which matches the watcher's own _fileLookup,
/// so resolving a grid clone back to its domain model (e.g. for a delete) is a path lookup.
/// </summary>
public sealed class GridGuard : IDisposable
{
    /// <summary>Single source of truth for the flat DataGrid (TreeGridFlat.ItemsSource). Holds clones.</summary>
    public DispatchedObservableCollection<FileSystemModel> FileList { get; } = new();

    /// <summary>Single source of truth for the hierarchical TreeGrid (TreeGrid.ItemsSource). Holds clones.</summary>
    public DispatchedObservableCollection<FileSystemModel> FileTree { get; } = new();

    private readonly long _h;
    private readonly SwiftXStateWinBridge.SnapshotCallback _onState; // field, so the GC keeps it alive
    private readonly object _gate = new();

    /// <summary>
    /// Invisible root clone used only for hierarchy/FullName computation in the projection.
    /// Mirrors the domain's &lt;ProjectDir&gt; so that top-level folders ("archive", "raw", ...)
    /// and their descendants compute the exact same FullName as their domain counterparts.
    /// This makes _cloneByKey lookups by domain.FullName reliable and prevents duplicate clones.
    /// </summary>
    private FileSystemModel? _invisibleCloneRoot;

    /// <summary>Raised (from the bridge's callback) whenever the machine's mode changes.</summary>
    public event Action<GridFlow.State>? ModeChanged;

    public GridGuard()
    {
        _h = SwiftXStateWinBridge.MachineCreate(GridFlow.DefinitionJson);
        if (_h == 0) throw new InvalidOperationException("Bad grid-flow definition.");

        _onState = wire =>
        {
            if (GridFlow.TryParseState(wire, out var s)) ModeChanged?.Invoke(s);
        };
        SwiftXStateWinBridge.MachineSetStateCallback(_h, _onState);
    }

    public GridFlow.State Mode =>
        GridFlow.TryParseState(SwiftXStateWinBridge.MachineState(_h), out var s) ? s : GridFlow.Initial;

    public bool Is(GridFlow.State s) =>
        SwiftXStateWinBridge.MachineMatches(_h, GridFlow.Wire(s)) == 1;

    /// <summary>True whenever we are NOT in Ready, i.e. external writers must not touch the grids.</summary>
    public bool GridsLocked => !Is(GridFlow.State.Ready);

    /// <summary>Send a raw event. True if it was legal in the current mode (and applied).</summary>
    public bool Send(GridFlow.Event e)
    {
        lock (_gate)
        {
            return SwiftXStateWinBridge.MachineSend(_h, GridFlow.Wire(e)) == 1;
        }
    }

    // --- Named transitions (these read better at call sites than the raw events) -----------------

    /// <summary>Ready -> Ready: a writer is asking to change files. Logged; no mode change.</summary>
    public bool NotifyChangeRequested() => Send(GridFlow.Event.ChangeRequestReceived);

    /// <summary>Ready -> Ready: the request was denied. No mode change.</summary>
    public bool DenyChange() => Send(GridFlow.Event.ChangeRequestDenialSent);

    /// <summary>Ready -> MakingChangesToFiles. False if we weren't in Ready (someone else holds it).</summary>
    public bool BeginChanges() => Send(GridFlow.Event.ChangeRequestApprovalSent);

    /// <summary>MakingChangesToFiles -> self: a progress tick while a change is carried out.</summary>
    public bool NotifyChangeCarriedOut() => Send(GridFlow.Event.ChangeRequestCarriedOut);

    /// <summary>MakingChangesToFiles -> AwaitingRedrawsOfGrids.</summary>
    public bool ConfirmChangesMade() => Send(GridFlow.Event.RequestedChangesConfirmedMade);

    /// <summary>AwaitingRedrawsOfGrids -> Ready.</summary>
    public bool ConfirmRedrawComplete() => Send(GridFlow.Event.GridUpdateConfirmedCompleted);

    /// <summary>
    /// Force the machine back to Ready from wherever it is. Each Send is a no-op when illegal in the
    /// current mode, so this safely lands us in Ready whether we were Making, Awaiting, or already
    /// Ready. Used by the resume/refresh choke points so an operation can never strand the guard.
    /// </summary>
    public void ForceReady()
    {
        ConfirmChangesMade();     // Making -> Awaiting (no-op otherwise)
        ConfirmRedrawComplete();  // Awaiting -> Ready  (no-op otherwise)
    }

    /// <summary>
    /// Runs the full Ready -> MakingChanges -> AwaitingRedraws -> Ready cycle around a mutation.
    /// <paramref name="mutate"/> changes files/models; <paramref name="redraw"/> (optional) does the
    /// grid reconcile. If we cannot enter MakingChanges (the guard is busy), returns false and runs
    /// nothing rather than risk corruption. The machine is always walked back to Ready in the
    /// finally, so a throw can't strand it.
    /// </summary>
    public bool RunGuardedChange(Action mutate, Action? redraw = null)
    {
        if (!BeginChanges()) return false; // someone else holds the guard; bail
        try
        {
            mutate();
            ConfirmChangesMade();  // -> AwaitingRedrawsOfGrids
            redraw?.Invoke();
            return true;
        }
        finally
        {
            ForceReady();
        }
    }

    /// <summary>Async sibling of <see cref="RunGuardedChange"/> for command handlers that await.</summary>
    public async Task<bool> RunGuardedChangeAsync(Func<Task> mutate, Func<Task>? redraw = null)
    {
        if (!BeginChanges()) return false;
        try
        {
            await mutate().ConfigureAwait(false);
            ConfirmChangesMade();
            if (redraw is not null) await redraw().ConfigureAwait(false);
            return true;
        }
        finally
        {
            ForceReady();
        }
    }

    // ===========================================================================================
    //  Projection: the grids bind to the clone nodes below; the watcher reports domain changes via
    //  the Project* intents and the shim re-applies them to the clones. Every mutation of a bound
    //  collection happens inside DispatcherHelper.RunOnMainThread so the grids only ever see changes
    //  on the UI thread, and under _projGate so the clone map and collections stay consistent.
    // ===========================================================================================

    private readonly object _projGate = new();

    // FullName (absolute path) -> the single clone for that node. Shared between FileTree and FileList.
    private readonly Dictionary<string, FileSystemModel> _cloneByKey = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>Resolve a grid clone (e.g. the current selection) back to the key callers can hand
    /// the watcher to find the domain model. The clone and its domain model share a FullName, so
    /// callers normally just use clone.FullName directly; this is here for symmetry/readability.</summary>
    public string KeyOf(FileSystemModel gridNode) => gridNode.FullName;

    /// <summary>True if a clone exists for this path (i.e. the node is currently shown in the grids).</summary>
    public bool HasNode(string fullName)
    {
        lock (_projGate) { return _cloneByKey.ContainsKey(fullName); }
    }

    /// <summary>
    /// Rebuild the entire projection from a freshly built domain tree (used on project load/reload).
    /// Clears the clones and the key map, deep-clones each domain root, then rebuilds the flat list
    /// from the same clones so selection identity is consistent between the two grids.
    /// </summary>
    public void ProjectReset(IReadOnlyList<FileSystemModel> domainFlat, IReadOnlyList<FileSystemModel> domainTreeRoots)
    {
        DispatcherHelper.RunOnMainThread(() =>
        {
            lock (_projGate)
            {
                try
                {
                    _cloneByKey.Clear();
                    FileTree.Clear();
                    FileList.Clear();
                    _invisibleCloneRoot = null;

                    if (domainTreeRoots.Count > 0)
                    {
                        var first = domainTreeRoots[0];
                        if (first.Parent?.Name == FileSystemModel.ProjectDirName)
                        {
                            var inv = first.Parent;
                            _invisibleCloneRoot = new FileSystemModel(null, FileSystemModel.ProjectDirName, inv.RawRelativePath, true);
                            _cloneByKey[_invisibleCloneRoot.FullName] = _invisibleCloneRoot;
                        }
                    }

                    foreach (var root in domainTreeRoots)
                    {
                        var rootClone = CloneSubtree(root, _invisibleCloneRoot);
                        FileTree.Add(rootClone);

                        if (_invisibleCloneRoot != null && !_invisibleCloneRoot.Children.Contains(rootClone))
                        {
                            _invisibleCloneRoot.Children.Add(rootClone);
                        }
                    }

                    var flatClones = new List<FileSystemModel>(domainFlat.Count);
                    foreach (var d in domainFlat)
                    {
                        if (_cloneByKey.TryGetValue(d.FullName, out var c))
                        {
                            flatClones.Add(c);
                        }
                    }
                    FileList.AddRange(flatClones);
                }
                catch
                {
                    // Projection is best-effort; a file vanishing mid-clone must never crash the UI
                    // thread. A manual Refresh rebuilds cleanly.
                }
            }
        });
    }

    /// <summary>Project one or more newly-added domain nodes (FS create / import) onto the clones.</summary>
    public void ProjectAdd(IReadOnlyList<FileSystemModel> domainNodes)
    {
        if (domainNodes.Count == 0)
        {
            return;
        }

        DispatcherHelper.RunOnMainThread(() =>
        {
            lock (_projGate)
            {
                foreach (var d in domainNodes)
                {
                    try
                    {
                        EnsureClone(d);
                    }
                    catch
                    {
                        // Best-effort: skip a node that can't be cloned right now (e.g. file vanished).
                    }
                }
            }
        });
    }

    /// <summary>Project the removal of a domain node (and its whole subtree) onto the clones.</summary>
    public void ProjectRemove(FileSystemModel domainNode)
    {
        DispatcherHelper.RunOnMainThread(() =>
        {
            lock (_projGate)
            {
                if (_cloneByKey.TryGetValue(domainNode.FullName, out var clone))
                {
                    RemoveCloneSubtree(clone);
                }
            }
        });
    }

    /// <summary>Reflect a file-info change (size etc.) from a domain node onto its clone.</summary>
    public void ProjectUpdateFileInfo(FileSystemModel domainNode)
    {
        DispatcherHelper.RunOnMainThread(() =>
        {
            lock (_projGate)
            {
                try
                {
                    if (_cloneByKey.TryGetValue(domainNode.FullName, out var clone) && !clone.IsDirectory)
                    {
                        clone.UpdateFileInfo();
                    }
                }
                catch
                {
                    // Best-effort; reading a vanished file's size must not crash the UI thread.
                }
            }
        });
    }

    /// <summary>
    /// Reflect a rename onto the clone subtree. <paramref name="oldFullName"/> is the clone's key
    /// before the domain rename (the caller captures it just before mutating the domain model),
    /// since the rename changes FullName and we'd otherwise have no way to find the clone.
    /// </summary>
    public void ProjectRename(FileSystemModel domainNode, string oldFullName)
    {
        DispatcherHelper.RunOnMainThread(() =>
        {
            lock (_projGate)
            {
                if (!_cloneByKey.TryGetValue(oldFullName, out var clone) || clone.Parent is null)
                {
                    // No clone, or it's a tree root (FileSystemModel.Rename requires a parent). Roots
                    // (archive/raw/resources) don't get renamed in practice; a reload would fix it.
                    return;
                }

                try
                {
                    clone.Rename(domainNode.Name); // recomputes FullName/GameRelativePath/Hash and recurses children
                    RekeySubtree(clone);
                }
                catch
                {
                    // Best-effort; a failed in-place rename is reconciled by the next Refresh.
                }
            }
        });
    }

    // ---- projection internals (always called under _projGate, on the UI thread) -----------------

    private FileSystemModel CloneSubtree(FileSystemModel domain, FileSystemModel? cloneParent)
    {
        var clone = new FileSystemModel(cloneParent, domain.Name, domain.RawRelativePath, domain.IsDirectory, domain.IsExpanded);
        _cloneByKey[clone.FullName] = clone;

        foreach (var child in domain.Children.ToList())
        {
            clone.Children.Add(CloneSubtree(child, clone));
        }

        return clone;
    }

    private FileSystemModel GetOrCreateInvisibleClone(FileSystemModel domainInvisible)
    {
        if (_invisibleCloneRoot == null)
        {
            _invisibleCloneRoot = new FileSystemModel(null, FileSystemModel.ProjectDirName, domainInvisible.RawRelativePath, true);
            _cloneByKey[_invisibleCloneRoot.FullName] = _invisibleCloneRoot;
        }
        return _invisibleCloneRoot;
    }

    private FileSystemModel EnsureClone(FileSystemModel domain)
    {
        if (_cloneByKey.TryGetValue(domain.FullName, out var existing))
        {
            return existing;
        }

        // A node is a visible tree root when its domain parent is the invisible project root.
        // We still create a (hidden) invisible clone parent so that GetMetadata() on the clone
        // walks a correct base and produces *exactly* the same FullName as the domain model.
        // This makes _cloneByKey[domain.FullName] lookups succeed and prevents creating
        // duplicate clone instances for the same folder (the root cause of "multiple copies of
        // the same folder" in FileTree/FileList after adds, converts, and ProjectAdd).
        FileSystemModel? cloneParent = null;
        var dp = domain.Parent;
        if (dp is not null && dp.Name == FileSystemModel.ProjectDirName)
        {
            cloneParent = GetOrCreateInvisibleClone(dp);
        }
        else if (dp is not null)
        {
            cloneParent = EnsureClone(dp);
        }

        var clone = new FileSystemModel(cloneParent, domain.Name, domain.RawRelativePath, domain.IsDirectory, domain.IsExpanded);
        _cloneByKey[clone.FullName] = clone;

        if (cloneParent is not null && !cloneParent.Children.Contains(clone))
        {
            cloneParent.Children.Add(clone);
        }

        bool isVisibleRoot = (dp is not null && dp.Name == FileSystemModel.ProjectDirName) || dp == null;
        if (isVisibleRoot)
        {
            if (!FileTree.Contains(clone))
            {
                FileTree.Add(clone);
            }
        }

        if (!FileList.Contains(clone))
        {
            FileList.Add(clone);
        }

        return clone;
    }

    private void RemoveCloneSubtree(FileSystemModel clone)
    {
        foreach (var child in clone.Children.ToList())
        {
            RemoveCloneSubtree(child);
        }

        _cloneByKey.Remove(clone.FullName);

        if (FileList.Contains(clone))
        {
            FileList.Remove(clone);
        }

        if (clone.Parent is not null)
        {
            if (clone.Parent.Children.Contains(clone))
            {
                clone.Parent.Children.Remove(clone);
            }
        }
        else if (FileTree.Contains(clone))
        {
            FileTree.Remove(clone);
        }
    }

    private void RekeySubtree(FileSystemModel root)
    {
        var subtree = new HashSet<FileSystemModel>();
        Collect(root, subtree);

        // The subtree's FullNames just changed; drop any stale keys pointing at these clones, then
        // re-index them by their current FullName.
        foreach (var staleKey in _cloneByKey.Where(kv => subtree.Contains(kv.Value)).Select(kv => kv.Key).ToList())
        {
            _cloneByKey.Remove(staleKey);
        }

        foreach (var node in subtree)
        {
            _cloneByKey[node.FullName] = node;
        }

        static void Collect(FileSystemModel node, HashSet<FileSystemModel> into)
        {
            into.Add(node);
            foreach (var child in node.Children.ToList())
            {
                Collect(child, into);
            }
        }
    }

    public void Dispose()
    {
        SwiftXStateWinBridge.MachineSetStateCallback(_h, null);
        SwiftXStateWinBridge.MachineRelease(_h);
    }
}
