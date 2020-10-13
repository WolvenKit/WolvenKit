#pragma once

#include "stdafx.h"
#include "ParticleAffector.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class ParticleGravityAffector : ParticleAffector
{
public:

	property Vector3Df^ Gravity { Vector3Df^ get(); void set(Vector3Df^ value); }
	property float TimeForceLost { float get(); void set(float value); }

internal:

	static ParticleGravityAffector^ Wrap(scene::IParticleGravityAffector* ref);
	ParticleGravityAffector(scene::IParticleGravityAffector* ref);

	scene::IParticleGravityAffector* m_ParticleGravityAffector;
};

} // end namespace Scene
} // end namespace IrrlichtLime