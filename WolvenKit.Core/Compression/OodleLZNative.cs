
using System;
using System.Runtime.InteropServices;

namespace WolvenKit.Core.Compression;
internal static class OodleLZNative
{
    [DllImport("oo2ext_7_win64.dll", EntryPoint = "OodleLZ_GetCompressedBufferSizeNeeded", CallingConvention = CallingConvention.StdCall)]
    public static extern int GetCompressedBufferSizeNeeded(long rawSize);

    [DllImport("oo2ext_7_win64.dll", EntryPoint = "OodleLZ_Compress", CallingConvention = CallingConvention.StdCall)]
    public static extern int Compress(Oodle.Compressor compressor,
        byte[] rawBuf, long rawLen, byte[] compBuf,
        Oodle.CompressionLevel level,
        IntPtr pOptions = new(),
        IntPtr dictionaryBase = new(),
        IntPtr lrm = new(),
        IntPtr scratchMem = new(),
        long scratchSize = 0);

    [DllImport("oo2ext_7_win64.dll", EntryPoint = "OodleLZ_Decompress", CallingConvention = CallingConvention.StdCall)]
    public static extern int Decompress(byte[] compBuf, long compBufSize, byte[] rawBuf, long rawLen,
        Oodle.FuzzSafe fuzzSafe = Oodle.FuzzSafe.Yes,
        Oodle.CheckCRC checkCRC = Oodle.CheckCRC.No,
        Oodle.Verbosity verbosity = Oodle.Verbosity.None,
        IntPtr decBufBase = new(),
        long decBufSize = 0,
        IntPtr fpCallback = new(),
        IntPtr callbackUserData = new(),
        IntPtr decoderMemory = new(),
        long decoderMemorySize = 0,
        Oodle.ThreadPhase threadModule = Oodle.ThreadPhase.Unthreaded);
}
