using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        /// <summary>
        /// Imports a raw File to a RedEngine file (e.g. .dds to .xbm, .fbx to .mesh)
        /// </summary>
        /// <param name="rawFile">the raw file to be imported</param>
        /// <param name="args"></param>
        /// <param name="outDir">can be a depotpath, or if null the parent directory of the rawfile</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Import(
            FileInfo rawFile,
            GlobalImportArgs args,
            DirectoryInfo outDir = null)
        {
            #region checks
            if (rawFile is null or {Exists: false})
            {
                return false;
            }
            if (rawFile.Directory is { Exists: false })
            {
                return false;
            }
            if (outDir is not { Exists: true })
            {
                outDir = rawFile.Directory;
            }

            #endregion

            var filename = rawFile.Name;

            // check if the file can be directly imported
            var ext = Path.GetExtension(rawFile.FullName).TrimStart('.');
            if (!Enum.TryParse(ext, true, out ERawFileFormat extAsEnum))
            {
                // only buffers can be rebuilt
                if (ext != "buffer")
                {
                    return false;
                }
                // buffers can not be rebuilt on their own
                if (!args.Get<CommonImportArgs>().Keep)
                {
                    return false;
                }

                // if keep, rebuild
                // get a list of buffers if the user selected just one
                var buffername = Path.ChangeExtension(filename.Remove(filename.Length - 7), "").TrimEnd('.');
                var buffers = rawFile.Directory
                    .GetFiles($"{buffername}.*.buffer", SearchOption.TopDirectoryOnly);

                var redfile = FindRedFileForBuffer(outDir, filename);
                if (string.IsNullOrEmpty(redfile))
                {
                    return false;
                }

                using var fileStream = new FileStream(redfile, FileMode.Open, FileAccess.ReadWrite);
                var r = Rebuild(fileStream, buffers);
                return r;
            }

            // import files
            switch (extAsEnum)
            {
                case ERawFileFormat.tga:
                case ERawFileFormat.dds:
                    var xbmargs = args.Get<XbmImportArgs>();
                    return ImportXbm(rawFile, outDir, xbmargs);
                case ERawFileFormat.fbx:
                case ERawFileFormat.gltf:
                case ERawFileFormat.glb:
                    var meshArgs = args.Get<MeshImportArgs>();
                    return ImportMesh(rawFile, meshArgs);
                default:
                    throw new ArgumentOutOfRangeException();
            }

            static string FindRedFileForBuffer(DirectoryInfo outDir, string bufferPath)
            {
                var filename = Path.ChangeExtension(bufferPath.Remove(bufferPath.Length - 7), "").TrimEnd('.');
                // find redfile in outdir
                // TODO (this can potentially return multiple files with the same name)
                var files = outDir.GetFiles($"*{filename}", SearchOption.AllDirectories);
                if (files.Length > 1)
                {
                    // duplicates found, assert something
                    return "";
                }

                if (files.Length < 1)
                {
                    // no redfile found, skip
                    return "";
                }

                var redfile = files.First().FullName;
                return redfile;
            }
        }

        public bool ImportFolder(
            DirectoryInfo inDir,
            DirectoryInfo outDir = null
        )
        {
            #region checks

            if (inDir is not { Exists: true })
            {
                return false;
            }
            if (outDir is not { Exists: true })
            {
                outDir = inDir;
            }

            #endregion



            //var texturesList = allFiles.Where(_ => _.Extension.ToLower() == ".dds");
            //foreach (var fileInfo in texturesList)
            //{
            //    // dds path e.g. stand__rh_hold_tray__serve_milkshakes__01.dds
            //    // rename to xbm and hash
            //    var relpath = fileInfo.FullName;//[(infolder.FullName.Length + 1)..];
            //    var parentpath = Path.ChangeExtension(relpath, "xbm");
            //    var key = parentpath;//FNV1A64HashAlgorithm.HashString(parentpath);

            //    // add buffer
            //    if (!buffersDict.ContainsKey(key))
            //    {
            //        buffersDict.Add(key, new List<FileInfo>());
            //    }
            //    else // there can always only be one texture and it gets priority
            //    {
            //        buffersDict[key] = new List<FileInfo>();
            //    }

            //    buffersDict[key].Add(fileInfo);
            //}

            return true;
        }

        public bool ImportXbm(FileInfo rawFile, DirectoryInfo outDir, XbmImportArgs args)
        {
            var rawExt = rawFile.Extension.TrimStart('.');
            // TODO: do this in a working directory?
            var ddsPath = Path.ChangeExtension(rawFile.FullName, "dds");
            // convert to dds if not already
            if (rawExt != "dds")
            {
                try
                {
                    if (ddsPath.Length > 255)
                    {
                        _loggerService.Error($"{ddsPath} - Path length exceeds 255 chars. Please move the archive to a directory with a shorter path.");
                        return false;
                    }
                    TexconvWrapper.Convert(rawFile.Directory.FullName, $"{ddsPath}", EUncookExtension.dds);
                }
                catch (Exception)
                {
                    //TODO: proper exception handling
                    return false;
                }

                if (!File.Exists(ddsPath))
                {
                    return false;
                }
            }

            if (args.Keep)
            {
                var buffer = new FileInfo(ddsPath);
                var filename = rawFile.Name;
                var redfile = FindRedFile(outDir, filename);
                using var fileStream = new FileStream(redfile, FileMode.Open, FileAccess.ReadWrite);
                return !string.IsNullOrEmpty(redfile) && Rebuild(fileStream, new List<FileInfo>() {buffer});
            }




            // read dds metadata
            var metadata = DDSUtils.ReadHeader(ddsPath);
            var width = metadata.Width;
            var height = metadata.Height;

            // create cr2wfile
            var cr2w = new CR2WFile();
            // create xbm chunk
            var xbm = new CBitmapTexture(cr2w, null, "CBitmapTexture");
            xbm.Width = new CUInt32(cr2w, xbm, "width") { Value = width, IsSerialized = true };
            xbm.Height = new CUInt32(cr2w, xbm, "height") { Value = height, IsSerialized = true };
            xbm.CookingPlatform = new CEnum<Enums.ECookingPlatform>(cr2w, xbm, "cookingPlatform"){ Value = Enums.ECookingPlatform.PLATFORM_PC, IsSerialized = true };
            xbm.Setup = new STextureGroupSetup(cr2w, xbm, "setup")
            {
                IsSerialized = true
            };
            SetTextureGroupSetup();



            // populate with dds metadata



            // kraken ddsfile
            // remove dds header

            // compress file

            // append to cr2wfile

            // update cr2w headers

            throw new NotImplementedException();


            #region local functions

            void SetTextureGroupSetup()
            {
                // first check the user-texture group
                var (compression, rawformat, flags) = CommonFunctions.GetRedFormatsFromTextureGroup(args.TextureGroup);
                xbm.Setup.Group = new CEnum<Enums.GpuWrapApieTextureGroup>(cr2w, xbm, "group")
                {
                    IsSerialized = true,
                    Value = args.TextureGroup
                };
                if (flags is CommonFunctions.ETexGroupFlags.Both or CommonFunctions.ETexGroupFlags.CompressionOnly)
                {
                    xbm.Setup.Compression = new CEnum<Enums.ETextureCompression>(cr2w, xbm, "setup")
                    {
                        IsSerialized = true,
                        Value = compression
                    };
                }

                if (flags is CommonFunctions.ETexGroupFlags.Both or CommonFunctions.ETexGroupFlags.RawFormatOnly)
                {
                    xbm.Setup.RawFormat = new CEnum<Enums.ETextureRawFormat>(cr2w, xbm, "rawFormat")
                    {
                        IsSerialized = true,
                        Value = rawformat
                    };
                }

                // if that didn't work, interpret the filename suffix
                if (rawFile.Name.Contains('_'))
                {
                    // try interpret suffix
                    switch (rawFile.Name.Split('_').Last())
                    {
                        case "d":
                        case "d01":

                            break;
                        case "e":

                            break;
                        case "r":
                        case "r01":

                            break;
                        default:
                            break;
                    }
                }

                // if that also didn't work, just use default or skip
                //TODO
            }

            #endregion

        }

        private static ECookedFileFormat FromRawExtension(ERawFileFormat rawextension) =>
            rawextension switch
            {
                ERawFileFormat.tga => ECookedFileFormat.xbm,
                ERawFileFormat.dds => ECookedFileFormat.xbm,
                ERawFileFormat.fbx => ECookedFileFormat.mesh,
                ERawFileFormat.gltf => ECookedFileFormat.mesh,
                ERawFileFormat.glb => ECookedFileFormat.mesh,
                _ => throw new ArgumentOutOfRangeException(nameof(rawextension), rawextension, null)
            };

        private static string FindRedFile(DirectoryInfo outDir, string rawfilename)
        {
            var ext = Path.GetExtension(rawfilename).TrimStart('.');
            if (!Enum.TryParse(ext, true, out ERawFileFormat extAsEnum))
            {
                return "";
            }

            var filename = Path.ChangeExtension(rawfilename, FromRawExtension(extAsEnum).ToString());


            // find redfile in outdir
            // TODO (this can potentially return multiple files with the same name)
            var files = outDir.GetFiles($"*{filename}", SearchOption.AllDirectories);
            if (files.Length > 1)
            {
                // duplicates found, assert something
                return "";
            }

            if (files.Length < 1)
            {
                // no redfile found, skip
                return "";
            }

            var redfile = files.First().FullName;
            return redfile;
        }
        private bool ImportMesh(FileInfo rawFile, MeshImportArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
