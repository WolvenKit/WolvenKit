#include "stdafx.h"
#include "GUIEditBox.h"
#include "GUIElement.h"
#include "GUIFont.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIEditBox^ GUIEditBox::Wrap(gui::IGUIEditBox* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIEditBox(ref);
}

GUIEditBox::GUIEditBox(gui::IGUIEditBox* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIEditBox = ref;
}

void GUIEditBox::SetPasswordChar(Char x)
{
	m_GUIEditBox->setPasswordBox(m_GUIEditBox->isPasswordBox(), x);
}

void GUIEditBox::SetTextAlignment(GUIAlignment horizontal, GUIAlignment vertical)
{
	m_GUIEditBox->setTextAlignment((gui::EGUI_ALIGNMENT)horizontal, (gui::EGUI_ALIGNMENT)vertical);
}

GUIFont^ GUIEditBox::ActiveFont::get()
{
	gui::IGUIFont* f = m_GUIEditBox->getActiveFont();
	return GUIFont::Wrap(f);
}

bool GUIEditBox::AutoScroll::get()
{
	return m_GUIEditBox->isAutoScrollEnabled();
}

void GUIEditBox::AutoScroll::set(bool value)
{
	m_GUIEditBox->setAutoScroll(value);
}

int GUIEditBox::CursorBlinkTime::get()
{
	return (int) m_GUIEditBox->getCursorBlinkTime();
}

void GUIEditBox::CursorBlinkTime::set(int value)
{
	m_GUIEditBox->setCursorBlinkTime((u32)value);
}

wchar_t GUIEditBox::CursorChar::get()
{
	return m_GUIEditBox->getCursorChar();
}

void GUIEditBox::CursorChar::set(wchar_t value)
{
	m_GUIEditBox->setCursorChar(value);
}

bool GUIEditBox::DrawBackground::get()
{
	return m_GUIEditBox->isDrawBackgroundEnabled();
}

void GUIEditBox::DrawBackground::set(bool value)
{
	m_GUIEditBox->setDrawBackground(value);
}

bool GUIEditBox::DrawBorder::get()
{
	return m_GUIEditBox->isDrawBorderEnabled();
}

void GUIEditBox::DrawBorder::set(bool value)
{
	m_GUIEditBox->setDrawBorder(value);
}

int GUIEditBox::MaxLength::get()
{
	return m_GUIEditBox->getMax();
}

void GUIEditBox::MaxLength::set(int value)
{
	LIME_ASSERT(value >= 0);
	m_GUIEditBox->setMax(value);
}

bool GUIEditBox::MultiLine::get()
{
	return m_GUIEditBox->isMultiLineEnabled();
}

void GUIEditBox::MultiLine::set(bool value)
{
	m_GUIEditBox->setMultiLine(value);
}

Video::Color^ GUIEditBox::OverrideColor::get()
{
	return gcnew Video::Color(m_GUIEditBox->getOverrideColor());
}

void GUIEditBox::OverrideColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_GUIEditBox->setOverrideColor(*value->m_NativeValue);
}

bool GUIEditBox::OverrideColorEnabled::get()
{
	return m_GUIEditBox->isOverrideColorEnabled();
}

void GUIEditBox::OverrideColorEnabled::set(bool value)
{
	m_GUIEditBox->enableOverrideColor(value);
}

GUIFont^ GUIEditBox::OverrideFont::get()
{
	gui::IGUIFont* f = m_GUIEditBox->getOverrideFont();
	return GUIFont::Wrap(f);
}

void GUIEditBox::OverrideFont::set(GUIFont^ value)
{
	m_GUIEditBox->setOverrideFont(LIME_SAFEREF(value, m_GUIFont));
}

bool GUIEditBox::PasswordBox::get()
{
	return m_GUIEditBox->isPasswordBox();
}

void GUIEditBox::PasswordBox::set(bool value)
{
	m_GUIEditBox->setPasswordBox(value);
}

Dimension2Di^ GUIEditBox::TextDimension::get()
{
	return gcnew Dimension2Di(m_GUIEditBox->getTextDimension());
}

bool GUIEditBox::WordWrap::get()
{
	return m_GUIEditBox->isWordWrapEnabled();
}

void GUIEditBox::WordWrap::set(bool value)
{
	m_GUIEditBox->setWordWrap(value);
}

} // end namespace GUI
} // end namespace IrrlichtLime