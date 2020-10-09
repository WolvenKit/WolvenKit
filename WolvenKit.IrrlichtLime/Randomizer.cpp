#include "stdafx.h"
#include "Randomizer.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

Randomizer^ Randomizer::Wrap(irr::IRandomizer* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew Randomizer(ref);
}

Randomizer::Randomizer(irr::IRandomizer* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_Randomizer = ref;
}

float Randomizer::GetFloat()
{
	return m_Randomizer->frand();
}

int Randomizer::GetInt()
{
	return m_Randomizer->rand();
}

void Randomizer::Reset(int value)
{
	m_Randomizer->reset(value);
}

void Randomizer::Reset()
{
	m_Randomizer->reset();
}

int Randomizer::MaxRandomInt::get()
{
	return m_Randomizer->randMax();
}

} // end namespace IrrlichtLime