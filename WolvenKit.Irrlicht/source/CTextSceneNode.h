// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_TEXT_SCENE_NODE_H_INCLUDED__
#define __C_TEXT_SCENE_NODE_H_INCLUDED__

#include "ITextSceneNode.h"
#include "IBillboardTextSceneNode.h"
#include "IGUIFont.h"
#include "IGUIFontBitmap.h"
#include "ISceneCollisionManager.h"
#include "SMesh.h"

namespace irr
{
namespace scene
{

	class ICameraSceneNode;

	class CTextSceneNode : public ITextSceneNode
	{
	public:

		//! constructor
		CTextSceneNode(ISceneNode* parent, ISceneManager* mgr, s32 id,
			gui::IGUIFont* font, scene::ISceneCollisionManager* coll,
			const core::vector3df& position = core::vector3df(0,0,0), const wchar_t* text=0,
			video::SColor color=video::SColor(100,0,0,0));

		//! destructor
		virtual ~CTextSceneNode();

		virtual void OnRegisterSceneNode() _IRR_OVERRIDE_;

		//! renders the node.
		virtual void render() _IRR_OVERRIDE_;

		//! returns the axis aligned bounding box of this node
		virtual const core::aabbox3d<f32>& getBoundingBox() const _IRR_OVERRIDE_;

		//! sets the text string
		virtual void setText(const wchar_t* text) _IRR_OVERRIDE_;

		//! get the text string
		virtual const wchar_t* getText() const _IRR_OVERRIDE_;

		//! sets the color of the text
		virtual void setTextColor(video::SColor color) _IRR_OVERRIDE_;

		//! get the color of the text
		virtual video::SColor getTextColor() const _IRR_OVERRIDE_;

		//! set the font used to draw the text
		virtual void setFont(gui::IGUIFont* font) _IRR_OVERRIDE_;

		//! Get the font used to draw the text
		virtual gui::IGUIFont* getFont() const _IRR_OVERRIDE_;

		//! Returns type of the scene node
		virtual ESCENE_NODE_TYPE getType() const _IRR_OVERRIDE_ { return ESNT_TEXT; }

	private:

		core::stringw Text;
		video::SColor Color;
		gui::IGUIFont* Font;
		scene::ISceneCollisionManager* Coll;
		core::aabbox3d<f32> Box;
	};

	class CBillboardTextSceneNode : public IBillboardTextSceneNode
	{
	public:

		CBillboardTextSceneNode(ISceneNode* parent, ISceneManager* mgr, s32 id,
			gui::IGUIFont* font,const wchar_t* text,
			const core::vector3df& position, const core::dimension2d<f32>& size,
			video::SColor colorTop, video::SColor shade_bottom);

		//! destructor
		virtual ~CBillboardTextSceneNode();

		//! sets the vertex positions etc
		virtual void OnAnimate(u32 timeMs) _IRR_OVERRIDE_;

		//! registers the node into the transparent pass
		virtual void OnRegisterSceneNode() _IRR_OVERRIDE_;

		//! renders the node.
		virtual void render() _IRR_OVERRIDE_;

		//! returns the axis aligned bounding box of this node
		virtual const core::aabbox3d<f32>& getBoundingBox() const _IRR_OVERRIDE_;

		//! sets the text string
		virtual void setText(const wchar_t* text) _IRR_OVERRIDE_;

		//! get the text string
		virtual const wchar_t* getText() const _IRR_OVERRIDE_;

		//! Get the font used to draw the text
		virtual gui::IGUIFont* getFont() const _IRR_OVERRIDE_;

		//! sets the size of the billboard
		virtual void setSize(const core::dimension2d<f32>& size) _IRR_OVERRIDE_;

		//! gets the size of the billboard
		virtual const core::dimension2d<f32>& getSize() const _IRR_OVERRIDE_;

		virtual video::SMaterial& getMaterial(u32 i) _IRR_OVERRIDE_;

		//! returns amount of materials used by this scene node.
		virtual u32 getMaterialCount() const _IRR_OVERRIDE_;

		//! Returns type of the scene node
		virtual ESCENE_NODE_TYPE getType() const _IRR_OVERRIDE_ { return ESNT_BILLBOARD_TEXT; }

		//! Set the color of all vertices of the billboard
		//! \param overallColor: the color to set
		virtual void setColor(const video::SColor & overallColor) _IRR_OVERRIDE_;

		//! Set the color of the top and bottom vertices of the billboard
		//! \param topColor: the color to set the top vertices
		//! \param bottomColor: the color to set the bottom vertices
		virtual void setColor(const video::SColor & topColor, const video::SColor & bottomColor) _IRR_OVERRIDE_;

		//! Gets the color of the top and bottom vertices of the billboard
		//! \param topColor: stores the color of the top vertices
		//! \param bottomColor: stores the color of the bottom vertices
		virtual void getColor(video::SColor & topColor, video::SColor & bottomColor) const _IRR_OVERRIDE_;

		virtual void setSize(f32 height, f32 bottomEdgeWidth, f32 topEdgeWidth) _IRR_OVERRIDE_
		{
			setSize(core::dimension2df(bottomEdgeWidth, height));
		}

		virtual void getSize(f32& height, f32& bottomEdgeWidth, f32& topEdgeWidth) const _IRR_OVERRIDE_
		{
			height = Size.Height;
			bottomEdgeWidth = Size.Width;
			topEdgeWidth = Size.Width;
		}

		virtual const core::aabbox3d<f32>& getTransformedBillboardBoundingBox(const irr::scene::ICameraSceneNode* camera) _IRR_OVERRIDE_;

	protected:
		void updateMesh(const irr::scene::ICameraSceneNode* camera);

	private:

		core::stringw Text;
		gui::IGUIFontBitmap* Font;

		core::dimension2d<f32> Size;
		core::aabbox3d<f32> BBox;
		video::SMaterial Material;

		video::SColor ColorTop;
		video::SColor ColorBottom;
		struct SSymbolInfo
		{
			u32 bufNo;
			f32 Width;
			f32 Kerning;
			u32 firstInd;
			u32 firstVert;
		};

		core::array < SSymbolInfo > Symbol;

		SMesh *Mesh;
	};

} // end namespace scene
} // end namespace irr

#endif

