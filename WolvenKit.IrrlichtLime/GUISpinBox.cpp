#include "stdafx.h"
#include "GUIEditBox.h"
#include "GUIElement.h"
#include "GUISpinBox.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUISpinBox^ GUISpinBox::Wrap(gui::IGUISpinBox* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUISpinBox(ref);
}

GUISpinBox::GUISpinBox(gui::IGUISpinBox* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUISpinBox = ref;
}

void GUISpinBox::SetDecimalPlaces(int places)
{
	LIME_ASSERT(places >= -1); // -1 is valid here
	m_GUISpinBox->setDecimalPlaces(places);
}

void GUISpinBox::SetRange(float min, float max)
{
	LIME_ASSERT(min <= max);
	m_GUISpinBox->setRange(min, max);
}

GUIEditBox^ GUISpinBox::EditBox::get()
{
	gui::IGUIEditBox* b = m_GUISpinBox->getEditBox();
	return GUIEditBox::Wrap(b);
}

float GUISpinBox::Maximum::get()
{
	return m_GUISpinBox->getMax();
}

void GUISpinBox::Maximum::set(float value)
{
	m_GUISpinBox->setRange(
		m_GUISpinBox->getMin(),
		value);
}

float GUISpinBox::Minimum::get()
{
	return m_GUISpinBox->getMin();
}

void GUISpinBox::Minimum::set(float value)
{
	m_GUISpinBox->setRange(
		value,
		m_GUISpinBox->getMax());
}

float GUISpinBox::StepSize::get()
{
	return m_GUISpinBox->getStepSize();
}

void GUISpinBox::StepSize::set(float value)
{
	LIME_ASSERT(value > 0.0f);
	m_GUISpinBox->setStepSize(value);
}

GUISpinBoxValidation GUISpinBox::ValidateOn::get()
{
	return (GUISpinBoxValidation) m_GUISpinBox->getValidateOn();
}

void GUISpinBox::ValidateOn::set(GUISpinBoxValidation value)
{
	m_GUISpinBox->setValidateOn((gui::EGUI_SPINBOX_VALIDATION) value);
}

float GUISpinBox::Value::get()
{
	return m_GUISpinBox->getValue();
}

void GUISpinBox::Value::set(float value)
{
	LIME_ASSERT(value >= Minimum && value <= Maximum);
	m_GUISpinBox->setValue(value);
}

} // end namespace GUI
} // end namespace IrrlichtLime