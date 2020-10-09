#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

ref class GUISpriteBank;

public ref class GUIListBox : GUIElement
{
public:

	int AddItem(String^ text, int icon);
	int AddItem(String^ text);

	void ClearItemColor(int index, GUIListBoxColor colorType);
	void ClearItemColors(int index);
	void ClearItems();

	String^ GetItem(int index);
	int GetItemAt(int xpos, int ypos);
	Video::Color^ GetItemDefaultColor(GUIListBoxColor colorType);
	Video::Color^ GetItemColor(int index, GUIListBoxColor colorType);
	int GetItemIcon(int index);

	int InsertItem(int index, String^ text, int icon);
	int InsertItem(int index, String^ text);

	bool ItemColorOverrided(int index, GUIListBoxColor colorType);

	void RemoveItem(int index);

	void SetDrawBackground(bool draw);

	void SetItem(int index, String^ text, int icon);
	void SetItem(int index, String^ text);
	void SetItemColor(int index, GUIListBoxColor colorType, Video::Color^ color);
	void SetItemHeight(int height);

	void SetSpriteBank(GUISpriteBank^ bank);

	void SwapItems(int index1, int index2);

	property bool AutoScroll { bool get(); void set(bool value); }
	property int ItemCount { int get(); }
	property int SelectedIndex { int get(); void set(int value); }
	property String^ SelectedItem { String^ get(); void set(String^ value); }

internal:

	static GUIListBox^ Wrap(gui::IGUIListBox* ref);
	GUIListBox(gui::IGUIListBox* ref);

	gui::IGUIListBox* m_GUIListBox;
};

} // end namespace GUI
} // end namespace IrrlichtLime