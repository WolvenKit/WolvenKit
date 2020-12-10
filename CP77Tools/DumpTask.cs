using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Catel.Collections;
using ConsoleProgressBar;
using CP77Tools.Model;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
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
        private static byte[] MAGIC = new byte[] {0x43, 0x52, 0x32, 0x57};

        public static int DumpTask(string path/*, bool all, bool strings*/, bool imports/*, bool buffers, bool chunks*/)
        {
            // initial checks
            var isDirectory = false;
            var inputFileInfo = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);
            if (!inputFileInfo.Exists)
            {
                if (!inputDirInfo.Exists)
                    return 0;
                else
                    isDirectory = true;
            }

            var archives = new List<Archive>();

            if (isDirectory)
            {
                archives.AddRange(inputDirInfo
                    .GetFiles("*.archive", SearchOption.AllDirectories)
                    .Select(_ => new Archive(_.FullName)));
            }
            else
            {
                archives.Add(new Archive(inputFileInfo.FullName));
            }

            if (imports /*|| strings || buffers || chunks || all*/)
            {

                foreach (var ar in archives)
                {
                    using var mmf = MemoryMappedFile.CreateFromFile(ar._filepath, FileMode.Open, ar._filepath.GetHashMD5(), 0,
                    MemoryMappedFileAccess.Read);
                    var fileDictionary = new ConcurrentDictionary<ulong, Cr2wDumpObject>();
                    foreach (var (key, value) in ar.HashDictionary)
                    {
                        fileDictionary[key] = new Cr2wDumpObject();
                    }

                    using var pb = new ProgressBar();
                    using var p1 = pb.Progress.Fork();

                    int progress = 0;

                    var count = ar.HashDictionary.Count;
                    Parallel.For(0, count, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i =>
                    {
                        var key = ar.GetHashFromIndex(i);

                        var f = ar.GetFileData((int)i, mmf);

                            // check if cr2w file
                            if (f.Length < 4)
                                return;

                            var id = f.Take(4);
                            if (!id.SequenceEqual(MAGIC))
                                return;
                            else
                            {
                                
                            }

                        try
                        {
                            var cr2w = new CR2WFile();

                            using var ms = new MemoryStream(f);
                            using var br = new BinaryReader(ms);
                            cr2w.ReadImportsAndBuffers(br);

                            var obj = new Cr2wDumpObject { Filename = key.ToString() };

                            //if (strings || all)
                            //    obj.Stringdict = cr2w.StringDictionary;
                            if (imports /*|| all*/)
                                obj.Imports = cr2w.Imports;
                            //if (buffers || all)
                            //    obj.Buffers = cr2w.Buffers;
                            //if (chunks || all)
                            //    obj.Chunks = cr2w.Chunks;

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


                    // write
                    using var writer = File.CreateText($"{ar._filepath}.imports.txt");
                    using var hwriter = File.CreateText($"{ar._filepath}.hashes.csv");
                    hwriter.WriteLine("String,Hash");
                    List<string> allimports = new List<string>();

                    foreach (var (key, value) in arobj.FileDictionary)
                    {
                        if (value.Imports == null)
                            continue;
                        foreach (var import in value.Imports)
                        {
                            allimports.Add(import.DepotPathStr);
                        }
                    }

                    foreach (var str in allimports.Distinct())
                    {
                        writer.WriteLine(str);
                        var hash = FNV1A64HashAlgorithm.HashString(str);
                        hwriter.WriteLine($"{str},{hash}");
                    }




                    Console.WriteLine($"Finished. Dump file written to {ar._filepath}.");
                }
            }

            return 1;
        }
    }
}