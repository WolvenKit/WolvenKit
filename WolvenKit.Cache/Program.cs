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
 /*
    FileTable + "null terminated"
    0x00
    Int32 NULL;
    for(int i = 0;i < filecount;i++)
    {
	    0xC Null byte
	    Int32 Offset;
	    Int32 Size;
	    Int32 Unk1;
	    Int32 NULL;
	    In64 Unk2;
	    0x00
	    Int64 Unk3;
	    0x00
	    Int64 Unk4;
	    Int64 Unk5;
	    Int32 Comtype?
	    Int32 NULL;
	    Int32 Unk6;	
    }   
*/




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
                        break;
                    }
                    case Cache.Cachetype.Shader:
                    {
                        var sc = new ShaderCache(of.FileName);
                        Console.WriteLine("IDString: " + new string(Encoding.ASCII.GetChars(sc.IdString)));
                        Console.WriteLine("Version: " + sc.Version);
                        Console.WriteLine("FileTableOffset1: " + sc.FileTableOffset1);
                        Console.WriteLine("FileTableOffset2: " + sc.FileTableOffset2);
                        Console.WriteLine("UNK: " + sc.Unk1);
                        Console.WriteLine("Filecount: " + sc.Files.Count);
                        Console.WriteLine("Version: " + sc.Version);
                        break;
                    }
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }

    public static class BREXT
    {
        public static string ReadCR2WString(this BinaryReader file, int len = 0)
        {
            string str = null;
            if (len > 0)
            {
                str = Encoding.Default.GetString(file.ReadBytes(len));
            }
            else
            {
                var sb = new StringBuilder();
                while (true)
                {
                    var c = (char)file.ReadByte();
                    if (c == 0)
                        break;
                    sb.Append(c);
                }
                str = sb.ToString();
            }
            return str;
        }
    }
}