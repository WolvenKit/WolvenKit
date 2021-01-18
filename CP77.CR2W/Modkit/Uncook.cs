using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Services;
using CP77.Common.Tools.FNV1A;
using CP77.CR2W.Archive;
using CP77.CR2W.Extensions;
using CP77.CR2W.Types;
using CP77.CR2W.Uncooker;
using WolvenKit.Common;
using WolvenKit.Common.Tools.DDS;

namespace CP77.CR2W
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public static partial class ModTools
    {
        /// <summary>
        /// Uncooks a single file by hash.
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="uncookext"></param>
        /// <param name="flip"></param>
        /// <returns></returns>
        public static int UncookSingle(this Archive.Archive ar, ulong hash, DirectoryInfo outDir, EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);
            
            return ar.UncookSingleInner(hash, outDir, uncookext, flip);
        }
        
        private static int UncookSingleInner(this Archive.Archive ar, ulong hash, DirectoryInfo outDir, EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            // checks
            if (!ar.Files.ContainsKey(hash))
                return -1;
            var name = ar.Files[hash].FileName;
            var outfile = new FileInfo(Path.Combine(outDir.FullName,
                $"{name}"));
            if (outfile.Directory == null)
                return -1;

            var uncooksuccess = false;
            var (file, buffers) = ar.GetFileData(hash, true);
            
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
                        EFileReadErrorCodes result = EFileReadErrorCodes.NoCr2w;
                        try
                        {
                            result = cr2w.Read(br);
                        }
                        catch (Exception e)
                        {
                            Logger.LogString(e.Message, Logtype.Error);
                            return -1;
                        }
                        
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
                                    
                                    
                                }

                                if (flip && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                                    TexconvWrapper.VFlip(outfile.Directory.FullName, newpath, texformat);
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
                    case ECookedFileFormat.mlmask:
                    {
                        br.BaseStream.Seek(0, SeekOrigin.Begin);
                        EFileReadErrorCodes result = EFileReadErrorCodes.NoCr2w;
                        try
                        {
                            result = cr2w.Read(br);
                        }
                        catch (Exception e)
                        {
                            Logger.LogString(e.Message, Logtype.Error);
                            return -1;
                        }
                        try
                        {
                            if (!Mlmask.UncookMultilayer(cr2w, buffers, outfile, uncookext))
                                return -1;
                            uncooksuccess = true;
                        }
                        catch
                        {
                            uncooksuccess = false;
                        }
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
        
        /// <summary>
        /// Uncooks all Files to the specified directory.
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <param name="regex"></param>
        /// <param name="uncookext"></param>
        /// <param name="flip"></param>
        /// <returns></returns>
        public static (List<string>, int) UncookAll(this Archive.Archive ar, DirectoryInfo outDir, string pattern = "", string regex = "", EUncookExtension uncookext = EUncookExtension.tga, bool flip = false)
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();
            
            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);
            
            // check search pattern then regex
            IEnumerable<ArchiveItem> finalmatches = ar.Files.Values;
            if (!string.IsNullOrEmpty(pattern))
                finalmatches = ar.Files.Values.MatchesWildcard(item => item.FileName, pattern);
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

            var finalMatchesList = finalmatches.Where(_ => ar.CanUncook(_.NameHash64)).ToList();
            logger.LogString($"Found {finalMatchesList.Count} bundle entries to uncook.", Logtype.Important);

            Thread.Sleep(1000);
            int progress = 0;
            logger.LogProgress(0);
            Parallel.ForEach(finalMatchesList, info =>
            {
                var uncooked = ar.UncookSingleInner(info.NameHash64, outDir, uncookext, flip);

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

    }
}