using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Catel.Collections;
using Catel.IoC;
using ConsoleProgressBar;
using CP77Tools.Model;
using CP77Tools.Services;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace CP77Tools
{
    public class ArchiveDumpObject
    {
        public ConcurrentDictionary<ulong, Cr2wChunkInfo> FileDictionary { get; set; }
        public ConcurrentDictionary<ulong, Cr2wTextureInfo> TextureDictionary { get; set; }
        public string Filename { get; set; }
    }

    public class Cr2wChunkInfo
    {
        public Dictionary<uint, string> Stringdict { get; set; }
        public List<CR2WImportWrapper> Imports { get; set; }
        public List<CR2WBufferWrapper> Buffers { get; set; }

        public List<CR2WExportWrapper> Chunks { get; set; }

        public List<CR2WExportWrapper.Cr2wVariableDumpObject> ChunkData { get; } =
            new List<CR2WExportWrapper.Cr2wVariableDumpObject>();

        public string Filename { get; set; }
    }

    public class Cr2wTextureInfo
    {
        public string Filename { get; set; }

        public ushort width { get; set; }
        public ushort height { get; set; }
        public byte mips { get; set; }
        public ushort slicecount { get; set; }
        public uint alignment { get; set; }
        public CEnum<Enums.ETextureCompression> compression { get; set; }
        public CEnum<Enums.GpuWrapApieTextureGroup> Group { get; set; }
        public CEnum<Enums.ETextureRawFormat> rawFormat { get; set; }
    }


    public static partial class ConsoleFunctions
    {
        private static byte[] MAGIC = new byte[] {0x43, 0x52, 0x32, 0x57};

        public static int DumpTask(string path, bool imports, bool missinghashes, bool info)
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

            var mainController = ServiceLocator.Default.ResolveType<IMainController>();

            var missinghashtxt = isDirectory 
                ? Path.Combine(inputDirInfo.FullName, "missinghashes.txt") 
                : $"{inputFileInfo.FullName}.missinghashes.txt";
            using var mwriter = File.CreateText(missinghashtxt);

            foreach (var ar in archives)
            {
                using var pb = new ProgressBar();
                if (imports || info)
                {
                    using var mmf = MemoryMappedFile.CreateFromFile(ar.Filepath, FileMode.Open,
                        ar.Filepath.GetHashMD5(), 0,
                        MemoryMappedFileAccess.Read);
                    using var p1 = pb.Progress.Fork();
                    int progress = 0;

                    var fileDictionary = new ConcurrentDictionary<ulong, Cr2wChunkInfo>();
                    var texDictionary = new ConcurrentDictionary<ulong, Cr2wTextureInfo>();
                    //foreach (var (hash, value) in ar.Files) 
                    //    fileDictionary[hash] = new Cr2wChunkInfo();

                    // get info
                    var count = ar.FileCount;
                    Parallel.For(0, count, new ParallelOptions {MaxDegreeOfParallelism = 8}, i =>
                    {
                        var entry = ar.Files.ToList()[i];
                        var hash = entry.Key;
                        var filename = string.IsNullOrEmpty(entry.Value.NameStr) ? hash.ToString() : entry.Value.NameStr;

                        if (imports)
                        {
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

                            var obj = new Cr2wChunkInfo
                            {
                                Filename = filename,
                                Imports = cr2w.Imports
                            };

                            

                            fileDictionary.AddOrUpdate(hash, obj, (arg1, o) => obj);
                        }

                        if (info)
                        {
                            if (!string.IsNullOrEmpty(entry.Value.NameStr) && entry.Value.NameStr.Contains(".xbm"))
                            {
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
                                var result = cr2w.Read(br);

                                if (result != EFileReadErrorCodes.NoError)
                                    return;
                                if (!(cr2w.Chunks.FirstOrDefault()?.data is CBitmapTexture xbm) ||
                                    !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
                                    return;

                                // create dds header
                                var texinfo = new Cr2wTextureInfo()
                                {
                                    Filename = filename,
                                    width = blob.Header.SizeInfo.Width.val,
                                    height = blob.Header.SizeInfo.Height.val,
                                    mips = blob.Header.TextureInfo.MipCount.val,
                                    slicecount = blob.Header.TextureInfo.SliceCount.val,
                                    alignment = blob.Header.TextureInfo.DataAlignment.val,
                                    compression = xbm.Setup.Compression,
                                    Group = xbm.Setup.Group,
                                    rawFormat = xbm.Setup.RawFormat,
                                };

                                texDictionary.AddOrUpdate(hash, texinfo, (arg1, o) => texinfo);
                            }
                        }

                        progress += 1;
                        var perc = progress / (double)count;
                        p1.Report(perc, $"Loading bundle entries: {progress}/{count}");
                    });

                    // write
                    var arobj = new ArchiveDumpObject()
                    {
                        Filename = ar.Filepath,
                        FileDictionary = fileDictionary,
                        TextureDictionary = texDictionary
                    };

                    if (imports)
                    {
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
                            if (!mainController.Hashdict.ContainsKey(hash))
                                hwriter.WriteLine($"{str},{hash}");
                        }

                        Console.WriteLine($"Finished. Dump file written to {ar.Filepath}.");
                    }

                    if (info)
                    {
                        //write
                        File.WriteAllText($"{ar.Filepath}.textures.json",
                            JsonConvert.SerializeObject(arobj, Formatting.Indented, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.None,
                                TypeNameHandling = TypeNameHandling.None
                            }));
                        Console.WriteLine($"Finished. Dump file written to {inputFileInfo.FullName}.json");
                    }
                }

                if (missinghashes)
                {
                    var ctr = 0;
                    foreach (var (hash, fileInfoEntry) in ar.Files)
                    {
                        if (fileInfoEntry.NameStr == hash.ToString())
                        {
                            mwriter.WriteLine(hash);
                            ctr++;
                        }
                    }
                    Console.WriteLine($"{ar.Filepath} - missing: {ctr}");
                }

            }


            return 1;
        }
    }
}