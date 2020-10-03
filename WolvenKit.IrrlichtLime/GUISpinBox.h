#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

ref class GUIEditBox;

public ref class GUISpinBox : GUIElement
{
public:

	void SetDecimalPlaces(int places);
	void SetRange(float min, float max);

	property GUIEditBox^ EditBox { GUIEditBox^ get(); }
	property float Maximum { float get(); void set(float value); }
	property float Minimum { float get(); void set(float value); }
	property float StepSize { float get(); void set(float value); }
	property GUISpinBoxValidation ValidateOn { GUISpinBoxValidation get(); void set(GUISpinBoxValidation value); }
	property float Value { float get(); void set(float value); }

internal:

	static GUISpinBox^ Wrap(gui::IGUISpinBox* ref);
	GUISpinBox(gui::IGUISpinBox* ref);

	gui::IGUISpinBox* m_GUISpinBox;
};

} // end namespace GUI
} // end namespace IrrlichtLime