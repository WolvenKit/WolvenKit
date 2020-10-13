#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

public ref class OSOperator : ReferenceCounted
{
public:

	property String^ ClipboardText { String^ get(); void set(String^ value); }
	property String^ OSVersion { String^ get(); }
	property int ProcessorSpeedMHz { int get(); }
	property int MemoryFreeKb { int get(); }
	property int MemoryTotalKb { int get(); }

	virtual String^ ToString() override;

internal:

	static OSOperator^ Wrap(irr::IOSOperator* ref);
	OSOperator(irr::IOSOperator* ref);

	irr::IOSOperator* m_OSOperator;
};

} // end namespace IrrlichtLime