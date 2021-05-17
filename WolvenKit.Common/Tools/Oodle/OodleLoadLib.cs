using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Oodle;

namespace WolvenKit.Common.Tools.Oodle
{
    //https://stackoverflow.com/a/23623244
    internal static class NativeMethods
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("kernel32.dll")]
        public static extern bool FreeLibrary(IntPtr hModule);
    }


    public static class OodleLoadLib
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int DecompressDelegate(IntPtr buffer, long bufferSize, IntPtr outputBuffer, long outputBufferSize,
            OodleNative.OodleLZ_FuzzSafe fuzzSafetyFlag,
            OodleNative.OodleLZ_CheckCRC crcCheckFlag,
            OodleNative.OodleLZ_Verbosity logVerbosityFlag,
            uint d, uint e, uint f, uint g, uint h, uint i, OodleNative.OodleLZ_Decode threadModule);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate long GetCompressedBufferSizeNeededDelegate(long size);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate long CompressDelegate(
            int algorithm,
            IntPtr inputBuffer,
            long inputSize,
            IntPtr outputBuffer,
            int level,
            IntPtr a6,
            IntPtr a7,
            IntPtr a8,
            IntPtr a9,
            long a10);


        private static IntPtr s_pDll = IntPtr.Zero;

        private static IntPtr s_pOodleLzCompress = IntPtr.Zero;
        private static IntPtr s_pOodleLzGetCompressedBufferSizeNeeded = IntPtr.Zero;
        private static IntPtr s_pOodleLzDecompress = IntPtr.Zero;

        private static DecompressDelegate s_decompress;
        private static GetCompressedBufferSizeNeededDelegate s_getCompressedBufferSizeNeeded;
        private static CompressDelegate s_compress;

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

            s_decompress = (DecompressDelegate)Marshal.GetDelegateForFunctionPointer(
                s_pOodleLzDecompress,
                typeof(DecompressDelegate)
            );
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

        public static int OodleLZ_Decompress(
            IntPtr inputBuffer,
            IntPtr outputBuffer,
            long inputBufferSize,
            long outputBufferSize) =>
            s_decompress(
                inputBuffer,
                inputBufferSize,
                outputBuffer,
                outputBufferSize,
                OodleNative.OodleLZ_FuzzSafe.No,
                OodleNative.OodleLZ_CheckCRC.No,
                OodleNative.OodleLZ_Verbosity.None,
                0,
                0,
                0,
                0,
                0,
                0,
                OodleNative.OodleLZ_Decode.Unthreaded);

        public static long OodleLZ_Compress(
            IntPtr inputAddress,
            IntPtr outputAddress,
            int inputCount,
            OodleNative.OodleLZ_Compressor algo = OodleNative.OodleLZ_Compressor.Kraken,
            OodleNative.OodleLZ_Compression level = OodleNative.OodleLZ_Compression.Normal) =>
            s_compress(
                (int)algo,
                inputAddress,
                inputCount,
                outputAddress,
                (int)level,
                IntPtr.Zero,
                IntPtr.Zero,
                IntPtr.Zero,
                IntPtr.Zero,
                0
            );

        
    }
}
