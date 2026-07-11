using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace WolvenKit.App.Services;

public class ProjectEvents : IProjectEvents
{
    private readonly Subject<FilesImportedMessage> _filesImported = new();
    private readonly Subject<FilesMovedMessage> _filesMoved = new();
    private readonly Subject<FilesDeletedMessage> _filesDeleted = new();

    public IObservable<FilesImportedMessage> FilesImported =>
        _filesImported.AsObservable();

    public IObservable<FilesMovedMessage> FilesMoved =>
        _filesMoved.AsObservable();

    public IObservable<FilesDeletedMessage> FilesDeleted =>
        _filesDeleted.AsObservable();

    public void PublishFilesImported(FilesImportedMessage message)
    {
        _filesImported.OnNext(message);
    }

    public void PublishFilesMoved(FilesMovedMessage message)
    {
        _filesMoved.OnNext(message);
    }

    // A single-file add is modelled as a move with an empty source: the consumer materializes the
    // destination (and any missing parent dirs) and removes nothing. Reusing FilesMoved keeps the add
    // path side-effect-free (unlike OnFilesImported, which also Resumes the watcher for the bulk flow).
    public void PublishFileImported(string absolutePath)
    {
        if (!string.IsNullOrEmpty(absolutePath))
        {
            _filesMoved.OnNext(new FilesMovedMessage([(string.Empty, absolutePath)]));
        }
    }

    public void PublishFileDeleted(string absolutePath) => PublishDeleted(absolutePath);

    public void PublishDirectoryDeleted(string absoluteDirectoryPath) => PublishDeleted(absoluteDirectoryPath);

    // File and directory deletions apply identically (the consumer removes the node, recursing for
    // directories); the two public methods just document intent at the call site.
    private void PublishDeleted(string absolutePath)
    {
        if (!string.IsNullOrEmpty(absolutePath))
        {
            _filesDeleted.OnNext(new FilesDeletedMessage([absolutePath]));
        }
    }
}
