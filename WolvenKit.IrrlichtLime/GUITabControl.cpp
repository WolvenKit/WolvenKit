#include "stdafx.h"
#include "GUIElement.h"
#include "GUITab.h"
#include "GUITabControl.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUITabControl^ GUITabControl::Wrap(gui::IGUITabControl* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUITabControl(ref);
}

GUITabControl::GUITabControl(gui::IGUITabControl* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUITabControl = ref;
}

GUITab^ GUITabControl::AddTab(String^ caption, int id)
{
	gui::IGUITab* t = m_GUITabControl->addTab(
		LIME_SAFESTRINGTOSTRINGW_C_STR(caption),
		id);

	return GUITab::Wrap(t);
}

GUITab^ GUITabControl::AddTab(String^ caption)
{
	gui::IGUITab* t = m_GUITabControl->addTab(
		LIME_SAFESTRINGTOSTRINGW_C_STR(caption));

	return GUITab::Wrap(t);
}

void GUITabControl::Clear()
{
	m_GUITabControl->clear();
}

int GUITabControl::GetTabAt(int xpos, int ypos)
{
	return m_GUITabControl->getTabAt(xpos, ypos);
}

GUITab^ GUITabControl::InsertTab(int indexAt, String^ caption, int id)
{
	LIME_ASSERT(indexAt >= 0 && indexAt <= TabCount); // "<=" is not a mistype

	gui::IGUITab* t = m_GUITabControl->insertTab(
		indexAt,
		LIME_SAFESTRINGTOSTRINGW_C_STR(caption),
		id);

	return GUITab::Wrap(t);
}

GUITab^ GUITabControl::InsertTab(int indexAt, String^ caption)
{
	LIME_ASSERT(indexAt >= 0 && indexAt <= TabCount); // "<=" is not a mistype

	gui::IGUITab* t = m_GUITabControl->insertTab(
		indexAt,
		LIME_SAFESTRINGTOSTRINGW_C_STR(caption));

	return GUITab::Wrap(t);
}

void GUITabControl::RemoveTab(int index)
{
	LIME_ASSERT(index >= 0 && index < TabCount);
	m_GUITabControl->removeTab(index);
}

GUITab^ GUITabControl::ActiveTab::get()
{
	int i = m_GUITabControl->getActiveTab();
	if (i >= 0)
	{
		gui::IGUITab* t = m_GUITabControl->getTab(i);
		return GUITab::Wrap(t);
	}

	return nullptr;
}

void GUITabControl::ActiveTab::set(GUITab^ value)
{
	m_GUITabControl->setActiveTab(LIME_SAFEREF(value, m_GUITab));
}

int GUITabControl::ActiveTabIndex::get()
{
	return m_GUITabControl->getActiveTab();
}

void GUITabControl::ActiveTabIndex::set(int value)
{
	LIME_ASSERT(value >= -1 && value < TabCount);
	m_GUITabControl->setActiveTab(value);
}

int GUITabControl::TabCount::get()
{
	return m_GUITabControl->getTabCount();
}

int GUITabControl::TabExtraWidth::get()
{
	return m_GUITabControl->getTabExtraWidth();
}

void GUITabControl::TabExtraWidth::set(int value)
{
	m_GUITabControl->setTabExtraWidth(value);
}

int GUITabControl::TabHeight::get()
{
	return m_GUITabControl->getTabHeight();
}

void GUITabControl::TabHeight::set(int value)
{
	m_GUITabControl->setTabHeight(value);
}

int GUITabControl::TabMaxWidth::get()
{
	return m_GUITabControl->getTabMaxWidth();
}

void GUITabControl::TabMaxWidth::set(int value)
{
	m_GUITabControl->setTabMaxWidth(value);
}

GUIAlignment GUITabControl::TabVerticalAlignment::get()
{
	return (GUIAlignment)m_GUITabControl->getTabVerticalAlignment();
}

void GUITabControl::TabVerticalAlignment::set(GUIAlignment value)
{
	m_GUITabControl->setTabVerticalAlignment((gui::EGUI_ALIGNMENT)value);
}

} // end namespace GUI
} // end namespace IrrlichtLime