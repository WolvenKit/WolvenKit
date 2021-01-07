using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Cache;
using WolvenKit.Wwise;
using WolvenKit.Common.Model;
using System.Reflection;

namespace WolvenKit.Cache
{
    public class SoundManager : IGameArchiveManager
    {
        public SoundManager()
        {
            Items = new Dictionary<string, List<IGameFile>>();
            Archives = new Dictionary<string, SoundCache>();
            FileList = new List<IGameFile>();
            Extensions = new List<string>();
            AutocompleteSource = new List<string>();
            soundBanksInfo = new SoundBanksInfoXML(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SoundCache","soundbanksinfo.xml"));
        }

        public Dictionary<string, List<IGameFile>> Items { get; set; }
        public Dictionary<string, SoundCache> Archives { get; set; }
        public WitcherTreeNode RootNode { get; set; }
        public List<IGameFile> FileList { get; set; }
        public EBundleType TypeName => EBundleType.SoundCache;
        public List<string> Extensions { get; set; }
        public List<string> AutocompleteSource { get; set; }

        public static string SerializationVersion => "1.0";

        public SoundBanksInfoXML soundBanksInfo;

        private readonly string[] vanillaDLClist = new string[] { "DLC1", "DLC2", "DLC3", "DLC4", "DLC5", "DLC6", "DLC7", "DLC8", "DLC9", "DLC10", "DLC11", "DLC12", "DLC13", "DLC14", "DLC15", "DLC16", "bob", "ep1" };


        /// <summary>
        ///     Load a single mod soundcache
        /// </summary>
        /// <param name="filename"></param>
        private void LoadModBundle(string filename)
        {
            if (Archives.ContainsKey(filename))
                return;

            var bundle = new SoundCache(filename);

            foreach (var item in bundle.Files)
            {
                if (!Items.ContainsKey(GetModFolder(filename) + "\\" + item.Name))
                    Items.Add(GetModFolder(filename) + "\\" + item.Name, new List<IGameFile>());

                Items[GetModFolder(filename) + "\\" + item.Name].Add(item);
            }

            Archives.Add(filename, bundle);
        }

        /// <summary>
        ///     Load a single soundcache
        /// </summary>
        /// <param name="filename"></param>
        private void LoadBundle(string filename)
        {
            if (Archives.ContainsKey(filename))
                return;

            var bundle = new SoundCache(filename);

            foreach (var item in bundle.Files)
            {
                if (!Items.ContainsKey(item.Name))
                    Items.Add(item.Name, new List<IGameFile>());

                Items[item.Name].Add(item);
            }

            Archives.Add(filename, bundle);
        }

        /// <summary>
        ///     Load every non-mod bundle it can find in ..\..\content and ..\..\DLC, also calls RebuildRootNode()
        /// </summary>
        /// <param name="exedir">Path to executable directory</param>
        public void LoadAll(string exedir)
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
                LoadBundle(file);
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in patchdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Sound)))
            {
                LoadBundle(file);
            }

            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());

                foreach (var file in dlcdirs
                    .Where(_ => vanillaDLClist.Contains(new DirectoryInfo(_).Name))
                    .SelectMany(dir => Directory.GetFiles(dir ?? "", "*.cache", SearchOption.AllDirectories)
                        .OrderBy(k => k)
                        .Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Sound)))
                {
                    LoadBundle(file);
                }
            }
            RebuildRootNode();
        }

        /// <summary>
        /// Loads the .cache soundcache files from the /Mods/ folder
        /// Note this resets everything
        /// </summary>
        /// <param name="mods"></param>
        /// <param name="dlc"></param>
        public void LoadModsBundles(string mods, string dlc)
        {
            if (!Directory.Exists(mods))
                Directory.CreateDirectory(mods);
            var modsdirs = new List<string>(Directory.GetDirectories(mods));
            modsdirs.Sort(new AlphanumComparator<string>());
            var modbundles = modsdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Sound)).ToList();
            foreach (var file in modbundles)
            {
                LoadModBundle(file);
            }

            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());

                var tmp = dlcdirs.Where(_ => !vanillaDLClist.Contains(new DirectoryInfo(_).Name)).ToList();
                foreach (var file in tmp
                    .SelectMany(dir => Directory.GetFiles(dir ?? "", "*.cache", SearchOption.AllDirectories)
                        .OrderBy(k => k)
                        .Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Sound)))
                {
                    LoadModBundle(file);
                }
            }
            RebuildRootNode();
        }

        private static string GetModFolder(string path)
        {
            if (path.Split('\\').Length > 3 && path.Split('\\').Contains("content"))
            {
                return path.Split('\\')[path.Split('\\').ToList().IndexOf(path.Split('\\').FirstOrDefault(x => x == "content")) - 1];
            }
            return path;
        }

        /// <summary>
        ///     Rebuilds the soundcache tree structure also rebuilds NOTE: Filelist,autocomplete,extensions
        /// </summary>
        private void RebuildRootNode()
        {
            RootNode = new WitcherTreeNode(EBundleType.SoundCache);
            RootNode.Name = EBundleType.SoundCache.ToString();

            foreach (var item in Items)
            {
                var currentNode = RootNode;
                var parts = item.Key.Split('\\');

                for (var i = 0; i < parts.Length - 1; i++)
                {
                    if (!currentNode.Directories.ContainsKey(parts[i]))
                    {
                        var newNode = new WitcherTreeNode
                        {
                            Parent = currentNode,
                            Name = parts[i]
                        };
                        currentNode.Directories.Add(parts[i], newNode);
                        currentNode = newNode;
                    }
                    else
                    {
                        currentNode = currentNode.Directories[parts[i]];
                    }
                }

                currentNode.Files.Add(parts[parts.Length - 1], item.Value);
            }
            RebuildFileList();
            RebuildExtensions();
            RebuildAutoCompleteSource();
        }

        /// <summary>
        /// Calls GetFiles on the rootnode
        /// </summary>
        private void RebuildFileList()
        {
            FileList = GetFiles(RootNode);
        }

        /// <summary>
        /// Gets the avaliable extensions in the files
        /// </summary>
        private void RebuildExtensions()
        {
            foreach (var file in FileList.Where(file => !Extensions.Contains(file.Name.Split('.').Last())))
            {
                Extensions.Add(file.Name.Split('.').Last());
            }
            Extensions.Sort();
        }

        /// <summary>
        /// Gets the distinct filenames from the loaded bundles so they can be used for autocomplete
        /// </summary>
        private void RebuildAutoCompleteSource()
        {
            AutocompleteSource.AddRange(FileList.Select(x => GetFileName(x.Name)).Distinct().ToArray());
        }

        /// <summary>
        /// Deep search for files
        /// </summary>
        /// <param name="mainnode">The rootnode to get the files from</param>
        /// <returns></returns>
        private List<IGameFile> GetFiles(WitcherTreeNode mainnode)
        {
            var bundfiles = new List<IGameFile>();
            if (mainnode?.Files != null)
            {
                foreach (var wfile in mainnode.Files)
                {
                    bundfiles.AddRange(wfile.Value);
                }
                bundfiles.AddRange(mainnode.Directories.Values.SelectMany(GetFiles));
            }
            return bundfiles;
        }

        /// <summary>
        /// Since File.GetFileName() only works for real paths we need to have this
        /// </summary>
        /// <param name="s">Path/Name of the file</param>
        /// <returns></returns>
        private string GetFileName(string s)
        {
            return s.Contains('\\') ? s.Split('\\').Last() : s;
        }
    }
}
