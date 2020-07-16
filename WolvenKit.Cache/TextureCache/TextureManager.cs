using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.Cache
{
    public class TextureManager : IWitcherArchive
    {
        public TextureManager()
        {
            Items = new Dictionary<string, List<IWitcherFile>>();
            Archives = new Dictionary<string, TextureCache>();
            FileList = new List<IWitcherFile>();
            Extensions = new List<string>();
            AutocompleteSource = new AutoCompleteStringCollection();
        }

        public Dictionary<string, List<IWitcherFile>> Items { get; set; }
        public Dictionary<string, TextureCache> Archives { get; set; }
        public WitcherTreeNode RootNode { get; set; }
        public List<IWitcherFile> FileList { get; set; }
        public EBundleType TypeName => EBundleType.TextureCache;
        public List<string> Extensions { get; set; }
        public AutoCompleteStringCollection AutocompleteSource { get; set; }

        /// <summary>
        ///     Load a single mod soundcache
        /// </summary>
        /// <param name="filename"></param>
        public void LoadModBundle(string filename)
        {
            if (Archives.ContainsKey(filename))
                return;

            var bundle = new TextureCache(filename);

            foreach (var item in bundle.Files)
            {
                if (!Items.ContainsKey(GetModFolder(filename) + "\\" + item.Name))
                    Items.Add(GetModFolder(filename) + "\\" + item.Name, new List<IWitcherFile>());

                Items[GetModFolder(filename) + "\\" + item.Name].Add(item);
            }

            Archives.Add(filename, bundle);
        }

        /// <summary>
        ///     Load a single soundcache
        /// </summary>
        /// <param name="filename"></param>
        public void LoadBundle(string filename)
        {
            if (Archives.ContainsKey(filename))
                return;

            var bundle = new TextureCache(filename);

            foreach (var item in bundle.Files)
            {
                if (!Items.ContainsKey(item.Name))
                    Items.Add(item.Name, new List<IWitcherFile>());

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
            var content = Path.Combine(exedir, @"..\..\content\");

            var contentdirs = new List<string>(Directory.GetDirectories(content, "content*"));
            contentdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in contentdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)))
            {
                LoadBundle(file);
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in patchdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)))
            {
                LoadBundle(file);
            }

            var dlc = Path.Combine(exedir, @"..\..\DLC\");
            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());
                foreach (var file in dlcdirs.Where(dir => new Regex("(DLC..)|(DLC.)|(BOB)|(ep.)|(bob)|(EP.)").IsMatch(Path.GetFileName(dir ?? ""))).SelectMany(dir => Directory.GetFiles(dir ?? "", "*.cache", SearchOption.AllDirectories).OrderBy(k => k).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)))
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
        /// <param name="exedir"></param>
        public void LoadModsBundles(string exedir)
        {
            var mods = Path.Combine(exedir, @"..\..\Mods\");
            if (!Directory.Exists(mods))
                Directory.CreateDirectory(mods);
            var modsdirs = new List<string>(Directory.GetDirectories(mods));
            modsdirs.Sort(new AlphanumComparator<string>());
            var modbundles = modsdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)).ToList();
            foreach (var file in modbundles)
            {
                LoadModBundle(file);
            }

            var dlc = Path.Combine(exedir, @"..\..\DLC\");
            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());
                foreach (var file in dlcdirs.Where(dir => !new Regex("(DLC..)|(DLC.)|(BOB)|(bob)|(EP.)|(ep.)").IsMatch(Path.GetFileName(dir ?? ""))).SelectMany(dir => Directory.GetFiles(dir ?? "", "*.cache", SearchOption.AllDirectories).OrderBy(k => k).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)))
                {
                    LoadModBundle(file);
                }
            }
            RebuildRootNode();
        }

        public static string GetModFolder(string path)
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
        public void RebuildRootNode()
        {
            RootNode = new WitcherTreeNode(EBundleType.TextureCache);
            RootNode.Name = EBundleType.TextureCache.ToString();

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
        public void RebuildFileList()
        {
            FileList = GetFiles(RootNode);
        }

        /// <summary>
        /// Gets the avaliable extensions in the files
        /// </summary>
        public void RebuildExtensions()
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
        public void RebuildAutoCompleteSource()
        {
            AutocompleteSource.AddRange(FileList.Select(x => GetFileName(x.Name)).Distinct().ToArray());
        }

        /// <summary>
        /// Deep search for files
        /// </summary>
        /// <param name="mainnode">The rootnode to get the files from</param>
        /// <returns></returns>
        public List<IWitcherFile> GetFiles(WitcherTreeNode mainnode)
        {
            var bundfiles = new List<IWitcherFile>();
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
        public string GetFileName(string s)
        {
            return s.Contains('\\') ? s.Split('\\').Last() : s;
        }
    }
}
