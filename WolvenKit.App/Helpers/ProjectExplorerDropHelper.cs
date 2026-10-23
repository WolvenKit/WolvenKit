using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using WolvenKit.App.Models;

namespace WolvenKit.App.Helpers;

/// <summary>
/// Determinds what drag-and-drop should actually allow to happen, given the drop payload,
/// the current tree selection, and the node under the cursor.
/// </summary>
public static class ProjectExplorerDropHelper
{
    /// <summary>The format Syncfusion's row drag-and-drop files the dragged rows under.</summary>
    public const string TreeNodeDataFormat = "Nodes";

    /// <summary>Where the dropped paths came from. The two are not interchangeable.</summary>
    public enum DropSource
    {
        /// <summary>The payload carried neither format we understand.</summary>
        None,

        /// <summary>Rows dragged inside the Project Explorer, each backed by a <see cref="FileSystemModel"/>.</summary>
        TreeRows,

        /// <summary>Files dragged in from outside the application. (I.e. Windows Explorer).</summary>
        ExternalFiles
    }

    /// <summary>The dropped paths, plus where they came from.</summary>
    public sealed record DropPayload(DropSource Source, IReadOnlyList<string> Paths);

    /// <summary>Why a drop produced no file operation.</summary>
    public enum DropRejection
    {
        /// <summary>The drop is actionable.</summary>
        None,

        /// <summary>Nothing droppable was under the cursor.</summary>
        NoTarget,

        /// <summary>The drop would have landed in the project root, outside archive/raw/resources.</summary>
        ProjectRoot,

        /// <summary>Everything in the payload was filtered out - typically a drop onto where the files already are.</summary>
        NothingToMove,

        /// <summary>Every dragged directory would have been moved inside one of its own descendants.</summary>
        DirectoryIntoOwnDescendant
    }

    /// <summary>
    /// The outcome of PlanDrop: either a list of source paths plus the directory they
    /// should end up in, or the reason there is nothing to do.
    /// </summary>
    /// <param name="Rejection">Why nothing will happen, or DropRejection.None.</param>
    /// <param name="Files">Source paths to hand to ProjectExplorerViewModel.ProcessFileAction.</param>
    /// <param name="TargetDirectory">
    /// Absolute path of the directory to drop into. Null only when there was no target at all;
    /// it is populated even for a rejected plan, so a caller can log where the drop landed.
    /// </param>
    /// <param name="RefusedDirectories">
    /// Payload entries left out because they would have swallowed their own destination. The rest
    /// of the drop still goes ahead, so these are worth telling the user about.
    /// </param>
    public sealed record DropPlan(
        DropRejection Rejection,
        IReadOnlyList<string> Files,
        string? TargetDirectory,
        IReadOnlyList<string> RefusedDirectories)
    {
        /// <summary>True when the drop should be carried out. Implies TargetDirectory is not null.</summary>
        public bool IsActionable => Rejection == DropRejection.None;

        internal static DropPlan Rejected(
            DropRejection rejection,
            string? targetDirectory = null,
            IReadOnlyList<string>? refusedDirectories = null) =>
            new(rejection, [], targetDirectory, refusedDirectories ?? []);
    }

    /// <summary>
    /// Unpacks a drop payload into absolute paths.
    /// </summary>
    /// <typeparam name="TNode">The grid's row type - Syncfusion's <c>TreeNode</c> in practice.</typeparam>
    /// <param name="dropData">The dropped IDataObject.</param>
    /// <param name="itemOfNode">Reads the bound item off a dragged row.</param>
    /// <returns>
    /// The dropped paths in payload order, tagged with their source. Empty and
    /// "None" when the payload carries neither format.
    /// </returns>
    public static DropPayload GetDroppedPayload<TNode>(IDataObject dropData, Func<TNode, object?> itemOfNode)
    {
        if (dropData.GetDataPresent(DataFormats.FileDrop) && dropData.GetData(DataFormats.FileDrop) is string[] fileDropData)
        {
            return new DropPayload(DropSource.ExternalFiles, [.. fileDropData]);
        }

        if (dropData.GetDataPresent(TreeNodeDataFormat) && dropData.GetData(TreeNodeDataFormat) is IEnumerable<TNode> treeNodes)
        {
            return new DropPayload(
                DropSource.TreeRows,
                [.. treeNodes.Select(itemOfNode).OfType<FileSystemModel>().Select(model => model.FullName)]);
        }

        return new DropPayload(DropSource.None, []);
    }

    /// <summary>
    /// Decides which of the dropped paths may be moved into the directory implied by targetItem
    ///
    /// The rules, in the order they are applied:
    /// 1. A drop onto a file means a drop into the directory that holds it.
    /// 2. The project root is not a drop target: everything belongs under one of the top-level
    /// directories.
    /// 3. An in-tree drag is narrowed to the selection, because the grid hands over whatever it
    /// put on the clipboard. An external file drop is left alone - nothing in the tree stands
    /// behind those paths, so the selection says nothing about them.
    /// 4. A directory that contains the target is refused: it cannot be moved inside itself.
    /// Only that entry is dropped, so the rest of the drop still goes through.
    /// 5. The target directory itself is never moved into itself.
    /// 6. An entry that lives inside another entry is redundant - it travels with its
    /// ancestor.
    /// 7. Anything already sitting directly in the target directory is dropped, because moving
    /// it would be a no-op. When isCopy is set it is kept instead: copying onto
    /// its own location is how a file or folder is duplicated in place.
    /// </summary>
    /// <param name="targetItem">The node under the cursor. A file resolves to its parent directory.</param>
    /// <param name="payload">The dropped paths, from GetDroppedPayload.</param>
    /// <param name="selectedModels">The current Project Explorer selection.</param>
    /// <param name="isCopy">True when the drop will copy rather than move - i.e. ctrl is held.</param>
    public static DropPlan PlanDrop(
        FileSystemModel? targetItem,
        DropPayload payload,
        IReadOnlyList<FileSystemModel> selectedModels,
        bool isCopy)
    {
        // a file with no parent has no directory to drop into
        if (targetItem is null || (!targetItem.IsDirectory && targetItem.Parent is null))
        {
            return DropPlan.Rejected(DropRejection.NoTarget);
        }

        var targetDirModel = targetItem.TargetDir;
        var targetDirPath = targetDirModel.FullName;

        // only <ProjectDir> has no parent, and dropping there would take files out of the mod
        if (targetDirModel.Parent is null)
        {
            return DropPlan.Rejected(DropRejection.ProjectRoot, targetDirPath);
        }

        var paths = payload.Paths.Distinct(StringComparer.OrdinalIgnoreCase).ToList();

        if (payload.Source == DropSource.TreeRows && selectedModels.Count > 0)
        {
            var selectedPaths = selectedModels.Select(model => model.FullName).ToList();
            paths = paths.Where(path => selectedPaths.Any(selected => IsSamePath(selected, path))).ToList();
        }

        // A directory cannot be moved inside itself. Refuse just that entry: a drop that also
        // carries legal items should still make the legal moves.
        var refusedDirectories = paths.Where(path => IsInsideDirectory(targetDirPath, path)).ToList();

        var candidates = paths
            .Where(path => !IsInsideDirectory(targetDirPath, path))
            .Where(path => !IsSamePath(path, targetDirPath))
            .ToList();

        // Keep children with their parent: an entry inside another entry moves along with it, so
        // listing it separately would move it twice.
        var files = candidates
            .Where(path => !candidates.Any(other => IsInsideDirectory(path, other)))
            .ToList();

        // Dropping something back where it already is does nothing - unless this is a copy, in
        // which case it is how the file or folder gets duplicated in place.
        if (!isCopy)
        {
            files = files.Where(path => !IsSamePath(ParentDirectoryOf(path), targetDirPath)).ToList();
        }

        if (files.Count == 0)
        {
            return DropPlan.Rejected(
                refusedDirectories.Count > 0 ? DropRejection.DirectoryIntoOwnDescendant : DropRejection.NothingToMove,
                targetDirPath,
                refusedDirectories);
        }

        return new DropPlan(DropRejection.None, files, targetDirPath, refusedDirectories);
    }

    #region path comparison

    private static string ParentDirectoryOf(string path) =>
        Path.GetDirectoryName(TrimSeparator(path)) ?? "";

    private static bool IsSamePath(string left, string right) =>
        left.Length > 0
        && right.Length > 0
        && string.Equals(TrimSeparator(left), TrimSeparator(right), StringComparison.OrdinalIgnoreCase);

    private static bool IsInsideDirectory(string path, string directory)
    {
        var parent = TrimSeparator(directory);
        var candidate = TrimSeparator(path);

        if (parent.Length == 0
            || candidate.Length <= parent.Length
            || !candidate.StartsWith(parent, StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        // a prefix match is only a containment if it ends on a directory boundary, or the parent is
        // a root like "C:\" and already carries one
        return IsSeparator(parent[^1]) || IsSeparator(candidate[parent.Length]);
    }

    private static string TrimSeparator(string path) => Path.TrimEndingDirectorySeparator(path);

    private static bool IsSeparator(char character) =>
        character == Path.DirectorySeparatorChar || character == Path.AltDirectorySeparatorChar;

    #endregion
}
