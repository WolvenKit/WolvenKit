// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_BILLBOARD_SCENE_NODE_H_INCLUDED__
#define __C_BILLBOARD_SCENE_NODE_H_INCLUDED__

#include "IBillboardSceneNode.h"
#include "SMeshBuffer.h"

namespace irr
{
namespace scene
{

//! Scene node which is a billboard. A billboard is like a 3d sprite: A 2d element,
//! which always looks to the camera.
class CBillboardSceneNode : virtual public IBillboardSceneNode
{
public:

	//! constructor
	CBillboardSceneNode(ISceneNode* parent, ISceneManager* mgr, s32 id,
		const core::vector3df& position, const core::dimension2d<f32>& size,
		video::SColor colorTop=video::SColor(0xFFFFFFFF),
		video::SColor colorBottom=video::SColor(0xFFFFFFFF));

	virtual ~CBillboardSceneNode();

	//! pre render event
	virtual void OnRegisterSceneNode() _IRR_OVERRIDE_;

	//! render
	virtual void render() _IRR_OVERRIDE_;

	//! returns the axis aligned bounding box of this node
	virtual const core::aabbox3d<f32>& getBoundingBox() const _IRR_OVERRIDE_;

	//! sets the size of the billboard
	virtual void setSize(const core::dimension2d<f32>& size) _IRR_OVERRIDE_;

	//! Sets the widths of the top and bottom edges of the billboard independently.
	virtual void setSize(f32 height, f32 bottomEdgeWidth, f32 topEdgeWidth) _IRR_OVERRIDE_;

	//! gets the size of the billboard
	virtual const core::dimension2d<f32>& getSize() const _IRR_OVERRIDE_;

	//! Gets the widths of the top and bottom edges of the billboard.
	virtual void getSize(f32& height, f32& bottomEdgeWidth, f32& topEdgeWidth) const _IRR_OVERRIDE_;

	virtual video::SMaterial& getMaterial(u32 i) _IRR_OVERRIDE_;

	//! returns amount of materials used by this scene node.
	virtual u32 getMaterialCount() const _IRR_OVERRIDE_;

	//! Set the color of all vertices of the billboard
	//! \param overallColor: the color to set
	virtual void setColor(const video::SColor& overallColor) _IRR_OVERRIDE_;

	//! Set the color of the top and bottom vertices of the billboard
	//! \param topColor: the color to set the top vertices
	//! \param bottomColor: the color to set the bottom vertices
	virtual void setColor(const video::SColor& topColor,
			const video::SColor& bottomColor) _IRR_OVERRIDE_;

	//! Gets the color of the top and bottom vertices of the billboard
	//! \param[out] topColor: stores the color of the top vertices
	//! \param[out] bottomColor: stores the color of the bottom vertices
	virtual void getColor(video::SColor& topColor,
			video::SColor& bottomColor) const _IRR_OVERRIDE_;

	//! Get the real boundingbox used by the billboard (which depends on the active camera)
	virtual const core::aabbox3d<f32>& getTransformedBillboardBoundingBox(const irr::scene::ICameraSceneNode* camera) _IRR_OVERRIDE_;

	//! Writes attributes of the scene node.
	virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options=0) const _IRR_OVERRIDE_;

	//! Reads attributes of the scene node.
	virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options=0) _IRR_OVERRIDE_;

	//! Returns type of the scene node
	virtual ESCENE_NODE_TYPE getType() const _IRR_OVERRIDE_ { return ESNT_BILLBOARD; }

	//! Creates a clone of this scene node and its children.
	virtual ISceneNode* clone(ISceneNode* newParent=0, ISceneManager* newManager=0) _IRR_OVERRIDE_;

protected:
	void updateMesh(const irr::scene::ICameraSceneNode* camera);

private:

	//! Size.Width is the bottom edge width
	core::dimension2d<f32> Size;
	f32 TopEdgeWidth;

	//! BoundingBox which is large enough to contain the billboard independent of the camera
	// TODO: BUG - still can be wrong with scaling < 1. Billboards should calculate relative coordinates for their mesh
	// and then use the node-scaling. But needs some work...
	/** Note that we can't use the real boundingbox for culling because at that point
	    the camera which is used to calculate the billboard is not yet updated. So we only
	    know the real boundingbox after rendering - which is too late for culling. */
	core::aabbox3d<f32> BBoxSafe;

	scene::SMeshBuffer* Buffer;
};


} // end namespace scene
} // end namespace irr

#endif

