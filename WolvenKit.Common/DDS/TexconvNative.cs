// using System;
// using System.Runtime.InteropServices;
// using WolvenKit.Common.DDS;
//
namespace WolvenKit.Common.Tools.DDS;
//
public static class TexconvNative
{
//     public class TexMetadata
//     {
//         public long width;
//         public long height;     // Should be 1 for 1D textures
//         public long depth;      // Should be 1 for 1D or 2D textures
//         public long arraySize;  // For cubemap, this is a multiple of 6
//         public long mipLevels;
//         public int miscFlags;
//         public int miscFlags2;
//         public DXGI_FORMAT format;
//         public TEX_DIMENSION dimension;
//     }
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
//
//     public enum DDSFLAGS
//     {
//         DDS_FLAGS_NONE = 0x0,
//
//         DDS_FLAGS_LEGACY_DWORD = 0x1,
//         // Assume pitch is DWORD aligned instead of BYTE aligned (used by some legacy DDS files)
//
//         DDS_FLAGS_NO_LEGACY_EXPANSION = 0x2,
//         // Do not implicitly convert legacy formats that result in larger pixel sizes (24 bpp, 3:3:2, A8L8, A4L4, P8, A8P8)
//
//         DDS_FLAGS_NO_R10B10G10A2_FIXUP = 0x4,
//         // Do not use work-around for long-standing D3DX DDS file format issue which reversed the 10:10:10:2 color order masks
//
//         DDS_FLAGS_FORCE_RGB = 0x8,
//         // Convert DXGI 1.1 BGR formats to DXGI_FORMAT_R8G8B8A8_UNORM to avoid use of optional WDDM 1.1 formats
//
//         DDS_FLAGS_NO_16BPP = 0x10,
//         // Conversions avoid use of 565, 5551, and 4444 formats and instead expand to 8888 to avoid use of optional WDDM 1.2 formats
//
//         DDS_FLAGS_EXPAND_LUMINANCE = 0x20,
//         // When loading legacy luminance formats expand replicating the color channels rather than leaving them packed (L8, L16, A8L8)
//
//         DDS_FLAGS_BAD_DXTN_TAILS = 0x40,
//         // Some older DXTn DDS files incorrectly handle mipchain tails for blocks smaller than 4x4
//
//         DDS_FLAGS_FORCE_DX10_EXT = 0x10000,
//         // Always use the 'DX10' header extension for DDS writer (i.e. don't try to write DX9 compatible DDS files)
//
//         DDS_FLAGS_FORCE_DX10_EXT_MISC2 = 0x20000,
//         // DDS_FLAGS_FORCE_DX10_EXT including miscFlags2 information (result may not be compatible with D3DX10 or D3DX11)
//
//         DDS_FLAGS_FORCE_DX9_LEGACY = 0x40000,
//         // Force use of legacy header for DDS writer (will fail if unable to write as such)
//
//         DDS_FLAGS_ALLOW_LARGE_FILES = 0x1000000,
//         // Enables the loader to read large dimension .dds files (i.e. greater than known hardware requirements)
//     };
//
//     public enum TGA_FLAGS
//     {
//         TGA_FLAGS_NONE = 0x0,
//
//         TGA_FLAGS_BGR = 0x1,
//         // 24bpp files are returned as BGRX; 32bpp files are returned as BGRA
//
//         TGA_FLAGS_ALLOW_ALL_ZERO_ALPHA = 0x2,
//         // If the loaded image has an all zero alpha channel, normally we assume it should be opaque. This flag leaves it alone.
//
//         TGA_FLAGS_IGNORE_SRGB = 0x10,
//         // Ignores sRGB TGA 2.0 metadata if present in the file
//
//         TGA_FLAGS_FORCE_SRGB = 0x20,
//         // Writes sRGB metadata into the file reguardless of format (TGA 2.0 only)
//
//         TGA_FLAGS_FORCE_LINEAR = 0x40,
//         // Writes linear gamma metadata into the file reguardless of format (TGA 2.0 only)
//
//         TGA_FLAGS_DEFAULT_SRGB = 0x80,
//         // If no colorspace is specified in TGA 2.0 metadata, assume sRGB
//     };
//
//     //EXPORT int ConvertAndSaveDdsImage(
//     //    byte* bytePtr,
//     //    int len,
//     //    const wchar_t* szFile,
//     //    DirectXTexSharp::ESaveFileTypes filetype,
//     //    bool vflip,
//     //    bool hflip);
//     //EXPORT byte* ConvertFromDdsArray(
//     //        byte* bytePtr,
//     //        int len,
//     //        DirectXTexSharp::ESaveFileTypes filetype,
//     //        bool vflip,
//     //        bool hflip);
//     //EXPORT byte* ConvertToDdsArray(
//     //        byte* bytePtr,
//     //        int len,
//     //        DirectXTexSharp::ESaveFileTypes filetype,
//     //        DXGI_FORMAT format,
//     //        bool vflip,
//     //        bool hflip);
//
//     //namespace DirectXTexSharp::Format
//     //{
//     //    EXPORT size_t ComputeRowPitch(DXGI_FORMAT format, long width, long height);
//     //    EXPORT size_t ComputeSlicePitch(DXGI_FORMAT format, long width, long height);
//     //    EXPORT size_t BitsPerPixel(DXGI_FORMAT format);
//     //}
//
//     //namespace DirectXTexSharp::Metadata
//     //{
//     //    EXPORT DirectX::TexMetadata GetMetadataFromDDSFile(
//     //            const wchar_t* szFile,
//     //            DirectXTexSharp::DDSFLAGS flags);
//     //    EXPORT DirectX::TexMetadata GetMetadataFromTGAFile(
//     //            const wchar_t* szFile,
//     //            DirectXTexSharp::TGA_FLAGS flags);
//     //    EXPORT DirectX::TexMetadata GetMetadataFromDDSMemory(
//     //            byte* pSource,
//     //            int size,
//     //            DirectXTexSharp::DDSFLAGS flags);
//     //}
//
//
//     [DllImport("lib/texconv.dll", EntryPoint = "ConvertAndSaveDdsImage", CallingConvention = CallingConvention.StdCall)]
//     public static extern int ConvertAndSaveDdsImage(
//         byte[] bytePtr,
//         int len,
//         [MarshalAs(UnmanagedType.LPWStr)] string szFile,
//         ESaveFileTypes filetype,
//         bool vflip = false,
//         bool hflip = false);
//
//     [DllImport("lib/texconv.dll", EntryPoint = "ConvertFromDdsArray", CallingConvention = CallingConvention.StdCall)]
//     public static extern IntPtr ConvertFromDdsArray(
//         byte[] bytePtr,
//         int len,
//         ESaveFileTypes filetype,
//         bool vflip = false,
//         bool hflip = false);
//
//     [DllImport("lib/texconv.dll", EntryPoint = "ConvertToDdsArray", CallingConvention = CallingConvention.StdCall)]
//     public static extern byte[] ConvertToDdsArray(
//         byte[] bytePtr,
//         int len,
//         ESaveFileTypes filetype,
//         DXGI_FORMAT format,
//         bool vflip = false,
//         bool hflip = false);
//
//     [DllImport("lib/texconv.dll", EntryPoint = "ComputeRowPitch", CallingConvention = CallingConvention.StdCall)]
//     public static extern long ComputeRowPitch(DXGI_FORMAT format, long width, long height);
//
//     [DllImport("lib/texconv.dll", EntryPoint = "ComputeSlicePitch", CallingConvention = CallingConvention.StdCall)]
//     public static extern long ComputeSlicePitch(DXGI_FORMAT format, long width, long height);
//
//     [DllImport("lib/texconv.dll", EntryPoint = "BitsPerPixel", CallingConvention = CallingConvention.StdCall)]
//     public static extern long BitsPerPixel(DXGI_FORMAT format);
//
//
//
//     [DllImport("lib/texconv.dll", EntryPoint = "GetMetadataFromDDSFile", CallingConvention = CallingConvention.StdCall)]
//     public static extern TexMetadata GetMetadataFromDDSFile(
//         [MarshalAs(UnmanagedType.LPWStr)] string szFile,
//         DDSFLAGS flags = DDSFLAGS.DDS_FLAGS_NONE);
//
//     [DllImport("lib/texconv.dll", EntryPoint = "GetMetadataFromTGAFile", CallingConvention = CallingConvention.StdCall)]
//     public static extern TexMetadata GetMetadataFromTGAFile(
//         [MarshalAs(UnmanagedType.LPWStr)] string szFile,
//         TGA_FLAGS flags = TGA_FLAGS.TGA_FLAGS_NONE);
//
//     [DllImport("lib/texconv.dll", EntryPoint = "GetMetadataFromDDSMemory", CallingConvention = CallingConvention.StdCall)]
//     public static extern TexMetadata GetMetadataFromDDSMemory(
//         byte[] pSource,
//         int size,
//         DDSFLAGS flags = DDSFLAGS.DDS_FLAGS_NONE);
//
}
