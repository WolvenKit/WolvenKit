using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WolvenKit.Bundles
{
    /// <summary>
    /// This game file at the root of the witcher3 content/ folder is used extensively by wcc_lite.
    /// It is used to keep track of archived files and to control their integrity.
    /// </summary>
    public class Metadata_Store : ICsvSerializable
    {
        #region Info
        public byte[] IDString = { 0x03, 0x56, 0x54, 0x4D }; // ".VTM"
        public Int32 Version = 6;
        public Int32 MaxFileSizeInBundle;
        public Int32 MaxFileSizeInMemory;
        public Int32 StringTableSize;

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
                str = Encoding.GetEncoding("ISO-8859-1").GetString(br.ReadBytes(len));
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
                MaxFileSizeInMemory = br.ReadInt32();
                StringTableSize = br.ReadVLQInt32();
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
                
                //Read the Archive Infos
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
                {
                    Console.WriteLine("Succesfully read everything!");

                }
                else
                {
                    Console.WriteLine($"Reader is at {br.BaseStream.Position} bytes. The length of the file is { br.BaseStream.Length} bytes.\n{ br.BaseStream.Length-br.BaseStream.Position} bytes wasn't read.");
                }
            }
        }

        public void SerializeToCsv(StreamWriter writer)
        {
            //Header
            writer.WriteLine("Header :");
            writer.WriteLine(new string('-', 80));
            writer.WriteLine("\"Version\";\"MaxFileSizeInBundle\";\"MaxFileSizeInMemory\";\"StringTableSize\"");
            writer.WriteLine(Version + ";" + MaxFileSizeInBundle + ";" + MaxFileSizeInMemory + ";" + StringTableSize);
            writer.WriteLine(new string('-', 80));
            writer.WriteLine(Environment.NewLine);
            writer.WriteLine(Environment.NewLine);

            //FileStringTable
            writer.WriteLine("FileStringTable :");
            writer.WriteLine(new string('-', 80));
            writer.WriteLine("\"StringTableNameByteOffset\";\"AbsolutePhysicalPath(archive)/AbsoluteVirtualPath(archived file)\"");
            StringBuilder filepathbuffer = new StringBuilder();
            UInt32 bytecount = 0;
            UInt32 offsetbuffer = 0;
            foreach (var abyte in FileStringTable)
            {
                if (abyte.Equals(0x00))
                {
                    writer.WriteLine(offsetbuffer + ";\"" + filepathbuffer.ToString() + "\"");
                    filepathbuffer.Clear();
                    offsetbuffer = bytecount + 1;
                }
                else
                {
                    filepathbuffer.Append(Encoding.ASCII.GetString(new[] { abyte }));
                }
                bytecount++;
            }
            writer.WriteLine(new string('-', 80));
            writer.WriteLine(Environment.NewLine);
            writer.WriteLine(Environment.NewLine);

            //FileInfoList
            writer.WriteLine("FileInfoList :");
            writer.WriteLine(new string('-', 80));
            writer.WriteLine("\"StringTableNameByteOffset\";\"PathHash\";\"SizeInBundle\";\"SizeInMemory\";\"FirstEntry\";\"CompressionType\";\"BufferID\";\"HasBuffer\"");

            foreach(var ufi in fileInfoList)
                writer.WriteLine(ufi.StringTableNameOffset + ";" + ufi.PathHash + ";" + ufi.SizeInBundle + ";" + ufi.SizeInMemory + ";" + ufi.FirstEntry + ";" + ufi.CompressionType + ";" + ufi.bufferid + ";" + ufi.hasbuffer);

            writer.WriteLine(new string('-', 80));
            writer.WriteLine(Environment.NewLine);
            writer.WriteLine(Environment.NewLine);

            //FileEntryInfoList
            writer.WriteLine("FileEntryInfoList :");
            writer.WriteLine(new string('-', 80));
            writer.WriteLine("\"FileID\";\"BundleID\";\"OffsetInBundle\";\"SizeInBundle\";\"NextEntry\"");
            foreach (var feil in fileEntryInfoList)
                writer.WriteLine(feil.FileID + ";" + feil.BundleID + ";" + feil.OffsetInBundle + ";" + feil.SizeInBundle + ";" + feil.NextEntry);
            writer.WriteLine(new string('-', 80));
            writer.WriteLine(Environment.NewLine);
            writer.WriteLine(Environment.NewLine);


            //BundleInfoList
            writer.WriteLine("BundleInfoList :");
            writer.WriteLine(new string('-', 80));
            writer.WriteLine("\"Name\";\"FirstFileEntry\";\"NumBundleEntries\";\"DataBlockSize\";\"DataBlockOffset\";\"BurstDataBlockSize\"");
            foreach (var bil in bundleInfoList)
                writer.WriteLine(bil.Name + ";" + bil.FirstFileEntry + ";" + bil.NumBundleEntries + ";" + bil.DataBlockSize + ";" + bil.DataBlockOffset + ";" + bil.BurstDataBlockSize);
            writer.WriteLine(new string('-', 80));
            writer.WriteLine(Environment.NewLine);
            writer.WriteLine(Environment.NewLine);

            //Buffers
            writer.WriteLine("Buffers :");
            writer.WriteLine(new string('-', 80));
            writer.WriteLine("\"Buffers\"");
            foreach (var b in Buffers)
                writer.WriteLine(b);
            writer.WriteLine(new string('-', 80));
            writer.WriteLine(Environment.NewLine);
            writer.WriteLine(Environment.NewLine);

            //DirInitInfoList
            writer.WriteLine("DirInitInfoList :");
            writer.WriteLine(new string('-', 80));
            writer.WriteLine("\"Name\";\"Parent\"");
            foreach (var diil in dirInitInfoList)
                writer.WriteLine(diil.Name + ";" + diil.Parent);
            writer.WriteLine(new string('-', 80));
            writer.WriteLine(Environment.NewLine);
            writer.WriteLine(Environment.NewLine);

            //Hashes
            writer.WriteLine("Hashes :");
            writer.WriteLine(new string('-', 80));
            writer.WriteLine("\"Hash\";\"Unk2\"");
            foreach (var h in hashes)
                writer.WriteLine(h.Hash+ ";" + h.Unk2);


            Console.WriteLine("Succesfully wrote csv dump!");
        }

        public void DeserializeFromCsv(StreamReader reader)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
