#include "stdafx.h"
#include "GUIComboBox.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIComboBox^ GUIComboBox::Wrap(gui::IGUIComboBox* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIComboBox(ref);
}

GUIComboBox::GUIComboBox(gui::IGUIComboBox* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIComboBox = ref;
}

int GUIComboBox::AddItem(String^ text, int data)
{
	int i = m_GUIComboBox->addItem(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		data);

	return i;
}

int GUIComboBox::AddItem(String^ text)
{
	int i = m_GUIComboBox->addItem(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));

	return i;
}

void GUIComboBox::Clear()
{
	m_GUIComboBox->clear();
}

int GUIComboBox::GetIndexForItemData(int data)
{
	return m_GUIComboBox->getIndexForItemData(data);
}

String^ GUIComboBox::GetItem(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return gcnew String(m_GUIComboBox->getItem(index));
}

int GUIComboBox::GetItemData(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	return m_GUIComboBox->getItemData(index);
}

void GUIComboBox::RemoveItem(int index)
{
	LIME_ASSERT(index >= 0 && index < ItemCount);
	m_GUIComboBox->removeItem(index);
}

void GUIComboBox::SetTextAlignment(GUIAlignment horizontal, GUIAlignment vertical)
{
	m_GUIComboBox->setTextAlignment((EGUI_ALIGNMENT)horizontal, (EGUI_ALIGNMENT)vertical);
}

int GUIComboBox::ItemCount::get()
{
	return m_GUIComboBox->getItemCount();
}

int GUIComboBox::MaxSelectionRows::get()
{
	return m_GUIComboBox->getMaxSelectionRows();
}

void GUIComboBox::MaxSelectionRows::set(int value)
{
	LIME_ASSERT(value >= 1);
	m_GUIComboBox->setMaxSelectionRows(value);
}

int GUIComboBox::SelectedIndex::get()
{
	return m_GUIComboBox->getSelected();
}

void GUIComboBox::SelectedIndex::set(int value)
{
	LIME_ASSERT(value >= -1); // -1 is valid value here
	m_GUIComboBox->setSelected(value);
}

} // end namespace GUI
} // end namespace IrrlichtLime