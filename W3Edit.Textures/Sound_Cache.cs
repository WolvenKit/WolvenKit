using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.CR2W;

namespace WolvenKit.Textures
{
    public class Soundfile
    {
        public string Name;
        public long NameOffset;
        public byte[] Content;
        public long ContentOffset;

    }
    public class SoundCache
    {
        public static uint Version;
        public static uint InfoOffset;
        public static uint FilesSize;
        public static uint NamesOffset;
        public static uint NamesSize;

        public List<Soundfile> Files = new List<Soundfile>(); 


        public static void Read(string file)
        {
            using (var br = new BinaryReader(new FileStream(file, FileMode.Open)))
            {
                Console.WriteLine("Magic: " + new string(br.ReadBytes(4).Select(x=>(char)x).ToArray()));
                Version = br.ReadUInt32();
                Console.WriteLine("Version: " + Version.ToString("x8"));
                var dummy = br.ReadUInt64();
                if (Version >= 2)
                {
                    InfoOffset = (uint)br.ReadUInt64();
                    FilesSize = (uint)br.ReadUInt64();
                    NamesOffset = (uint)br.ReadUInt64();
                    NamesSize = (uint)br.ReadUInt64();
                }
                else
                {
                    InfoOffset = br.ReadUInt32();
                    FilesSize = br.ReadUInt32();
                    NamesOffset = br.ReadUInt32();
                    NamesSize = br.ReadUInt32();
                }
                br.BaseStream.Seek(NamesOffset, SeekOrigin.Begin);
                var names = br.ReadBytes((int)NamesSize);
                
                Console.WriteLine("Version: " + Version);
                Console.WriteLine("Info offset: " + InfoOffset + "\nFile count: " + FilesSize + "\nName offset: " + NamesOffset);
                br.BaseStream.Seek((int)InfoOffset, SeekOrigin.Begin);
                for (var i = 0; i < (int)FilesSize; i++)
                {
                    var tempfile = new Soundfile();
                    long nameOff = BitConverter.ToUInt32(br.ReadBytes(8), 0);
                    long offset = BitConverter.ToUInt32(br.ReadBytes(8), 0);
                    br.ReadUInt32(); BitConverter.ToUInt32(br.ReadBytes(8), 0);
                    br.BaseStream.Seek(nameOff, SeekOrigin.Begin);
                    tempfile.NameOffset = offset;
                    tempfile.Name = br.ReadCR2WString();
                    br.BaseStream.Seek(offset, SeekOrigin.Begin);
                    Console.WriteLine("File: " + tempfile.Name);
                }


            }
        }

        public static void Write()
        {
            
        }
    }
}
