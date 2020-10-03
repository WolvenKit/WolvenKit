// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_DIRECTX9_TEXTURE_H_INCLUDED__
#define __C_DIRECTX9_TEXTURE_H_INCLUDED__

#include "IrrCompileConfig.h"
#ifdef _IRR_COMPILE_WITH_DIRECT3D_9_

#include "irrArray.h"
#include "ITexture.h"
#include "IImage.h"
#if defined(__BORLANDC__) || defined (__BCPLUSPLUS__)
#include "irrMath.h"    // needed by borland for sqrtf define
#endif
#include <d3d9.h>

namespace irr
{
namespace video
{

class CD3D9Driver;

class CD3D9Texture : public ITexture
{
public:
	CD3D9Texture(const io::path& name, const core::array<IImage*>& image, E_TEXTURE_TYPE type, CD3D9Driver* driver);

	CD3D9Texture(CD3D9Driver* driver, const core::dimension2d<u32>& size, const io::path& name, E_TEXTURE_TYPE type, const ECOLOR_FORMAT format = ECF_UNKNOWN);

	virtual ~CD3D9Texture();

	virtual void* lock(E_TEXTURE_LOCK_MODE mode = ETLM_READ_WRITE, u32 mipmapLevel=0, u32 layer = 0, E_TEXTURE_LOCK_FLAGS lockFlags = ETLF_FLIP_Y_UP_RTT) _IRR_OVERRIDE_;

	virtual void unlock() _IRR_OVERRIDE_;

	virtual void regenerateMipMapLevels(void* data = 0, u32 layer = 0) _IRR_OVERRIDE_;

	IDirect3DBaseTexture9* getDX9BaseTexture() const;
	IDirect3DTexture9* getDX9Texture() const;
	IDirect3DCubeTexture9* getDX9CubeTexture() const;

private:
	friend class CD3D9Driver;

	void releaseTexture();

	void generateRenderTarget();

	ECOLOR_FORMAT getBestColorFormat(ECOLOR_FORMAT format);

	void getImageValues(const IImage* image);

	void uploadTexture(u32 layer, u32 level, void* data);

	CD3D9Driver* Driver;

	D3DFORMAT InternalFormat;

	bool LockReadOnly;
	void* LockData;
	u32 LockLayer;

	bool AutoGenerateMipMaps;

	IDirect3DDevice9* Device;
	IDirect3DTexture9* Texture;
	IDirect3DCubeTexture9* CubeTexture;
	IDirect3DSurface9* RTTSurface;
};

}
}

#endif
#endif
