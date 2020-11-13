using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WolvenKit.Common;
using WolvenKit.Common.Model;

namespace WolvenKit.Bundles
{
    public class BundleManager : WitcherArchiveManager
    {
        public BundleManager()
        {
            Items = new Dictionary<string, List<IWitcherFile>>();
            Bundles = new Dictionary<string, Bundle>();
            FileList = new List<IWitcherFile>();
            Extensions = new List<string>();
            AutocompleteSource = new AutoCompleteStringCollection();
        }

        public Dictionary<string, Bundle> Bundles { get; }
        
        public override EBundleType TypeName => EBundleType.Bundle;
        public static string SerializationVersion => "1.0";

        /// <summary>
        ///     Load a single mod bundle
        /// </summary>
        /// <param name="filename">
        ///     file to process
        /// </param>
        public override void LoadModBundle(string filename)
        {
            if (Bundles.ContainsKey(filename))
                return;

            var bundle = new Bundle(filename);

            foreach (var item in bundle.Items)
            {
                if (!Items.ContainsKey(GetModFolder(filename) + "\\" + item.Key))
                    Items.Add(GetModFolder(filename) + "\\" + item.Key, new List<IWitcherFile>());

                Items[GetModFolder(filename) + "\\" +item.Key].Add(item.Value);
            }

            Bundles.Add(filename, bundle);
        }

        /// <summary>
        /// Load a single bundle
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="ispatch"></param>
        public override void LoadBundle(string filename, bool ispatch = false)
        {
            if (Bundles.ContainsKey(filename))
                return;

            var bundle = new Bundle(filename);
            foreach (KeyValuePair<string, BundleItem> item in bundle.Items)
            {
                // add new key if the file isn't already in another bundle
                if (!Items.ContainsKey(item.Key))
                    Items.Add(item.Key, new List<IWitcherFile>());

                // if file is already in another bundle
                if (ispatch && Items[item.Key].Count > 0)
                {
                    // check if file is already in contentN directory (content0, content1 etc) 
                    List<IWitcherFile> filesInBundles = Items[item.Key];
                    var splits = filesInBundles.First().Bundle.ArchiveAbsolutePath.Split(Path.DirectorySeparatorChar);
                    var contentdir = splits[splits.Length - 3];
                    if (contentdir.Contains("content"))
                    {
                        // then remove all other existing files
                        for (var i = 0; i < filesInBundles.Count; i++)
                        {
                            bundle.Patchedfiles.Add(filesInBundles[i]);
                            filesInBundles.RemoveAt(0);
                        }
                    }
                }
                Items[item.Key].Add(item.Value);
            }

            Bundles.Add(filename, bundle);
        }

        /// <summary>
        ///     Load every non-mod bundle it can find in ..\..\content and ..\..\DLC, also calls RebuildRootNode()
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
            foreach (var file in contentdirs.SelectMany(dir => Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories)))
            {
                LoadBundle(file);
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in patchdirs.SelectMany(dir =>
                Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories)))
            {
                LoadBundle(file, true);
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
        public override void LoadModsBundles(string exedir)
        {
            var di = new DirectoryInfo(exedir);
            if (!di.Exists)
                return;
            var mods = Path.Combine(di.Parent.Parent.FullName, "Mods");
            var dlc = Path.Combine(di.Parent.Parent.FullName, "DLC");

            if (!Directory.Exists(mods))
                Directory.CreateDirectory(mods);
            var modsdirs = new List<string>(Directory.GetDirectories(mods));
            modsdirs.Sort(new AlphanumComparator<string>());
            var modbundles = modsdirs.SelectMany(dir => Directory.GetFiles(dir, "*.bundle", SearchOption.AllDirectories)).ToList();
            foreach (var file in modbundles)
            {
                LoadModBundle(file);
            }
            
            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());

                var tmp = dlcdirs.Where(_ => !VanillaDlClist.Contains(new DirectoryInfo(_).Name)).ToList();
                foreach (var file in tmp.SelectMany(dir => Directory.GetFiles(dir ?? "", "*.bundle", SearchOption.AllDirectories).OrderBy(k => k)))
                {
                    LoadModBundle(file);
                }
            }
            RebuildRootNode();
        }

    }
}
