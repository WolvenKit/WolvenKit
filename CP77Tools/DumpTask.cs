using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using CP77Tools.Model;
using WolvenKit.CR2W;

namespace CP77Tools
{
    public class ArchiveDumpObject
    {
        public Dictionary<ulong, Cr2wDumpObject> FileDictionary { get; set; }
        public string Filename { get; set; }
    }

    public class Cr2wDumpObject
    {
        public Dictionary<uint, string> Stringdict { get; set; }
        public List<CR2WImportWrapper> Imports { get; set; }
        public List<CR2WBufferWrapper> Buffers { get; set; }
        public List<CR2WExportWrapper> Chunks { get; set; }
        public string Filename { get; set; }
    }


    public static partial class ConsoleFunctions
    {

        public static async Task<int> DumpTask(DumpOptions options)
        {
            // initial checks
            var inputFileInfo = new FileInfo(options.path);
            if (!inputFileInfo.Exists)
                return 0;


            var ar = new Archive(inputFileInfo.FullName);

            if (options.strings || options.imports || options.buffers || options.chunks || options.all)
            {
                Dictionary<ulong, Cr2wDumpObject> fileDictionary = new Dictionary<ulong, Cr2wDumpObject>();
                foreach (var key in ar.HashDictionary.Keys)
                {
                    var f = ar.ExtractOne(key);

                    try
                    {
                        var cr2w = new CR2WFile();

                        using var ms = new MemoryStream(f);
                        using var br = new BinaryReader(ms);
                        var (imports, _, buffers) = cr2w.ReadImportsAndBuffers(br);

                        var obj = new Cr2wDumpObject();
                        obj.Filename = key.ToString();

                        if (options.strings || options.all)
                            obj.Stringdict = cr2w.StringDictionary;
                        if (options.imports || options.all)
                            obj.Imports = imports;
                        if (options.buffers || options.all)
                            obj.Buffers = buffers;
                        if (options.chunks || options.all)
                            obj.Chunks = cr2w.Chunks;


                        fileDictionary.Add(key, obj);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Could not read file {key}.");
                        //throw;
                        continue;
                    }
                }

                
                var arobj = new ArchiveDumpObject()
                {
                    Filename = ar._filepath,
                    FileDictionary = fileDictionary
                };


                try
                {
                    var joptions = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };
                    var jsonstring = JsonSerializer.Serialize(arobj, joptions);

                    File.WriteAllText($"{ar._filepath}.dump.json", jsonstring);
                    Console.WriteLine($"Finished. Dump file written to {ar._filepath}.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return 1;
        }
    }
}