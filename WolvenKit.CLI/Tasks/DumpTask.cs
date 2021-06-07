using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.RED4.CR2W.Types;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Core.Services;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.CR2W;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Fields

        private static byte[] MAGIC = { 0x43, 0x52, 0x32, 0x57 };

        #endregion Fields

        #region Methods

        public void DumpTask(string[] path, bool imports, bool missinghashes,
            bool texinfo, bool dump, bool list)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            Parallel.ForEach(path, file =>
            {
                DumpTaskInner(file, imports, missinghashes, texinfo, dump, list);
            });
        }

        public int DumpTaskInner(string path, bool imports, bool missinghashes,
            bool texinfo, bool dump, bool list)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                _loggerService.Warning("Please fill in an input path.");
                return 0;
            }

            var isDirectory = false;
            var inputFileInfo = new FileInfo(path);
            var inputDirInfo = new DirectoryInfo(path);
            if (!inputFileInfo.Exists)
            {
                if (!inputDirInfo.Exists)
                {
                    return 0;
                }
                else
                {
                    isDirectory = true;
                }
            }

            #endregion checks

            var archives = new List<Archive>();

            if (isDirectory)
            {
                archives.AddRange(inputDirInfo
                    .GetFiles("*.archive", SearchOption.AllDirectories)
                    .Select(_ => Red4ParserServiceExtensions.ReadArchive(_.FullName, _hashService)));
            }
            else
            {
                archives.Add(Red4ParserServiceExtensions.ReadArchive(inputFileInfo.FullName, _hashService));
            }

            if (missinghashes)
            {
                List<ulong> used = new();
                List<ulong> missing = new();

                _loggerService.Info($"Parsing...");
                for (var i = 0; i < archives.Count; i++)
                {
                    var ar = archives[i];
                    foreach (var (hash, fileInfoEntry) in ar.Files)
                    {
                        if (fileInfoEntry is FileEntry fe && fe.NameOrHash == hash.ToString())
                        {
                            missing.Add(hash);
                        }
                        else
                        {
                            used.Add(hash);
                        }
                    }

                    _progressService.Report((i + 1) / (float)archives.Count);
                }

                // write all used and all missing hashes
                _loggerService.Info($"Writing...");

                var missinghashtxt = isDirectory
                    ? Path.Combine(inputDirInfo.FullName, "missinghashes.txt")
                    : $"{inputFileInfo.FullName}.missinghashes.txt";

                using var missingWriter = File.CreateText(missinghashtxt);
                for (var i = 0; i < missing.Count; i++)
                {
                    var mh = missing[i];
                    missingWriter.WriteLine(mh);
                    _progressService.Report((i + 1) / (float)missing.Count);
                }

                var usedhashtxt = isDirectory
                    ? Path.Combine(inputDirInfo.FullName, "usedhashes.txt")
                    : $"{inputFileInfo.FullName}.usedhashes.txt";
                using var usedWriter = File.CreateText(usedhashtxt);
                for (var i = 0; i < used.Count; i++)
                {
                    var mh = used[i];
                    usedWriter.WriteLine(_hashService.Get(mh));
                    _progressService.Report((i + 1) / (float)used.Count);
                }

                //List<ulong> unused = new();
                var unusedhashtxt = isDirectory
                    ? Path.Combine(inputDirInfo.FullName, "unusedhashes.txt")
                    : $"{inputFileInfo.FullName}.unusedhashes.txt";
                using var unusedWriter = File.CreateText(unusedhashtxt);

                var allhashes = _hashService.GetAllHashes().ToList();

                var unused = allhashes.Except(used).ToList();

                for (var i = 0; i < unused.Count; i++)
                {
                    var h = allhashes[i];
                    unusedWriter.WriteLine(_hashService.Get(h));
                    _progressService.Report((i + 1) / (float)unused.Count);
                }

                _loggerService.Info($"Unused: {unused.Count}");
                _loggerService.Info($"Used: {used.Count}");
                _loggerService.Info($"Missing: {missing.Count}");

                return 1;
            }

            // Parallel
            foreach (var ar in archives)
            {
                if (imports || texinfo)
                {
                    if (texinfo && ar.Files.Values.All(_ => _.Extension != ".xbm"))
                    {
                        _loggerService.Info($"Skipping {ar.Name}");
                        continue;
                    }

                    // using var mmf = MemoryMappedFile.CreateFromFile(ar.Filepath, FileMode.Open,
                    //     ar.Filepath.GetHashMD5(), 0,
                    //     MemoryMappedFileAccess.Read);

                    var fileDictionary = new ConcurrentDictionary<ulong, Cr2wChunkInfo>();
                    var texDictionary = new ConcurrentDictionary<ulong, Cr2wTextureInfo>();

                    // get info
                    var count = ar.FileCount;
                    _loggerService.Log($"Exporting {count} bundle entries ");

                    Thread.Sleep(1000);
                    int progress = 0;
                    _progressService.Report(0);

                    Parallel.For(0, count, i =>
                    {
                        var (hash, ifileEntry) = ar.Files.ToList()[i];
                        var fileEntry = ifileEntry as FileEntry;
                        var filename = string.IsNullOrEmpty(fileEntry.FileName) ? hash.ToString() : fileEntry.FileName;

                        if (imports)
                        {
                            using var ms = new MemoryStream();
                            ar.CopyFileToStream(ms, fileEntry.NameHash64, false);
                            var cr2w = _wolvenkitFileService.TryReadCr2WFileHeaders(ms);
                            if (cr2w == null)
                            {
                                return;
                            }

                            var obj = new Cr2wChunkInfo
                            {
                                Filename = filename,
                                Imports = cr2w.Imports
                            };

                            fileDictionary.AddOrUpdate(hash, obj, (arg1, o) => obj);
                        }

                        if (texinfo)
                        {
                            if (!string.IsNullOrEmpty(fileEntry.FileName) && fileEntry.FileName.Contains(".xbm"))
                            {
                                using var ms = new MemoryStream();
                                ar.CopyFileToStream(ms, (fileEntry as FileEntry).NameHash64, false);
                                var cr2w = _wolvenkitFileService.TryReadCr2WFile(ms);

                                if (cr2w?.Chunks.FirstOrDefault()?.Data is not CBitmapTexture xbm ||
                                    !(cr2w.Chunks[1]?.Data is rendRenderTextureBlobPC blob))
                                {
                                    return;
                                }

                                // create dds header
                                var texinfoObj = new Cr2wTextureInfo()
                                {
                                    Filename = filename,
                                    width = blob.Header.SizeInfo.Width.IsSerialized ? blob.Header.SizeInfo.Width.Value.ToString() : "null",
                                    height = blob.Header.SizeInfo.Height.IsSerialized ? blob.Header.SizeInfo.Height.Value.ToString() : "null",
                                    mips = blob.Header.TextureInfo.MipCount.IsSerialized ? blob.Header.TextureInfo.MipCount.Value.ToString() : "null",
                                    slicecount = blob.Header.TextureInfo.SliceCount.IsSerialized ? blob.Header.TextureInfo.SliceCount.Value.ToString() : "null",
                                    alignment = blob.Header.TextureInfo.DataAlignment.IsSerialized ? blob.Header.TextureInfo.DataAlignment.Value.ToString() : "null",
                                    compression = xbm.Setup.Compression.IsSerialized ? xbm.Setup.Compression.Value.ToString() : "null",
                                    Group = xbm.Setup.Group.IsSerialized ? xbm.Setup.Group.Value.ToString() : "null",
                                    rawFormat = xbm.Setup.RawFormat.IsSerialized ? xbm.Setup.RawFormat.Value.ToString(): "null",
                                };

                                texDictionary.AddOrUpdate(hash, texinfoObj, (arg1, o) => texinfoObj);
                            }
                        }

                        Interlocked.Increment(ref progress);
                        _progressService.Report(progress / (float)count);
                    });

                    // write
                    var arobj = new ArchiveDumpObject()
                    {
                        Filename = ar.ArchiveAbsolutePath,
                        FileDictionary = fileDictionary,
                        TextureDictionary = texDictionary
                    };

                    if (imports)
                    {
                        using var hwriter = File.CreateText($"{ar.ArchiveAbsolutePath}.hashes.csv");
                        hwriter.WriteLine("String,Hash");
                        List<string> allimports = new List<string>();

                        foreach (var (key, value) in arobj.FileDictionary)
                        {
                            if (value.Imports == null)
                            {
                                continue;
                            }

                            allimports.AddRange(value.Imports.Select(import => import.DepotPathStr));
                        }
                        foreach (var str in allimports.Distinct())
                        {
                            var hash = FNV1A64HashAlgorithm.HashString(str);
                            if (!_hashService.Contains(hash))
                            {
                                hwriter.WriteLine($"{str},{hash}");
                            }
                        }

                        _loggerService.Success($"Finished. Dump file written to {ar.ArchiveAbsolutePath}.");

                        //write
                        File.WriteAllText($"{ar.ArchiveAbsolutePath}.json.",
                            JsonConvert.SerializeObject(arobj, Formatting.Indented, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.None,
                                TypeNameHandling = TypeNameHandling.None
                            }));
                        _loggerService.Success($"Finished. Dump file written to {inputFileInfo.FullName}.json.");
                    }

                    if (texinfo)
                    {
                        //write
                        using var fs = new FileStream($"{ar.ArchiveAbsolutePath}.textures.csv", FileMode.Create,
                            FileAccess.Write);
                        using var sw = new StreamWriter(fs);
                        sw.WriteLine(
                            $"Filename;" +

                            $"compression;" +
                            $"Group;" +
                            $"rawFormat;" +

                            $"alignment;" +
                            $"slicecount;" +
                            $"mips;" +

                            $"height;" +
                            $"width"
                        );

                        foreach (var value in arobj.TextureDictionary.Values)
                        {
                            sw.WriteLine(
                                $"{value.Filename};" +

                                $"{value.compression};" +
                                $"{value.Group};" +
                                $"{value.rawFormat};" +

                                $"{value.alignment};" +
                                $"{value.slicecount};" +
                                $"{value.mips};" +

                                $"{value.height};" +
                                $"{value.width};"
                            );
                        }


                        // File.WriteAllText($"{ar.ArchiveAbsolutePath}.textures.json",
                        //     JsonConvert.SerializeObject(arobj, Formatting.Indented, new JsonSerializerSettings()
                        //     {
                        //         ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        //         PreserveReferencesHandling = PreserveReferencesHandling.None,
                        //         TypeNameHandling = TypeNameHandling.None
                        //     }));
                        _loggerService.Success($"Finished. Dump file written to {ar.ArchiveAbsolutePath}.textures.csv");
                    }
                }

                if (dump)
                {
                    var json = JsonConvert.SerializeObject(ar, Formatting.Indented,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.None,
                            TypeNameHandling = TypeNameHandling.None
                        });

                    File.WriteAllText($"{ar.ArchiveAbsolutePath}.json",json);

                    _loggerService.Success($"Finished dumping {ar.ArchiveAbsolutePath}.");
                }

                if (list)
                {
                    foreach (var entry in ar.Files.Values.Cast<FileEntry>())
                    {
                        _loggerService.Info(entry.FileName);
                    }
                }
            }

            return 1;
        }

        #endregion Methods
    }

    public class ArchiveDumpObject
    {
        #region Properties

        public ConcurrentDictionary<ulong, Cr2wChunkInfo> FileDictionary { get; set; }
        public string Filename { get; set; }
        public ConcurrentDictionary<ulong, Cr2wTextureInfo> TextureDictionary { get; set; }

        #endregion Properties
    }

    public class Cr2wChunkInfo
    {
        #region Properties

        public List<ICR2WBuffer> Buffers { get; set; }
        public List<CR2WExportWrapper.Cr2wVariableDumpObject> ChunkData { get; } = new();
        public List<CR2WExportWrapper> Chunks { get; set; }
        public string Filename { get; set; }
        public List<ICR2WImport> Imports { get; set; }
        public Dictionary<uint, string> Stringdict { get; set; }

        #endregion Properties
    }

    public class Cr2wTextureInfo
    {
        #region Properties

        public string alignment { get; set; }
        public string compression { get; set; }
        public string Filename { get; set; }

        public string Group { get; set; }
        public string height { get; set; }
        public string mips { get; set; }
        public string rawFormat { get; set; }
        public string slicecount { get; set; }
        public string width { get; set; }

        #endregion Properties
    }
}
