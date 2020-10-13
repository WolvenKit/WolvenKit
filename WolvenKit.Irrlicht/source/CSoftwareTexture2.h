// Copyright (C) 2002-2012 Nikolaus Gebhardt / Thomas Alten
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_SOFTWARE_2_TEXTURE_H_INCLUDED__
#define __C_SOFTWARE_2_TEXTURE_H_INCLUDED__

#include "SoftwareDriver2_compile_config.h"

#include "ITexture.h"
#include "IRenderTarget.h"
#include "CImage.h"

namespace irr
{
namespace video
{

class CBurningVideoDriver;

/*!
	interface for a Video Driver dependent Texture.
*/
class CSoftwareTexture2 : public ITexture
{
public:

	//! constructor
	enum eTex2Flags
	{
		GEN_MIPMAP	= 1,
		IS_RENDERTARGET	= 2,
		NP2_SIZE	= 4,
	};
	CSoftwareTexture2(IImage* surface, const io::path& name, u32 flags);

	//! destructor
	virtual ~CSoftwareTexture2();

	//! lock function
	virtual void* lock(E_TEXTURE_LOCK_MODE mode, u32 mipmapLevel, u32 layer, E_TEXTURE_LOCK_FLAGS lockFlags = ETLF_FLIP_Y_UP_RTT) _IRR_OVERRIDE_
	{
		if (Flags & GEN_MIPMAP)
		{
			MipMapLOD = mipmapLevel;
			Size = MipMap[MipMapLOD]->getDimension();
			Pitch = MipMap[MipMapLOD]->getPitch();
		}

		return MipMap[MipMapLOD]->getData();
	}

	//! unlock function
	virtual void unlock() _IRR_OVERRIDE_
	{
	}

	//! Returns the size of the largest mipmap.
	f32 getLODFactor( const f32 texArea ) const
	{
		return OrigImageDataSizeInPixels * texArea;
		//return MipMap[0]->getImageDataSizeInPixels () * texArea;
	}

	//! returns unoptimized surface
	virtual CImage* getImage() const
	{
		return MipMap[0];
	}

	//! returns texture surface
	virtual CImage* getTexture() const
	{
		return MipMap[MipMapLOD];
	}

	virtual void regenerateMipMapLevels(void* data = 0, u32 layer = 0) _IRR_OVERRIDE_;

private:
	f32 OrigImageDataSizeInPixels;

	CImage * MipMap[SOFTWARE_DRIVER_2_MIPMAPPING_MAX];

	u32 MipMapLOD;
	u32 Flags;
	ECOLOR_FORMAT OriginalFormat;
};

/*!
interface for a Video Driver dependent render target.
*/
class CSoftwareRenderTarget2 : public IRenderTarget
{
public:
	CSoftwareRenderTarget2(CBurningVideoDriver* driver);
	virtual ~CSoftwareRenderTarget2();

	virtual void setTexture(const core::array<ITexture*>& texture, ITexture* depthStencil, const core::array<E_CUBE_SURFACE>& cubeSurfaces) _IRR_OVERRIDE_;

	ITexture* getTexture() const;

protected:
	CBurningVideoDriver* Driver;
};


} // end namespace video
} // end namespace irr

#endif

