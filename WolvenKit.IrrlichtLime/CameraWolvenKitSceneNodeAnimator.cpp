#include "stdafx.h"
#include "CameraWolvenKitSceneNodeAnimator.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	CameraWolvenKitSceneNodeAnimator^ CameraWolvenKitSceneNodeAnimator::Wrap(scene::ISceneNodeAnimatorCameraMaya* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew CameraWolvenKitSceneNodeAnimator(ref);
}

	CameraWolvenKitSceneNodeAnimator::CameraWolvenKitSceneNodeAnimator(scene::ISceneNodeAnimatorCameraMaya* ref)
	: SceneNodeAnimator(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_CameraWolvenKitSceneNodeAnimator = ref;
}

float CameraWolvenKitSceneNodeAnimator::Distance::get()
{
	return m_CameraWolvenKitSceneNodeAnimator->getDistance();
}

void CameraWolvenKitSceneNodeAnimator::Distance::set(float value)
{
	LIME_ASSERT(value > 0.0f);
	m_CameraWolvenKitSceneNodeAnimator->setDistance(value);
}

float CameraWolvenKitSceneNodeAnimator::MoveSpeed::get()
{
	return m_CameraWolvenKitSceneNodeAnimator->getMoveSpeed();
}

void CameraWolvenKitSceneNodeAnimator::MoveSpeed::set(float value)
{
	m_CameraWolvenKitSceneNodeAnimator->setMoveSpeed(value);
}

float CameraWolvenKitSceneNodeAnimator::RotateSpeed::get()
{
	return m_CameraWolvenKitSceneNodeAnimator->getRotateSpeed();
}

void CameraWolvenKitSceneNodeAnimator::RotateSpeed::set(float value)
{
	m_CameraWolvenKitSceneNodeAnimator->setRotateSpeed(value);
}

float CameraWolvenKitSceneNodeAnimator::ZoomSpeed::get()
{
	return m_CameraWolvenKitSceneNodeAnimator->getZoomSpeed();
}

void CameraWolvenKitSceneNodeAnimator::ZoomSpeed::set(float value)
{
	m_CameraWolvenKitSceneNodeAnimator->setZoomSpeed(value);
}

Vector3Df^ CameraWolvenKitSceneNodeAnimator::ModelRotation::get()
{
    return gcnew Vector3Df(m_CameraWolvenKitSceneNodeAnimator->getModelRotation());
}

} // end namespace Scene
} // end namespace IrrlichtLime