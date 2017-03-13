using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.W3Speech
{
    class Program
    {
        public static void Main(string[] args)
        {
            var file = "F:\\Witcher_modding\\The Witcher 3 - Wild Hunt\\content\\content1\\enpc.w3speech";
            Console.Title = "Reading " + Path.GetFileName(file) + "!";
            using (var br = new BinaryReader(new MemoryStream(File.ReadAllBytes(file))))
            {
              new W3Speech().Read(br);
            }
        }
    }
}
