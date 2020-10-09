#include "stdafx.h"
#include "ParticleBoxEmitter.h"
#include "ParticleEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ParticleBoxEmitter^ ParticleBoxEmitter::Wrap(scene::IParticleBoxEmitter* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ParticleBoxEmitter(ref);
}

ParticleBoxEmitter::ParticleBoxEmitter(scene::IParticleBoxEmitter* ref)
	: ParticleEmitter(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ParticleBoxEmitter = ref;
}

AABBox^ ParticleBoxEmitter::Box::get()
{
	return gcnew AABBox(m_ParticleBoxEmitter->getBox());
}

void ParticleBoxEmitter::Box::set(AABBox^ value)
{
	LIME_ASSERT(value != nullptr);
	m_ParticleBoxEmitter->setBox(*value->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime