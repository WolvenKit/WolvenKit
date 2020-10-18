#pragma once

#include "stdafx.h"
#include "SceneNodeAnimator.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public ref class CameraWolvenKitSceneNodeAnimator : SceneNodeAnimator
{
public:

	property float Distance { float get(); void set(float value); }
	property float MoveSpeed { float get(); void set(float value); }
	property float RotateSpeed { float get(); void set(float value); }
	property float ZoomSpeed { float get(); void set(float value); }
	property Vector3Df^ ModelRotation { Vector3Df^ get(); }

internal:

	static CameraWolvenKitSceneNodeAnimator^ Wrap(scene::ISceneNodeAnimatorCameraMaya* ref);
	CameraWolvenKitSceneNodeAnimator(scene::ISceneNodeAnimatorCameraMaya* ref);

	scene::ISceneNodeAnimatorCameraMaya* m_CameraWolvenKitSceneNodeAnimator;
};

} // end namespace Scene
} // end namespace IrrlichtLime