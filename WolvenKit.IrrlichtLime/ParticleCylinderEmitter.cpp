#include "stdafx.h"
#include "ParticleCylinderEmitter.h"
#include "ParticleEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleCylinderEmitter^ ParticleCylinderEmitter::Wrap(scene::IParticleCylinderEmitter* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ParticleCylinderEmitter(ref);
}

ParticleCylinderEmitter::ParticleCylinderEmitter(scene::IParticleCylinderEmitter* ref)
	: ParticleEmitter(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleCylinderEmitter = ref;
}

Vector3Df^ ParticleCylinderEmitter::Center::get()
{
	return gcnew Vector3Df(m_ParticleCylinderEmitter->getCenter());
}

void ParticleCylinderEmitter::Center::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleCylinderEmitter->setCenter(*value->m_NativeValue);
}

float ParticleCylinderEmitter::Length::get()
{
	return m_ParticleCylinderEmitter->getLength();
}

void ParticleCylinderEmitter::Length::set(float value)
{
	m_ParticleCylinderEmitter->setLength(value);
}

Vector3Df^ ParticleCylinderEmitter::Normal::get()
{
	return gcnew Vector3Df(m_ParticleCylinderEmitter->getNormal());
}

void ParticleCylinderEmitter::Normal::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleCylinderEmitter->setNormal(*value->m_NativeValue);
}

bool ParticleCylinderEmitter::OutlineOnly::get()
{
	return m_ParticleCylinderEmitter->getOutlineOnly();
}

void ParticleCylinderEmitter::OutlineOnly::set(bool value)
{
	m_ParticleCylinderEmitter->setOutlineOnly(value);
}

float ParticleCylinderEmitter::Radius::get()
{
	return m_ParticleCylinderEmitter->getRadius();
}

void ParticleCylinderEmitter::Radius::set(float value)
{
	m_ParticleCylinderEmitter->setRadius(value);
}

} // end namespace Scene
} // end namespace IrrlichtLime