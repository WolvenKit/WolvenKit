#include "CImageLoaderCube.h"

#ifdef _IRR_COMPILE_WITH_CUBE_LOADER_

#include "IReadFile.h"
#include "os.h"
#include "CColorConverter.h"
#include "CImage.h"
#include "irrString.h"
#include "debug.h"

namespace irr
{
namespace video
{

//! returns true if the file maybe is able to be loaded by this class
//! based on the file extension (e.g. ".cube")
bool CImageLoaderCube::isALoadableFileExtension(const io::path& filename) const
{
	return core::hasFileExtension ( filename, "w2cube" );
}

//! returns true if the file maybe is able to be loaded by this class
bool CImageLoaderCube::isALoadableFileFormat(io::IReadFile* file) const
{
    constexpr u32 MAGIC = 0x57325243; // "W2RC"
    u32 id = 0;
    file->read(&id, sizeof(u32));

    return id == MAGIC;
}

//! creates a surface from the file
IImage* CImageLoaderCube::loadImage(io::IReadFile* file) const
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

    file->seek(sizeof(u16), true); // end of variables flag
    
    file->seek(sizeof(u16) * 10, true);

    u32 bytesLeft = chunks.dataSize - (file->getPos() - chunks.dataOffset);

    /*
    For cubic environment maps, one or more faces of a cube are written to the file, 
    using either uncompressed or compressed formats, and all faces must be the same size. 
    Each face can have mipmaps defined, although all faces must have the same number of 
    mipmap levels. If a file contains a cube map, DDSCAPS_COMPLEX, DDSCAPS2_CUBEMAP, and
    one or more of DSCAPS2_CUBEMAP_POSITIVEX/Y/Z and/or DDSCAPS2_CUBEMAP_NEGATIVEX/Y/Z should
    be set. The faces are written in the order: positive x, negative x, positive y, negative y, 
    positive z, negative z, with any missing faces omitted. Each face is written with its main image, followed by any mipmap levels.
    */
    u8 header[128];
    file->read(&header, 128);

    D3DXIMAGE_INFO info;
    file->read(&info, sizeof(D3DXIMAGE_INFO));

    // start of cube map data?
    // image now owns the data
    u32 w = 0;
    u32 h = 0;
    IImage*image = DBG_NEW CImage(ECF_A8R8G8B8, core::dimension2d<u32>(w, h));
    return image;
}


//! creates a loader which is able to load cubemaps
IImageLoader* createImageLoaderCube()
{
	return DBG_NEW CImageLoaderCube();
}


} // end namespace video
} // end namespace irr

#endif
