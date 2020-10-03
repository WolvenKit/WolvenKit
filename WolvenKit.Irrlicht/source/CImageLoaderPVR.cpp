// Copyright (C) 2013-2016 Patryk Nadrowski
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "CImageLoaderPVR.h"

#ifdef _IRR_COMPILE_WITH_PVR_LOADER_

#include "IReadFile.h"
#include "os.h"
#include "CImage.h"
#include "irrString.h"

namespace irr
{
namespace video
{

bool CImageLoaderPVR::isALoadableFileExtension(const io::path& filename) const
{
	return core::hasFileExtension(filename, "pvr");
}

bool CImageLoaderPVR::isALoadableFileFormat(io::IReadFile* file) const
{
	if (!file)
		return false;

	c8 fourCC[4];
	file->seek(0);
	file->read(&fourCC, 4);

	/*if (header.Version == 0x03525650) // TO-DO - fix endiannes
	{
		fourCC[0] = os::Byteswap::byteswap(fourCC[0]);
		fourCC[1] = os::Byteswap::byteswap(fourCC[1]);
		fourCC[2] = os::Byteswap::byteswap(fourCC[2]);
		fourCC[3] = os::Byteswap::byteswap(fourCC[3]);
	}*/

	return (fourCC[0] == 'P' && fourCC[1] == 'V' && fourCC[2] == 'R');
}

IImage* CImageLoaderPVR::loadImage(io::IReadFile* file) const
{
	core::array<IImage*> imageArray = loadImages(file, 0);

	const u32 imageCount = imageArray.size();

	for (u32 i = 1; i < imageCount; ++i)
	{
		if (imageArray[i])
			imageArray[i]->drop();
	}

	if (imageCount > 1)
		imageArray.erase(1, imageCount - 1);

	return (imageCount > 1) ? imageArray[0] : 0;
}

core::array<IImage*> CImageLoaderPVR::loadImages(io::IReadFile* file, E_TEXTURE_TYPE* type) const
{
	// TO-DO -> use 'move' feature from C++11 standard.

	SPVRHeader header;

	core::array<IImage*> imageArray;
	core::array<u8*> mipMapsDataArray;

	ECOLOR_FORMAT format = ECF_UNKNOWN;
	u32 dataSize = 0;

	file->seek(0);
	file->read(&header, sizeof(SPVRHeader));

	/*if (header.Version == 0x03525650) // TO-DO - fix endiannes
	{
		header.Flags = os::Byteswap::byteswap(header.Flags);
		header.PixelFormat = os::Byteswap::byteswap(header.PixelFormat);
		header.ColourSpace = os::Byteswap::byteswap(header.ColourSpace);
		header.ChannelType = os::Byteswap::byteswap(header.ChannelType);
		header.Height = os::Byteswap::byteswap(header.Height);
		header.Width = os::Byteswap::byteswap(header.Width);
		header.Depth = os::Byteswap::byteswap(header.Depth);
		header.NumSurfaces = os::Byteswap::byteswap(header.NumSurfaces);
		header.NumFaces = os::Byteswap::byteswap(header.NumFaces);
		header.MipMapCount = os::Byteswap::byteswap(header.MipMapCount);
		header.MetDataSize = os::Byteswap::byteswap(header.MetDataSize);
	}*/

	c8 fourCC[4];
	u32 key;
	u32 helperDataSize;

	if (header.MetDataSize > 0)
	{
		file->read(&fourCC, 4);
		file->read(&key, sizeof(u32));
		file->read(&helperDataSize, sizeof(u32));
		file->seek(helperDataSize, true);
	}

	if (header.PixelFormat & 0xFFFFFFFF00000000)
	{
		switch (header.PixelFormat)
		{
		case 0x505050162677261:
			format = ECF_A1R5G5B5;
			break;
		case 0x5060500626772:
			format = ECF_R5G6B5;
			break;
		case 0x8080800626772:
			format = ECF_R8G8B8;
			break;
		case 0x808080861726762:
			format = ECF_A8R8G8B8;
			break;
		default:
			break;
		}
	}
	else // Compressed texture formats
	{
		switch (header.PixelFormat)
		{
		case 0: // PVRTC 2bpp RGB
			format = ECF_PVRTC_RGB2;
			break;
		case 1: // PVRTC 2bpp RGBA
			format = ECF_PVRTC_ARGB2;
			break;
		case 2: // PVRTC 4bpp RGB
			format = ECF_PVRTC_RGB4;
			break;
		case 3: // PVRTC 4bpp RGBA
			format = ECF_PVRTC_ARGB4;
			break;
		case 4: // PVRTC-II 2bpp
			format = ECF_PVRTC2_ARGB2;
			break;
		case 5: // PVRTC-II 4bpp
			format = ECF_PVRTC2_ARGB4;
			break;
		case 6: // ETC1
			format = ECF_ETC1;
			break;
		case 7: // DXT1 / BC1
			format = ECF_DXT1;
			break;
		case 8: // DXT2
		case 9: // DXT3 / BC2
			format = ECF_DXT3;
			break;
		case 10: // DXT4
		case 11: // DXT5 / BC3
			format = ECF_DXT5;
			break;
		case 22: // ETC2 RGB
			format = ECF_ETC2_RGB;
			break;
		case 23: // ETC2 RGBA
			format = ECF_ETC2_ARGB;
			break;
		default:
			format = ECF_UNKNOWN;
			break;
		}
	}

	if (format != ECF_UNKNOWN)
	{
		imageArray.set_used(1);
		E_TEXTURE_TYPE tmpType = ETT_2D;

		// check for texture type

		if (header.NumFaces == 6) // cube map
		{
			imageArray.set_used(6);
			tmpType = ETT_CUBEMAP;
		}
		else if (header.Depth > 1) // 3d texture
		{
			// TO-DO
		}
		else if (header.NumSurfaces > 1) // texture array
		{
			// To-DO
		}

		if (type)
			*type = tmpType;

		// prepare mipmaps data

		dataSize = 0;

		for (u32 i = 1; i < header.MipMapCount; ++i)
		{
			u32 tmpWidth = header.Width >> i;
			u32 tmpHeight = header.Height >> i;

			dataSize += IImage::getDataSizeFromFormat(format, tmpWidth, tmpHeight);
		}

		if (header.MipMapCount > 1)
		{
			mipMapsDataArray.set_used(imageArray.size());

			for (u32 j = 0; j < mipMapsDataArray.size(); ++j)
				mipMapsDataArray[j] = new u8[dataSize];
		}

		// read texture

		dataSize = 0;
		long offset = 0;

		for (u32 i = 0; i < header.MipMapCount; ++i)
		{
			if (i == 0)
			{
				for (u32 j = 0; j < imageArray.size(); ++j)
				{
					dataSize = IImage::getDataSizeFromFormat(format, header.Width, header.Height);

					u8* data = new u8[dataSize];
					file->read(data, dataSize);

					imageArray[j] = new CImage(format, core::dimension2d<u32>(header.Width, header.Height), data, true, true);
				}
			}
			else
			{
				u32 tmpWidth = header.Width >> i;
				u32 tmpHeight = header.Height >> i;

				dataSize = IImage::getDataSizeFromFormat(format, tmpWidth, tmpHeight);

				for (u32 j = 0; j < imageArray.size(); ++j)
					file->read(mipMapsDataArray[j] + offset, dataSize);

				offset += dataSize;
			}
		}

		// assign mipmaps data

		for (u32 i = 0; i < mipMapsDataArray.size(); ++i)
			imageArray[i]->setMipMapsData(mipMapsDataArray[i], true, true);
	}

	return imageArray;
}

IImageLoader* createImageLoaderPVR()
{
	return new CImageLoaderPVR();
}

}
}

#endif
