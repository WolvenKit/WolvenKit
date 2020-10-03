#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

ref class GUITab;

public ref class GUITabControl : GUIElement
{
public:

	GUITab^ AddTab(String^ caption, int id);
	GUITab^ AddTab(String^ caption);

	void Clear();

	int GetTabAt(int xpos, int ypos);

	GUITab^ InsertTab(int indexAt, String^ caption, int id);
	GUITab^ InsertTab(int indexAt, String^ caption);

	void RemoveTab(int index);

	property GUITab^ ActiveTab { GUITab^ get(); void set(GUITab^ value); }
	property int ActiveTabIndex { int get(); void set(int value); }
	property int TabCount { int get(); }
	property int TabExtraWidth { int get(); void set(int value); }
	property int TabHeight { int get(); void set(int value); }
	property int TabMaxWidth { int get(); void set(int value); }
	property GUIAlignment TabVerticalAlignment { GUIAlignment get(); void set(GUIAlignment value); }

internal:

	static GUITabControl^ Wrap(gui::IGUITabControl* ref);
	GUITabControl(gui::IGUITabControl* ref);

	gui::IGUITabControl* m_GUITabControl;
};

} // end namespace GUI
} // end namespace IrrlichtLime