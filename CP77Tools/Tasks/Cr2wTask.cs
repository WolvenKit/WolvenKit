using System;
using System.IO;
using Newtonsoft.Json;
using WolvenKit.CR2W;

namespace CP77Tools.Tasks
{
    public static partial class ConsoleFunctions
    {

        public static int Cr2wTask(string path, bool all, bool chunks)
        {
            // initial checks
            var inputFileInfo = new FileInfo(path);
            if (!inputFileInfo.Exists)
                return 0;

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
                File.WriteAllText($"{inputFileInfo.FullName}.info.json", 
                    JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.None,
                    TypeNameHandling = TypeNameHandling.Auto
                }));
                Console.WriteLine($"Finished. Dump file written to {inputFileInfo.FullName}.info.json");
            }

            if (chunks)
            {
                cr2w.Read(br);

                //write
                File.WriteAllText($"{inputFileInfo.FullName}.json",
                    JsonConvert.SerializeObject(cr2w, Formatting.Indented, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.None,
                        TypeNameHandling = TypeNameHandling.None
                    }));
                Console.WriteLine($"Finished. Dump file written to {inputFileInfo.FullName}.json");
            }

            
            

            return 1;
        }
    }
}