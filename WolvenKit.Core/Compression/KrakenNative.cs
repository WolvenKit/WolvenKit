using System.Runtime.InteropServices;

namespace WolvenKit.Core.Compression;

internal static class KrakenNative
{
    public static int Decompress(byte[] buffer, byte[] outputBuffer)
        => Kraken_Decompress(buffer, buffer.Length, outputBuffer, outputBuffer.Length);

    public static int Compress(byte[] buffer, byte[] outputBuffer, int level)
        => Kraken_Compress(buffer, buffer.Length, outputBuffer, level);


#if _WINDOWS
    private const string dllName = "lib/kraken.dll";
#elif _OSX
    private const string dllName = "lib/libkraken.dylib";
#elif _LINUX
    private const string dllName = "lib/libkraken.so";
#endif

    // EXPORT int Kraken_Decompress(const byte* src, size_t src_len, byte* dst, size_t dst_len);
    [DllImport(dllName, CallingConvention = CallingConvention.StdCall)]
    private static extern int Kraken_Decompress(
        byte[] buffer,
        long bufferSize,
        byte[] outputBuffer,
        long outputBufferSize);

    // EXPORT int Kraken_Compress(uint8* src, size_t src_len, byte* dst, int level);
    [DllImport(dllName, CallingConvention = CallingConvention.StdCall)]
    private static extern int Kraken_Compress(
       byte[] buffer,
       long bufferSize,
       byte[] outputBuffer,
       int level);
}
