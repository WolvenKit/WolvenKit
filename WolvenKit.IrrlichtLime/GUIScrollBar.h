#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

public ref class GUIScrollBar : GUIElement
{
public:

	property int LargeStep { int get(); void set(int value); }
	property int MaxValue { int get(); void set(int value); }
	property int MinValue { int get(); void set(int value); }
	property int Position { int get(); void set(int value); }
	property int SmallStep { int get(); void set(int value); }

internal:

	static GUIScrollBar^ Wrap(gui::IGUIScrollBar* ref);
	GUIScrollBar(gui::IGUIScrollBar* ref);

	gui::IGUIScrollBar* m_GUIScrollBar;
};

} // end namespace GUI
} // end namespace IrrlichtLime