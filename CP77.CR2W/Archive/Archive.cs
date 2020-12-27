using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
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
using WolvenKit.CR2W.SRT;
using WolvenKit.CR2W.Types;
using StreamExtensions = Catel.IO.StreamExtensions;

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
            _header = new ArHeader();
            _table = new ArTable();
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

        public string Filepath { get; private init; }

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
        /// <param name="outpath"></param>
        /// <returns></returns>
        public static Archive WriteFromFolder(DirectoryInfo infolder, DirectoryInfo outpath)
        {
            if (!infolder.Exists) return null;
            if (!outpath.Exists) return null;

            var outfile = Path.Combine(outpath.FullName, "basegame_blob0.archive");

            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            var ar = new Archive
            {
                Filepath = outfile,
                _table = new ArTable()
            };
            using var fs = new FileStream(outfile, FileMode.Create);
            using var bw = new BinaryWriter(fs);

            // write header to allocate bytes
            ar._header.Write(bw);
            bw.Write(new byte[132]); // some weird padding

            // get all buffer paths beforehand
            #region buffers pre-locate

            // TODO: fix that for textures (pack from .tga and not .buffer)? probably in an intermediary step
            var buffersDict = new ConcurrentDictionary<ulong, List<FileInfo>>();
            var allfiles = infolder.GetFiles("*", SearchOption.AllDirectories);
            var buffersList = allfiles.Where(_ => _.Extension == ".buffer");
            Parallel.ForEach(buffersList, fileInfo =>
            {
                // buffer path e.g. stand__rh_hold_tray__serve_milkshakes__01.scenerid.7.buffer
                // removes 7 characters (".buffer") and then removes the extension (".7")
                var relpath = fileInfo.FullName[(infolder.FullName.Length + 1)..];
                relpath = Path.ChangeExtension(relpath.Remove(relpath.Length - 7), "").TrimEnd('.');
                var hash = FNV1A64HashAlgorithm.HashString(relpath);

                // add buffer
                if (!buffersDict.ContainsKey(hash))
                    buffersDict.AddOrUpdate(hash, new List<FileInfo>(), (arg1, o) => new List<FileInfo>());
                buffersDict[hash].Add(fileInfo);
            });

            #endregion

            // all parentfiles. don't multitherad this bc the file order matters?
            #region write files

            Thread.Sleep(1000);
            int progress = 0;
            logger.LogProgress(0);

            var parentfiles = allfiles.Where(_ => _.Extension != ".buffer");
            //Parallel.ForEach(parentfiles, fileInfo =>
            var fileInfos = parentfiles
                .OrderBy(_ => FNV1A64HashAlgorithm.HashString(GetRelpath(_)))
                .ToList();

            // local
            string GetRelpath(FileInfo infi) => infi.FullName[(infolder.FullName.Length + 1)..];

            foreach (var fileInfo in fileInfos)
            {
                var relpath = GetRelpath(fileInfo);
                var hash = FNV1A64HashAlgorithm.HashString(relpath);

                if (fileInfo.Extension == ".bin")
                    hash = ulong.Parse(Path.GetFileNameWithoutExtension(relpath));

                // read the cr2w and get imports
                using var cr2wfs = new FileStream(fileInfo.FullName, FileMode.Open);
                using var cr2wbr = new BinaryReader(cr2wfs);

                // peak if cr2w
                var magic = cr2wbr.ReadUInt32();
                var isCr2wFile = magic == CR2WFile.MAGIC;
                cr2wbr.BaseStream.Seek(0, SeekOrigin.Begin);

                var cr2w = new CR2WFile();
                if (isCr2wFile)
                {
                    try
                    {
                        cr2w.ReadImportsAndBuffers(cr2wbr);
                    }
                    catch (Exception e)
                    {
                        logger.LogString($"Failed to read cr2w file {fileInfo.FullName}", Logtype.Error);
                        continue;
                    }
                }
                else
                {

                }
                
                //register imports
                uint firstimportidx = (uint)ar._table.Dependencies.Count;

                foreach (var cr2WImportWrapper in cr2w.Imports)
                {
                    if (!ar._table.Dependencies.Select(_ => _.HashStr).Contains(cr2WImportWrapper.DepotPathStr))
                        ar._table.Dependencies.Add(
                            new HashEntry(FNV1A64HashAlgorithm.HashString(cr2WImportWrapper.DepotPathStr)));
                }
                uint lastimportidx = (uint)ar._table.Dependencies.Count;

                // kraken the file and write
                var cr2winbuffer = StreamExtensions.ToByteArray(cr2wbr.BaseStream);
                CompressAndWrite(cr2winbuffer);


                // foreach buffer: kraken and write
                // get buffers
                var buffers = new List<FileInfo>();
                if (buffersDict.ContainsKey(hash))
                    buffers = buffersDict[hash]
                        .OrderBy(x => x.FullName.Length)
                        .ThenBy(x => x.FullName)
                        .ToList();
                uint firstoffsetidx = (uint)ar._table.Offsets.Count - 1;
                foreach (var inputbuffer in buffers.Select(b => File.ReadAllBytes(b.FullName)))
                {
                    CompressAndWrite(inputbuffer);
                }

                uint lastoffsetidx = (uint)ar._table.Offsets.Count;

                // save table data
                var sha1 = new System.Security.Cryptography.SHA1Managed();
                var sha1hash = sha1.ComputeHash(StreamExtensions.ToByteArray(cr2wbr.BaseStream)); //TODO: this is only correct for files with no buffer
                var flags = buffers.Count > 0 ? (uint)buffers.Count - 1 : 0;
                var item = new ArchiveItem(hash, DateTime.Now, flags
                    , firstoffsetidx, lastoffsetidx, firstimportidx, lastimportidx
                    , sha1hash);
                ar._table.FileInfo.Add(hash, item);

                Interlocked.Increment(ref progress);
                logger.LogProgress(progress / (float)fileInfos.Count);
            };

            #endregion

            // padding to page (4096 bytes)
            bw.PadUntilPage();

            // write tables
            var tableoffset = bw.BaseStream.Position;
            ar._table.Write(bw);
            var tablesize = bw.BaseStream.Position - tableoffset;

            // padding to page (4096 bytes)
            bw.PadUntilPage();
            var filesize = bw.BaseStream.Position;

            // write the header again
            ar._header.Tableoffset = (ulong)tableoffset;
            ar._header.Tablesize = (uint)tablesize;
            ar._header.Filesize = (ulong)filesize;
            bw.BaseStream.Seek(0, SeekOrigin.Begin);
            ar._header.Write(bw);

            return ar;


            int CompressAndWrite(byte[] inbuffer)
            {
                var size = (uint)inbuffer.Length;
                if (size < 255)
                {
                    ar._table.Offsets.Add(new OffsetEntry(
                        (ulong)bw.BaseStream.Position,
                        size,
                        size));
                    bw.Write(inbuffer);
                }
                else
                {
                    var zsize = OodleHelper.GetCompressedBufferSizeNeeded((int)size);
                    var outBuffer = new byte[zsize];

                    var r = OodleHelper.Compress(
                        inbuffer, 0,
                        (int)size,
                        outBuffer,
                        0,
                        zsize);
                    if (r != zsize)
                    {
                        //Debugger.Break();
                    }

                    //resize buffer
                    var writelist = new List<byte>()
                    {
                        0x4B, 0x41, 0x52, 0x4B  //KRAKEN, TODO: make this variable and dependent on the compression algo
                    };
                    writelist.AddRange(BitConverter.GetBytes(size));
                    writelist.AddRange(outBuffer.Take(r));

                    ar._table.Offsets.Add(new OffsetEntry(
                        (ulong)bw.BaseStream.Position,
                        (uint)r + 8,
                        size));
                    bw.Write(writelist.ToArray());
                }

                return 1;
            }
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
            string name = Files[hash].FileName;

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
            string name = Files[hash].FileName;
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


            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            Console.Write($"Exporting {FileCount} bundle entries ");

            // check search pattern then regex
            IEnumerable<ArchiveItem> finalmatches = Files.Values;
            if (!string.IsNullOrEmpty(pattern))
                finalmatches = Files.Values.MatchesWildcard(item => item.FileName, pattern);
            if (!string.IsNullOrEmpty(regex))
            {
                var searchTerm = new System.Text.RegularExpressions.Regex($@"{regex}");
                var queryMatchingFiles =
                    from file in finalmatches
                    let matches = searchTerm.Matches(file.FileName)
                    where matches.Count > 0
                    select file;

                finalmatches = queryMatchingFiles;
            }

            Thread.Sleep(1000);
            int progress = 0;
            logger.LogProgress(0);

            Parallel.ForEach(finalmatches, info =>
            {
                int extracted = ExtractSingleInner(mmf, info.NameHash64, outDir);

                if (extracted != 0)
                    extractedList.Add(info.FileName);
                else
                    failedList.Add(info.FileName);

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

            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();
            int all = 0;

            using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            Console.Write($"Uncooking {FileCount} bundle entries ");

            // check search pattern then regex
            IEnumerable<ArchiveItem> finalmatches = Files.Values;
            if (!string.IsNullOrEmpty(pattern))
                finalmatches = Files.Values.MatchesWildcard(item => item.FileName, pattern);
            if (!string.IsNullOrEmpty(regex))
            {
                var searchTerm = new System.Text.RegularExpressions.Regex($@"{regex}");
                var queryMatchingFiles =
                    from file in finalmatches
                    let matches = searchTerm.Matches(file.FileName)
                    where matches.Count > 0
                    select file;

                finalmatches = queryMatchingFiles;
            }

            Thread.Sleep(1000);
            int progress = 0;
            logger.LogProgress(0);

            Parallel.ForEach(finalmatches, info =>
            {
                if (CanUncook(info.NameHash64))
                {
                    Interlocked.Increment(ref all);
                    int uncooked = UncookSingleInner(mmf, info.NameHash64, outDir, uncookext);

                    if (uncooked != 0)
                        extractedList.Add(info.FileName);
                    else
                        failedList.Add(info.FileName);
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
            string name = Files[hash].FileName;

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
                    if ((oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
                    {
                        var size = binaryReader.ReadUInt32();

                        if (size != offsetentry.Size)
                            throw new NotImplementedException();

                        var buffer = binaryReader.ReadBytes((int)offsetentry.ZSize - 8);

                        byte[] unpacked = new byte[offsetentry.Size];
                        long unpackedSize = OodleNative.Decompress(buffer, unpacked);

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



