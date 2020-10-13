#pragma once

#include "stdafx.h"
#include "AttributeExchangingObject.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ref class Particle;

public ref class ParticleAffector : IO::AttributeExchangingObject
{
public:

	void Affect(unsigned int now, List<Particle^>^ particleList);

	property bool Enabled { bool get(); void set(bool value); }
	property ParticleAffectorType Type { ParticleAffectorType get(); }

	virtual String^ ToString() override;

internal:

	static ParticleAffector^ Wrap(scene::IParticleAffector* ref);
	ParticleAffector(scene::IParticleAffector* ref);

	scene::IParticleAffector* m_ParticleAffector;
};

} // end namespace Scene
} // end namespace IrrlichtLime