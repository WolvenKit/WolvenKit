using System;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Model;
using WolvenKit.CR2W;

namespace CP77Tools
{
    public static partial class ConsoleFunctions
    {

        public static async Task<int> DumpTask(DumpOptions options)
        {
            // initial checks
            var inputFileInfo = new FileInfo(options.path);
            if (!inputFileInfo.Exists)
                return 0;

            var ar = new Archive(inputFileInfo.FullName);

            if (options.dumpstrings)
            {
                foreach (var key in ar.HashDictionary.Keys)
                {
                    var f = ar.ExtractOne(key);

                    var cr2w = new CR2WFile();

                }


            }

            return 1;
        }
    }
}