using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace WolvenKit.App.Services;

public class ProjectEvents : IProjectEvents
{
    private readonly Subject<FilesImportedMessage> _filesImported = new();

    public IObservable<FilesImportedMessage> FilesImported =>
        _filesImported.AsObservable();

    public void PublishFilesImported(FilesImportedMessage message)
    {
        _filesImported.OnNext(message);
    }
}
