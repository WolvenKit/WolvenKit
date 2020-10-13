// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_SCENE_NODE_ANIMATOR_CAMERA_MAYA_H_INCLUDED__
#define __C_SCENE_NODE_ANIMATOR_CAMERA_MAYA_H_INCLUDED__

#include "ISceneNodeAnimatorCameraMaya.h"
#include "ICameraSceneNode.h"
#include "vector2d.h"

namespace irr
{

namespace gui
{
	class ICursorControl;
}

namespace scene
{

	//! Special scene node animator for FPS cameras
	/** This scene node animator can be attached to a camera to make it act
	like a 3d modeling tool camera
	*/
	class CSceneNodeAnimatorCameraMaya : public ISceneNodeAnimatorCameraMaya
	{
	public:
		//! Constructor
		CSceneNodeAnimatorCameraMaya(gui::ICursorControl* cursor, f32 rotateSpeed = -1500.f,
			f32 zoomSpeed = 200.f, f32 translationSpeed = 1500.f, f32 distance=70.f);

		//! Destructor
		virtual ~CSceneNodeAnimatorCameraMaya();

		//! Animates the scene node, currently only works on cameras
		virtual void animateNode(ISceneNode* node, u32 timeMs) _IRR_OVERRIDE_;

		//! Event receiver
		virtual bool OnEvent(const SEvent& event) _IRR_OVERRIDE_;

		//! Returns the speed of movement in units per millisecond
		virtual f32 getMoveSpeed() const _IRR_OVERRIDE_;

		//! Sets the speed of movement in units per millisecond
		virtual void setMoveSpeed(f32 moveSpeed) _IRR_OVERRIDE_;

		//! Returns the rotation speed
		virtual f32 getRotateSpeed() const _IRR_OVERRIDE_;

		//! Set the rotation speed
		virtual void setRotateSpeed(f32 rotateSpeed) _IRR_OVERRIDE_;

		//! Returns the zoom speed
		virtual f32 getZoomSpeed() const _IRR_OVERRIDE_;

		//! Set the zoom speed
		virtual void setZoomSpeed(f32 zoomSpeed) _IRR_OVERRIDE_;

		//! Returns the current distance, i.e. orbit radius
		virtual f32 getDistance() const _IRR_OVERRIDE_;

		//! Set the distance
		virtual void setDistance(f32 distance) _IRR_OVERRIDE_;

		//! Set the minimal distance to the camera target for zoom
		virtual void setTargetMinDistance(f32 minDistance) _IRR_OVERRIDE_;

		//! Returns the minimal distance to the camera target for zoom
		virtual f32 getTargetMinDistance() const _IRR_OVERRIDE_;

		//! This animator will receive events when attached to the active camera
		virtual bool isEventReceiverEnabled() const _IRR_OVERRIDE_
		{
			return true;
		}

		//! Returns type of the scene node
		virtual ESCENE_NODE_ANIMATOR_TYPE getType() const _IRR_OVERRIDE_
		{
			return ESNAT_CAMERA_MAYA;
		}

		//! Creates a clone of this animator.
		/** Please note that you will have to drop
		(IReferenceCounted::drop()) the returned pointer after calling
		this. */
		virtual ISceneNodeAnimator* createClone(ISceneNode* node, ISceneManager* newManager=0) _IRR_OVERRIDE_;

		//! Writes attributes of the scene node animator.
		virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options=0) const _IRR_OVERRIDE_;

		//! Reads attributes of the scene node animator.
		virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options=0) _IRR_OVERRIDE_;

	private:

		void allKeysUp();
		void animate();
		bool isMouseKeyDown(s32 key) const;

		bool MouseKeys[3];

		gui::ICursorControl *CursorControl;
		scene::ICameraSceneNode* OldCamera;
		core::vector3df OldTarget;
		core::vector3df LastCameraTarget;	// to find out if the camera target was moved outside this animator
		core::position2df RotateStart;
		core::position2df ZoomStart;
		core::position2df TranslateStart;
		core::position2df MousePos;
		f32 TargetMinDistance;
		f32 ZoomSpeed;
		f32 RotateSpeed;
		f32 TranslateSpeed;
		f32 CurrentZoom;
		f32 RotX, RotY;
		bool Zooming;
		bool Rotating;
		bool Moving;
		bool Translating;
	};

} // end namespace scene
} // end namespace irr

#endif

