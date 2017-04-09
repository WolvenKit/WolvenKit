using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WolvenKit.Cache
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
            Console.Title = "*.cache parser test";
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
                            Texture_Cache.Read(of.FileName);
                            break;
                        }
                        case Cachetype.Sound:
                        {
							new SoundCache(of.FileName);
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

    }
}
