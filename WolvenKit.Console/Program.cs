using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.ConsoleColor;

/// <summary>
/// Well, you know, command-line interface (CLI)
/// </summary>
namespace WolvenKit.Console
{
    using CR2W;
    using System.IO;
    using CR2W.Types;
    using Cache;
    using Bundles;
    using Common;
    using static WolvenKit.CR2W.Types.Enums;
    using ConsoleProgressBar;
    using WolvenKit.Common.Model;
    using W3Speech;
    using Wwise;
    using System.Text.RegularExpressions;
    using System.IO.MemoryMappedFiles;
    using WolvenKit.Common.Extensions;
    using System.Collections.Concurrent;
    using Konsole;
    using Npgsql;
    using System.Security.AccessControl;
    using System.Security.Principal;

    public partial class WolvenKitConsole
    {

        [STAThread]
        public static async Task Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                while (true)
                {
                    string line = System.Console.ReadLine();
                    var parsed = ParseText(line, ' ', '"');
                    await Parse(parsed.ToArray());
                }

            }
            else
            {
                await Parse(args);
            }
        }

        internal static Task Parse(string[] _args)
        {
            var result = Parser.Default.ParseArguments<
                CacheOptions,
                BundleOptions,
                DumpCookedEffectsOptions,
                DumpXbmsOptions,
                DumpDDSOptions,
                DumpCollisionOptions,
                DumpArchivedFileInfosOptions,
                DumpMetadataStoreOptions,
                CR2WToPostgresOptions>(_args)
                        .MapResult(
                          async (CacheOptions opts) => await  ConsoleFunctions.DumpCache(opts),
                          async (BundleOptions opts) => await RunBundle(opts),
                          async (DumpCookedEffectsOptions opts) => await ConsoleFunctions.DumpCookedEffects(opts),
                          async (DumpXbmsOptions opts) => await ConsoleFunctions.DumpXbmInfo(opts),
                          async (DumpDDSOptions opts) => await ConsoleFunctions.DumpDDSInfo(opts),
                          async (DumpArchivedFileInfosOptions opts) => await DumpArchivedFileInfos(opts),
                          async (DumpMetadataStoreOptions opts) => await DumpMetadataStore(opts),
                          async (DumpCollisionOptions opts) => await ConsoleFunctions.DumpCollision(opts),
                          async (CR2WToPostgresOptions opts) => await CR2WToPostgres(opts),
                          //errs => 1,
                          _ => Task.FromResult(1));
            return result;
        }



        private static async Task<int> DumpArchivedFileInfos(DumpArchivedFileInfosOptions options)
        {
            /*Doesn't work for some reason
             * var mc = MainController.Get();
                        mc.Initialize();
                        List<IWitcherArchive> managers = MainController.Get().GetManagers(false);
            */
            uint cnt = 1;

            var bm = new BundleManager();
            bm.LoadAll("C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");
            var tm = new TextureManager();
            tm.LoadAll("C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");
            var cm = new CollisionManager();
            cm.LoadAll("C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");
            var em = new SpeechManager();
            em.LoadAll("C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");
            var sm = new SoundManager();
            sm.LoadAll("C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Witcher 3\\bin\\x64");

            var managers = new List<IWitcherArchiveManager>() { bm, tm, cm, em, sm };

            using (StreamWriter writer = File.CreateText("C:\\Users\\Maxim\\Desktop\\wk\\cons_wk_unbundled_file_namesv2.txt"))
            {
                foreach (var manager in managers)
                {
                    foreach (var file in manager.FileList)
                    {
                        writer.WriteLine(cnt++ + ";" + file.Bundle.ArchiveAbsolutePath + ";" + file.Name + ";" +
                            file.Bundle.TypeName + ";" + file.Size + ";" + file.CompressionType
                             + ";" + file.ZSize + ";" + file.PageOffset);
                    }
                    writer.WriteLine(Environment.NewLine);
                    //System.Console.WriteLine(cnt);
                }
            }
            System.Console.WriteLine($"Finished extracting " + cnt + " files.");
            System.Console.ReadLine();
            return 1;
        }

        public static void IntenseTest(List<string> Files2Test)
        {
            var xdoc = new XDocument(new XElement("CollisionCacheTest",
                Files2Test.Select(x => new XElement("Result", new XAttribute("FileName", x),
                                                   new XElement("OldFileHash", GetHash(x)),
                                                   new XElement("NewFileHash", CloneCollisionCache(x))))));
            xdoc.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\result.xml");
        }

        private static async Task<string> CloneCollisionCache(string old)
        {
            if (Cache.GetCacheTypeOfFile(old) == Cache.Cachetype.Collision)
            {
                var filename = Path.GetFileName(Path.GetTempFileName());
                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var workingdir = desktop + "\\workingdir";
                var clonedir = desktop + "\\clonedcachedir";
                try
                {
                    Directory.GetFiles(clonedir + "\\Collisioncache").ToList().ForEach(x => File.Delete(x));
                    System.Console.WriteLine("Deleted wms and bnks!");
                    Directory.GetFiles(workingdir).ToList().ForEach(x => File.Delete(x));
                    System.Console.WriteLine("Deleted soundcache clone!");
                }
                catch { }
                System.Console.Title = "Reading: " + old + "!";
                System.Console.WriteLine("-----------------------------------");
                var sc = new CollisionCache(old);
                foreach (var item in sc.Files)
                {
                    item.Extract(new BundleFileExtractArgs(clonedir + "\\" + item.Name));
                    System.Console.WriteLine("Extracted: " + item.Name);
                }
                var orderedfiles = new List<string>();
                foreach (var oi in sc.Files)
                {

                    foreach (var ni in Directory.GetFiles(clonedir + "\\Collisioncache").ToList().OrderBy(x => new FileInfo(x).CreationTime).ToList())
                    {
                        if (("Collisioncache\\" + Path.GetFileName(ni)) == oi.Name)
                            orderedfiles.Add(ni);
                    }
                }
                CollisionCache.Write(orderedfiles, workingdir + "\\" + filename + "_clone.cache");
                System.Console.WriteLine("-----------------------------------");
                System.Console.WriteLine("Collision cache clone created!");
                System.Console.WriteLine();
                return await GetHash(workingdir + "\\" + filename + "_clone.cache");
            }
            return "Not a Collisioncache";
        }

        private static async Task<string> GetHash(string FileName)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            using (var stream = File.OpenRead(FileName))
                return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "");
        }

        private static async Task<int> RunBundle(BundleOptions options)
        {
            return 0;
        }

        private static async Task<int> DumpMetadataStore(DumpMetadataStoreOptions options)
        {
            var ms = new Metadata_Store("C:\\Program Files (x86)\\Steam\\steamapps\\common\\The Witcher 3\\content\\metadata.store");
            using (StreamWriter writer = File.CreateText("C:\\Users\\maxim\\Desktop\\wk\\dump_metadatastore.csv"))
            {
                ms.SerializeToCsv(writer);
            }
                return 1;
        }

        public static IEnumerable<String> ParseText(String line, Char delimiter, Char textQualifier)
        {

            if (line == null)
                yield break;

            else
            {
                Char prevChar = '\0';
                Char nextChar = '\0';
                Char currentChar = '\0';

                Boolean inString = false;

                StringBuilder token = new StringBuilder();

                for (int i = 0; i < line.Length; i++)
                {
                    currentChar = line[i];

                    if (i > 0)
                        prevChar = line[i - 1];
                    else
                        prevChar = '\0';

                    if (i + 1 < line.Length)
                        nextChar = line[i + 1];
                    else
                        nextChar = '\0';

                    if (currentChar == textQualifier && prevChar != 0x5c && !inString)
                    {
                        inString = true;
                        continue;
                    }

                    if (currentChar == textQualifier && inString)
                    {
                        inString = false;
                        continue;
                    }

                    if (currentChar == delimiter && !inString)
                    {
                        yield return token.ToString();
                        token = token.Remove(0, token.Length);
                        continue;
                    }

                    token = token.Append(currentChar);

                }

                yield return token.ToString();

            }
        }
    }
}

