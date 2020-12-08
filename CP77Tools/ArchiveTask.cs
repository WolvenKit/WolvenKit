using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CP77Tools.Model;

namespace CP77Tools
{
    public enum OodleFormat : uint
    {
        LZH,
        LZHLW,
        LZNIB,
        None,
        LZB16,
        LZBLW,
        LZA,
        LZNA,
        Kraken,
        Mermaid,
        BitKnit,
        Selkie,
        Akkorokamui
    }

    public enum OodleCompressionLevel : ulong
    {
        None,
        SuperFast,
        VeryFast,
        Fast,
        Normal,
        Optimal1,
        Optimal2,
        Optimal3,
        Optimal4,
        Optimal5
    }

    public static partial class ConsoleFunctions
    {
        
        public static int ArchiveTask(ArchiveOptions options)
        {
            


            if (options.extract || options.dump)
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
                if (inputFileInfo.Extension != ".archive")
                    return 0;
                var indir = new FileInfo(options.path).Directory;
                if (indir == null)
                    return 0;

                // load texture cache
                // switch chache types
                var ar = new Archive(inputFileInfo.FullName);

                if (options.extract)
                {
                    ar.Extract(indir);

                    // ALL FILES

                    //for (int i = 0; i < ar.Files.Count; i++)
                    //{


                    //    var f = ar.Files[i];
                    //    var o = ar.Table.Offsets[i];
                    //    var outbuffer = new byte[o.Size];

                    //    var zero = f.Length - o.Zsize;

                    //    int decompressedCount = OodleLZ_Decompress(f, f.Length, outbuffer, o.Size
                    //        , 0, 0, 0, 0, 0, 0, 0, 0, 0, 3);

                    //    string outpath = Path.Combine(indir.FullName, $"extractedfile_{i}.bin");
                    //    File.WriteAllBytesAsync(outpath, outbuffer);
                    //}

                }

                if (options.dump)
                {
                    ar.DumpInfo();
                }
            }

            Console.WriteLine($"Finished extracting {options.path}");

            return 1;
        }

        private static uint GetCompressionBound(uint bufferSize)
        {
            return bufferSize + 274 * ((bufferSize + 0x3FFFF) / 0x40000);
        }
    }
}