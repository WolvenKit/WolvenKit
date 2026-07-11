using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WolvenKit.App.Services;

/// <summary>
/// Reconciles a before/after snapshot of an on-disk file set with the project explorer by publishing
/// the adds and removals to <see cref="IProjectEvents"/>.
///
/// Use this where the exact mutations aren't knowable up front — e.g. a script export that produces
/// derived, possibly multi-file outputs (a mesh yields a .glb plus textures) — but the operation can
/// be bracketed deterministically (snapshot, run + await, snapshot again). It's much cheaper than a
/// full project reload: an on-disk enumeration plus publishing the (usually small) diff, with no tree
/// rebuild.
/// </summary>
public static class ProjectFileDiff
{
    /// <summary>
    /// Absolute paths of every file under <paramref name="directory"/> (recursively), case-insensitive.
    /// Returns an empty set if the directory is null or missing.
    /// </summary>
    public static IReadOnlySet<string> Snapshot(string? directory) =>
        !string.IsNullOrEmpty(directory) && Directory.Exists(directory)
            ? Directory.EnumerateFiles(directory, "*", SearchOption.AllDirectories)
                .ToHashSet(StringComparer.OrdinalIgnoreCase)
            : new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Publishes the difference between two snapshots: paths present only in <paramref name="after"/>
    /// are announced as adds, paths present only in <paramref name="before"/> as deletes. Paths in both
    /// (unchanged, or overwritten in place) produce nothing.
    /// </summary>
    public static void Publish(IReadOnlySet<string> before, IReadOnlySet<string> after, IProjectEvents projectEvents)
    {
        ArgumentNullException.ThrowIfNull(before);
        ArgumentNullException.ThrowIfNull(after);
        ArgumentNullException.ThrowIfNull(projectEvents);

        foreach (var added in after)
        {
            if (!before.Contains(added))
            {
                projectEvents.PublishFileImported(added);
            }
        }

        foreach (var removed in before)
        {
            if (!after.Contains(removed))
            {
                projectEvents.PublishFileDeleted(removed);
            }
        }
    }
}
