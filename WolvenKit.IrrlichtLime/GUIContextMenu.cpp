#include "stdafx.h"
#include "GUIContextMenu.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIContextMenu^ GUIContextMenu::Wrap(gui::IGUIContextMenu* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIContextMenu(ref);
}

GUIContextMenu::GUIContextMenu(gui::IGUIContextMenu* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIContextMenu = ref;
}

int GUIContextMenu::AddItem(String^ text, int commandID, bool enabled, bool hasSubMenu, bool isChecked, bool autoChecking)
{
	return m_GUIContextMenu->addItem(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID,
		enabled,
		hasSubMenu,
		isChecked,
		autoChecking);
}

int GUIContextMenu::AddItem(String^ text, int commandID, bool enabled, bool hasSubMenu, bool isChecked)
{
	return m_GUIContextMenu->addItem(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID,
		enabled,
		hasSubMenu,
		isChecked);
}

int GUIContextMenu::AddItem(String^ text, int commandID, bool enabled, bool hasSubMenu)
{
	return m_GUIContextMenu->addItem(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID,
		enabled,
		hasSubMenu);
}

int GUIContextMenu::AddItem(String^ text, int commandID, bool enabled)
{
	return m_GUIContextMenu->addItem(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID,
		enabled);
}

int GUIContextMenu::AddItem(String^ text, int commandID)
{
	return m_GUIContextMenu->addItem(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID);
}

int GUIContextMenu::AddItem(String^ text)
{
	return m_GUIContextMenu->addItem(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));
}

void GUIContextMenu::AddSeparator()
{
	m_GUIContextMenu->addSeparator();
}

int GUIContextMenu::FindItem(int commandID, int indexStartSearch)
{
	LIME_ASSERT(indexStartSearch < ItemCount);
	return m_GUIContextMenu->findItemWithCommandId(commandID, indexStartSearch);
}

int GUIContextMenu::FindItem(int commandID)
{
	return m_GUIContextMenu->findItemWithCommandId(commandID);
}

bool GUIContextMenu::GetItemAutoChecking(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return m_GUIContextMenu->getItemAutoChecking(index);
}

bool GUIContextMenu::GetItemChecked(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return m_GUIContextMenu->isItemChecked(index);
}

int GUIContextMenu::GetItemCommandID(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return m_GUIContextMenu->getItemCommandId(index);
}

bool GUIContextMenu::GetItemEnabled(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return m_GUIContextMenu->isItemEnabled(index);
}

String^ GUIContextMenu::GetItemText(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return gcnew String(m_GUIContextMenu->getItemText(index));
}

GUIContextMenu^ GUIContextMenu::GetSubMenu(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);

	gui::IGUIContextMenu* m = m_GUIContextMenu->getSubMenu(index);
	return GUIContextMenu::Wrap(m);
}

int GUIContextMenu::InsertItem(int index, String^ text, int commandID, bool enabled, bool hasSubMenu, bool isChecked, bool autoChecking)
{
	LIME_ASSERT(index >= 0);

	return m_GUIContextMenu->insertItem(
		index,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID,
		enabled,
		hasSubMenu,
		isChecked,
		autoChecking);
}

int GUIContextMenu::InsertItem(int index, String^ text, int commandID, bool enabled, bool hasSubMenu, bool isChecked)
{
	LIME_ASSERT(index >= 0);

	return m_GUIContextMenu->insertItem(
		index,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID,
		enabled,
		hasSubMenu,
		isChecked);
}

int GUIContextMenu::InsertItem(int index, String^ text, int commandID, bool enabled, bool hasSubMenu)
{
	LIME_ASSERT(index >= 0);

	return m_GUIContextMenu->insertItem(
		index,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID,
		enabled,
		hasSubMenu);
}

int GUIContextMenu::InsertItem(int index, String^ text, int commandID, bool enabled)
{
	LIME_ASSERT(index >= 0);

	return m_GUIContextMenu->insertItem(
		index,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID,
		enabled);
}

int GUIContextMenu::InsertItem(int index, String^ text, int commandID)
{
	LIME_ASSERT(index >= 0);

	return m_GUIContextMenu->insertItem(
		index,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		commandID);
}

int GUIContextMenu::InsertItem(int index, String^ text)
{
	LIME_ASSERT(index >= 0);

	return m_GUIContextMenu->insertItem(
		index,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));
}

void GUIContextMenu::RemoveAllItems()
{
	m_GUIContextMenu->removeAllItems();
}

void GUIContextMenu::RemoveItem(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIContextMenu->removeItem(index);
}

void GUIContextMenu::SetEventParent(GUIElement^ parent)
{
	m_GUIContextMenu->setEventParent(LIME_SAFEREF(parent, m_GUIElement));
}

void GUIContextMenu::SetItemAutoChecking(int index, bool autoChecking)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIContextMenu->setItemAutoChecking(index, autoChecking);
}

void GUIContextMenu::SetItemChecked(int index, bool isChecked)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIContextMenu->setItemChecked(index, isChecked);
}

void GUIContextMenu::SetItemCommandID(int index, int commandID)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIContextMenu->setItemCommandId(index, commandID);
}

void GUIContextMenu::SetItemEnabled(int index, bool enabled)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIContextMenu->setItemEnabled(index, enabled);
}

void GUIContextMenu::SetItemText(int index, String^ text)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIContextMenu->setItemText(index, LIME_SAFESTRINGTOSTRINGW_C_STR(text));
}

GUIContextMenuClose GUIContextMenu::CloseHandling::get()
{
	return (GUIContextMenuClose)m_GUIContextMenu->getCloseHandling();
}

void GUIContextMenu::CloseHandling::set(GUIContextMenuClose value)
{
	m_GUIContextMenu->setCloseHandling((gui::ECONTEXT_MENU_CLOSE)value);
}

int GUIContextMenu::ItemCount::get()
{
	return m_GUIContextMenu->getItemCount();
}

int GUIContextMenu::SelectedCommandID::get()
{
	int i = m_GUIContextMenu->getSelectedItem();
	return i == -1 ? -1 : m_GUIContextMenu->getItemCommandId(i);
}

int GUIContextMenu::SelectedIndex::get()
{
	return m_GUIContextMenu->getSelectedItem();
}

} // end namespace GUI
} // end namespace IrrlichtLime