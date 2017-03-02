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
            throw new NotImplementedException("This is only for testing shouldn't be used yet!");
            var file = "";
            using (BinaryReader br = new BinaryReader(new MemoryStream(File.ReadAllBytes(file))))
            {
              var sfile = new W3Speech();
                sfile.Read(br);
            }
        }
    }
}
