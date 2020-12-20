using System;
using System.Runtime.InteropServices;

namespace CP77.Common.Tools
{
    public static class OodleLZ
    {
        public enum OodleLZ_Compressor : int
        {
            LZH = 0,
            LZHLW = 1,
            LZNIB = 2,
            None = 3,
            LZB16 = 4,
            LZBLW = 5,
            LZA = 6,
            LZNA = 7,
            Kraken = 8,
            Mermaid = 9,
            BitKnit = 10,
            Selkie = 11,
            Akkorokamui = 12,
        }

        public enum OodleLZ_Compression : int
        {
            None = 0,
            SuperFast = 1,
            VertFast = 2,
            Fast = 3,
            Normal = 4,
            Optimal1 = 5,
            Optimal2 = 6,
            Optimal3 = 7,
            Optimal4 = 8,
            Optimal5 = 9,
        }

        public enum OodleLZ_FuzzSafe : int
        {
            No = 0,
            Yes = 1,
        }

        public enum OodleLZ_CheckCRC : int
        {
            No = 0,
            Yes = 1,
        }

        public enum OodleLZ_Verbosity : int
        {
            None = 0,
        }

        public enum OodleLZ_Decode : int
        {
            ThreadPhase1 = 1,
            ThreadPhase2 = 2,
            Unthreaded = 3,
        }

//#if _WINDOWS
        [DllImport("lib/kraken.dll")]
        static extern int Kraken_Decompress(byte[] buffer, long bufferSize, byte[] outputBuffer, long outputBufferSize);

        [DllImport("lib/kraken.dll")]
        static extern int Kraken_Compress(byte[] buffer, long bufferSize, byte[] outputBuffer);
//#else
//        [DllImport("lib/kraken.os")]
//        static extern int Kraken_Decompress(byte[] buffer, long bufferSize, byte[] outputBuffer, long outputBufferSize);

//        [DllImport("lib/kraken.os")]
//        static extern int Kraken_Compress(byte[] buffer, long bufferSize, byte[] outputBuffer);
//#endif

        public static int Decompress(byte[] inputBuffer, byte[] outputBuffer)
        {
            return Kraken_Decompress(inputBuffer, inputBuffer.Length, outputBuffer, outputBuffer.Length);
        }

        public static int Compress(byte[] inputBuffer, byte[] outputBuffer)
        {

            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                return Kraken_Compress(inputBuffer, inputBuffer.Length, outputBuffer);
            }
            else if (Environment.OSVersion.Platform == PlatformID.MacOSX)
            {

            }
            else if (Environment.OSVersion.Platform == PlatformID.Unix)
            {

            }

#if _WINDOWS
            return Kraken_Compress(inputBuffer, inputBuffer.Length, outputBuffer);

#else
            throw new InvalidOperationException("Compression not supported on linux");
            
#endif
        }

        public static uint GetCompressionBound(uint bufferSize)
        {
            return bufferSize + 274 * ((bufferSize + 0x3FFFF) / 0x40000);
        }

        /*public static uint GetDecompressionBound(uint bufferSize)
        {
            uint v2 = bufferSize + 272 + 0;
            uint v3 = (bufferSize + 0x3FFFF) / 0x40000;
            if (bufferSize + 16731 + 2 * v3 < v2)
            {
                v2 = bufferSize + 16731 + 2 * v3;
            }
            return v2;
        }*/
    }
}
