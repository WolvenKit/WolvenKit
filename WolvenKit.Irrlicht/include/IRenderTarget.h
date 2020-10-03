// Copyright (C) 2015 Patryk Nadrowski
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_RENDER_TARGET_H_INCLUDED__
#define __I_RENDER_TARGET_H_INCLUDED__

#include "IReferenceCounted.h"
#include "EDriverTypes.h"
#include "irrArray.h"

namespace irr
{
namespace video
{
	class ITexture;

	//! Enumeration of cube texture surfaces
	enum E_CUBE_SURFACE
	{
		ECS_POSX  = 0,
		ECS_NEGX,
		ECS_POSY,
		ECS_NEGY,
		ECS_POSZ, 
		ECS_NEGZ
	};

	//! Interface of a Render Target.
	class IRenderTarget : public virtual IReferenceCounted
	{
	public:

		//! constructor
		IRenderTarget() : DepthStencil(0), DriverType(EDT_NULL)
		{
		}

		//! Returns an array of previously set textures.
		const core::array<ITexture*>& getTexture() const
		{
			return Texture;
		}

		//! Returns a of previously set depth / depth-stencil texture.
		ITexture* getDepthStencil() const
		{
			return DepthStencil;
		}

		//! Set multiple textures.
		/** Set multiple textures for the render target.
		\param texture Array of texture objects. These textures are used for a color outputs.
		\param depthStencil Depth or packed depth-stencil texture. This texture is used as depth
		or depth-stencil buffer. 
		\param cubeSurfaces When rendering to cube textures, set the surface to be used for each texture. Can be empty otherwise.
		*/
		virtual void setTexture(const core::array<ITexture*>& texture, ITexture* depthStencil, const core::array<E_CUBE_SURFACE>& cubeSurfaces = core::array<E_CUBE_SURFACE>()) = 0;

		//! Set one texture.
		void setTexture(ITexture* texture, ITexture* depthStencil)
		{
			core::array<ITexture*> textureArray(1);
			textureArray.push_back(texture);

			setTexture(textureArray, depthStencil);
		}

		//! Set one cube surface texture.
		void setTexture(ITexture* texture, ITexture* depthStencil, E_CUBE_SURFACE cubeSurface)
		{
			core::array<ITexture*> textureArray(1);
			textureArray.push_back(texture);

			core::array<E_CUBE_SURFACE> cubeSurfaces(1);
			cubeSurfaces.push_back(cubeSurface);

			setTexture(textureArray, depthStencil, cubeSurfaces);
		}

		//! Get driver type of render target.
		E_DRIVER_TYPE getDriverType() const
		{
			return DriverType;
		}

	protected:

		//! Textures assigned to render target.
		core::array<ITexture*> Texture;

		//! Depth or packed depth-stencil texture assigned to render target.
		ITexture* DepthStencil;

		//! Active surface of cube textures
		core::array<E_CUBE_SURFACE> CubeSurfaces;

		//! Driver type of render target.
		E_DRIVER_TYPE DriverType;

	private:
		// no copying (IReferenceCounted still allows that for reasons which take some time to work around)
		IRenderTarget(const IRenderTarget&);
		IRenderTarget& operator=(const IRenderTarget&);
	};

}
}

#endif
