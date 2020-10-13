#include "stdafx.h"
#include "GUIElement.h"
#include "GUITab.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUITab^ GUITab::Wrap(gui::IGUITab* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUITab(ref);
}

GUITab::GUITab(gui::IGUITab* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUITab = ref;
}

Video::Color^ GUITab::BackgroundColor::get()
{
	return gcnew Video::Color(m_GUITab->getBackgroundColor());
}

void GUITab::BackgroundColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_GUITab->setBackgroundColor(*value->m_NativeValue);
}

bool GUITab::DrawBackground::get()
{
	return m_GUITab->isDrawingBackground();
}

void GUITab::DrawBackground::set(bool value)
{
	m_GUITab->setDrawBackground(value);
}

int GUITab::Index::get()
{
	return m_GUITab->getNumber();
}

Video::Color^ GUITab::TextColor::get()
{
	return gcnew Video::Color(m_GUITab->getTextColor());
}

void GUITab::TextColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_GUITab->setTextColor(*value->m_NativeValue);
}

} // end namespace GUI
} // end namespace IrrlichtLime