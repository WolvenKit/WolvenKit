using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading.Tasks;
using ProtoBuf;
using WolvenKit.Common;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.RED4.Archive
{
    [ProtoContract]
    public class Archive : ICyberGameArchive
    {
        #region constructors

        public Archive()
        {
            Header = new Header();
            Index = new Index();
            Files = new Dictionary<ulong, IGameFile>();
        }

        #endregion constructors

        #region properties

        [ProtoMember(1)] public string ArchiveAbsolutePath { get; set; }

        [ProtoMember(2)] public Header Header { get; set; }

        [ProtoMember(3)] public Index Index { get; set; }


        public Dictionary<ulong, IGameFile> Files { get; }

        public string Name => Path.GetFileName(ArchiveAbsolutePath);

        public EArchiveType TypeName => EArchiveType.Archive;

        public int FileCount => Files?.Count ?? 0;



        #endregion properties

        #region methods

        /// <summary>
        ///
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public bool CanUncook(ulong hash)
        {
            if (!Files.ContainsKey(hash))
            {
                return false;
            }

            var archiveItem = Files[hash] as FileEntry;
            var hasBuffers = (archiveItem.SegmentsEnd - archiveItem.SegmentsStart) > 1;

            var values = Enum.GetNames(typeof(ECookedFileFormat));
            var b = values.Any(e => e == Path.GetExtension(archiveItem.FileName)?[1..]) || hasBuffers;
            return b;
        }

        public void CopyFileToStreamWithoutBuffers(Stream stream, ulong hash, MemoryMappedFile mmf = null)
        {
            if (!Files.ContainsKey(hash))
            {
                return;
            }

            var entry = Files[hash] as FileEntry;
            var startIndex = (int)entry.SegmentsStart;
            var nextIndex = (int)entry.SegmentsEnd;

            // decompress main file
            CopyFileSegmentToStream(stream, Index.FileSegments[startIndex], true, mmf);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="hash"></param>
        /// <param name="decompressBuffers"></param>
        public void CopyFileToStream(Stream stream, ulong hash, bool decompressBuffers, MemoryMappedFile mmf = null)
        {
            if (!Files.ContainsKey(hash))
            {
                return;
            }

            var entry = Files[hash] as FileEntry;
            var startIndex = (int)entry.SegmentsStart;
            var nextIndex = (int)entry.SegmentsEnd;

            // decompress main file
            CopyFileSegmentToStream(stream, Index.FileSegments[startIndex], true, mmf);

            //var bufferSegments = new List<FileSegment>();
            for (var j = startIndex + 1; j < nextIndex; j++)
            {
                var offsetEntry = Index.FileSegments[j];
                CopyFileSegmentToStream(stream, offsetEntry, decompressBuffers, mmf);
            }
            //for (var j = startIndex + 1; j < nextIndex; j++)
            //{
            //    bufferSegments.Add(Index.FileSegments[j]);
            //}

            //if (bufferSegments.Count < 1)
            //{
            //    return;
            //}

            //var cOffsets = new List<ulong> {bufferSegments[0].Offset};
            //var cSizes = new List<ulong>();

            //var lastOffset = bufferSegments[0].Offset;
            //ulong currentSize = 0;
            //foreach (var segment in bufferSegments)
            //{
            //    if (lastOffset == segment.Offset)
            //    {
            //        lastOffset += segment.ZSize;
            //    }
            //    else
            //    {
            //        cSizes.Add(currentSize);
            //        cOffsets.Add(segment.Offset);
            //        lastOffset = segment.Offset + segment.ZSize;
            //        currentSize = 0;
            //    }

            //    currentSize += segment.ZSize;
            //}
            //cSizes.Add(currentSize);

            //for (var i = 0; i < cOffsets.Count; i++)
            //{
            //    var curOffset = cOffsets[i];
            //    var curSize = cSizes[i];

            //    using var vs = mmf.CreateViewStream((long)curOffset, (long)curSize, MemoryMappedFileAccess.Read);
            //    vs.CopyTo(stream);
            //}
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="hash"></param>
        /// <param name="decompressBuffers"></param>
        public async Task CopyFileToStreamAsync(Stream stream, ulong hash, bool decompressBuffers, MemoryMappedFile mmf = null)
        {
            if (!Files.ContainsKey(hash))
            {
                return;
            }

            var entry = Files[hash] as FileEntry;
            var startIndex = (int)entry.SegmentsStart;
            var nextIndex = (int)entry.SegmentsEnd;

            // decompress main file
            await CopyFileSegmentToStreamAsync(stream, Index.FileSegments[startIndex], true, mmf);

            var bufferSegments = new List<FileSegment>();
            for (var j = startIndex + 1; j < nextIndex; j++)
            {
                bufferSegments.Add(Index.FileSegments[j]);
            }

            if (bufferSegments.Count < 1)
            {
                return;
            }

            var cOffsets = new List<ulong> { bufferSegments[0].Offset };
            var cSizes = new List<ulong>();

            var lastOffset = bufferSegments[0].Offset;
            ulong currentSize = 0;
            foreach (var segment in bufferSegments)
            {
                if (lastOffset == segment.Offset)
                {
                    lastOffset += segment.ZSize;
                }
                else
                {
                    cSizes.Add(currentSize);
                    cOffsets.Add(segment.Offset);
                    lastOffset = segment.Offset + segment.ZSize;
                    currentSize = 0;
                }

                currentSize += segment.ZSize;
            }
            cSizes.Add(currentSize);

            for (var i = 0; i < cOffsets.Count; i++)
            {
                var curOffset = cOffsets[i];
                var curSize = cSizes[i];

                await using var vs = mmf.CreateViewStream((long)curOffset, (long)curSize, MemoryMappedFileAccess.Read);
                await vs.CopyToAsync(stream);
            }
        }


        /// <summary>
        /// Extracts a FileSegment from the archive to a stream
        /// </summary>
        /// <param name="outStream"></param>
        /// <param name="offsetEntry"></param>
        /// <param name="decompress"></param>
        private void CopyFileSegmentToStream(Stream outStream, FileSegment offsetEntry, bool decompress, MemoryMappedFile mf = null)
        {
            var zSize = offsetEntry.ZSize;

            if (mf == null)
            {
                using var fs = new FileStream(ArchiveAbsolutePath, FileMode.Open, FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                mf = MemoryMappedFile.CreateFromFile(fs, null, 0, MemoryMappedFileAccess.ReadWrite,
                    HandleInheritability.None, false);
            }

            using var vs = mf.CreateViewStream((long)offsetEntry.Offset, zSize, MemoryMappedFileAccess.Read);
            if (!decompress)
            {
                vs.CopyTo(outStream);
            }
            else
            {
                var size = offsetEntry.Size;
                vs.DecompressAndCopySegment(outStream, zSize, size);
            }
            vs.Dispose();
        }

        /// <summary>
        /// Extracts a FileSegment from the archive to a stream
        /// </summary>
        /// <param name="outStream"></param>
        /// <param name="offsetEntry"></param>
        /// <param name="decompress"></param>
        private async Task CopyFileSegmentToStreamAsync(Stream outStream, FileSegment offsetEntry, bool decompress, MemoryMappedFile mf = null)
        {
            var zSize = offsetEntry.ZSize;

            if (mf == null)
            {
                await using var fs = new FileStream(ArchiveAbsolutePath, FileMode.Open, FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                mf = MemoryMappedFile.CreateFromFile(fs, null, 0, MemoryMappedFileAccess.ReadWrite,
                    HandleInheritability.None, false);
            }

            await using var vs = mf.CreateViewStream((long)offsetEntry.Offset, zSize, MemoryMappedFileAccess.Read);
            if (!decompress)
            {
                await vs.CopyToAsync(outStream);
            }
            else
            {
                var size = offsetEntry.Size;
                await vs.DecompressAndCopySegmentAsync(outStream, zSize, size);
            }
        }
        #endregion methods
    }
}
