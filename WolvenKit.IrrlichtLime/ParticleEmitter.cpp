#include "stdafx.h"
#include "AttributeExchangingObject.h"
#include "Particle.h"
#include "ParticleAnimatedMeshSceneNodeEmitter.h"
#include "ParticleBoxEmitter.h"
#include "ParticleCylinderEmitter.h"
#include "ParticleEmitter.h"
#include "ParticleMeshEmitter.h"
#include "ParticleRingEmitter.h"
#include "ParticleSphereEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleEmitter^ ParticleEmitter::Wrap(scene::IParticleEmitter* ref)
{
	if (ref == nullptr)
		return nullptr;

	switch (ref->getType())
	{
	case scene::EPET_ANIMATED_MESH:
		return gcnew ParticleAnimatedMeshSceneNodeEmitter((scene::IParticleAnimatedMeshSceneNodeEmitter*)ref);
	case scene::EPET_BOX:
		return gcnew ParticleBoxEmitter((scene::IParticleBoxEmitter*)ref);
	case scene::EPET_CYLINDER:
		return gcnew ParticleCylinderEmitter((scene::IParticleCylinderEmitter*)ref);
	case scene::EPET_MESH:
		return gcnew ParticleMeshEmitter((scene::IParticleMeshEmitter*)ref);
	case scene::EPET_RING:
		return gcnew ParticleRingEmitter((scene::IParticleRingEmitter*)ref);
	case scene::EPET_SPHERE:
		return gcnew ParticleSphereEmitter((scene::IParticleSphereEmitter*)ref);

	case scene::EPET_POINT:
	default:
		return gcnew ParticleEmitter(ref);
	}
}

ParticleEmitter::ParticleEmitter(scene::IParticleEmitter* ref)
	: IO::AttributeExchangingObject(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleEmitter = ref;
}

List<Particle^>^ ParticleEmitter::Emitt(unsigned int now, unsigned int timeSinceLastCall)
{
	List<Particle^>^ l = gcnew List<Particle^>();

	scene::SParticle* a;
	int c = m_ParticleEmitter->emitt(now, timeSinceLastCall, a);

	for (int i = 0; i < c; i++)
		l->Add(gcnew Particle(&(a[i])));

	return l;
}

Vector3Df^ ParticleEmitter::Direction::get()
{
	return gcnew Vector3Df(m_ParticleEmitter->getDirection());
}

void ParticleEmitter::Direction::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleEmitter->setDirection(*value->m_NativeValue);
}

int ParticleEmitter::MaxAngleDegrees::get()
{
	return m_ParticleEmitter->getMaxAngleDegrees();
}

void ParticleEmitter::MaxAngleDegrees::set(int value)
{
	m_ParticleEmitter->setMaxAngleDegrees(value);
}

int ParticleEmitter::MaxLifeTime::get()
{
	return m_ParticleEmitter->getMaxLifeTime();
}

void ParticleEmitter::MaxLifeTime::set(int value)
{
	LIME_ASSERT(value >= 0);
	m_ParticleEmitter->setMaxLifeTime(value);
}

int ParticleEmitter::MaxParticlesPerSecond::get()
{
	return m_ParticleEmitter->getMaxParticlesPerSecond();
}

void ParticleEmitter::MaxParticlesPerSecond::set(int value)
{
	LIME_ASSERT(value >= 0);
	m_ParticleEmitter->setMaxParticlesPerSecond(value);
}

Video::Color^ ParticleEmitter::MaxStartColor::get()
{
	return gcnew Video::Color(m_ParticleEmitter->getMaxStartColor());
}

void ParticleEmitter::MaxStartColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleEmitter->setMaxStartColor(*value->m_NativeValue);
}

Dimension2Df^ ParticleEmitter::MaxStartSize::get()
{
	return gcnew Dimension2Df(m_ParticleEmitter->getMaxStartSize());
}

void ParticleEmitter::MaxStartSize::set(Dimension2Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleEmitter->setMaxStartSize(*value->m_NativeValue);
}

int ParticleEmitter::MinLifeTime::get()
{
	return m_ParticleEmitter->getMinLifeTime();
}

void ParticleEmitter::MinLifeTime::set(int value)
{
	LIME_ASSERT(value >= 0);
	m_ParticleEmitter->setMinLifeTime(value);
}

int ParticleEmitter::MinParticlesPerSecond::get()
{
	return m_ParticleEmitter->getMinParticlesPerSecond();
}

void ParticleEmitter::MinParticlesPerSecond::set(int value)
{
	LIME_ASSERT(value >= 0);
	m_ParticleEmitter->setMinParticlesPerSecond(value);
}

Video::Color^ ParticleEmitter::MinStartColor::get()
{
	return gcnew Video::Color(m_ParticleEmitter->getMinStartColor());
}

void ParticleEmitter::MinStartColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleEmitter->setMinStartColor(*value->m_NativeValue);
}

Dimension2Df^ ParticleEmitter::MinStartSize::get()
{
	return gcnew Dimension2Df(m_ParticleEmitter->getMinStartSize());
}

void ParticleEmitter::MinStartSize::set(Dimension2Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleEmitter->setMinStartSize(*value->m_NativeValue);
}

ParticleEmitterType ParticleEmitter::Type::get()
{
	return (ParticleEmitterType)m_ParticleEmitter->getType();
}

String^ ParticleEmitter::ToString()
{
	return String::Format("ParticleEmitter: Type={0}", Type);
}

} // end namespace Scene
} // end namespace IrrlichtLime