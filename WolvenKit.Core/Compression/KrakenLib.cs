using System;
using System.IO;
using System.Runtime.InteropServices;

namespace WolvenKit.Core.Compression;

public static class KrakenLib
{
#if _WINDOWS
    private const string dllName = "kraken.dll";
#elif _OSX
    private const string dllName = "libkraken.dylib";
#elif _LINUX
    private const string dllName = "libkraken.so";
#endif


    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate int DecompressDelegate(
        byte[] buffer,
        long bufferSize,
        byte[] outputBuffer,
        long outputBufferSize);

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    private delegate int CompressDelegate(
        byte[] buffer,
        long bufferSize,
        byte[] outputBuffer,
        int level);


    private static IntPtr s_pDll = IntPtr.Zero;

    private static IntPtr s_pOodleLzCompress = IntPtr.Zero;
    private static IntPtr s_pOodleLzDecompress = IntPtr.Zero;

    private static DecompressDelegate s_decompress;
    private static CompressDelegate s_compress;

    public static bool Load()
    {
        s_pDll = NativeMethods.LoadLibrary(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lib", dllName));
        if (s_pDll == IntPtr.Zero)
        {
            return false;
        }
        s_pOodleLzCompress = NativeMethods.GetProcAddress(s_pDll, "Kraken_Compress");
        if (s_pOodleLzCompress == IntPtr.Zero)
        {
            return false;
        }
        s_pOodleLzDecompress = NativeMethods.GetProcAddress(s_pDll, "Kraken_Decompress");
        if (s_pOodleLzDecompress == IntPtr.Zero)
        {
            return false;
        }

        s_decompress = (DecompressDelegate)Marshal.GetDelegateForFunctionPointer(
            s_pOodleLzDecompress,
            typeof(DecompressDelegate)
        );
        s_compress = (CompressDelegate)Marshal.GetDelegateForFunctionPointer(
            s_pOodleLzCompress,
            typeof(CompressDelegate)
        );

        return true;
    }

    public static bool Free() => NativeMethods.FreeLibrary(s_pDll);

    public static int Decompress(
        byte[] buffer,
        //long bufferSize,
        byte[] outputBuffer
        //long outputBufferSize
        ) =>
        s_decompress(buffer, buffer.Length, outputBuffer, outputBuffer.Length);

    public static int Compress(
      byte[] buffer,
      //long bufferSize,
      byte[] outputBuffer,
      int level) =>
        s_compress(buffer, buffer.Length, outputBuffer, level);


}
