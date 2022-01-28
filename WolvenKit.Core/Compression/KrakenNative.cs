using System.Runtime.InteropServices;

namespace WolvenKit.Core.Compression;

public static class KrakenNative
{
    public static int Decompress(byte[] buffer, byte[] outputBuffer)
        => Kraken_Decompress(buffer, buffer.Length, outputBuffer, outputBuffer.Length);

    public static int Compress(byte[] buffer, byte[] outputBuffer, int level)
        => Kraken_Compress(buffer, buffer.Length, outputBuffer, level);

    // #region osx
    //
    // [DllImport("lib/kraken.dylib", CallingConvention = CallingConvention.StdCall)]
    // public static extern int Compress(
    //     int algorithm,
    //     IntPtr inputBuffer,
    //     IntPtr outputBuffer,
    //     int inputSize,
    //     IntPtr src_window_base,
    //     IntPtr lrm_org);
    //
    // [DllImport("lib/kraken.dylib", CallingConvention = CallingConvention.StdCall)]
    // public static extern int GetCompressedBufferSizeNeeded(int size);
    //
    // [DllImport("lib/kraken.dylib", CallingConvention = CallingConvention.StdCall)]
    // public static extern int Kraken_Decompress(
    //     byte[] buffer,
    //     long bufferSize,
    //     byte[] outputBuffer,
    //     long outputBufferSize);
    //
    // #endregion osx

    #region Win

    // EXPORT int Kraken_Decompress(const byte* src, size_t src_len, byte* dst, size_t dst_len);
    [DllImport("lib/kraken.dll", CallingConvention = CallingConvention.StdCall)]
    private static extern int Kraken_Decompress(
        byte[] buffer,
        long bufferSize,
        byte[] outputBuffer,
        long outputBufferSize);

    // EXPORT int Kraken_Compress(uint8* src, size_t src_len, byte* dst, int level);
    [DllImport("lib/kraken.dll", CallingConvention = CallingConvention.StdCall)]
    private static extern int Kraken_Compress(
       byte[] buffer,
       long bufferSize,
       byte[] outputBuffer,
       int level);

    #endregion
}
