using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using WolvenKit.Common;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        #region Methods

        private bool Rebuild(
            Stream redfile,
            IEnumerable<FileInfo> buffers
        )
        {
            AppendBuffersToFile(redfile, buffers);

            return true;

            void AppendBuffersToFile(Stream fileStream, IEnumerable<FileInfo> buffersIn)
            {
                //check if cr2w
                using var fileReader = new BinaryReader(fileStream);

                var cr2w = _wolvenkitFileService.TryReadRED4FileHeaders(fileReader);
                if (cr2w == null)
                {
                    return;
                }

                // sort buffers numerically
                var buffers = buffersIn;
                if (buffersIn.All(_ => _.Extension == ".buffer"))
                {
                    buffers = buffersIn
                        .OrderBy(_ =>
                            int.Parse(Path.GetExtension(_.FullName.Remove(_.FullName.Length - 7))[1..]))
                        .ToList();
                }

                // remove old buffers
                fileReader.BaseStream.Seek(0, SeekOrigin.Begin);
                fileStream.SetLength(cr2w.Header.objectsEnd);

                // kraken the buffers and handle textures
                using var fileWriter = new BinaryWriter(fileStream);
                fileWriter.BaseStream.Seek(0, SeekOrigin.End);

                var existingBufferCount = cr2w.Buffers.Count;

                var bufferList = buffers.ToList();
                for (var i = 0; i < bufferList.Count; i++)
                {
                    var buffer = bufferList[i];
                    if (!buffer.Exists)
                    {
                        throw new FileNotFoundException($"Could not find file {buffer.FullName} anymore.");
                    }

                    var inbuffer = ReadBuffer(buffer);
                    if (inbuffer.Length < 1)
                    {
                        continue;
                    }

                    var offset = (uint)fileWriter.BaseStream.Position;
                    var (zsize, crc) = fileWriter.CompressAndWrite(inbuffer);

                    if (i < existingBufferCount)
                    {
                        var b = cr2w.Buffers[i];
                        b.Offset = offset;
                        b.DiskSize = zsize;
                        b.MemSize = (uint)inbuffer.Length;
                        b.Crc32 = crc;
                    }
                    else
                    {
                        cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                        {
                            flags = 0, //TODO: find out what these are
                            index = (uint)i,
                            offset = offset,
                            diskSize = zsize,
                            memSize = (uint)inbuffer.Length,
                            crc32 = crc
                        }));
                    }
                }

                // write cr2w headers
                fileWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                cr2w.WriteHeader(fileWriter);

            }

            static byte[] ReadBuffer(FileInfo buffer)
            {
                using var fs = new FileStream(buffer.FullName, FileMode.Open, FileAccess.Read);
                using var br = new BinaryReader(fs);
                var bext = buffer.Extension.ToLower();

                // if dds file, delete the
                if (bext != ".buffer")
                {
                    switch (bext)
                    {
                        case ".dds":
                            // check if dx10
                            fs.Seek(84, SeekOrigin.Begin);
                            var fourcc = br.ReadInt32();
                            // delete dds header
                            if (fourcc == 808540228) //is dx10
                            {
                                fs.Seek(148, SeekOrigin.Begin);
                                return br.ReadBytes((int)fs.Length - 148);
                            }
                            else
                            {
                                fs.Seek(128, SeekOrigin.Begin);
                                return br.ReadBytes((int)fs.Length - 128);
                            }
                    }
                }
                else
                {
                    return fs.ToByteArray();
                }

                return Array.Empty<byte>();
            }
        }

        public bool RebuildBuffer(
            FileInfo rawFile,
            DirectoryInfo outDirectory = null
            )
        {
            var ext = Path.GetExtension(rawFile.FullName).TrimStart('.');
            if (!Enum.TryParse(ext, true, out ERawFileFormat extAsEnum))
            {
                return false;
            }
            // only buffers can be rebuilt
            if (ext != ".buffer")
            {
                return false;
            }
            if (outDirectory is not { Exists: true })
            {
                outDirectory = rawFile.Directory;
            }

            var filename = rawFile.Name;

            // get a list of buffers if the user selected just one
            var buffers = rawFile.Directory
                .GetFiles($"{rawFile.FullName}.*.buffer", SearchOption.TopDirectoryOnly);


            // find redfile in outdir
            // TODO (this can potentially return multiple files with the same name)
            var files = outDirectory.GetFiles($"*{filename}", SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                // throw something
                return false;
            }
            else if (files.Length < 1)
            {
                // no redfile found, skip
                return false;
            }
            else
            {
                using var fileStream = new FileStream(files.First().FullName, FileMode.Open, FileAccess.ReadWrite);
                return Rebuild(fileStream, buffers);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="inDir"></param>
        /// <param name="outDir"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public bool RebuildFolder(
            DirectoryInfo inDir,
            DirectoryInfo outDir = null
            )
        {
            if (outDir is not { Exists: true })
            {
                outDir = inDir;
            }

            var buffersDict = new Dictionary<string, List<FileInfo>>();

            // get all buffers and textures to recombine
            // if both buffers and textures is selected and a file has both buffers and textures
            // then the texture has priority
            GetBuffers();

            if (buffersDict.Count < 1)
            {
                _loggerService.Info($"No buffers found to rebuild in {inDir.FullName}");
                return true;
            }

            _loggerService.Info($"Found {buffersDict.Count} raw file(s) to rebuild");

            var failsCount = 0;
            var progress = 0;
            _progressService.Report(0);
            foreach (var (parentPath, buffers) in buffersDict)
            {
                using var fileStream = new FileStream(parentPath, FileMode.Open, FileAccess.ReadWrite);
                if (!Rebuild(fileStream, buffers))
                {
                    failsCount++;
                    _loggerService.Warning($"Failed to rebuild {parentPath} with buffers");
                    
                }
                else
                {
                    _loggerService.Success($"Rebuilt {parentPath} with buffers");
                }

                Interlocked.Increment(ref progress);
                _progressService.Report(progress / (float)buffersDict.Count);
            }

            _loggerService.Info($"Rebuilt {buffersDict.Count - failsCount}/{buffersDict.Count} file(s)");
            return true;

            void GetBuffers()
            {
                var allFiles = inDir.GetFiles("*", SearchOption.AllDirectories).ToList();
                var buffersList = allFiles.Where(_ => _.Extension.ToLower() == ".buffer");
                foreach (var fileInfo in buffersList)
                {
                    // buffer path e.g. stand__rh_hold_tray__serve_milkshakes__01.scenerid.11.buffer
                    // removes 7 characters (".buffer") and then removes the variable length extension (".11")
                    var path = fileInfo.FullName;//[(infolder.FullName.Length + 1)..];
                    var parentpath = Path.ChangeExtension(path.Remove(path.Length - 7), "").TrimEnd('.');

                    // if the outdir is elsewhere, we need to change the path... :(
                    var parentFileName = Path.GetFileName(parentpath);
                    if (inDir.FullName != outDir.FullName)
                    {
                        parentpath = parentpath.Replace(inDir.FullName, outDir.FullName);
                    }

                    var key = parentpath;//FNV1A64HashAlgorithm.HashString(parentpath);

                    // add buffer
                    if (!buffersDict.ContainsKey(key))
                    {
                        buffersDict.Add(key, new List<FileInfo>());
                    }

                    buffersDict[key].Add(fileInfo);
                }
            }
        }

        #endregion Methods
    }
}
