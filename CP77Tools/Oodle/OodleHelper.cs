using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CP77Tools.Oodle
{
    public static class OodleHelper
    {
        [DllImport(@"\oo2core_8_win64.dll")]
        public static extern int OodleLZ_Decompress(byte[] buffer, long bufferSize, byte[] outputBuffer, long outputBufferSize,
            uint a, uint b, ulong c, uint d, uint e, uint f, uint g, uint h, uint i, uint threadModule);

        // game use format 8 (Kraken) and level 9 (maximum).
        [DllImport(@"\oo2core_8_win64.dll")]
        public static extern int OodleLZ_Compress(OodleFormat format, byte[] buffer, long bufferSize, byte[] outputBuffer,
            OodleCompressionLevel level, uint unused1, uint unused2, uint unused3, uint unused4, uint unused5);

    }
}
