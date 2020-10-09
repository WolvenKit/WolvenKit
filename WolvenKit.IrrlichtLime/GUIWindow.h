#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

ref class GUIButton;

public ref class GUIWindow : GUIElement
{
public:

	property Recti^ ClientRect { Recti^ get(); }
	property GUIButton^ CloseButton { GUIButton^ get(); }
	property bool Draggable { bool get(); void set(bool value); }
	property bool DrawBackground { bool get(); void set(bool value); }
	property bool DrawTitleBar { bool get(); void set(bool value); }
	property GUIButton^ MaximizeButton { GUIButton^ get(); }
	property GUIButton^ MinimizeButton { GUIButton^ get(); }

internal:

	static GUIWindow^ Wrap(gui::IGUIWindow* ref);
	GUIWindow(gui::IGUIWindow* ref);

	gui::IGUIWindow* m_GUIWindow;
};

} // end namespace GUI
} // end namespace IrrlichtLime