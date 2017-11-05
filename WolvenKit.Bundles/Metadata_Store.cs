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
        //public List<FileRecord> FileRecords;
        TDynArray<UFileInfo> fileInfoList;
        TDynArray<UFileEntryInfo> fileEntryInfoList;
        TDynArray<UBundleInfo> bundleInfoList;
        TDynArray<UDirInitInfo> dirInitInfoList;
        TDynArray<UnknownType01> unknownType01List;
        TDynArray<UnknownType02> unknownType02List;
        TDynArray<UnknownType03> unknownType03List;



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
                //Console.WriteLine("\n-----------------------------------\nFile string table:");
                //Console.WriteLine(FileStringTable.Aggregate("", (c, n) => c += "\n" + n));
                //Console.WriteLine("-----------------------------------");

                fileInfoList = new TDynArray<UFileInfo>();
                fileInfoList.Deserialize(br);

                fileEntryInfoList = new TDynArray<UFileEntryInfo>();
                fileEntryInfoList.Deserialize(br);

                bundleInfoList = new TDynArray<UBundleInfo>();
                bundleInfoList.Deserialize(br);

                unknownType01List = new TDynArray<UnknownType01>();
                unknownType01List.Deserialize(br);

                unknownType02List = new TDynArray<UnknownType02>();
                unknownType02List.Deserialize(br);

                dirInitInfoList = new TDynArray<UDirInitInfo>();
                dirInitInfoList.Deserialize(br);

                unknownType03List = new TDynArray<UnknownType03>();
                unknownType03List.Deserialize(br);




                //FileCount = br.ReadInt32() - 1;
                //Console.WriteLine("FileCount: " + FileCount);
                //br.BaseStream.Seek(0x17, SeekOrigin.Current);
                //FileRecords = new List<FileRecord>();
                //for (var i = 0; i < FileCount; i++)
                //{
                //    FileRecords.Add(new FileRecord
                //    {
                //        FilePathLength = br.ReadInt32(),
                //        FileSIzeCompressed = br.ReadInt32(),
                //        FileSize = br.ReadInt32(),
                //        FileIndex = br.ReadInt32(),
                //        CompressionType = br.ReadInt32(),
                //        LastIndex = br.ReadInt32()
                //    });
                //}
                var a = br.BaseStream.Position;
            }
        }

        public void Write(string OutPutPath, params Bundle[] Bundles)
        {
            //TODO: Code this when everything is figured out.
        }
    }

    public class UFileInfo : ISerializable
    {
        public Int32 FilePathLength;
        //4 null bytes
        public Int32 FileSIzeCompressed;
        public Int32 FileSize;
        public Int32 FileIndex;
        public Int32 CompressionType;
        //8 null bytes
        public Int32 LastIndex;

        public void Deserialize(BinaryReader reader)
        {
            this.FilePathLength = reader.ReadInt32();
            this.FileSIzeCompressed = reader.ReadInt32();
            this.FileSize = reader.ReadInt32();
            this.FileIndex = reader.ReadInt32();
            this.CompressionType = reader.ReadInt32();
            this.LastIndex = reader.ReadInt32();
            reader.ReadInt32();
            reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UFileEntryInfo : ISerializable
    {
        public void Deserialize(BinaryReader reader)
        {
            reader.ReadBytes(20);
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
    public class UBundleInfo : ISerializable
    {
        public void Deserialize(BinaryReader reader)
        {
            reader.ReadBytes(24);
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UDirInitInfo : ISerializable
    {
        public void Deserialize(BinaryReader reader)
        {
            reader.ReadBytes(12);
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
    public class UnknownType01 : ISerializable
    {
        public void Deserialize(BinaryReader reader)
        {
            reader.ReadBytes(4);
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UnknownType02 : ISerializable
    {
        public void Deserialize(BinaryReader reader)
        {
            reader.ReadBytes(8);
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UnknownType03 : ISerializable
    {
        public void Deserialize(BinaryReader reader)
        {
            reader.ReadBytes(16);
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
