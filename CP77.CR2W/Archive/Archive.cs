using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Services;
using CP77.Common.Tools;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Extensions;
using CP77Tools.Model;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Tools.DDS;
using CP77.CR2W.Types;

namespace CP77.CR2W.Archive
{
    public class Archive
    {
        #region constructors

        public Archive()
        {
            Header = new ArHeader();
            Table = new ArTable();
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
        public ArHeader Header { get; set; }
        public ArTable Table { get; set; }
        public string Filepath { get; set; }

        [JsonIgnore]
        public Dictionary<ulong, ArchiveItem> Files => Table?.FileInfo;

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
            //using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0, MemoryMappedFileAccess.Read);

            // using (var vs = mmf.CreateViewStream(0, ArHeader.SIZE, MemoryMappedFileAccess.Read))
            // {
            //     _header = new ArHeader(new BinaryReader(vs));
            // }

            // using (var vs = mmf.CreateViewStream((long)_header.Tableoffset, (long)_header.Tablesize,
            //     MemoryMappedFileAccess.Read))
            // {
            //     _table = new ArTable(new BinaryReader(vs), this);
            // }

            using var vs = new FileStream(Filepath, FileMode.Open, FileAccess.Read);
            Header = new ArHeader(new BinaryReader(vs));
            vs.Seek((long) Header.Tableoffset, SeekOrigin.Begin);
            Table = new ArTable(new BinaryReader(vs), this);
            vs.Close();
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
        public int UncookSingle(ulong hash, DirectoryInfo outDir, EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);
            
            return UncookSingleInner(hash, outDir, uncookext, flip);
        }

        /// <summary>
        /// Extracts a single file + buffers.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <returns></returns>
        public int ExtractSingle(ulong hash, DirectoryInfo outDir)
        {
            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);

            return ExtractSingleInner(hash, outDir);
        }

        private int UncookSingleInner( ulong hash, DirectoryInfo outDir, EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            // checks
            if (!Files.ContainsKey(hash))
                return -1;
            var name = Files[hash].FileName;
            var outfile = new FileInfo(Path.Combine(outDir.FullName,
                $"{name}"));
            if (outfile.Directory == null)
                return -1;

            var uncooksuccess = false;
            var (file, buffers) = GetFileData(hash, true);
            
            var cr2w = new CR2WFile();
            using var ms = new MemoryStream(file);
            using var br = new BinaryReader(ms);
            cr2w.ReadImportsAndBuffers(br);

            var ext = Path.GetExtension(name)[1..];
            
            //TODO: temp fix to support uncooking unknown files
            if (cr2w.StringDictionary[1] == "C2dArray")
                ext = "csv";
            else if (cr2w.StringDictionary[1] == "CBitmapTexture")
                ext = "xbm";
            
            // uncook textures, meshes etc
            if (Enum.GetNames(typeof(ECookedFileFormat)).Contains(ext))
            {
                if (!Enum.TryParse(ext, true, out ECookedFileFormat extAsEnum))
                    return -1;
                switch (extAsEnum)
                {
                    case ECookedFileFormat.xbm:
                    {
                        if (buffers.Count > 1)
                            return -1; //TODO: can that happen?
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
                                #region get xbm data

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

                                var texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt);

                                #endregion

                                // extract and write buffer 
                                Directory.CreateDirectory(outfile.Directory.FullName);
                                using (var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write))
                                {
                                    DDSUtils.GenerateAndWriteHeader(ddsStream,
                                        new DDSMetadata(width, height, mips, texformat, alignment, false, slicecount,
                                            true));
                                    ddsStream.Write(b);
                                    
                                    if (flip && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                                        TexconvWrapper.VFlip(outfile.Directory.FullName, newpath, texformat);
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
                            if (uncookext != EUncookExtension.dds && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
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

                        break;
                    }
                    case ECookedFileFormat.csv:
                    {
                        if (buffers.Count > 0)
                            return -1; //TODO: can that happen?
                        if (cr2w.StringDictionary[1] != "C2dArray")
                            return -1;

                        br.BaseStream.Seek(0, SeekOrigin.Begin);
                        var result = cr2w.Read(br);
                        if (result != EFileReadErrorCodes.NoError)
                            return -1;
                        if (!(cr2w.Chunks.FirstOrDefault() is {data: C2dArray redcsv}))
                            return -1;

                        // write
                        var newpath = $"{outfile.FullName}.csv";

                        Directory.CreateDirectory(outfile.Directory.FullName);
                        using var nstream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                        redcsv.ToCsvStream(nstream);


                        break;
                    }
                    case ECookedFileFormat.json:
                    {

                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else // extract buffers
            {
                for (int i = 0; i < buffers.Count; i++)
                {
                    var buffer = buffers[i];
                    var bufferpath = $"{outfile}.{i}.buffer";
                    Directory.CreateDirectory(outfile.Directory.FullName);
                    File.WriteAllBytes(bufferpath, buffer);
                }
                uncooksuccess = true;
            }

            return uncooksuccess ? 1 : 0;
        }

        private int ExtractSingleInner(ulong hash, DirectoryInfo outDir)
        {
            var extractsuccess = false;
            var (file, buffers) = GetFileData(hash, false);

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
            // buffers are usually(?) appended to the main file
            // TODO: dump all buffered files and check this
            for (int j = 0; j < buffers.Count; j++)
            {
                var buffer = buffers[j];
                using var fs = new FileStream(outfile.FullName, FileMode.Append, FileAccess.Write);
                fs.Write(buffer);
                extractsuccess = true;
            }

            return extractsuccess ? 1 : 0;
        }

        /// <summary>
        /// Extracts all Files to the specified directory.
        /// </summary>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <param name="regex"></param>
        /// <returns></returns>
        public (List<string>, int) ExtractAll(DirectoryInfo outDir, string pattern = "", string regex = "")
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);

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

            var finalMatchesList = finalmatches.ToList();
            logger.LogString($"Exporting {finalMatchesList.Count} bundle entries.");

            Thread.Sleep(1000);
            int progress = 0;
            logger.LogProgress(0);
            Parallel.ForEach(finalMatchesList, info =>
            {
                
                var extracted = ExtractSingleInner(info.NameHash64, outDir);

                if (extracted != 0)
                    extractedList.Add(info.FileName);
                else
                    failedList.Add(info.FileName);

                Interlocked.Increment(ref progress);
                logger.LogProgress(progress / (float)finalMatchesList.Count);
            });

            return (extractedList.ToList(), finalMatchesList.Count);
        }

        /// <summary>
        /// Uncooks all Files to the specified directory.
        /// </summary>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <param name="regex"></param>
        /// <param name="uncookext"></param>
        /// <returns></returns>
        public (List<string>, int) UncookAll(DirectoryInfo outDir, string pattern = "", string regex = "", EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();
            
            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);
            
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

            var finalMatchesList = finalmatches.Where(_ => CanUncook(_.NameHash64)).ToList();
            logger.LogString($"Uncooking {finalMatchesList.Count} bundle entries.");

            Thread.Sleep(1000);
            int progress = 0;
            logger.LogProgress(0);
            Parallel.ForEach(finalMatchesList, info =>
            {
                var uncooked = UncookSingleInner(info.NameHash64, outDir, uncookext, flip);

                if (uncooked != 0)
                    extractedList.Add(info.FileName);
                else
                    failedList.Add(info.FileName);
                Interlocked.Increment(ref progress);
                logger.LogProgress(progress / (float)finalMatchesList.Count);
            });

            foreach (var failed in failedList)
            {
                logger.LogString($"Failed to uncook {failed}.", Logtype.Error);
            }

            return (extractedList.ToList(), finalMatchesList.Count);
        }

        private bool CanUncook(ulong hash)
        {
            if (!Files.ContainsKey(hash))
                return false;
            var archiveItem = Files[hash]; 
            string name = archiveItem.FileName;
            var hasBuffers = (archiveItem.LastOffsetTableIdx - archiveItem.FirstOffsetTableIdx) > 1;

            var values = Enum.GetNames(typeof(ECookedFileFormat));
            var b = values.Any(e => e == Path.GetExtension(name)[1..]) || hasBuffers ;
            return b;
        }

        /// <summary>
        /// Gets the bytes of one file by index from the archive.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="decompressBuffers"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public (byte[], List<byte[]>) GetFileData(ulong hash, bool decompressBuffers)
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            if (!Files.ContainsKey(hash)) return (null, null);

            var entry = Files[hash];
            var startindex = (int)entry.FirstOffsetTableIdx;
            var nextindex = (int)entry.LastOffsetTableIdx;
            
            // decompress main file
            var file = ExtractFile(this.Table.Offsets[startindex], true);
            
            // don't decompress buffers
            var buffers = new List<byte[]>();
            for (int j = startindex + 1; j < nextindex; j++)
            {
                var offsetentry = this.Table.Offsets[j];
                var buffer = ExtractFile(offsetentry, decompressBuffers);
                buffers.Add(buffer);
            }

            return (file, buffers);

            // local
            byte[] ExtractFile(OffsetEntry offsetentry, bool decompress)
            {
                
                using var ms = new MemoryStream();
                using var bw = new BinaryWriter(ms);

                // using var stream = mmf.CreateViewStream((long)offsetentry.Offset, (long)offsetentry.ZSize,
                //     MemoryMappedFileAccess.Read);
                using var stream = new FileStream(Filepath, FileMode.Open, FileAccess.Read);
                using var binaryReader = new BinaryReader(stream);
                binaryReader.BaseStream.Seek((long) offsetentry.Offset, SeekOrigin.Begin);

                if (offsetentry.ZSize == offsetentry.Size || !decompress)
                {
                    try
                    {
                        var buffer = binaryReader.ReadBytes((int)offsetentry.ZSize);
                        bw.Write(buffer);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
                else
                {
                    var oodleCompression = binaryReader.ReadBytes(4);
                    if ((oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
                    {
                        var size = binaryReader.ReadUInt32();

                        if (size != offsetentry.Size)
                            throw new Exception($"{hash}: Buffer size doesn't match size in info table. {size} vs {offsetentry.Size}");

                        var inputBuffer = binaryReader.ReadBytes((int)offsetentry.ZSize - 8);

                        try
                        {
                            var outputBuffer = new byte[offsetentry.Size];
                            long unpackedSize = OodleHelper.Decompress(inputBuffer, outputBuffer);

                            if (unpackedSize != offsetentry.Size)
                                throw new Exception($"{hash}: Unpacked size doesn't match real size. {unpackedSize} vs {offsetentry.Size}");
                            bw.Write(outputBuffer);
                        }
                        catch (Exception e)
                        {
                            logger.LogString($"Unable to decompress file {hash}. Exporting uncompressed file", Logtype.Error);
                            bw.Write(inputBuffer);
                        }
                        
                    }
                    else
                    {
                        binaryReader.BaseStream.Seek((long) offsetentry.Offset, SeekOrigin.Begin);
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



