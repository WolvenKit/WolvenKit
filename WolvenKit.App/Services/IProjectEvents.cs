using System;
using System.Collections.Generic;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.App.Services;

public interface IProjectEvents
{
    IObservable<FilesImportedMessage> FilesImported { get; }

    void PublishFilesImported(FilesImportedMessage message);
}

public sealed record FilesImportedMessage(
    IReadOnlyList<IGameFile> Files
);
