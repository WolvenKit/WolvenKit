using DynamicData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WolvenKit.Core.Services;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.App.Services;

public class AppArchiveManager : ArchiveManager, IAppArchiveManager
{
    public AppArchiveManager(
        IHashService hashService,
        Red4ParserService wolvenkitFileService,
        ILoggerService logger,
        IProgressService<double> progressService,
        ISettingsManager settings) : base(hashService, wolvenkitFileService, logger, progressService)
    {
        _hashService = hashService;
        _logger = logger;
        _progressService = progressService;
        _settings = settings;
    }
    
    #region Fields

    private readonly IHashService _hashService;
    private readonly ILoggerService _logger;
    private readonly IProgressService<double> _progressService;
    private readonly ISettingsManager _settings;
    
    private readonly SourceList<RedFileSystemModel> _rootCache = new();

    private readonly SourceList<RedFileSystemModel> _modCache = new();

    private string[] IgnoredArchives =>
        _settings.ArchiveNamesExcludeFromScan.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(archiveName => archiveName.Replace(".archive", "")).ToArray();

    public override string[] GetIgnoredArchiveNames() => IgnoredArchives;

    public static bool ArchivesNeedRescan = true;

    #endregion Fields

    #region Properties

    public bool IsModBrowserActive { get; set; }

    public RedFileSystemModel? RootNode { get; set; }

    public List<RedFileSystemModel> ModRoots { get; set; } = new();

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        if (e.PropertyName == nameof(IsModBrowserActive) && IsModBrowserActive)
        {
            ArchivesNeedRescan = true;
        }
    }

    #endregion

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
            foreach (var t in path)
            {
                if (t == '\\')
                {
                    var str = sb.ToString();

                    if (!lastNode.Directories.TryGetValue(str, out var tmpNode))
                    {
                        tmpNode = new RedFileSystemModel(str);
                        lastNode.Directories.TryAdd(str, tmpNode);
                    }
                    lastNode = tmpNode;
                }

                sb.Append(t);
            }
            lastNode.Files.Enqueue(file.Value);
        });
    }

    private string? GetGameDir() =>
        _settings.GetRED4GameExecutablePath() is string executablePath && !string.IsNullOrEmpty(executablePath) &&
        Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(executablePath))) is string gameDir
            ? gameDir
            : null;
    public override void LoadModArchives(FileInfo executable, bool analyzeFiles = true, string[]? ignoredFiles = null)
    {
        _progressService.IsIndeterminate = true;

        ignoredFiles ??= [];

        base.LoadModArchives(executable, analyzeFiles, [.. ignoredFiles]);
        var gameDir = GetGameDir();

        foreach (var iGameArchive in Archives.Items)
        {
            if (gameDir != null && iGameArchive.ArchiveAbsolutePath.StartsWith(gameDir))
            {
                iGameArchive.ArchiveRelativePath = iGameArchive.ArchiveAbsolutePath.Replace(gameDir, "");
            }

            foreach (var redFileSystemModel in ModRoots.Where(fs =>
                         iGameArchive.ArchiveAbsolutePath.StartsWith(fs.FullName)))
            {
                iGameArchive.ArchiveRelativePath = iGameArchive.ArchiveAbsolutePath.Replace(redFileSystemModel.FullName, "");
            }
        }

        try
        {
            RebuildModRoot();
        }
        catch (ArgumentNullException err)
        {
            _logger.Error(err.Message);
        }

        _modCache.Edit(innerCache =>
        {
            innerCache.Clear();
            innerCache.Add([.. ModRoots]);
        });

        if (analyzeFiles)
        {
            ArchivesNeedRescan = false;
        }

    }

    public override void LoadAdditionalModArchives(string archiveBasePath, bool analyzeFiles = true, string[]? ignoredFiles = null)
    {
        base.LoadAdditionalModArchives(archiveBasePath, analyzeFiles, ignoredFiles);

        try
        {
            RebuildModRoot();
        }
        catch (ArgumentNullException err)
        {
            _logger.Error(err.Message);
        }

        _modCache.Edit(innerCache =>
        {
            innerCache.Clear();
            innerCache.Add([.. ModRoots]);
        });
    }

    private void RebuildModRoot()
    {
        ModRoots.Clear();

        _progressService.IsIndeterminate = true;

        var progress = -1;
        var numTotalArchives = (float)GetModArchives().Count();
        
        foreach (var archive in GetModArchives())
        {
            progress++;
            _progressService.Report(progress / numTotalArchives);
            ArgumentNullException.ThrowIfNull(archive.ArchiveRelativePath,
                $"{nameof(archive.ArchiveRelativePath)}, archive name: ${archive.Name}");

            if (IgnoredArchives.Contains(archive.Name.Replace(".archive", "")))
            {
                continue;
            }

            var modRoot = new RedFileSystemModel(archive.ArchiveRelativePath);

            // loop through all files
            foreach (var (_, model) in archive.Files)
            {
                var currentNode = modRoot;
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
                currentNode.Files.Enqueue(model);
            }

            ModRoots.Add(modRoot);
        }

        _progressService.Completed();
    }

    public override Dictionary<string, IEnumerable<IGameFile>> GetGroupedFiles() => 
        GetGroupedFiles(IsModBrowserActive ? ArchiveManagerScope.Mods : ArchiveManagerScope.Basegame);

    #endregion Methods
}