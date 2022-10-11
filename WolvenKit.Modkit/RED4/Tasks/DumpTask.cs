using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.Types;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public void DumpTask(string[] path, bool imports, bool missinghashes,
            bool texinfo, bool dump, bool list)
        {
            if (path == null || path.Length < 1)
            {
                _loggerService.Warning("Please fill in an input path.");
                return;
            }

            Parallel.ForEach(path, file => DumpTaskInner(file, imports, missinghashes, texinfo, dump, list));
        }

        public int DumpTaskInner(string path, bool imports, bool missinghashes, bool texinfo, bool dump, bool list)
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


            //fix to force loading all
            _hashService.GetAllHashes();

            var archives = new List<Archive>();

            var outputDir = isDirectory ? inputDirInfo.FullName : inputFileInfo.Directory.FullName;
            if (isDirectory)
            {
                archives.AddRange(inputDirInfo
                    .GetFiles("*.archive", SearchOption.AllDirectories)
                    .Select(_ => _wolvenkitFileService.ReadRed4Archive(_.FullName, _hashService)));
            }
            else
            {
                archives.Add(_wolvenkitFileService.ReadRed4Archive(inputFileInfo.FullName, _hashService));
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
                _loggerService.Info($"Missing: {missing.Count}");
                using (var missingWriter = File.CreateText(missinghashtxt))
                {
                    for (var i = 0; i < missing.Count; i++)
                    {
                        var mh = missing[i];
                        missingWriter.WriteLine(mh);
                        _progressService.Report((i + 1) / (float)missing.Count);
                    }
                }

                var usedhashtxt = isDirectory
                    ? Path.Combine(inputDirInfo.FullName, "usedhashes.txt")
                    : $"{inputFileInfo.FullName}.usedhashes.txt";
                _loggerService.Info($"Used: {used.Count}");
                using (var usedWriter = File.CreateText(usedhashtxt))
                {
                    for (var i = 0; i < used.Count; i++)
                    {
                        var mh = used[i];
                        usedWriter.WriteLine(_hashService.Get(mh));
                        _progressService.Report((i + 1) / (float)used.Count);
                    }
                }

                var allhashes = _hashService.GetAllHashes().ToList();
                var unused = allhashes.Except(used).ToList();

                var unusedhashtxt = isDirectory
                    ? Path.Combine(inputDirInfo.FullName, "unusedhashes.txt")
                    : $"{inputFileInfo.FullName}.unusedhashes.txt";
                _loggerService.Info($"Unused: {unused.Count}");
                using (var unusedWriter = File.CreateText(unusedhashtxt))
                {
                    for (var i = 0; i < unused.Count; i++)
                    {
                        var h = unused[i];

                        unusedWriter.WriteLine(_hashService.Get(h));
                        _progressService.Report((i + 1) / (float)unused.Count);
                    }
                }

                //compress all used and all missing hashes
                _loggerService.Info($"Compressing...");
                OodleTask(new FileInfo(unusedhashtxt), null, false, true);
                OodleTask(new FileInfo(usedhashtxt), null, false, true);

                return 1;
            }

            var missingImports = new List<string>();
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

                    var fileDictionary = new ConcurrentDictionary<ulong, Cr2wChunkInfo>();
                    var texDictionary = new ConcurrentDictionary<ulong, Cr2WTextureInfo>();
                    var importDictionary = new ConcurrentDictionary<ulong, string>();

                    // get info
                    var count = ar.FileCount;
                    _loggerService.Info($"Exporting {count} bundle entries ");

                    Thread.Sleep(1000);
                    var progress = 0;
                    _progressService.Report(0);

                    // process files
                    Parallel.For(0, count, i =>
                    {
                        var (hash, ifileEntry) = ar.Files.ToList()[i];
                        var fileEntry = ifileEntry as FileEntry;
                        var filename = string.IsNullOrEmpty(fileEntry.FileName) ? hash.ToString() : fileEntry.FileName;

                        if (imports)
                        {
                            using var ms = new MemoryStream();
                            ar.CopyFileToStream(ms, fileEntry.NameHash64, false);
                            if (!_wolvenkitFileService.TryReadRed4File(ms, out var cr2w))
                            {
                                return;
                            }

                            var imports = cr2w.GetImports();
                            if (imports.Count > 0)
                            {
                                foreach (var import in imports)
                                {
                                    if (!_hashService.Contains(import.GetRedHash()))
                                    {
                                        importDictionary.AddOrUpdate(import.GetRedHash(), import, (arg1, o) => import);
                                    }
                                }
                            }
                        }

                        if (texinfo)
                        {
                            if (!string.IsNullOrEmpty(fileEntry.FileName) && fileEntry.FileName.Contains(".xbm"))
                            {
                                using var ms = new MemoryStream();
                                ar.CopyFileToStream(ms, fileEntry.NameHash64, false);
                                var cr2w = _wolvenkitFileService.ReadRed4File(ms);
                                if (cr2w == null || cr2w.RootChunk is not CBitmapTexture xbm || xbm.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendIRenderTextureBlob blob)
                                {
                                    return;
                                }

                                // create dds header
                                var texinfoObj = new Cr2WTextureInfo()
                                {
                                    Filename = filename,
                                    Width = blob.Header.SizeInfo.Width.ToString(),
                                    Height = blob.Header.SizeInfo.Height.ToString(),
                                    Mips = blob.Header.TextureInfo.MipCount.ToString(),
                                    Slicecount = blob.Header.TextureInfo.SliceCount.ToString(),
                                    Alignment = blob.Header.TextureInfo.DataAlignment.ToString(),
                                    Compression = xbm.Setup.Compression.ToString(),
                                    Group = xbm.Setup.Group.ToString(),
                                    RawFormat = xbm.Setup.RawFormat.ToString()
                                };

                                texDictionary.AddOrUpdate(hash, texinfoObj, (arg1, o) => texinfoObj);
                            }
                        }

                        Interlocked.Increment(ref progress);
                        _progressService.Report(progress / (float)count);
                    });

                    // write
                    if (texinfo)
                    {
                        var arobj = new ArchiveDumpObject()
                        {
                            Filename = ar.ArchiveAbsolutePath,
                            FileDictionary = fileDictionary,
                            TextureDictionary = texDictionary
                        };

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

                                $"{value.Compression};" +
                                $"{value.Group};" +
                                $"{value.RawFormat};" +

                                $"{value.Alignment};" +
                                $"{value.Slicecount};" +
                                $"{value.Mips};" +

                                $"{value.Height};" +
                                $"{value.Width};"
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

                    if (imports)
                    {
                        if (!importDictionary.IsEmpty)
                        {
                            _loggerService.Success($"Found {importDictionary.Count} new imports in {ar.ArchiveAbsolutePath}.");
                            missingImports.AddRange(importDictionary.Values);
                        }
                        else
                        {
                            _loggerService.Info($"No new imports in {ar.ArchiveAbsolutePath}.");
                        }
                    }
                }

                // post
                if (dump)
                {
                    var json = JsonSerializer.Serialize(ar, new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        ReferenceHandler = ReferenceHandler.IgnoreCycles
                    });

                    File.WriteAllText($"{ar.ArchiveAbsolutePath}.json", json);

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

            if (imports)
            {
                using var hwriter = File.CreateText(Path.Combine(outputDir, "missing_imports.txt"));
                foreach (var str in missingImports)
                {
                    hwriter.WriteLine($"{str},{FNV1A64HashAlgorithm.HashString(str)}");
                }

                _loggerService.Success($"Finished. Dump file written to {Path.Combine(outputDir, "missing_imports.txt")}.");

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
        public ConcurrentDictionary<ulong, Cr2WTextureInfo> TextureDictionary { get; set; }

        #endregion Properties
    }

    public class Cr2wChunkInfo
    {
        #region Properties

        public List<ICR2WBuffer> Buffers { get; set; }
        //public List<CR2WExportWrapper.Cr2wVariableDumpObject> ChunkData { get; } = new();
        //public List<CR2WExportWrapper> Chunks { get; set; }
        //public string Filename { get; set; }
        public List<ICR2WImport> Imports { get; set; }
        public Dictionary<uint, string> Stringdict { get; set; }

        #endregion Properties
    }

    public class Cr2WTextureInfo
    {
        #region Properties

        public string Alignment { get; set; }
        public string Compression { get; set; }
        public string Filename { get; set; }

        public string Group { get; set; }
        public string Height { get; set; }
        public string Mips { get; set; }
        public string RawFormat { get; set; }
        public string Slicecount { get; set; }
        public string Width { get; set; }

        #endregion Properties
    }
}
