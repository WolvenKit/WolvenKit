#include "CSceneNodeAnimatorCameraWolvenKit.h"
#include "ICursorControl.h"
#include "ICameraSceneNode.h"
#include "SViewFrustum.h"
#include "ISceneManager.h"

namespace irr
{
namespace scene
{

//! constructor
CSceneNodeAnimatorCameraWolvenKit::CSceneNodeAnimatorCameraWolvenKit(gui::ICursorControl* cursor,
	f32 rotateSpeed, f32 zoomSpeed, f32 translateSpeed, f32 distance)
	: CursorControl(cursor), OldCamera(0), MousePos(0.5f, 0.5f), WheelDelta(0.0f),
	TargetMinDistance(0.f),
	ZoomSpeed(zoomSpeed), RotateSpeed(rotateSpeed), TranslateSpeed(translateSpeed),
	CurrentZoom(distance), RotX(0.0f), RotY(0.0f), nRotX(0.0f), nRotY(0.0f),
	Zooming(false), Rotating(false), Moving(false), Translating(false)
{
	#ifdef _DEBUG
	setDebugName("CSceneNodeAnimatorCameraWolvenKit");
	#endif

	if (CursorControl)
	{
		CursorControl->grab();
		MousePos = CursorControl->getRelativePosition();
	}

	allKeysUp();
}


//! destructor
CSceneNodeAnimatorCameraWolvenKit::~CSceneNodeAnimatorCameraWolvenKit()
{
	if (CursorControl)
		CursorControl->drop();
}


//! It is possible to send mouse and key events to the camera. Most cameras
//! may ignore this input, but camera scene nodes which are created for
//! example with scene::ISceneManager::addMayaCameraSceneNode or
//! scene::ISceneManager::addMeshViewerCameraSceneNode, may want to get this input
//! for changing their position, look at target or whatever.
bool CSceneNodeAnimatorCameraWolvenKit::OnEvent(const SEvent& event)
{
	if (event.EventType != EET_MOUSE_INPUT_EVENT)
		return false;

	WheelDelta = 0.0f;

	switch(event.MouseInput.Event)
	{
	case EMIE_LMOUSE_PRESSED_DOWN:
		MouseKeys[0] = true;
		break;
	case EMIE_RMOUSE_PRESSED_DOWN:
		MouseKeys[2] = true;
		break;
	case EMIE_MMOUSE_PRESSED_DOWN:
		MouseKeys[1] = true;
		break;
	case EMIE_LMOUSE_LEFT_UP:
		MouseKeys[0] = false;
		break;
	case EMIE_RMOUSE_LEFT_UP:
		MouseKeys[2] = false;
		break;
	case EMIE_MMOUSE_LEFT_UP:
		MouseKeys[1] = false;
		break;
	case EMIE_MOUSE_MOVED:
		// check states again because sometimes the gui has already caught events
		MouseKeys[0] = event.MouseInput.isLeftPressed();
		MouseKeys[2] = event.MouseInput.isRightPressed();
		MouseKeys[1] = event.MouseInput.isMiddlePressed();

		if ( CursorControl )
		{
			MousePos = CursorControl->getRelativePosition();
		}
		break;
	case EMIE_MOUSE_WHEEL:
		WheelDelta = event.MouseInput.Wheel;
		Zooming = true;
		break;
	case EMIE_LMOUSE_DOUBLE_CLICK:
	case EMIE_RMOUSE_DOUBLE_CLICK:
	case EMIE_MMOUSE_DOUBLE_CLICK:
	case EMIE_LMOUSE_TRIPLE_CLICK:
	case EMIE_RMOUSE_TRIPLE_CLICK:
	case EMIE_MMOUSE_TRIPLE_CLICK:
	case EMIE_COUNT:
		return false;
	}
	return true;
}


//! OnAnimate() is called just before rendering the whole scene.
void CSceneNodeAnimatorCameraWolvenKit::animateNode(ISceneNode *node, u32 timeMs)
{
	//LM = Rotate around camera pivot
	//Wheel = Dolly forth/back in view direction (speed % distance camera pivot - max distance to pivot)

	if (!node || node->getType() != ESNT_CAMERA)
		return;

	ICameraSceneNode* camera = static_cast<ICameraSceneNode*>(node);

	// If the camera isn't the active camera, and receiving input, then don't process it.
	if (!camera->isInputReceiverEnabled())
	{
		return;
	}

	scene::ISceneManager * smgr = camera->getSceneManager();
	if (smgr && smgr->getActiveCamera() != camera)
		return;

	if (OldCamera != camera)
	{
		LastCameraTarget = OldTarget = camera->getTarget();
		OldCamera = camera;
	}
	else
	{
		OldTarget += camera->getTarget() - LastCameraTarget;
	}

	nRotX = RotX;
	nRotY = RotY;
	f32 nZoom = CurrentZoom;

	if (Zooming)
	{
        const f32 old = CurrentZoom;
        CurrentZoom = CurrentZoom + WheelDelta * ZoomSpeed;
        nZoom = CurrentZoom;

        if (nZoom < TargetMinDistance)
            nZoom = CurrentZoom = old;
		Zooming = false;
	}

	// Translation ---------------------------------

	core::vector3df translate(OldTarget);
	const core::vector3df upVector(camera->getUpVector());
	const core::vector3df target = camera->getTarget();

	core::vector3df pos = camera->getPosition();
	core::vector3df tvectX = pos - target;
	tvectX = tvectX.crossProduct(upVector);
	tvectX.normalize();

	const SViewFrustum* const va = camera->getViewFrustum();
	core::vector3df tvectY = (va->getFarLeftDown() - va->getFarRightDown());
	tvectY = tvectY.crossProduct(upVector.Y > 0 ? pos - target : target - pos);
	tvectY.normalize();

	if (isMouseKeyDown(2) && !Zooming)
	{
		if (!Translating)
		{
			TranslateStart = MousePos;
			Translating = true;
		}
		else
		{
			translate +=  tvectX * (TranslateStart.X - MousePos.X)*TranslateSpeed +
			              tvectY * (TranslateStart.Y - MousePos.Y)*TranslateSpeed;
		}
	}
	else if (Translating)
	{
		translate += tvectX * (TranslateStart.X - MousePos.X)*TranslateSpeed +
		             tvectY * (TranslateStart.Y - MousePos.Y)*TranslateSpeed;
		OldTarget = translate;
		Translating = false;
	}

	// Rotation ------------------------------------

	if (isMouseKeyDown(0) && !Zooming)
	{
		if (!Rotating)
		{
			RotateStart = MousePos;
			Rotating = true;
			nRotX = RotX;
			nRotY = RotY;
		}
		else
		{
			nRotX += (RotateStart.X - MousePos.X) * RotateSpeed;
			nRotY += (RotateStart.Y - MousePos.Y) * RotateSpeed;
		}
	}
	else if (Rotating)
	{
		RotX += (RotateStart.X - MousePos.X) * RotateSpeed;
		RotY += (RotateStart.Y - MousePos.Y) * RotateSpeed;
		nRotX = RotX;
		nRotY = RotY;
		Rotating = false;
	}

	// Set pos ------------------------------------

    pos = translate;
    pos.X += nZoom;

	pos.rotateXYBy(nRotY, translate);
	pos.rotateXZBy(-nRotX, translate);

	camera->setPosition(pos);
	camera->setTarget(translate);

	// Rotation Error ----------------------------

	// jox: fixed bug: jitter when rotating to the top and bottom of y
	pos.set(0,1,0);
	pos.rotateXYBy(-nRotY);
	pos.rotateXZBy(-nRotX+180.f);
	camera->setUpVector(pos);
	LastCameraTarget = camera->getTarget();
}


bool CSceneNodeAnimatorCameraWolvenKit::isMouseKeyDown(s32 key) const
{
	return MouseKeys[key];
}


void CSceneNodeAnimatorCameraWolvenKit::allKeysUp()
{
	for (s32 i=0; i<3; ++i)
		MouseKeys[i] = false;
}


//! Sets the rotation speed
void CSceneNodeAnimatorCameraWolvenKit::setRotateSpeed(f32 speed)
{
	RotateSpeed = speed;
}


//! Sets the movement speed
void CSceneNodeAnimatorCameraWolvenKit::setMoveSpeed(f32 speed)
{
	TranslateSpeed = speed;
}


//! Sets the zoom speed
void CSceneNodeAnimatorCameraWolvenKit::setZoomSpeed(f32 speed)
{
	ZoomSpeed = speed;
}


//! Set the distance
void CSceneNodeAnimatorCameraWolvenKit::setDistance(f32 distance)
{
	CurrentZoom=distance;
}


//! Gets the rotation speed
f32 CSceneNodeAnimatorCameraWolvenKit::getRotateSpeed() const
{
	return RotateSpeed;
}


// Gets the movement speed
f32 CSceneNodeAnimatorCameraWolvenKit::getMoveSpeed() const
{
	return TranslateSpeed;
}


//! Gets the zoom speed
f32 CSceneNodeAnimatorCameraWolvenKit::getZoomSpeed() const
{
	return ZoomSpeed;
}


//! Returns the current distance, i.e. orbit radius
f32 CSceneNodeAnimatorCameraWolvenKit::getDistance() const
{
	return CurrentZoom;
}

void CSceneNodeAnimatorCameraWolvenKit::setTargetMinDistance(f32 minDistance)
{
	TargetMinDistance = minDistance;
	if ( CurrentZoom < TargetMinDistance )
		CurrentZoom = TargetMinDistance;
}

f32 CSceneNodeAnimatorCameraWolvenKit::getTargetMinDistance() const
{
	return TargetMinDistance;
}

//! Returns the model rotation
const core::vector3df CSceneNodeAnimatorCameraWolvenKit::getModelRotation() const
{
	return core::vector3df(0.0f, -nRotX, nRotY);
}

ISceneNodeAnimator* CSceneNodeAnimatorCameraWolvenKit::createClone(ISceneNode* node, ISceneManager* newManager)
{
	CSceneNodeAnimatorCameraWolvenKit* newAnimator =
		new CSceneNodeAnimatorCameraWolvenKit(CursorControl, RotateSpeed, ZoomSpeed, TranslateSpeed);
	newAnimator->cloneMembers(this);
	return newAnimator;
}

void CSceneNodeAnimatorCameraWolvenKit::serializeAttributes(io::IAttributes* out, io::SAttributeReadWriteOptions* options) const
{
	ISceneNodeAnimator::serializeAttributes(out, options);

	out->addFloat("TargetMinDistance", TargetMinDistance);
	out->addFloat("ZoomSpeed", ZoomSpeed);
	out->addFloat("RotateSpeed", RotateSpeed);
	out->addFloat("TranslateSpeed", TranslateSpeed);
	out->addFloat("CurrentZoom", CurrentZoom);
}

void CSceneNodeAnimatorCameraWolvenKit::deserializeAttributes(io::IAttributes* in, io::SAttributeReadWriteOptions* options)
{
	ISceneNodeAnimator::deserializeAttributes(in, options);

	TargetMinDistance = in->getAttributeAsFloat("TargetMinDistance", TargetMinDistance);
	ZoomSpeed = in->getAttributeAsFloat("ZoomSpeed", ZoomSpeed);
	RotateSpeed = in->getAttributeAsFloat("RotateSpeed", RotateSpeed);
	TranslateSpeed = in->getAttributeAsFloat("TranslateSpeed", TranslateSpeed);
	CurrentZoom = in->getAttributeAsFloat("CurrentZoom", CurrentZoom);
}

} // end namespace
} // end namespace

