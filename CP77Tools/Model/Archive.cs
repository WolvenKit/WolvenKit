using CP77Tools.Oodle;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CP77Tools.Model
{
    public class Archive
    {
        public class ArchiveFile
        {
            private Archive _archive;
            private int _key;

            public ArchiveFile(Archive archive, int key)
            {
                _archive = archive;
                RawBytes = new List<byte[]>();
                OffsetEntries = new List<OffsetEntry>();

                _key = key;
            }

            public List<byte[]> RawBytes { get; set; }
            public List<OffsetEntry> OffsetEntries { get; set; }


            public int Name => _key;

            public FileInfoEntry Info => _archive.Table.FileInfo[_key];
        }



        public ArHeader Header { get; set; }
        public uint FilesCount { get; set; }
        public ArTable Table { get; set; }
        public Dictionary<int, ArchiveFile> Files { get; set; }
        
        private string filepath;


        private BinaryReader binaryReader { get; set; }

        public Archive(string path)
        {
            filepath = path;
            binaryReader = new BinaryReader(new FileStream(path, FileMode.Open));
            Header = new ArHeader(binaryReader);
            binaryReader.BaseStream.Seek((long)Header.Tableoffset, SeekOrigin.Begin);
            Table = new ArTable(binaryReader);
            FilesCount = Table.Table1count;
        }

        public byte[] GetFileData(int idx)
        {
            if (idx < Table.FileInfo.Count)
            {
                var entry = Table.FileInfo[idx];
                var startindex = (int)entry.FirstDataSector;
                var nextindex = (int)entry.NextDataSector;

                MemoryStream ms = new MemoryStream();
                BinaryWriter bw = new BinaryWriter(ms);

                for (int j = startindex; j < nextindex; j++)
                {
                    var offsetentry = this.Table.Offsets[idx];
                    binaryReader.BaseStream.Seek((long)offsetentry.Offset, SeekOrigin.Begin);
                    if (offsetentry.PhysicalSize == offsetentry.VirtualSize)
                    {
                        var buffer = binaryReader.ReadBytes((int)offsetentry.PhysicalSize);
                        bw.Write(buffer);
                    }
                    else
                    {
                        var oodleCompression = binaryReader.ReadBytes(4);
                        if (!(oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
                            throw new NotImplementedException();
                        var size = binaryReader.ReadUInt32();

                        if (size != offsetentry.VirtualSize)
                            throw new NotImplementedException();

                        var buffer = binaryReader.ReadBytes((int)offsetentry.PhysicalSize - 8);

                        byte[] unpacked = new byte[offsetentry.VirtualSize];
                        long unpackedSize = OodleLZ.Decompress(buffer, unpacked);
                        if (unpackedSize != offsetentry.VirtualSize)
                            throw new Exception(string.Format("Unpacked size doesn't match real size. {0} vs {1}", unpackedSize, offsetentry.VirtualSize));
                        bw.Write(unpacked);
                    }
                }

                return ms.ToArray();
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DumpInfo()
        {


            // dump chache info
            using (var writer = File.CreateText($"{this.filepath}.info"))
            {
                writer.WriteLine($"Magic: {Header.Magic}\r\n");
                writer.WriteLine($"Version: {Header.Version}\r\n");
                writer.WriteLine($"Tableoffset: {Header.Tableoffset}\r\n");
                writer.WriteLine($"Tablesize: {Header.Tablesize}\r\n");
                writer.WriteLine($"Unk3: {Header.Unk3}\r\n");
                writer.WriteLine($"Filesize: {Header.Filesize}\r\n");
                writer.WriteLine($"Size: {Table.Size}\r\n");
                writer.WriteLine($"Checksum: {Table.Checksum}\r\n");
                writer.WriteLine($"Num: {Table.Num}\r\n");
                writer.WriteLine($"Table1count: {Table.Table1count}\r\n");
                writer.WriteLine($"Table2count: {Table.Table2count}\r\n");
                writer.WriteLine($"Table3count: {Table.Table3count}\r\n");

            }

            const string head = //"Hash\t" +
                                "Hash64," +
                                "Hash32," +
                                "VirtualSize," +
                                "PhysicalSize," +
                                "Unk1," +
                                "Unk2," +
                                "Flags," +
                                "StartDataSector," +
                                "NextDataSector," +
                                "StartUnkSector," +
                                "NextUnkSector," +
                                "Footer,";

            // dump and extract files
            using (var writer = File.CreateText($"{this.filepath}.csv"))
            {
                // write header
                writer.WriteLine(head);

                // write info elements
                foreach (var entry in Table.FileInfo)
                {
                    var x = entry.Value;
                    var idx = entry.Key;

                    int PhysicalSize = 0;
                    int VirtualSize = 0;

                    var startindex = (int)x.FirstDataSector;
                    var nextindex = (int)x.NextDataSector;

                    for (int i = startindex; i < nextindex; i++)
                    {
                        PhysicalSize += (int)Table.Offsets[i].PhysicalSize;
                        VirtualSize += (int)Table.Offsets[i].VirtualSize;
                    }

                    var offsetEntry = Table.Offsets[idx];

                    string info =
                        $"{x.NameHash64:X2}," +
                        $"{x.NameHash32:X2}," +
                        $"{VirtualSize}," +
                        $"{PhysicalSize}," +
                        $"{x.Unk1:X2}," +
                        $"{x.Unk2:X2}," +
                        $"{x.FileFlags}," +
                        $"{x.FirstDataSector}," +
                        $"{x.NextDataSector}," +
                        $"{x.FirstUnkIndex}," +
                        $"{x.NextUnkIndex}," +
                        $"{BitConverter.ToString(x.SHA1Hash)}";

                    writer.WriteLine(info);
                }
            }
        }
    }

    public class ArHeader
    {
        public byte[] Magic { get; set; }
        public uint Version { get; set; }
        public ulong Tableoffset { get; set; }
        public ulong Tablesize { get; set; }
        public ulong Unk3 { get; set; }
        public ulong Filesize { get; set; }

        public ArHeader(BinaryReader br)
        {
            Read(br);
        }

        private void Read(BinaryReader br)
        {
            Magic = br.ReadBytes(4);
            if (!Magic.SequenceEqual(new byte[] { 82, 68, 65, 82 }))
                throw new NotImplementedException();

            Version = br.ReadUInt32();
            Tableoffset = br.ReadUInt64();
            Tablesize = br.ReadUInt64();
            Unk3 = br.ReadUInt64();
            Filesize = br.ReadUInt64();
        }
    }

    public class ArTable
    {
        public uint Num { get; private set; }
        public uint Size { get; private set; }
        public ulong Checksum { get; private set; }
        public uint Table1count { get; private set; }
        public uint Table2count { get; private set; }
        public uint Table3count { get; private set; }
        public Dictionary<int, FileInfoEntry> FileInfo { get; private set; }
        public Dictionary<int, OffsetEntry> Offsets { get; private set; }
        public Dictionary<int, HashEntry> HashTable { get; private set; }

        public ArTable(BinaryReader br)
        {
            Read(br);

            FileInfo = new Dictionary<int, FileInfoEntry>();
            Offsets = new Dictionary<int, OffsetEntry>();
            HashTable = new Dictionary<int, HashEntry>();

            // read tables
            for (int i = 0; i < Table1count; i++)
            {
                FileInfo.Add(i, new FileInfoEntry(br));
            }

            for (int i = 0; i < Table2count; i++)
            {
                Offsets.Add(i, new OffsetEntry(br));
            }

            for (int i = 0; i < Table3count; i++)
            {
                HashTable.Add(i, new HashEntry(br));
            }
        }

        private void Read(BinaryReader br)
        {
            Num = br.ReadUInt32();
            Size = br.ReadUInt32();
            Checksum = br.ReadUInt64();
            Table1count = br.ReadUInt32();
            Table2count = br.ReadUInt32();
            Table3count = br.ReadUInt32();
        }
    }
    public class HashEntry
    {
        public ulong Hash { get; set; }

        public HashEntry(BinaryReader br)
        {
            Read(br);
        }

        private void Read(BinaryReader br)
        {
            Hash = br.ReadUInt64();
        }
    }
    public class OffsetEntry
    {
        public ulong Offset { get; set; }
        public uint PhysicalSize { get; set; }
        public uint VirtualSize { get; set; }

        public OffsetEntry(BinaryReader br)
        {
            Read(br);
        }

        private void Read(BinaryReader br)
        {
            Offset = br.ReadUInt64();
            PhysicalSize = br.ReadUInt32();
            VirtualSize = br.ReadUInt32();
        }
    }

    public class FileInfoEntry
    {
        public ulong NameHash64 { get; private set; }
        public uint NameHash32 { get; private set; }
        public ushort Unk1 { get; private set; } //???? maybe it's really one int32
        public ushort Unk2 { get; private set; } //????
        public uint FileFlags { get; private set; }
        public uint FirstDataSector { get; private set; }
        public uint NextDataSector { get; private set; }
        public uint FirstUnkIndex { get; private set; }
        public uint NextUnkIndex { get; private set; }
        public byte[] SHA1Hash { get; set; }

        public FileInfoEntry(BinaryReader br)
        {
            Read(br);
        }

        private void Read(BinaryReader br)
        {
            NameHash64 = br.ReadUInt64();
            NameHash32 = br.ReadUInt32();
            Unk1 = br.ReadUInt16();
            Unk2 = br.ReadUInt16();

            FileFlags = br.ReadUInt32();
            FirstDataSector = br.ReadUInt32();
            NextDataSector = br.ReadUInt32();
            FirstUnkIndex = br.ReadUInt32();
            NextUnkIndex = br.ReadUInt32();

            SHA1Hash = br.ReadBytes(20);
        }
    }
}



