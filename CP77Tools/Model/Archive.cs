using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CP77Tools.Oodle;

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
        public ArTable Table { get; set; }
        public Dictionary<int, ArchiveFile> Files { get; set; }
        
        private string filepath;

        public Archive(string path)
        {
            filepath = path;
            Files = new Dictionary<int, ArchiveFile>();

            using var br = new BinaryReader(new FileStream(path, FileMode.Open));
            Read(br);
        }


        private void Read(BinaryReader br)
        {
            Header = new ArHeader(br);

            br.BaseStream.Seek((long)Header.Tableoffset, SeekOrigin.Begin);

            Table = new ArTable(br);

            // read files
            foreach (var (key, value) in Table.FileInfo)
            {
                var entry = new ArchiveFile(this, key);
                // get file offsets
                var startindex = (int)value.startindex;
                var nextindex = (int)value.endindex;

                for (int j = startindex; j < nextindex; j++)
                {
                    var offsetentry = this.Table.Offsets[j];
                    entry.OffsetEntries.Add(offsetentry);

                    br.BaseStream.Seek((long)offsetentry.Offset, SeekOrigin.Begin);

                    // not compressed
                    if (offsetentry.Size == offsetentry.Zsize)
                    {
                        var buffer = br.ReadBytes((int)offsetentry.Zsize);
                        entry.RawBytes.Add(buffer);
                    }
                    else
                    {
                        // read the first 8 bytes
                        var oodleCompression = br.ReadBytes(4);
                        if (!(oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
                            throw new NotImplementedException();
                        var size = br.ReadUInt32();

                        if (size != offsetentry.Size)
                            throw new NotImplementedException();

                        var buffer = br.ReadBytes((int)offsetentry.Zsize - 8);
                        entry.RawBytes.Add(buffer);
                    }
                }
                Files.Add(key, entry);
            }

            //foreach (var entry in Table.Offsets)
            //{
            //    br.BaseStream.Seek((long)entry.Value.Offset + 8, SeekOrigin.Begin);
            //    var buffer = br.ReadBytes((int)entry.Value.Zsize - 8);
            //    Files.Add(buffer);
            //}
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

            const string head = "Hash\t" +
                                "Offset\t" +
                                "Size\t" +
                                "Zsize\t" +
                                "Header\t" +
                                "somebool\t" +
                                "startindex\t" +
                                "endindex\t" +
                                "unk1\t" +
                                "unk2\t" +
                                "Footer\t"
                                ;

            // dump and extract files
            using (var writer = File.CreateText($"{this.filepath}.txt"))
            {
                // write header
                writer.WriteLine(head);

                // write info elements
                foreach (var entry in Table.FileInfo)
                {
                    var x = entry.Value;
                    var idx = entry.Key;

                    var offsetEntry = Table.Offsets[idx];
                    

                    //string ext = x.Name.Split('.').Last();

                    string info =
                        $"{offsetEntry.Offset}\t" +
                        $"{offsetEntry.Size}\t" +
                        $"{offsetEntry.Zsize}\t" +
                        $"{x.Hash}\t" +
                        $"{BitConverter.ToString(x.Header)}\t" +
                        $"{x.flag}\t" +
                        $"{x.startindex}\t" +
                        $"{x.endindex}\t" +
                        $"{x.unk1}\t" +
                        $"{x.unk2}\t" +
                        $"{BitConverter.ToString(x.Footer)}\t"

                        ;
                    
                    writer.WriteLine(info);
                }
            }
        }

        public void Extract(DirectoryInfo outdir)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var oodle = Path.Combine(dir, "oo2core_8_win64.dll");
            if (!File.Exists(oodle))
            {
                Console.WriteLine("oo2core_8_win64.dll not found. Please add it to the base directory of the CP77Tools.");
                return;
            }

            foreach (var (key, value) in Files)
            {
                using var ms = new MemoryStream();
                using var bw = new BinaryWriter(ms);

                // go through all chunks
                for (int i = 0; i < value.RawBytes.Count; i++)
                {
                    var file = value.RawBytes[i];
                    var size = value.OffsetEntries[i].Size;     // extracted size
                    var zsize = value.OffsetEntries[i].Zsize;   // compressed size

                    // not compressed
                    if (size == zsize)
                    {
                        bw.Write(file);
                    }
                    else
                    {
                        var decompressedBuffer = new byte[size];
                        int decompressedCount = OodleHelper.OodleLZ_Decompress(file, file.Length, decompressedBuffer, size
                            , 0, 0, 0, 0, 0, 0, 0, 0, 0, 3);

                        if (decompressedCount != decompressedBuffer.Length)
                            throw new NotImplementedException();

                        bw.Write(decompressedBuffer);
                    }
                }


                // write
                string outpath = Path.Combine(outdir.FullName, $"extractedfile_{key}.bin");
                File.WriteAllBytesAsync(outpath, ms.ToArray());
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
            if (!(Magic.SequenceEqual(new byte[] { 82, 68, 65, 82 })))
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
        public uint Zsize { get; set; }
        public uint Size { get; set; }

        public OffsetEntry(BinaryReader br)
        {
            Read(br);
        }

        private void Read(BinaryReader br)
        {
            Offset = br.ReadUInt64();
            Zsize = br.ReadUInt32();
            Size = br.ReadUInt32();
        }
    }

    public class FileInfoEntry
    {
        public ulong Hash { get; set; }
        public byte[] Header { get; set; }
        public uint flag { get; private set; }
        public uint startindex { get; private set; }
        public uint endindex { get; private set; }
        public uint unk1 { get; private set; }
        public uint unk2 { get; private set; }

        public byte[] Footer { get; set; }

        public FileInfoEntry(BinaryReader br)
        {
            Read(br);
        }

        private void Read(BinaryReader br)
        {
            Hash = br.ReadUInt64();
            Header = br.ReadBytes(8);

            flag = br.ReadUInt32();
            startindex = br.ReadUInt32();
            endindex = br.ReadUInt32();
            unk1 = br.ReadUInt32();
            unk2 = br.ReadUInt32();

            Footer = br.ReadBytes(20);
        }
    }
}



