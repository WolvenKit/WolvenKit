#include "stdafx.h"
#include "GUICheckBox.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUICheckBox^ GUICheckBox::Wrap(gui::IGUICheckBox* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUICheckBox(ref);
}

GUICheckBox::GUICheckBox(gui::IGUICheckBox* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUICheckBox = ref;
}

bool GUICheckBox::Checked::get()
{
	return m_GUICheckBox->isChecked();
}

void GUICheckBox::Checked::set(bool value)
{
	m_GUICheckBox->setChecked(value);
}

bool GUICheckBox::DrawBackground::get()
{
	return m_GUICheckBox->isDrawBackgroundEnabled();
}

void GUICheckBox::DrawBackground::set(bool value)
{
	m_GUICheckBox->setDrawBackground(value);
}

bool GUICheckBox::DrawBorder::get()
{
	return m_GUICheckBox->isDrawBorderEnabled();
}

void GUICheckBox::DrawBorder::set(bool value)
{
	m_GUICheckBox->setDrawBorder(value);
}

} // end namespace GUI
} // end namespace IrrlichtLime