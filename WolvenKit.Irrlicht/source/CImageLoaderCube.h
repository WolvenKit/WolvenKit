#ifndef __C_IMAGE_LOADER_CUBE_H_INCLUDED__
#define __C_IMAGE_LOADER_CUBE_H_INCLUDED__

#include "IrrCompileConfig.h"
#include "IImageLoader.h"

namespace irr
{
namespace video
{
#if defined(_IRR_COMPILE_WITH_CUBE_LOADER_)

// byte-align structures
#include "irrpack.h"

    struct CR2WFileHeader
    {
        u32 version;
        u32 flags;
        u64 timeStamp;
        u32 buildVersion;
        u32 fileSize;
        u32 bufferSize;
        u32 crc32;
        u32 numChunks;
    } PACK_STRUCT;

    struct CR2WTable
    {
        u32 offset;
        u32 itemCount;
        u32 crc32;
    } PACK_STRUCT;

    struct CR2WExport
    {
        u16 className;        //needs to be registered upon new creation and updated on file write!   //done
        u16 objectFlags;      // 0 means uncooked, 8192 is cooked //TODO
        u32 parentID;
        u32 dataSize;           // created upon data write  //done
        u32 dataOffset;         // created upon data write  //done
        u32 utemplate;           // can be 0 //TODO?
        u32 crc32;              // created upon write   //done
    } PACK_STRUCT;

    /*
typedef enum _D3DFORMAT {
    D3DFMT_UNKNOWN              =  0,

    D3DFMT_R8G8B8               = 20,
    D3DFMT_A8R8G8B8             = 21,
    D3DFMT_X8R8G8B8             = 22,
    D3DFMT_R5G6B5               = 23,
    D3DFMT_X1R5G5B5             = 24,
    D3DFMT_A1R5G5B5             = 25,
    D3DFMT_A4R4G4B4             = 26,
    D3DFMT_R3G3B2               = 27,
    D3DFMT_A8                   = 28,
    D3DFMT_A8R3G3B2             = 29,
    D3DFMT_X4R4G4B4             = 30,
    D3DFMT_A2B10G10R10          = 31,
    D3DFMT_A8B8G8R8             = 32,
    D3DFMT_X8B8G8R8             = 33,
    D3DFMT_G16R16               = 34,
    D3DFMT_A2R10G10B10          = 35,
    D3DFMT_A16B16G16R16         = 36,

    D3DFMT_A8P8                 = 40,
    D3DFMT_P8                   = 41,

    D3DFMT_L8                   = 50,
    D3DFMT_A8L8                 = 51,
    D3DFMT_A4L4                 = 52,

    D3DFMT_V8U8                 = 60,
    D3DFMT_L6V5U5               = 61,
    D3DFMT_X8L8V8U8             = 62,
    D3DFMT_Q8W8V8U8             = 63,
    D3DFMT_V16U16               = 64,
    D3DFMT_A2W10V10U10          = 67,

    D3DFMT_UYVY                 = MAKEFOURCC('U', 'Y', 'V', 'Y'),
    D3DFMT_R8G8_B8G8            = MAKEFOURCC('R', 'G', 'B', 'G'),
    D3DFMT_YUY2                 = MAKEFOURCC('Y', 'U', 'Y', '2'),
    D3DFMT_G8R8_G8B8            = MAKEFOURCC('G', 'R', 'G', 'B'),
    D3DFMT_DXT1                 = MAKEFOURCC('D', 'X', 'T', '1'),
    D3DFMT_DXT2                 = MAKEFOURCC('D', 'X', 'T', '2'),
    D3DFMT_DXT3                 = MAKEFOURCC('D', 'X', 'T', '3'),
    D3DFMT_DXT4                 = MAKEFOURCC('D', 'X', 'T', '4'),
    D3DFMT_DXT5                 = MAKEFOURCC('D', 'X', 'T', '5'),

    D3DFMT_D16_LOCKABLE         = 70,
    D3DFMT_D32                  = 71,
    D3DFMT_D15S1                = 73,
    D3DFMT_D24S8                = 75,
    D3DFMT_D24X8                = 77,
    D3DFMT_D24X4S4              = 79,
    D3DFMT_D16                  = 80,

    D3DFMT_D32F_LOCKABLE        = 82,
    D3DFMT_D24FS8               = 83,

#if !defined(D3D_DISABLE_9EX)
    D3DFMT_D32_LOCKABLE         = 84,
    D3DFMT_S8_LOCKABLE          = 85,
#endif // !D3D_DISABLE_9EX

    D3DFMT_L16                  = 81,

    D3DFMT_VERTEXDATA           =100,
    D3DFMT_INDEX16              =101,
    D3DFMT_INDEX32              =102,

    D3DFMT_Q16W16V16U16         =110,

    D3DFMT_MULTI2_ARGB8         = MAKEFOURCC('M','E','T','1'),

    D3DFMT_R16F                 = 111,
    D3DFMT_G16R16F              = 112,
    D3DFMT_A16B16G16R16F        = 113,

    D3DFMT_R32F                 = 114,
    D3DFMT_G32R32F              = 115,
    D3DFMT_A32B32G32R32F        = 116,

    D3DFMT_CxV8U8               = 117,
    */
    /*
        Image File Formats
          D3DXIFF_BMP          = 0,
          D3DXIFF_JPG          = 1,
          D3DXIFF_TGA          = 2,
          D3DXIFF_PNG          = 3,
          D3DXIFF_DDS          = 4,
          D3DXIFF_PPM          = 5,
          D3DXIFF_DIB          = 6,
          D3DXIFF_HDR          = 7,
          D3DXIFF_PFM          = 8,
    */
    struct D3DXIMAGE_INFO {
        u32 width;
        u32 height;
        u32 depth;
        u32 mipLevels;
        u32 format;
        u32 resourceType; // D3DRTYPE_CubeTexture = 5
        u32 imageFileFormat; // 
    } PACK_STRUCT;
#include "irrunpack.h"

/*!
	Surface Loader for xbm images
*/
class CImageLoaderCube : public IImageLoader
{
public:

	//! returns true if the file maybe is able to be loaded by this class
	//! based on the file extension (e.g. ".xbm")
	bool isALoadableFileExtension(const io::path& filename) const _IRR_OVERRIDE_;

	//! returns true if the file maybe is able to be loaded by this class
	bool isALoadableFileFormat(io::IReadFile* file) const _IRR_OVERRIDE_;

	//! creates a surface from the file
	IImage* loadImage(io::IReadFile* file) const _IRR_OVERRIDE_;
};
#endif

} // end namespace video
} // end namespace irr

#endif

