using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

        public byte[] FileStringTable;
        TDynArray<UFileInfo> fileInfoList;
        TDynArray<UFileEntryInfo> fileEntryInfoList;
        TDynArray<UBundleInfo> bundleInfoList;
        List<Int32> Buffers = new List<int>();
        TDynArray<UDirInitInfo> dirInitInfoList;
        TDynArray<UFileInitInfo> fileInitInfoList;
        TDynArray<UHash> hashes;

        public void cwdump(object obj,BinaryReader br)
        {
            Console.WriteLine("Dumping object: " + obj.GetType().Name);
            Console.WriteLine(ObjectDumper.Dump(obj));
            Console.WriteLine("Br is at: " + br.BaseStream.Position + "[0x"+ br.BaseStream.Position.ToString("X") + "] left: " + ((int)br.BaseStream.Length-br.BaseStream.Position) + "[0x" + ((int)br.BaseStream.Length-br.BaseStream.Position).ToString("X") + "]");
            Console.WriteLine();

        }

        public static string ReadCR2WString(BinaryReader br, int len = 0)
        {
            if (br.BaseStream.Position >= br.BaseStream.Length)
                throw new IndexOutOfRangeException();
            string str = null;
            if (len > 0)
            {
                str = Encoding.Default.GetString(br.ReadBytes(len));
            }
            else
            {
                bool shouldread = true;
                while (shouldread)
                {
                    if (br.BaseStream.Position >= br.BaseStream.Length) //mallformed string not closed by '\0' properly
                        throw new IndexOutOfRangeException();
                    var c = br.ReadByte();
                    str += (char)c;
                    shouldread = (c != 0);
                }
            }
            return str;
        }

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
                /*
                 empty line => ""
                <everything>
                empty line => ""
                parts so stuff like 
                bundles\\buffers.bundle is here split 
                by the \\ for the non bundles this is 
                basically if you would 
                do a virtual tree inside the bundles
                one more empty line at the end=> ""
                 */
                FileStringTable = br.ReadBytes(StringTableSize);

                //Read the file infos
                fileInfoList = new TDynArray<UFileInfo>();
                fileInfoList.Deserialize(br);
                

                using (var ms = new MemoryStream(FileStringTable))
                {
                    using (var brr = new BinaryReader(ms))
                    {
                        foreach (var inf in fileInfoList)
                        {
                            brr.BaseStream.Seek(inf.StringTableNameOffset, SeekOrigin.Begin);
                            inf.path = ReadCR2WString(brr);
                        }
                    }
                }

                //Read the file entry infos
                fileEntryInfoList = new TDynArray<UFileEntryInfo>();
                fileEntryInfoList.Deserialize(br);
                
                //Read the Bundle Infos
                bundleInfoList = new TDynArray<UBundleInfo>();
                bundleInfoList.Deserialize(br);

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
                fileInitInfoList.Deserialize(br);

                //Hashes
                hashes = new TDynArray<UHash>();
                hashes.Deserialize(br);

                if(br.BaseStream.Position == br.BaseStream.Length)
                    Console.WriteLine("Succesfully read everything!");
                else
                {
                    Console.WriteLine($"Reader is at {br.BaseStream.Position} bytes. The length of the file is { br.BaseStream.Length} bytes.\n{ br.BaseStream.Length-br.BaseStream.Position} bytes wasn't read.");
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
        public string path;

        public UInt32 StringTableNameOffset;
        public UInt32 PathHash;
        public UInt32 SizeInBundle;
        public UInt32 SizeInMemory;
        public UInt32  FirstEntry;
        public UInt32 CompressionType;
        public UInt32 bufferid;
        public UInt32 hasbuffer;

        public void Deserialize(BinaryReader reader)
        {
            StringTableNameOffset = reader.ReadUInt32();
            PathHash = reader.ReadUInt32();
            SizeInBundle = reader.ReadUInt32();
            SizeInMemory = reader.ReadUInt32();
            FirstEntry = reader.ReadUInt32();
            CompressionType = reader.ReadUInt32();
            bufferid = reader.ReadUInt32();
            hasbuffer = reader.ReadUInt32();
        }

        public void Serialize(BinaryWriter writer)
        {
            
        }
    }

    public class UFileEntryInfo : ISerializable
    {
        public UInt32 FileID;
        public UInt32 BundleID;
        public UInt32 OffsetInBundle;
        public UInt32 SizeInBundle;
        public UInt32 NextEntry;

        public void Deserialize(BinaryReader reader)
        {
            FileID = reader.ReadUInt32();
            BundleID = reader.ReadUInt32();
            OffsetInBundle = reader.ReadUInt32();
            SizeInBundle = reader.ReadUInt32();
            NextEntry = reader.ReadUInt32();
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
        public Int64 Unk2; //Some count thing

        public void Deserialize(BinaryReader reader)
        {
            Hash = reader.ReadInt64();
            Unk2 = reader.ReadInt64();
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
