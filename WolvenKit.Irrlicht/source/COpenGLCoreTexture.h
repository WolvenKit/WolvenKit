// Copyright (C) 2015 Patryk Nadrowski
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_OGLCORE_TEXTURE_H_INCLUDED__
#define __C_OGLCORE_TEXTURE_H_INCLUDED__

#include "IrrCompileConfig.h"

#if defined(_IRR_COMPILE_WITH_OPENGL_) || defined(_IRR_COMPILE_WITH_OGLES1_) || defined(_IRR_COMPILE_WITH_OGLES2_)

#include "irrArray.h"
#include "SMaterialLayer.h"
#include "ITexture.h"
#include "EDriverFeatures.h"
#include "os.h"
#include "CImage.h"
#include "CColorConverter.h"

namespace irr
{
namespace video
{

template <class TOpenGLDriver>
class COpenGLCoreTexture : public ITexture
{
public:
	struct SStatesCache
	{
		SStatesCache() : WrapU(ETC_REPEAT), WrapV(ETC_REPEAT), WrapW(ETC_REPEAT),
			LODBias(0), AnisotropicFilter(0), BilinearFilter(false), TrilinearFilter(false),
			MipMapStatus(false), IsCached(false)
		{
		}

		u8 WrapU;
		u8 WrapV;
		u8 WrapW;
		s8 LODBias;
		u8 AnisotropicFilter;
		bool BilinearFilter;
		bool TrilinearFilter;
		bool MipMapStatus;
		bool IsCached;
	};

	COpenGLCoreTexture(const io::path& name, const core::array<IImage*>& image, E_TEXTURE_TYPE type, TOpenGLDriver* driver) : ITexture(name, type), Driver(driver), TextureType(GL_TEXTURE_2D),
		TextureName(0), InternalFormat(GL_RGBA), PixelFormat(GL_RGBA), PixelType(GL_UNSIGNED_BYTE), Converter(0), LockReadOnly(false), LockImage(0), LockLayer(0),
		KeepImage(false), AutoGenerateMipMaps(false)
	{
		_IRR_DEBUG_BREAK_IF(image.size() == 0)

		DriverType = Driver->getDriverType();
		TextureType = TextureTypeIrrToGL(Type);
		HasMipMaps = Driver->getTextureCreationFlag(ETCF_CREATE_MIP_MAPS);
		AutoGenerateMipMaps = Driver->queryFeature(EVDF_MIP_MAP_AUTO_UPDATE);
		KeepImage = Driver->getTextureCreationFlag(ETCF_ALLOW_MEMORY_COPY);

		getImageValues(image[0]);

		const core::array<IImage*>* tmpImage = &image;

		if (KeepImage || OriginalSize != Size || OriginalColorFormat != ColorFormat)
		{
			Image.set_used(image.size());

			for (u32 i = 0; i < image.size(); ++i)
			{
				Image[i] = Driver->createImage(ColorFormat, Size);

				if (image[i]->getDimension() == Size)
					image[i]->copyTo(Image[i]);
				else
					image[i]->copyToScaling(Image[i]);
			}

			tmpImage = &Image;
		}

		glGenTextures(1, &TextureName);

		const COpenGLCoreTexture* prevTexture = Driver->getCacheHandler()->getTextureCache().get(0);
		Driver->getCacheHandler()->getTextureCache().set(0, this);

		glTexParameteri(TextureType, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
		glTexParameteri(TextureType, GL_TEXTURE_MAG_FILTER, GL_NEAREST);

		if (HasMipMaps && AutoGenerateMipMaps)
		{
			if (Driver->getTextureCreationFlag(ETCF_OPTIMIZED_FOR_SPEED))
				glHint(GL_GENERATE_MIPMAP_HINT, GL_FASTEST);
			else if (Driver->getTextureCreationFlag(ETCF_OPTIMIZED_FOR_QUALITY))
				glHint(GL_GENERATE_MIPMAP_HINT, GL_NICEST);
			else
				glHint(GL_GENERATE_MIPMAP_HINT, GL_DONT_CARE);
		}

#if (defined(IRR_OPENGL_VERSION) && IRR_OPENGL_VERSION < 20) || (defined(IRR_OPENGL_ES_VERSION) && IRR_OPENGL_ES_VERSION < 20)
		if (HasMipMaps)
			glTexParameteri(TextureType, GL_GENERATE_MIPMAP, (AutoGenerateMipMaps) ? GL_TRUE : GL_FALSE);
#endif

		for (u32 i = 0; i < (*tmpImage).size(); ++i)
			uploadTexture(true, i, 0, (*tmpImage)[i]->getData());

		Driver->getCacheHandler()->getTextureCache().set(0, prevTexture);

		bool autoGenerateRequired = true;

		for (u32 i = 0; i < (*tmpImage).size(); ++i)
		{
			void* mipmapsData = (*tmpImage)[i]->getMipMapsData();

			if (autoGenerateRequired || mipmapsData)
				regenerateMipMapLevels(mipmapsData, i);

			if (!mipmapsData)
				autoGenerateRequired = false;
		}

		if (!KeepImage)
		{
			for (u32 i = 0; i < Image.size(); ++i)
				Image[i]->drop();

			Image.clear();
		}

		Driver->testGLError(__LINE__);
	}

	COpenGLCoreTexture(const io::path& name, const core::dimension2d<u32>& size, E_TEXTURE_TYPE type, ECOLOR_FORMAT format, TOpenGLDriver* driver) 
		: ITexture(name, type), 
		Driver(driver), TextureType(GL_TEXTURE_2D),
		TextureName(0), InternalFormat(GL_RGBA), PixelFormat(GL_RGBA), PixelType(GL_UNSIGNED_BYTE), Converter(0), LockReadOnly(false), LockImage(0), LockLayer(0), KeepImage(false),
		AutoGenerateMipMaps(false)
	{
		DriverType = Driver->getDriverType();
		TextureType = TextureTypeIrrToGL(Type);
		HasMipMaps = false;
		IsRenderTarget = true;

		OriginalColorFormat = format;

		if (ECF_UNKNOWN == OriginalColorFormat)
			ColorFormat = getBestColorFormat(Driver->getColorFormat());
		else
			ColorFormat = OriginalColorFormat;

		OriginalSize = size;
		Size = OriginalSize;

		Pitch = Size.Width * IImage::getBitsPerPixelFromFormat(ColorFormat) / 8;

		if ( !Driver->getColorFormatParameters(ColorFormat, InternalFormat, PixelFormat, PixelType, &Converter) )
		{
			os::Printer::log("COpenGLCoreTexture: Color format is not supported", ColorFormatNames[ColorFormat < ECF_UNKNOWN?ColorFormat:ECF_UNKNOWN], ELL_ERROR);
		}

		glGenTextures(1, &TextureName);

		const COpenGLCoreTexture* prevTexture = Driver->getCacheHandler()->getTextureCache().get(0);
		Driver->getCacheHandler()->getTextureCache().set(0, this);

		glTexParameteri(TextureType, GL_TEXTURE_MIN_FILTER, GL_NEAREST);
		glTexParameteri(TextureType, GL_TEXTURE_MAG_FILTER, GL_NEAREST);
		glTexParameteri(TextureType, GL_TEXTURE_WRAP_S, GL_CLAMP_TO_EDGE);
		glTexParameteri(TextureType, GL_TEXTURE_WRAP_T, GL_CLAMP_TO_EDGE);
		glTexParameteri(TextureType, GL_TEXTURE_WRAP_R, GL_CLAMP_TO_EDGE);

		StatesCache.WrapU = ETC_CLAMP_TO_EDGE;
		StatesCache.WrapV = ETC_CLAMP_TO_EDGE;
		StatesCache.WrapW = ETC_CLAMP_TO_EDGE;

		switch (Type)
		{
		case ETT_2D: 
			glTexImage2D(GL_TEXTURE_2D, 0, InternalFormat, Size.Width, Size.Height, 0, PixelFormat, PixelType, 0);
			break;
		case ETT_CUBEMAP:
			glTexImage2D(GL_TEXTURE_CUBE_MAP_POSITIVE_X, 0, InternalFormat, Size.Width, Size.Height, 0, PixelFormat, PixelType, 0);
			glTexImage2D(GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 0, InternalFormat, Size.Width, Size.Height, 0, PixelFormat, PixelType, 0);
			glTexImage2D(GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 0, InternalFormat, Size.Width, Size.Height, 0, PixelFormat, PixelType, 0);
			glTexImage2D(GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, 0, InternalFormat, Size.Width, Size.Height, 0, PixelFormat, PixelType, 0);
			glTexImage2D(GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 0, InternalFormat, Size.Width, Size.Height, 0, PixelFormat, PixelType, 0);
			glTexImage2D(GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, 0, InternalFormat, Size.Width, Size.Height, 0, PixelFormat, PixelType, 0);
			break;
		}

		Driver->getCacheHandler()->getTextureCache().set(0, prevTexture);
		Driver->testGLError(__LINE__);
	}

	virtual ~COpenGLCoreTexture()
	{
		if (TextureName)
			glDeleteTextures(1, &TextureName);

		if (LockImage)
			LockImage->drop();

		for (u32 i = 0; i < Image.size(); ++i)
			Image[i]->drop();
	}

	virtual void* lock(E_TEXTURE_LOCK_MODE mode = ETLM_READ_WRITE, u32 mipmapLevel=0, u32 layer = 0, E_TEXTURE_LOCK_FLAGS lockFlags = ETLF_FLIP_Y_UP_RTT) _IRR_OVERRIDE_
	{
		if (LockImage)
			return LockImage->getData();

		if (IImage::isCompressedFormat(ColorFormat))
			return 0;

		LockReadOnly |= (mode == ETLM_READ_ONLY);
		LockLayer = layer;

		if (KeepImage)
		{
			_IRR_DEBUG_BREAK_IF(LockLayer > Image.size())

			LockImage = Image[LockLayer];
			LockImage->grab();
		}
		else
		{
			LockImage = Driver->createImage(ColorFormat, Size);

			if (LockImage && mode != ETLM_WRITE_ONLY)
			{
				bool passed = true;

#if 1
				IImage* tmpImage = LockImage;	// not sure yet if the size required by glGetTexImage is always correct, if not we might have to allocate a different tmpImage and convert colors later on.

				Driver->getCacheHandler()->getTextureCache().set(0, this);

				GLenum tmpTextureType = TextureType;

				if (tmpTextureType == GL_TEXTURE_CUBE_MAP)
				{
					_IRR_DEBUG_BREAK_IF(layer > 5)

					tmpTextureType = GL_TEXTURE_CUBE_MAP_POSITIVE_X + layer;
				}

				glGetTexImage(tmpTextureType, 0, PixelFormat, PixelType, tmpImage->getData());

				if (IsRenderTarget && lockFlags == ETLF_FLIP_Y_UP_RTT)
				{
					const s32 pitch = tmpImage->getPitch();

					u8* srcA = static_cast<u8*>(tmpImage->getData());
					u8* srcB = srcA + (tmpImage->getDimension().Height - 1) * pitch;

					u8* tmpBuffer = new u8[pitch];

					for (u32 i = 0; i < tmpImage->getDimension().Height; i += 2)
					{
						memcpy(tmpBuffer, srcA, pitch);
						memcpy(srcA, srcB, pitch);
						memcpy(srcB, tmpBuffer, pitch);
						srcA += pitch;
						srcB -= pitch;
					}

					delete[] tmpBuffer;
				}
#else	// Alternative method working with copies to memory, still here for quick testing when things break, hope we can remove that before 1.9 release.
				COpenGLCoreTexture* tmpTexture = new COpenGLCoreTexture("OGL_CORE_LOCK_TEXTURE", Size, ETT_2D, ColorFormat, Driver);

				GLuint tmpFBO = 0;
				Driver->irrGlGenFramebuffers(1, &tmpFBO);

				GLint prevViewportX = 0;
				GLint prevViewportY = 0;
				GLsizei prevViewportWidth = 0;
				GLsizei prevViewportHeight = 0;
				Driver->getCacheHandler()->getViewport(prevViewportX, prevViewportY, prevViewportWidth, prevViewportHeight);
				Driver->getCacheHandler()->setViewport(0, 0, Size.Width, Size.Height);

				GLuint prevFBO = 0;
				Driver->getCacheHandler()->getFBO(prevFBO);
				Driver->getCacheHandler()->setFBO(tmpFBO);

				Driver->irrGlFramebufferTexture2D(GL_FRAMEBUFFER, GL_COLOR_ATTACHMENT0, GL_TEXTURE_2D, tmpTexture->getOpenGLTextureName(), 0);

				glClear(GL_COLOR_BUFFER_BIT);

				Driver->draw2DImage(this, layer, true);

				IImage* tmpImage = Driver->createImage(ECF_A8R8G8B8, Size);
				glReadPixels(0, 0, Size.Width, Size.Height, GL_RGBA, GL_UNSIGNED_BYTE, tmpImage->getData());

				Driver->getCacheHandler()->setFBO(prevFBO);
				Driver->getCacheHandler()->setViewport(prevViewportX, prevViewportY, prevViewportWidth, prevViewportHeight);

				Driver->irrGlDeleteFramebuffers(1, &tmpFBO);
				delete tmpTexture;

				void* src = tmpImage->getData();
				void* dest = LockImage->getData();

				switch (ColorFormat)
				{
				case ECF_A1R5G5B5:
					CColorConverter::convert_A8R8G8B8toA1B5G5R5(src, tmpImage->getDimension().getArea(), dest);
					break;
				case ECF_R5G6B5:
					CColorConverter::convert_A8R8G8B8toR5G6B5(src, tmpImage->getDimension().getArea(), dest);
					break;
				case ECF_R8G8B8:
					CColorConverter::convert_A8R8G8B8toB8G8R8(src, tmpImage->getDimension().getArea(), dest);
					break;
				case ECF_A8R8G8B8:
					CColorConverter::convert_A8R8G8B8toA8B8G8R8(src, tmpImage->getDimension().getArea(), dest);
					break;
				default:
					passed = false;
					break;
				}
				tmpImage->drop();
#endif

				if (!passed)
				{
					LockImage->drop();
					LockImage = 0;
				}
			}
		}

		Driver->testGLError(__LINE__);

		return (LockImage) ? LockImage->getData() : 0;
	}

	virtual void unlock() _IRR_OVERRIDE_
	{
		if (!LockImage)
			return;

		if (!LockReadOnly)
		{
			const COpenGLCoreTexture* prevTexture = Driver->getCacheHandler()->getTextureCache().get(0);
			Driver->getCacheHandler()->getTextureCache().set(0, this);

			uploadTexture(false, LockLayer, 0, LockImage->getData());

			Driver->getCacheHandler()->getTextureCache().set(0, prevTexture);

			regenerateMipMapLevels(0, LockLayer);
		}

		LockImage->drop();

		LockReadOnly = false;
		LockImage = 0;
		LockLayer = 0;
	}

	virtual void regenerateMipMapLevels(void* data = 0, u32 layer = 0) _IRR_OVERRIDE_
	{
		if (!HasMipMaps || (!data && !AutoGenerateMipMaps) || (Size.Width <= 1 && Size.Height <= 1))
			return;

		const COpenGLCoreTexture* prevTexture = Driver->getCacheHandler()->getTextureCache().get(0);
		Driver->getCacheHandler()->getTextureCache().set(0, this);

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

				uploadTexture(true, layer, level, tmpData);

				tmpData += dataSize;
			}
			while (width != 1 || height != 1);
		}
		else
		{
#if (defined(IRR_OPENGL_VERSION) && IRR_OPENGL_VERSION >= 20) || (defined(IRR_OPENGL_ES_VERSION) && IRR_OPENGL_ES_VERSION >= 20)
			Driver->irrGlGenerateMipmap(TextureType);
#endif
		}

		Driver->getCacheHandler()->getTextureCache().set(0, prevTexture);
	}

	GLenum getOpenGLTextureType() const
	{
		return TextureType;
	}

	GLuint getOpenGLTextureName() const
	{
		return TextureName;
	}

	SStatesCache& getStatesCache() const
	{
		return StatesCache;
	}

protected:
	ECOLOR_FORMAT getBestColorFormat(ECOLOR_FORMAT format)
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

	void getImageValues(const IImage* image)
	{
		OriginalColorFormat = image->getColorFormat();
		ColorFormat = getBestColorFormat(OriginalColorFormat);

		if ( !Driver->getColorFormatParameters(ColorFormat, InternalFormat, PixelFormat, PixelType, &Converter) )
		{
			os::Printer::log("getImageValues: Color format is not supported", ColorFormatNames[ColorFormat < ECF_UNKNOWN?ColorFormat:ECF_UNKNOWN], ELL_ERROR);
			// not quitting as it will use some alternative internal format
		}

		if (IImage::isCompressedFormat(image->getColorFormat()))
		{
			KeepImage = false;
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

		if ((Size.Width > Driver->MaxTextureSize) && (ratio >= 1.f))
		{
			Size.Width = Driver->MaxTextureSize;
			Size.Height = (u32)(Driver->MaxTextureSize / ratio);
		}
		else if (Size.Height > Driver->MaxTextureSize)
		{
			Size.Height = Driver->MaxTextureSize;
			Size.Width = (u32)(Driver->MaxTextureSize * ratio);
		}

		bool needSquare = (!Driver->queryFeature(EVDF_TEXTURE_NSQUARE) || Type == ETT_CUBEMAP);

		Size = Size.getOptimalSize(!Driver->queryFeature(EVDF_TEXTURE_NPOT), needSquare, true, Driver->MaxTextureSize);

		Pitch = Size.Width * IImage::getBitsPerPixelFromFormat(ColorFormat) / 8;
	}

	void uploadTexture(bool initTexture, u32 layer, u32 level, void* data)
	{
		if (!data)
			return;

		u32 width = Size.Width >> level;
		u32 height = Size.Height >> level;

		GLenum tmpTextureType = TextureType;

		if (tmpTextureType == GL_TEXTURE_CUBE_MAP)
		{
			_IRR_DEBUG_BREAK_IF(layer > 5)

			tmpTextureType = GL_TEXTURE_CUBE_MAP_POSITIVE_X + layer;
		}

		if (!IImage::isCompressedFormat(ColorFormat))
		{
			CImage* tmpImage = 0;
			void* tmpData = data;

			if (Converter)
			{
				const core::dimension2d<u32> tmpImageSize(width, height);

				tmpImage = new CImage(ColorFormat, tmpImageSize);
				tmpData = tmpImage->getData();

				Converter(data, tmpImageSize.getArea(), tmpData);
			}

			switch (TextureType)
			{
			case GL_TEXTURE_2D:
			case GL_TEXTURE_CUBE_MAP:
				if (initTexture)
					glTexImage2D(tmpTextureType, level, InternalFormat, width, height, 0, PixelFormat, PixelType, tmpData);
				else
					glTexSubImage2D(tmpTextureType, level, 0, 0, width, height, PixelFormat, PixelType, tmpData);

				break;
			default:
				break;
			}

			delete tmpImage;
		}
		else
		{
			u32 dataSize = IImage::getDataSizeFromFormat(ColorFormat, width, height);

			switch (TextureType)
			{
			case GL_TEXTURE_2D:
			case GL_TEXTURE_CUBE_MAP:
				if (initTexture)
					Driver->irrGlCompressedTexImage2D(tmpTextureType, level, InternalFormat, width, height, 0, dataSize, data);
				else
					Driver->irrGlCompressedTexSubImage2D(tmpTextureType, level, 0, 0, width, height, PixelFormat, dataSize, data);

				break;
			default:
				break;
			}
		}
	}

	GLenum TextureTypeIrrToGL(E_TEXTURE_TYPE type) const
	{
		switch ( type)
		{
		case ETT_2D: 
			return GL_TEXTURE_2D;
		case ETT_CUBEMAP:
			return GL_TEXTURE_CUBE_MAP;
		}

		os::Printer::log("COpenGLCoreTexture::TextureTypeIrrToGL unknown texture type", ELL_WARNING);
		return GL_TEXTURE_2D;
	}

	TOpenGLDriver* Driver;

	GLenum TextureType;
	GLuint TextureName;
	GLint InternalFormat;
	GLenum PixelFormat;
	GLenum PixelType;
	void (*Converter)(const void*, s32, void*);

	bool LockReadOnly;
	IImage* LockImage;
	u32 LockLayer;

	bool KeepImage;
	core::array<IImage*> Image;

	bool AutoGenerateMipMaps;

	mutable SStatesCache StatesCache;
};

}
}

#endif
#endif
