#pragma once

#include "stdafx.h"
#include "ParticleEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class ParticleRingEmitter : ParticleEmitter
{
public:

	property Vector3Df^ Center { Vector3Df^ get(); void set(Vector3Df^ value); }
	property float Radius { float get(); void set(float value); }
	property float Thickness { float get(); void set(float value); }

internal:

	static ParticleRingEmitter^ Wrap(scene::IParticleRingEmitter* ref);
	ParticleRingEmitter(scene::IParticleRingEmitter* ref);

	scene::IParticleRingEmitter* m_ParticleRingEmitter;
};

} // end namespace Scene
} // end namespace IrrlichtLime