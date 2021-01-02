using System;
using System.IO;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Services;
using Newtonsoft.Json;
using WolvenKit.Common.Tools.DDS;
using WolvenKit.CR2W;

namespace CP77Tools.Tasks
{
    public static partial class ConsoleFunctions
    {
        public static void Cr2wTask(string[] path, string outpath, bool all, bool chunks)
        {
            if (path == null || path.Length < 1)
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                Cr2wTaskInner(file, outpath, all, chunks);
            });

        }

        private static int Cr2wTaskInner(string path, string outpath, bool all, bool chunks)
        {
            // initial checks
            if (string.IsNullOrEmpty(path))
            {
                logger.LogString("Please fill in an input path.", Logtype.Error);
                return 0;
            }
            var inputFileInfo = new FileInfo(path);
            if (!inputFileInfo.Exists)
            {
                logger.LogString("Input file does not exist.", Logtype.Error);
                return 0;
            }

            var outputDirInfo = string.IsNullOrEmpty(outpath) 
                ? inputFileInfo.Directory 
                : new DirectoryInfo(outpath);
            if (outputDirInfo == null || !outputDirInfo.Exists)
            {
                logger.LogString("Output directory is not valid.", Logtype.Error);
                return 0;
            }

            var f = File.ReadAllBytes(inputFileInfo.FullName);
            using var ms = new MemoryStream(f);
            using var br = new BinaryReader(ms);

            var cr2w = new CR2WFile();

            if (all)
            {
                cr2w.ReadImportsAndBuffers(br);

                var obj = new Cr2wChunkInfo { Filename = inputFileInfo.FullName };

                obj.Stringdict = cr2w.StringDictionary;
                obj.Imports = cr2w.Imports;
                obj.Buffers = cr2w.Buffers;
                obj.Chunks = cr2w.Chunks;
                foreach (var chunk in cr2w.Chunks)
                {
                    obj.ChunkData.Add(chunk.GetDumpObject(br));
                }

                //write
                File.WriteAllText(Path.Combine(outputDirInfo.FullName, $"{inputFileInfo.Name}.info.json"),
                    JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.None,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                logger.LogString($"Finished. Dump file written to {Path.Combine(outputDirInfo.FullName, $"{inputFileInfo.Name}.info.json")}", Logtype.Success);
            }

            if (chunks)
            {
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                cr2w.Read(br);

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




            return 1;
        }
    }
}