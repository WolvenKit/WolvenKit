#include "stdafx.h"
#include "GUIElement.h"
#include "GUIImage.h"
#include "Texture.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIImage^ GUIImage::Wrap(gui::IGUIImage* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIImage(ref);
}

GUIImage::GUIImage(gui::IGUIImage* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIImage = ref;
}

bool GUIImage::AlphaChannel::get()
{
	return m_GUIImage->isAlphaChannelUsed();
}

void GUIImage::AlphaChannel::set(bool value)
{
	m_GUIImage->setUseAlphaChannel(value);
}

Video::Color^ GUIImage::Color::get()
{
	return gcnew Video::Color(m_GUIImage->getColor());
}

void GUIImage::Color::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_GUIImage->setColor(*value->m_NativeValue);
}

Video::Texture^ GUIImage::Image::get()
{
	video::ITexture* i = m_GUIImage->getImage();
	return Video::Texture::Wrap(i);
}

void GUIImage::Image::set(Video::Texture^ value)
{
	m_GUIImage->setImage(LIME_SAFEREF(value, m_Texture));
}

bool GUIImage::ScaleImage::get()
{
	return m_GUIImage->isImageScaled();
}

void GUIImage::ScaleImage::set(bool value)
{
	m_GUIImage->setScaleImage(value);
}

} // end namespace GUI
} // end namespace IrrlichtLime