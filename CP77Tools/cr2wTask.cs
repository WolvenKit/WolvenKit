using System;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Model;

namespace CP77Tools
{
    public static partial class ConsoleFunctions
    {

        public static /*async Task<int>*/int Cr2wTask(Cr2wOptions options)
        {
            ////if (options.extract || options.dump)
            //{
            //    // initial checks
            //    var inputFileInfo = new FileInfo(options.path);
            //    if (!inputFileInfo.Exists)
            //        return 0;
            //    var outDir = inputFileInfo.Directory;
            //    if (outDir == null)
            //        return 0;
            //    if (!outDir.Exists)
            //        Directory.CreateDirectory(outDir.FullName);
            //    //if (inputFileInfo.Extension != ".cr2w")
            //    //    return 0;

            //    // load texture cache
            //    // switch chache types
            //    var ar = new CR2WFile(inputFileInfo.FullName);

                

            //    if (options.dump)
            //    {
            //        ar.DumpInfo();
            //    }
            //}

            //Console.WriteLine($"Finished extracting {options.path}");

            return 1;
        }
    }
}