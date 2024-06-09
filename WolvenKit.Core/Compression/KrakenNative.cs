using System.Runtime.InteropServices;

namespace WolvenKit.Core.Compression;

public static class KrakenNative
{
    public static int Decompress(byte[] buffer, byte[] outputBuffer)
        => Kraken_Decompress(buffer, buffer.Length, outputBuffer, outputBuffer.Length);
    
    public static unsafe int Decompress(byte* buffer, long bufferLength, byte* outputBuffer, long outputLength)
        => Kraken_Decompress(buffer, bufferLength, outputBuffer, outputLength);

    public static int Compress(byte[] buffer, byte[] outputBuffer, int level)
        => Kraken_Compress(buffer, buffer.Length, outputBuffer, level);

    private const string dllName = "kraken";

    [DllImport(dllName, CallingConvention = CallingConvention.StdCall)]
    private static extern unsafe int Kraken_Decompress(
        byte* buffer,
        long bufferSize,
        byte* outputBuffer,
        long outputBufferSize);
    
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
