using DynamicData;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.App.Services;

public class AppArchiveManager : ArchiveManager, IAppArchiveManager
{
    #region Fields

    private readonly SourceList<RedFileSystemModel> _rootCache;

    private readonly SourceList<RedFileSystemModel> _modCache;

    #endregion Fields

    #region Properties

    public bool IsModBrowserActive { get; set; }

    public RedFileSystemModel? RootNode { get; set; }

    public List<RedFileSystemModel> ModRoots { get; set; } = new();

    #endregion

    public AppArchiveManager(IHashService hashService, Red4ParserService wolvenkitFileService, ILoggerService logger) : base(hashService, wolvenkitFileService, logger)
    {
        _rootCache = new SourceList<RedFileSystemModel>();
        _modCache = new SourceList<RedFileSystemModel>();
    }

    #region Methods

    public IObservable<IChangeSet<RedFileSystemModel>> ConnectGameRoot() => _rootCache.Connect();

    public IObservable<IChangeSet<RedFileSystemModel>> ConnectModRoot() => _modCache.Connect();

    public override void LoadGameArchives(FileInfo executable)
    {
        base.LoadGameArchives(executable);

        var sw = new Stopwatch();
        sw.Start();

        RebuildGameRoot(_hashService);

        _logger.Debug($"Finished rebuilding root in {sw.ElapsedMilliseconds}ms");

        _rootCache.Edit(innerCache =>
        {
            innerCache.Clear();
            innerCache.Add(RootNode.NotNull());
        });

        sw.Stop();
    }

    private void RebuildGameRoot(IHashService hashService)
    {
        RootNode = new RedFileSystemModel(EArchiveType.Archive.ToString());

        var allFiles = GetGameArchives()
            .SelectMany(x => x.Files)
            .GroupBy(x => x.Key)
            .Select(x => x.First());

        Parallel.ForEach(allFiles, (file) =>
        {
            var path = hashService.Get(file.Key);
            if (path == null)
            {
                RootNode.Files.Enqueue(file.Value);
                return;
            }

            var lastNode = RootNode;

            var sb = new StringBuilder();
            for (var i = 0; i < path.Length; i++)
            {
                if (path[i] == '\\')
                {
                    var str = sb.ToString();

                    if (!lastNode.Directories.TryGetValue(str, out var tmpNode))
                    {
                        tmpNode = new RedFileSystemModel(str);
                        lastNode.Directories.TryAdd(str, tmpNode);
                    }
                    lastNode = tmpNode;
                }
                sb.Append(path[i]);
            }
            lastNode.Files.Enqueue(file.Value);
        });
    }

    public override void LoadModsArchives(FileInfo executable, bool analyzeFiles = true)
    {
        base.LoadModsArchives(executable, analyzeFiles);

        RebuildModRoot();

        _modCache.Edit(innerCache =>
        {
            innerCache.Clear();
            innerCache.Add(ModRoots);
        });
    }

    public override void LoadAdditionalModArchives(string archiveBasePath, bool analyzeFiles = true)
    {
        base.LoadAdditionalModArchives(archiveBasePath, analyzeFiles);

        RebuildModRoot();

        _modCache.Edit(innerCache =>
        {
            innerCache.Clear();
            innerCache.Add(ModRoots);
        });
    }

    private void RebuildModRoot()
    {
        ModRoots.Clear();

        foreach (var archive in GetModArchives())
        {
            ArgumentNullException.ThrowIfNull(archive.ArchiveRelativePath);

            var modroot = new RedFileSystemModel(archive.ArchiveRelativePath);

            // loop through all files
            //Parallel.ForEach(archive.Files, item =>
            foreach (var item in archive.Files)
            {
                var currentNode = modroot;
                var model = item.Value;
                var parts = model.Name.Split('\\');

                // loop through path
                var fullpath = "";
                for (var i = 0; i < parts.Length - 1; i++)
                {
                    var part = parts[i];
                    fullpath += part + Path.DirectorySeparatorChar;

                    var dirPath = fullpath.TrimEnd(Path.DirectorySeparatorChar);
                    var x = currentNode.Directories.GetOrAdd(dirPath, new RedFileSystemModel(dirPath));
                    currentNode = x;
                }

                // add file to the last directory in path
                currentNode.Files.Enqueue(item.Value);
            }
            //);

            ModRoots.Add(modroot);
        }
    }

    public override Dictionary<string, IEnumerable<IGameFile>> GetGroupedFiles() => 
        GetGroupedFiles(IsModBrowserActive ? ArchiveManagerScope.Mods : ArchiveManagerScope.Everywhere);

    #endregion Methods
}