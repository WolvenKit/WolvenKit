#pragma once

#include "stdafx.h"
#include "ParticleEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class ParticleCylinderEmitter : ParticleEmitter
{
public:

	property Vector3Df^ Center { Vector3Df^ get(); void set(Vector3Df^ value); }
	property float Length { float get(); void set(float value); }
	property Vector3Df^ Normal { Vector3Df^ get(); void set(Vector3Df^ value); }
	property bool OutlineOnly { bool get(); void set(bool value); }
	property float Radius { float get(); void set(float value); }

internal:

	static ParticleCylinderEmitter^ Wrap(scene::IParticleCylinderEmitter* ref);
	ParticleCylinderEmitter(scene::IParticleCylinderEmitter* ref);

	scene::IParticleCylinderEmitter* m_ParticleCylinderEmitter;
};

} // end namespace Scene
} // end namespace IrrlichtLime