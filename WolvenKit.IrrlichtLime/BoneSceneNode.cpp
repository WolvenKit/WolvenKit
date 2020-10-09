#include "stdafx.h"
#include "BoneSceneNode.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

BoneSceneNode^ BoneSceneNode::Wrap(scene::IBoneSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew BoneSceneNode(ref);
}

BoneSceneNode::BoneSceneNode(scene::IBoneSceneNode* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_BoneSceneNode = ref;
}

void BoneSceneNode::UpdateAbsolutePositionOfAllChildren()
{
	m_BoneSceneNode->updateAbsolutePositionOfAllChildren();
}

BoneAnimationMode BoneSceneNode::AnimationMode::get()
{
	return (BoneAnimationMode)m_BoneSceneNode->getAnimationMode();
}

void BoneSceneNode::AnimationMode::set(BoneAnimationMode value)
{
	m_BoneSceneNode->setAnimationMode((scene::E_BONE_ANIMATION_MODE)value);
}

int BoneSceneNode::BoneIndex::get()
{
	return m_BoneSceneNode->getBoneIndex();
}

BoneSkinningSpace BoneSceneNode::SkinningSpace::get()
{
	return (BoneSkinningSpace)m_BoneSceneNode->getSkinningSpace();
}

void BoneSceneNode::SkinningSpace::set(BoneSkinningSpace value)
{
	m_BoneSceneNode->setSkinningSpace((scene::E_BONE_SKINNING_SPACE)value);
}

int BoneSceneNode::PositionHint::get()
{
	return m_BoneSceneNode->positionHint;
}

void BoneSceneNode::PositionHint::set(int value)
{
	m_BoneSceneNode->positionHint = value;
}

int BoneSceneNode::RotationHint::get()
{
	return m_BoneSceneNode->rotationHint;
}

void BoneSceneNode::RotationHint::set(int value)
{
	m_BoneSceneNode->rotationHint = value;
}

int BoneSceneNode::ScaleHint::get()
{
	return m_BoneSceneNode->scaleHint;
}

void BoneSceneNode::ScaleHint::set(int value)
{
	m_BoneSceneNode->scaleHint = value;
}

} // end namespace Scene
} // end namespace IrrlichtLime