using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WolvenKit.App.Services;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using Xunit;

namespace Wolvenkit.Test.App.Services;

/// <summary>
/// Tests for the new IProjectEvents pub/sub used by the large-project performance bypass path.
/// These protect the contract between bulk file add operations (Asset Browser, JSON export, RED4 AddToModAsync)
/// and the WatcherService's OnFilesImported handler.
/// </summary>
public class ProjectEventsTests
{
    [Fact]
    public void PublishFilesImported_WithGameFiles_NotifiesSubscribers()
    {
        var events = new ProjectEvents();
        var received = new List<FilesImportedMessage>();

        using var sub = events.FilesImported.Subscribe(received.Add);

        var fakeFiles = new List<IGameFile> { new FakeGameFile("archive\\test\\file.mesh") };
        events.PublishFilesImported(new FilesImportedMessage.GameFiles(fakeFiles));

        Assert.Single(received);

        if (received[0] is not FilesImportedMessage.GameFiles gameFilesMsg)
        {
            Assert.Fail("FilesImportedMessage received was not a GameFiles.");
            return;
        }

        Assert.Single(gameFilesMsg.Files);
        Assert.Equal("archive\\test\\file.mesh", gameFilesMsg.Files.First().FileName);
    }

    [Fact]
    public void PublishFilesImported_WithRawFiles_NotifiesSubscribers()
    {
        var events = new ProjectEvents();
        var received = new List<FilesImportedMessage>();

        using var sub = events.FilesImported.Subscribe(received.Add);

        var raw = new FileInfo(Path.GetTempFileName());
        try
        {
            events.PublishFilesImported(new FilesImportedMessage.RawFiles(new[] { raw }));

            Assert.Single(received);

            if (received[0] is not FilesImportedMessage.RawFiles rawFilesMsg)
            {
                Assert.Fail("FilesImportedMessage received was not a GameFiles.");
                return;
            }
            Assert.Single(rawFilesMsg.Files);
        }
        finally
        {
            if (raw.Exists) raw.Delete();
        }
    }

    [Fact]
    public void MultipleSubscribers_AllReceiveMessages()
    {
        var events = new ProjectEvents();
        var count1 = 0;
        var count2 = 0;

        using var s1 = events.FilesImported.Subscribe(_ => count1++);
        using var s2 = events.FilesImported.Subscribe(_ => count2++);

        events.PublishFilesImported(new FilesImportedMessage.RawFiles(Array.Empty<FileInfo>()));

        Assert.Equal(1, count1);
        Assert.Equal(1, count2);
    }

    private sealed class FakeGameFile : IGameFile
    {
        public FakeGameFile(string fileName)
        {
            FileName = fileName;
            Name = Path.GetFileName(fileName);
            Extension = Path.GetExtension(fileName).TrimStart('.');
        }

        public ulong Key { get; set; }
        public string Name { get; }
        public uint Size { get; set; }
        public uint ZSize { get; set; }
        public string Extension { get; }
        public string? GuessedExtension { get; set; }
        public string FileName { get; }
        public ArchiveManagerScope Scope { get; set; }

        public void Extract(Stream output) => throw new NotImplementedException();
        public Task ExtractAsync(Stream output) => Task.CompletedTask;

        public T GetArchive<T>() where T : IGameArchive => throw new NotImplementedException();
        public IGameArchive GetArchive() => throw new NotImplementedException();
    }
}
