using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using DynamicData;
using DynamicData.Kernel;
using ProtoBuf;
using ReactiveUI.Fody.Helpers;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;
using Path = System.IO.Path;

namespace WolvenKit.RED4.CR2W.Archive
{
    [ProtoContract]
    public class ArchiveManager : RED4ArchiveManager
    {
        #region Fields

        public const string Version = "1.1";

        private readonly IHashService _hashService;

        private readonly Red4ParserService _wolvenkitFileService;

        private readonly ILoggerService _logger;

        private readonly SourceList<RedFileSystemModel> _rootCache;

        private readonly SourceList<RedFileSystemModel> _modCache;

        private static readonly List<string> s_loadOrder = new() { "memoryresident", "basegame", "audio", "lang" };

        #endregion Fields

        #region Constructors

        public ArchiveManager(IHashService hashService, Red4ParserService wolvenkitFileService, ILoggerService logger)
        {
            _hashService = hashService;
            _wolvenkitFileService = wolvenkitFileService;
            _logger = logger;

            _rootCache = new SourceList<RedFileSystemModel>();
            _modCache = new SourceList<RedFileSystemModel>();
        }

        #endregion Constructors

        #region properties

        [Reactive] public override bool IsManagerLoaded { get; set; }


        [ProtoMember(1)]
        public override SourceCache<IGameArchive, string> Archives { get; set; } = new(x => x.ArchiveAbsolutePath);

        public override SourceCache<IGameArchive, string> ModArchives { get; set; } = new(x => x.ArchiveAbsolutePath);


        public IObservable<IChangeSet<IGameArchive, string>> ConnectArchives() => Archives.Connect();


        public override IObservable<IChangeSet<RedFileSystemModel>> ConnectGameRoot() => _rootCache.Connect();

        public override IObservable<IChangeSet<RedFileSystemModel>> ConnectModRoot() => _modCache.Connect();

        public override EArchiveType TypeName => EArchiveType.Archive;

        #endregion properties

        #region methods

        //[ProtoAfterDeserialization]
        //public void AfterDeserializationCallback()
        //{
        //    foreach (var archive in Archives.Values)
        //    {
        //        var fileEntries = (archive as Archive).Index.FileEntries.Values;
        //        foreach (var file in fileEntries)
        //        {
        //            file.Archive = archive;
        //            archive.Files.Add(file.Key, file);
        //            file.SetHashService(_hashService);
        //        }
        //        var deps = (archive as Archive).Index.Dependencies;
        //        foreach (var d in deps)
        //        {
        //            d.SetHashService(_hashService);
        //        }
        //    }

        //    Items.Edit(innerList =>
        //    {
        //        innerList.Clear();
        //        innerList.AddOrUpdate(Archives.Values.SelectMany(_ => _.Files));
        //    });

        //    RebuildRootNode();
        //}

        #region sorting

        private static int CompareArchives(string x, string y)
        {
            if (ReferenceEquals(x, y))
            {
                return 0;
            }

            if (x is null)
            {
                return -1;
            }

            if (y is null)
            {
                return 1;
            }

            var baseX = Path.GetFileName(x);
            baseX = baseX[..baseX.IndexOf("_", StringComparison.Ordinal)];

            var baseY = Path.GetFileName(y);
            baseY = baseY[..baseY.IndexOf("_", StringComparison.Ordinal)];

            var retVal = s_loadOrder.IndexOf(baseX).CompareTo(s_loadOrder.IndexOf(baseY));
            return retVal != 0 ? retVal : string.Compare(x, y, StringComparison.Ordinal);
        }

        #endregion

        #region loading

        /// <summary>
        /// Loads all archives from a folder
        /// </summary>
        /// <param name="archivedir"></param>
        public override void LoadFromFolder(DirectoryInfo archivedir)
        {
            if (!archivedir.Exists)
            {
                return;
            }

            var archiveFiles = Directory.GetFiles(archivedir.FullName, "*.archive").ToList();
            archiveFiles.Sort(CompareArchives);

            foreach (var file in archiveFiles)
            {
                LoadArchive(file);
            }

            IsManagerLoaded = true;
        }


        /// <summary>
        /// Load every non-mod bundle it can find in ..\..\content and ..\..\DLC, also calls RebuildRootNode()
        /// </summary>
        /// <param name="executable"></param>
        /// <param name="rebuildtree"></param>
        public override void LoadGameArchives(FileInfo executable, bool rebuildtree = true)
        {
            var di = executable.Directory;
            if (di?.Parent?.Parent is null)
            {
                return;
            }
            if (!di.Exists)
            {
                return;
            }

            var archivedir = Path.Combine(di.Parent.Parent.FullName, "archive", "pc", "content");

            var sw = new Stopwatch();
            var sw2 = new Stopwatch();
            sw.Start();
            sw2.Start();

            var archiveFiles = Directory.GetFiles(archivedir, "*.archive").ToList();
            archiveFiles.Sort(CompareArchives);

            var cnt = 0;
            foreach (var file in archiveFiles)
            {
                sw.Restart();

                LoadArchive(file);
                cnt++;

                _logger.Debug($"Loaded archive {Path.GetFileName(file)} {cnt}/{archiveFiles.Count} in {sw.ElapsedMilliseconds}ms");
            }

            if (rebuildtree)
            {
                sw.Restart();

                RebuildGameRoot();

                _logger.Debug($"Finished rebuilding root in {sw.ElapsedMilliseconds}ms");

                _rootCache.Edit(innerCache =>
                {
                    innerCache.Clear();
                    innerCache.Add(RootNode);
                });
            }

            sw.Stop();
            sw2.Stop();
            _logger.Success($"Archive Manager loaded in {sw2.ElapsedMilliseconds}ms");

            IsManagerLoaded = true;
        }


        /// <summary>
        /// Load a single bundle
        /// </summary>
        /// <param name="path"></param>
        /// <param name="ispatch"></param>
        public override void LoadArchive(string path, bool ispatch = false)
        {
            if (Archives.Lookup(path).HasValue)
            {
                return;
            }

            var archive = _wolvenkitFileService.ReadRed4Archive(path, _hashService);

            if (archive == null)
            {
                _logger.Warning($"Unable to load game archive: {path}");
                return;
            }

            Archives.AddOrUpdate(archive);
        }

        /// <summary>
        /// Load a single mod bundle
        /// </summary>
        /// <param name="filename">
        /// file to process
        /// </param>
        public override void LoadModArchive(string filename)
        {
            if (ModArchives.Lookup(filename).HasValue)
            {
                return;
            }

            var archive = _wolvenkitFileService.ReadRed4Archive(filename, _hashService);

            if (archive == null)
            {
                _logger.Warning($"Unable to load mod archive: {filename}");
                return;
            }

            ModArchives.AddOrUpdate(archive);
        }

        public override void ReleaseFileModArchive(string path)
        {
            var dictValue = ModArchives.Lookup(path);
            if (!dictValue.HasValue)
            {
                return;
            }

            (dictValue.Value as RED4.Archive.Archive)?.ReleaseFileHandle();
        }

        /// <summary>
        /// Loads bundles from specified mods and dlc folder
        /// </summary>
        public override void LoadModsArchives(FileInfo executable)
        {
            var di = executable.Directory;
            if (di?.Parent?.Parent is null)
            {
                return;
            }
            if (!di.Exists)
            {
                return;
            }

            _logger.Info("Open Archive");

            ModArchives.Clear();

            var modsDirs = new DirectoryInfo[]
            {
                new(Path.Combine(di.Parent.Parent.FullName, "mods")),
                new(Path.Combine(di.Parent.Parent.FullName, "archive", "pc", "mod")),
            };

            var files = new List<string>();
            foreach (var modsDir in modsDirs)
            {
                if (!modsDir.Exists)
                {
                    continue;
                }

                foreach (var file in Directory.GetFiles(modsDir.FullName, "*.archive", SearchOption.AllDirectories))
                {
                    files.Add(file);
                }
            }

            files.Sort(string.CompareOrdinal);
            files.Reverse();

            foreach (var file in files)
            {
                LoadModArchive(file);
            }

            foreach (var modArchive in ModArchives.Items)
            {
                modArchive.ArchiveRelativePath = Path.GetRelativePath(di.Parent.Parent.FullName, modArchive.ArchiveAbsolutePath);
            }

            RebuildModRoot();

            _modCache.Edit(innerCache =>
            {
                innerCache.Clear();
                innerCache.Add(ModRoots);
            });

            IsManagerLoaded = true;
        }

        #endregion

        /// <summary>
        /// Get files grouped by extension in all archives
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, IEnumerable<FileEntry>> GetGroupedFiles() =>
            IsModBrowserActive
            ? ModArchives.Items
              .SelectMany(_ => _.Files.Values)
              .GroupBy(_ => _.Extension)
              .ToDictionary(_ => _.Key, _ => _.Select(x => x as FileEntry))
            : Archives.Items
              .SelectMany(_ => _.Files.Values)
              .GroupBy(_ => _.Extension)
              .ToDictionary(_ => _.Key, _ => _.Select(x => x as FileEntry));

        /// <summary>
        /// Get all files in all archives
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<FileEntry> GetFiles() =>
            IsModBrowserActive
            ? ModArchives.Items
                .SelectMany(_ => _.Files.Values)
                .Cast<FileEntry>()
            : Archives.Items
                .SelectMany(_ => _.Files.Values)
                .Cast<FileEntry>();

        /// <summary>
        /// Checks if a file with the given hash exists in the archivemanager
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public bool ContainsFile(ulong hash) => Lookup(hash).HasValue;

        /// <summary>
        /// Look up a hash in the ArchiveManager
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public override Optional<IGameFile> Lookup(ulong hash)
        {
            return IsModBrowserActive
                ? Optional<IGameFile>.ToOptional(
                    (from item in ModArchives.Items where item.Files.ContainsKey(hash) select item.Files[hash])
                .FirstOrDefault())
                : Optional<IGameFile>.ToOptional(
                    (from item in Archives.Items where item.Files.ContainsKey(hash) select item.Files[hash])
                .FirstOrDefault());
        }

        /// <summary>
        /// Retrieves a directory with the given fullpath
        /// </summary>
        /// <param name="fullpath"></param>
        /// <param name="expandAll"></param>
        /// <returns></returns>
        public override RedFileSystemModel LookupDirectory(string fullpath, bool expandAll = false)
        {
            if (IsModBrowserActive)
            {
                foreach (var item in ModRoots)
                {
                    var result = LookupDirectory(fullpath, item, expandAll);
                    if (result is not null)
                    {
                        return result;
                    }
                }
                return null;
            }
            else
            {
                return LookupDirectory(fullpath, RootNode, expandAll);
            }
        }

        private static RedFileSystemModel LookupDirectory(string fullpath, RedFileSystemModel currentDir, bool expandAll = false)
        {
            var splits = fullpath.Split(Path.DirectorySeparatorChar);
            if (expandAll)
            {
                currentDir.IsExpanded = true;
            }

            for (var i = 0; i < splits.Length; i++)
            {
                var s = splits[i];

                if (currentDir.Directories.ContainsKey(s))
                {
                    currentDir = currentDir.Directories[s];
                    if (expandAll)
                    {
                        currentDir.IsExpanded = true;
                    }
                    if (i == splits.Length - 1)
                    {
                        return currentDir;
                    }
                }
                else
                {
                    return i == splits.Length - 1 ? currentDir : null;
                }
            }
            return null;
        }

        #endregion methods
    }
}
