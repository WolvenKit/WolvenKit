using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.W3Strings;

namespace WolvenKit.Bundles
{
    public class Metadata_Store
    {
        public byte[] Magic = { 0x03, 0x56, 0x54, 0x4D }; // ".VTM"
        public Int32 Version = 6;
        public Int32 BiggestFileSizeCompressed;
        public Int32 BiggestFileSize;
        public Int32 StringTableSize;
        public List<string> FileStringTable;
        public Int32 FileCount;
        public List<FileRecord> FileRecords;



        public Metadata_Store(string filepath)
        {
            Console.WriteLine("Reading: " + filepath);
            using (var br = new BinaryReader(new FileStream(filepath, FileMode.Open)))
            {
                if (!br.ReadBytes(4).SequenceEqual(Magic))
                    throw new InvalidDataException("Wrong Magic when reading the metadata.store file!");
                Version = br.ReadInt32();
                Console.WriteLine("Version: " + Version);
                BiggestFileSizeCompressed = br.ReadInt32();
                Console.WriteLine("BiggestFileSizeCompressed: " + BiggestFileSizeCompressed);
                BiggestFileSize = br.ReadInt32();
                Console.WriteLine("BiggestFileSize: " + BiggestFileSize);
                StringTableSize = br.ReadBit6().value;
                Console.WriteLine("String table size: " + StringTableSize);
                FileStringTable = new string(br.ReadChars(StringTableSize)).Split('\0').ToList();
                Console.WriteLine("\n-----------------------------------\nFile string table:");
                Console.WriteLine(FileStringTable.Aggregate("", (c, n) => c += "\n" + n));
                Console.WriteLine("-----------------------------------");
                FileCount = br.ReadInt32() - 1;
                Console.WriteLine("FileCount: " + FileCount);
                br.BaseStream.Seek(0x17, SeekOrigin.Current);
                FileRecords = new List<FileRecord>();
                for (var i = 0; i < FileCount; i++)
                {
                    FileRecords.Add(new FileRecord
                    {
                        FilePathLength = br.ReadInt32(),
                        FileSIzeCompressed = br.ReadInt32(),
                        FileSize = br.ReadInt32(),
                        FileIndex = br.ReadInt32(),
                        CompressionType = br.ReadInt32(),
                        LastIndex = br.ReadInt32()
                    });
                }
                var a = br.BaseStream.Position;
            }
        }

        public void Write(string OutPutPath, params Bundle[] Bundles)
        {
            //TODO: Code this when everything is figured out.
        }

    }

    public class FileRecord
    {
        public Int32 FilePathLength;
        //4 null bytes
        public Int32 FileSIzeCompressed;
        public Int32 FileSize;
        public Int32 FileIndex;
        public Int32 CompressionType;
        //8 null bytes
        public Int32 LastIndex;
    }
}
