using System;
using System.IO;
using Newtonsoft.Json;
using WolvenKit.CR2W;

namespace CP77Tools.Tasks
{
    public static partial class ConsoleFunctions
    {

        public static int Cr2wTask(string path, string outpath, bool all, bool chunks)
        {
            // initial checks
            if (string.IsNullOrEmpty(path)) return 0;
            if (string.IsNullOrEmpty(outpath)) { outpath = path; }

            var inputFileInfo = new FileInfo(path);
            var outputDirInfo = new DirectoryInfo(outpath);

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
                File.WriteAllText($"{outputDirInfo.FullName}" + inputFileInfo.Name + ".info.json",
                    JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.None,
                        TypeNameHandling = TypeNameHandling.Auto
                    }));
                Console.WriteLine($"Finished. Dump file written to {outputDirInfo.FullName} as " + inputFileInfo.Name + ".info.json");
            }

            if (chunks)
            {
                cr2w.Read(br);

                //write
                File.WriteAllText($"{outputDirInfo.FullName}" + inputFileInfo.Name + ".json",
                    JsonConvert.SerializeObject(cr2w, Formatting.Indented, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.None,
                        TypeNameHandling = TypeNameHandling.None
                    }));
                Console.WriteLine($"Finished. Dump file written to {outputDirInfo.FullName} as " + inputFileInfo.Name + ".json");
            }




            return 1;
        }
    }
}