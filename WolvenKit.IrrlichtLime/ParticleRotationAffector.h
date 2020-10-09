#pragma once

#include "stdafx.h"
#include "ParticleAffector.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class ParticleRotationAffector : ParticleAffector
{
public:

	property Vector3Df^ Pivot { Vector3Df^ get(); void set(Vector3Df^ value); }
	property Vector3Df^ Speed { Vector3Df^ get(); void set(Vector3Df^ value); }

internal:

	static ParticleRotationAffector^ Wrap(scene::IParticleRotationAffector* ref);
	ParticleRotationAffector(scene::IParticleRotationAffector* ref);

	scene::IParticleRotationAffector* m_ParticleRotationAffector;
};

} // end namespace Scene
} // end namespace IrrlichtLime