#include "stdafx.h"
#include "AttributeExchangingObject.h"
#include "GUIElement.h"
#include "GUIFont.h"
#include "GUISkin.h"
#include "GUISpriteBank.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace GUI {

GUISkin^ GUISkin::Wrap(gui::IGUISkin* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUISkin(ref);
}

GUISkin::GUISkin(gui::IGUISkin* ref)
	: IO::AttributeExchangingObject(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUISkin = ref;
}

void GUISkin::Draw2DRectangle(GUIElement^ element, Video::Color^ color, Recti^ pos, Recti^ clip)
{
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(pos != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw2DRectangle(
		LIME_SAFEREF(element, m_GUIElement),
		*color->m_NativeValue,
		*pos->m_NativeValue,
		clip->m_NativeValue);
}

void GUISkin::Draw2DRectangle(GUIElement^ element, Video::Color^ color, Recti^ pos)
{
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(pos != nullptr);

	m_GUISkin->draw2DRectangle(
		LIME_SAFEREF(element, m_GUIElement),
		*color->m_NativeValue,
		*pos->m_NativeValue);
}

void GUISkin::Draw3DButtonPanePressed(GUIElement^ element, Recti^ rect, Recti^ clip)
{
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DButtonPanePressed(
		LIME_SAFEREF(element, m_GUIElement),
		*rect->m_NativeValue,
		clip->m_NativeValue);
}

void GUISkin::Draw3DButtonPanePressed(GUIElement^ element, Recti^ rect)
{
	LIME_ASSERT(rect != nullptr);

	m_GUISkin->draw3DButtonPanePressed(
		LIME_SAFEREF(element, m_GUIElement),
		*rect->m_NativeValue);
}

void GUISkin::Draw3DButtonPaneStandard(GUIElement^ element, Recti^ rect, Recti^ clip)
{
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DButtonPaneStandard(
		LIME_SAFEREF(element, m_GUIElement),
		*rect->m_NativeValue,
		clip->m_NativeValue);
}

void GUISkin::Draw3DButtonPaneStandard(GUIElement^ element, Recti^ rect)
{
	LIME_ASSERT(rect != nullptr);

	m_GUISkin->draw3DButtonPaneStandard(
		LIME_SAFEREF(element, m_GUIElement),
		*rect->m_NativeValue);
}

void GUISkin::Draw3DMenuPane(GUIElement^ element, Recti^ rect, Recti^ clip)
{
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DMenuPane(
		LIME_SAFEREF(element, m_GUIElement),
		*rect->m_NativeValue,
		clip->m_NativeValue);
}

void GUISkin::Draw3DMenuPane(GUIElement^ element, Recti^ rect)
{
	LIME_ASSERT(rect != nullptr);

	m_GUISkin->draw3DMenuPane(
		LIME_SAFEREF(element, m_GUIElement),
		*rect->m_NativeValue);
}

void GUISkin::Draw3DSunkenPane(GUIElement^ element, Video::Color^ bgcolor, bool flat, bool fillBackGround, Recti^ rect, Recti^ clip)
{
	LIME_ASSERT(bgcolor != nullptr);
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DSunkenPane(
		LIME_SAFEREF(element, m_GUIElement),
		*bgcolor->m_NativeValue,
		flat,
		fillBackGround,
		*rect->m_NativeValue,
		clip->m_NativeValue);
}

void GUISkin::Draw3DSunkenPane(GUIElement^ element, Video::Color^ bgcolor, bool flat, bool fillBackGround, Recti^ rect)
{
	LIME_ASSERT(bgcolor != nullptr);
	LIME_ASSERT(rect != nullptr);

	m_GUISkin->draw3DSunkenPane(
		LIME_SAFEREF(element, m_GUIElement),
		*bgcolor->m_NativeValue,
		flat,
		fillBackGround,
		*rect->m_NativeValue);
}

void GUISkin::Draw3DTabBody(GUIElement^ element, bool border, bool background, Recti^ rect, Recti^ clip, int tabHeight, GUIAlignment alignment)
{
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DTabBody(
		LIME_SAFEREF(element, m_GUIElement),
		border,
		background,
		*rect->m_NativeValue,
		clip->m_NativeValue,
		tabHeight,
		(gui::EGUI_ALIGNMENT)alignment);
}

void GUISkin::Draw3DTabBody(GUIElement^ element, bool border, bool background, Recti^ rect, Recti^ clip, int tabHeight)
{
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DTabBody(
		LIME_SAFEREF(element, m_GUIElement),
		border,
		background,
		*rect->m_NativeValue,
		clip->m_NativeValue,
		tabHeight);
}

void GUISkin::Draw3DTabBody(GUIElement^ element, bool border, bool background, Recti^ rect, Recti^ clip)
{
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DTabBody(
		LIME_SAFEREF(element, m_GUIElement),
		border,
		background,
		*rect->m_NativeValue,
		clip->m_NativeValue);
}

void GUISkin::Draw3DTabBody(GUIElement^ element, bool border, bool background, Recti^ rect)
{
	LIME_ASSERT(rect != nullptr);

	m_GUISkin->draw3DTabBody(
		LIME_SAFEREF(element, m_GUIElement),
		border,
		background,
		*rect->m_NativeValue);
}

void GUISkin::Draw3DTabButton(GUIElement^ element, bool active, Recti^ rect, Recti^ clip, GUIAlignment alignment)
{
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DTabButton(
		LIME_SAFEREF(element, m_GUIElement),
		active,
		*rect->m_NativeValue,
		clip->m_NativeValue,
		(gui::EGUI_ALIGNMENT)alignment);
}

void GUISkin::Draw3DTabButton(GUIElement^ element, bool active, Recti^ rect, Recti^ clip)
{
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DTabButton(
		LIME_SAFEREF(element, m_GUIElement),
		active,
		*rect->m_NativeValue,
		clip->m_NativeValue);
}

void GUISkin::Draw3DTabButton(GUIElement^ element, bool active, Recti^ rect)
{
	LIME_ASSERT(rect != nullptr);

	m_GUISkin->draw3DTabButton(
		LIME_SAFEREF(element, m_GUIElement),
		active,
		*rect->m_NativeValue);
}

void GUISkin::Draw3DToolBar(GUIElement^ element, Recti^ rect, Recti^ clip)
{
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUISkin->draw3DToolBar(
		LIME_SAFEREF(element, m_GUIElement),
		*rect->m_NativeValue,
		clip->m_NativeValue);
}

void GUISkin::Draw3DToolBar(GUIElement^ element, Recti^ rect)
{
	LIME_ASSERT(rect != nullptr);

	m_GUISkin->draw3DToolBar(
		LIME_SAFEREF(element, m_GUIElement),
		*rect->m_NativeValue);
}

Recti^ GUISkin::Draw3DWindowBackground(GUIElement^ element, bool drawTitleBar, Video::Color^ titleBarColor, Recti^ rect, Recti^ clip, [Out] Recti^ checkClientArea)
{
	LIME_ASSERT(titleBarColor != nullptr);
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	core::recti rclient;
	core::recti rtitle = m_GUISkin->draw3DWindowBackground(
		LIME_SAFEREF(element, m_GUIElement),
		drawTitleBar,
		*titleBarColor->m_NativeValue,
		*rect->m_NativeValue,
		clip->m_NativeValue,
		&rclient);

	checkClientArea = gcnew Recti(rclient);
	return gcnew Recti(rtitle);
}

Recti^ GUISkin::Draw3DWindowBackground(GUIElement^ element, bool drawTitleBar, Video::Color^ titleBarColor, Recti^ rect, Recti^ clip)
{
	LIME_ASSERT(titleBarColor != nullptr);
	LIME_ASSERT(rect != nullptr);
	LIME_ASSERT(clip != nullptr);

	core::recti rtitle = m_GUISkin->draw3DWindowBackground(
		LIME_SAFEREF(element, m_GUIElement),
		drawTitleBar,
		*titleBarColor->m_NativeValue,
		*rect->m_NativeValue,
		clip->m_NativeValue);

	return gcnew Recti(rtitle);
}

Recti^ GUISkin::Draw3DWindowBackground(GUIElement^ element, bool drawTitleBar, Video::Color^ titleBarColor, Recti^ rect)
{
	LIME_ASSERT(titleBarColor != nullptr);
	LIME_ASSERT(rect != nullptr);

	core::recti rtitle = m_GUISkin->draw3DWindowBackground(
		LIME_SAFEREF(element, m_GUIElement),
		drawTitleBar,
		*titleBarColor->m_NativeValue,
		*rect->m_NativeValue);

	return gcnew Recti(rtitle);
}

void GUISkin::DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position, unsigned int starttime, unsigned int currenttime, bool loop, Recti^ clip)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(clip != nullptr);
	
	m_GUISkin->drawIcon(
		LIME_SAFEREF(element, m_GUIElement),
		(gui::EGUI_DEFAULT_ICON)icon,
		*position->m_NativeValue,
		starttime,
		currenttime,
		loop,
		clip->m_NativeValue);
}

void GUISkin::DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position, unsigned int starttime, unsigned int currenttime, bool loop)
{
	LIME_ASSERT(position != nullptr);
	
	m_GUISkin->drawIcon(
		LIME_SAFEREF(element, m_GUIElement),
		(gui::EGUI_DEFAULT_ICON)icon,
		*position->m_NativeValue,
		starttime,
		currenttime,
		loop);
}

void GUISkin::DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position, unsigned int starttime, unsigned int currenttime)
{
	LIME_ASSERT(position != nullptr);
	
	m_GUISkin->drawIcon(
		LIME_SAFEREF(element, m_GUIElement),
		(gui::EGUI_DEFAULT_ICON)icon,
		*position->m_NativeValue,
		starttime,
		currenttime);
}

void GUISkin::DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position, unsigned int starttime)
{
	LIME_ASSERT(position != nullptr);
	
	m_GUISkin->drawIcon(
		LIME_SAFEREF(element, m_GUIElement),
		(gui::EGUI_DEFAULT_ICON)icon,
		*position->m_NativeValue,
		starttime);
}

void GUISkin::DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position)
{
	LIME_ASSERT(position != nullptr);
	
	m_GUISkin->drawIcon(
		LIME_SAFEREF(element, m_GUIElement),
		(gui::EGUI_DEFAULT_ICON)icon,
		*position->m_NativeValue);
}

Video::Color^ GUISkin::GetColor(GUIDefaultColor color)
{
	return gcnew Video::Color(m_GUISkin->getColor((gui::EGUI_DEFAULT_COLOR)color));
}

String^ GUISkin::GetText(GUIDefaultText text)
{
	return gcnew String(m_GUISkin->getDefaultText((gui::EGUI_DEFAULT_TEXT)text));
}

GUIFont^ GUISkin::GetFont(GUIDefaultFont which)
{
	return GUIFont::Wrap(m_GUISkin->getFont((gui::EGUI_DEFAULT_FONT)which));
}

int GUISkin::GetIcon(GUIDefaultIcon icon)
{
	return m_GUISkin->getIcon((gui::EGUI_DEFAULT_ICON)icon);
}

int GUISkin::GetSize(GUIDefaultSize size)
{
	return m_GUISkin->getSize((gui::EGUI_DEFAULT_SIZE)size);
}

void GUISkin::SetColor(Video::Color^ newColor, GUIDefaultColor which)
{
	LIME_ASSERT(newColor != nullptr);
	m_GUISkin->setColor((gui::EGUI_DEFAULT_COLOR)which, *newColor->m_NativeValue);
}

void GUISkin::SetText(String^ newText, GUIDefaultText which)
{
	m_GUISkin->setDefaultText((gui::EGUI_DEFAULT_TEXT)which, LIME_SAFESTRINGTOSTRINGW_C_STR(newText));
}

void GUISkin::SetFont(GUIFont^ font, GUIDefaultFont which)
{
	LIME_ASSERT(font != nullptr);
	m_GUISkin->setFont(LIME_SAFEREF(font, m_GUIFont), (gui::EGUI_DEFAULT_FONT)which);
}

void GUISkin::SetFont(GUIFont^ font)
{
	LIME_ASSERT(font != nullptr);
	m_GUISkin->setFont(LIME_SAFEREF(font, m_GUIFont));
}

void GUISkin::SetIcon(int index, GUIDefaultIcon which)
{
	LIME_ASSERT(index >= 0);
	m_GUISkin->setIcon((gui::EGUI_DEFAULT_ICON)which, index);
}

void GUISkin::SetSize(int size, GUIDefaultSize which)
{
	m_GUISkin->setSize((gui::EGUI_DEFAULT_SIZE)which, size);
}

GUISpriteBank^ GUISkin::SpriteBank::get()
{
	return GUISpriteBank::Wrap(m_GUISkin->getSpriteBank());
}

void GUISkin::SpriteBank::set(GUISpriteBank^ value)
{
	m_GUISkin->setSpriteBank(LIME_SAFEREF(value, m_GUISpriteBank));
}

GUISkinType GUISkin::Type::get()
{
	return (GUISkinType)m_GUISkin->getType();
}

String^ GUISkin::ToString()
{
	return String::Format("GUISkin: Type={0}", Type);
}

} // end namespace GUI
} // end namespace IrrlichtLime