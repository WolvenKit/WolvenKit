using System;
using System.Linq;
using System.Threading.Tasks;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.Tools;
using FlaUI.Core.WindowsAPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WolvenKit.UITests.Helpers;

public sealed class ProjectExplorerUiActions
{
    // Path segments to navigate in the Asset Browser's left tree.
    // The first segment is the root archive node name as shown in the tree.
    private static readonly string[] AnimMotionDatabasePath =
    [
        "archive",
        "base",
        "animations",
        "anim_motion_database"
    ];

    private readonly WolvenKitTestFixture _fixture;
    private readonly Window _mainWindow;
    private readonly InspectableGridHelpers _grids;
    private readonly InspectableGridHelpers.WaitForElement _waitForElement;

    public ProjectExplorerUiActions(
        WolvenKitTestFixture fixture,
        Window mainWindow,
        InspectableGridHelpers grids,
        InspectableGridHelpers.WaitForElement waitForElement)
    {
        _fixture = fixture ?? throw new ArgumentNullException(nameof(fixture));
        _mainWindow = mainWindow ?? throw new ArgumentNullException(nameof(mainWindow));
        _grids = grids ?? throw new ArgumentNullException(nameof(grids));
        _waitForElement = waitForElement ?? throw new ArgumentNullException(nameof(waitForElement));
    }

    public AutomationElement? DragSingleFileToBaseDirectory()
    {
        var clickTarget = _grids.GetTargetByName(_grids.ProjectExplorerTreeGrid, "crowd_bumps.csv");
        var target = _grids.GetTargetByName(_grids.ProjectExplorerTreeGrid, "adam_smasher_weapons.csv");
        var dragTarget = _grids.GetTargetByName(_grids.ProjectExplorerTreeGrid, "base");
        Mouse.MoveTo(clickTarget.BoundingRectangle.Center());
        Task.Delay(50).Wait();
        Mouse.Click();
        Task.Delay(50).Wait();
        Mouse.MoveTo(target.BoundingRectangle.Center());
        Task.Delay(100).Wait();
        Mouse.Down();
        Task.Delay(100).Wait();
        Mouse.MoveTo(target.BoundingRectangle.ImmediateInteriorEast());
        Task.Delay(1000).Wait();
        Mouse.MoveTo(dragTarget.BoundingRectangle.Center());
        Task.Delay(100).Wait();
        Mouse.Up();
        Task.Delay(2000).Wait();
        var updatedDragTarget = _grids.GetTargetByName(_grids.ProjectExplorerTreeGrid, "adam_smasher_weapons.csv");
        return updatedDragTarget;
    }
}
