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
    public class TextureManager : WitcherArchiveManager
    {
        public TextureManager()
        {
            Items = new Dictionary<string, List<IWitcherFile>>();
            Archives = new Dictionary<string, TextureCache>();
            FileList = new List<IWitcherFile>();

            Extensions = new List<string>();
            AutocompleteSource = new AutoCompleteStringCollection();
        }

        public Dictionary<string, TextureCache> Archives { get; }
        public override EBundleType TypeName => EBundleType.TextureCache;



        /// <summary>
        ///     Load a single mod soundcache
        /// </summary>
        /// <param name="filename"></param>
        public override void LoadModBundle(string filename)
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
        public override void LoadBundle(string filename, bool ispatch = false)
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
                LoadBundle(file);
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in patchdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)))
            {
                LoadBundle(file);
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
        public override void LoadModsBundles(string exedir)
        {
            var di = new DirectoryInfo(exedir);
            if (!di.Exists)
                return;

            // this is slow
            Archives.Clear();
            Items.Clear();
            FileList.Clear();

            var mods = Path.Combine(di.Parent.Parent.FullName, "Mods");
            var dlc = Path.Combine(di.Parent.Parent.FullName, "DLC");

            if (!Directory.Exists(mods))
                Directory.CreateDirectory(mods);
            var modsdirs = new List<string>(Directory.GetDirectories(mods));
            modsdirs.Sort(new AlphanumComparator<string>());
            var modbundles = modsdirs.SelectMany(dir => Directory.GetFiles(dir, "*.cache", SearchOption.AllDirectories).Where(x => Cache.GetCacheTypeOfFile(x) == Cache.Cachetype.Texture)).ToList();
            foreach (var file in modbundles)
            {
                LoadModBundle(file);
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
                    LoadModBundle(file);
                }
            }
            RebuildRootNode();
        }
    }
}
