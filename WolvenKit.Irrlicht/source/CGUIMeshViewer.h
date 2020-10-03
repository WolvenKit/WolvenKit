// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_GUI_MESH_VIEWER_H_INCLUDED__
#define __C_GUI_MESH_VIEWER_H_INCLUDED__

#include "IrrCompileConfig.h"
#ifdef _IRR_COMPILE_WITH_GUI_

#include "IGUIMeshViewer.h"
#include "SMaterial.h"

namespace irr
{

namespace gui
{

	class CGUIMeshViewer : public IGUIMeshViewer
	{
	public:

		//! constructor
		CGUIMeshViewer(IGUIEnvironment* environment, IGUIElement* parent, s32 id, core::rect<s32> rectangle);

		//! destructor
		virtual ~CGUIMeshViewer();

		//! sets the mesh to be shown
		virtual void setMesh(scene::IAnimatedMesh* mesh) _IRR_OVERRIDE_;

		//! Gets the displayed mesh
		virtual scene::IAnimatedMesh* getMesh() const _IRR_OVERRIDE_;

		//! sets the material
		virtual void setMaterial(const video::SMaterial& material) _IRR_OVERRIDE_;

		//! gets the material
		virtual const video::SMaterial& getMaterial() const _IRR_OVERRIDE_;

		//! called if an event happened.
		virtual bool OnEvent(const SEvent& event) _IRR_OVERRIDE_;

		//! draws the element and its children
		virtual void draw() _IRR_OVERRIDE_;

	private:

		video::SMaterial Material;
		scene::IAnimatedMesh* Mesh;
	};


} // end namespace gui
} // end namespace irr

#endif // _IRR_COMPILE_WITH_GUI_

#endif // __C_GUI_MESH_VIEWER_H_INCLUDED__

