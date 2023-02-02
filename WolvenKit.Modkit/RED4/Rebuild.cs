using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        #region Methods

        /// <summary>
        /// Rebuild a list of buffer bytearrays into a redfile
        /// </summary>
        /// <param name="redfileStream"></param>
        /// <param name="buffersenumerable"></param>
        /// <returns></returns>
        private bool Rebuild(Stream redfileStream, IEnumerable<byte[]> buffersenumerable)
        {
            var isResource = _parserService.IsCR2WFile(redfileStream);
            if (!isResource)
            {
                return false;
            }

            //using var reader = new CR2WReader(redfileStream);
            //reader.ParsingError += args => args is InvalidDefaultValueEventArgs;
            //_ = reader.ReadFile(out var cr2w, false);

            if (!_parserService.TryReadRed4File(redfileStream, out var cr2w))
            {
                _loggerService.Error("Could not read file");
                return false;
            }

            var existingBuffers = cr2w.GetBuffers();
            var buffers = buffersenumerable.ToList();

            if (buffers.Count != existingBuffers.Count)
            {
                throw new NotSupportedException("Rebuild: Adding/Removing buffers is not supported");
            }

            for (var i = 0; i < buffers.Count; i++)
            {
                existingBuffers[i].SetBytes(buffers[i]);
            }

            // write cr2w
            redfileStream.Seek(0, SeekOrigin.Begin);
            using var writer = new CR2WWriter(redfileStream) { LoggerService = _loggerService };
            writer.WriteFile(cr2w);

            return true;
        }

        /// <summary>
        /// Rebuild a list of buffer files into a redfile
        /// </summary>
        /// <param name="redfileStream"></param>
        /// <param name="buffers"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        private bool Rebuild(Stream redfileStream, IEnumerable<FileInfo> buffers)
        {
            AppendBuffersToFile(redfileStream);

            return true;

            void AppendBuffersToFile(Stream fileStream)
            {
                var isResource = _parserService.IsCR2WFile(redfileStream);
                if (!isResource)
                {
                    return;
                }

                //using var reader = new CR2WReader(redfileStream);
                //reader.ParsingError += args => args is InvalidDefaultValueEventArgs;
                //_ = reader.ReadFile(out var cr2w, false);

                if (!_parserService.TryReadRed4File(redfileStream, out var cr2w))
                {
                    _loggerService.Error("Could not read file");
                    return;
                }

                var existingBuffers = cr2w.GetBuffers();

                // sort buffers numerically
                var bufferlist = buffers.ToList();
                if (bufferlist.All(_ => _.Extension == ".buffer"))
                {
                    bufferlist = bufferlist
                        .OrderBy(_ => int.Parse(Path.GetExtension(_.FullName.Remove(_.FullName.Length - 7))[1..]))
                        .ToList();
                }

                if (bufferlist.All(_ => _.Extension == ".dds"))
                {
                    // ml_w_knife__combat__grip1_01_masksset_0.dds
                    bufferlist = bufferlist
                        .OrderBy(n => Regex.Replace(n.Name, @"\d+", n => n.Value.PadLeft(4, '0')))
                        //.OrderBy(_ => int.Parse(Path.GetExtension(_.FullName.Remove(_.FullName.Length - 4))[1..]))
                        .ToList();
                }

                if (bufferlist.Count != existingBuffers.Count)
                {
                    throw new NotSupportedException("Rebuild: Adding/Removing buffers is not supported");
                }

                for (var i = 0; i < bufferlist.Count; i++)
                {
                    var buffer = bufferlist[i];
                    if (!buffer.Exists)
                    {
                        throw new FileNotFoundException($"Could not find file {buffer.FullName} anymore.");
                    }

                    var inbuffer = ReadBuffer(buffer);
                    if (inbuffer.Length < 1)
                    {
                        continue;
                    }

                    existingBuffers[i].SetBytes(inbuffer);
                }

                // write cr2w
                redfileStream.Seek(0, SeekOrigin.Begin);
                using var writer = new CR2WWriter(redfileStream) { LoggerService = _loggerService };
                writer.WriteFile(cr2w);
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

                        default:
                            break;
                    }
                }
                else
                {
                    return fs.ToByteArray();
                }

                return Array.Empty<byte>();
            }
        }

        /// <summary>
        /// Rebuilds a single raw buffer into its redfile
        /// </summary>
        /// <param name="rawRelativePath"></param>
        /// <param name="outDir"></param>
        /// <returns></returns>
        public bool RebuildBuffer(RedRelativePath rawRelativePath, DirectoryInfo outDir)
        {
            var ext = rawRelativePath.Extension;
            // only buffers can be rebuilt
            if (ext != "buffer")
            {
                return false;
            }
            if (outDir is not { Exists: true })
            {
                outDir = rawRelativePath.BaseDirectory;
            }

            var bufferPath = rawRelativePath.FullPath;
            var rawRedFilePath = new FileInfo(Path.ChangeExtension(bufferPath.Remove(bufferPath.Length - 7), "").TrimEnd('.'));

            var redRelative = new RedRelativePath(rawRelativePath)
                .ChangeBaseDir(outDir)
                .ChangeRelativePath(rawRedFilePath.GetRelativePath(rawRelativePath.BaseDirectory));

            if (string.IsNullOrEmpty(redRelative.FullPath) || !File.Exists(redRelative.FullPath))
            {
                var depotBase = $"{Path.DirectorySeparatorChar}base{Path.DirectorySeparatorChar}";
                var basedir = rawRelativePath.BaseDirectory.FullName;
                // check one more combination if the user is derpy
                if (basedir.Contains(depotBase))
                {
                    var first = basedir.IndexOf(depotBase, StringComparison.Ordinal);
                    var additionalRelPath = basedir[(first + 1)..];

                    redRelative.ChangeBaseDir(outDir);
                    var newrelpath = Path.Combine(additionalRelPath, redRelative.RelativePath);
                    redRelative.ChangeRelativePath(newrelpath);

                    if (!File.Exists(redRelative.FullPath))
                    {
                        // this means the redfile to be rebuilt has not been found in the output folder
                        _loggerService.Error($"Failed to find a file to rebuild for {bufferPath}");
                        return false;
                    }
                }
            }

            // get all other buffers
            var dir = rawRelativePath.ToFileInfo().Directory;
            if (dir is not null)
            {
                var buffers = dir.GetFiles($"{rawRedFilePath.Name}.*.buffer", SearchOption.TopDirectoryOnly);
                using var fileStream = new FileStream(redRelative.FullPath, FileMode.Open, FileAccess.ReadWrite);
                var r = Rebuild(fileStream, buffers);
                if (r)
                {
                    _loggerService.Success($"Succesfully rebuilt {redRelative.FullPath} with raw buffers");
                }
                else
                {
                    _loggerService.Error($"Failed to rebuild {redRelative.FullPath} with raw buffers.");
                }

                return r;
            }
            return false;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="inDir"></param>
        /// <param name="outDir"></param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public bool RebuildFolder(DirectoryInfo inDir, DirectoryInfo outDir)
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
                if (!File.Exists(parentPath))
                {
                    failsCount++;
                    _loggerService.Warning($"Failed to rebuild {parentPath} with buffers");
                }
                else
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
                }

                Interlocked.Increment(ref progress);
                _progressService.Report(progress / (float)buffersDict.Count);
            }

            _progressService.Completed();
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
                    var rawRedFilePath = Path.ChangeExtension(path.Remove(path.Length - 7), "").TrimEnd('.');

                    // if the outdir is elsewhere, we need to change the path
                    var redFilePath = rawRedFilePath.Replace(inDir.FullName, outDir.FullName);
                    if (outDir != inDir && rawRedFilePath.Equals(redFilePath))
                    {
                        // this means the redfile to be rebuilt has not been found in the output folder
                        _loggerService.Error($"Failed to find a file to rebuild for {path}");
                        return;
                    }

                    if (!File.Exists(redFilePath))
                    {
                        var depotBase = $"{Path.DirectorySeparatorChar}base{Path.DirectorySeparatorChar}";
                        var basedir = inDir.FullName;
                        // check one more combination if the user is derpy
                        if (basedir.Contains(depotBase))
                        {
                            var first = basedir.IndexOf(depotBase, StringComparison.Ordinal);
                            var additionalRelPath = basedir[(first + 1)..];

                            var redRelative = new RedRelativePath(outDir, new FileInfo(rawRedFilePath).GetRelativePath(inDir));
                            var newrelpath = Path.Combine(additionalRelPath, redRelative.RelativePath);
                            redRelative.ChangeRelativePath(newrelpath);

                            if (!File.Exists(redRelative.FullPath))
                            {
                                // this means the redfile to be rebuilt has not been found in the output folder
                                _loggerService.Error($"Failed to find a file to rebuild for {path}");
                                return;
                            }

                            redFilePath = redRelative.FullName;
                        }
                    }


                    // add buffer
                    if (!buffersDict.ContainsKey(redFilePath))
                    {
                        buffersDict.Add(redFilePath, new List<FileInfo>());
                    }

                    buffersDict[redFilePath].Add(fileInfo);
                }
            }
        }

        #endregion Methods
    }
}
