using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;

namespace WolvenKit.Cache
{
    public class TextureManager : WitcherArchiveManager
    {
        #region Constructors

        public TextureManager()
        {
        }

        #endregion Constructors

        #region Properties

        public static string SerializationVersion => "1.1";
        public override EArchiveType TypeName => EArchiveType.TextureCache;
        public override Dictionary<string, IGameArchive> Archives { get; set; } = new();

        #endregion Properties

        #region Methods

        /// <summary>
        ///     Load every non-mod bundle it can find in ..\\..\\content and ..\\..\\DLC, also calls RebuildRootNode()
        /// </summary>
        /// <param name="exedir">Path to executable directory</param>
        public override void LoadAll(string exedir)
        {
            var di = new DirectoryInfo(exedir);
            if (!di.Exists)
                return;
            var dlc = Path.Combine(di.Parent.Parent.FullName, "DLC");
            var content = Path.Combine(di.Parent.Parent.FullName, "content");

            var contentdirs = new List<string>(Directory.GetDirectories(content, "content*"));
            contentdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in contentdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)))
            {
                LoadArchive(file);
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in patchdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)))
            {
                LoadArchive(file);
            }

            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());

                foreach (var file in dlcdirs
                    .Where(_ => VanillaDlClist.Contains(new DirectoryInfo(_).Name))
                    .SelectMany(dir => Directory.GetFiles(dir ?? "", "*.cache", SearchOption.AllDirectories)
                        .OrderBy(k => k)
                        .Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)))
                {
                    LoadArchive(file);
                }
            }
            RebuildRootNode();
        }

        /// <summary>
        ///     Load a single soundcache
        /// </summary>
        /// <param name="filename"></param>
        public override void LoadArchive(string filename, bool ispatch = false)
        {
            if (Archives.ContainsKey(filename))
                return;

            var bundle = new TextureCache(filename);

            //foreach (var item in bundle.Files.Values)
            //{
            //    if (!Items.ContainsKey(item.Name))
            //        Items.Add(item.Name, new List<IGameFile>());

            //    Items[item.Name].Add(item);
            //}

            Archives.Add(filename, bundle);
        }

        /// <summary>
        ///     Load a single mod soundcache
        /// </summary>
        /// <param name="filename"></param>
        public override void LoadModArchive(string filename)
        {
            if (Archives.ContainsKey(filename))
                return;

            var bundle = new TextureCache(filename);

            //foreach (var item in bundle.Files.Values)
            //{
            //    if (!Items.ContainsKey(GetModFolder(filename) + "\\" + item.Name))
            //        Items.Add(GetModFolder(filename) + "\\" + item.Name, new List<IGameFile>());

            //    Items[GetModFolder(filename) + "\\" + item.Name].Add(item);
            //}

            Archives.Add(filename, bundle);
        }

        /// <summary>
        /// Loads .cache files from given mods and dlc folder
        /// </summary>
        /// <param name="mods"></param>
        /// <param name="dlc"></param>
        public override void LoadModsArchives(string mods, string dlc)
        {
            // this is slow
            Archives.Clear();
            Items.Clear();

            if (!Directory.Exists(mods))
                Directory.CreateDirectory(mods);
            var modsdirs = new List<string>(Directory.GetDirectories(mods));
            modsdirs.Sort(new AlphanumComparator<string>());
            var modbundles = modsdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)).ToList();
            foreach (var file in modbundles)
            {
                LoadModArchive(file);
            }

            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());

                var tmp = dlcdirs.Where(_ => !VanillaDlClist.Contains(new DirectoryInfo(_).Name)).ToList();
                foreach (var file in tmp
                    .SelectMany(dir => Directory.GetFiles(dir ?? "", "*.cache", SearchOption.AllDirectories)
                        .OrderBy(k => k)
                        .Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)))
                {
                    LoadModArchive(file);
                }
            }
            RebuildRootNode();
        }

        #endregion Methods
    }
}
