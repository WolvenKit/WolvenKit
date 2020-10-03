#include "stdafx.h"
#include "ParticleAffector.h"
#include "ParticleRotationAffector.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleRotationAffector^ ParticleRotationAffector::Wrap(scene::IParticleRotationAffector* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ParticleRotationAffector(ref);
}

ParticleRotationAffector::ParticleRotationAffector(scene::IParticleRotationAffector* ref)
	: ParticleAffector(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleRotationAffector = ref;
}

Vector3Df^ ParticleRotationAffector::Pivot::get()
{
	return gcnew Vector3Df(m_ParticleRotationAffector->getPivotPoint());
}

void ParticleRotationAffector::Pivot::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleRotationAffector->setPivotPoint(*value->m_NativeValue);
}

Vector3Df^ ParticleRotationAffector::Speed::get()
{
	return gcnew Vector3Df(m_ParticleRotationAffector->getSpeed());
}

void ParticleRotationAffector::Speed::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleRotationAffector->setSpeed(*value->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime