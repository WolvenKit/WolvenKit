using System;
using System.Runtime.InteropServices;

namespace WolvenKit.Common.DDS;

public static class TexconvNative
{
    public class ManagedBlob : IDisposable
    {
        private Blob _blob;

        private bool disposed = false;

        public ManagedBlob() => _blob = new Blob();

        public Blob GetBlob() => _blob;
        public byte[] GetBytes() => _blob.GetBytes();

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            FreeBlob(_blob);
            _blob = new Blob();

            disposed = true;
        }

        ~ManagedBlob()
        {
            Dispose(disposing: false);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public class Blob
    {
        public Blob()
        {
            Handle = IntPtr.Zero;
            Length = 0;
        }
        public IntPtr Handle;
        public long Length;

        public byte[] GetBytes()
        {
            var length = Length;
            var managedArray = new byte[length];
            Marshal.Copy(Handle, managedArray, 0, (int)length);
            return managedArray;
        }
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
        DDS,
        BMP,
        JPEG,
        PNG,
        TGA,
        //HDR, //broken for some reason, disabling for now
        TIFF,
        CUBE,
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
    private static extern long _ConvertFromDds(byte[] inBuffer, int inBufferLength, Blob blob, ESaveFileTypes filetype, bool vflip = false, bool hflip = false);
    public static long ConvertFromDds(byte[] inBuffer, Blob blob, ESaveFileTypes filetype, bool vflip = false, bool hflip = false)
        => _ConvertFromDds(inBuffer, inBuffer.Length, blob, filetype, vflip, hflip);


    [DllImport("lib/texconv.dll", EntryPoint = "ConvertToDds", CallingConvention = CallingConvention.StdCall)]
    private static extern long _ConvertToDds(byte[] inBuff, int inBufferLength, Blob blob, ESaveFileTypes filetype, DXGI_FORMAT format, bool vflip, bool hflip);
    public static long ConvertToDds(byte[] inBuff, Blob blob, ESaveFileTypes filetype, DXGI_FORMAT format, bool vflip = false, bool hflip = false)
        => _ConvertToDds(inBuff, inBuff.Length, blob, filetype, format, vflip, hflip);


    [DllImport("lib/texconv.dll", EntryPoint = "FreeBlob", CallingConvention = CallingConvention.StdCall)]
    public static extern long FreeBlob(Blob blob);


}
