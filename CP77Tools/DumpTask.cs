using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text.Json;
using System.Threading.Tasks;
using Catel.Collections;
using ConsoleProgressBar;
using CP77Tools.Model;
using WolvenKit.Common.Extensions;
using WolvenKit.CR2W;

namespace CP77Tools
{
    public class ArchiveDumpObject
    {
        public ConcurrentDictionary<ulong, Cr2wDumpObject> FileDictionary { get; set; }
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

                using var pb = new ProgressBar();
                using var p1 = pb.Progress.Fork();

                int progress = 0;

                try
                {
                    using var mmf = MemoryMappedFile.CreateFromFile(ar._filepath, FileMode.Open, ar._filepath.GetHashMD5(), 0,
                        MemoryMappedFileAccess.Read);
                    var fileDictionary = new ConcurrentDictionary<ulong, Cr2wDumpObject>();
                    foreach (var (key, value) in ar.HashDictionary)
                    {
                        fileDictionary[key] = new Cr2wDumpObject();
                    }

                    var count = ar.HashDictionary.Count;
                    Parallel.For(0, count, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i =>
                    {
                        var key = ar.GetHashFromIndex(i);

                        try
                        {
                            var f = ar.GetFileData((int)i, mmf);

                            var cr2w = new CR2WFile();

                            using var ms = new MemoryStream(f);
                            using var br = new BinaryReader(ms);
                            cr2w.ReadImportsAndBuffers(br);

                            var obj = new Cr2wDumpObject {Filename = key.ToString()};

                            if (options.strings || options.all)
                                obj.Stringdict = cr2w.StringDictionary;
                            if (options.imports || options.all)
                                obj.Imports = cr2w.Imports;
                            if (options.buffers || options.all)
                                obj.Buffers = cr2w.Buffers;
                            if (options.chunks || options.all)
                                obj.Chunks = cr2w.Chunks;

                            //fileDictionary[key] = obj;
                            fileDictionary.AddOrUpdate(key, obj, (arg1, o) => obj);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Could not read file {key}.");
                            //throw;
                            return;
                        }
                        finally
                        {
                            progress += 1;
                            var perc = progress / (double)count;
                            p1.Report(perc, $"Loading bundle entries: {progress}/{count}");
                        }
                    });


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