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
using WolvenKit.Common.Services;
using CP77.CR2W.Extensions;
using CP77Tools.Model;
using Newtonsoft.Json;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using CP77.CR2W.Types;
using WolvenKit.Common.Oodle;
using Index = CP77Tools.Model.Index;

namespace CP77.CR2W.Archive
{
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

        #endregion

        #region properties
        public EArchiveType TypeName => EArchiveType.Archive;

        public Header Header { get; set; }


        public Index Index { get; set; }


        public string ArchiveAbsolutePath { get; set; }

        [JsonIgnore]
        public Dictionary<ulong, FileEntry> Files => Index?.FileEntries;

        public int FileCount => Files?.Count ?? 0;

        [JsonIgnore]
        public string Name => Path.GetFileName(ArchiveAbsolutePath);
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
            //     _table = new Index(new BinaryReader(vs), this);
            // }

            using var vs = new FileStream(ArchiveAbsolutePath, FileMode.Open, FileAccess.Read);
            Header = new Header(new BinaryReader(vs));
            vs.Seek((long) Header.IndexPosition, SeekOrigin.Begin);
            Index = new Index(new BinaryReader(vs), this);
            vs.Close();
        }

        /// <summary>
        /// Serializes this archive to a redengine .archive file
        /// </summary>
        public void Serialize()
        {




        }


        public bool CanUncook(ulong hash)
        {
            if (!Files.ContainsKey(hash))
                return false;
            var archiveItem = Files[hash]; 
            string name = archiveItem.FileName;
            var hasBuffers = (archiveItem.SegmentsEnd - archiveItem.SegmentsStart) > 1;

            var values = Enum.GetNames(typeof(ECookedFileFormat));
            var b = values.Any(e => e == Path.GetExtension(name)[1..]) || hasBuffers ;
            return b;
        }

        public void CopyFileToStream(Stream stream, ulong hash, bool decompressBuffers)
        {
            if (!Files.ContainsKey(hash)) return;

            var entry = Files[hash];
            var startindex = (int)entry.SegmentsStart;
            var nextindex = (int)entry.SegmentsEnd;

            // decompress main file
            CopyFileSegmentToStream(stream, this.Index.FileSegments[startindex], true);

            // get buffers, optionally decompressing them
            for (int j = startindex + 1; j < nextindex; j++)
            {
                var offsetentry = this.Index.FileSegments[j];
                CopyFileSegmentToStream(stream, offsetentry, decompressBuffers);
            }
        }

        /// <summary>
        /// Extracts a FileSegment to a stream
        /// </summary>
        /// <param name="outstream"></param>
        /// <param name="offsetentry"></param>
        /// <param name="decompress"></param>
        private void CopyFileSegmentToStream(Stream outstream, FileSegment offsetentry, bool decompress)
        {
            using var fs = new FileStream(ArchiveAbsolutePath, FileMode.Open, FileAccess.Read);
            using var br = new BinaryReader(fs);
            br.BaseStream.Seek((long)offsetentry.Offset, SeekOrigin.Begin);


            var zSize = offsetentry.ZSize;
            var size = offsetentry.Size;

            if (!decompress)
            {
                var buffer = br.ReadBytes((int)zSize);
                outstream.Write(buffer);
            }
            else
            {
                br.DecompressBuffer(outstream, zSize, size);
            }
        }


        #endregion


    }


}



