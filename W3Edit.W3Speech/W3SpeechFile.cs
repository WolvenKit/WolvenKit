using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W3Edit.W3Speech
{
    public class W3Speech
    {
        public static readonly byte[] IDString = new byte[] { (byte)'C', (byte)'P', (byte)'S', (byte)'W' };
        public static readonly byte[] Version = new byte[] {0xA2,0x00,0x00,0x00};


        public void Read(BinaryReader file)
        {

        }

        public void Write(BinaryWriter file)
        {

        }
    }
}
