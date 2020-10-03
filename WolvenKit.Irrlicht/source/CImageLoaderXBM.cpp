#include "CImageLoaderXBM.h"

#ifdef _IRR_COMPILE_WITH_XBM_LOADER_

#include "IReadFile.h"
#include "os.h"
#include "CColorConverter.h"
#include "CImage.h"
#include "irrString.h"
#include "CD3D9Driver.h"
#include "debug.h"

#define DDSD_CAPS			0x00000001
#define DDSD_HEIGHT			0x00000002
#define DDSD_WIDTH			0x00000004
#define DDSD_PIXELFORMAT	0x00001000
#define DDSD_MIPMAPCOUNT	0x00020000
#define DDSD_LINEARSIZE		0x00080000

#define DDPF_FOURCC			0x00000004

#define DDSCAPS1_COMPLEX	0x00000008
#define DDSCAPS1_TEXTURE	0x00001000
#define DDSCAPS1_MIPMAP		0x00400000

namespace irr
{
namespace video
{


//! returns true if the file maybe is able to be loaded by this class
//! based on the file extension (e.g. ".xbm")
bool CImageLoaderXBM::isALoadableFileExtension(const io::path& filename) const
{
	return core::hasFileExtension ( filename, "xbm" );
}

//! returns true if the file maybe is able to be loaded by this class
bool CImageLoaderXBM::isALoadableFileFormat(io::IReadFile* file) const
{
    constexpr u32 MAGIC = 0x57325243; // "W2RC"
    u32 id = 0;
    file->read(&id, sizeof(u32));

    return id == MAGIC;
}

u32 ReadVariable(io::IReadFile* file)
{
    file->seek(sizeof(u16), true); // nameId
    file->seek(sizeof(u16), true); // typeId
    u32 size;
    file->read(&size, sizeof(u32));
    u32 var;
    file->read(&var, size - 4);

    return var;
}

//! creates a surface from the file
IImage* CImageLoaderXBM::loadImage(io::IReadFile* file) const
{    
	u32 id = 0;
	file->read(&id, sizeof(u32));

    CR2WFileHeader fileheader;
    file->read(&fileheader, sizeof(CR2WFileHeader));

    if (fileheader.version > 163 || fileheader.version < 159)
    {
        return NULL;
    }
    // tables
    CR2WTable tableheaders[10];

    file->read(&tableheaders, sizeof(CR2WTable) * 10);

    // strings
    //file->seek(tableheaders[0].itemCount, true);
    u32 start = tableheaders[0].offset;
    u32 strings_size = tableheaders[0].itemCount;
    u32 crc = tableheaders[0].crc32;

    char* temp = new char[strings_size];
    file->read(temp, tableheaders[0].itemCount);

    // read the other tables

    // names
    constexpr long CR2WName_size = 8;
    file->seek(tableheaders[1].itemCount * CR2WName_size, true);

    // imports
    constexpr long CR2WImport_size = 8;
    file->seek(tableheaders[2].itemCount * CR2WImport_size, true);

    // properties
    constexpr long CR2WProperty_size = 16;
    file->seek(tableheaders[3].itemCount * CR2WProperty_size, true);

    // chunks
    CR2WExport chunks;
    file->read(&chunks, sizeof(CR2WExport));

    file->seek(chunks.dataOffset, false); // move to absolute file offset
    
    file->seek(1, true); // skip zero byte
    // read variables
    u32 width = ReadVariable(file);
    u32 height = ReadVariable(file);
    u16 compression = (u16)ReadVariable(file);
    u16 textureGroup = (u16)ReadVariable(file);
    u8 residentMipIndex = (u8)ReadVariable(file);
    u32 textureCacheKey = ReadVariable(file);
    file->seek(sizeof(u16), true); // end of variables flag
    file->seek(sizeof(u32), true); // unknown variable
    u32 mipsCount;
    file->read(&mipsCount, sizeof(u32));

    MipData mipData[12]; // max image size is 2048 x 2048 I hope...
    file->read(mipData, sizeof(MipData) * mipsCount);

    u32 residentMipSize;
    file->read(&residentMipSize, sizeof(u32));
    file->seek(4, true); // skip unknown fields
    
    //ddsHeader header;
    //header.Magic[0] = 'D';
    //header.Magic[1] = 'D';
    //header.Magic[2] = 'S';
    //header.Magic[3] = ' ';
    //header.Size = sizeof(ddsHeader);
    //header.Flags = DDSD_CAPS | DDSD_HEIGHT | DDSD_WIDTH | DDSD_PIXELFORMAT | DDSD_MIPMAPCOUNT | DDSD_LINEARSIZE;
    //header.Height = mipData[residentMipIndex].height;
    //header.Width = mipData[residentMipIndex].width;
    //header.PitchOrLinearSize = (header.Height * header.Width) / 2;
    //header.Depth = 0;
    //header.MipMapCount = mipsCount;
    //memset(header.Reserved1, 0, sizeof(u32) * 11);
    //header.PixelFormat.Size = sizeof(ddsPixelFormat);
    //header.PixelFormat.Flags = DDPF_FOURCC;
    //header.PixelFormat.FourCC = MAKEFOURCC('D', 'X', 'T', '1');
    //header.PixelFormat.RGBBitCount = 0;
    //header.PixelFormat.RBitMask = 0;
    //header.PixelFormat.GBitMask = 0;
    //header.PixelFormat.BBitMask = 0;
    //header.PixelFormat.ABitMask = 0;
    //header.Caps.caps1 = DDSCAPS1_TEXTURE | DDSCAPS1_COMPLEX | DDSCAPS1_MIPMAP;
    //header.Caps.caps2 = 0;
    //header.Caps.caps3 = 0;
    //header.Caps.caps4 = 0;
    //header.Reserved2 = 0;

    // find in string table
    char* compressionType = temp + 1; // skip initial zero
    char* nextCompression = temp + 1;
    u32 j = 0;
    for (int i = 0; i < compression; ++i)
    {
        compressionType = nextCompression;
        for (; j < strings_size; ++j)
        {
            if (*nextCompression == NULL)
                break;
            ++nextCompression;
        }
        ++nextCompression;
    }

    os::Printer::log("Compression type = ", compressionType, ELL_DEBUG);

    ECOLOR_FORMAT fmt = ECF_DXT1;
    if (strcmp(compressionType, "TCM_DXTAlpha") == 0)
    {
        fmt = ECF_DXT5;
    }
    else if (strcmp(compressionType, "TCM_NormalsGloss") == 0)
    {
        fmt = ECF_DXT5;
    }
    delete[] temp;

    u32 h = mipData[residentMipIndex].height;
    u32 w = mipData[residentMipIndex].width;
    u32 lod0DataSize = 0;

    if (fmt == ECF_DXT1)
    {
        lod0DataSize = ((w + 3) / 4) * ((h + 3) / 4) * 8;
    }
    else
    {
        lod0DataSize = ((w + 3) / 4) * ((h + 3) / 4) * 16;
    }

    u32 mipDataSize = residentMipSize - lod0DataSize;

    u8* lod0Data = DBG_NEW u8[lod0DataSize];
    file->read(lod0Data, lod0DataSize);

    u8* mipsData = DBG_NEW u8[mipDataSize];
    file->read(mipsData, mipDataSize);

	IImage* image = DBG_NEW CImage(fmt, core::dimension2d<u32>(w, h), lod0Data, true, true);
    image->setMipMapsData(mipsData, true, true);

    // image now owns the data
    return image;
}


//! creates a loader which is able to load xbms
IImageLoader* createImageLoaderXBM()
{
	return DBG_NEW CImageLoaderXBM();
}


} // end namespace video
} // end namespace irr

#endif
