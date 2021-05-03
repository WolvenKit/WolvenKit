using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using CP77Tools.Model;
using WolvenKit.Common;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using ZeroFormatter;
using Index = CP77Tools.Model.Index;

namespace WolvenKit.RED4.CR2W.Archive
{
    [ZeroFormattable]
    public class Archive : IGameArchive
    {
        #region constructors

        public Archive()
        {
            Header = new Header();
            Index = new Index();
        }

        /// <summary>
        /// Creates and reads an archive from a path
        /// </summary>
        /// <param name="path"></param>
        public Archive(string path)
        {
            ArchiveAbsolutePath = path;

            ReadTables();
        }

        #endregion constructors

        #region properties

        [Index(0)] public string ArchiveAbsolutePath { get; set; }

        [Index(1)] public Header Header { get; set; }

        [Index(2)] public Index Index { get; set; }



        public Dictionary<ulong, FileEntry> Files => Index?.FileEntries;

        public string Name => Path.GetFileName(ArchiveAbsolutePath);

        public EArchiveType TypeName => EArchiveType.Archive;

        public int FileCount => Files?.Count ?? 0;


        #endregion properties

        #region methods

        public bool CanUncook(ulong hash)
        {
            if (!Files.ContainsKey(hash))
            {
                return false;
            }

            var archiveItem = Files[hash];
            var hasBuffers = (archiveItem.SegmentsEnd - archiveItem.SegmentsStart) > 1;

            var values = Enum.GetNames(typeof(ECookedFileFormat));
            var b = values.Any(e => e == Path.GetExtension(Files[hash].FileName)?[1..]) || hasBuffers;
            return b;
        }

        public void CopyFileToStream(Stream stream, ulong hash, bool decompressBuffers)
        {
            if (!Files.ContainsKey(hash))
            {
                return;
            }

            var entry = Files[hash];
            var startIndex = (int)entry.SegmentsStart;
            var nextIndex = (int)entry.SegmentsEnd;

            // decompress main file
            CopyFileSegmentToStream(stream, this.Index.FileSegments[startIndex], true);

            // get buffers, optionally decompressing them
            for (var j = startIndex + 1; j < nextIndex; j++)
            {
                var offsetEntry = this.Index.FileSegments[j];
                CopyFileSegmentToStream(stream, offsetEntry, decompressBuffers);
            }
        }

        /// <summary>
        /// Serializes this archive to a redengine .archive file
        /// </summary>
        public void Serialize()
        {
        }

        /// <summary>
        /// Extracts a FileSegment from the archive to a stream
        /// </summary>
        /// <param name="outStream"></param>
        /// <param name="offsetEntry"></param>
        /// <param name="decompress"></param>
        private void CopyFileSegmentToStream(Stream outStream, FileSegment offsetEntry, bool decompress)
        {
            var zSize = offsetEntry.ZSize;

            using var fs = new FileStream(ArchiveAbsolutePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite,0x1000, FileOptions.None);
            using var mmf = MemoryMappedFile.CreateFromFile(fs, null, 0, MemoryMappedFileAccess.ReadWrite, HandleInheritability.None, false);
            using var vs = mmf.CreateViewStream((long)offsetEntry.Offset, zSize, MemoryMappedFileAccess.Read);

            if (!decompress)
            {
                vs.CopyTo(outStream);
            }
            else
            {
                var size = offsetEntry.Size;
                vs.DecompressAndCopySegment(outStream, zSize, size);
            }
        }

        /// <summary>
        /// Reads the tables info to the archive.
        /// </summary>
        private void ReadTables()
        {
            using var mmf = MemoryMappedFile.CreateFromFile(ArchiveAbsolutePath, FileMode.Open);

            using (var vs = mmf.CreateViewStream(
                0, Header.SIZE, MemoryMappedFileAccess.Read))
            {
                Header = new Header(new BinaryReader(vs));
            }

            using (var vs = mmf.CreateViewStream(
                (long)Header.IndexPosition, Header.IndexSize, MemoryMappedFileAccess.Read))
            {
                Index = new Index(new BinaryReader(vs), this);
            }
        }

        #endregion methods
    }
}
