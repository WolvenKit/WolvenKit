#pragma once

#include "stdafx.h"
#include "ParticleEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ref class Mesh;

public ref class ParticleMeshEmitter : ParticleEmitter
{
public:

	property bool EveryMeshVertex { bool get(); void set(bool value); }
	property Mesh^ ParticleMesh { Mesh^ get(); void set(Mesh^ value); }
	property float NormalDirectionModifier { float get(); void set(float value); }
	property bool UseNormalDirection { bool get(); void set(bool value); }

internal:

	static ParticleMeshEmitter^ Wrap(scene::IParticleMeshEmitter* ref);
	ParticleMeshEmitter(scene::IParticleMeshEmitter* ref);

	scene::IParticleMeshEmitter* m_ParticleMeshEmitter;
};

} // end namespace Scene
} // end namespace IrrlichtLime