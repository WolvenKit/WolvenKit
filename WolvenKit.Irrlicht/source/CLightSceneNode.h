// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_LIGHT_SCENE_NODE_H_INCLUDED__
#define __C_LIGHT_SCENE_NODE_H_INCLUDED__

#include "ILightSceneNode.h"

namespace irr
{
namespace scene
{

//! Scene node which is a dynamic light. You can switch the light on and off by
//! making it visible or not, and let it be animated by ordinary scene node animators.
class CLightSceneNode : public ILightSceneNode
{
public:

	//! constructor
	CLightSceneNode(ISceneNode* parent, ISceneManager* mgr, s32 id,
		const core::vector3df& position, video::SColorf color, f32 range);

	//! pre render event
	virtual void OnRegisterSceneNode() _IRR_OVERRIDE_;

	//! render
	virtual void render() _IRR_OVERRIDE_;

	//! set node light data from light info
	virtual void setLightData(const video::SLight& light) _IRR_OVERRIDE_;

	//! \return Returns the light data.
	virtual const video::SLight& getLightData() const _IRR_OVERRIDE_;

	//! \return Returns the light data.
	virtual video::SLight& getLightData() _IRR_OVERRIDE_;

	//! Sets if the node should be visible or not.
	/** All children of this node won't be visible either, when set
	to true.
	\param isVisible If the node shall be visible. */
	virtual void setVisible(bool isVisible) _IRR_OVERRIDE_;

	//! returns the axis aligned bounding box of this node
	virtual const core::aabbox3d<f32>& getBoundingBox() const _IRR_OVERRIDE_;

	//! Returns type of the scene node
	virtual ESCENE_NODE_TYPE getType() const _IRR_OVERRIDE_ { return ESNT_LIGHT; }

	//! Writes attributes of the scene node.
	virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options=0) const _IRR_OVERRIDE_;

	//! Reads attributes of the scene node.
	virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options=0) _IRR_OVERRIDE_;

	//! Creates a clone of this scene node and its children.
	virtual ISceneNode* clone(ISceneNode* newParent=0, ISceneManager* newManager=0) _IRR_OVERRIDE_;

	//! Sets the light's radius of influence.
	/** Outside this radius the light won't lighten geometry and cast no
	shadows. Setting the radius will also influence the attenuation, setting
	it to (0,1/radius,0). If you want to override this behavior, set the
	attenuation after the radius.
	\param radius The new radius. */
	virtual void setRadius(f32 radius) _IRR_OVERRIDE_;

	//! Gets the light's radius of influence.
	/** \return The current radius. */
	virtual f32 getRadius() const _IRR_OVERRIDE_;

	//! Sets the light type.
	/** \param type The new type. */
	virtual void setLightType(video::E_LIGHT_TYPE type) _IRR_OVERRIDE_;

	//! Gets the light type.
	/** \return The current light type. */
	virtual video::E_LIGHT_TYPE getLightType() const _IRR_OVERRIDE_;

	//! Sets whether this light casts shadows.
	/** Enabling this flag won't automatically cast shadows, the meshes
	will still need shadow scene nodes attached. But one can enable or
	disable distinct lights for shadow casting for performance reasons.
	\param shadow True if this light shall cast shadows. */
	virtual void enableCastShadow(bool shadow=true) _IRR_OVERRIDE_;

	//! Check whether this light casts shadows.
	/** \return True if light would cast shadows, else false. */
	virtual bool getCastShadow() const _IRR_OVERRIDE_;

	//! Updates the absolute position based on the relative and the parents position
	virtual void updateAbsolutePosition() _IRR_OVERRIDE_;

private:

	video::SLight LightData;
	core::aabbox3d<f32> BBox;
	s32 DriverLightIndex;
	bool LightIsOn;
	void doLightRecalc();
};


} // end namespace scene
} // end namespace irr

#endif

