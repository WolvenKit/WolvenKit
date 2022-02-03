using System.IO;
using CP77Tools.Model;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.CR2W.Archive;
using Index = CP77Tools.Model.Index;

namespace WolvenKit.Common.Services
{
    public static class Red4WriterService /*: IRed4WriterService*/
    {
        public static void WriteDependency(this BinaryWriter bw, Dependency dependency) => bw.Write(dependency.Hash);

        public static void WriteIndex(this BinaryWriter bw, Index index)
        {
            // write the table to a stream to calculate the size
            using var ms = new MemoryStream();
            using var tablewriter = new BinaryWriter(ms);

            index.FileEntryCount = (uint)index.FileEntries.Count;
            index.FileSegmentCount = (uint)index.FileSegments.Count;
            index.ResourceDependencyCount = (uint)index.Dependencies.Count;
            //tablewriter.Write(Crc);
            tablewriter.Write(index.FileEntryCount);
            tablewriter.Write(index.FileSegmentCount);
            tablewriter.Write(index.ResourceDependencyCount);

            foreach (var archiveItem in index.FileEntries)
            {
                tablewriter.WriteFileEntry(archiveItem.Value);
            }

            foreach (var offsetEntry in index.FileSegments)
            {
                tablewriter.WriteFileSegment(offsetEntry);
            }

            foreach (var dependency in index.Dependencies)
            {
                tablewriter.WriteDependency(dependency);
            }

            index.FileTableOffset = 8; //TODO
            bw.Write(index.FileTableOffset);
            bw.Write((uint)ms.Length + 8);
            //crc64 calculate
            bw.Write(Crc64.Compute(tablewriter.BaseStream.ToByteArray()));
            bw.Write(tablewriter.BaseStream.ToByteArray());
        }

        public static void WriteHeader(this BinaryWriter bw, Header header)
        {
            bw.Write(Header.MAGIC);
            bw.Write(header.Version);
            bw.Write(header.IndexPosition);
            bw.Write(header.IndexSize);
            bw.Write(header.DebugPosition);
            bw.Write(header.DebugSize);
            bw.Write(header.Filesize);
        }

        public static void WriteFileSegment(this BinaryWriter bw, FileSegment fileSegment)
        {
            bw.Write(fileSegment.Offset);
            bw.Write(fileSegment.ZSize);
            bw.Write(fileSegment.Size);
        }

        public static void WriteFileEntry(this BinaryWriter bw, FileEntry fileEntry)
        {
            bw.Write(fileEntry.NameHash64);
            bw.Write(fileEntry.Timestamp.ToFileTime());
            bw.Write(fileEntry.NumInlineBufferSegments);
            bw.Write(fileEntry.SegmentsStart);
            bw.Write(fileEntry.SegmentsEnd);
            bw.Write(fileEntry.ResourceDependenciesStart);
            bw.Write(fileEntry.ResourceDependenciesEnd);
            bw.Write(fileEntry.SHA1Hash);
        }
    }
}
