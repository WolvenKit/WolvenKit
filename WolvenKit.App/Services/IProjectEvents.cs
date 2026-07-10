using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Services;

/// <summary>
/// Service for published events related to file operations.
/// Provides an alternative to monitoring of file system events.
/// </summary>
public interface IProjectEvents
{
    /// <summary>
    /// Consumers of the published events should subscribe here.
    /// </summary>
    IObservable<FilesImportedMessage> FilesImported { get; }

    /// <summary>
    /// Consumers of completed-move events should subscribe here.
    /// </summary>
    IObservable<FilesMovedMessage> FilesMoved { get; }

    /// <summary>
    /// Consumers of completed-deletion events should subscribe here.
    /// </summary>
    IObservable<FilesDeletedMessage> FilesDeleted { get; }

    /// <summary>
    /// To be called when a known batch of files are being added to the project.
    /// E.g.: when adding files from AssetBrowser or exporting JSON, etc.
    /// NOTE: Be sure to disable monitoring of file system events before use.
    /// </summary>
    /// <param name="message"></param>
    void PublishFilesImported(FilesImportedMessage message);

    /// <summary>
    /// Publish an authoritative set of file moves that have <b>already happened on disk</b>.
    /// Call this AFTER the move completes and after any overwrite/confirmation prompts have been
    /// resolved, so the project explorer reflects what actually happened rather than what was
    /// intended. The apply is idempotent, so it is safe to publish whether or not the OS file
    /// system watcher is suspended (a live watcher's own events simply become no-ops).
    /// </summary>
    /// <param name="message"></param>
    void PublishFilesMoved(FilesMovedMessage message);

    /// <summary>
    /// Publish that a single file was deleted on disk (e.g. an overwrite target removed just before a
    /// move takes its place). Call this AFTER the delete has happened. The project explorer removes the
    /// matching node. Idempotent: a path the tree doesn't know is a no-op.
    /// </summary>
    /// <param name="absolutePath">Absolute path of the deleted file.</param>
    void PublishFileDeleted(string absolutePath);

    /// <summary>
    /// Publish that a directory (and everything under it) was deleted on disk. Call this AFTER the
    /// delete has happened. The project explorer removes the matching node and its whole subtree.
    /// Idempotent: a path the tree doesn't know is a no-op.
    /// </summary>
    /// <param name="absoluteDirectoryPath">Absolute path of the deleted directory.</param>
    void PublishDirectoryDeleted(string absoluteDirectoryPath);
}

/// <summary>
/// A list of files published. If other formats of file lists are needed to be used,
/// this record could be expanded upon.
/// </summary>
/// <param name="Files"></param>
public sealed record FilesImportedMessage(
    IReadOnlyList<IGameFile> GameFiles,
    IReadOnlyList<FileInfo> RawFiles
);

/// <summary>
/// An authoritative list of completed moves, each an absolute source path that was moved to an
/// absolute target path. Renames are moves too. Covers whole-directory moves as a flat list of the
/// files that were actually relocated (empty source directories left behind are reconciled by the
/// consumer). Emitted only for moves that succeeded, so declining an overwrite prompt simply omits
/// those files from the set. An entry with an empty <c>From</c> is a pure addition (e.g. a copy
/// target): the consumer just materializes <c>To</c> and performs no removal.
/// </summary>
/// <param name="Moves"></param>
public sealed record FilesMovedMessage(
    IReadOnlyList<(string From, string To)> Moves
);

/// <summary>
/// An authoritative list of absolute paths that were deleted on disk. A directory path implies its
/// entire subtree was removed; the consumer removes the matching node (recursing for directories).
/// </summary>
/// <param name="AbsolutePaths"></param>
public sealed record FilesDeletedMessage(
    IReadOnlyList<string> AbsolutePaths
);
