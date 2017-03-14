using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W3Edit.W3Speech
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var file = "";
            using (var of = new OpenFileDialog())
            {
                of.Title = "Select a Witcher 3 Speech file!";
                of.Filter = "Witcher 3 Speech file | *.w3speech";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    file = of.FileName;
                }
                else
                {
                    Environment.Exit(0x01);
                }
            }               
            Console.Title = "Reading " + Path.GetFileName(file) + "!";
            using (var br = new BinaryReader(new MemoryStream(File.ReadAllBytes(file))))
            {
              new W3Speech().Read(br);
            }
        }
    }
}
