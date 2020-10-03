// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_SCENE_NODE_ANIMATOR_H_INCLUDED__
#define __I_SCENE_NODE_ANIMATOR_H_INCLUDED__

#include "IReferenceCounted.h"
#include "vector3d.h"
#include "ESceneNodeAnimatorTypes.h"
#include "IAttributeExchangingObject.h"
#include "IAttributes.h"
#include "IEventReceiver.h"

namespace irr
{
namespace io
{
	class IAttributes;
} // end namespace io
namespace scene
{
	class ISceneNode;
	class ISceneManager;

	//! Animates a scene node. Can animate position, rotation, material, and so on.
	/** A scene node animator is able to animate a scene node in a very simple way. It may
	change its position, rotation, scale and/or material. There are lots of animators
	to choose from. You can create scene node animators with the ISceneManager interface.
	*/
	class ISceneNodeAnimator : public io::IAttributeExchangingObject, public IEventReceiver
	{
	public:
		ISceneNodeAnimator() : IsEnabled(true), PauseTimeSum(0), PauseTimeStart(0), StartTime(0)
		{
		}

		//! Animates a scene node.
		/** \param node Node to animate.
		\param timeMs Current time in milliseconds. */
		virtual void animateNode(ISceneNode* node, u32 timeMs) =0;

		//! Creates a clone of this animator.
		/** Please note that you will have to drop
		(IReferenceCounted::drop()) the returned pointer after calling this. */
		virtual ISceneNodeAnimator* createClone(ISceneNode* node,
				ISceneManager* newManager=0) =0;

		//! Returns true if this animator receives events.
		/** When attached to an active camera, this animator will be
		able to respond to events such as mouse and keyboard events. */
		virtual bool isEventReceiverEnabled() const
		{
			return false;
		}

		//! Event receiver, override this function for camera controlling animators
		virtual bool OnEvent(const SEvent& event) _IRR_OVERRIDE_
		{
			return false;
		}

		//! Returns type of the scene node animator
		virtual ESCENE_NODE_ANIMATOR_TYPE getType() const
		{
			return ESNAT_UNKNOWN;
		}

		//! Returns if the animator has finished.
		/** This is only valid for non-looping animators with a discrete end state.
		\return true if the animator has finished, false if it is still running. */
		virtual bool hasFinished(void) const
		{
			return false;
		}

		//! Reset a time-based movement by changing the starttime.
		/** By default most animators start on object creation.
			This value is ignored by animators which don't work with a starttime.
			Known problems: CSceneNodeAnimatorRotation currently overwrites this value constantly (might be changed in the future).
			\param time Commonly you will use irr::ITimer::getTime().
			\param resetPauseTime Reset internal pause time for enabling/diabling animators as well
		*/
		virtual void setStartTime(u32 time, bool resetPauseTime=true)
		{
			StartTime = time;
			if ( resetPauseTime )
			{
				PauseTimeStart = 0;
				PauseTimeSum = 0;
			}
		}

		//! Get the starttime.
		/** This will return 0 for by animators which don't work with a starttime unless a starttime was manually set */
		virtual irr::u32 getStartTime() const
		{
			return StartTime;
		}

		//! Sets the enabled state of this element.
		/**
		\param enabled When set to false ISceneNodes will not update the animator anymore.
		       Animators themselves usually don't care. So manual calls to animateNode still work.
		\param timeNow When set to values > 0 on enabling and disabling an internal timer will be increased by the time disabled time.
			   Animator decide themselves how to handle that timer, but generally setting it will allow you to pause an animator, so it
			   will continue at the same position when you enable it again. To use that pass irr::ITimer::getTime() as value.
			   Animators with no timers will just ignore this.
		*/
		virtual void setEnabled(bool enabled, u32 timeNow=0)
		{
			if ( enabled == IsEnabled )
				return;
			IsEnabled = enabled;
			if ( enabled )
			{
				if ( timeNow > 0 && PauseTimeStart > 0 )
					PauseTimeSum += timeNow-PauseTimeStart;
			}
			else
			{
				PauseTimeStart = timeNow;
			}
		}

		virtual bool isEnabled() const
		{
			return IsEnabled;
		}

		//! Writes attributes of the scene node animator.
		virtual void serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options=0) const _IRR_OVERRIDE_
		{
			out->addBool("IsEnabled", IsEnabled);
			// timers not serialized as they usually depend on system-time which is different on each application start.
		}

		//! Reads attributes of the scene node animator.
		virtual void deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options=0) _IRR_OVERRIDE_
		{
			IsEnabled = in->getAttributeAsBool("IsEnabled", IsEnabled);
			PauseTimeSum = 0;
			PauseTimeStart = 0;
		}

	protected:

		/** This method can be used by clone() implementations of
		derived classes
		\param toCopyFrom The animator from which the values are copied */
		void cloneMembers(const ISceneNodeAnimator* toCopyFrom)
		{
			IsEnabled = toCopyFrom->IsEnabled;
			PauseTimeSum = toCopyFrom->IsEnabled;
			PauseTimeStart = toCopyFrom->PauseTimeStart;
			StartTime = toCopyFrom->StartTime;
		}

		bool IsEnabled;		//! Only enabled animators are updated
		u32 PauseTimeSum;	//! Sum up time which the animator was disabled
		u32 PauseTimeStart;	//! Last time setEnabled(false) was called with a timer > 0
		u32 StartTime;		//! Used by animators which are time-based, ignored otherwise.
	};


} // end namespace scene
} // end namespace irr

#endif

