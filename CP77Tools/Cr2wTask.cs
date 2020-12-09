using System;
using System.IO;
using System.Threading.Tasks;
using CP77Tools.Model;
using WolvenKit.CR2W;

namespace CP77Tools
{
    public static partial class ConsoleFunctions
    {

        public static async Task<int> Cr2wTask(CR2WOptions options)
        {
            // initial checks
            var inputFileInfo = new FileInfo(options.path);
            if (!inputFileInfo.Exists)
                return 0;

            var buffer = File.ReadAllBytes(inputFileInfo.FullName);

            var file = new CR2WFile();
            file.Read(buffer);



           
            return 1;
        }
    }
}