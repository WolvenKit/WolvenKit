#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

public ref class GUITab : GUIElement
{
public:

	property Video::Color^ BackgroundColor { Video::Color^ get(); void set(Video::Color^ value); }
	property bool DrawBackground { bool get(); void set(bool value); }
	property int Index { int get(); }
	property Video::Color^ TextColor { Video::Color^ get(); void set(Video::Color^ value); }

internal:

	static GUITab^ Wrap(gui::IGUITab* ref);
	GUITab(gui::IGUITab* ref);

	gui::IGUITab* m_GUITab;
};

} // end namespace GUI
} // end namespace IrrlichtLime