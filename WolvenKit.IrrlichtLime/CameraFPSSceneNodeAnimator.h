#pragma once

#include "stdafx.h"
#include "SceneNodeAnimator.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public ref class CameraFPSSceneNodeAnimator : SceneNodeAnimator
{
public:

	void SetInvertMouse(bool invert);
	void SetVerticalMovement(bool allow);

	property IrrlichtLime::KeyMap^ KeyMap { IrrlichtLime::KeyMap^ get(); void set(IrrlichtLime::KeyMap^ value); }
	property float MoveSpeed { float get(); void set(float value); }
	property float RotateSpeed { float get(); void set(float value); }

internal:

	static CameraFPSSceneNodeAnimator^ Wrap(scene::ISceneNodeAnimatorCameraFPS* ref);
	CameraFPSSceneNodeAnimator(scene::ISceneNodeAnimatorCameraFPS* ref);

	scene::ISceneNodeAnimatorCameraFPS* m_CameraFPSSceneNodeAnimator;
};

} // end namespace Scene
} // end namespace IrrlichtLime