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

        [DllImport("oo2ext_7_win64.dll")]
        public static extern int OodleLZ_Decompress(byte[] buffer, long bufferSize, byte[] outputBuffer, long outputBufferSize,
            OodleLZ_FuzzSafe fuzzSafetyFlag,
            OodleLZ_CheckCRC crcCheckFlag,
            OodleLZ_Verbosity logVerbosityFlag,
            uint d, uint e, uint f, uint g, uint h, uint i, OodleLZ_Decode threadModule);

        [DllImport("oo2ext_7_win64.dll")]
        public static extern int OodleLZ_Compress(OodleLZ_Compressor format, byte[] buffer, long bufferSize, byte[] outputBuffer, OodleLZ_Compression level, uint unused1, uint unused2, uint unused3);

        public static int Decompress(byte[] inputBuffer, byte[] outputBuffer)
        {
            int readed = OodleLZ_Decompress(inputBuffer, inputBuffer.Length, outputBuffer, outputBuffer.Length, OodleLZ_FuzzSafe.No, OodleLZ_CheckCRC.No, OodleLZ_Verbosity.None, 0, 0, 0, 0, 0, 0, OodleLZ_Decode.Unthreaded);
            return readed;
        }

        public static int Compress(byte[] inputBuffer, byte[] outputBuffer)
        {
            return OodleLZ_Compress(
                        OodleLZ_Compressor.Kraken,
                        inputBuffer,
                        inputBuffer.Length,
                        outputBuffer,
                        OodleLZ_Compression.Optimal5,
                        0,
                        0,
                        0);
        }
    }
}
