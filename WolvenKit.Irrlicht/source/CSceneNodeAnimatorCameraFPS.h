// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_SCENE_NODE_ANIMATOR_CAMERA_FPS_H_INCLUDED__
#define __C_SCENE_NODE_ANIMATOR_CAMERA_FPS_H_INCLUDED__

#include "ISceneNodeAnimatorCameraFPS.h"
#include "vector2d.h"
#include "position2d.h"
#include "SKeyMap.h"
#include "irrArray.h"

namespace irr
{
namespace gui
{
	class ICursorControl;
}

namespace scene
{

	//! Special scene node animator for FPS cameras
	class CSceneNodeAnimatorCameraFPS : public ISceneNodeAnimatorCameraFPS
	{
	public:

		//! Constructor
		CSceneNodeAnimatorCameraFPS(gui::ICursorControl* cursorControl,
			f32 rotateSpeed = 100.0f, f32 moveSpeed = .5f, f32 jumpSpeed=0.f,
			SKeyMap* keyMapArray=0, u32 keyMapSize=0, bool noVerticalMovement=false,
			bool invertY=false, float rotateSpeedKeyboard = 0.3f);

		//! Destructor
		virtual ~CSceneNodeAnimatorCameraFPS();

		//! Animates the scene node, currently only works on cameras
		virtual void animateNode(ISceneNode* node, u32 timeMs) _IRR_OVERRIDE_;

		//! Event receiver
		virtual bool OnEvent(const SEvent& event) _IRR_OVERRIDE_;

		//! Returns the speed of movement in units per second
		virtual f32 getMoveSpeed() const _IRR_OVERRIDE_;

		//! Sets the speed of movement in units per second
		virtual void setMoveSpeed(f32 moveSpeed) _IRR_OVERRIDE_;

		//! Returns the rotation speed when moving mouse
		virtual f32 getRotateSpeed() const _IRR_OVERRIDE_;

		//! Set the rotation speed when moving mouse
		virtual void setRotateSpeed(f32 rotateSpeed) _IRR_OVERRIDE_;

		//! Returns the rotation speed when using keyboard
		virtual f32 getRotateSpeedKeyboard() const _IRR_OVERRIDE_
		{
			return RotateSpeedKeyboard;
		}

		//! Set the rotation speed when using keyboard
		virtual void setRotateSpeedKeyboard(f32 rotateSpeed) _IRR_OVERRIDE_
		{
			RotateSpeedKeyboard = rotateSpeed;
		}

		//! Sets the keyboard mapping for this animator (old style)
		//! \param keymap: an array of keyboard mappings, see SKeyMap
		//! \param count: the size of the keyboard map array
		virtual void setKeyMap(SKeyMap *map, u32 count) _IRR_OVERRIDE_;

		//! Sets the keyboard mapping for this animator
		//!	\param keymap The new keymap array
		virtual void setKeyMap(const core::array<SKeyMap>& keymap) _IRR_OVERRIDE_;

		//! Gets the keyboard mapping for this animator
		virtual const core::array<SKeyMap>& getKeyMap() const _IRR_OVERRIDE_;

		//! Sets whether vertical movement should be allowed.
		virtual void setVerticalMovement(bool allow) _IRR_OVERRIDE_;

		//! Sets whether the Y axis of the mouse should be inverted.
		/** If enabled then moving the mouse down will cause
		the camera to look up. It is disabled by default. */
		virtual void setInvertMouse(bool invert) _IRR_OVERRIDE_;

		//! This animator will receive events when attached to the active camera
		virtual bool isEventReceiverEnabled() const _IRR_OVERRIDE_
		{
			return true;
		}

		//! Returns the type of this animator
		virtual ESCENE_NODE_ANIMATOR_TYPE getType() const _IRR_OVERRIDE_
		{
			return ESNAT_CAMERA_FPS;
		}

		//! Creates a clone of this animator.
		/** Please note that you will have to drop
		(IReferenceCounted::drop()) the returned pointer once you're
		done with it. */
		virtual ISceneNodeAnimator* createClone(ISceneNode* node, ISceneManager* newManager=0) _IRR_OVERRIDE_;

		//! Writes attributes of the scene node animator.
		virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options=0) const _IRR_OVERRIDE_;

		//! Reads attributes of the scene node animator.
		virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options=0) _IRR_OVERRIDE_;


	private:
		void allKeysUp();

		gui::ICursorControl *CursorControl;

		f32 MaxVerticalAngle;
		bool NoVerticalMovement;

		f32 MoveSpeed;
		f32 RotateSpeedKeyboard;
		f32 RotateSpeed;
		f32 JumpSpeed;
		// -1.0f for inverted mouse, defaults to 1.0f
		f32 MouseYDirection;

		s32 LastAnimationTime;

		core::array<SKeyMap> KeyMap;
		core::position2d<f32> CenterCursor, CursorPos;

		bool CursorKeys[EKA_COUNT];

		bool firstUpdate;
		bool firstInput;
	};

} // end namespace scene
} // end namespace irr

#endif // __C_SCENE_NODE_ANIMATOR_CAMERA_FPS_H_INCLUDED__

