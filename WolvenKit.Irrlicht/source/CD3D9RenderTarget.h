// Copyright (C) 2015 Patryk Nadrowski
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_OPEN_GL_RENDER_TARGET_H_INCLUDED__
#define __C_OPEN_GL_RENDER_TARGET_H_INCLUDED__

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_DIRECT3D_9_

#include "IRenderTarget.h"

#include "dimension2d.h"
#include "os.h"

#include <d3d9.h>

namespace irr
{
	namespace video
	{

		class CD3D9Driver;

		class CD3D9RenderTarget : public IRenderTarget
		{
		public:
			CD3D9RenderTarget(CD3D9Driver* driver);
			virtual ~CD3D9RenderTarget();

			virtual void setTexture(const core::array<ITexture*>& texture, ITexture* depthStencil, const core::array<E_CUBE_SURFACE>& cubeSurfaces) _IRR_OVERRIDE_;

			const core::dimension2d<u32>& getSize() const;

			IDirect3DSurface9* getSurface(u32 id) const;

			u32 getSurfaceCount() const;

			IDirect3DSurface9* getDepthStencilSurface() const;

			void releaseSurfaces();

			void generateSurfaces();

		protected:
			core::dimension2d<u32> Size;

			core::array<IDirect3DSurface9*> Surface;

			IDirect3DSurface9* DepthStencilSurface;

			CD3D9Driver* Driver;
		};

	}
}

#endif
#endif
