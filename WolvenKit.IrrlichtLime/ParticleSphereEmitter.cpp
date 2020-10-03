#include "stdafx.h"
#include "ParticleEmitter.h"
#include "ParticleSphereEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleSphereEmitter^ ParticleSphereEmitter::Wrap(scene::IParticleSphereEmitter* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ParticleSphereEmitter(ref);
}

ParticleSphereEmitter::ParticleSphereEmitter(scene::IParticleSphereEmitter* ref)
	: ParticleEmitter(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleSphereEmitter = ref;
}

Vector3Df^ ParticleSphereEmitter::Center::get()
{
	return gcnew Vector3Df(m_ParticleSphereEmitter->getCenter());
}

void ParticleSphereEmitter::Center::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleSphereEmitter->setCenter(*value->m_NativeValue);
}

float ParticleSphereEmitter::Radius::get()
{
	return m_ParticleSphereEmitter->getRadius();
}

void ParticleSphereEmitter::Radius::set(float value)
{
	m_ParticleSphereEmitter->setRadius(value);
}

} // end namespace Scene
} // end namespace IrrlichtLime