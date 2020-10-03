#ifndef __C_IMAGE_LOADER_XBM_H_INCLUDED__
#define __C_IMAGE_LOADER_XBM_H_INCLUDED__

#include "IrrCompileConfig.h"
#include "IImageLoader.h"

namespace irr
{
namespace video
{
#if defined(_IRR_COMPILE_WITH_XBM_LOADER_)

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

    struct MipData
    {
        u32 width;
        u32 height;
        u32 blocksize;
    } PACK_STRUCT;

    /*
    struct ddsPixelFormat
    {
        u32	Size;
        u32 Flags;
        u32 FourCC;
        u32 RGBBitCount;
        u32	RBitMask;
        u32 GBitMask;
        u32 BBitMask;
        u32	ABitMask;
    } PACK_STRUCT;

    struct ddsCaps
    {
        u32		caps1;
        u32		caps2;
        u32		caps3;
        u32		caps4;
    } PACK_STRUCT;

    struct ddsHeader
    {
        c8 Magic[4];
        u32 Size;
        u32 Flags;
        u32 Height;
        u32 Width;
        u32 PitchOrLinearSize;
        u32 Depth;
        u32 MipMapCount;
        u32 Reserved1[11];
        ddsPixelFormat PixelFormat;
        ddsCaps Caps;
        u32 Reserved2;
    } PACK_STRUCT;
    */

    // Default alignment
#include "irrunpack.h"

/*!
	Surface Loader for xbm images
*/
class CImageLoaderXBM : public IImageLoader
{
public:

	//! returns true if the file maybe is able to be loaded by this class
	//! based on the file extension (e.g. ".xbm")
	virtual bool isALoadableFileExtension(const io::path& filename) const _IRR_OVERRIDE_;

	//! returns true if the file maybe is able to be loaded by this class
	virtual bool isALoadableFileFormat(io::IReadFile* file) const _IRR_OVERRIDE_;

	//! creates a surface from the file
	virtual IImage* loadImage(io::IReadFile* file) const _IRR_OVERRIDE_;
};
#endif

} // end namespace video
} // end namespace irr

#endif

