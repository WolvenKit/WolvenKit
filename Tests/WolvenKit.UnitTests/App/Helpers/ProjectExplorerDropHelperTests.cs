using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using Xunit;
using static WolvenKit.App.Helpers.ProjectExplorerDropHelper;

namespace Wolvenkit.Test.App.Helpers;

public sealed class ProjectExplorerDropHelperTests : IDisposable
{
    private readonly string _projectDirectory;

    public ProjectExplorerDropHelperTests()
    {
        _projectDirectory = Path.Combine(Path.GetTempPath(), "wk-drophelper-tests", Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(_projectDirectory);
    }

    public void Dispose()
    {
        try
        {
            Directory.Delete(_projectDirectory, true);
        }
        catch (IOException)
        {
            // a leaked temp directory must never fail a test run
        }
    }

    #region helpers

    private FileSystemModel NewRoot() =>
        new(null, FileSystemModel.ProjectDirName, _projectDirectory, true);

    private FileSystemModel NewDirectory(FileSystemModel parent, string name)
    {
        var relativePath = RelativePathOf(parent, name);
        Directory.CreateDirectory(Path.Combine(_projectDirectory, relativePath));

        var model = new FileSystemModel(parent, name, relativePath, true);
        AddChild(parent, model);
        return model;
    }

    private FileSystemModel NewFile(FileSystemModel parent, string name)
    {
        var relativePath = RelativePathOf(parent, name);
        File.WriteAllBytes(Path.Combine(_projectDirectory, relativePath), []);

        var model = new FileSystemModel(parent, name, relativePath, false);
        AddChild(parent, model);
        return model;
    }

    private static string RelativePathOf(FileSystemModel parent, string name) =>
        parent.Parent == null ? name : Path.Combine(parent.RawRelativePath, name);

    private static void AddChild(FileSystemModel parent, FileSystemModel child) =>
        ((ObservableCollection<FileSystemModel>)parent.Children).Add(child);

    private static string[] PathsOf(params FileSystemModel[] models) =>
        models.Select(model => model.FullName).ToArray();

    private static DropPayload TreeDrag(params FileSystemModel[] models) =>
        new(DropSource.TreeRows, PathsOf(models));

    private static DropPayload ExternalDrop(params string[] paths) =>
        new(DropSource.ExternalFiles, paths);

    private static string OutsidePath(string name) =>
        Path.Combine(Path.GetTempPath(), "wk-drophelper-elsewhere", name);

    private static DropPlan Plan(
        FileSystemModel? targetItem,
        DropPayload payload,
        IReadOnlyList<FileSystemModel> selectedModels,
        bool isCopy = false) =>
        PlanDrop(targetItem, payload, selectedModels, isCopy);

    private sealed record Node(object? Item);

    private static object? ItemOf(Node node) => node.Item;

    private static DataObject NodeDrag(params FileSystemModel?[] items) =>
        new(TreeNodeDataFormat, new ObservableCollection<Node>(items.Select(item => new Node(item))));

    #endregion

    #region unpacking the payload

    [Fact]
    public void GetDroppedPayload_FromAnInTreeDrag_ReturnsTheFullNameOfEveryDraggedRow()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var directory = NewDirectory(archive, "directory");
        var file = NewFile(archive, "foo.mesh");

        var payload = GetDroppedPayload<Node>(NodeDrag(directory, file), ItemOf);

        Assert.Equal(DropSource.TreeRows, payload.Source);
        Assert.Equal(PathsOf(directory, file), payload.Paths);
    }

    [Fact]
    public void GetDroppedPayload_FromAnExternalFileDrop_ReturnsThePathsAsGiven()
    {
        var external = OutsidePath("external.mesh");

        var payload = GetDroppedPayload<Node>(new DataObject(DataFormats.FileDrop, new[] { external }), ItemOf);

        // nothing here has a model behind it, so the paths are passed through untouched
        Assert.Equal(DropSource.ExternalFiles, payload.Source);
        Assert.Equal(new[] { external }, payload.Paths);
    }

    [Fact]
    public void GetDroppedPayload_WhenThePayloadCarriesBothFormats_PrefersTheExternalFiles()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var file = NewFile(archive, "foo.mesh");
        var external = OutsidePath("external.mesh");

        var dropData = NodeDrag(file);
        dropData.SetData(DataFormats.FileDrop, new[] { external });

        var payload = GetDroppedPayload<Node>(dropData, ItemOf);

        Assert.Equal(DropSource.ExternalFiles, payload.Source);
        Assert.Equal(new[] { external }, payload.Paths);
    }

    [Fact]
    public void GetDroppedPayload_SkipsDraggedRowsThatAreNotBoundToAFileSystemModel()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var file = NewFile(archive, "foo.mesh");

        var payload = GetDroppedPayload<Node>(NodeDrag(null, file), ItemOf);

        Assert.Equal(PathsOf(file), payload.Paths);
    }

    [Fact]
    public void GetDroppedPayload_FromAnEmptyDrag_IsAnEmptyTreeDrag()
    {
        var payload = GetDroppedPayload<Node>(NodeDrag(), ItemOf);

        Assert.Equal(DropSource.TreeRows, payload.Source);
        Assert.Empty(payload.Paths);
    }

    [Fact]
    public void GetDroppedPayload_FromAPayloadInNeitherFormat_HasNoSource()
    {
        var payload = GetDroppedPayload<Node>(new DataObject(DataFormats.UnicodeText, "not a drag"), ItemOf);

        Assert.Equal(DropSource.None, payload.Source);
        Assert.Empty(payload.Paths);
    }

    [Fact]
    public void GetDroppedPayload_FromRowsOfSomeOtherGrid_HasNoSource()
    {
        // the format is right but the rows are not ours, so the typed cast declines them
        var dropData = new DataObject(TreeNodeDataFormat, new ObservableCollection<string> { "surprise" });

        var payload = GetDroppedPayload<Node>(dropData, ItemOf);

        Assert.Equal(DropSource.None, payload.Source);
        Assert.Empty(payload.Paths);
    }

    #endregion

    #region no target

    [Fact]
    public void PlanDrop_WithoutATarget_IsRejected()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var file = NewFile(archive, "foo.mesh");

        var plan = Plan(null, TreeDrag(file), [file]);

        Assert.False(plan.IsActionable);
        Assert.Equal(DropRejection.NoTarget, plan.Rejection);
        Assert.Empty(plan.Files);
        Assert.Null(plan.TargetDirectory);
    }

    [Fact]
    public void PlanDrop_OntoAParentlessFile_IsRejectedRatherThanThrowing()
    {
        // a file node with no parent has no directory to drop into. FileSystemModel.TargetDir
        // throws for this; planning is also driven from DragOver, where an exception per mouse
        // move would be a very bad way to find out.
        var orphanPath = Path.Combine(_projectDirectory, "orphan.mesh");
        File.WriteAllBytes(orphanPath, []);
        var orphan = new FileSystemModel(null, "orphan.mesh", orphanPath, false);

        var plan = Plan(orphan, ExternalDrop(orphanPath), []);

        Assert.Equal(DropRejection.NoTarget, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_RejectedPlan_StillReportsWhereTheDropLanded()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var directory = NewDirectory(archive, "directory");

        var plan = Plan(directory, TreeDrag(directory), [directory]);

        Assert.False(plan.IsActionable);
        Assert.Equal(directory.FullName, plan.TargetDirectory);
    }

    #endregion

    #region the project root is not a drop target

    [Fact]
    public void PlanDrop_OntoAFileInTheProjectRoot_IsRefused()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var projectFile = NewFile(root, "mymod.cdproj");
        var file = NewFile(archive, "foo.mesh");

        var plan = Plan(projectFile, TreeDrag(file), [file]);

        // the target would be <ProjectDir>, which is outside archive/raw/resources - a file moved
        // there drops out of the mod with nothing to show for it
        Assert.False(plan.IsActionable);
        Assert.Equal(DropRejection.ProjectRoot, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_OntoATopLevelDirectory_IsFine()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var raw = NewDirectory(root, "raw");
        var file = NewFile(raw, "foo.mesh");

        var plan = Plan(archive, TreeDrag(file), [file]);

        Assert.True(plan.IsActionable);
        Assert.Equal(archive.FullName, plan.TargetDirectory);
    }

    #endregion

    #region target directory resolution

    [Fact]
    public void PlanDrop_OntoADirectory_TargetsThatDirectory()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var destination = NewDirectory(archive, "destination");
        var file = NewFile(source, "foo.mesh");

        var plan = Plan(destination, TreeDrag(file), [file]);

        Assert.True(plan.IsActionable);
        Assert.Equal(destination.FullName, plan.TargetDirectory);
        Assert.Equal(PathsOf(file), plan.Files);
    }

    [Fact]
    public void PlanDrop_OntoAFile_TargetsTheDirectoryThatHoldsIt()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var destination = NewDirectory(archive, "destination");
        var file = NewFile(source, "foo.mesh");
        var neighbour = NewFile(destination, "bar.mesh");

        var plan = Plan(neighbour, TreeDrag(file), [file]);

        Assert.True(plan.IsActionable);
        Assert.Equal(destination.FullName, plan.TargetDirectory);
    }

    #endregion

    #region narrowing an in-tree drag to the selection

    [Fact]
    public void PlanDrop_InTreeDrag_DropsPayloadEntriesThatAreNotSelected()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var destination = NewDirectory(archive, "destination");
        var selected = NewFile(source, "selected.mesh");
        var alsoDragged = NewFile(source, "stowaway.mesh");

        // the grid can hand over more than the user last clicked; only the selection counts
        var plan = Plan(destination, TreeDrag(selected, alsoDragged), [selected]);

        Assert.Equal(PathsOf(selected), plan.Files);
    }

    [Fact]
    public void PlanDrop_InTreeDrag_MatchesPayloadPathsCaseInsensitively()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var destination = NewDirectory(archive, "destination");
        var file = NewFile(source, "foo.mesh");

        var plan = Plan(destination, new DropPayload(DropSource.TreeRows, [file.FullName.ToUpperInvariant()]), [file]);

        // Windows paths are case insensitive, so an upper-cased payload is the same file
        Assert.True(plan.IsActionable);
        Assert.Equal(new[] { file.FullName.ToUpperInvariant() }, plan.Files);
    }

    [Fact]
    public void PlanDrop_InTreeDragWithNothingSelected_KeepsThePayloadAsItIs()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var destination = NewDirectory(archive, "destination");
        var file = NewFile(source, "foo.mesh");

        var plan = Plan(destination, TreeDrag(file), []);

        Assert.True(plan.IsActionable);
        Assert.Equal(PathsOf(file), plan.Files);
    }

    [Fact]
    public void PlanDrop_ExternalFiles_AreNotNarrowedByTheTreeSelection()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var destination = NewDirectory(archive, "destination");
        var stillSelected = NewFile(source, "foo.mesh");

        var external = OutsidePath("external.mesh");

        var plan = Plan(destination, ExternalDrop(external), [stillSelected]);

        // a file dragged in from Explorer can never be in the tree selection, so narrowing to it
        // would silently import nothing whenever any row happened to be selected
        Assert.True(plan.IsActionable);
        Assert.Equal(new[] { external }, plan.Files);
    }

    #endregion

    #region dropping onto where the files already are

    [Fact]
    public void PlanDrop_DirectoryOntoItself_HasNothingToMove()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var directory = NewDirectory(archive, "directory");

        var plan = Plan(directory, TreeDrag(directory), [directory]);

        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
        Assert.Empty(plan.Files);
    }

    [Fact]
    public void PlanDrop_DirectoryOntoItself_IsRefusedEvenWithNothingSelected()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var directory = NewDirectory(archive, "directory");

        // the rules are decided on the payload; the selection only ever narrows it
        var plan = Plan(directory, TreeDrag(directory), []);

        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_DirectoryOntoItsOwnParent_HasNothingToMove()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var directory = NewDirectory(archive, "directory");

        var plan = Plan(archive, TreeDrag(directory), [directory]);

        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_FileOntoTheDirectoryItAlreadyLivesIn_HasNothingToMove()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var file = NewFile(source, "foo.mesh");

        var plan = Plan(source, TreeDrag(file), [file]);

        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_FileOntoItself_HasNothingToMove()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var file = NewFile(source, "foo.mesh");

        var plan = Plan(file, TreeDrag(file), [file]);

        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_FileOntoASiblingFile_HasNothingToMove()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var file = NewFile(source, "foo.mesh");
        var sibling = NewFile(source, "bar.mesh");

        // the sibling resolves to the same directory the file is already in
        var plan = Plan(sibling, TreeDrag(file), [file]);

        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_MixedDrop_KeepsTheEntriesThatAreNotAlreadyInTheTarget()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var destination = NewDirectory(archive, "destination");
        var moving = NewFile(source, "moving.mesh");
        var alreadyThere = NewFile(destination, "resident.mesh");

        var plan = Plan(destination, TreeDrag(moving, alreadyThere), [moving, alreadyThere]);

        Assert.True(plan.IsActionable);
        Assert.Equal(PathsOf(moving), plan.Files);
    }

    #endregion

    #region ctrl-drag duplicates in place

    [Fact]
    public void PlanDrop_CopyingAFileOntoItsOwnDirectory_IsKept()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var file = NewFile(source, "foo.mesh");

        var plan = Plan(source, TreeDrag(file), [file], isCopy: true);

        // this is how a file is duplicated: ProcessFileAction sees the collision and offers a
        // rename, or falls back to a "_copy" suffix. Pruning it as a no-op move kills the feature.
        Assert.True(plan.IsActionable);
        Assert.Equal(PathsOf(file), plan.Files);
    }

    [Fact]
    public void PlanDrop_CopyingADirectoryOntoItsOwnParent_IsKept()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var directory = NewDirectory(archive, "directory");

        var plan = Plan(archive, TreeDrag(directory), [directory], isCopy: true);

        // same thing one level up: the folder is duplicated as "directory_copy"
        Assert.True(plan.IsActionable);
        Assert.Equal(PathsOf(directory), plan.Files);
    }

    [Fact]
    public void PlanDrop_CopyingADirectoryOntoItself_IsStillRefused()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var directory = NewDirectory(archive, "directory");

        var plan = Plan(directory, TreeDrag(directory), [directory], isCopy: true);

        // there is no sensible reading of copying a directory into itself
        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_CopyingADirectoryIntoItsOwnDescendant_IsStillRefused()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var parent = NewDirectory(archive, "parent");
        var child = NewDirectory(parent, "child");

        var plan = Plan(child, TreeDrag(parent), [parent], isCopy: true);

        // worse than the move: the copy would be walking a tree it is writing into
        Assert.Equal(DropRejection.DirectoryIntoOwnDescendant, plan.Rejection);
    }

    #endregion

    #region entries that travel with an ancestor

    [Fact]
    public void PlanDrop_SelectedDirectoryAndItsContents_ListsOnlyTheDirectory()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var destination = NewDirectory(archive, "destination");
        var nested = NewDirectory(source, "nested");
        var file = NewFile(nested, "foo.mesh");

        var plan = Plan(destination, TreeDrag(source, nested, file), [source, nested, file]);

        // the children move inside their parent, so naming them separately would move them twice
        Assert.True(plan.IsActionable);
        Assert.Equal(PathsOf(source), plan.Files);
    }

    [Fact]
    public void PlanDrop_WholeSelectedSubtreeOntoItsContainer_HasNothingToMove()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var nested = NewDirectory(archive, "nested");
        var deeper = NewDirectory(nested, "deeper");
        var file = NewFile(deeper, "foo.mesh");

        var plan = Plan(archive, TreeDrag(nested, deeper, file), [nested, deeper, file]);

        // "deeper" and the file travel with "nested", and "nested" is already in "archive"
        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_ItemUnderAnUnselectedDirectory_IsStillMovedOnItsOwn()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var nested = NewDirectory(archive, "nested");
        var file = NewFile(nested, "foo.mesh");

        var plan = Plan(archive, TreeDrag(file), [file]);

        // "nested" is not being dragged, so it stays put - which makes moving the file up to
        // "archive" a real move, not a no-op
        Assert.True(plan.IsActionable);
        Assert.Equal(PathsOf(file), plan.Files);
    }

    #endregion

    #region a directory may not move into its own descendant

    [Fact]
    public void PlanDrop_DirectoryIntoItsOwnChild_IsRefused()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var parent = NewDirectory(archive, "parent");
        var child = NewDirectory(parent, "child");

        var plan = Plan(child, TreeDrag(parent), [parent]);

        Assert.False(plan.IsActionable);
        Assert.Equal(DropRejection.DirectoryIntoOwnDescendant, plan.Rejection);
        Assert.Empty(plan.Files);
        Assert.Equal(PathsOf(parent), plan.RefusedDirectories);
    }

    [Fact]
    public void PlanDrop_DirectoryIntoADeepDescendant_IsRefused()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var parent = NewDirectory(archive, "parent");
        var child = NewDirectory(parent, "child");
        var grandChild = NewDirectory(child, "grandchild");

        var plan = Plan(grandChild, TreeDrag(parent), [parent]);

        Assert.Equal(DropRejection.DirectoryIntoOwnDescendant, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_DirectoryOntoAFileInsideItself_IsRefused()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var parent = NewDirectory(archive, "parent");
        var child = NewDirectory(parent, "child");
        var file = NewFile(child, "foo.mesh");

        // dropping on the file resolves to "child", which is still inside "parent"
        var plan = Plan(file, TreeDrag(parent), [parent]);

        Assert.Equal(DropRejection.DirectoryIntoOwnDescendant, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_OneIllegalDirectory_StillMakesTheLegalMoves()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var parent = NewDirectory(archive, "parent");
        var child = NewDirectory(parent, "child");
        var elsewhere = NewDirectory(archive, "elsewhere");
        var innocent = NewFile(elsewhere, "foo.mesh");

        var plan = Plan(child, TreeDrag(parent, innocent), [parent, innocent]);

        // only the offending directory is dropped; refusing the whole gesture would make a
        // multi-select drag all-or-nothing for a reason the user cannot see
        Assert.True(plan.IsActionable);
        Assert.Equal(PathsOf(innocent), plan.Files);
        Assert.Equal(PathsOf(parent), plan.RefusedDirectories);
    }

    [Fact]
    public void PlanDrop_DirectoryIntoItsOwnDescendant_IsRefusedWithNothingSelected()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var parent = NewDirectory(archive, "parent");
        var child = NewDirectory(parent, "child");

        var plan = Plan(child, TreeDrag(parent), []);

        // the rule is evaluated on the payload, so an empty or stale selection cannot smuggle a
        // directory into its own child
        Assert.Equal(DropRejection.DirectoryIntoOwnDescendant, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_ExternalDirectoryContainingTheTarget_IsRefused()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var parent = NewDirectory(archive, "parent");
        var child = NewDirectory(parent, "child");

        // the same folder dragged in from an Explorer window: no model, only a path
        var plan = Plan(child, ExternalDrop(parent.FullName), []);

        Assert.Equal(DropRejection.DirectoryIntoOwnDescendant, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_FileWhoseDirectoryIsAnAncestorOfTheTarget_IsFine()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var parent = NewDirectory(archive, "parent");
        var child = NewDirectory(parent, "child");
        var file = NewFile(parent, "foo.mesh");

        var plan = Plan(child, TreeDrag(file), [file]);

        // only a directory can contain its destination; a file moving down is a normal move
        Assert.True(plan.IsActionable);
        Assert.Equal(PathsOf(file), plan.Files);
    }

    [Fact]
    public void PlanDrop_DirectoryWhoseNameIsAPrefixOfTheTargets_IsFine()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var baseDir = NewDirectory(archive, "base");
        var baseTwo = NewDirectory(archive, "base2");
        var destination = NewDirectory(baseTwo, "sub");

        var plan = Plan(destination, TreeDrag(baseDir), [baseDir]);

        // "...\archive\base2\sub" starts with "...\archive\base" without being inside it - the
        // containment check has to land on a separator, not just on a prefix
        Assert.True(plan.IsActionable);
        Assert.Equal(PathsOf(baseDir), plan.Files);
    }

    #endregion

    #region payload edge cases

    [Fact]
    public void PlanDrop_EmptyPayload_HasNothingToMove()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var destination = NewDirectory(archive, "destination");

        var plan = Plan(destination, new DropPayload(DropSource.None, []), []);

        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_PayloadListedTwice_KeepsOneCopyOfIt()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var source = NewDirectory(archive, "source");
        var destination = NewDirectory(archive, "destination");
        var file = NewFile(source, "foo.mesh");

        var plan = Plan(destination, ExternalDrop(file.FullName, file.FullName.ToUpperInvariant()), []);

        Assert.Equal(PathsOf(file), plan.Files);
    }

    [Fact]
    public void PlanDrop_TargetPathListedTwice_IsStillRecognisedAsASelfDrop()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var destination = NewDirectory(archive, "destination");

        var plan = Plan(destination, ExternalDrop(destination.FullName, destination.FullName), []);

        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_TargetPathSpelledInADifferentCase_IsStillRecognisedAsASelfDrop()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var destination = NewDirectory(archive, "destination");

        var plan = Plan(destination, ExternalDrop(destination.FullName.ToUpperInvariant()), []);

        // an Explorer drop can spell a path differently than the tree does, and NTFS does not care
        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_PathWithATrailingSeparator_IsStillRecognisedAsASelfDrop()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var destination = NewDirectory(archive, "destination");

        var plan = Plan(destination, ExternalDrop(destination.FullName + Path.DirectorySeparatorChar), []);

        Assert.Equal(DropRejection.NothingToMove, plan.Rejection);
    }

    [Fact]
    public void PlanDrop_DoesNotMutateItsInputs()
    {
        var root = NewRoot();
        var archive = NewDirectory(root, "archive");
        var directory = NewDirectory(archive, "directory");
        var file = NewFile(directory, "foo.mesh");

        var payload = new DropPayload(DropSource.TreeRows, PathsOf(directory, file));
        var selection = new List<FileSystemModel> { directory, file };

        Plan(directory, payload, selection);

        // the caller's selection is live grid state; the helper works on copies
        Assert.Equal(PathsOf(directory, file), payload.Paths);
        Assert.Equal(new[] { directory, file }, selection);
    }

    #endregion
}
