// Copyright (C) 2013-2016 Patryk Nadrowski
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_IMAGE_LOADER_PVR_H_INCLUDED__
#define __C_IMAGE_LOADER_PVR_H_INCLUDED__

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_PVR_LOADER_

#include "IImageLoader.h"

namespace irr
{
namespace video
{

#include "irrpack.h"

struct SPVRHeader
{
    u32 Version;
    u32 Flags;
    u64 PixelFormat;
    u32 ColourSpace;
    u32 ChannelType;
    u32 Height;
    u32 Width;
    u32 Depth;
    u32 NumSurfaces;
    u32 NumFaces;
    u32 MipMapCount;
    u32 MetDataSize;
} PACK_STRUCT;

#include "irrunpack.h"

class CImageLoaderPVR : public IImageLoader
{
public:
	virtual bool isALoadableFileExtension(const io::path& filename) const;

	virtual bool isALoadableFileFormat(io::IReadFile* file) const;

	virtual IImage* loadImage(io::IReadFile* file) const;

	virtual core::array<IImage*> loadImages(io::IReadFile* file, E_TEXTURE_TYPE* type) const;
};

}
}

#endif
#endif
