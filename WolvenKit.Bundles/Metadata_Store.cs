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
                var StringTableSize = br.ReadBit6().value;


                FileStringTable = new string(br.ReadChars(StringTableSize)).Split('\0').ToList();

                fileInfoList = new TDynArray<UFileInfo>();
                fileInfoList.Deserialize(br);

                fileEntryInfoList = new TDynArray<UFileEntryInfo>();
                fileEntryInfoList.Deserialize(br);

                bundleInfoList = new TDynArray<UBundleInfo>();
                bundleInfoList.Deserialize(br);

                var buffercount = br.ReadBit6();
                for (int i = 0;i < buffercount.value;i++)
                {
                    Buffers.Add(br.ReadInt32());
                }

                dirInitInfoList = new TDynArray<UDirInitInfo>();
                dirInitInfoList.Deserialize(br);

                fileInitInfoList = new TDynArray<UFileInitInfo>();
                fileInfoList.Deserialize(br);

                hashes = new TDynArray<UHash>();
                hashes.Deserialize(br);

                if(br.BaseStream.Position == br.BaseStream.Length)
                    MessageBox.Show("Succesfully read everything!");
            }
        }

        public void Write(string OutPutPath, params Bundle[] Bundles)
        {
            //TODO: Code this when everything is figured out.
        }
    }

    public class UFileInfo : ISerializable
    {
        public Int32 Name;
        public Int32 PathHash;
        public Int32 SizeInBundle;
        public Int32 SizeInMemory;
        public byte  FirstEntry;
        public Int32 CompressionType;
        public Int32 NumEntries;

        public void Deserialize(BinaryReader reader)
        {
            Name = reader.ReadInt32();
            PathHash = reader.ReadInt32();
            SizeInBundle = reader.ReadInt32();
            SizeInMemory = reader.ReadInt32();
            FirstEntry = reader.ReadByte();
            CompressionType = reader.ReadInt32();
            NumEntries = reader.ReadInt32();
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
    public class UBundleInfo : ISerializable
    {
        public Int32 Name;
        public Int32 FirstFileEntry;
        public Int32 NumBundleEntries;
        public Int32 DataBlockSize;
        public Int32 DataBlockOffset;
        public Int32 BurstDataBlockSize;

        public void Deserialize(BinaryReader reader)
        {
            Name = reader.ReadInt32();
            FirstFileEntry = reader.ReadInt32();
            NumBundleEntries = reader.ReadInt32();
            DataBlockSize = reader.ReadInt32();
            DataBlockOffset = reader.ReadInt32();
            BurstDataBlockSize = reader.ReadInt32();
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
        public Int32 Unk1;
        public Int32 Unk2;

        public void Deserialize(BinaryReader reader)
        {
            Hash = reader.ReadInt64();
            Unk1 = reader.ReadInt32();
            Unk2 = reader.ReadInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
