#include "stdafx.h"
#include "GUIElement.h"
#include "GUIInOutFader.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIInOutFader^ GUIInOutFader::Wrap(gui::IGUIInOutFader* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIInOutFader(ref);
}

GUIInOutFader::GUIInOutFader(gui::IGUIInOutFader* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIInOutFader = ref;
}

void GUIInOutFader::FadeIn(unsigned int time)
{
	m_GUIInOutFader->fadeIn(time);
}

void GUIInOutFader::FadeOut(unsigned int time)
{
	m_GUIInOutFader->fadeOut(time);
}

void GUIInOutFader::SetColor(Video::Color^ source, Video::Color^ dest)
{
	LIME_ASSERT(source != nullptr);
	LIME_ASSERT(dest != nullptr);

	m_GUIInOutFader->setColor(
		*source->m_NativeValue,
		*dest->m_NativeValue);
}

void GUIInOutFader::SetColor(Video::Color^ bothAplhaIgnored)
{
	LIME_ASSERT(bothAplhaIgnored != nullptr);
	m_GUIInOutFader->setColor(*bothAplhaIgnored->m_NativeValue);
}

bool GUIInOutFader::Ready::get()
{
	return m_GUIInOutFader->isReady();
}

} // end namespace GUI
} // end namespace IrrlichtLime