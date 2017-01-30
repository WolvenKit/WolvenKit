using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace W3Edit.Bundles
{
    public class BundleManager
    {
        public BundleManager()
        {
            Items = new Dictionary<string, List<BundleItem>>();
            Bundles = new Dictionary<string, Bundle>();
        }

        public Dictionary<string, List<BundleItem>> Items { get; set; }
        public Dictionary<string, Bundle> Bundles { get; set; }
        public BundleTreeNode RootNode { get; set; }

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
            Items.Clear();
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
            Items.Clear();
            var mods = Path.Combine(exedir, @"..\..\Mods\");
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
        ///     Rebuilds the bundle tree structure
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
        }
    }
}