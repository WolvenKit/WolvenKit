using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using CP77Tools.Model;
using ProtoBuf;
using WolvenKit.Common;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using Index = CP77Tools.Model.Index;

namespace WolvenKit.RED4.CR2W.Archive
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
            CopyFileSegmentToStream(stream, this.Index.FileSegments[startIndex], true, mmf);

            // get buffers, optionally decompressing them
            for (var j = startIndex + 1; j < nextIndex; j++)
            {
                var offsetEntry = this.Index.FileSegments[j];
                CopyFileSegmentToStream(stream, offsetEntry, decompressBuffers, mmf);
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

                // no streams


            }
        }

        #endregion methods
    }
}
