#include "stdafx.h"
#include "GUIFont.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace GUI {

GUIFont^ GUIFont::Wrap(gui::IGUIFont* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIFont(ref);
}

GUIFont::GUIFont(gui::IGUIFont* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIFont = ref;
}

void GUIFont::Draw(String^ text, Recti^ position, Video::Color^ color, bool hcenter, bool vcenter, Recti^ clip)
{
	LIME_ASSERT(text != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUIFont->draw(
		Lime::StringToStringW(text),
		*position->m_NativeValue,
		*color->m_NativeValue,
		hcenter,
		vcenter,
		clip->m_NativeValue);
}

void GUIFont::Draw(String^ text, Recti^ position, Video::Color^ color, bool hcenter, bool vcenter)
{
	LIME_ASSERT(text != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(color != nullptr);

	m_GUIFont->draw(
		Lime::StringToStringW(text),
		*position->m_NativeValue,
		*color->m_NativeValue,
		hcenter,
		vcenter);
}

void GUIFont::Draw(String^ text, Recti^ position, Video::Color^ color, bool hcenter)
{
	LIME_ASSERT(text != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(color != nullptr);

	m_GUIFont->draw(
		Lime::StringToStringW(text),
		*position->m_NativeValue,
		*color->m_NativeValue,
		hcenter);
}

void GUIFont::Draw(String^ text, Vector2Di^ position, Video::Color^ color, Recti^ clip)
{
	LIME_ASSERT(text != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUIFont->draw(
		Lime::StringToStringW(text),
		core::recti(*position->m_NativeValue, core::vector2di()),
		*color->m_NativeValue,
		false,
		false,
		clip->m_NativeValue);
}

void GUIFont::Draw(String^ text, Vector2Di^ position, Video::Color^ color)
{
	LIME_ASSERT(text != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(color != nullptr);

	m_GUIFont->draw(
		Lime::StringToStringW(text),
		core::recti(*position->m_NativeValue, core::vector2di()),
		*color->m_NativeValue);
}

void GUIFont::Draw(String^ text, int x, int y, Video::Color^ color, Recti^ clip)
{
	LIME_ASSERT(text != nullptr);
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUIFont->draw(
		Lime::StringToStringW(text),
		core::recti(core::vector2di(x, y), core::vector2di()),
		*color->m_NativeValue,
		false,
		false,
		clip->m_NativeValue);
}

void GUIFont::Draw(String^ text, int x, int y, Video::Color^ color)
{
	LIME_ASSERT(text != nullptr);
	LIME_ASSERT(color != nullptr);

	m_GUIFont->draw(
		Lime::StringToStringW(text),
		core::recti(core::vector2di(x, y), core::vector2di()),
		*color->m_NativeValue);
}

int GUIFont::GetCharacterFromPos(String^ text, int pixel_x)
{
	return m_GUIFont->getCharacterFromPos(LIME_SAFESTRINGTOSTRINGW_C_STR(text), pixel_x);
}

Dimension2Di^ GUIFont::GetDimension(String^ text)
{
	return gcnew Dimension2Di(m_GUIFont->getDimension(LIME_SAFESTRINGTOSTRINGW_C_STR(text)));
}

int GUIFont::GetKerningWidth(Char thisLetter, Char previousLetter)
{
	return m_GUIFont->getKerningWidth(&thisLetter, &previousLetter);
}

int GUIFont::GetKerningWidth(Char thisLetter)
{
	return m_GUIFont->getKerningWidth(&thisLetter);
}

void GUIFont::SetInvisibleCharacters(String^ s)
{
	m_GUIFont->setInvisibleCharacters(LIME_SAFESTRINGTOSTRINGW_C_STR(s));
}

int GUIFont::KerningHeight::get()
{
	return m_GUIFont->getKerningHeight();
}

void GUIFont::KerningHeight::set(int value)
{
	m_GUIFont->setKerningHeight(value);
}

int GUIFont::KerningWidth::get()
{
	return m_GUIFont->getKerningWidth();
}

void GUIFont::KerningWidth::set(int value)
{
	m_GUIFont->setKerningWidth(value);
}

GUIFontType GUIFont::Type::get()
{
	return (GUIFontType)m_GUIFont->getType();
}

String^ GUIFont::ToString()
{
	return String::Format("GUIFont: Type={0}", Type);
}

} // end namespace GUI
} // end namespace IrrlichtLime