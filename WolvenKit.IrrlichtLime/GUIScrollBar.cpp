#include "stdafx.h"
#include "GUIElement.h"
#include "GUIScrollBar.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIScrollBar^ GUIScrollBar::Wrap(gui::IGUIScrollBar* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIScrollBar(ref);
}

GUIScrollBar::GUIScrollBar(gui::IGUIScrollBar* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIScrollBar = ref;
}

int GUIScrollBar::LargeStep::get()
{
	return m_GUIScrollBar->getLargeStep();
}

void GUIScrollBar::LargeStep::set(int value)
{
	m_GUIScrollBar->setLargeStep(value);
}

int GUIScrollBar::MaxValue::get()
{
	return m_GUIScrollBar->getMax();
}

void GUIScrollBar::MaxValue::set(int value)
{
	m_GUIScrollBar->setMax(value);
}

int GUIScrollBar::MinValue::get()
{
	return m_GUIScrollBar->getMin();
}

void GUIScrollBar::MinValue::set(int value)
{
	m_GUIScrollBar->setMin(value);
}

int GUIScrollBar::Position::get()
{
	return m_GUIScrollBar->getPos();
}

void GUIScrollBar::Position::set(int value)
{
	m_GUIScrollBar->setPos(value);
}

int GUIScrollBar::SmallStep::get()
{
	return m_GUIScrollBar->getSmallStep();
}

void GUIScrollBar::SmallStep::set(int value)
{
	m_GUIScrollBar->setSmallStep(value);
}

} // end namespace GUI
} // end namespace IrrlichtLime