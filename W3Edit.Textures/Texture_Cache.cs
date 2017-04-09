using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Edit.CR2W;

namespace W3Edit.Textures
{
    class Texture_Cache
    {
        public static void Read(string filepath)
        {
            using (var br = new BinaryReader(new FileStream(filepath, FileMode.Open)))
            {
                br.BaseStream.Seek(-20, SeekOrigin.End);
                var texturenum = br.ReadUInt32();
                var namesBlock = br.ReadUInt32(); //block2
                var chunksBlock = br.ReadUInt32(); //block1
                var idString = br.ReadUInt32();
                var version = br.ReadUInt32();
                Console.WriteLine("Number of textures: " + texturenum);
                Console.WriteLine("Names block offset: " + namesBlock);
                Console.WriteLine("Chunk block offset: " + chunksBlock);
                Console.WriteLine("IDString: " + idString);
                Console.WriteLine("Version: " + version);
                Console.Title = "Texture cache: " + Path.GetFileName(filepath) + " with " + texturenum + " files!";
                var jmp = -(20 + 12 + (texturenum * 52) + namesBlock + (chunksBlock * 4));
                Console.WriteLine("JUMP: " + jmp);
                br.BaseStream.Seek(jmp, SeekOrigin.End);
                var chunkoffsets = new List<uint>();
                Console.WriteLine("Reading chunk offsets...");
                Console.WriteLine("Reading " + chunksBlock + " chunks");
                for (var i = 0; i < chunksBlock; i++)
                {
                    chunkoffsets.Add(br.ReadUInt32());
                }
                Console.WriteLine("Reading file names...");
                var names = new List<string>();
                Console.WriteLine("Position: " + br.BaseStream.Position);
                Console.WriteLine("Reading " + texturenum + " strings");
                Console.ReadKey();
                for (var i = 0; i < texturenum; i++)
                {
                    names.Add(br.ReadCR2WString());
                    Console.WriteLine("[" + i + 1 + "]: " + names.Last());
                }
                Console.WriteLine("Reading file details...");
                for (int i = 0; i < texturenum; i++)
                {
                    br.ReadBytes(4);    //number (unique???)
                    br.ReadUInt32();    //filename, start offset in block2
                    br.ReadUInt32();    //* 4096 = start offset, first chunk
                    br.ReadUInt32();    //packed size (all chunks)
                    br.ReadUInt32();    //unpacked size
                    br.ReadUInt32();    //bpp? always 16
                    br.ReadUInt16();    //width
                    br.ReadUInt16();    //height
                    br.ReadUInt16();    //mips
                    br.ReadUInt16();    //1/6/N, single, cubemaps, arrays
                    br.ReadUInt32();    //offset in block1, second packed chunk
                    br.ReadUInt32();    //the number of remaining packed chunks
                    br.ReadBytes(4);    //???
                    br.ReadBytes(4);    //???
                    br.ReadByte();      //0-RGBA?, 7-DXT1, 8-DXT5, 10-???, 13-DXT3, 14-ATI1, 15-???, 253-???
                    br.ReadByte();      //3-cubemaps, 4-texture
                    br.ReadUInt16();    //0/1 ???
                }

                for (var i = 0; i < 3; i++)
                {
                    br.ReadBytes(4);
                }

                //TODO: Once the xbm converter is fixed add it here!
            }
        }

        public static void Write(BinaryWriter bw)
        {
            //TODO: Finish this!
        }
    }
}
