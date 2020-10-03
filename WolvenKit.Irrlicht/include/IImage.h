// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_IMAGE_H_INCLUDED__
#define __I_IMAGE_H_INCLUDED__

#include "IReferenceCounted.h"
#include "position2d.h"
#include "rect.h"
#include "SColor.h"
#include "irrAllocator.h"
#include <string.h>

namespace irr
{
namespace video
{

//! Interface for software image data.
/** Image loaders create these images from files. IVideoDrivers convert
these images into their (hardware) textures.
NOTE: Floating point formats are not well supported yet. Basically only getData() works for them.
*/
class IImage : public virtual IReferenceCounted
{
public:

	//! constructor
	IImage(ECOLOR_FORMAT format, const core::dimension2d<u32>& size, bool deleteMemory) :
		Format(format), Size(size), Data(0), MipMapsData(0), BytesPerPixel(0), Pitch(0), DeleteMemory(deleteMemory), DeleteMipMapsMemory(false)
	{
		BytesPerPixel = getBitsPerPixelFromFormat(Format) / 8;
		Pitch = BytesPerPixel * Size.Width;
	}

	//! destructor
	virtual ~IImage()
	{
		if (DeleteMemory)
			delete[] Data;

		if (DeleteMipMapsMemory)
			Allocator.deallocate(MipMapsData);
	}

	//! Returns the color format
	ECOLOR_FORMAT getColorFormat() const
	{
		return Format;
	}

	//! Returns width and height of image data.
	const core::dimension2d<u32>& getDimension() const
	{
		return Size;
	}

	//! Returns bits per pixel.
	u32 getBitsPerPixel() const
	{

		return getBitsPerPixelFromFormat(Format);
	}

	//! Returns bytes per pixel
	u32 getBytesPerPixel() const
	{
		return BytesPerPixel;
	}

	//! Returns image data size in bytes
	u32 getImageDataSizeInBytes() const
	{
		return getDataSizeFromFormat(Format, Size.Width, Size.Height);
	}

	//! Returns image data size in pixels
	u32 getImageDataSizeInPixels() const
	{
		return Size.Width * Size.Height;
	}

	//! Returns pitch of image
	u32 getPitch() const
	{
		return Pitch;
	}

	//! Returns mask for red value of a pixel
	u32 getRedMask() const
	{
		switch (Format)
		{
		case ECF_A1R5G5B5:
			return 0x1F << 10;
		case ECF_R5G6B5:
			return 0x1F << 11;
		case ECF_R8G8B8:
			return 0x00FF0000;
		case ECF_A8R8G8B8:
			return 0x00FF0000;
		default:
			return 0x0;
		}
	}

	//! Returns mask for green value of a pixel
	u32 getGreenMask() const
	{
		switch (Format)
		{
		case ECF_A1R5G5B5:
			return 0x1F << 5;
		case ECF_R5G6B5:
			return 0x3F << 5;
		case ECF_R8G8B8:
			return 0x0000FF00;
		case ECF_A8R8G8B8:
			return 0x0000FF00;
		default:
			return 0x0;
		}
	}

	//! Returns mask for blue value of a pixel
	u32 getBlueMask() const
	{
		switch (Format)
		{
		case ECF_A1R5G5B5:
			return 0x1F;
		case ECF_R5G6B5:
			return 0x1F;
		case ECF_R8G8B8:
			return 0x000000FF;
		case ECF_A8R8G8B8:
			return 0x000000FF;
		default:
			return 0x0;
		}
	}

	//! Returns mask for alpha value of a pixel
	u32 getAlphaMask() const
	{
		switch (Format)
		{
		case ECF_A1R5G5B5:
			return 0x1 << 15;
		case ECF_R5G6B5:
			return 0x0;
		case ECF_R8G8B8:
			return 0x0;
		case ECF_A8R8G8B8:
			return 0xFF000000;
		default:
			return 0x0;
		}
	}

	//! Use this to get a pointer to the image data.
	/**
	\return Pointer to the image data. What type of data is pointed to
	depends on the color format of the image. For example if the color
	format is ECF_A8R8G8B8, it is of u32. */
	void* getData() const
	{
		return Data;
	}

	//! Lock function. Use this to get a pointer to the image data.
	/** Use getData instead.
	\return Pointer to the image data. What type of data is pointed to
	depends on the color format of the image. For example if the color
	format is ECF_A8R8G8B8, it is of u32. Be sure to call unlock() after
	you don't need the pointer any more. */
	_IRR_DEPRECATED_ void* lock()
	{
		return getData();
	}

	//! Unlock function.
	/** Should be called after the pointer received by lock() is not
	needed anymore. */
	_IRR_DEPRECATED_ void unlock()
	{
	}

	//! Get mipmaps data.
	void* getMipMapsData() const
	{
		return MipMapsData;
	}

	//! Set mipmaps data.
	/** This method allows you to put custom mipmaps data for
	image.
	\param data A byte array with pixel color information
	\param ownForeignMemory If true, the image will use the data
	pointer directly and own it afterward. If false, the memory
	will by copied internally.
	\param deleteMemory Whether the memory is deallocated upon
	destruction. */
	void setMipMapsData(void* data, bool ownForeignMemory, bool deleteMemory)
	{
		if (data != MipMapsData)
		{
			if (DeleteMipMapsMemory)
			{
				Allocator.deallocate(MipMapsData);

				DeleteMipMapsMemory = false;
			}

			if (data)
			{
				if (ownForeignMemory)
				{
					MipMapsData = static_cast<u8*>(data);

					DeleteMipMapsMemory = deleteMemory;
				}
				else
				{
					u32 dataSize = 0;
					u32 width = Size.Width;
					u32 height = Size.Height;

					do
					{
						if (width > 1)
							width >>= 1;

						if (height > 1)
							height >>= 1;

						dataSize += getDataSizeFromFormat(Format, width, height);
					} while (width != 1 || height != 1);

					MipMapsData = Allocator.allocate(dataSize);
					memcpy(MipMapsData, data, dataSize);

					DeleteMipMapsMemory = true;
				}
			}
			else
			{
				MipMapsData = 0;
			}
		}
	}

	//! Returns a pixel
	virtual SColor getPixel(u32 x, u32 y) const = 0;

	//! Sets a pixel
	virtual void setPixel(u32 x, u32 y, const SColor &color, bool blend = false ) = 0;

	//! Copies the image into the target, scaling the image to fit
	virtual void copyToScaling(void* target, u32 width, u32 height, ECOLOR_FORMAT format=ECF_A8R8G8B8, u32 pitch=0) =0;

	//! Copies the image into the target, scaling the image to fit
	virtual void copyToScaling(IImage* target) =0;

	//! copies this surface into another
	virtual void copyTo(IImage* target, const core::position2d<s32>& pos=core::position2d<s32>(0,0)) =0;

	//! copies this surface into another
	virtual void copyTo(IImage* target, const core::position2d<s32>& pos, const core::rect<s32>& sourceRect, const core::rect<s32>* clipRect=0) =0;

	//! copies this surface into another, using the alpha mask and cliprect and a color to add with
	/**	\param combineAlpha - When true then combine alpha channels. When false replace target image alpha with source image alpha.
	*/
	virtual void copyToWithAlpha(IImage* target, const core::position2d<s32>& pos,
			const core::rect<s32>& sourceRect, const SColor &color,
			const core::rect<s32>* clipRect = 0,
			bool combineAlpha=false) =0;

	//! copies this surface into another, scaling it to fit, applying a box filter
	virtual void copyToScalingBoxFilter(IImage* target, s32 bias = 0, bool blend = false) = 0;

	//! fills the surface with given color
	virtual void fill(const SColor &color) =0;

	//! Inform whether the image is compressed
	_IRR_DEPRECATED_ bool isCompressed() const
	{
		return IImage::isCompressedFormat(Format);
	}

	//! Check whether the image has MipMaps
	/** \return True if image has MipMaps, else false. */
	_IRR_DEPRECATED_ bool hasMipMaps() const
	{
		return (getMipMapsData() != 0);
	}

	//! get the amount of Bits per Pixel of the given color format
	static u32 getBitsPerPixelFromFormat(const ECOLOR_FORMAT format)
	{
		switch(format)
		{
		case ECF_A1R5G5B5:
			return 16;
		case ECF_R5G6B5:
			return 16;
		case ECF_R8G8B8:
			return 24;
		case ECF_A8R8G8B8:
			return 32;
		case ECF_DXT1:
			return 16;
		case ECF_DXT2:
		case ECF_DXT3:
		case ECF_DXT4:
		case ECF_DXT5:
			return 32;
		case ECF_PVRTC_RGB2:
			return 12;
		case ECF_PVRTC_ARGB2:
		case ECF_PVRTC2_ARGB2:
			return 16;
		case ECF_PVRTC_RGB4:
			return 24;
		case ECF_PVRTC_ARGB4:
		case ECF_PVRTC2_ARGB4:
			return 32;
		case ECF_ETC1:
		case ECF_ETC2_RGB:
			return 24;
		case ECF_ETC2_ARGB:
			return 32;
		case ECF_D16:
			return 16;
		case ECF_D32:
			return 32;
		case ECF_D24S8:
			return 32;
		case ECF_R8:
			return 8;
		case ECF_R8G8:
			return 16;
		case ECF_R16:
			return 16;
		case ECF_R16G16:
			return 32;
		case ECF_R16F:
			return 16;
		case ECF_G16R16F:
			return 32;
		case ECF_A16B16G16R16F:
			return 64;
		case ECF_R32F:
			return 32;
		case ECF_G32R32F:
			return 64;
		case ECF_A32B32G32R32F:
			return 128;
		default:
			return 0;
		}
	}

	//! calculate image data size in bytes for selected format, width and height.
	static u32 getDataSizeFromFormat(ECOLOR_FORMAT format, u32 width, u32 height)
	{
		u32 imageSize = 0;

		switch (format)
		{
		case ECF_DXT1:
			imageSize = ((width + 3) / 4) * ((height + 3) / 4) * 8;
			break;
		case ECF_DXT2:
		case ECF_DXT3:
		case ECF_DXT4:
		case ECF_DXT5:
			imageSize = ((width + 3) / 4) * ((height + 3) / 4) * 16;
			break;
		case ECF_PVRTC_RGB2:
		case ECF_PVRTC_ARGB2:
			imageSize = (core::max_<u32>(width, 16) * core::max_<u32>(height, 8) * 2 + 7) / 8;
			break;
		case ECF_PVRTC_RGB4:
		case ECF_PVRTC_ARGB4:
			imageSize = (core::max_<u32>(width, 8) * core::max_<u32>(height, 8) * 4 + 7) / 8;
			break;
		case ECF_PVRTC2_ARGB2:
			imageSize = core::ceil32(width / 8.0f) * core::ceil32(height / 4.0f) * 8;
			break;
		case ECF_PVRTC2_ARGB4:
		case ECF_ETC1:
		case ECF_ETC2_RGB:
			imageSize = core::ceil32(width / 4.0f) * core::ceil32(height / 4.0f) * 8;
			break;
		case ECF_ETC2_ARGB:
			imageSize = core::ceil32(width / 4.0f) * core::ceil32(height / 4.0f) * 16;
			break;
		default: // uncompressed formats
			imageSize = getBitsPerPixelFromFormat(format) / 8 * width;
			imageSize *= height;
			break;
		}

		return imageSize;
	}

	//! check if this is compressed color format
	static bool isCompressedFormat(const ECOLOR_FORMAT format)
	{
		switch(format)
		{
			case ECF_DXT1:
			case ECF_DXT2:
			case ECF_DXT3:
			case ECF_DXT4:
			case ECF_DXT5:
			case ECF_PVRTC_RGB2:
			case ECF_PVRTC_ARGB2:
			case ECF_PVRTC2_ARGB2:
			case ECF_PVRTC_RGB4:
			case ECF_PVRTC_ARGB4:
			case ECF_PVRTC2_ARGB4:
			case ECF_ETC1:
			case ECF_ETC2_RGB:
			case ECF_ETC2_ARGB:
				return true;
			default:
				return false;
		}
	}

	//! check if the color format is only viable for depth/stencil textures
	static bool isDepthFormat(const ECOLOR_FORMAT format)
	{
		switch(format)
		{
			case ECF_D16:
			case ECF_D32:
			case ECF_D24S8:
				return true;
			default:
				return false;
		}
	}

	//! Check if the color format is only viable for RenderTarget textures
	/** Since we don't have support for e.g. floating point IImage formats
	one should test if the color format can be used for arbitrary usage, or
	if it is restricted to RTTs. */
	static bool isRenderTargetOnlyFormat(const ECOLOR_FORMAT format)
	{
		switch(format)
		{
			case ECF_A1R5G5B5:
			case ECF_R5G6B5:
			case ECF_R8G8B8:
			case ECF_A8R8G8B8:
			case ECF_DXT1:
			case ECF_DXT2:
			case ECF_DXT3:
			case ECF_DXT4:
			case ECF_DXT5:
			case ECF_PVRTC_RGB2:
			case ECF_PVRTC_ARGB2:
			case ECF_PVRTC2_ARGB2:
			case ECF_PVRTC_RGB4:
			case ECF_PVRTC_ARGB4:
			case ECF_PVRTC2_ARGB4:
			case ECF_ETC1:
			case ECF_ETC2_RGB:
			case ECF_ETC2_ARGB:
				return false;
			default:
				// All floating point formats. Function name should really be isFloatingPointFormat.
				return true;
		}
	}

protected:
	ECOLOR_FORMAT Format;
	core::dimension2d<u32> Size;

	u8* Data;
	u8* MipMapsData;

	u32 BytesPerPixel;
	u32 Pitch;

	bool DeleteMemory;
	bool DeleteMipMapsMemory;

	core::irrAllocator<u8> Allocator;
};

} // end namespace video
} // end namespace irr

#endif

