#include "stdafx.h"
#include "ParticleAffector.h"
#include "ParticleGravityAffector.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleGravityAffector^ ParticleGravityAffector::Wrap(scene::IParticleGravityAffector* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ParticleGravityAffector(ref);
}

ParticleGravityAffector::ParticleGravityAffector(scene::IParticleGravityAffector* ref)
	: ParticleAffector(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleGravityAffector = ref;
}

Vector3Df^ ParticleGravityAffector::Gravity::get()
{
	return gcnew Vector3Df(m_ParticleGravityAffector->getGravity());
}

void ParticleGravityAffector::Gravity::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleGravityAffector->setGravity(*value->m_NativeValue);
}

float ParticleGravityAffector::TimeForceLost::get()
{
	return m_ParticleGravityAffector->getTimeForceLost();
}

void ParticleGravityAffector::TimeForceLost::set(float value)
{
	LIME_ASSERT(value >= 0.0f);
	m_ParticleGravityAffector->setTimeForceLost(value);
}

} // end namespace Scene
} // end namespace IrrlichtLime