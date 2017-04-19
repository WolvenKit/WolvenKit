using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WolvenKit.CR2W;

namespace WolvenKit.Cache
{
    public class SoundCache
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
            var version = br.ReadInt32();
            if (version >= 2)
            {
                Unknown1 = br.ReadInt64();
                InfoOffset = br.ReadInt64();
                FileCount = br.ReadInt64();
                NamesOffset = br.ReadInt64();
                NamesSize = br.ReadInt64();
            }
            else
            {
                Unknown1 = br.ReadInt64();
                InfoOffset = br.ReadUInt32();
                FileCount = br.ReadUInt32();
                NamesOffset = br.ReadUInt32();
                NamesSize = br.ReadUInt32();
            }
            //Unknown2 = br.ReadInt64();
            //Unknown3 = br.ReadInt64();
            br.BaseStream.Seek(InfoOffset, SeekOrigin.Begin);
            for (int i = 0; i < FileCount; i++)
            {
                var sf = new SoundFile();
                sf.Info = new SoundFileInfo();
                if (version >= 2)
                {
                    sf.Info.NameOffset = br.ReadInt64();
                    sf.Info.Offset = br.ReadInt64();
                    sf.Info.Size = br.ReadInt64();
                }
                else
                {
                    sf.Info.NameOffset = br.ReadUInt32();
                    sf.Info.Offset = br.ReadUInt32();
                    sf.Info.Size = br.ReadUInt32();
                }
                Files.Add(sf);
            }
            Console.WriteLine("Files:\n");
            foreach (SoundFile t in Files)
            {
                br.BaseStream.Seek(NamesOffset + t.Info.NameOffset, SeekOrigin.Begin);
                t.name = br.ReadCR2WString();
                br.BaseStream.Seek(t.Info.Offset, SeekOrigin.Begin);
                t.Content = br.ReadBytes((int)t.Info.Size);
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
