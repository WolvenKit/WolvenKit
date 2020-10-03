#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

ref class GUIFont;

public ref class GUIStaticText : GUIElement
{
public:

	void SetTextAlignment(GUIAlignment horizontal, GUIAlignment vertical);

	property GUIFont^ ActiveFont { GUIFont^ get(); }
	property Video::Color^ BackgroundColor { Video::Color^ get(); void set(Video::Color^ value); }
	property bool DrawBackgroundEnabled { bool get(); void set(bool value); }
	property bool DrawBorderEnabled { bool get(); void set(bool value); }
	property Video::Color^ OverrideColor { Video::Color^ get(); void set(Video::Color^ value); }
	property bool OverrideColorEnabled { bool get(); void set(bool value); }
	property GUIFont^ OverrideFont { GUIFont^ get(); void set(GUIFont^ value); }
	property bool RightToLeft { bool get(); void set(bool value); }
	property int TextHeight { int get(); }
	property bool TextRestrainedInside { bool get(); void set(bool value); }
	property int TextWidth { int get(); }
	property bool WordWrap { bool get(); void set(bool value); }

internal:

	static GUIStaticText^ Wrap(gui::IGUIStaticText* ref);
	GUIStaticText(gui::IGUIStaticText* ref);

	gui::IGUIStaticText* m_GUIStaticText;
};

} // end namespace GUI
} // end namespace IrrlichtLime