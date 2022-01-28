using System;
using System.Runtime.InteropServices;

namespace WolvenKit.Core.Compression;

public static class OodleLZNative
{
    public enum Compressor : int
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

    public enum CompressionLevel
    {
        None = 0,
        SuperFast = 1,
        VeryFast = 2,
        Fast = 3,
        Normal = 4,
        Optimal1 = 5,
        Optimal2 = 6,
        Optimal3 = 7,
        Optimal4 = 8,
        Optimal5 = 9,
    }

    public enum FuzzSafe
    {
        No = 0,
        Yes = 1
    }

    public enum CheckCRC
    {
        No = 0,
        Yes = 1
    }

    public enum Verbosity
    {
        None = 0,
        Minimal = 1,
        Some = 2,
        Lots = 3
    }

    public enum ThreadPhase
    {
        ThreadPhase1 = 1,
        ThreadPhase2 = 2,
        ThreadPhaseAll = 3,
        Unthreaded = ThreadPhaseAll
    }


    [DllImport("oo2ext_7_win64.dll", EntryPoint = "OodleLZ_GetCompressedBufferSizeNeeded", CallingConvention = CallingConvention.StdCall)]
    public static extern int GetCompressedBufferSizeNeeded(long rawSize);

    [DllImport("oo2ext_7_win64.dll", EntryPoint = "OodleLZ_Compress", CallingConvention = CallingConvention.StdCall)]
    public static extern int Compress(Compressor compressor,
        byte[] rawBuf, long rawLen, byte[] compBuf,
        CompressionLevel level,
        IntPtr pOptions = new(),
        IntPtr dictionaryBase = new(),
        IntPtr lrm = new(),
        IntPtr scratchMem = new(),
        long scratchSize = 0);

    [DllImport("oo2ext_7_win64.dll", EntryPoint = "OodleLZ_Decompress", CallingConvention = CallingConvention.StdCall)]
    public static extern int Decompress(byte[] compBuf, long compBufSize, byte[] rawBuf, long rawLen,
        FuzzSafe fuzzSafe = FuzzSafe.Yes,
        CheckCRC checkCRC = CheckCRC.No,
        Verbosity verbosity = Verbosity.None,
        IntPtr decBufBase = new(),
        long decBufSize = 0,
        IntPtr fpCallback = new(),
        IntPtr callbackUserData = new(),
        IntPtr decoderMemory = new(),
        long decoderMemorySize = 0,
        ThreadPhase threadModule = ThreadPhase.Unthreaded);
}
