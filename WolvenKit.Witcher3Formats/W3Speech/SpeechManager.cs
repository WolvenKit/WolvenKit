using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Common;

namespace WolvenKit.W3Speech
{
    public class SpeechManager : WitcherArchiveManager
    {
        public static string SerializationVersion => "1.0";
        public override EArchiveType TypeName => EArchiveType.Speech;
        public override Dictionary<string, IGameArchive> Archives { get; set; } = new();

        public SpeechManager()
        {
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

            var content = Path.Combine(di.Parent.Parent.FullName, "content");

            var contentdirs = new List<string>(Directory.GetDirectories(content, "content*"));
            contentdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in contentdirs.SelectMany(dir => Directory.GetFiles(dir, "*.w3speech", SearchOption.AllDirectories)))
            {
                LoadArchive(file);
            }

            var patchdirs = new List<string>(Directory.GetDirectories(content, "patch*"));
            patchdirs.Sort(new AlphanumComparator<string>());
            foreach (var file in patchdirs.SelectMany(dir => Directory.GetFiles(dir, "*.w3speech", SearchOption.AllDirectories)))
            {
                LoadArchive(file);
            }

            var dlc = Path.Combine(di.Parent.Parent.FullName, "DLC");
            if (Directory.Exists(dlc))
            {
                var dlcdirs = new List<string>(Directory.GetDirectories(dlc));
                dlcdirs.Sort(new AlphanumComparator<string>());

                foreach (var file in dlcdirs
                    .Where(_ => VanillaDlClist.Contains(new DirectoryInfo(_).Name))
                    .SelectMany(dir => Directory.GetFiles(dir ?? "", "*.w3speech", SearchOption.AllDirectories)
                        .OrderBy(k => k)))
                {
                    LoadArchive(file);
                }
            }
            RebuildRootNode();
        }

        /// <summary>
        ///     Load a single bundle
        /// </summary>
        /// <param name="filename"></param>
        public override void LoadArchive(string filename, bool ispatch = false)
        {
            if (Archives.ContainsKey(filename))
                return;

            var speech = Coder.Decode(new W3Speech(filename), new System.IO.BinaryReader(new FileStream(filename, FileMode.Open)));

            //foreach (var item in speech.Files.Values)
            //{
            //    if (!Items.ContainsKey(item.Name))
            //        Items.Add(item.Name, new List<IGameFile>());

            //    Items[item.Name].Add(item);
            //}

            Archives.Add(filename, speech);
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

            var speech = Coder.Decode(new W3Speech(filename), new System.IO.BinaryReader(new FileStream(filename, FileMode.Open)));

            //foreach (var item in speech.Files.Values)
            //{
            //    if (!Items.ContainsKey(GetModFolder(filename) + "\\" + item.Name))
            //        Items.Add(GetModFolder(filename) + "\\" + item.Name, new List<IGameFile>());

            //    Items[GetModFolder(filename) + "\\" + item.Name].Add(item);
            //}

            Archives.Add(filename, speech);
        }


        /// <summary>
        /// Loads the .bundle files from the /Mods/ folder
        /// Note this resets everything
        /// </summary>
        /// <param name="exedir"></param>
        public override void LoadModsArchives(string mods, string dlc)
        {
            if (!Directory.Exists(mods))
                Directory.CreateDirectory(mods);
            var modsdirs = new List<string>(Directory.GetDirectories(mods));
            modsdirs.Sort(new AlphanumComparator<string>());
            var modbundles = modsdirs.SelectMany(dir => Directory.GetFiles(dir, "*.w3speech", SearchOption.AllDirectories)).ToList();
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
                    .SelectMany(dir => Directory.GetFiles(dir ?? "", "*.w3speech", SearchOption.AllDirectories)
                        .OrderBy(k => k)))
                {
                    LoadModArchive(file);
                }
            }
            RebuildRootNode();
        }
    }
}
