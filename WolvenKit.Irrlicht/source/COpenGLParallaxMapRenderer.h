// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_OPENGL_PARALLAX_MAP_RENDERER_H_INCLUDED__
#define __C_OPENGL_PARALLAX_MAP_RENDERER_H_INCLUDED__

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_OPENGL_

#include "IShaderConstantSetCallBack.h"

#include "COpenGLShaderMaterialRenderer.h"

namespace irr
{
namespace video
{

//! Class for rendering normal maps with OpenGL
class COpenGLParallaxMapRenderer : public COpenGLShaderMaterialRenderer, public IShaderConstantSetCallBack
{
public:

	//! Constructor
	COpenGLParallaxMapRenderer(video::COpenGLDriver* driver,
		s32& outMaterialTypeNr, E_MATERIAL_TYPE baseMaterial);

	//! Destructor
	~COpenGLParallaxMapRenderer();

	//! Called by the engine when the vertex and/or pixel shader constants for an
	//! material renderer should be set.
	virtual void OnSetConstants(IMaterialRendererServices* services, s32 userData) _IRR_OVERRIDE_;

	//! Returns the render capability of the material.
	virtual s32 getRenderCapability() const _IRR_OVERRIDE_;

	virtual void OnSetMaterial(const SMaterial& material) _IRR_OVERRIDE_ { }
	virtual void OnSetMaterial(const video::SMaterial& material,
		const video::SMaterial& lastMaterial,
		bool resetAllRenderstates, video::IMaterialRendererServices* services) _IRR_OVERRIDE_;

protected:

	bool CompiledShaders;
	f32 CurrentScale;
};


} // end namespace video
} // end namespace irr

#endif
#endif

