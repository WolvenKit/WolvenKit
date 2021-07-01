using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;

namespace WolvenKit.Bundles
{
    public class BundleManager : WitcherArchiveManager
    {
        public static string SerializationVersion => "1.0";
        public override EArchiveType TypeName => EArchiveType.Bundle;
        public override Dictionary<string, IGameArchive> Archives { get; set; } = new();

        #region Constructors

        public BundleManager()
        {
        }

        #endregion Constructors

        #region Properties



        #endregion Properties

        #region Methods

        /// <summary>
        ///     Load every non-mod bundle it can find in ..\..\content and ..\..\DLC, also calls RebuildRootNode()
        /// </summary>
        /// <param name="exedir">Path to executable directory</param>
        public override void LoadAll(FileInfo executable, bool rebuildtree = true)
        {
            var di = executable.Directory;
            if (!di.Exists)
                return;
            var dlc = Path.Combine(di.Parent.Parent.FullName, "DLC");
            var content = Path.Combine(di.Parent.Parent.FullName, "content");

            var contentdirs = new List<string>(Directory.GetDirectories(content, "content*"));
            contentdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in contentdirs.SelectMany(dir => Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories)))
            {
                LoadArchive(file);
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in patchdirs.SelectMany(dir =>
                Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories)))
            {
                LoadArchive(file, true);
            }

            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());

                foreach (var file in dlcdirs
                    .Where(_ => VanillaDlClist.Contains(new DirectoryInfo(_).Name))
                    .SelectMany(dir => Directory.GetFiles(dir ?? "", "*.bundle", SearchOption.AllDirectories)
                    .OrderBy(k => k)))
                {
                    LoadArchive(file);
                }
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
                return;

            var bundle = new Bundle(filename);
            //foreach (var item in bundle.Files)
            //{
            //    // add new key if the file isn't already in another bundle
            //    if (!Items.ContainsKey(item.Key))
            //        Items.TryAdd(item.Key, new List<IGameFile>());

            //    // if file is already in another bundle
            //    if (ispatch && Items[item.Key].Count() > 0)
            //    {
            //        // check if file is already in contentN directory (content0, content1 etc)
            //        var filesInBundles = Items[item.Key].ToList();
            //        var splits = filesInBundles.First().Archive.ArchiveAbsolutePath.Split(Path.DirectorySeparatorChar);
            //        var contentdir = splits[splits.Length - 3];
            //        if (contentdir.Contains("content"))
            //        {
            //            // then remove all other existing files
            //            for (var i = 0; i < filesInBundles.Count; i++)
            //            {
            //                bundle.Patchedfiles.Add(filesInBundles[i]);
            //                filesInBundles.RemoveAt(0);
            //            }
            //        }
            //    }
            //    Items[item.Key].Add(item.Value);
            //}

            foreach (var (key, value) in bundle.Files)
            {
                // add new key if the file isn't already in another bundle
                if (!Items.ContainsKey(key))
                {
                    Items.Add(key, new List<IGameFile>());
                }
                if (!Items[key].ToList().Contains(value))
                {
                    Items[key].Add(value);
                }
            }

            Archives.Add(filename, bundle);
        }

        /// <summary>
        ///     Load a single mod bundle
        /// </summary>
        /// <param name="filename">
        ///     file to process
        /// </param>
        public override void LoadModArchive(string filename)
        {
            if (Archives.ContainsKey(filename))
                return;

            var bundle = new Bundle(filename);

            foreach (var (key, value) in bundle.Files)
            {
                // add new key if the file isn't already in another bundle
                if (!Items.ContainsKey(key))
                {
                    Items.Add(key, new List<IGameFile>());
                }
                if (!Items[key].ToList().Contains(value))
                {
                    Items[key].Add(value);
                }
            }

            Archives.Add(filename, bundle);
        }

        /// <summary>
        /// Loads bundles from specified mods and dlc folder
        /// </summary>
        /// <param name="mods"></param>
        /// <param name="dlc"></param>
        public override void LoadModsArchives(string mods, string dlc)
        {
            if (!Directory.Exists(mods))
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
            RebuildRootNode();
        }

        #endregion Methods
    }
}
