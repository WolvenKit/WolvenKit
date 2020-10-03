#include "stdafx.h"
#include "GUIButton.h"
#include "GUIElement.h"
#include "GUIToolBar.h"
#include "Texture.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIToolBar^ GUIToolBar::Wrap(gui::IGUIToolBar* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIToolBar(ref);
}

GUIToolBar::GUIToolBar(gui::IGUIToolBar* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIToolBar = ref;
}

GUIButton^ GUIToolBar::AddButton(int id, String^ text, String^ toolTipText, Video::Texture^ img, Video::Texture^ pressedImg,
	bool isPushButton, bool useAlphaChannel)
{
	gui::IGUIButton* b = m_GUIToolBar->addButton(
		id,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(toolTipText),
		LIME_SAFEREF(img, m_Texture),
		LIME_SAFEREF(pressedImg, m_Texture),
		isPushButton,
		useAlphaChannel);

	return GUIButton::Wrap(b);
}

GUIButton^ GUIToolBar::AddButton(int id, String^ text, String^ toolTipText, Video::Texture^ img, Video::Texture^ pressedImg,
	bool isPushButton)
{
	gui::IGUIButton* b = m_GUIToolBar->addButton(
		id,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(toolTipText),
		LIME_SAFEREF(img, m_Texture),
		LIME_SAFEREF(pressedImg, m_Texture),
		isPushButton);

	return GUIButton::Wrap(b);
}

GUIButton^ GUIToolBar::AddButton(int id, String^ text, String^ toolTipText, Video::Texture^ img, Video::Texture^ pressedImg)
{
	gui::IGUIButton* b = m_GUIToolBar->addButton(
		id,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(toolTipText),
		LIME_SAFEREF(img, m_Texture),
		LIME_SAFEREF(pressedImg, m_Texture));

	return GUIButton::Wrap(b);
}

GUIButton^ GUIToolBar::AddButton(int id, String^ text, String^ toolTipText, Video::Texture^ img)
{
	gui::IGUIButton* b = m_GUIToolBar->addButton(
		id,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(toolTipText),
		LIME_SAFEREF(img, m_Texture));

	return GUIButton::Wrap(b);
}

GUIButton^ GUIToolBar::AddButton(int id, String^ text, String^ toolTipText)
{
	gui::IGUIButton* b = m_GUIToolBar->addButton(
		id,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(toolTipText));

	return GUIButton::Wrap(b);
}

GUIButton^ GUIToolBar::AddButton(int id, String^ text)
{
	gui::IGUIButton* b = m_GUIToolBar->addButton(
		id,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));

	return GUIButton::Wrap(b);
}

GUIButton^ GUIToolBar::AddButton(int id)
{
	gui::IGUIButton* b = m_GUIToolBar->addButton(id);
	return GUIButton::Wrap(b);
}

GUIButton^ GUIToolBar::AddButton()
{
	gui::IGUIButton* b = m_GUIToolBar->addButton();
	return GUIButton::Wrap(b);
}

} // end namespace GUI
} // end namespace IrrlichtLime