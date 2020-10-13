#include "stdafx.h"
#include "CameraMayaSceneNodeAnimator.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

CameraMayaSceneNodeAnimator^ CameraMayaSceneNodeAnimator::Wrap(scene::ISceneNodeAnimatorCameraMaya* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew CameraMayaSceneNodeAnimator(ref);
}

CameraMayaSceneNodeAnimator::CameraMayaSceneNodeAnimator(scene::ISceneNodeAnimatorCameraMaya* ref)
	: SceneNodeAnimator(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_CameraMayaSceneNodeAnimator = ref;
}

float CameraMayaSceneNodeAnimator::Distance::get()
{
	return m_CameraMayaSceneNodeAnimator->getDistance();
}

void CameraMayaSceneNodeAnimator::Distance::set(float value)
{
	LIME_ASSERT(value > 0.0f);
	m_CameraMayaSceneNodeAnimator->setDistance(value);
}

float CameraMayaSceneNodeAnimator::MoveSpeed::get()
{
	return m_CameraMayaSceneNodeAnimator->getMoveSpeed();
}

void CameraMayaSceneNodeAnimator::MoveSpeed::set(float value)
{
	m_CameraMayaSceneNodeAnimator->setMoveSpeed(value);
}

float CameraMayaSceneNodeAnimator::RotateSpeed::get()
{
	return m_CameraMayaSceneNodeAnimator->getRotateSpeed();
}

void CameraMayaSceneNodeAnimator::RotateSpeed::set(float value)
{
	m_CameraMayaSceneNodeAnimator->setRotateSpeed(value);
}

float CameraMayaSceneNodeAnimator::ZoomSpeed::get()
{
	return m_CameraMayaSceneNodeAnimator->getZoomSpeed();
}

void CameraMayaSceneNodeAnimator::ZoomSpeed::set(float value)
{
	m_CameraMayaSceneNodeAnimator->setZoomSpeed(value);
}

} // end namespace Scene
} // end namespace IrrlichtLime