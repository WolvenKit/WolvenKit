using SwiftXStateWinBridgeInterop;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace WolvenKit.App.ViewModels.Tools;

public partial class ProjectExplorerViewModel
{
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

public sealed class GridGuard : IDisposable
{
    private readonly long _h;
    private readonly SwiftXStateWinBridge.SnapshotCallback _onState; // field, so the GC keeps it alive

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

    public bool GridsLocked => !Is(GridFlow.State.Ready);

    /// True if the event was legal in the current mode (and applied).
    public bool Send(GridFlow.Event e) =>
        SwiftXStateWinBridge.MachineSend(_h, GridFlow.Wire(e)) == 1;

    public void Dispose()
    {
        SwiftXStateWinBridge.MachineSetStateCallback(_h, null);
        SwiftXStateWinBridge.MachineRelease(_h);
    }
}
/*
var guard = new GridGuard();

guard.ModeChanged += mode => Dispatcher.Invoke(() =>
    BusyOverlay.Visibility = mode == GridFlow.State.Ready ? Visibility.Collapsed : Visibility.Visible);

guard.Send(GridFlow.Event.ChangeRequestReceived);

if (guard.Send(GridFlow.Event.ChangeRequestApprovalSent))   // -> MakingChangesToFiles
{
    ApplyToFiles(req);
    guard.Send(GridFlow.Event.RequestedChangesConfirmedMade);   // -> AwaitingRedrawsOfGrids
    // when the grid finishes:
    guard.Send(GridFlow.Event.GridUpdateConfirmedCompleted);    // -> Ready
}

// any writer:
if (guard.GridsLocked) return;
if (guard.Mode == GridFlow.State.AwaitingRedrawsOfGrids) { /* … */ //}/*
