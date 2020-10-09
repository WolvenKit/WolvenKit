#include "stdafx.h"
#include "ParticleAffector.h"
#include "ParticleFadeOutAffector.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleFadeOutAffector^ ParticleFadeOutAffector::Wrap(scene::IParticleFadeOutAffector* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ParticleFadeOutAffector(ref);
}

ParticleFadeOutAffector::ParticleFadeOutAffector(scene::IParticleFadeOutAffector* ref)
	: ParticleAffector(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleFadeOutAffector = ref;
}

int ParticleFadeOutAffector::FadeOutTime::get()
{
	return m_ParticleFadeOutAffector->getFadeOutTime();
}

void ParticleFadeOutAffector::FadeOutTime::set(int value)
{
	LIME_ASSERT(value >= 0);
	m_ParticleFadeOutAffector->setFadeOutTime(value);
}

Video::Color^ ParticleFadeOutAffector::TargetColor::get()
{
	return gcnew Video::Color(m_ParticleFadeOutAffector->getTargetColor());
}

void ParticleFadeOutAffector::TargetColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleFadeOutAffector->setTargetColor(*value->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime