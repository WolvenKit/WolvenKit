using System;
using System.Runtime.InteropServices;

namespace WolvenKit.Common.Oodle
{
    public static class OozNative
    {
        // #region osx
        //
        // [DllImport("lib/liboodle.dylib", CallingConvention = CallingConvention.StdCall)]
        // public static extern int Compress(
        //     int algorithm,
        //     IntPtr inputBuffer,
        //     IntPtr outputBuffer,
        //     int inputSize,
        //     IntPtr src_window_base,
        //     IntPtr lrm_org);
        //
        // [DllImport("lib/liboodle.dylib", CallingConvention = CallingConvention.StdCall)]
        // public static extern int GetCompressedBufferSizeNeeded(int size);
        //
        // [DllImport("lib/liboodle.dylib", CallingConvention = CallingConvention.StdCall)]
        // public static extern int Kraken_Decompress(
        //     byte[] buffer,
        //     long bufferSize,
        //     byte[] outputBuffer,
        //     long outputBufferSize);
        //
        // #endregion osx

        #region Win

        //public static int Kraken_Decompress(
        //    byte[] buffer,
        //    long bufferSize,
        //    byte[] outputBuffer,
        //    long outputBufferSize)
        //{
        //    return 0;
        //}

        //public static int Kraken_Compress(
        //   byte[] buffer,
        //   long bufferSize,
        //   byte[] outputBuffer)
        //{
        //    return 0;
        //}


        // EXPORT int Kraken_Decompress(const byte* src, size_t src_len, byte* dst, size_t dst_len);
        [DllImport("lib/kraken.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Kraken_Decompress(
            byte[] buffer,
            long bufferSize,
            byte[] outputBuffer,
            long outputBufferSize);

        // EXPORT int Kraken_Compress(uint8* src, size_t src_len, byte* dst);
        [DllImport("lib/kraken.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Kraken_Compress(
           byte[] buffer,
           long bufferSize,
           byte[] outputBuffer);

        #endregion
    }
}
