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

        public List<CR2WExportWrapper.Cr2wVariableDumpObject> ChunkData { get; } =
            new List<CR2WExportWrapper.Cr2wVariableDumpObject>();

        public string Filename { get; set; }
    }

    public class Cr2wVariableObject
    {

    }


    public static partial class ConsoleFunctions
    {
        private static byte[] MAGIC = new byte[] {0x43, 0x52, 0x32, 0x57};

        public static int DumpTask(string path, bool imports, bool missinghashes)
        {
            #region checks

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

            #endregion

            
            var missinghashtxt = isDirectory 
                ? Path.Combine(inputDirInfo.FullName, "missinghashes.txt") 
                : $"{inputFileInfo.FullName}.missinghashes.txt";
            using var mwriter = File.CreateText(missinghashtxt);

            foreach (var ar in archives)
            {
                using var pb = new ProgressBar();
                if (imports)
                {
                    using var mmf = MemoryMappedFile.CreateFromFile(ar.Filepath, FileMode.Open,
                        ar.Filepath.GetHashMD5(), 0,
                        MemoryMappedFileAccess.Read);
                    using var p1 = pb.Progress.Fork();
                    int progress = 0;

                    var fileDictionary = new ConcurrentDictionary<ulong, Cr2wDumpObject>();
                    foreach (var (hash, value) in ar.Files) 
                        fileDictionary[hash] = new Cr2wDumpObject();

                    // get info
                    var count = ar.FileCount;
                    Parallel.For(0, count, new ParallelOptions {MaxDegreeOfParallelism = 8}, i =>
                    {
                        var entry = ar.Files.ToList()[i];
                        var hash = entry.Key;
                        var (f, buffers) = ar.GetFileData(hash, mmf);

                        // check if cr2w file
                        if (f.Length < 4)
                            return;
                        var id = f.Take(4);
                        if (!id.SequenceEqual(MAGIC))
                            return;

                        var cr2w = new CR2WFile();

                        using var ms = new MemoryStream(f);
                        using var br = new BinaryReader(ms);
                        cr2w.ReadImportsAndBuffers(br);

                        var obj = new Cr2wDumpObject
                        {
                            Filename = hash.ToString(),
                            Imports = cr2w.Imports
                        };


                        fileDictionary.AddOrUpdate(hash, obj, (arg1, o) => obj);

                        progress += 1;
                        var perc = progress / (double)count;
                        p1.Report(perc, $"Loading bundle entries: {progress}/{count}");
                    });

                    // write
                    var arobj = new ArchiveDumpObject()
                    {
                        Filename = ar.Filepath,
                        FileDictionary = fileDictionary
                    };

                    using var writer = File.CreateText($"{ar.Filepath}.imports.txt");
                    using var hwriter = File.CreateText($"{ar.Filepath}.hashes.csv");
                    hwriter.WriteLine("String,Hash");
                    List<string> allimports = new List<string>();

                    foreach (var (key, value) in arobj.FileDictionary)
                    {
                        if (value.Imports == null)
                            continue;
                        allimports.AddRange(value.Imports.Select(import => import.DepotPathStr));
                    }
                    foreach (var str in allimports.Distinct())
                    {
                        writer.WriteLine(str);
                        var hash = FNV1A64HashAlgorithm.HashString(str);
                        hwriter.WriteLine($"{str},{hash}");
                    }

                    Console.WriteLine($"Finished. Dump file written to {ar.Filepath}.");
                }

                if (missinghashes)
                {
                    
                    foreach (var (hash, fileInfoEntry) in ar.Files)
                    {
                        if (fileInfoEntry.NameStr == hash.ToString())
                        {
                            mwriter.WriteLine(hash);
                        }
                    }
                }
            }


            return 1;
        }
    }
}