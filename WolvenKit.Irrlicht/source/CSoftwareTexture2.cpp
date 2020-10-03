// Copyright (C) 2002-2012 Nikolaus Gebhardt / Thomas Alten
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "IrrCompileConfig.h"
#ifdef _IRR_COMPILE_WITH_BURNINGSVIDEO_

#include "SoftwareDriver2_compile_config.h"
#include "SoftwareDriver2_helper.h"
#include "CSoftwareTexture2.h"
#include "CSoftwareDriver2.h"
#include "os.h"

namespace irr
{
namespace video
{

//! constructor
CSoftwareTexture2::CSoftwareTexture2(IImage* image, const io::path& name, u32 flags)
	: ITexture(name, ETT_2D), MipMapLOD(0), Flags ( flags ), OriginalFormat(video::ECF_UNKNOWN)
{
	#ifdef _DEBUG
	setDebugName("CSoftwareTexture2");
	#endif

#ifndef SOFTWARE_DRIVER_2_MIPMAPPING
	Flags &= ~GEN_MIPMAP;
#endif

	DriverType = EDT_BURNINGSVIDEO;
	ColorFormat = BURNINGSHADER_COLOR_FORMAT;
	IsRenderTarget = (Flags & IS_RENDERTARGET) != 0;
	
	memset32 ( MipMap, 0, sizeof ( MipMap ) );

	if (image)
	{
		bool IsCompressed = false;

		if (IImage::isCompressedFormat(image->getColorFormat()))
		{
			os::Printer::log("Texture compression not available.", ELL_ERROR);
			IsCompressed = true;
		}

		OriginalSize = image->getDimension();
		OriginalFormat = image->getColorFormat();

		core::dimension2d<u32> optSize(
				OriginalSize.getOptimalSize(0 != (Flags & NP2_SIZE),
				false, true,
				SOFTWARE_DRIVER_2_TEXTURE_MAXSIZE)
			);

		if (OriginalSize == optSize)
		{
			MipMap[0] = new CImage(BURNINGSHADER_COLOR_FORMAT, image->getDimension());

			if (!IsCompressed)
				image->copyTo(MipMap[0]);
		}
		else
		{
			char buf[256];
			core::stringw showName ( name );
			snprintf_irr ( buf, 256, "Burningvideo: Warning Texture %ls reformat %dx%d -> %dx%d,%d",
							showName.c_str(),
							OriginalSize.Width, OriginalSize.Height, optSize.Width, optSize.Height,
							BURNINGSHADER_COLOR_FORMAT
						);

			os::Printer::log ( buf, ELL_WARNING );
			MipMap[0] = new CImage(BURNINGSHADER_COLOR_FORMAT, optSize);

			if (!IsCompressed)
				image->copyToScalingBoxFilter ( MipMap[0],0, false );
		}

		Size = MipMap[MipMapLOD]->getDimension();
		Pitch = MipMap[MipMapLOD]->getPitch();

		OrigImageDataSizeInPixels = (f32) 0.3f * MipMap[0]->getImageDataSizeInPixels();

		HasMipMaps = (Flags & GEN_MIPMAP) != 0;

		regenerateMipMapLevels(image->getMipMapsData());
	}
}


//! destructor
CSoftwareTexture2::~CSoftwareTexture2()
{
	for ( s32 i = 0; i!= SOFTWARE_DRIVER_2_MIPMAPPING_MAX; ++i )
	{
		if ( MipMap[i] )
			MipMap[i]->drop();
	}
}


//! Regenerates the mip map levels of the texture. Useful after locking and
//! modifying the texture
void CSoftwareTexture2::regenerateMipMapLevels(void* data, u32 layer)
{
	if (!hasMipMaps())
		return;

	s32 i;

	// release
	for ( i = 1; i < SOFTWARE_DRIVER_2_MIPMAPPING_MAX; ++i )
	{
		if ( MipMap[i] )
			MipMap[i]->drop();
	}

	core::dimension2d<u32> newSize;
	core::dimension2d<u32> origSize = Size;

	for (i=1; i < SOFTWARE_DRIVER_2_MIPMAPPING_MAX; ++i)
	{
		newSize = MipMap[i-1]->getDimension();
		newSize.Width = core::s32_max ( 1, newSize.Width >> SOFTWARE_DRIVER_2_MIPMAPPING_SCALE );
		newSize.Height = core::s32_max ( 1, newSize.Height >> SOFTWARE_DRIVER_2_MIPMAPPING_SCALE );
		origSize.Width = core::s32_max(1, origSize.Width >> 1);
		origSize.Height = core::s32_max(1, origSize.Height >> 1);

		if (data)
		{
			if (OriginalFormat != BURNINGSHADER_COLOR_FORMAT)
			{
				IImage* tmpImage = new CImage(OriginalFormat, origSize, data, true, false);
				MipMap[i] = new CImage(BURNINGSHADER_COLOR_FORMAT, newSize);
				if (origSize==newSize)
					tmpImage->copyTo(MipMap[i]);
				else
					tmpImage->copyToScalingBoxFilter(MipMap[i]);
				tmpImage->drop();
			}
			else
			{
				if (origSize==newSize)
					MipMap[i] = new CImage(BURNINGSHADER_COLOR_FORMAT, newSize, data, false);
				else
				{
					MipMap[i] = new CImage(BURNINGSHADER_COLOR_FORMAT, newSize);
					IImage* tmpImage = new CImage(BURNINGSHADER_COLOR_FORMAT, origSize, data, true, false);
					tmpImage->copyToScalingBoxFilter(MipMap[i]);
					tmpImage->drop();
				}
			}
			data = (u8*)data +origSize.getArea()*IImage::getBitsPerPixelFromFormat(OriginalFormat)/8;
		}
		else
		{
			MipMap[i] = new CImage(BURNINGSHADER_COLOR_FORMAT, newSize);

			//static u32 color[] = { 0, 0xFFFF0000, 0xFF00FF00,0xFF0000FF,0xFFFFFF00,0xFFFF00FF,0xFF00FFFF,0xFF0F0F0F };
			MipMap[i]->fill ( 0 );
			MipMap[0]->copyToScalingBoxFilter( MipMap[i], 0, false );
		}
	}
}


/* Software Render Target 2 */

CSoftwareRenderTarget2::CSoftwareRenderTarget2(CBurningVideoDriver* driver) : Driver(driver)
{
	DriverType = EDT_BURNINGSVIDEO;

	Texture.set_used(1);
	Texture[0] = 0;
}

CSoftwareRenderTarget2::~CSoftwareRenderTarget2()
{
	if (Texture[0])
		Texture[0]->drop();
}

void CSoftwareRenderTarget2::setTexture(const core::array<ITexture*>& texture, ITexture* depthStencil, const core::array<E_CUBE_SURFACE>& cubeSurfaces)
{
	if (Texture != texture)
	{
		if (Texture[0])
			Texture[0]->drop();

		bool textureDetected = false;

		for (u32 i = 0; i < texture.size(); ++i)
		{
			if (texture[i] && texture[i]->getDriverType() == EDT_BURNINGSVIDEO)
			{
				Texture[0] = texture[i];
				Texture[0]->grab();
				textureDetected = true;

				break;
			}
		}

		if (!textureDetected)
			Texture[0] = 0;
	}
}

ITexture* CSoftwareRenderTarget2::getTexture() const
{
	return Texture[0];
}


} // end namespace video
} // end namespace irr

#endif // _IRR_COMPILE_WITH_BURNINGSVIDEO_
