// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_DIRECT3D_9_

#include "CD3D9Texture.h"
#include "CD3D9Driver.h"
#include "os.h"

namespace irr
{
namespace video
{

CD3D9Texture::CD3D9Texture(const io::path& name, const core::array<IImage*>& image, E_TEXTURE_TYPE type, CD3D9Driver* driver)
	: ITexture(name, type), Driver(driver), InternalFormat(D3DFMT_UNKNOWN), LockReadOnly(false), LockData(0), LockLayer(0),
	AutoGenerateMipMaps(false), Device(0), Texture(0), CubeTexture(0), RTTSurface(0)
{
#ifdef _DEBUG
	setDebugName("CD3D9Texture");
#endif

	_IRR_DEBUG_BREAK_IF(image.size() == 0)

	Device=driver->getExposedVideoData().D3D9.D3DDev9;

	if (Device)
		Device->AddRef();

	DriverType = Driver->getDriverType();
	HasMipMaps = Driver->getTextureCreationFlag(ETCF_CREATE_MIP_MAPS);
	AutoGenerateMipMaps = Driver->queryFeature(EVDF_MIP_MAP_AUTO_UPDATE);

	getImageValues(image[0]);

	core::array<IImage*> tmpImage = image;

	bool releaseImageData = false;

	if (OriginalSize != Size || OriginalColorFormat != ColorFormat)
	{
		releaseImageData = true;

		for (u32 i = 0; i < image.size(); ++i)
		{
			tmpImage[i] = Driver->createImage(ColorFormat, Size);

			if (image[i]->getDimension() == Size)
				image[i]->copyTo(tmpImage[i]);
			else
				image[i]->copyToScaling(tmpImage[i]);
		}
	}

	DWORD flags = 0;

	if (HasMipMaps && AutoGenerateMipMaps)
	{
		LPDIRECT3D9 intf = Driver->getExposedVideoData().D3D9.D3D9;
		D3DDISPLAYMODE d3ddm;
		intf->GetAdapterDisplayMode(Driver->Params.DisplayAdapter, &d3ddm);

		if (D3D_OK == intf->CheckDeviceFormat(Driver->Params.DisplayAdapter, D3DDEVTYPE_HAL, d3ddm.Format, D3DUSAGE_AUTOGENMIPMAP, D3DRTYPE_TEXTURE, InternalFormat))
			flags = D3DUSAGE_AUTOGENMIPMAP;
		else
			AutoGenerateMipMaps = false;
	}

	HRESULT hr = 0;
	
	switch (Type)
	{
	case ETT_2D:
		hr = Device->CreateTexture(Size.Width, Size.Height, HasMipMaps ? 0 : 1, flags, InternalFormat, D3DPOOL_MANAGED, &Texture, NULL);
		break;
	case ETT_CUBEMAP:
		hr = Device->CreateCubeTexture(Size.Width, HasMipMaps ? 0 : 1, flags, InternalFormat, D3DPOOL_MANAGED, &CubeTexture, NULL);
		break;
	default:
		_IRR_DEBUG_BREAK_IF(true)
		break;
	}

	if (SUCCEEDED(hr))
	{
		for (u32 i = 0; i < tmpImage.size(); ++i)
			uploadTexture(i, 0, tmpImage[i]->getData());

		bool autoGenerateRequired = true;

		for (u32 i = 0; i < tmpImage.size(); ++i)
		{
			void* mipmapsData = tmpImage[i]->getMipMapsData();

			if (autoGenerateRequired || mipmapsData)
				regenerateMipMapLevels(mipmapsData, i);

			if (!mipmapsData)
				autoGenerateRequired = false;
		}
	}
	else
	{
		switch  (hr )
		{
			case D3DERR_INVALIDCALL:
				os::Printer::log("Could not create DIRECT3D9 Texture. D3DERR_INVALIDCALL", ELL_WARNING);
				break;
			case D3DERR_OUTOFVIDEOMEMORY:
				os::Printer::log("Could not create DIRECT3D9 Texture. D3DERR_OUTOFVIDEOMEMORY", ELL_WARNING);
				break;
			case E_OUTOFMEMORY:
				os::Printer::log("Could not create DIRECT3D9 Texture. E_OUTOFMEMORY", ELL_WARNING);
				break;
			default:
				os::Printer::log("Could not create DIRECT3D9 Texture.", ELL_WARNING);
		}
	}
	
	if (releaseImageData)
    {
		for (u32 i = 0; i < tmpImage.size(); ++i)
			tmpImage[i]->drop();
    }
}

CD3D9Texture::CD3D9Texture(CD3D9Driver* driver, const core::dimension2d<u32>& size, const io::path& name, E_TEXTURE_TYPE type, const ECOLOR_FORMAT format)
	: ITexture(name, type), Driver(driver), InternalFormat(D3DFMT_UNKNOWN), LockReadOnly(false), LockData(0), LockLayer(0),
	AutoGenerateMipMaps(false), Device(0), Texture(0), CubeTexture(0), RTTSurface(0)
{
#ifdef _DEBUG
	setDebugName("CD3D9Texture");
#endif

	Device = driver->getExposedVideoData().D3D9.D3DDev9;

	if (Device)
		Device->AddRef();

	DriverType = Driver->getDriverType();
	HasMipMaps = false;
	IsRenderTarget = true;

	OriginalColorFormat = format;

	if (ECF_UNKNOWN == OriginalColorFormat)
		ColorFormat = getBestColorFormat(Driver->getColorFormat());
	else
		ColorFormat = OriginalColorFormat;

	OriginalSize = size;
	Size = OriginalSize;

	if (!Driver->queryFeature(EVDF_TEXTURE_NPOT))
	{
		Size = Size.getOptimalSize(true, !Driver->queryFeature(EVDF_TEXTURE_NSQUARE), true, Driver->Caps.MaxTextureWidth);

		if (Size != OriginalSize)
			os::Printer::log("RenderTarget size has to be a power of two", ELL_INFORMATION);
	}

	Pitch = Size.Width * IImage::getBitsPerPixelFromFormat(ColorFormat) / 8;

	InternalFormat = Driver->getD3DFormatFromColorFormat(ColorFormat);

	generateRenderTarget();
}

CD3D9Texture::~CD3D9Texture()
{
	releaseTexture();

	if (Device)
		Device->Release();
}

void* CD3D9Texture::lock(E_TEXTURE_LOCK_MODE mode, u32 mipmapLevel, u32 layer, E_TEXTURE_LOCK_FLAGS lockFlags)
{
	if (LockData)
		return LockData;

	if (IImage::isCompressedFormat(ColorFormat))
		return 0;

	LockReadOnly = (mode == ETLM_READ_ONLY);
	LockLayer = layer;

	HRESULT hr;
	D3DLOCKED_RECT rect;

	if (!IsRenderTarget)
	{
		if (Texture)
		{
			hr = Texture->LockRect(0, &rect, 0, LockReadOnly ? D3DLOCK_READONLY : 0);
		}
		else if (CubeTexture)
		{
			_IRR_DEBUG_BREAK_IF(layer > 5)

			hr = CubeTexture->LockRect(static_cast<_D3DCUBEMAP_FACES>(layer), 0, &rect, 0, LockReadOnly ? D3DLOCK_READONLY : 0);
		}
		
		if (FAILED(hr))
		{
			os::Printer::log("Could not lock DIRECT3D9 Texture.", ELL_ERROR);
			return 0;
		}
	}
	else
	{
		if (!RTTSurface)
		{
			// Make RTT surface large enough for all miplevels (including 0)
			D3DSURFACE_DESC desc;
			if (Texture)
				Texture->GetLevelDesc(0, &desc);
			else if (CubeTexture)
				CubeTexture->GetLevelDesc(0, &desc);
			hr = Device->CreateOffscreenPlainSurface(desc.Width, desc.Height, desc.Format, D3DPOOL_SYSTEMMEM, &RTTSurface, 0);
			if (FAILED(hr))
			{
				os::Printer::log("Could not lock DIRECT3D9 Texture", "Offscreen surface creation failed.", ELL_ERROR);
				return 0;
			}
		}

		IDirect3DSurface9 *surface = 0;
		if (Texture)
			hr = Texture->GetSurfaceLevel(0, &surface);
		else if (CubeTexture)
			hr = CubeTexture->GetCubeMapSurface(static_cast<_D3DCUBEMAP_FACES>(layer), 0, &surface);
		if (FAILED(hr))
		{
			os::Printer::log("Could not lock DIRECT3D9 Texture", "Could not get surface.", ELL_ERROR);
			return 0;
		}
		hr = Device->GetRenderTargetData(surface, RTTSurface);
		surface->Release();
		if(FAILED(hr))
		{
			os::Printer::log("Could not lock DIRECT3D9 Texture", "Data copy failed.", ELL_ERROR);
			return 0;
		}
		hr = RTTSurface->LockRect(&rect, 0, LockReadOnly ? D3DLOCK_READONLY : 0);
		if(FAILED(hr))
		{
			os::Printer::log("Could not lock DIRECT3D9 Texture", "LockRect failed.", ELL_ERROR);
			return 0;
		}
	}

	LockData = rect.pBits;

	return LockData;
}

void CD3D9Texture::unlock()
{
	if (!LockData)
		return;

	if (!IsRenderTarget)
	{
		if (Texture)
		{
			Texture->UnlockRect(0);
		}
		else if (CubeTexture)
		{
			CubeTexture->UnlockRect(static_cast<_D3DCUBEMAP_FACES>(LockLayer), 0);
		}
	}
	else if (RTTSurface)
	{
		RTTSurface->UnlockRect();
	}

	if (!LockReadOnly)
		regenerateMipMapLevels(0, LockLayer);

	LockReadOnly = false;
	LockData = 0;
	LockLayer = 0;
}

void CD3D9Texture::regenerateMipMapLevels(void* data, u32 layer)
{
	if (!HasMipMaps || (!data && !AutoGenerateMipMaps) || (Size.Width <= 1 && Size.Height <= 1))
		return;

	if (data)
	{
		u32 width = Size.Width;
		u32 height = Size.Height;
		u8* tmpData = static_cast<u8*>(data);
		u32 dataSize = 0;
		u32 level = 0;

		do
		{
			if (width > 1)
				width >>= 1;

			if (height > 1)
				height >>= 1;

			dataSize = IImage::getDataSizeFromFormat(ColorFormat, width, height);
			++level;

			uploadTexture(layer, level, tmpData);

			tmpData += dataSize;
		} while (width != 1 || height != 1);
	}
	else
	{
		if (Texture)
			Texture->GenerateMipSubLevels();
		else if (CubeTexture)
			CubeTexture->GenerateMipSubLevels();
	}
}

IDirect3DBaseTexture9* CD3D9Texture::getDX9BaseTexture() const
{
	return (Texture) ? static_cast<IDirect3DBaseTexture9*>(Texture) : static_cast<IDirect3DBaseTexture9*>(CubeTexture);
}

IDirect3DTexture9* CD3D9Texture::getDX9Texture() const
{
	return Texture;
}

IDirect3DCubeTexture9* CD3D9Texture::getDX9CubeTexture() const
{
	return CubeTexture;
}

void CD3D9Texture::releaseTexture()
{
	if (RTTSurface)
	{
		if (RTTSurface->Release() == 0)
			RTTSurface = 0;
	}

	if (Texture)
	{
		if (Texture->Release() == 0)
			Texture = 0;
	}

	if (CubeTexture)
	{
		if (CubeTexture->Release() == 0)
			CubeTexture = 0;
	}
}

void CD3D9Texture::generateRenderTarget()
{
	DWORD flags = (IImage::isDepthFormat(ColorFormat)) ? D3DUSAGE_DEPTHSTENCIL : D3DUSAGE_RENDERTARGET;

	HRESULT hr = 0;

	switch (Type)
	{
		case ETT_2D:
			if (!Texture )
				hr = Device->CreateTexture(Size.Width, Size.Height, 1, flags, InternalFormat, D3DPOOL_DEFAULT, &Texture, NULL);
			break;
		case ETT_CUBEMAP:
			if (!CubeTexture)
				hr = Device->CreateCubeTexture(Size.Width, 1, flags, InternalFormat, D3DPOOL_DEFAULT, &CubeTexture, NULL);
			break;
		default:
			_IRR_DEBUG_BREAK_IF(true)
			break;
	}

	if (FAILED(hr))
	{
		if (D3DERR_INVALIDCALL == hr)
			os::Printer::log("Could not create render target texture", "Invalid Call", irr::ELL_ERROR);
		else if (D3DERR_OUTOFVIDEOMEMORY == hr)
			os::Printer::log("Could not create render target texture", "Out of Video Memory", irr::ELL_ERROR);
		else if (E_OUTOFMEMORY == hr)
			os::Printer::log("Could not create render target texture", "Out of Memory", irr::ELL_ERROR);
		else
			os::Printer::log("Could not create render target texture", irr::ELL_ERROR);
		core::stringc params("Width:");
		params += (unsigned int)Size.Width;
		params += " Height: ";
		params += (unsigned int)Size.Height;
		params += " flag: ";
		params += (unsigned int)flags;
		params += " format";
		params += (unsigned int)InternalFormat;
		params += " Type: ";
		params += (unsigned int)Type;
		os::Printer::log(params.c_str(), irr::ELL_ERROR);
	}
}

ECOLOR_FORMAT CD3D9Texture::getBestColorFormat(ECOLOR_FORMAT format)
{
	ECOLOR_FORMAT destFormat = (!IImage::isCompressedFormat(format)) ? ECF_A8R8G8B8 : format;

	switch (format)
	{
	case ECF_A1R5G5B5:
		if (!Driver->getTextureCreationFlag(ETCF_ALWAYS_32_BIT))
			destFormat = ECF_A1R5G5B5;
		break;
	case ECF_R5G6B5:
		if (!Driver->getTextureCreationFlag(ETCF_ALWAYS_32_BIT))
			destFormat = ECF_A1R5G5B5;
		break;
	case ECF_A8R8G8B8:
		if (Driver->getTextureCreationFlag(ETCF_ALWAYS_16_BIT) ||
			Driver->getTextureCreationFlag(ETCF_OPTIMIZED_FOR_SPEED))
			destFormat = ECF_A1R5G5B5;
		break;
	case ECF_R8G8B8:
		if (Driver->getTextureCreationFlag(ETCF_ALWAYS_16_BIT) || Driver->getTextureCreationFlag(ETCF_OPTIMIZED_FOR_SPEED))
			destFormat = ECF_A1R5G5B5;
	default:
		break;
	}

	if (Driver->getTextureCreationFlag(ETCF_NO_ALPHA_CHANNEL))
	{
		switch (destFormat)
		{
		case ECF_A1R5G5B5:
			destFormat = ECF_R5G6B5;
			break;
		case ECF_A8R8G8B8:
			destFormat = ECF_R8G8B8;
			break;
		default:
			break;
		}
	}

	return destFormat;
}

void CD3D9Texture::getImageValues(const IImage* image)
{
	OriginalColorFormat = image->getColorFormat();
	ColorFormat = getBestColorFormat(OriginalColorFormat);

	InternalFormat = Driver->getD3DFormatFromColorFormat(ColorFormat);

	if (IImage::isCompressedFormat(image->getColorFormat()))
	{
		AutoGenerateMipMaps = false;
	}

	OriginalSize = image->getDimension();
	Size = OriginalSize;

	if (Size.Width == 0 || Size.Height == 0)
	{
		os::Printer::log("Invalid size of image for texture.", ELL_ERROR);
		return;
	}

	const f32 ratio = (f32)Size.Width / (f32)Size.Height;

	if ((Size.Width > Driver->Caps.MaxTextureWidth) && (ratio >= 1.f))
	{
		Size.Width = Driver->Caps.MaxTextureWidth;
		Size.Height = (u32)(Driver->Caps.MaxTextureWidth / ratio);
	}
	else if (Size.Height > Driver->Caps.MaxTextureHeight)
	{
		Size.Height = Driver->Caps.MaxTextureHeight;
		Size.Width = (u32)(Driver->Caps.MaxTextureHeight * ratio);
	}

	bool needSquare = (!Driver->queryFeature(EVDF_TEXTURE_NSQUARE) || Type == ETT_CUBEMAP);

	Size = Size.getOptimalSize(!Driver->queryFeature(EVDF_TEXTURE_NPOT), needSquare, true, Driver->Caps.MaxTextureWidth);

	Pitch = Size.Width * IImage::getBitsPerPixelFromFormat(ColorFormat) / 8;
}

void CD3D9Texture::uploadTexture(u32 layer, u32 level, void* data)
{
	if (!data)
		return;

	u32 width = Size.Width >> level;
	u32 height = Size.Height >> level;

	u32 dataSize = IImage::getDataSizeFromFormat(ColorFormat, width, height);

	HRESULT hr = 0;

	D3DLOCKED_RECT lockRectangle;

	if (Texture)
	{
		hr = Texture->LockRect(level, &lockRectangle, 0, 0);
	}
	else if (CubeTexture)
	{
		_IRR_DEBUG_BREAK_IF(layer > 5)

		hr = CubeTexture->LockRect(static_cast<_D3DCUBEMAP_FACES>(layer), level, &lockRectangle, 0, 0);
	}

	if (FAILED(hr))
	{
		os::Printer::log("Texture data not copied", "Could not LockRect D3D9 Texture.", ELL_ERROR);
		return;
	}

	memcpy(lockRectangle.pBits, data, dataSize);

	if (Texture)
	{
		hr = Texture->UnlockRect(level);
	}
	else if (CubeTexture)
	{
		hr = CubeTexture->UnlockRect(static_cast<_D3DCUBEMAP_FACES>(layer), level);
	}

	if (FAILED(hr))
	{
		os::Printer::log("Texture data not copied", "Could not UnlockRect D3D9 Texture.", ELL_ERROR);
	}
}

}
}

#endif
