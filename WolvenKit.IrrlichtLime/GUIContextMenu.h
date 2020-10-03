#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

public ref class GUIContextMenu : GUIElement
{
public:

	int AddItem(String^ text, int commandID, bool enabled, bool hasSubMenu, bool isChecked, bool autoChecking);
	int AddItem(String^ text, int commandID, bool enabled, bool hasSubMenu, bool isChecked);
	int AddItem(String^ text, int commandID, bool enabled, bool hasSubMenu);
	int AddItem(String^ text, int commandID, bool enabled);
	int AddItem(String^ text, int commandID);
	int AddItem(String^ text);

	void AddSeparator();

	int FindItem(int commandID, int indexStartSearch);
	int FindItem(int commandID);

	bool GetItemAutoChecking(int index);
	bool GetItemChecked(int index);
	int GetItemCommandID(int index);
	bool GetItemEnabled(int index);
	String^ GetItemText(int index);
	GUIContextMenu^ GetSubMenu(int index);

	int InsertItem(int index, String^ text, int commandID, bool enabled, bool hasSubMenu, bool isChecked, bool autoChecking);
	int InsertItem(int index, String^ text, int commandID, bool enabled, bool hasSubMenu, bool isChecked);
	int InsertItem(int index, String^ text, int commandID, bool enabled, bool hasSubMenu);
	int InsertItem(int index, String^ text, int commandID, bool enabled);
	int InsertItem(int index, String^ text, int commandID);
	int InsertItem(int index, String^ text);

	void RemoveAllItems();
	void RemoveItem(int index);

	void SetEventParent(GUIElement^ parent);

	void SetItemAutoChecking(int index, bool autoChecking);
	void SetItemChecked(int index, bool isChecked);
	void SetItemCommandID(int index, int commandID);
	void SetItemEnabled(int index, bool enabled);
	void SetItemText(int index, String^ text);

	property GUIContextMenuClose CloseHandling { GUIContextMenuClose get(); void set(GUIContextMenuClose value); }
	property int ItemCount { int get(); }
	property int SelectedCommandID { int get(); }
	property int SelectedIndex { int get(); }

internal:

	static GUIContextMenu^ Wrap(gui::IGUIContextMenu* ref);
	GUIContextMenu(gui::IGUIContextMenu* ref);

	gui::IGUIContextMenu* m_GUIContextMenu;
};

} // end namespace GUI
} // end namespace IrrlichtLime