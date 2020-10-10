#include "CImageLoaderXBM.h"

#ifdef _IRR_COMPILE_WITH_XBM_LOADER_

#include "IReadFile.h"
#include "os.h"
#include "CColorConverter.h"
#include "CImage.h"
#include "irrString.h"
#include "CD3D9Driver.h"

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

#define XBM_STORE_UNCOMPRESSED_IMAGES 1

namespace irr
{
namespace video
{
#ifdef XBM_STORE_UNCOMPRESSED_IMAGES
    static int Unpack565(u8 const* packed, u8* colour) noexcept
    {
        // build the packed value
        const int value = (int)packed[0] | ((int)packed[1] << 8);

        // get the components in the stored range
        const u8 red = (u8)((value >> 11) & 0x1f);
        const u8 green = (u8)((value >> 5) & 0x3f);
        const u8 blue = (u8)(value & 0x1f);

        // scale up to 8 bits
        colour[0] = (red << 3) | (red >> 2);
        colour[1] = (green << 2) | (green >> 4);
        colour[2] = (blue << 3) | (blue >> 2);
        colour[3] = 255;

        // return the value
        return value;
    }

    void DecompressDXT1Colour(u8* rgba, void const* block)
    {
        // get the block bytes
        u8 const* bytes = reinterpret_cast<u8 const*>(block);

        // unpack the endpoints
        u8 codes[16];
        const int a = Unpack565(bytes, codes);
        const int b = Unpack565(bytes + 2, codes + 4);

        // generate the midpoints
        for (int i = 0; i < 3; ++i)
        {
            const int c = codes[i];
            const int d = codes[4 + i];

            if (a <= b)
            {
                codes[8 + i] = (u8)((c + d) / 2);
                codes[12 + i] = 0;
            }
            else
            {
                codes[8 + i] = (u8)((2 * c + d) / 3);
                codes[12 + i] = (u8)((c + 2 * d) / 3);
            }
        }

        // fill in alpha for the intermediate values
        codes[8 + 3] = 255;
        codes[12 + 3] = (a <= b) ? 0 : 255;

        // unpack the indices
        u8 indices[16];
        for (int i = 0; i < 4; ++i)
        {
            u8* ind = indices + 4 * i;
            const u8 packed = bytes[4 + i];

            ind[0] = packed & 0x3;
            ind[1] = (packed >> 2) & 0x3;
            ind[2] = (packed >> 4) & 0x3;
            ind[3] = (packed >> 6) & 0x3;
        }

        // store out the colours
        for (int i = 0; i < 16; ++i)
        {
            const u8 offset = 4 * indices[i];
            for (int j = 0; j < 4; ++j)
                rgba[4 * i + j] = codes[offset + j];
        }
    }

    void DecompressDXT5Colour(u8* rgba, void const* block)
    {
        // get the block bytes
        u8 const* bytes = reinterpret_cast<u8 const*>(block);

        // unpack the endpoints
        u8 codes[16];
        const int a = Unpack565(bytes, codes);
        const int b = Unpack565(bytes + 2, codes + 4);

        // generate the midpoints
        for (int i = 0; i < 3; ++i)
        {
            const int c = codes[i];
            const int d = codes[4 + i];

            codes[8 + i] = (u8)((2 * c + d) / 3);
            codes[12 + i] = (u8)((c + 2 * d) / 3);
        }

        // fill in alpha for the intermediate values
        codes[8 + 3] = 255;
        codes[12 + 3] = 255;

        // unpack the indices
        u8 indices[16];
        for (int i = 0; i < 4; ++i)
        {
            u8* ind = indices + 4 * i;
            const u8 packed = bytes[4 + i];

            ind[0] = packed & 0x3;
            ind[1] = (packed >> 2) & 0x3;
            ind[2] = (packed >> 4) & 0x3;
            ind[3] = (packed >> 6) & 0x3;
        }

        // store out the colours
        for (int i = 0; i < 16; ++i)
        {
            const u8 offset = 4 * indices[i];
            for (int j = 0; j < 4; ++j)
                rgba[4 * i + j] = codes[offset + j];
        }
    }

    void DecompressAlphaDxt5(u8* rgba, void const* block) noexcept
    {
        // get the two alpha values
        u8 const* bytes = reinterpret_cast<u8 const*>(block);
        const int alpha0 = bytes[0];
        const int alpha1 = bytes[1];

        // compare the values to build the codebook
        u8 codes[8];
        codes[0] = (u8)alpha0;
        codes[1] = (u8)alpha1;
        if (alpha0 <= alpha1)
        {
            // use 5-alpha codebook
            for (int i = 1; i < 5; ++i)
                codes[1 + i] = (u8)(((5 - i)*alpha0 + i * alpha1) / 5);
            codes[6] = 0;
            codes[7] = 255;
        }
        else
        {
            // use 7-alpha codebook
            for (int i = 1; i < 7; ++i)
                codes[1 + i] = (u8)(((7 - i)*alpha0 + i * alpha1) / 7);
        }

        // decode the indices
        u8 indices[16];
        u8 const* src = bytes + 2;
        u8* dest = indices;
        for (int i = 0; i < 2; ++i)
        {
            // grab 3 bytes
            int value = 0;
            for (int j = 0; j < 3; ++j)
            {
                const int byte = *src++;
                value |= (byte << 8 * j);
            }

            // unpack 8 3-bit values from it
            for (int j = 0; j < 8; ++j)
            {
                int index = (value >> 3 * j) & 0x7;
                *dest++ = (u8)index;
            }
        }

        // write out the indexed codebook values
        for (int i = 0; i < 16; ++i)
            rgba[4 * i + 3] = codes[indices[i]];
    }

    void CopyRGBA(u8 const* source, u8* dest)
    {
        // convert from bgra to rgba
        dest[0] = source[2];
        dest[1] = source[1];
        dest[2] = source[0];
        dest[3] = source[3];
        //for (int i = 0; i < 4; ++i)
        //    *dest++ = *source++;
    }

    void DecompressDXT1(u8* rgba, void const* block)
    {
        // get the block locations
        void const* colourBlock = block;
        void const* alphaBlock = block;

        // decompress colour
        DecompressDXT1Colour(rgba, colourBlock);
    }

    void DecompressDXT5(u8* rgba, void const* block)
    {
        // get the block locations
        void const* colourBlock = reinterpret_cast<u8 const*>(block) + 8;
        void const* alphaBlock = block;

        // decompress colour
        DecompressDXT5Colour(rgba, colourBlock);

        // decompress alpha separately if necessary
        DecompressAlphaDxt5(rgba, alphaBlock);
    }

    void DecompressDXT1Image(u8* rgba, int width, int height, void const* blocks)
    {
        int pitch = width * 4;
        constexpr int bytesPerBlock = 8;

        for (int y = 0; y < height; y += 4)
        {
            // initialise the block input
            u8 const* sourceBlock = reinterpret_cast<u8 const*>(blocks);
            sourceBlock += ((y / 4) * ((width + 3) / 4)) * bytesPerBlock;

            for (int x = 0; x < width; x += 4)
            {
                // decompress the block
                u8 targetRgba[4 * 16];
                DecompressDXT1(targetRgba, sourceBlock);

                // write the decompressed pixels to the correct image locations
                u8 const* sourcePixel = targetRgba;
                for (int py = 0; py < 4; ++py)
                {
                    for (int px = 0; px < 4; ++px)
                    {
                        // get the target location
                        int sx = x + px;
                        int sy = y + py;

                        // write if we're in the image
                        if (sx < width && sy < height)
                        {
                            // copy the rgba value
                            u8* targetPixel = rgba + pitch * sy + 4 * sx;
                            CopyRGBA(sourcePixel, targetPixel);
                        }

                        // advance to the next pixel
                        sourcePixel += 4;
                    }
                }

                // advance
                sourceBlock += bytesPerBlock;
            }
        }

    }

    void DecompressDXT5Image(u8* rgba, int width, int height, void const* blocks)
    {
        int pitch = width * 4;
        constexpr int bytesPerBlock = 16;

        for (int y = 0; y < height; y += 4)
        {
            // initialise the block input
            u8 const* sourceBlock = reinterpret_cast<u8 const*>(blocks);
            sourceBlock += ((y / 4) * ((width + 3) / 4)) * bytesPerBlock;

            for (int x = 0; x < width; x += 4)
            {
                // decompress the block
                u8 targetRgba[4 * 16];
                DecompressDXT5(targetRgba, sourceBlock);

                // write the decompressed pixels to the correct image locations
                u8 const* sourcePixel = targetRgba;
                for (int py = 0; py < 4; ++py)
                {
                    for (int px = 0; px < 4; ++px)
                    {
                        // get the target location
                        int sx = x + px;
                        int sy = y + py;

                        // write if we're in the image
                        if (sx < width && sy < height)
                        {
                            // copy the rgba value
                            u8* targetPixel = rgba + pitch * sy + 4 * sx;
                            CopyRGBA(sourcePixel, targetPixel);
                        }

                        // advance to the next pixel
                        sourcePixel += 4;
                    }
                }

                // advance
                sourceBlock += bytesPerBlock;
            }
        }

    }

#endif

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
