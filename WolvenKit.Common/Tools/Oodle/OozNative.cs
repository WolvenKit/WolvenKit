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

        [DllImport("lib/kraken.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Kraken_Decompress(
            byte[] buffer,
            long bufferSize,
            byte[] outputBuffer,
            long outputBufferSize);

        #endregion
    }
}
