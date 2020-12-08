using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CP77Tools.Model;

namespace CP77Tools
{
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

                var ar = new Archive(inputFileInfo.FullName);

                if (options.extract)
                {
                    var outDir = Directory.CreateDirectory(inputFileInfo.Directory + "\\" + inputFileInfo.Name.Replace(".archive", ""));
                    if (outDir == null)
                        return 0;
                    if (!outDir.Exists)
                        Directory.CreateDirectory(outDir.FullName);
                    if (inputFileInfo.Extension != ".archive")
                        return 0;

                    for (var i = 0; i < ar.FilesCount; i++)
                    {
                        var file = ar.GetFileData(i);
                        var indir = new FileInfo(options.path).Directory;
                        if (indir == null)
                            continue;

                        string extension = "bin";
                        if (options.extension != null)
                        {
                            extension = options.extension;
                        }
                        
                        string outpath = Path.Combine(outDir.FullName, $"{ar.Table.FileInfo[i].NameHash64:X8}.{extension}");

                        File.WriteAllBytes(outpath, file);
                    }
                }

                if (options.dump)
                {
                    ar.DumpInfo();
                }
            }

            Console.WriteLine($"Finished extracting {options.path}");

            return 1;
        }
    }
}