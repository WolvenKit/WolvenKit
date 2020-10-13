#include "stdafx.h"
#include "GUIElement.h"
#include "GUIFont.h"
#include "GUIStaticText.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIStaticText^ GUIStaticText::Wrap(gui::IGUIStaticText* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIStaticText(ref);
}

GUIStaticText::GUIStaticText(gui::IGUIStaticText* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIStaticText = ref;
}

void GUIStaticText::SetTextAlignment(GUIAlignment horizontal, GUIAlignment vertical)
{
	m_GUIStaticText->setTextAlignment((gui::EGUI_ALIGNMENT)horizontal, (gui::EGUI_ALIGNMENT)vertical);
}

GUIFont^ GUIStaticText::ActiveFont::get()
{
	gui::IGUIFont* f = m_GUIStaticText->getActiveFont();
	return GUIFont::Wrap(f);
}

Video::Color^ GUIStaticText::BackgroundColor::get()
{
	return gcnew Video::Color(m_GUIStaticText->getBackgroundColor());
}

void GUIStaticText::BackgroundColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_GUIStaticText->setBackgroundColor(*value->m_NativeValue);
}

bool GUIStaticText::DrawBackgroundEnabled::get()
{
	return m_GUIStaticText->isDrawBackgroundEnabled();
}

void GUIStaticText::DrawBackgroundEnabled::set(bool value)
{
	m_GUIStaticText->setDrawBackground(value);
}

bool GUIStaticText::DrawBorderEnabled::get()
{
	return m_GUIStaticText->isDrawBorderEnabled();
}

void GUIStaticText::DrawBorderEnabled::set(bool value)
{
	m_GUIStaticText->setDrawBorder(value);
}

Video::Color^ GUIStaticText::OverrideColor::get()
{
	return gcnew Video::Color(m_GUIStaticText->getOverrideColor());
}

void GUIStaticText::OverrideColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_GUIStaticText->setOverrideColor(*value->m_NativeValue);
}

bool GUIStaticText::OverrideColorEnabled::get()
{
	return m_GUIStaticText->isOverrideColorEnabled();
}

void GUIStaticText::OverrideColorEnabled::set(bool value)
{
	m_GUIStaticText->enableOverrideColor(value);
}

GUIFont^ GUIStaticText::OverrideFont::get()
{
	return GUIFont::Wrap(m_GUIStaticText->getOverrideFont());
}

void GUIStaticText::OverrideFont::set(GUIFont^ value)
{
	m_GUIStaticText->setOverrideFont(LIME_SAFEREF(value, m_GUIFont));
}

bool GUIStaticText::RightToLeft::get()
{
	return m_GUIStaticText->isRightToLeft();
}

void GUIStaticText::RightToLeft::set(bool value)
{
	m_GUIStaticText->setRightToLeft(value);
}

int GUIStaticText::TextHeight::get()
{
	return m_GUIStaticText->getTextHeight();
}

bool GUIStaticText::TextRestrainedInside::get()
{
	return m_GUIStaticText->isTextRestrainedInside();
}

void GUIStaticText::TextRestrainedInside::set(bool value)
{
	m_GUIStaticText->setTextRestrainedInside(value);
}

int GUIStaticText::TextWidth::get()
{
	return m_GUIStaticText->getTextWidth();
}

bool GUIStaticText::WordWrap::get()
{
	return m_GUIStaticText->isWordWrapEnabled();
}

void GUIStaticText::WordWrap::set(bool value)
{
	m_GUIStaticText->setWordWrap(value);
}

} // end namespace GUI
} // end namespace IrrlichtLime