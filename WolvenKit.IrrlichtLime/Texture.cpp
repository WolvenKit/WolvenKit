#include "stdafx.h"
#include "ReferenceCounted.h"
#include "Texture.h"
#include "TexturePainter.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

Texture^ Texture::Wrap(video::ITexture* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew Texture(ref);
}

Texture::Texture(video::ITexture* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_Texture = ref;
	m_painter = nullptr;
}

void Texture::RegenerateMipMapLevels()
{
	m_Texture->regenerateMipMapLevels();
}

bool Texture::AlphaChannel::get()
{
	return m_Texture->hasAlpha();
}

Video::ColorFormat Texture::ColorFormat::get()
{
	return (Video::ColorFormat)m_Texture->getColorFormat();
}

Video::DriverType Texture::DriverType::get()
{
	return (Video::DriverType)m_Texture->getDriverType();
}

bool Texture::MipMaps::get()
{
	return m_Texture->hasMipMaps();
}

IO::NamedPath^ Texture::Name::get()
{
	return gcnew IO::NamedPath(m_Texture->getName());
}

Dimension2Di^ Texture::OriginalSize::get()
{
	return gcnew Dimension2Di(m_Texture->getOriginalSize());
}

TexturePainter^ Texture::Painter::get()
{
	if (m_painter == nullptr)
		m_painter = gcnew TexturePainter(this);

	return m_painter;
}

int Texture::Pitch::get()
{
	return m_Texture->getPitch();
}

bool Texture::RenderTarget::get()
{
	return m_Texture->isRenderTarget();
}

Dimension2Di^ Texture::Size::get()
{
	return gcnew Dimension2Di(m_Texture->getSize());
}

String^ Texture::ToString()
{
	return String::Format("Texture: Name={0}; Size={1}; ColorFormat={2}", Name->Path, Size, ColorFormat);
}

} // end namespace Video
} // end namespace IrrlichtLime