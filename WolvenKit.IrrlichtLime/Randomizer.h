#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

public ref class Randomizer : ReferenceCounted
{
public:

	float GetFloat();
	int GetInt();

	void Reset(int value);
	void Reset();

	property int MaxRandomInt { int get(); }

internal:

	static Randomizer^ Wrap(irr::IRandomizer* ref);
	Randomizer(irr::IRandomizer* ref);

	irr::IRandomizer* m_Randomizer;
};

} // end namespace IrrlichtLime