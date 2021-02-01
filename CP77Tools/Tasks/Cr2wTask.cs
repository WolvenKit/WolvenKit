using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CP77.CR2W;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
{
    public static partial class ConsoleFunctions
    {
        public static void Cr2wTask(string[] path, string outpath, bool chunks)
        {
            if (path == null || path.Length < 1)
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                Cr2wTaskInner(file, outpath, chunks);
            });

        }

        private static void Cr2wTaskInner(string path, string outpath, bool chunks)
        {
            // initial checks
            if (string.IsNullOrEmpty(path))
            {
                logger.LogString("Please fill in an input path.", Logtype.Error);
                return;
            }
            var inputFileInfo = new FileInfo(path);
            if (!inputFileInfo.Exists)
            {
                logger.LogString("Input file does not exist.", Logtype.Error);
                return;
            }

            var outputDirInfo = string.IsNullOrEmpty(outpath) 
                ? inputFileInfo.Directory 
                : new DirectoryInfo(outpath);
            if (outputDirInfo == null || !outputDirInfo.Exists)
            {
                logger.LogString("Output directory is not valid.", Logtype.Error);
                return;
            }

            var f = File.ReadAllBytes(inputFileInfo.FullName);
            using var fs = new FileStream(inputFileInfo.FullName, FileMode.Open, FileAccess.Read);
            var cr2w = ModTools.TryReadCr2WFile(fs);
            if (cr2w == null)
                return;


            if (!chunks) return;
            //write
            File.WriteAllText(Path.Combine(outputDirInfo.FullName, $"{inputFileInfo.Name}.json"),
                JsonConvert.SerializeObject(cr2w, Formatting.Indented, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.None,
                    TypeNameHandling = TypeNameHandling.None
                }));
            logger.LogString($"Finished. Dump file written to {Path.Combine(outputDirInfo.FullName, $"{inputFileInfo.Name}.json")}", Logtype.Success);
        }
    }
}