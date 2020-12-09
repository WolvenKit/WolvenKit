using System;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Model;

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



            }

            return 1;
        }
    }
}