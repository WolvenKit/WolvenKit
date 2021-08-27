using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ProtoBuf;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.Model;
using WolvenKit.Common.Services;
using Path = System.IO.Path;

namespace WolvenKit.RED4.CR2W.Archive
{
    [ProtoContract]
    public class ArchiveManager : CyberArchiveManager
    {
        #region Fields

        public static string SerializationVersion = "1.1";

        private readonly IHashService _hashService;
        #endregion Fields

        #region Constructors

        public ArchiveManager() : this(Locator.Current.GetService<IHashService>())
        {

        }

        public ArchiveManager(IHashService hashService)
        {
            _hashService = hashService;
        }

        #endregion Constructors

        #region properties
        [ProtoMember(1)] public override Dictionary<string, IGameArchive> Archives { get; set; } = new();

        public Dictionary<string, IEnumerable<FileEntry>> GroupedFiles =>
            Archives.Values
                .SelectMany(_ => _.Files.Values)
                .GroupBy(_ => _.Extension)
                .ToDictionary(_ => _.Key, _ => _.Select(x => x as FileEntry));


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

        public override EArchiveType TypeName => EArchiveType.Archive;

        /// <summary>
        /// Loads all archives from a folder
        /// </summary>
        /// <param name="archivedir"></param>
        /// <param name="rebuildtree"></param>
        public void LoadFromFolder(DirectoryInfo archivedir, bool rebuildtree = false)
        {
            if (!archivedir.Exists)
            {
                return;
            }
            foreach (var file in Directory.GetFiles(archivedir.FullName, "*.archive"))
            {
                LoadArchive(file);
            }

            if (rebuildtree)
            {
                RebuildRootNode(_hashService);
            }
        }


        /// <summary>
        ///     Load every non-mod bundle it can find in ..\..\content and ..\..\DLC, also calls RebuildRootNode()
        /// </summary>
        /// <param name="executable"></param>
        /// <param name="rebuildtree"></param>
        public override void LoadAll(FileInfo executable, bool rebuildtree = true)
        {
            var di = executable.Directory;
            if (!di.Exists)
            {
                return;
            }

            var archivedir = Path.Combine(di.Parent.Parent.FullName, "archive", "pc", "content");

            //var sw = new Stopwatch();
            //sw.Start();

            foreach (var file in Directory.GetFiles(archivedir, "*.archive"))
            {
                LoadArchive(file);
            }

            //sw.Stop();
            //var ms = sw.ElapsedMilliseconds;

            // populate lists
            Items.Edit(innerList =>
            {
                innerList.Clear();
                innerList.AddOrUpdate(Archives.Values.SelectMany(_ => _.Files));
            });

            Extensions = Items.KeyValues.Select(_ => _.Value.Extension).Distinct();

            if (rebuildtree)
            {
                RebuildRootNode(_hashService);
            }
        }

        /// <summary>
        /// Load a single bundle
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="ispatch"></param>
        public override void LoadArchive(string filename, bool ispatch = false)
        {
            if (Archives.ContainsKey(filename))
            {
                return;
            }

            var archive = Red4ParserServiceExtensions.ReadArchive(filename, _hashService);
            Archives.Add(archive.ArchiveAbsolutePath, archive);
        }

        /// <summary>
        ///     Load a single mod bundle
        /// </summary>
        /// <param name="filename">
        ///     file to process
        /// </param>
        public override void LoadModArchive(string filename)
        {
            throw new NotImplementedException();
            /*if (Archives.ContainsKey(filename))
                return;

            var bundle = new Archive(filename);

            foreach (var item in bundle.Files)
            {
                if (!Items.ContainsKey(GetModFolder(filename) + "\\" + item.Key))
                    Items.Add(GetModFolder(filename) + "\\" + item.Key, new List<IGameFile>());

                Items[GetModFolder(filename) + "\\" + item.Key].Add(item.Value);
            }

            Archives.Add(filename, bundle);*/
        }

        /// <summary>
        /// Loads bundles from specified mods and dlc folder
        /// </summary>
        /// <param name="mods"></param>
        /// <param name="dlc"></param>
        public override void LoadModsArchives(string mods, string dlc)
        {
            throw new NotImplementedException();
            /*if (!Directory.Exists(mods))
                Directory.CreateDirectory(mods);
            var modsdirs = new List<string>(Directory.GetDirectories(mods));
            modsdirs.Sort(new AlphanumComparator<string>());
            var modbundles = modsdirs.SelectMany(dir => Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories)).ToList();
            foreach (var file in modbundles)
            {
                LoadModArchive(file);
            }

            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());

                var tmp = dlcdirs.Where(_ => !VanillaDlClist.Contains(new DirectoryInfo(_).Name)).ToList();
                foreach (var file in tmp.SelectMany(dir => Directory.GetFiles(dir ?? "", "*.bundle", SearchOption.AllDirectories).OrderBy(k => k)))
                {
                    LoadModArchive(file);
                }
            }
            RebuildRootNode();*/
        }

        /// <summary>
        /// Checks if a file with the given hash exists in the archivemanager
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public bool ContainsFile(ulong hash) => Items.Lookup(hash).HasValue;

        /// <summary>
        /// Retrieves a file with the given hash
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public IGameFile LookupFile(ulong hash)
        {
            var query = Items.Lookup(hash);
            if (query.HasValue)
            {
                return query.Value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Retrieves a directory with the given fullpath
        /// </summary>
        /// <param name="fullpath"></param>
        /// <returns></returns>
        public RedFileSystemModel LookupDirectory(string fullpath, bool expandAll = false)
        {
            var splits = fullpath.Split(Path.DirectorySeparatorChar);

            var currentDir = RootNode;
            if (expandAll)
            {
                currentDir.IsExpanded = true;
            }

            for (var i = 0; i < splits.Length; i++)
            {
                var s = splits[i];
               
                if (currentDir.Directories.Any(d => d.Name == s))
                {
                    currentDir = currentDir.Directories.First(d => d.Name == s);
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
                    if (i == splits.Length - 1)
                    {
                        return currentDir;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
        }

        #endregion methods
    }
}
