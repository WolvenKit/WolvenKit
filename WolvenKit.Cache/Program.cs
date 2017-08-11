using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WolvenKit.Cache
{
    public class ShaderCache
    {
        public byte[] IdString = { (byte)'R', (byte)'D', (byte)'H', (byte)'S' };
        public uint Version;
        public Int64 FileTableOffset1;
        public Int64 FileTableOffset2;
        public Int64 Unk1;

        public List<Tuple<byte[],Int32>> Files = new List<Tuple<byte[], int>>();

        public ShaderCache(string filename)
        {
            this.Read(new BinaryReader(new FileStream(filename, FileMode.Open)));
        }

        public void Read(BinaryReader br)
        {
            br.BaseStream.Seek(-32, SeekOrigin.End);
            FileTableOffset2 = br.ReadInt64();
            Unk1 = br.ReadInt64();
            FileTableOffset1 = br.ReadInt64();
            if (!br.ReadBytes(4).SequenceEqual(IdString))
                throw new Exception("Invalid file!");
            this.Version = br.ReadUInt32();
            var len = 0;
            br.BaseStream.Seek(FileTableOffset1, SeekOrigin.Begin);
            len = br.ReadInt32();
            do
            {
                var info = br.ReadBytes(len);
                var hash = br.ReadInt32();
                br.BaseStream.Seek(0x30, SeekOrigin.Current);
                Files.Add(new Tuple<byte[], int>(info,hash));
                len = br.ReadInt32();
            } while ((len + 0x30 + 4 + br.BaseStream.Position) < br.BaseStream.Length);
        }


    }
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.Title = "Collision.cache reader test";
            var of = new OpenFileDialog();
            of.Filter = "Cache files | *.cache";
            of.Title = "Please select a witcher 3 cache file";
            if (of.ShowDialog() == DialogResult.OK)
            {
                switch (Cache.GetCacheTypeOfFile(of.FileName))
                {
                    case Cache.Cachetype.Collision:
                    {
                        var cc = new CollisionCache.CollisionCache(of.FileName);
                        Console.WriteLine("Parsing: " + of.FileName);
                        Console.WriteLine();
                            if (!Directory.Exists(Path.GetDirectoryName(of.FileName) + "\\Ex"))
                                Directory.CreateDirectory(Path.GetDirectoryName(of.FileName) + "\\Ex");
                        foreach (var f in cc.Files)
                        {                            
                            Console.WriteLine("\t" + f.Name);
                            if(!File.Exists(Path.GetDirectoryName(of.FileName) + "\\Ex\\" + Path.GetFileName(f.Name)))
                                f.Extract(Path.GetDirectoryName(of.FileName) + "\\Ex\\" + Path.GetFileName(f.Name));
                            Console.WriteLine("EXTRACTED!");
                        }
                        Console.WriteLine();
                        break;
                    }
                    case Cache.Cachetype.Shader:
                    {
                        var sc = new ShaderCache(of.FileName);
                        Console.WriteLine("IDString: " + new string(Encoding.ASCII.GetChars(sc.IdString)));
                        Console.WriteLine("Version: " + sc.Version);
                        Console.WriteLine("FileTableOffset1: " + sc.FileTableOffset1);
                        Console.WriteLine("FileTableOffset2: " + sc.FileTableOffset2);
                        Console.WriteLine("Filecount: " + sc.Files.Count);
                        Console.WriteLine("Files:");
                        break;
                    }
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}