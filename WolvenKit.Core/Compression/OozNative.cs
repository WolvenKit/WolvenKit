using System.Runtime.InteropServices;

namespace WolvenKit.Core.Compression
{
    public static class OozNative
    {
        public static int Kraken_Decompress(byte[] buffer, byte[] outputBuffer)
            => Kraken_Decompress_Raw(buffer, buffer.Length, outputBuffer, outputBuffer.Length);

        public static int Kraken_Compress(byte[] buffer, byte[] outputBuffer, long level)
            => Kraken_Compress_Raw(buffer, buffer.Length, outputBuffer, level);

        #region Linux
        [DllImport("lib/ooz", EntryPoint = "_Z17Kraken_DecompressPKhmPhm")]
        public static extern int Kraken_Decompress_Raw(
            byte[] buffer,
            long bufferSize,
            byte[] outputBuffer,
            long outputBufferSize);


        [DllImport("lib/ooz", EntryPoint = "_Z15Kraken_CompressPhmS_i")]
        public static extern int Kraken_Compress_Raw(
            byte[] buffer,
            long bufferSize,
            byte[] outputBuffer,
            long level);
        #endregion
    }

}
