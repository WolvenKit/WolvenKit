using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProtoBuf;
using Splat;
using WolvenKit.Common;
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

        public ArchiveManager() : this(Locator.Current.GetService< IHashService>())
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

        [ProtoAfterDeserialization]
        public void AfterDeserializationCallback()
        {
            foreach (var archive in Archives.Values)
            {
                var fileEntries = (archive as Archive).Index.FileEntries.Values;
                foreach (var file in fileEntries)
                {
                    file.Archive = archive;
                    archive.Files.Add(file.Key, file);
                    file.SetHashService(_hashService);
                }
                var deps = (archive as Archive).Index.Dependencies;
                foreach (var d in deps)
                {
                    d.SetHashService(_hashService);
                }
            }

            Items = Archives.Values
                .SelectMany(_ => _.Files)
                .GroupBy(_ => _.Key)
                .ToDictionary(_ => _.Key, _ => _.Select(x => x.Value).ToList());

            RebuildRootNode();
        }

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
                RebuildRootNode();
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

            foreach (var file in Directory.GetFiles(archivedir, "*.archive"))
            {
                LoadArchive(file);
            }

            if (rebuildtree)
            {
                RebuildRootNode();
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

            var bundle = Red4ParserServiceExtensions.ReadArchive(filename, _hashService);

            foreach (var (key, value) in bundle.Files)
            {
                // add new key if the file isn't already in another bundle
                if (!Items.ContainsKey(key))
                {
                    Items.Add(key, new List<IGameFile>());
                }
                if (!Items[key].ToList().Contains(value))
                {
                    var items = Items[key];
                    items.Add(value);
                }
            }


            Archives.Add(bundle.ArchiveAbsolutePath, bundle);
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

        #endregion methods
    }
}
