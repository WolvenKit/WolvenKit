#include "stdafx.h"
#include "Material.h"
#include "MaterialLayer.h"
#include "Texture.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video {

Material^ Material::Wrap(video::SMaterial* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew Material(ref);
}

Material::Material(video::SMaterial* ref)
	: Lime::NativeValue<video::SMaterial>(false)
{
	LIME_ASSERT(ref != nullptr);
	m_NativeValue = ref;
}

Material::Material(const video::SMaterial& copy)
	: Lime::NativeValue<video::SMaterial>(true)
{
	m_NativeValue = new video::SMaterial(copy);
}

Material::Material()
	: Lime::NativeValue<video::SMaterial>(true)
{
	m_NativeValue = new video::SMaterial();
}

Material::Material(Material^ other)
	: Lime::NativeValue<video::SMaterial>(true)
{
	LIME_ASSERT(other != nullptr);
	m_NativeValue = new video::SMaterial(*other->m_NativeValue);
}

bool Material::GetFlag(MaterialFlag flag)
{
	return m_NativeValue->getFlag((E_MATERIAL_FLAG)flag);
}

Texture^ Material::GetTexture(int index)
{
	LIME_ASSERT(index >= 0 && index < Material::MaxTextures);

	video::ITexture* t = m_NativeValue->getTexture(index);
	return Texture::Wrap(t);
}

Matrix^ Material::GetTextureMatrix(int index)
{
	LIME_ASSERT(index >= 0 && index < Material::MaxTextures);
	return gcnew Matrix(m_NativeValue->getTextureMatrix(index));
}

void Material::SetFlag(MaterialFlag flag, bool value)
{
	m_NativeValue->setFlag((E_MATERIAL_FLAG)flag, value);
}

void Material::SetTexture(int index, Texture^ tex)
{
	LIME_ASSERT(index >= 0 && index < Material::MaxTextures);
	m_NativeValue->setTexture(index, LIME_SAFEREF(tex, m_Texture));
}

void Material::SetTextureMatrix(int index, Matrix^ mat)
{
	LIME_ASSERT(index >= 0 && index < Material::MaxTextures);
	LIME_ASSERT(mat != nullptr);

	m_NativeValue->setTextureMatrix(index, *mat->m_NativeValue);
}

List<MaterialLayer^>^ Material::Layer::get()
{
	List<MaterialLayer^>^ l = gcnew List<MaterialLayer^>();

	for (int i = 0; i < Material::MaxTextures; i++)
		l->Add(gcnew MaterialLayer(&m_NativeValue->TextureLayer[i]));

	return l;
}

Video::MaterialType Material::Type::get()
{
	return (Video::MaterialType)m_NativeValue->MaterialType;
}

void Material::Type::set(Video::MaterialType value)
{
	LIME_ASSERT((int)value != -1); // this assert specially for
	// VideoDriver::AddMaterialRenderer() and GPUProgrammingServices::Add*()
	// as they all return "-1" on error

	m_NativeValue->MaterialType = (video::E_MATERIAL_TYPE)value;
}

Color^ Material::AmbientColor::get()
{
	return gcnew Color(m_NativeValue->AmbientColor);
}

void Material::AmbientColor::set(Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->AmbientColor = *value->m_NativeValue;
}

Video::BlendOperation Material::BlendOperation::get()
{
	return (Video::BlendOperation)m_NativeValue->BlendOperation;
}

void Material::BlendOperation::set(Video::BlendOperation value)
{
	m_NativeValue->BlendOperation = (video::E_BLEND_OPERATION)value;
}

Color^ Material::DiffuseColor::get()
{
	return gcnew Color(m_NativeValue->DiffuseColor);
}
void Material::DiffuseColor::set(Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->DiffuseColor = *value->m_NativeValue;
}

Color^ Material::EmissiveColor::get()
{
	return gcnew Color(m_NativeValue->EmissiveColor);
}
void Material::EmissiveColor::set(Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->EmissiveColor = *value->m_NativeValue;
}

Color^ Material::SpecularColor::get()
{
	return gcnew Color(m_NativeValue->SpecularColor);
}

void Material::SpecularColor::set(Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_NativeValue->SpecularColor = *value->m_NativeValue;
}

float Material::Shininess::get()
{
	return m_NativeValue->Shininess;
}

void Material::Shininess::set(float value)
{
	m_NativeValue->Shininess = value;
}

float Material::MaterialTypeParam::get()
{
	return m_NativeValue->MaterialTypeParam;
}

void Material::MaterialTypeParam::set(float value)
{
	m_NativeValue->MaterialTypeParam = value;
}

float Material::MaterialTypeParam2::get()
{
	return m_NativeValue->MaterialTypeParam2;
}

void Material::MaterialTypeParam2::set(float value)
{
	m_NativeValue->MaterialTypeParam2 = value;
}

float Material::Thickness::get()
{
	return m_NativeValue->Thickness;
}

void Material::Thickness::set(float value)
{
	m_NativeValue->Thickness = value;
}

ComparisonFunc Material::ZBuffer::get()
{
	return (ComparisonFunc)m_NativeValue->ZBuffer;
}

void Material::ZBuffer::set(ComparisonFunc value)
{
	m_NativeValue->ZBuffer = (irr::u8)(E_COMPARISON_FUNC)value;
}

AntiAliasingMode Material::AntiAliasing::get()
{
	return (AntiAliasingMode)m_NativeValue->AntiAliasing;
}

void Material::AntiAliasing::set(AntiAliasingMode value)
{
	m_NativeValue->AntiAliasing = (irr::u8)(E_ANTI_ALIASING_MODE)value;
}

ColorPlane Material::ColorMask::get()
{
	return (ColorPlane)m_NativeValue->ColorMask;
}

void Material::ColorMask::set(ColorPlane value)
{
	m_NativeValue->ColorMask = (E_COLOR_PLANE)value;
}

Video::ColorMaterial Material::ColorMaterial::get()
{
	return (Video::ColorMaterial)m_NativeValue->ColorMaterial;
}

void Material::ColorMaterial::set(Video::ColorMaterial value)
{
	m_NativeValue->ColorMaterial = (E_COLOR_PLANE)value;
}

f32 Material::PolygonOffsetDepthBias::get()
{
	return m_NativeValue->PolygonOffsetDepthBias;
}

void Material::PolygonOffsetDepthBias::set(f32 value)
{
	m_NativeValue->PolygonOffsetDepthBias = value;
}

f32 Material::PolygonOffsetSlopeScale::get()
{
	return m_NativeValue->PolygonOffsetSlopeScale;
}

void Material::PolygonOffsetSlopeScale::set(f32 value)
{
	m_NativeValue->PolygonOffsetSlopeScale = value;
}

bool Material::Wireframe::get()
{
	return m_NativeValue->Wireframe;
}

void Material::Wireframe::set(bool value)
{
	m_NativeValue->Wireframe = value;
}

bool Material::PointCloud::get()
{
	return m_NativeValue->PointCloud;
}

void Material::PointCloud::set(bool value)
{
	m_NativeValue->PointCloud = value;
}

bool Material::GouraudShading::get()
{
	return m_NativeValue->GouraudShading;
}

void Material::GouraudShading::set(bool value)
{
	m_NativeValue->GouraudShading = value;
}

bool Material::Lighting::get()
{
	return m_NativeValue->Lighting;
}

void Material::Lighting::set(bool value)
{
	m_NativeValue->Lighting = value;
}

bool Material::ZWrite::get()
{
	return m_NativeValue->ZWriteEnable;
}

void Material::ZWrite::set(bool value)
{
	m_NativeValue->ZWriteEnable = value;
}

bool Material::ZWriteFineControl::get()
{
	return m_NativeValue->ZWriteFineControl;
}

void Material::ZWriteFineControl::set(bool value)
{
	m_NativeValue->ZWriteFineControl = (video::E_ZWRITE_FINE_CONTROL)(value ? 1 : 0);
}

bool Material::BackfaceCulling::get()
{
	return m_NativeValue->BackfaceCulling;
}

void Material::BackfaceCulling::set(bool value)
{
	m_NativeValue->BackfaceCulling = value;
}

bool Material::FrontfaceCulling::get()
{
	return m_NativeValue->FrontfaceCulling;
}

void Material::FrontfaceCulling::set(bool value)
{
	m_NativeValue->FrontfaceCulling = value;
}

bool Material::Fog::get()
{
	return m_NativeValue->FogEnable;
}

void Material::Fog::set(bool value)
{
	m_NativeValue->FogEnable = value;
}

bool Material::NormalizeNormals::get()
{
	return m_NativeValue->NormalizeNormals;
}

void Material::NormalizeNormals::set(bool value)
{
	m_NativeValue->NormalizeNormals = value;
}

bool Material::Mipmaps::get()
{
	return m_NativeValue->UseMipMaps;
}

void Material::Mipmaps::set(bool value)
{
	m_NativeValue->UseMipMaps = value;
}

bool Material::Transparent::get()
{
	return m_NativeValue->isTransparent();
}

String^ Material::ToString()
{
	return String::Format("Material: Type={0}", Type);
}

} // end namespace Video
} // end namespace IrrlichtLime
