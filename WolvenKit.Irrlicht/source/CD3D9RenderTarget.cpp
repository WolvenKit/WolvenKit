// Copyright (C) 2015 Patryk Nadrowski
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "CD3D9RenderTarget.h"

#ifdef _IRR_COMPILE_WITH_DIRECT3D_9_

#include "IImage.h"
#include "irrMath.h"
#include "irrString.h"

#include "CD3D9Driver.h"
#include "CD3D9Texture.h"

namespace irr
{
	namespace video
	{

		CD3D9RenderTarget::CD3D9RenderTarget(CD3D9Driver* driver) : DepthStencilSurface(0), Driver(driver)
		{
#ifdef _DEBUG
			setDebugName("CD3D9RenderTarget");
#endif

			DriverType = EDT_DIRECT3D9;
			Size = Driver->getScreenSize();
		}

		CD3D9RenderTarget::~CD3D9RenderTarget()
		{
			for (u32 i = 0; i < Surface.size(); ++i)
			{
				if (Surface[i])
					Surface[i]->Release();
			}

			if (DepthStencilSurface)
				DepthStencilSurface->Release();

			for (u32 i = 0; i < Texture.size(); ++i)
			{
				if (Texture[i])
					Texture[i]->drop();
			}

			if (DepthStencil)
				DepthStencil->drop();
		}

		void CD3D9RenderTarget::setTexture(const core::array<ITexture*>& texture, ITexture* depthStencil, const core::array<E_CUBE_SURFACE>& cubeSurfaces)
		{
			bool textureUpdate = (Texture != texture) || (CubeSurfaces != cubeSurfaces) ? true : false;
			bool depthStencilUpdate = (DepthStencil != depthStencil) ? true : false;

			if (textureUpdate || depthStencilUpdate)
			{
				// Set color attachments.

				if (textureUpdate)
				{
					CubeSurfaces = cubeSurfaces;

					if (texture.size() > Driver->ActiveRenderTarget.size())
					{
						core::stringc message = "This GPU supports up to ";
						message += Driver->ActiveRenderTarget.size();
						message += " textures per render target.";

						os::Printer::log(message.c_str(), ELL_WARNING);
					}

					const u32 size = core::min_(texture.size(), static_cast<u32>(Driver->ActiveRenderTarget.size()));

					for (u32 i = 0; i < Surface.size(); ++i)
					{
						if (Surface[i])
							Surface[i]->Release();
					}

					Surface.set_used(size);

					for (u32 i = 0; i < Texture.size(); ++i)
					{
						if (Texture[i])
							Texture[i]->drop();
					}

					Texture.set_used(size);

					for (u32 i = 0; i < size; ++i)
					{
						CD3D9Texture* currentTexture = (texture[i] && texture[i]->getDriverType() == DriverType) ? static_cast<CD3D9Texture*>(texture[i]) : 0;

						IDirect3DTexture9* textureID = 0;
						IDirect3DCubeTexture9* cubeTextureId = 0;
						UINT level = 0;	// no support for rendering to to other mip-levels so far

						if (currentTexture)
						{
							if (currentTexture->getType() == ETT_2D)
								textureID = currentTexture->getDX9Texture();
							else if ( currentTexture->getType() == ETT_CUBEMAP )
								cubeTextureId = currentTexture->getDX9CubeTexture();
						}

						if (textureID)
						{
							Texture[i] = texture[i];
							Texture[i]->grab();

							IDirect3DSurface9* currentSurface = 0;
							textureID->GetSurfaceLevel(level, &currentSurface);

							Surface[i] = currentSurface;
						}
						else if ( cubeTextureId )
						{
							Texture[i] = texture[i];
							Texture[i]->grab();

							IDirect3DSurface9* currentSurface = 0;
							D3DCUBEMAP_FACES face = (D3DCUBEMAP_FACES)CubeSurfaces[i];	// we use same numbering
							cubeTextureId->GetCubeMapSurface(face, level, &currentSurface);

							Surface[i] = currentSurface;
						}
						else
						{
							Surface[i] = 0;
							Texture[i] = 0;
						}
					}
				}

				// Set depth and stencil attachments.

				if (depthStencilUpdate)
				{
					if (DepthStencilSurface)
					{
						DepthStencilSurface->Release();
						DepthStencilSurface = 0;
					}

					if (DepthStencil)
					{
						DepthStencil->drop();
						DepthStencil = 0;

						DepthStencilSurface = 0;
					}

					CD3D9Texture* currentTexture = (depthStencil && depthStencil->getDriverType() == DriverType) ? static_cast<CD3D9Texture*>(depthStencil) : 0;

					IDirect3DTexture9* textureID = 0;

					if (currentTexture)
					{
						if (currentTexture->getType() == ETT_2D)
							textureID = currentTexture->getDX9Texture();
						else
							os::Printer::log("This driver doesn't support depth/stencil to cubemaps.", ELL_WARNING);
					}

					if (textureID)
					{
						const ECOLOR_FORMAT textureFormat = (depthStencil) ? depthStencil->getColorFormat() : ECF_UNKNOWN;

						if (IImage::isDepthFormat(textureFormat))
						{
							DepthStencil = depthStencil;
							DepthStencil->grab();

							IDirect3DSurface9* currentSurface = 0;
							textureID->GetSurfaceLevel(0, &currentSurface);

							DepthStencilSurface = currentSurface;
						}
					}
				}

				// Set size required for a viewport.

				bool sizeDetected = false;

				for (u32 i = 0; i < Texture.size(); ++i)
				{
					if (Texture[i])
					{
						Size = Texture[i]->getSize();
						sizeDetected = true;

						break;
					}
				}

				if (!sizeDetected)
				{
					if (DepthStencil)
						Size = DepthStencil->getSize();
					else
						Size = Driver->getScreenSize();
				}
			}
		}

		const core::dimension2d<u32>& CD3D9RenderTarget::getSize() const
		{
			return Size;
		}

		IDirect3DSurface9* CD3D9RenderTarget::getSurface(u32 id) const
		{
			return (id < Surface.size()) ? Surface[id] : 0;
		}

		u32 CD3D9RenderTarget::getSurfaceCount() const
		{
			return Surface.size();
		}

		IDirect3DSurface9* CD3D9RenderTarget::getDepthStencilSurface() const
		{
			return DepthStencilSurface;
		}

		void CD3D9RenderTarget::releaseSurfaces()
		{
			for (u32 i = 0; i < Surface.size(); ++i)
			{
				if (Surface[i])
				{
					Surface[i]->Release();
					Surface[i] = 0;
				}
			}

			if (DepthStencilSurface)
			{
				DepthStencilSurface->Release();
				DepthStencilSurface = 0;
			}
		}

		void CD3D9RenderTarget::generateSurfaces()
		{
			for (u32 i = 0; i < Surface.size(); ++i)
			{
				if (!Surface[i] && Texture[i])
				{
					IDirect3DTexture9* currentTexture = static_cast<CD3D9Texture*>(Texture[i])->getDX9Texture();
					if ( currentTexture )
					{
						IDirect3DSurface9* currentSurface = 0;
						currentTexture->GetSurfaceLevel(0, &currentSurface);
						Surface[i] = currentSurface;
					}
				}
			}

			if (!DepthStencilSurface && DepthStencil)
			{
				IDirect3DTexture9* currentTexture = static_cast<CD3D9Texture*>(DepthStencil)->getDX9Texture();
				if ( currentTexture )
				{
					IDirect3DSurface9* currentSurface = 0;
					currentTexture->GetSurfaceLevel(0, &currentSurface);
					DepthStencilSurface = currentSurface;
				}
			}
		}
	}
}

#endif
