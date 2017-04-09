using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.CR2W;

namespace WolvenKit.Cache
{
    class SoundCache
    {
        public byte[] Magic = { (byte)'C', (byte)'S', (byte)'3', (byte)'W' };
        public long version = 2;
        public Int64 Unknown1;
        public Int64 InfoOffset;
        public Int64 FileCount;
        public Int64 NamesOffset;
        public Int64 NamesSize;
        public Int64 Unknown2;
        public Int64 Unknown3;

        public class SoundFileInfo
        {
            public Int64 NameOffset;
            public Int64 Offset;
            public Int64 Size;
        }

        public class SoundFile
        {
            public SoundFileInfo Info;
            public byte[] Content;
            public string name;
        }

        public SoundCache(string FileName)
        {
            this.Read(new BinaryReader(new FileStream(FileName, FileMode.Open)));
        }

        public List<SoundFile> Files;

        public void Read(BinaryReader br)
        {
            Files = new List<SoundFile>();
            if (!br.ReadBytes(4).SequenceEqual(Magic))
                throw new InvalidDataException("Wrong Magic in soundcache!");
            if (br.ReadInt32() != 2)
                throw new Exception("Invalid soundcache version!");
            Unknown1 = br.ReadInt64();
            Console.WriteLine("Unknown: " + Unknown1);
            InfoOffset = br.ReadInt64();
            Console.WriteLine("Info offset: " + InfoOffset);
            FileCount = br.ReadInt64();
            Console.WriteLine("FilesOffset: " + FileCount);
            NamesOffset = br.ReadInt64();
            Console.WriteLine("NamesOffset: " + NamesOffset);
            NamesSize = br.ReadInt64();
            Console.WriteLine("NamesSize: " + NamesSize);
            Unknown2 = br.ReadInt64();
            Console.WriteLine("Unknown: " + Unknown2);
            Unknown3 = br.ReadInt64();
            Console.WriteLine("Unknown: " + Unknown3);

            br.BaseStream.Seek(InfoOffset, SeekOrigin.Begin);
            for (int i = 0; i < FileCount; i++)
            {
                var sf = new SoundFile();
                sf.Info = new SoundFileInfo();
                sf.Info.NameOffset = br.ReadInt64();
                sf.Info.Offset = br.ReadInt64();
                sf.Info.Size = br.ReadInt64();
                Files.Add(sf);
            }
            Console.WriteLine("Files:\n");
            foreach (SoundFile t in Files)
            {
                br.BaseStream.Seek(NamesOffset + t.Info.NameOffset, SeekOrigin.Begin);
                t.name = br.ReadCR2WString();
                br.BaseStream.Seek(t.Info.Offset, SeekOrigin.Begin);
                t.Content = br.ReadBytes((int)t.Info.Size);
                Console.WriteLine("\t" + t.name + "\tSize: " + t.Info.Size + " bytes");
            }
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(Magic);
            bw.Write(version);
            bw.Write(Unknown1);
            bw.Write(InfoOffset);
            bw.Write(FileCount);
            bw.Write(NamesOffset);
            bw.Write(NamesSize);
            bw.Write(Unknown2);
            bw.Write(Unknown3);
            //TODO: Write file contents and names
        }
    }
}
