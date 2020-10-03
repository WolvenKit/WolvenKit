#pragma once

#include "stdafx.h"
#include "SceneNodeAnimator.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public ref class CameraMayaSceneNodeAnimator : SceneNodeAnimator
{
public:

	property float Distance { float get(); void set(float value); }
	property float MoveSpeed { float get(); void set(float value); }
	property float RotateSpeed { float get(); void set(float value); }
	property float ZoomSpeed { float get(); void set(float value); }

internal:

	static CameraMayaSceneNodeAnimator^ Wrap(scene::ISceneNodeAnimatorCameraMaya* ref);
	CameraMayaSceneNodeAnimator(scene::ISceneNodeAnimatorCameraMaya* ref);

	scene::ISceneNodeAnimatorCameraMaya* m_CameraMayaSceneNodeAnimator;
};

} // end namespace Scene
} // end namespace IrrlichtLime