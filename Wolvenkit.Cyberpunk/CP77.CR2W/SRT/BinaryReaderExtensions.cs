using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.CR2W.SRT
{
    public static class BinaryReaderExtensions
    {
        public static void ReadUntilAligned(this BinaryReader br)
        {
            // read padding
            int uiPadSize = 4 - (int)br.BaseStream.Position % 4;
            if (uiPadSize < 4)
                br.ReadBytes(uiPadSize);
        }
    }

    public static class BinaryWriterExtensions
    {
        public static void WriteUntilAligned(this BinaryWriter bw)
        {
            // read padding
            int uiPadSize = 4 - (int)bw.BaseStream.Position % 4;
            if (uiPadSize < 4)
                bw.Write(new byte[uiPadSize]);
        }
    }
}
