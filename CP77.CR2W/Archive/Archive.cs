using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Tools;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Extensions;
using CP77Tools.Model;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Services;
using WolvenKit.Common.Tools.DDS;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace CP77.CR2W.Archive
{
    public class Archive
    {
        #region fields

        [JsonProperty]
        private ArHeader _header;
        [JsonProperty]
        private ArTable _table;

        private string Mmfhash => Filepath.GetHashMD5();

        #endregion

        #region constructors

        public Archive()
        {
            
        }

        /// <summary>
        /// Creates and reads an archive from a path
        /// </summary>
        /// <param name="path"></param>
        public Archive(string path)
        {
            Filepath = path;
            
            ReadTables();
        }

        #endregion

        #region properties

        public string Filepath { get; }

        [JsonIgnore]
        public Dictionary<ulong, ArchiveItem> Files => _table?.FileInfo;

        public int FileCount => Files?.Count ?? 0;

        [JsonIgnore]
        public string Name => Path.GetFileName(Filepath);
        #endregion

        #region methods

        /// <summary>
        /// Reads the tables info to the archive.
        /// </summary>
        private void ReadTables()
        {
            using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            using (var vs = mmf.CreateViewStream(0, ArHeader.SIZE, MemoryMappedFileAccess.Read))
            {
                _header = new ArHeader(new BinaryReader(vs));
            }

            using (var vs = mmf.CreateViewStream((long)_header.Tableoffset, (long)_header.Tablesize,
                MemoryMappedFileAccess.Read))
            {
                _table = new ArTable(new BinaryReader(vs), this);
            }
        }

        /// <summary>
        /// Creates and archive from a folder and packs all files inside into it
        /// </summary>
        /// <param name="infolder"></param>
        /// <returns></returns>
        public static Archive CreateFromFolder(DirectoryInfo infolder)
        {
            if (!infolder.Exists) return null;

            var ar = new Archive();

            // we use this to get all buffers
            // TODO: fix that for textures (pack from .tga and not .buffer)? probably in an intermediary step
            var buffersDict = new ConcurrentDictionary<ulong, List<FileInfo>>();
            var allfiles = infolder.GetFiles("*", SearchOption.AllDirectories);
            var buffersList = allfiles.Where(_ => _.Extension == ".buffer");
            var parentfiles = allfiles.Where(_ => _.Extension != ".buffer");
            Parallel.ForEach(buffersList, fileInfo =>
            {

                // buffer path e.g. stand__rh_hold_tray__serve_milkshakes__01.scenerid.7.buffer
                // removes 7 characters (".buffer") and then removes the extension (".7")
                var relpath = fileInfo.FullName.Substring(infolder.FullName.Length + 1);
                var bufferParentfile = Path.GetFileNameWithoutExtension(relpath.Remove(relpath.Length - 7));
                var hash = FNV1A64HashAlgorithm.HashString(bufferParentfile);

                // add buffer
                if (!buffersDict.ContainsKey(hash))
                    buffersDict.AddOrUpdate(hash, new List<FileInfo>(), (arg1, o) => new List<FileInfo>());
                buffersDict[hash].Add(fileInfo);
            });

            // all parentfiles
            Parallel.ForEach(parentfiles, fileInfo =>
            {
                var relpath = fileInfo.FullName.Substring(infolder.FullName.Length + 1);
                var hash = FNV1A64HashAlgorithm.HashString(relpath);

                // get buffers
                var buffers = new List<FileInfo>();
                if (buffersDict.ContainsKey(hash))
                {
                    buffers = buffersDict[hash];
                }



                var item = new ArchiveItem(ar)
                {
                    NameHash64 = hash,
                    DateTime = DateTime.Now,
                    FileFlags = 0, //TODO
                    FirstOffsetTableIdx = 0,
                    LastOffsetTableIdx = 0,
                    FirstImportTableIdx = 0,
                    LastImportTableIdx = 0,
                    SHA1Hash = new byte[20]
                };

            });




            return ar;
        }

        /// <summary>
        /// Serializes this archive to a redengine .archive file
        /// </summary>
        public void Serialize()
        {




        }


        /// <summary>
        /// Uncooks a single file by hash.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="uncookext"></param>
        /// <returns></returns>
        public int UncookSingle(ulong hash, DirectoryInfo outDir, EUncookExtension uncookext = EUncookExtension.tga)
        {
            using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            return UncookSingleInner(mmf, hash, outDir, uncookext);
        }

        /// <summary>
        /// Extracts a single file + buffers.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <returns></returns>
        public int ExtractSingle(ulong hash, DirectoryInfo outDir)
        {
            using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            return ExtractSingleInner(mmf, hash, outDir);
        }
        
        private int UncookSingleInner(MemoryMappedFile mmf, ulong hash, DirectoryInfo outDir, EUncookExtension uncookext = EUncookExtension.tga)
        {
            var uncooksuccess = false;
            var (file, buffers) = GetFileData(hash, mmf);

            if (!Files.ContainsKey(hash))
                return -1;
            string name = Files[hash].NameStr;

            // checks
            var outfile = new FileInfo(Path.Combine(outDir.FullName,
                $"{name}"));
            if (outfile.Directory == null)
                return -1;
            if (buffers.Count > 1)
                return -1; //TODO: can that happen?

            var cr2w = new CR2WFile();
            using var ms = new MemoryStream(file);
            using var br = new BinaryReader(ms);
            cr2w.ReadImportsAndBuffers(br);
            if (cr2w.StringDictionary[1] != "CBitmapTexture")
                return -1;

            br.BaseStream.Seek(0, SeekOrigin.Begin);
            var result = cr2w.Read(br);
            if (result != EFileReadErrorCodes.NoError)
                return -1;
            if (!(cr2w.Chunks.FirstOrDefault()?.data is CBitmapTexture xbm) ||
                !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
                return -1;

            // write buffers
            foreach (var b in buffers)
            {
                #region textures
                // create dds header
                var newpath = Path.ChangeExtension(outfile.FullName, "dds");
                try
                {
                    var width = blob.Header.SizeInfo.Width.val;
                    var height = blob.Header.SizeInfo.Height.val;
                    var mips = blob.Header.TextureInfo.MipCount.val;
                    var slicecount = blob.Header.TextureInfo.SliceCount.val;
                    var alignment = blob.Header.TextureInfo.DataAlignment.val;

                    Enums.ETextureRawFormat rawfmt = Enums.ETextureRawFormat.TRF_Invalid;
                    if (xbm.Setup.RawFormat?.WrappedEnum != null)
                        rawfmt = xbm.Setup.RawFormat.WrappedEnum;
                    else
                    {
                    }

                    Enums.ETextureCompression compression = Enums.ETextureCompression.TCM_None;
                    if (xbm.Setup.Compression?.WrappedEnum != null)
                        compression = xbm.Setup.Compression.WrappedEnum;
                    else
                    {
                    }

                    var texformat = CommonFunctions.GetDXGIFormatFromXBM(compression, rawfmt);

                    Directory.CreateDirectory(outfile.Directory.FullName);
                    using (var stream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write))
                    {
                        DDSUtils.GenerateAndWriteHeader(stream,
                            new DDSMetadata(width, height, mips, texformat, alignment, false, slicecount, true));
                        var buffer = b;
                        stream.Write(buffer);

                    }

                    // success
                    uncooksuccess = true;
                }
                catch
                {
                    uncooksuccess = false;
                    continue;
                }

                // convert to texture
                if (uncookext != EUncookExtension.dds)
                {
                    try
                    {
                        var di = new FileInfo(outfile.FullName).Directory;
                        TexconvWrapper.Convert(di.FullName, $"{newpath}", uncookext);
                    }
                    catch (Exception e)
                    {
                        // silent
                    }
                }

                #endregion
            }

            return uncooksuccess ? 1 : 0;
        }

        private int ExtractSingleInner(MemoryMappedFile mmf, ulong hash, DirectoryInfo outDir)
        {
            var extractsuccess = false;
            var (file, buffers) = GetFileData(hash, mmf);

            if (!Files.ContainsKey(hash))
                return -1;
            string name = Files[hash].NameStr;
            if (string.IsNullOrEmpty(Path.GetExtension(name)))
            {
                name += ".bin";
            }

            var outfile = new FileInfo(Path.Combine(outDir.FullName,
                $"{name}"));
            if (outfile.Directory == null)
                return -1;

            // write main file
            Directory.CreateDirectory(outfile.Directory.FullName);
            File.WriteAllBytes(outfile.FullName, file);
            extractsuccess = true;

            // write buffers
            for (int j = 0; j < buffers.Count; j++)
            {
                var buffer = buffers[j];
                var bufferpath = $"{outfile}.{j}.buffer";
                Directory.CreateDirectory(outfile.Directory.FullName);
                File.WriteAllBytes(bufferpath, buffer);
                extractsuccess = true;
            }

            return extractsuccess ? 1 : 0;
        }

        /// <summary>
        /// Extracts all Files to the specified directory.
        /// </summary>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public (List<string>, int) ExtractAll(DirectoryInfo outDir, string pattern = "", string regex = "")
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            int progress = 0;
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            Console.Write($"Exporting {FileCount} bundle entries ");

            // check search pattern then regex
            IEnumerable<ArchiveItem> finalmatches = Files.Values;
            if (!string.IsNullOrEmpty(pattern))
                finalmatches = Files.Values.MatchesWildcard(item => item.NameStr, pattern);
            if (!string.IsNullOrEmpty(regex))
            {
                var searchTerm = new System.Text.RegularExpressions.Regex($@"{regex}");
                var queryMatchingFiles =
                    from file in finalmatches
                    let matches = searchTerm.Matches(file.NameStr)
                    where matches.Count > 0
                    select file;
                    
                finalmatches = queryMatchingFiles;
            }

            Thread.Sleep(1000);
            logger.LogProgress(0);

            Parallel.ForEach(finalmatches, info =>
            {
                int extracted = ExtractSingleInner(mmf, info.NameHash64, outDir);

                if (extracted != 0)
                    extractedList.Add(info.NameStr);
                else
                    failedList.Add(info.NameStr);

                Interlocked.Increment(ref progress);
                logger.LogProgress(progress / (float)FileCount);
            });

            return (extractedList.ToList(), FileCount);
        }

        /// <summary>
        /// Uncooks all Files to the specified directory.
        /// </summary>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <param name="uncookext"></param>
        /// <returns></returns>
        public (List<string>, int) UncookAll(DirectoryInfo outDir, string pattern = "", string regex = "", EUncookExtension uncookext = EUncookExtension.tga)
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            int progress = 0;
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();
            int all = 0;

            using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            Console.Write($"Uncooking {FileCount} bundle entries ");

            // check search pattern then regex
            IEnumerable<ArchiveItem> finalmatches = Files.Values;
            if (!string.IsNullOrEmpty(pattern))
                finalmatches = Files.Values.MatchesWildcard(item => item.NameStr, pattern);
            if (!string.IsNullOrEmpty(regex))
            {
                var searchTerm = new System.Text.RegularExpressions.Regex($@"{regex}");
                var queryMatchingFiles =
                    from file in finalmatches
                    let matches = searchTerm.Matches(file.NameStr)
                    where matches.Count > 0
                    select file;

                finalmatches = queryMatchingFiles;
            }

            Thread.Sleep(1000);
            logger.LogProgress(0);

            Parallel.ForEach(finalmatches, info =>
            {
                if (CanUncook(info.NameHash64))
                {
                    Interlocked.Increment(ref all);
                    int uncooked = UncookSingleInner(mmf, info.NameHash64, outDir, uncookext);

                    if (uncooked != 0)
                        extractedList.Add(info.NameStr);
                    else
                        failedList.Add(info.NameStr);
                }
                Interlocked.Increment(ref progress);
                logger.LogProgress(progress / (float)FileCount);
            });

            
            return (extractedList.ToList(), all);
        }

        private bool CanUncook(ulong hash)
        {
            if (!Files.ContainsKey(hash))
                return false;
            string name = Files[hash].NameStr;

            return (Path.GetExtension(name) == ".xbm" || Path.GetExtension(name) == ".bin"); //TODO: remove when all filenames found
        }

        /// <summary>
        /// Gets the bytes of one file by index from the archive.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="mmf"></param>
        /// <returns></returns>
        public (byte[], List<byte[]>) GetFileData(ulong hash, MemoryMappedFile mmf)
        {
            if (!Files.ContainsKey(hash)) return (null, null);

            var entry = Files[hash];
            var startindex = (int)entry.FirstOffsetTableIdx;
            var nextindex = (int)entry.LastOffsetTableIdx;

            var file = ExtractFile(this._table.Offsets[startindex]);
            var buffers = new List<byte[]>();

            for (int j = startindex + 1; j < nextindex; j++)
            {
                var offsetentry = this._table.Offsets[j];
                var buffer = ExtractFile(offsetentry);
                buffers.Add(buffer);
            }

            return (file, buffers);

            // local
            byte[] ExtractFile(OffsetEntry offsetentry)
            {
                using var ms = new MemoryStream();
                using var bw = new BinaryWriter(ms);

                using var vs = mmf.CreateViewStream((long)offsetentry.Offset, (long)offsetentry.ZSize,
                    MemoryMappedFileAccess.Read);
                using var binaryReader = new BinaryReader(vs);

                if (offsetentry.ZSize == offsetentry.Size)
                {
                    var buffer = binaryReader.ReadBytes((int)offsetentry.ZSize);
                    bw.Write(buffer);
                }
                else
                {
                    var oodleCompression = binaryReader.ReadBytes(4);
                    if ((oodleCompression.SequenceEqual(new byte[] {0x4b, 0x41, 0x52, 0x4b})))
                    {
                        var size = binaryReader.ReadUInt32();

                        if (size != offsetentry.Size)
                            throw new NotImplementedException();

                        var buffer = binaryReader.ReadBytes((int)offsetentry.ZSize - 8);

                        byte[] unpacked = new byte[offsetentry.Size];
                        long unpackedSize = OodleLZ.Decompress(buffer, unpacked);

                        if (unpackedSize != offsetentry.Size)
                            throw new Exception(
                                $"Unpacked size doesn't match real size. {unpackedSize} vs {offsetentry.Size}");
                        bw.Write(unpacked);
                    }
                    else
                    {
                        binaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                        var buffer = binaryReader.ReadBytes((int)offsetentry.ZSize);
                        bw.Write(buffer);
                    }
                }

                return ms.ToArray();
            }
        }

        

        #endregion
    }

    
}



