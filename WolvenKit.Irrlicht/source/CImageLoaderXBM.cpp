#include "CImageLoaderXBM.h"

#ifdef _IRR_COMPILE_WITH_XBM_LOADER_

#include "IReadFile.h"
#include "os.h"
#include "CColorConverter.h"
#include "CImage.h"
#include "irrString.h"
#include "CD3D9Driver.h"
#include "dxtinfo.h"

//#define XBM_STORE_UNCOMPRESSED_IMAGES 1

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

static u32 ReadVariable(io::IReadFile* file)
{
#ifdef _DEBUG
    u16 nameId, typeId;
    file->read(&nameId, sizeof(u16));
    os::Printer::log("namdId = ", core::stringc(nameId), ELL_DEBUG);

    file->read(&typeId, sizeof(u16));
    os::Printer::log("typeId = ", core::stringc(typeId), ELL_DEBUG);
#else
    file->seek(sizeof(u16), true); // nameId
    file->seek(sizeof(u16), true); // typeId
#endif
    u32 size;
    file->read(&size, sizeof(u32));


    u32 var;
    file->read(&var, size - 4);

    return var;
}

//! creates a surface from the file
IImage* CImageLoaderXBM::loadImage(io::IReadFile* file) const
{    
    os::Printer::log("XBM file ", file->getFileName().c_str(), ELL_DEBUG);

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
    const u32 start = tableheaders[0].offset;
    const u32 strings_size = tableheaders[0].itemCount;
    const u32 crc = tableheaders[0].crc32;

    char* temp = DBG_NEW char[strings_size];
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
    const u32 width = ReadVariable(file);
    const u32 height = ReadVariable(file);
    const u16 compression = (u16)ReadVariable(file);
    const u16 textureGroup = (u16)ReadVariable(file);
    
    // could be a residentMipIndex or the textureCacheKey
    u8 residentMipIndex = 0;
    u32 textureCacheKey = 0;

    u16 nameId;
    file->read(&nameId, sizeof(u16));
    file->seek(sizeof(u16), true); // typeId
    u32 size;
    file->read(&size, sizeof(u32));
    size -= 4;

    // textureCacheKey is at the end of the list of variables so either it IS the end or the residentMipIndex is before it
    if(size == 4)
    {
        file->read(&textureCacheKey, size);
    }
    else if(size == 1)
    {
        u32 var;
        file->read(&var, size);
        residentMipIndex = (u8)var;

        textureCacheKey = ReadVariable(file);
    }
    
    file->seek(sizeof(u16), true); // end of variables flag
    file->seek(sizeof(u32), true); // unknown variable

    u32 mipsCount;
    file->read(&mipsCount, sizeof(u32));

    MipData mipData[12]; // max image size is 2048 x 2048 I hope...
    file->read(mipData, sizeof(MipData) * mipsCount);

    u32 residentMipSize;
    file->read(&residentMipSize, sizeof(u32));
    file->seek(4, true); // skip unknown fields
    
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

    const u32 h = mipData[residentMipIndex].height;
    const u32 w = mipData[residentMipIndex].width;

#ifdef XBM_STORE_UNCOMPRESSED_IMAGES
    // for now, use uncompressed so we can export the images into other formats
    u8* rawData = DBG_NEW u8[residentMipSize];
    file->read(rawData, residentMipSize);

    IImage*image = DBG_NEW CImage(ECF_A8R8G8B8, core::dimension2d<u32>(w, h));

    if (fmt == ECF_DXT1)
    {
        DecompressDXT1Image((u8*)image->lock(), w, h, rawData);
    }
    else
    {
        DecompressDXT5Image((u8*)image->lock(), w, h, rawData);
    }
    delete[] rawData;
#else
    // if we want to have compressed images in memory
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
#endif
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
