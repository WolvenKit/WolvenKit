#pragma once

#include "stdafx.h"
#include "AttributeExchangingObject.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ref class Particle;

public ref class ParticleEmitter : IO::AttributeExchangingObject
{
public:

	List<Particle^>^ Emitt(unsigned int now, unsigned int timeSinceLastCall);

	property Vector3Df^ Direction { Vector3Df^ get(); void set(Vector3Df^ value); }
	property int MaxAngleDegrees { int get(); void set(int value); }
	property int MaxLifeTime { int get(); void set(int value); }
	property int MaxParticlesPerSecond { int get(); void set(int value); }
	property Video::Color^ MaxStartColor { Video::Color^ get(); void set(Video::Color^ value); }
	property Dimension2Df^ MaxStartSize { Dimension2Df^ get(); void set(Dimension2Df^ value); }
	property int MinLifeTime { int get(); void set(int value); }
	property int MinParticlesPerSecond { int get(); void set(int value); }
	property Video::Color^ MinStartColor { Video::Color^ get(); void set(Video::Color^ value); }
	property Dimension2Df^ MinStartSize { Dimension2Df^ get(); void set(Dimension2Df^ value); }
	property ParticleEmitterType Type { ParticleEmitterType get(); }

	virtual String^ ToString() override;

internal:

	static ParticleEmitter^ Wrap(scene::IParticleEmitter* ref);
	ParticleEmitter(scene::IParticleEmitter* ref);

	scene::IParticleEmitter* m_ParticleEmitter;
};

} // end namespace Scene
} // end namespace IrrlichtLime