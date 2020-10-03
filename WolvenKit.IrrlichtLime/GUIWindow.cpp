#include "stdafx.h"
#include "GUIButton.h"
#include "GUIElement.h"
#include "GUIWindow.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIWindow^ GUIWindow::Wrap(gui::IGUIWindow* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIWindow(ref);
}

GUIWindow::GUIWindow(gui::IGUIWindow* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIWindow = ref;
}

Recti^ GUIWindow::ClientRect::get()
{
	return gcnew Recti(m_GUIWindow->getClientRect());
}

GUIButton^ GUIWindow::CloseButton::get()
{
	gui::IGUIButton* b = m_GUIWindow->getCloseButton();
	return GUIButton::Wrap(b);
}

bool GUIWindow::Draggable::get()
{
	return m_GUIWindow->isDraggable();
}

void GUIWindow::Draggable::set(bool value)
{
	m_GUIWindow->setDraggable(value);
}

bool GUIWindow::DrawBackground::get()
{
	return m_GUIWindow->getDrawBackground();
}

void GUIWindow::DrawBackground::set(bool value)
{
	m_GUIWindow->setDrawBackground(value);
}

bool GUIWindow::DrawTitleBar::get()
{
	return m_GUIWindow->getDrawTitlebar();
}

void GUIWindow::DrawTitleBar::set(bool value)
{
	m_GUIWindow->setDrawTitlebar(value);
}

GUIButton^ GUIWindow::MaximizeButton::get()
{
	gui::IGUIButton* b = m_GUIWindow->getMaximizeButton();
	return GUIButton::Wrap(b);
}

GUIButton^ GUIWindow::MinimizeButton::get()
{
	gui::IGUIButton* b = m_GUIWindow->getMinimizeButton();
	return GUIButton::Wrap(b);
}

} // end namespace GUI
} // end namespace IrrlichtLime