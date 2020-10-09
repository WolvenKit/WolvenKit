#include "stdafx.h"
#include "AnimatedMeshSceneNode.h"
#include "ParticleAnimatedMeshSceneNodeEmitter.h"
#include "ParticleEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleAnimatedMeshSceneNodeEmitter^ ParticleAnimatedMeshSceneNodeEmitter::Wrap(scene::IParticleAnimatedMeshSceneNodeEmitter* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ParticleAnimatedMeshSceneNodeEmitter(ref);
}

ParticleAnimatedMeshSceneNodeEmitter::ParticleAnimatedMeshSceneNodeEmitter(scene::IParticleAnimatedMeshSceneNodeEmitter* ref)
	: ParticleEmitter(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleAnimatedMeshSceneNodeEmitter = ref;
}

bool ParticleAnimatedMeshSceneNodeEmitter::EveryMeshVertex::get()
{
	return m_ParticleAnimatedMeshSceneNodeEmitter->getEveryMeshVertex();
}

void ParticleAnimatedMeshSceneNodeEmitter::EveryMeshVertex::set(bool value)
{
	m_ParticleAnimatedMeshSceneNodeEmitter->setEveryMeshVertex(value);
}

float ParticleAnimatedMeshSceneNodeEmitter::NormalDirectionModifier::get()
{
	return m_ParticleAnimatedMeshSceneNodeEmitter->getNormalDirectionModifier();
}

void ParticleAnimatedMeshSceneNodeEmitter::NormalDirectionModifier::set(float value)
{
	m_ParticleAnimatedMeshSceneNodeEmitter->setNormalDirectionModifier(value);
}

AnimatedMeshSceneNode^ ParticleAnimatedMeshSceneNodeEmitter::ParticleNode::get()
{
	scene::IAnimatedMeshSceneNode* n = (scene::IAnimatedMeshSceneNode*)m_ParticleAnimatedMeshSceneNodeEmitter->getAnimatedMeshSceneNode(); // !!! cast to non-const pointer
	return AnimatedMeshSceneNode::Wrap(n);
}

void ParticleAnimatedMeshSceneNodeEmitter::ParticleNode::set(AnimatedMeshSceneNode^ value)
{
	m_ParticleAnimatedMeshSceneNodeEmitter->setAnimatedMeshSceneNode(LIME_SAFEREF(value, m_AnimatedMeshSceneNode));
}

bool ParticleAnimatedMeshSceneNodeEmitter::UseNormalDirection::get()
{
	return m_ParticleAnimatedMeshSceneNodeEmitter->isUsingNormalDirection();
}

void ParticleAnimatedMeshSceneNodeEmitter::UseNormalDirection::set(bool value)
{
	m_ParticleAnimatedMeshSceneNodeEmitter->setUseNormalDirection(value);
}

} // end namespace Scene
} // end namespace IrrlichtLime