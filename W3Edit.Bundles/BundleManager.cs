using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace W3Edit.Bundles
{
    public class BundleManager
    {
        public BundleManager()
        {
            GameItems = new Dictionary<string, List<BundleItem>>();
            GameBundles = new Dictionary<string, Bundle>();
            ModItems = new Dictionary<string, List<BundleItem>>();
            ModBundles = new Dictionary<string, Bundle>();
        }

        public Dictionary<string, List<BundleItem>> GameItems { get; set; }
        public Dictionary<string, Bundle> GameBundles { get; set; }
        public BundleTreeNode GameRootNode { get; set; }

        public Dictionary<string, List<BundleItem>> ModItems { get; set; }
        public Dictionary<string, Bundle> ModBundles { get; set; }
        public BundleTreeNode ModRootNode { get; set; }


        /// <summary>
        ///     Load a single game bundle
        /// </summary>
        /// <param name="filename"></param>
        public void LoadBundle(string filename,bool game)
        {
            if (game ? GameBundles.ContainsKey(filename) : ModBundles.ContainsKey(filename))
                return;

            var bundle = new Bundle(filename);

            foreach (var item in bundle.Items)
            {
                if (game)
                {
                    if (!GameItems.ContainsKey(item.Key))
                        GameItems.Add(item.Key, new List<BundleItem>());
                    GameItems[item.Key].Add(item.Value);
                }
                else
                {
                    if (!ModItems.ContainsKey(item.Key))
                        ModItems.Add(item.Key, new List<BundleItem>());
                    ModItems[item.Key].Add(item.Value);
                }

            }
            if (game)
                GameBundles.Add(filename, bundle);
            else
                ModBundles.Add(filename, bundle);
        }

        /// <summary>
        ///     Load every bundle it can find in ..\..\content and ..\..\DLC, also calls RebuildRootNode()
        /// </summary>
        /// <param name="exedir">Path to executable directory</param>
        public void LoadAll(string exedir)
        {
            GameItems.Clear();
            var content = Path.Combine(exedir, @"..\..\content\");

            var contentdirs = new List<string>(Directory.GetDirectories(content, "content*"));
            contentdirs.Sort(new AlphanumComparator<string>());
            foreach (var dir in contentdirs)
            {
                foreach (var file in Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories))
                {
                    LoadBundle(file,true);
                }
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in patchdirs.SelectMany(dir => Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories)))
            {
                LoadBundle(file,true);
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
                    LoadBundle(file,true);
                }
            }
            RebuilRootNode(true);
        }

        /// <summary>
        /// Loads the .bundle files from the /Mods/ folder
        /// Note this resets everything
        /// </summary>
        /// <param name="exedir"></param>
        public void LoadModsBundles(string exedir)
        {
            ModItems.Clear();
            var mods = Path.Combine(exedir, @"..\..\Mods\");
            var modsdirs = new List<string>(Directory.GetDirectories(mods));
            modsdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in modsdirs.SelectMany(dir => Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories)))
            {
                LoadBundle(file,false);
            }
            RebuilRootNode(false);
        }

        /// <summary>
        ///     Rebuilds the bundle tree structure
        /// </summary>
        public void RebuilRootNode(bool game)
        {
            if(game)
                GameRootNode = new BundleTreeNode();
            else
                ModRootNode = new BundleTreeNode();

            foreach (var item in (game ? GameItems : ModItems))
            {
                var currentNode = game ? GameRootNode : ModRootNode;
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