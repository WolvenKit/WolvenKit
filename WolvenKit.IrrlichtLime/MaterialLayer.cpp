#include "stdafx.h"
#include "MaterialLayer.h"
#include "Texture.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video {

MaterialLayer::MaterialLayer(video::SMaterialLayer* ref)
	: Lime::NativeValue<video::SMaterialLayer>(false)
{
	LIME_ASSERT(ref != nullptr);
	m_NativeValue = ref;
}

MaterialLayer::MaterialLayer()
	: Lime::NativeValue<video::SMaterialLayer>(true)
{
	m_NativeValue = new video::SMaterialLayer();
}

unsigned __int8 MaterialLayer::AnisotropicFilter::get()
{
	return m_NativeValue->AnisotropicFilter;
}

void MaterialLayer::AnisotropicFilter::set(unsigned __int8 value)
{
	m_NativeValue->AnisotropicFilter = value;
}

bool MaterialLayer::BilinearFilter::get()
{
	return m_NativeValue->BilinearFilter;
}

void MaterialLayer::BilinearFilter::set(bool value)
{
	m_NativeValue->BilinearFilter = value;
}

__int8 MaterialLayer::LODBias::get()
{
	return m_NativeValue->LODBias;
}

void MaterialLayer::LODBias::set(__int8 value)
{
	m_NativeValue->LODBias = value;
}

Video::Texture^ MaterialLayer::Texture::get()
{
	return Video::Texture::Wrap(m_NativeValue->Texture);
}

void MaterialLayer::Texture::set(Video::Texture^ value)
{
	m_NativeValue->Texture = LIME_SAFEREF(value, m_Texture);
}

Matrix^ MaterialLayer::TextureMatrix::get()
{
	return gcnew Matrix(m_NativeValue->getTextureMatrix());
}

void MaterialLayer::TextureMatrix::set(Matrix^ value)
{
	m_NativeValue->setTextureMatrix(*value->m_NativeValue);
}

TextureClamp MaterialLayer::TextureWrapU::get()
{
	return (TextureClamp)m_NativeValue->TextureWrapU;
}

void MaterialLayer::TextureWrapU::set(TextureClamp value)
{
	m_NativeValue->TextureWrapU = (video::E_TEXTURE_CLAMP)value;
}

TextureClamp MaterialLayer::TextureWrapV::get()
{
	return (TextureClamp)m_NativeValue->TextureWrapV;
}

void MaterialLayer::TextureWrapV::set(TextureClamp value)
{
	m_NativeValue->TextureWrapV = (video::E_TEXTURE_CLAMP)value;
}

bool MaterialLayer::TrilinearFilter::get()
{
	return m_NativeValue->TrilinearFilter;
}

void MaterialLayer::TrilinearFilter::set(bool value)
{
	m_NativeValue->TrilinearFilter = value;
}

String^ MaterialLayer::ToString()
{
	return String::Format("MaterialLayer: AnisotropicFilter={0}; BilinearFilter={1}; TrilinearFilter={2}",
		AnisotropicFilter, BilinearFilter, TrilinearFilter);
}

} // end namespace Video
} // end namespace IrrlichtLime