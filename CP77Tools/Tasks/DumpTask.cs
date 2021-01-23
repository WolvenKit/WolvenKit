using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
//using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W.Archive;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using CP77.CR2W;
using CP77.CR2W.Reflection;
using CP77.CR2W.Types;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;

namespace CP77Tools.Tasks
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
        private static byte[] MAGIC = {0x43, 0x52, 0x32, 0x57};

        public static void DumpTask(string[] path, bool imports, bool missinghashes, 
            bool texinfo, bool classinfo, bool dump, bool list)
        {
            if (path == null || path.Length < 1)
            {
                logger.LogString("Please fill in an input path", Logtype.Error);
                return;
            }

            Parallel.ForEach(path, file =>
            {
                DumpTaskInner(file, imports, missinghashes, texinfo, classinfo, dump, list);
            });

        }

        public static int DumpTaskInner(string path, bool imports, bool missinghashes, 
            bool texinfo, bool classinfo, bool dump, bool list)
        {
            #region checks

            if (string.IsNullOrEmpty(path))
            {
                ConsoleFunctions.logger.LogString("Please fill in an input path",Logtype.Error);
                return 0;
            }

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
            #endregion
            
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

            

            var mainController = ServiceLocator.Default.ResolveType<IHashService>();
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            var typedict = new ConcurrentDictionary<string, IEnumerable<string>>();

            // Parallel
            foreach (var ar in archives)
            {
                if (classinfo)
                {
                    // using var mmf = MemoryMappedFile.CreateFromFile(ar.Filepath, FileMode.Open,
                    //     ar.Filepath.GetHashMD5(), 0,
                    //     MemoryMappedFileAccess.Read);

                    var fileinfo = ar.Files.Values;
                    var query = fileinfo.GroupBy(
                        ext => Path.GetExtension(ext.FileName),
                        file => file,
                        (ext, finfo) => new
                        {
                            Key = ext,
                            File = fileinfo.Where(_ => Path.GetExtension(_.FileName) == ext)
                        }).ToList();



                    var total = query.Count;
                    logger.LogString($"Exporting {total} bundle entries ");

                    Thread.Sleep(1000);
                    int progress = 0;
                    logger.LogProgress(0);

                    // foreach extension
                    Parallel.ForEach(query, result =>
                    {
                        if (!string.IsNullOrEmpty(result.Key))
                        {
                            Parallel.ForEach(result.File, fi =>
                            {
                                var (f, b) = ar.GetFileData(fi.NameHash64, false);
                                using var ms = new MemoryStream(f);
                                using var br = new BinaryReader(ms);

                                var cr2w = new CR2WFile();
                                try
                                {
                                    cr2w.ReadImportsAndBuffers(br);
                                }
                                catch (Exception e)
                                {
                                    return;
                                }
                                
                                foreach (var chunk in cr2w.Chunks)
                                {
                                    var o = chunk.GetDumpObject(br);
                                    if (o != null) Register(o);
                                }
                            });
                        }
                        
                        Interlocked.Increment(ref progress);
                        logger.LogProgress(progress / (float)total);

                        logger.LogString($"Dumped extension {result.Key}", Logtype.Normal);
                    });


                }
                if (imports || texinfo)
                {
                    // using var mmf = MemoryMappedFile.CreateFromFile(ar.Filepath, FileMode.Open,
                    //     ar.Filepath.GetHashMD5(), 0,
                    //     MemoryMappedFileAccess.Read);

                    var fileDictionary = new ConcurrentDictionary<ulong, Cr2wChunkInfo>();
                    var texDictionary = new ConcurrentDictionary<ulong, Cr2wTextureInfo>();

                    // get info
                    var count = ar.FileCount;
                    logger.LogString($"Exporting {count} bundle entries ");

                    Thread.Sleep(1000);
                    int progress = 0;
                    logger.LogProgress(0);

                    Parallel.For(0, count, i =>
                    {
                        var entry = ar.Files.ToList()[i];
                        var hash = entry.Key;
                        var filename = string.IsNullOrEmpty(entry.Value.FileName) ? hash.ToString() : entry.Value.FileName;

                        if (imports)
                        {
                            var (f, buffers) = ar.GetFileData(hash, false);

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

                        if (texinfo)
                        {
                            if (!string.IsNullOrEmpty(entry.Value.FileName) && entry.Value.FileName.Contains(".xbm"))
                            {
                                var (f, buffers) = ar.GetFileData(hash, false);

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

                        Interlocked.Increment(ref progress);
                        logger.LogProgress(progress / (float)count);
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
                                continue;
                            allimports.AddRange(value.Imports.Select(import => import.DepotPathStr));
                        }
                        foreach (var str in allimports.Distinct())
                        {
                            var hash = FNV1A64HashAlgorithm.HashString(str);
                            if (!mainController.Hashdict.ContainsKey(hash))
                                hwriter.WriteLine($"{str},{hash}");
                        }

                        logger.LogString($"Finished. Dump file written to {ar.ArchiveAbsolutePath}.", Logtype.Success);

                        //write
                        File.WriteAllText($"{ar.ArchiveAbsolutePath}.json",
                            JsonConvert.SerializeObject(arobj, Formatting.Indented, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.None,
                                TypeNameHandling = TypeNameHandling.None
                            }));
                        logger.LogString($"Finished. Dump file written to {inputFileInfo.FullName}.json", Logtype.Success);

                    }

                    if (texinfo)
                    {
                        //write
                        File.WriteAllText($"{ar.ArchiveAbsolutePath}.textures.json",
                            JsonConvert.SerializeObject(arobj, Formatting.Indented, new JsonSerializerSettings()
                            {
                                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                                PreserveReferencesHandling = PreserveReferencesHandling.None,
                                TypeNameHandling = TypeNameHandling.None
                            }));
                        logger.LogString($"Finished. Dump file written to {inputFileInfo.FullName}.json", Logtype.Success);
                    }
                }
                
                // TODO: add this here
                if (dump)
                {
                    File.WriteAllText($"{ar.ArchiveAbsolutePath}.json",
                        JsonConvert.SerializeObject(ar, Formatting.Indented, new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                            PreserveReferencesHandling = PreserveReferencesHandling.None,
                            TypeNameHandling = TypeNameHandling.None
                        }));

                    logger.LogString($"Finished dumping {ar.ArchiveAbsolutePath}.", Logtype.Success);
                }

                if (list)
                {
                    foreach (var entry in ar.Files)
                    {
                        logger.LogString(entry.Value.FileName, Logtype.Normal);
                    }
                }
            }

            if (classinfo)
            {
                //write class definitions
                var outdir = isDirectory
                ? Path.Combine(inputDirInfo.FullName, "ClassDefinitions")
                : Path.Combine(inputFileInfo.Directory.FullName, "ClassDefinitions");
                Directory.CreateDirectory(outdir);
                var outfile = Path.Combine(outdir, "classdefinitions.txt");
                var outfileS = Path.Combine(outdir, "classdefinitions_simple.json");
                var text = "";
                foreach (var (typename, variables) in typedict)
                {
                    //write
                    var sb = new StringBuilder($"[REDMeta] public class {typename} : CVariable {{\r\n");

                    var variableslist = variables.ToList();
                    for (int i = 0; i < variableslist.Count; i++)
                    {
                        var typ = variableslist[i].Split(' ').First();
                        var nam = variableslist[i].Split(' ').Last();
                        var wktype = REDReflection.GetWKitBaseTypeFromREDBaseType(typ);

                        if (string.IsNullOrEmpty(nam)) nam = "Missing";
                        if (string.IsNullOrEmpty(typ)) typ = "Missing";


                        sb.Append($"\t[Ordinal({i})]  [RED(\"{nam}\")] public {wktype} {nam.FirstCharToUpper()} {{ get; set; }}\r\n");
                    }

                    sb.Append(
                        $"public {typename}(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) {{ }}\r\n");

                    sb.Append("}\r\n");
                    text += sb.ToString();
                }
                File.WriteAllText(outfile, text);

                //write
                File.WriteAllText(outfileS,
                    JsonConvert.SerializeObject(typedict, Formatting.Indented, new JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.None,
                        TypeNameHandling = TypeNameHandling.None
                    }));

                logger.LogString("Done.", Logtype.Success);
            }
            if (missinghashes)
            {
                var missinghashtxt = isDirectory
                    ? Path.Combine(inputDirInfo.FullName, "missinghashes.txt")
                    : $"{inputFileInfo.FullName}.missinghashes.txt";
                using var mwriter = File.CreateText(missinghashtxt);
                foreach (var ar in archives)
                {
                    var ctr = 0;
                    foreach (var (hash, fileInfoEntry) in ar.Files)
                    {
                        if (fileInfoEntry.NameOrHash == hash.ToString())
                        {
                            mwriter.WriteLine(hash);
                            ctr++;
                        }
                    }
                    logger.LogString($"{ar.ArchiveAbsolutePath} - missing: {ctr}", Logtype.Normal);
                }
            }


            return 1;

            void Register(CR2WExportWrapper.Cr2wVariableDumpObject o)
            {
                if (o?.Type == null) return;

                o.Variables ??= new List<CR2WExportWrapper.Cr2wVariableDumpObject>();

                IEnumerable<string> vars = o.Variables.Select(_ => _.ToSimpleString());
                if (typedict.ContainsKey(o.Type))
                {
                    var existing = typedict[o.Type];
                    var newlist = o.Variables.Select(_ => _.ToSimpleString());
                    if (existing != null) vars = existing.Union(newlist);
                }
                typedict.AddOrUpdate(o.Type, vars, (arg1, ol) => ol);

                foreach (var oVariable in o.Variables)
                {
                    // generic types (arrays, handles, refs)
                    if (oVariable.Type != null && oVariable.Type.Contains(":"))
                    {
                        var gentyp = oVariable.Type.Split(":").First();
                        var innertype = oVariable.Type.Substring(gentyp.Length + 1);
                        var innertype2 = oVariable.Type[(gentyp.Length + 1)];
                        if (gentyp == "array")
                        {
                            oVariable.Type = innertype;
                            Register(oVariable);
                        }
                        else
                        {
                            continue;
                        }

                        
                    }

                    Register(oVariable);
                }
            }

        }
    }
}

