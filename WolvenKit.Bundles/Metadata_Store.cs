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
                Console.WriteLine("\n-----------------------------------\nFile string table:");
                Console.WriteLine(FileStringTable.Aggregate("", (c, n) => c += "\n" + n));
                Console.WriteLine("-----------------------------------");

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
        public Int32 FileSIzeCompressed;
        public Int32 FileSize;
        public Int32 FileIndex;
        public Int32 CompressionType;
        public Int32 LastIndex;

        public string Compression
        {
            get
            {
                switch (CompressionType)
                {
                    case 0:
                        return "None";
                    case 1:
                        return "Zlib";
                    case 2:
                        return "Snappy";
                    case 3:
                        return "Doboz";
                    case 4:
                        return "Lz4";
                    case 5:
                        return "Lz4";
                    default:
                        return "Unknown";
                }
            }
        }

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
        public Int32 Unk1;
        public Int32 Unk2;
        public Int32 Unk3;
        public Int32 Unk4;
        public Int32 Unk5;
        

        public void Deserialize(BinaryReader reader)
        {
            Unk1 = reader.ReadInt32();
            Unk2 = reader.ReadInt32();
            Unk3 = reader.ReadInt32();
            Unk4 = reader.ReadInt32();
            Unk5 = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
    public class UBundleInfo : ISerializable
    {
        public Int32 Unk1;
        public Int32 Unk2;
        public Int32 Unk3;
        public Int32 Unk4;
        public Int32 Unk5;
        public Int32 Unk6;

        public void Deserialize(BinaryReader reader)
        {
            Unk1 = reader.ReadInt32();
            Unk2 = reader.ReadInt32();
            Unk3 = reader.ReadInt32();
            Unk4 = reader.ReadInt32();
            Unk5 = reader.ReadInt32();
            Unk6 = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UDirInitInfo : ISerializable
    {
        public Int32 Unk1;
        public Int32 Unk2;
        public Int32 Unk3;

        public void Deserialize(BinaryReader reader)
        {
            Unk1 = reader.ReadInt32();
            Unk2 = reader.ReadInt32();
            Unk3 = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
    public class UnknownType01 : ISerializable
    {
        public Int32 Unk1;

        public void Deserialize(BinaryReader reader)
        {
            Unk1 = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UnknownType02 : ISerializable
    {
        public Int32 Unk1;
        public Int32 Unk2;

        public void Deserialize(BinaryReader reader)
        {
            Unk1 = reader.ReadInt32();
            Unk2 = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UnknownType03 : ISerializable
    {
        public Int32 Unk1;
        public Int32 Unk2;
        public Int32 Unk3;
        public Int32 Unk4;

        public void Deserialize(BinaryReader reader)
        {
            Unk1 = reader.ReadInt32();
            Unk2 = reader.ReadInt32();
            Unk3 = reader.ReadInt32();
            Unk4 = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
