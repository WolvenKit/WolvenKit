using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Bundles;
using WolvenKit.Cache;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Console
{
    public static partial class ConsoleFunctions
    {

        public static async Task<int> Cache(CacheOptions options)
        {
            if (options.dump || options.extract)
            {
                // initial checks
                var inputFileInfo = new FileInfo(options.path);
                if (!inputFileInfo.Exists)
                    return 0;
                var outDir = inputFileInfo.Directory;
                if (outDir == null)
                    return 0;
                if (!outDir.Exists)
                    Directory.CreateDirectory(outDir.FullName);
                if (inputFileInfo.Extension != ".cache")
                    return 0;
                if (inputFileInfo.Name != "texture.cache")
                {
                    System.Console.WriteLine($@"Only texture.caches are currently suported. {options.path}.");
                    return 0;
                }

                // load texture cache
                // switch chache types
                var txc = new TextureCache(inputFileInfo.FullName);

                if (options.dump)
                {
                    txc.DumpInfo();
                    System.Console.WriteLine($@"Finished dumping {options.path}.");
                }

                if (options.extract)
                {
                    foreach (var x in txc.Files)
                    {
                        string fullpath = Path.Combine(outDir.FullName, x.Name);
                        x.Extract(new BundleFileExtractArgs(fullpath, EUncookExtension.dds));
                        System.Console.WriteLine($@"Finished extracting {x.Name}");
                    }
                    System.Console.WriteLine($@"Finished extracting {options.path}.");
                }
            }

            if (options.create)
            {
                if (!Directory.Exists(options.path))
                    return 0;
                var txc = new TextureCache();
                txc.LoadFiles(options.path);
                txc.Write(Path.Combine(options.path, "texture.cache"));

                System.Console.WriteLine($@"Finished creating {options.path}.");
            }
            
            
            return 1;
        }
    }
}
