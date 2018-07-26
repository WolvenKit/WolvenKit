using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WolvenKit.W3Strings;

namespace WolvenKit.Bundles
{
    public class Metadata_Store
    {
        #region Info
        public byte[] IDString = { 0x03, 0x56, 0x54, 0x4D }; // ".VTM"
        public Int32 Version = 6;
        public Int32 MaxFileSizeInBundle;
        public Int32 MaxFileSIzeInMemory;
        #endregion

        public List<string> FileStringTable;
        TDynArray<UFileInfo> fileInfoList;
        TDynArray<UFileEntryInfo> fileEntryInfoList;
        TDynArray<UBundleInfo> bundleInfoList;
        List<Int32> Buffers = new List<int>();
        TDynArray<UDirInitInfo> dirInitInfoList;
        TDynArray<UFileInitInfo> fileInitInfoList;
        TDynArray<UHash> hashes;




        public Metadata_Store(string filepath)
        {
            Console.WriteLine("Reading: " + filepath);
            using (var br = new BinaryReader(new FileStream(filepath, FileMode.Open)))
            {
                if (!br.ReadBytes(4).SequenceEqual(IDString))
                    throw new InvalidDataException("Wrong Magic when reading the metadata.store file!");
                Version = br.ReadInt32();
                MaxFileSizeInBundle = br.ReadInt32();
                MaxFileSIzeInMemory = br.ReadInt32();
                var StringTableSize = br.ReadVLQInt32();

                //Read the string table
                FileStringTable = new string(br.ReadChars(StringTableSize)).Split('\0').ToList();

                //Read the Bundle Infos
                bundleInfoList = new TDynArray<UBundleInfo>();
                bundleInfoList.Deserialize(br);

                //Read the file infos
                fileInfoList = new TDynArray<UFileInfo>();
                fileInfoList.Deserialize(br);

                //Read the file entry infos
                fileEntryInfoList = new TDynArray<UFileEntryInfo>();
                fileEntryInfoList.Deserialize(br);

                //Read the buffers
                var buffercount = br.ReadVLQInt32();
                if (buffercount > 0)
                {
                    for (int i = 0;i < buffercount;i++)
                    {
                        Buffers.Add(br.ReadInt32());
                    }
                }
         
                //Read dir initialization infos
                dirInitInfoList = new TDynArray<UDirInitInfo>();
                dirInitInfoList.Deserialize(br);

                //File initialization infos
                fileInitInfoList = new TDynArray<UFileInitInfo>();
                fileInfoList.Deserialize(br);

                //Hashes
                hashes = new TDynArray<UHash>();
                hashes.Deserialize(br);

                if(br.BaseStream.Position == br.BaseStream.Length)
                    Console.WriteLine("Succesfully read everything!");
                else
                {
                    Console.WriteLine($"Reader is at {br.BaseStream.Position}bytes. The length of the file is { br.BaseStream.Length} bytes.\n{ br.BaseStream.Length-br.BaseStream.Position} bytes wasn't read.");
                }
            }
        }

        public void Write(string OutPutPath, params Bundle[] Bundles)
        {
            //TODO: Code this when everything is figured out.
        }
    }

    public class UBundleInfo : ISerializable
    {
        public UInt32 Name;
        public UInt32 FirstFileEntry;
        public UInt32 NumBundleEntries;
        public UInt32 DataBlockSize;
        public UInt32 DataBlockOffset;
        public UInt32 BurstDataBlockSize;

        public void Deserialize(BinaryReader reader)
        {
            Name = reader.ReadUInt32();
            FirstFileEntry = reader.ReadUInt32();
            NumBundleEntries = reader.ReadUInt32();
            DataBlockSize = reader.ReadUInt32();
            DataBlockOffset = reader.ReadUInt32();
            BurstDataBlockSize = reader.ReadUInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UFileInfo : ISerializable
    {
        public UInt32 Name;
        public UInt32 PathHash;
        public UInt32 SizeInBundle;
        public UInt32 SizeInMemory;
        public UInt32  FirstEntry;
        public byte CompressionType;
        public byte NumEntries;
        public int _bf28;

        public void Deserialize(BinaryReader reader)
        {
            Name = reader.ReadUInt32();
            PathHash = reader.ReadUInt32();
            SizeInBundle = reader.ReadUInt32();
            SizeInMemory = reader.ReadUInt32();
            FirstEntry = reader.ReadUInt32();
            CompressionType = reader.ReadByte();
            NumEntries = reader.ReadByte();
            reader.BaseStream.Seek(6, SeekOrigin.Current); //GAP
        }

        public void Serialize(BinaryWriter writer)
        {
            
        }
    }

    public class UFileEntryInfo : ISerializable
    {
        public Int32 FileID;
        public Int16 BundleID;
        public Int32 OffsetInBundle;
        public Int32 SizeInBundle;
        public Int32 NextEntry;

        public void Deserialize(BinaryReader reader)
        {
            FileID = reader.ReadInt32();
            BundleID = reader.ReadInt16();
            OffsetInBundle = reader.ReadInt32();
            SizeInBundle = reader.ReadInt32();
            NextEntry = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UDirInitInfo : ISerializable
    {
        public Int32 Name;
        public Int32 Parent;

        public void Deserialize(BinaryReader reader)
        {
            Name = reader.ReadInt32();
            Parent = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UFileInitInfo : ISerializable
    {
        public Int32 FileIF;
        public Int32 DirID;
        public Int32 Name;

        public void Deserialize(BinaryReader reader)
        {
            FileIF = reader.ReadInt32();
            DirID = reader.ReadInt32();
            Name = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }

    public class UHash : ISerializable
    {
        public Int64 Hash;
        public Int32 Unk2;

        public void Deserialize(BinaryReader reader)
        {
            Hash = reader.ReadInt64();
            Unk2 = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
