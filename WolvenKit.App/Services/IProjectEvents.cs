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
    /// To be called when a known batch of files are being added to the project.
    /// E.g.: when adding files from AssetBrowser or exporting JSON, etc.
    /// NOTE: Be sure to disable monitoring of file system events before use.
    /// </summary>
    /// <param name="message"></param>
    void PublishFilesImported(FilesImportedMessage message);
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
