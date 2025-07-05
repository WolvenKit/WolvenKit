using System;
using System.Runtime.InteropServices;
using static WolvenKit.Core.Compression.Oodle;

namespace WolvenKit.Core.Compression
{
    internal static class OodleLib
    {
        private static IntPtr s_pDll = IntPtr.Zero;

        private static IntPtr s_pOodleLzCompress = IntPtr.Zero;
        private static IntPtr s_pOodleLzGetCompressedBufferSizeNeeded = IntPtr.Zero;
        private static IntPtr s_pOodleLzDecompress = IntPtr.Zero;

        private static DecompressDelegate? s_decompress;
        private static DecompressDelegateUnsafe? s_decompressUnsafe;
        private static GetCompressedBufferSizeNeededDelegate? s_getCompressedBufferSizeNeeded;
        private static CompressDelegate? s_compress;

        public static bool Load(string oodlepath)
        {
            s_pDll = NativeMethods.LoadLibrary(oodlepath);
            if (s_pDll == IntPtr.Zero)
            {
                return false;
            }
            s_pOodleLzCompress = NativeMethods.GetProcAddress(s_pDll, "OodleLZ_Compress");
            if (s_pOodleLzCompress == IntPtr.Zero)
            {
                return false;
            }
            s_pOodleLzGetCompressedBufferSizeNeeded = NativeMethods.GetProcAddress(s_pDll, "OodleLZ_GetCompressedBufferSizeNeeded");
            if (s_pOodleLzGetCompressedBufferSizeNeeded == IntPtr.Zero)
            {
                return false;
            }
            s_pOodleLzDecompress = NativeMethods.GetProcAddress(s_pDll, "OodleLZ_Decompress");
            if (s_pOodleLzDecompress == IntPtr.Zero)
            {
                return false;
            }

            var decompressPtr = Marshal.GetDelegateForFunctionPointer(
                s_pOodleLzDecompress,
                typeof(DecompressDelegate)
            );
            
            var decompressPtrUnsafe = Marshal.GetDelegateForFunctionPointer(
                s_pOodleLzDecompress,
                typeof(DecompressDelegateUnsafe)
            );

            s_decompress = (DecompressDelegate)decompressPtr;
            s_decompressUnsafe = (DecompressDelegateUnsafe)decompressPtrUnsafe;
            
            s_getCompressedBufferSizeNeeded = (GetCompressedBufferSizeNeededDelegate)Marshal.GetDelegateForFunctionPointer(
                s_pOodleLzGetCompressedBufferSizeNeeded,
                typeof(GetCompressedBufferSizeNeededDelegate)
            );
            s_compress = (CompressDelegate)Marshal.GetDelegateForFunctionPointer(
                s_pOodleLzCompress,
                typeof(CompressDelegate)
            );

            return true;
        }

        public static bool Free() => NativeMethods.FreeLibrary(s_pDll);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int DecompressDelegate(
            byte[] compBuf,
            long compBufSize,
            byte[] rawBuf,
            long rawLen,
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
        
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private unsafe delegate int DecompressDelegateUnsafe(
            byte* compBuf,
            long compBufSize,
            byte* rawBuf,
            long rawLen,
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

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate long GetCompressedBufferSizeNeededDelegate(long size);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int CompressDelegate(
            Oodle.Compressor compressor,
            byte[] rawBuf,
            long rawLen,
            byte[] compBuf,
            CompressionLevel level,
            IntPtr pOptions = new(),
            IntPtr dictionaryBase = new(),
            IntPtr lrm = new(),
            IntPtr scratchMem = new(),
            long scratchSize = 0);

        public static int OodleLZ_Decompress(
            byte[] inputBuffer,
            byte[] outputBuffer)
        {
            ArgumentNullException.ThrowIfNull(s_decompress);
            return s_decompress(
                inputBuffer,
                inputBuffer.Length,
                outputBuffer,
                outputBuffer.Length);
        }
        
        public static unsafe int OodleLZ_Decompress(
            byte* inputBuffer,
            long inputLength,
            byte* outputBuffer,
            long outputLength)
        {
            ArgumentNullException.ThrowIfNull(s_decompress);
            
            return s_decompressUnsafe!(
                inputBuffer,
                inputLength,
                outputBuffer,
                outputLength);
        }

        public static int OodleLZ_Compress(
            byte[] inputBuffer,
            byte[] outputBuffer,
            Compressor compressor = Compressor.Kraken,
            CompressionLevel level = CompressionLevel.Normal)
        {
            ArgumentNullException.ThrowIfNull(s_compress);
            return s_compress(
                compressor,
                inputBuffer,
                inputBuffer.Length,
                outputBuffer,
                level);
        }
    }
}
