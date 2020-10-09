#include "stdafx.h"
#include "CollisionResponseSceneNodeAnimator.h"
#include "SceneNode.h"
#include "TriangleSelector.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

CollisionResponseSceneNodeAnimator^ CollisionResponseSceneNodeAnimator::Wrap(scene::ISceneNodeAnimatorCollisionResponse* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew CollisionResponseSceneNodeAnimator(ref);
}

CollisionResponseSceneNodeAnimator::CollisionResponseSceneNodeAnimator(scene::ISceneNodeAnimatorCollisionResponse* ref)
	: SceneNodeAnimator(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_CollisionResponseSceneNodeAnimator = ref;
}

void CollisionResponseSceneNodeAnimator::Jump(float jumpSpeed)
{
	m_CollisionResponseSceneNodeAnimator->jump(jumpSpeed);
}

bool CollisionResponseSceneNodeAnimator::AnimateTarget::get()
{
	return m_CollisionResponseSceneNodeAnimator->getAnimateTarget();
}

void CollisionResponseSceneNodeAnimator::AnimateTarget::set(bool value)
{
	return m_CollisionResponseSceneNodeAnimator->setAnimateTarget(value);
}

SceneNode^ CollisionResponseSceneNodeAnimator::CollisionNode::get()
{
	scene::ISceneNode* n = m_CollisionResponseSceneNodeAnimator->getCollisionNode();
	return SceneNode::Wrap(n);
}

bool CollisionResponseSceneNodeAnimator::CollisionOccurred::get()
{
	return m_CollisionResponseSceneNodeAnimator->collisionOccurred();
}

Vector3Df^ CollisionResponseSceneNodeAnimator::CollisionPoint::get()
{
	return gcnew Vector3Df(m_CollisionResponseSceneNodeAnimator->getCollisionPoint());
}

Vector3Df^ CollisionResponseSceneNodeAnimator::CollisionResultPosition::get()
{
	return gcnew Vector3Df(m_CollisionResponseSceneNodeAnimator->getCollisionResultPosition());
}

Triangle3Df^ CollisionResponseSceneNodeAnimator::CollisionTriangle::get()
{
	return gcnew Triangle3Df(m_CollisionResponseSceneNodeAnimator->getCollisionTriangle());
}

Vector3Df^ CollisionResponseSceneNodeAnimator::EllipsoidRadius::get()
{
	return gcnew Vector3Df(m_CollisionResponseSceneNodeAnimator->getEllipsoidRadius());
}

void CollisionResponseSceneNodeAnimator::EllipsoidRadius::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_CollisionResponseSceneNodeAnimator->setEllipsoidRadius(*value->m_NativeValue);
}

Vector3Df^ CollisionResponseSceneNodeAnimator::EllipsoidTranslation::get()
{
	return gcnew Vector3Df(m_CollisionResponseSceneNodeAnimator->getEllipsoidTranslation());
}

void CollisionResponseSceneNodeAnimator::EllipsoidTranslation::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_CollisionResponseSceneNodeAnimator->setEllipsoidTranslation(*value->m_NativeValue);
}

bool CollisionResponseSceneNodeAnimator::Falling::get()
{
	return m_CollisionResponseSceneNodeAnimator->isFalling();
}

Vector3Df^ CollisionResponseSceneNodeAnimator::Gravity::get()
{
	return gcnew Vector3Df(m_CollisionResponseSceneNodeAnimator->getGravity());
}

void CollisionResponseSceneNodeAnimator::Gravity::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_CollisionResponseSceneNodeAnimator->setGravity(*value->m_NativeValue);
}

SceneNode^ CollisionResponseSceneNodeAnimator::TargetNode::get()
{
	scene::ISceneNode* n = m_CollisionResponseSceneNodeAnimator->getTargetNode();
	return SceneNode::Wrap(n);
}

void CollisionResponseSceneNodeAnimator::TargetNode::set(SceneNode^ value)
{
	m_CollisionResponseSceneNodeAnimator->setTargetNode(LIME_SAFEREF(value, m_SceneNode));
}

TriangleSelector^ CollisionResponseSceneNodeAnimator::World::get()
{
	scene::ITriangleSelector* s = m_CollisionResponseSceneNodeAnimator->getWorld();
	return TriangleSelector::Wrap(s);
}

void CollisionResponseSceneNodeAnimator::World::set(TriangleSelector^ value)
{
	m_CollisionResponseSceneNodeAnimator->setWorld(LIME_SAFEREF(value, m_TriangleSelector));
}

} // end namespace Scene
} // end namespace IrrlichtLime