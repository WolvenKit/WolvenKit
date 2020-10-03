#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

public ref class GUICheckBox : GUIElement
{
public:

	property bool Checked { bool get(); void set(bool value); }
	property bool DrawBackground { bool get(); void set(bool value); }
	property bool DrawBorder { bool get(); void set(bool value); }

internal:

	static GUICheckBox^ Wrap(gui::IGUICheckBox* ref);
	GUICheckBox(gui::IGUICheckBox* ref);

	gui::IGUICheckBox* m_GUICheckBox;
};

} // end namespace GUI
} // end namespace IrrlichtLime