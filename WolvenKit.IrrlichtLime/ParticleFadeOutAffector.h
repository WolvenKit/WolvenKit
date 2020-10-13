#pragma once

#include "stdafx.h"
#include "ParticleAffector.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class ParticleFadeOutAffector : ParticleAffector
{
public:

	property int FadeOutTime { int get(); void set(int value); }
	property Video::Color^ TargetColor { Video::Color^ get(); void set(Video::Color^ value); }

internal:

	static ParticleFadeOutAffector^ Wrap(scene::IParticleFadeOutAffector* ref);
	ParticleFadeOutAffector(scene::IParticleFadeOutAffector* ref);

	scene::IParticleFadeOutAffector* m_ParticleFadeOutAffector;
};

} // end namespace Scene
} // end namespace IrrlichtLime