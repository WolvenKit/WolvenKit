#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

ref class GUIFont;

public ref class GUIEditBox : GUIElement
{
public:

	void SetPasswordChar(Char x);
	void SetTextAlignment(GUIAlignment horizontal, GUIAlignment vertical);

	property GUIFont^ ActiveFont { GUIFont^ get(); }
	property bool AutoScroll { bool get(); void set(bool value); }
	property int CursorBlinkTime { int get(); void set(int value); }
	property wchar_t CursorChar { wchar_t get(); void set(wchar_t value); }
	property bool DrawBackground { bool get(); void set(bool value); }
	property bool DrawBorder { bool get(); void set(bool value); }
	property int MaxLength { int get(); void set(int value); }
	property bool MultiLine { bool get(); void set(bool value); }
	property Video::Color^ OverrideColor { Video::Color^ get(); void set(Video::Color^ value); }
	property bool OverrideColorEnabled { bool get(); void set(bool value); }
	property GUIFont^ OverrideFont { GUIFont^ get(); void set(GUIFont^ value); }
	property bool PasswordBox { bool get(); void set(bool value); }
	property Dimension2Di^ TextDimension { Dimension2Di^ get(); }
	property bool WordWrap { bool get(); void set(bool value); }

internal:

	static GUIEditBox^ Wrap(gui::IGUIEditBox* ref);
	GUIEditBox(gui::IGUIEditBox* ref);

	gui::IGUIEditBox* m_GUIEditBox;
};

} // end namespace GUI
} // end namespace IrrlichtLime