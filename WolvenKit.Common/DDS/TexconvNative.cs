using System;
using System.Runtime.InteropServices;

namespace WolvenKit.Common.DDS;

public static class TexconvNative
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Blob
    {
        public IntPtr Buffer;
        public long Length;
    }

    public static byte[] GetBytes(this Blob blob)
    {
        var length = blob.Length;
        var buffer = blob.Buffer;
        var managedArray = new byte[length];
        Marshal.Copy(buffer, managedArray, 0, (int)length);
        return managedArray;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TexMetadata
    {
        public long width;
        public long height;     // Should be 1 for 1D textures
        public long depth;      // Should be 1 for 1D or 2D textures
        public long arraySize;  // For cubemap, this is a multiple of 6
        public long mipLevels;
        public int miscFlags;
        public int miscFlags2;
        public DXGI_FORMAT format;
        public TEX_DIMENSION dimension;
    }
    public enum ESaveFileTypes
    {
        BMP,
        JPEG,
        PNG,
        TGA,
        //HDR, //broken for some reason, disabling for now
        TIFF,
        /*WIC_CODEC_WMP,
        CODEC_HDP,
        CODEC_JXR,
        CODEC_PPM,
        CODEC_PFMm*/
    };

    [DllImport("lib/texconv.dll", EntryPoint = "ComputeRowPitch", CallingConvention = CallingConvention.StdCall)]
    private static extern long _ComputeRowPitch(DXGI_FORMAT format, long width, long height);
    public static long ComputeRowPitch(DXGI_FORMAT format, long width, long height) => _ComputeRowPitch(format, width, height);

    [DllImport("lib/texconv.dll", EntryPoint = "ComputeSlicePitch", CallingConvention = CallingConvention.StdCall)]
    private static extern long _ComputeSlicePitch(DXGI_FORMAT format, long width, long height);
    public static long ComputeSlicePitch(DXGI_FORMAT format, long width, long height) => _ComputeSlicePitch(format, width, height);

    [DllImport("lib/texconv.dll", EntryPoint = "BitsPerPixel", CallingConvention = CallingConvention.StdCall)]
    private static extern long _BitsPerPixel(DXGI_FORMAT format);
    public static long BitsPerPixel(DXGI_FORMAT format) => _BitsPerPixel(format);



    [DllImport("lib/texconv.dll", EntryPoint = "GetMetadataFromDDSFile", CallingConvention = CallingConvention.StdCall)]
    private static extern TexMetadata _GetMetadataFromDDSFile([MarshalAs(UnmanagedType.LPWStr)] string szFile, DDSFLAGS flags = DDSFLAGS.DDS_FLAGS_NONE);
    public static TexMetadata GetMetadataFromDDSFile([MarshalAs(UnmanagedType.LPWStr)] string szFile, DDSFLAGS flags = DDSFLAGS.DDS_FLAGS_NONE)
        => _GetMetadataFromDDSFile(szFile, flags);

    [DllImport("lib/texconv.dll", EntryPoint = "GetMetadataFromTGAFile", CallingConvention = CallingConvention.StdCall)]
    private static extern TexMetadata _GetMetadataFromTGAFile([MarshalAs(UnmanagedType.LPWStr)] string szFile, TGA_FLAGS flags = TGA_FLAGS.TGA_FLAGS_NONE);
    public static TexMetadata GetMetadataFromTGAFile([MarshalAs(UnmanagedType.LPWStr)] string szFile, TGA_FLAGS flags = TGA_FLAGS.TGA_FLAGS_NONE)
        => _GetMetadataFromTGAFile(szFile, flags);

    [DllImport("lib/texconv.dll", EntryPoint = "GetMetadataFromDDSMemory", CallingConvention = CallingConvention.StdCall)]
    private static extern TexMetadata _GetMetadataFromDDSMemory(byte[] pSource, int size, DDSFLAGS flags = DDSFLAGS.DDS_FLAGS_NONE);
    public static TexMetadata GetMetadataFromDDSMemory(byte[] pSource, DDSFLAGS flags = DDSFLAGS.DDS_FLAGS_NONE)
        => _GetMetadataFromDDSMemory(pSource, pSource.Length, flags);



    //[DllImport("lib/texconv.dll", EntryPoint = "ConvertAndSaveDdsImage", CallingConvention = CallingConvention.StdCall)]
    //private static extern long _ConvertAndSaveDdsImage(byte[] bytePtr, int len, [MarshalAs(UnmanagedType.LPWStr)] string szFile, ESaveFileTypes filetype,
    //    bool vflip = false, bool hflip = false);
    //public static long ConvertAndSaveDdsImage(byte[] bytePtr, [MarshalAs(UnmanagedType.LPWStr)] string szFile, ESaveFileTypes filetype,
    //    bool vflip = false, bool hflip = false)
    //    => _ConvertAndSaveDdsImage(bytePtr, bytePtr.Length, szFile, filetype, vflip, hflip);


    [DllImport("lib/texconv.dll", EntryPoint = "ConvertFromDds", CallingConvention = CallingConvention.StdCall)]
    private static extern long _ConvertFromDds(byte[] inBuffer, int inBufferLength, ref Blob blob, ESaveFileTypes filetype, bool vflip = false, bool hflip = false);
    public static long ConvertFromDds(byte[] inBuffer, ref Blob blob, ESaveFileTypes filetype, bool vflip = false, bool hflip = false)
        => _ConvertFromDds(inBuffer, inBuffer.Length, ref blob, filetype, vflip, hflip);


    [DllImport("lib/texconv.dll", EntryPoint = "ConvertToDds", CallingConvention = CallingConvention.StdCall)]
    private static extern long _ConvertToDds(byte[] inBuff, int inBufferLength, ref Blob blob, ESaveFileTypes filetype, DXGI_FORMAT format, bool vflip, bool hflip);
    public static long ConvertToDds(byte[] inBuff, ref Blob blob, ESaveFileTypes filetype, DXGI_FORMAT format, bool vflip = false, bool hflip = false)
        => _ConvertToDds(inBuff, inBuff.Length, ref blob, filetype, format, vflip, hflip);


}
