#pragma once

#include "stdafx.h"
#include "ParticleEmitter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ref class AnimatedMeshSceneNode;

public ref class ParticleAnimatedMeshSceneNodeEmitter : ParticleEmitter
{
public:

	property bool EveryMeshVertex { bool get(); void set(bool value); }
	property float NormalDirectionModifier { float get(); void set(float value); }
	property AnimatedMeshSceneNode^ ParticleNode { AnimatedMeshSceneNode^ get(); void set(AnimatedMeshSceneNode^ value); }
	property bool UseNormalDirection { bool get(); void set(bool value); }

internal:

	static ParticleAnimatedMeshSceneNodeEmitter^ Wrap(scene::IParticleAnimatedMeshSceneNodeEmitter* ref);
	ParticleAnimatedMeshSceneNodeEmitter(scene::IParticleAnimatedMeshSceneNodeEmitter* ref);

	scene::IParticleAnimatedMeshSceneNodeEmitter* m_ParticleAnimatedMeshSceneNodeEmitter;
};

} // end namespace Scene
} // end namespace IrrlichtLime