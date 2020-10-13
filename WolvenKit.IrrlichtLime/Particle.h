#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public ref class Particle : Lime::NativeValue<scene::SParticle>
{
public:

	Particle();

	property Video::Color^ Color { Video::Color^ get(); void set(Video::Color^ value); }
	property unsigned int EndTime { unsigned int get(); void set(unsigned int value); }
	property Vector3Df^ Position { Vector3Df^ get(); void set(Vector3Df^ value); }
	property Dimension2Df^ Size { Dimension2Df^ get(); void set(Dimension2Df^ value); }
	property Video::Color^ StartColor { Video::Color^ get(); void set(Video::Color^ value); }
	property Dimension2Df^ StartSize { Dimension2Df^ get(); void set(Dimension2Df^ value); }
	property unsigned int StartTime { unsigned int get(); void set(unsigned int value); }
	property Vector3Df^ StartVector { Vector3Df^ get(); void set(Vector3Df^ value); }
	property Vector3Df^ Vector { Vector3Df^ get(); void set(Vector3Df^ value); }

	virtual String^ ToString() override;

internal:

	static Particle^ Wrap(scene::SParticle* ref);
	Particle(scene::SParticle* ref);
};

} // end namespace Scene
} // end namespace IrrlichtLime