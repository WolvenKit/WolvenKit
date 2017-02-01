using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace W3Edit.Bundles
{
    public class BundleManager
    {
        public BundleManager()
        {
            Items = new Dictionary<string, List<BundleItem>>();
            Bundles = new Dictionary<string, Bundle>();
            FileList = new List<BundleItem>();
            Extensions = new List<string>();
            AutocompleteSource = new AutoCompleteStringCollection();
        }

        public Dictionary<string, List<BundleItem>> Items { get; set; }
        public Dictionary<string, Bundle> Bundles { get; set; }
        public BundleTreeNode RootNode { get; set; }
        public List<BundleItem> FileList { get; set; }
        public List<string> Extensions { get; set; }
        public AutoCompleteStringCollection AutocompleteSource { get; set; }   

        /// <summary>
        ///     Load a single bundle
        /// </summary>
        /// <param name="filename"></param>
        public void LoadBundle(string filename)
        {
            if (Bundles.ContainsKey(filename))
                return;

            var bundle = new Bundle(filename);

            foreach (var item in bundle.Items)
            {
                if (!Items.ContainsKey(item.Key))
                    Items.Add(item.Key, new List<BundleItem>());

                Items[item.Key].Add(item.Value);
            }

            Bundles.Add(filename, bundle);
        }

        /// <summary>
        ///     Load every bundle it can find in ..\..\content and ..\..\DLC, also calls RebuildRootNode()
        /// </summary>
        /// <param name="exedir">Path to executable directory</param>
        public void LoadAll(string exedir)
        {
            var content = Path.Combine(exedir, @"..\..\content\");

            var contentdirs = new List<string>(Directory.GetDirectories(content, "content*"));
            contentdirs.Sort(new AlphanumComparator<string>());
            foreach (var dir in contentdirs)
            {
                foreach (var file in Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories))
                {
                    LoadBundle(file);
                }
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var dir in patchdirs)
            {
                foreach (var file in Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories))
                {
                    LoadBundle(file);
                }
            }

            var dlc = Path.Combine(exedir, @"..\..\DLC\");
            var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
            dlcdirs.Sort(new AlphanumComparator<string>());
            foreach (var dir in dlcdirs)
            {
                if (Path.GetFileName(dir ?? "").StartsWith("mod"))
                    continue;

                foreach (var file in Directory.GetFiles(dir ?? "", "*.bundle", SearchOption.AllDirectories).OrderBy(k => k))
                {
                    LoadBundle(file);
                }
            }
            RebuildRootNode();
        }

        /// <summary>
        /// Loads the .bundle files from the /Mods/ folder
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
            foreach (var dir in modsdirs)
            {
                foreach (var file in Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories))
                {
                    LoadBundle(file);
                }
            }
            RebuildRootNode();
        }

        /// <summary>
        ///     Rebuilds the bundle tree structure also rebuilds NOTE: Filelist,autocomplete,extensions
        /// </summary>
        public void RebuildRootNode()
        {
            RootNode = new BundleTreeNode();

            foreach (var item in Items)
            {
                var currentNode = RootNode;
                var parts = item.Key.Split('\\');

                for (var i = 0; i < parts.Length - 1; i++)
                {
                    if (!currentNode.Directories.ContainsKey(parts[i]))
                    {
                        var newNode = new BundleTreeNode
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
        public List<BundleItem> GetFiles(BundleTreeNode mainnode)
        {
            var bundfiles = new List<BundleItem>();
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
        /// Since File.GetExtension() only works for real paths we need to have this
        /// </summary>
        /// <param name="s">Path/Name of the file</param>
        /// <returns></returns>
        public string GetFileName(string s)
        {
            return s.Contains('\\') ? s.Split('\\').Last() : s;
        }
    }
}