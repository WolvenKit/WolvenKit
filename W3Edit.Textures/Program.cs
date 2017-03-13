using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W3Edit.CR2W;

namespace W3Edit.Textures
{
    //TEXTURE.CACHE HCXT + INT32(VERSION?) AT THE END
    //SOUNDPC.CACHE CS3W AT THE START
    //STATICSHADER.CACHE,SHADER.CACHE  RDHS + INT32(VERSION?) AT THE END
    //COLLISION.CACHE CC3W AT THE START
    //FURSHADER.CACHE?
    internal class Program
    {
        public static byte[] TextureIdString = { (byte)'H', (byte)'C', (byte)'X', (byte)'T' };
        public static byte[] SoundIdString = { (byte)'C', (byte)'S', (byte)'3', (byte)'W' };
        public static byte[] ShaderIdString = { (byte)'R', (byte)'D', (byte)'H', (byte)'S' };
        public static byte[] CollisionIdString = { (byte)'C', (byte)'C', (byte)'3', (byte)'W' };
        public static byte[] DepIdString = { (byte)'S', (byte)'P', (byte)'E', (byte)'D' };

        public enum Cachetype
        {
            Texture,
            Sound,
            Shader,
            Collision,
            Dep,
            Unknown
        }

        [STAThread]
        private static void Main(string[] args)
        {
            Console.Title = "Texture.cache parser test";
            using (var of = new OpenFileDialog())
            {
                of.Filter = "Witcher 3 Cache files | *.cache";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("Got file: " + Path.GetFileName(of.FileName) + "->" +
                                      GetCacheTypeOfFile(of.FileName));
                    switch (GetCacheTypeOfFile(of.FileName))
                    {
                        case Cachetype.Texture:
                        {
                            ParseTextureCache(of.FileName);
                            break;
                        }
                        default:
                            MessageBox.Show("Unsupported file!"); 
                            break;
                    }
                }
                Console.ReadKey();
            }
        }

        public static Cachetype GetCacheTypeOfFile(string path)
        {
            using (var br = new BinaryReader(new FileStream(path,FileMode.Open)))
            {
                var idString = br.ReadBytes(4);
                br.BaseStream.Seek(-8, SeekOrigin.End);
                var idStringBack = br.ReadBytes(4);
                if (idStringBack.SequenceEqual(TextureIdString))
                    return Cachetype.Texture;
                if(idString.SequenceEqual(SoundIdString))
                    return Cachetype.Sound;
                if(idString.SequenceEqual(DepIdString))
                    return Cachetype.Dep;
                if(idString.SequenceEqual(CollisionIdString))
                    return Cachetype.Collision;
                return idStringBack.SequenceEqual(ShaderIdString) ? Cachetype.Shader : Cachetype.Unknown;
            }   
        }

        public static void ParseTextureCache(string filepath)
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
                var jmp = -(20 + 12 + (texturenum*52) + namesBlock + (chunksBlock*4));
                Console.WriteLine("JUMP: " + jmp);
                br.BaseStream.Seek(jmp,SeekOrigin.End);
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
                    Console.WriteLine("[" + i+1 + "]: " + names.Last());
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

    }
}
