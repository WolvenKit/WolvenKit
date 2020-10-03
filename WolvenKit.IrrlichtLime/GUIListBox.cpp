#include "stdafx.h"
#include "GUIElement.h"
#include "GUIListBox.h"
#include "GUISpriteBank.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIListBox^ GUIListBox::Wrap(gui::IGUIListBox* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIListBox(ref);
}

GUIListBox::GUIListBox(gui::IGUIListBox* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIListBox = ref;
}

int GUIListBox::AddItem(String^ text, int icon)
{
	return m_GUIListBox->addItem(LIME_SAFESTRINGTOSTRINGW_C_STR(text), icon);
}

int GUIListBox::AddItem(String^ text)
{
	return m_GUIListBox->addItem(LIME_SAFESTRINGTOSTRINGW_C_STR(text));
}

void GUIListBox::ClearItemColor(int index, GUIListBoxColor colorType)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIListBox->clearItemOverrideColor(index, (gui::EGUI_LISTBOX_COLOR)colorType);
}

void GUIListBox::ClearItemColors(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIListBox->clearItemOverrideColor(index);
}

void GUIListBox::ClearItems()
{
	m_GUIListBox->clear();
}

String^ GUIListBox::GetItem(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return gcnew String(m_GUIListBox->getListItem(index));
}

int GUIListBox::GetItemAt(int xpos, int ypos)
{
	return m_GUIListBox->getItemAt(xpos, ypos);
}

Video::Color^ GUIListBox::GetItemDefaultColor(GUIListBoxColor colorType)
{
	return gcnew Video::Color(m_GUIListBox->getItemDefaultColor((gui::EGUI_LISTBOX_COLOR)colorType));
}

Video::Color^ GUIListBox::GetItemColor(int index, GUIListBoxColor colorType)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return gcnew Video::Color(m_GUIListBox->getItemOverrideColor(index, (gui::EGUI_LISTBOX_COLOR)colorType));
}

int GUIListBox::GetItemIcon(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return m_GUIListBox->getIcon(index);
}

int GUIListBox::InsertItem(int index, String^ text, int icon)
{
	LIME_ASSERT(index >= 0);
	return m_GUIListBox->insertItem(index, LIME_SAFESTRINGTOSTRINGW_C_STR(text), icon);
}

int GUIListBox::InsertItem(int index, String^ text)
{
	LIME_ASSERT(index >= 0);
	return m_GUIListBox->insertItem(index, LIME_SAFESTRINGTOSTRINGW_C_STR(text), -1);
}

bool GUIListBox::ItemColorOverrided(int index, GUIListBoxColor colorType)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return m_GUIListBox->hasItemOverrideColor(index, (gui::EGUI_LISTBOX_COLOR)colorType);
}

void GUIListBox::RemoveItem(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIListBox->removeItem(index);
}

void GUIListBox::SetDrawBackground(bool draw)
{
	m_GUIListBox->setDrawBackground(draw);
}

void GUIListBox::SetItem(int index, String^ text, int icon)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIListBox->setItem(index, LIME_SAFESTRINGTOSTRINGW_C_STR(text), icon);
}

void GUIListBox::SetItem(int index, String^ text)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIListBox->setItem(index, LIME_SAFESTRINGTOSTRINGW_C_STR(text), -1);
}

void GUIListBox::SetItemColor(int index, GUIListBoxColor colorType, Video::Color^ color)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	LIME_ASSERT(color != nullptr);

	m_GUIListBox->setItemOverrideColor(index, (gui::EGUI_LISTBOX_COLOR)colorType, *color->m_NativeValue);
}

void GUIListBox::SetItemHeight(int height)
{
	m_GUIListBox->setItemHeight(height);
}

void GUIListBox::SetSpriteBank(GUISpriteBank^ bank)
{
	m_GUIListBox->setSpriteBank(LIME_SAFEREF(bank, m_GUISpriteBank));
}

void GUIListBox::SwapItems(int index1, int index2)
{
	LIME_ASSERT(index1 >= 0 && index1 < ItemCount);
	LIME_ASSERT(index2 >= 0 && index2 < ItemCount);
	LIME_ASSERT(index1 != index2);

	m_GUIListBox->swapItems(index1, index2);
}

bool GUIListBox::AutoScroll::get()
{
	return m_GUIListBox->isAutoScrollEnabled();
}

void GUIListBox::AutoScroll::set(bool value)
{
	m_GUIListBox->setAutoScrollEnabled(value);
}

int GUIListBox::ItemCount::get()
{
	return m_GUIListBox->getItemCount();
}

int GUIListBox::SelectedIndex::get()
{
	return m_GUIListBox->getSelected();
}

void GUIListBox::SelectedIndex::set(int value)
{
	LIME_ASSERT(value >= -1); // -1 is valid here
	m_GUIListBox->setSelected(value);
}

String^ GUIListBox::SelectedItem::get()
{
	int i = m_GUIListBox->getSelected();

	if (i == -1)
		return nullptr;

	return gcnew String(m_GUIListBox->getListItem(i));
}

void GUIListBox::SelectedItem::set(String^ value)
{
	if (value == nullptr)
		m_GUIListBox->setSelected(nullptr);

	m_GUIListBox->setSelected(LIME_SAFESTRINGTOSTRINGW_C_STR(value));
}

} // end namespace GUI
} // end namespace IrrlichtLime