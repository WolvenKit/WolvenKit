#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

public ref class GUIComboBox : GUIElement
{
public:

	int AddItem(String^ text, int data);
	int AddItem(String^ text);

	void Clear();

	int GetIndexForItemData(int data);
	String^ GetItem(int index);
	int GetItemData(int index);

	void RemoveItem(int index);

	void SetTextAlignment(GUIAlignment horizontal, GUIAlignment vertical);

	property int ItemCount { int get(); }
	property int MaxSelectionRows { int get(); void set(int value); }
	property int SelectedIndex { int get(); void set(int value); }

internal:

	static GUIComboBox^ Wrap(gui::IGUIComboBox* ref);
	GUIComboBox(gui::IGUIComboBox* ref);

	gui::IGUIComboBox* m_GUIComboBox;
};

} // end namespace GUI
} // end namespace IrrlichtLime