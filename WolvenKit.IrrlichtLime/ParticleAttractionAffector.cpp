#include "stdafx.h"
#include "ParticleAffector.h"
#include "ParticleAttractionAffector.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleAttractionAffector^ ParticleAttractionAffector::Wrap(scene::IParticleAttractionAffector* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ParticleAttractionAffector(ref);
}

ParticleAttractionAffector::ParticleAttractionAffector(scene::IParticleAttractionAffector* ref)
	: ParticleAffector(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleAttractionAffector = ref;
}

bool ParticleAttractionAffector::AffectX::get()
{
	return m_ParticleAttractionAffector->getAffectX();
}

void ParticleAttractionAffector::AffectX::set(bool value)
{
	m_ParticleAttractionAffector->setAffectX(value);
}

bool ParticleAttractionAffector::AffectY::get()
{
	return m_ParticleAttractionAffector->getAffectY();
}

void ParticleAttractionAffector::AffectY::set(bool value)
{
	m_ParticleAttractionAffector->setAffectY(value);
}

bool ParticleAttractionAffector::AffectZ::get()
{
	return m_ParticleAttractionAffector->getAffectZ();
}

void ParticleAttractionAffector::AffectZ::set(bool value)
{
	m_ParticleAttractionAffector->setAffectZ(value);
}

bool ParticleAttractionAffector::Attract::get()
{
	return m_ParticleAttractionAffector->getAttract();
}

void ParticleAttractionAffector::Attract::set(bool value)
{
	m_ParticleAttractionAffector->setAttract(value);
}

Vector3Df^ ParticleAttractionAffector::Point::get()
{
	return gcnew Vector3Df(m_ParticleAttractionAffector->getPoint());
}

void ParticleAttractionAffector::Point::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleAttractionAffector->setPoint(*value->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime