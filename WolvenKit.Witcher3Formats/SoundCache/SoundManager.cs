using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using WolvenKit.Common;
using WolvenKit.Wwise;

namespace WolvenKit.Cache
{
    public class SoundManager : WitcherArchiveManager
    {
        #region Fields

        public SoundBanksInfoXML soundBanksInfo;
        public static string SerializationVersion => "1.0";
        public override EArchiveType TypeName => EArchiveType.SoundCache;
        public override Dictionary<string, IGameArchive> Archives { get; set; } = new();

        #endregion Fields

        #region Constructors

        public SoundManager()
        {
            soundBanksInfo = new SoundBanksInfoXML(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SoundCache", "soundbanksinfo.xml"));
        }

        #endregion Constructors



        #region Methods

        /// <summary>
        ///     Load every non-mod bundle it can find in ..\..\content and ..\..\DLC, also calls RebuildRootNode()
        /// </summary>
        /// <param name="exedir">Path to executable directory</param>
        public override void LoadAll(string exedir, bool rebuildtree = true)
        {
            var di = new DirectoryInfo(exedir);
            if (!di.Exists)
                return;
            var dlc = Path.Combine(di.Parent.Parent.FullName, "DLC");
            var content = Path.Combine(di.Parent.Parent.FullName, "content");

            var contentdirs = new List<string>(Directory.GetDirectories(content, "content*"));
            contentdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in contentdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Sound)))
            {
                LoadArchive(file);
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in patchdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Sound)))
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
                        .Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Sound)))
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
        /// Loads the .cache soundcache files from the /Mods/ folder
        /// Note this resets everything
        /// </summary>
        /// <param name="mods"></param>
        /// <param name="dlc"></param>
        public override void LoadModsArchives(string mods, string dlc)
        {
            if (!Directory.Exists(mods))
                Directory.CreateDirectory(mods);
            var modsdirs = new List<string>(Directory.GetDirectories(mods));
            modsdirs.Sort(new AlphanumComparator<string>());
            var modbundles = modsdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Sound)).ToList();
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
                        .Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Sound)))
                {
                    LoadModArchive(file);
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

            var bundle = new SoundCache(filename);

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
        ///     Load a single mod soundcache
        /// </summary>
        /// <param name="filename"></param>
        public override void LoadModArchive(string filename)
        {
            if (Archives.ContainsKey(filename))
            {
                return;
            }

            var bundle = new SoundCache(filename);

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




        #endregion Methods
    }
}
