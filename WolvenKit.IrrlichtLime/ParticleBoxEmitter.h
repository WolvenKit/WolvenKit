#pragma once

#include "stdafx.h"
#include "ParticleEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class ParticleBoxEmitter : ParticleEmitter
{
public:

	property AABBox^ Box { AABBox^ get(); void set(AABBox^ value); }

internal:

	static ParticleBoxEmitter^ Wrap(scene::IParticleBoxEmitter* ref);
	ParticleBoxEmitter(scene::IParticleBoxEmitter* ref);

	scene::IParticleBoxEmitter* m_ParticleBoxEmitter;
};

} // end namespace Scene
} // end namespace IrrlichtLime