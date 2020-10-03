// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "IrrCompileConfig.h"
#ifdef _IRR_COMPILE_WITH_SOFTWARE_

#include "CSoftwareTexture.h"
#include "CSoftwareDriver.h"
#include "os.h"

namespace irr
{
namespace video
{

//! constructor
CSoftwareTexture::CSoftwareTexture(IImage* image, const io::path& name, bool renderTarget)
	: ITexture(name, ETT_2D), Texture(0)
{
	#ifdef _DEBUG
	setDebugName("CSoftwareTexture");
	#endif

	DriverType = EDT_SOFTWARE;
	ColorFormat = ECF_A1R5G5B5;
	HasMipMaps = false;
	IsRenderTarget = renderTarget;

	if (image)
	{
		bool IsCompressed = false;

		if(IImage::isCompressedFormat(image->getColorFormat()))
		{
			os::Printer::log("Texture compression not available.", ELL_ERROR);
			IsCompressed = true;
		}

		OriginalSize = image->getDimension();
		core::dimension2d<u32> optSize = OriginalSize.getOptimalSize();

		Image = new CImage(ECF_A1R5G5B5, OriginalSize);

		if (!IsCompressed)
			image->copyTo(Image);

		if (optSize == OriginalSize)
		{
			Texture = Image;
			Texture->grab();
		}
		else
		{
			Texture = new CImage(ECF_A1R5G5B5, optSize);
			Image->copyToScaling(Texture);
		}

		Size = Texture->getDimension();
		Pitch = Texture->getDimension().Width * 2;
	}
}



//! destructor
CSoftwareTexture::~CSoftwareTexture()
{
	if (Image)
		Image->drop();

	if (Texture)
		Texture->drop();
}



//! lock function
void* CSoftwareTexture::lock(E_TEXTURE_LOCK_MODE mode, u32 mipmapLevel, u32 layer, E_TEXTURE_LOCK_FLAGS lockFlags)
{
	return Image->getData();
}



//! unlock function
void CSoftwareTexture::unlock()
{
	if (Image != Texture)
	{
		os::Printer::log("Performance warning, slow unlock of non power of 2 texture.", ELL_WARNING);
		Image->copyToScaling(Texture);
	}
}


//! returns unoptimized surface
CImage* CSoftwareTexture::getImage()
{
	return Image;
}


//! returns texture surface
CImage* CSoftwareTexture::getTexture()
{
	return Texture;
}

void CSoftwareTexture::regenerateMipMapLevels(void* data, u32 layer)
{
	// our software textures don't have mip maps
}


/* Software Render Target */

CSoftwareRenderTarget::CSoftwareRenderTarget(CSoftwareDriver* driver) : Driver(driver)
{
	DriverType = EDT_SOFTWARE;

	Texture.set_used(1);
	Texture[0] = 0;
}

CSoftwareRenderTarget::~CSoftwareRenderTarget()
{
	if (Texture[0])
		Texture[0]->drop();
}

void CSoftwareRenderTarget::setTexture(const core::array<ITexture*>& texture, ITexture* depthStencil, const core::array<E_CUBE_SURFACE>& cubeSurfaces)
{
	if (Texture != texture)
	{
		if (Texture[0])
			Texture[0]->drop();

		bool textureDetected = false;

		for (u32 i = 0; i < texture.size(); ++i)
		{
			if (texture[i] && texture[i]->getDriverType() == EDT_SOFTWARE)
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

ITexture* CSoftwareRenderTarget::getTexture() const
{
	return Texture[0];
}


} // end namespace video
} // end namespace irr

#endif // _IRR_COMPILE_WITH_SOFTWARE_

