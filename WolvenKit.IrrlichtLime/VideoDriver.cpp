#include "stdafx.h"
#include "Attributes.h"
#include "GPUProgrammingServices.h"
#include "Image.h"
#include "ImageLoader.h"
#include "IndexBuffer.h"
#include "Light.h"
#include "Material.h"
#include "MaterialRenderer.h"
#include "Mesh.h"
#include "MeshBuffer.h"
#include "MeshManipulator.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"
#include "SceneNode.h"
#include "Texture.h"
#include "VertexBuffer.h"
#include "VideoDriver.h"
#include "WriteFile.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

VideoDriver^ VideoDriver::Wrap(video::IVideoDriver* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew VideoDriver(ref);
}

VideoDriver::VideoDriver(video::IVideoDriver* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_VideoDriver = ref;
}

int VideoDriver::AddDynamicLight(Light^ light)
{
	LIME_ASSERT(DynamicLightCount + 1 < MaxDynamicLightCount);
	LIME_ASSERT(light != nullptr);

	return m_VideoDriver->addDynamicLight(*light->m_NativeValue);
}

MaterialType VideoDriver::AddMaterialRenderer(MaterialRenderer^ renderer, String^ name)
{
	return (MaterialType)m_VideoDriver->addMaterialRenderer(
		LIME_SAFEREF(renderer, m_MaterialRenderer),
		LIME_SAFESTRINGTOSTRINGC_C_STR(name));
}

MaterialType VideoDriver::AddMaterialRenderer(MaterialRenderer^ renderer)
{
	return (MaterialType)m_VideoDriver->addMaterialRenderer(
		LIME_SAFEREF(renderer, m_MaterialRenderer));
}

void VideoDriver::AddOcclusionQuery(Scene::SceneNode^ node, Scene::Mesh^ mesh)
{
	m_VideoDriver->addOcclusionQuery(LIME_SAFEREF(node, m_SceneNode), LIME_SAFEREF(mesh, m_Mesh));
}

void VideoDriver::AddOcclusionQuery(Scene::SceneNode^ node)
{
	m_VideoDriver->addOcclusionQuery(LIME_SAFEREF(node, m_SceneNode));
}

Texture^ VideoDriver::AddRenderTargetTexture(Dimension2Di^ size, String^ name, Video::ColorFormat format)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width >= 0);
	LIME_ASSERT(size->Height >= 0);
	LIME_ASSERT(name != nullptr);

	video::ITexture* t = m_VideoDriver->addRenderTargetTexture(
		(core::dimension2du&) *size->m_NativeValue,
		Lime::StringToPath(name),
		(video::ECOLOR_FORMAT) format);

	return Texture::Wrap(t);
}

Texture^ VideoDriver::AddRenderTargetTexture(Dimension2Di^ size, String^ name)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width >= 0);
	LIME_ASSERT(size->Height >= 0);
	LIME_ASSERT(name != nullptr);

	video::ITexture* t = m_VideoDriver->addRenderTargetTexture(
		(core::dimension2du&) *size->m_NativeValue,
		Lime::StringToPath(name));

	return Texture::Wrap(t);
}

Texture^ VideoDriver::AddRenderTargetTexture(Dimension2Di^ size)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width >= 0);
	LIME_ASSERT(size->Height >= 0);

	video::ITexture* t = m_VideoDriver->addRenderTargetTexture((core::dimension2du&)*size->m_NativeValue);
	return Texture::Wrap(t);
}

Texture^ VideoDriver::AddTexture(Dimension2Di^ size, String^ name, Video::ColorFormat format)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width >= 0);
	LIME_ASSERT(size->Height >= 0);
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(name->Length > 0);

	video::ITexture* t = m_VideoDriver->addTexture(
		(core::dimension2du&) *size->m_NativeValue,
		Lime::StringToPath(name),
		(video::ECOLOR_FORMAT) format);

	return Texture::Wrap(t);
}

Texture^ VideoDriver::AddTexture(Dimension2Di^ size, String^ name)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width >= 0);
	LIME_ASSERT(size->Height >= 0);
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(name->Length > 0);

	video::ITexture* t = m_VideoDriver->addTexture(
		(core::dimension2du&) *size->m_NativeValue,
		Lime::StringToPath(name));

	return Texture::Wrap(t);
}

Texture^ VideoDriver::AddTexture(String^ name, Image^ image)
{
	LIME_ASSERT(name != nullptr);

	video::ITexture* t = m_VideoDriver->addTexture(Lime::StringToPath(name), LIME_SAFEREF(image, m_Image));
	return Texture::Wrap(t);
}

bool VideoDriver::BeginScene(ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth, u8 clearStencil, Video::ExposedVideoData^ videoData, Recti^ sourceRect)
{
	return m_VideoDriver->beginScene(
		(u16)clearFlag,
		LIME_SAFEVAL(clearColor, SColor(255, 0, 0, 0)),
		clearDepth,
		clearStencil,
		LIME_SAFEVAL(videoData, SExposedVideoData()),
		LIME_SAFEREF(sourceRect, m_NativeValue));
}

bool VideoDriver::BeginScene(ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth, u8 clearStencil, Video::ExposedVideoData^ videoData)
{
	return m_VideoDriver->beginScene(
		(u16)clearFlag,
		LIME_SAFEVAL(clearColor, SColor(255, 0, 0, 0)),
		clearDepth,
		clearStencil,
		LIME_SAFEVAL(videoData, SExposedVideoData()));
}

bool VideoDriver::BeginScene(ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth, u8 clearStencil)
{
	return m_VideoDriver->beginScene(
		(u16)clearFlag,
		LIME_SAFEVAL(clearColor, SColor(255, 0, 0, 0)),
		clearDepth,
		clearStencil);
}

bool VideoDriver::BeginScene(ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth)
{
	return m_VideoDriver->beginScene(
		(u16)clearFlag,
		LIME_SAFEVAL(clearColor, SColor(255, 0, 0, 0)),
		clearDepth);
}

bool VideoDriver::BeginScene(ClearBufferFlag clearFlag, Color^ clearColor)
{
	return m_VideoDriver->beginScene(
		(u16)clearFlag,
		LIME_SAFEVAL(clearColor, SColor(255, 0, 0, 0)));
}

bool VideoDriver::BeginScene(ClearBufferFlag clearFlag)
{
	return m_VideoDriver->beginScene(
		(u16)clearFlag);
}

bool VideoDriver::BeginScene()
{
	return m_VideoDriver->beginScene();
}

bool VideoDriver::CheckDriverReset()
{
	return m_VideoDriver->checkDriverReset();
}

// TODO: flag should cast to video::E_CLEAR_BUFFER_FLAG; now gives warning
// TODO: add assert for depth range
void VideoDriver::ClearBuffers(ClearBufferFlag flag, Color^ color, f32 depth, u8 stencil)
{
	LIME_ASSERT(color != nullptr);
	m_VideoDriver->clearBuffers((u16) flag, *color->m_NativeValue, depth, stencil);
}

void VideoDriver::ClearBuffers(ClearBufferFlag flag, Color^ color, f32 depth)
{
	LIME_ASSERT(color != nullptr);
	m_VideoDriver->clearBuffers((u16) flag, *color->m_NativeValue, depth);
}

void VideoDriver::ClearBuffers(ClearBufferFlag flag, Color^ color)
{
	LIME_ASSERT(color != nullptr);
	m_VideoDriver->clearBuffers((u16) flag, *color->m_NativeValue);
}

void VideoDriver::ClearBuffers(ClearBufferFlag flag)
{
	m_VideoDriver->clearBuffers((u16) flag);
}

IO::Attributes^ VideoDriver::CreateAttributesFromMaterial(Material^ material)
{
	LIME_ASSERT(material != nullptr);

	io::IAttributes* a = m_VideoDriver->createAttributesFromMaterial(*material->m_NativeValue);
	return IO::Attributes::Wrap(a);
}

IO::Attributes^ VideoDriver::CreateAttributesFromMaterial(Material^ material, IO::AttributeReadWriteOptions^ options)
{
	LIME_ASSERT(material != nullptr);

	io::SAttributeReadWriteOptions* o = IO::AttributeReadWriteOptions::Allocate_SAttributeReadWriteOptions(options);
	io::IAttributes* a = m_VideoDriver->createAttributesFromMaterial(*material->m_NativeValue, o);
	IO::AttributeReadWriteOptions::Free_SAttributeReadWriteOptions(o);

	return IO::Attributes::Wrap(a);
}

Image^ VideoDriver::CreateImage(Texture^ texture, Vector2Di^ pos, Dimension2Di^ size)
{
	LIME_ASSERT(pos != nullptr);
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width > 0);
	LIME_ASSERT(size->Height > 0);

	video::IImage* i = m_VideoDriver->createImage(
		LIME_SAFEREF(texture, m_Texture),
		*pos->m_NativeValue,
		(core::dimension2du&)*size->m_NativeValue);

	return Image::Wrap(i);
}

Image^ VideoDriver::CreateImage(Texture^ texture)
{
	LIME_ASSERT(texture != nullptr);

	video::IImage* i = m_VideoDriver->createImage(
		LIME_SAFEREF(texture, m_Texture),
		core::vector2di(),
		(core::dimension2du&)*texture->Size->m_NativeValue);

	return Image::Wrap(i);
}

Image^ VideoDriver::CreateUncompressedImage(Texture^ texture)
{
    LIME_ASSERT(texture != nullptr);

    video::IImage* i = m_VideoDriver->createUncompressedImage(
        LIME_SAFEREF(texture, m_Texture),
        core::vector2di(),
        (core::dimension2du&) * texture->Size->m_NativeValue);

    return Image::Wrap(i);
}

Image^ VideoDriver::CreateImage(Video::ColorFormat format, Dimension2Di^ size)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width > 0);
	LIME_ASSERT(size->Height > 0);

	video::IImage* i = m_VideoDriver->createImage(
		(video::ECOLOR_FORMAT)format,
		(core::dimension2du&)*size->m_NativeValue);

	return Image::Wrap(i);
}

Image^ VideoDriver::CreateImage(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	video::IImage* i = m_VideoDriver->createImageFromFile(Lime::StringToPath(filename));
	return Image::Wrap(i);
}

Image^ VideoDriver::CreateImage(IO::ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);

	video::IImage* i = m_VideoDriver->createImageFromFile(LIME_SAFEREF(file, m_ReadFile));
	return Image::Wrap(i);
}

Image^ VideoDriver::CreateScreenShot()
{
	video::IImage* i = m_VideoDriver->createScreenShot();
	return Image::Wrap(i);
}

Image^ VideoDriver::CreateScreenShot(Video::ColorFormat format)
{
	video::IImage* i = m_VideoDriver->createScreenShot(
		(video::ECOLOR_FORMAT)format);

	return Image::Wrap(i);
}

Image^ VideoDriver::CreateScreenShot(Video::ColorFormat format, Video::RenderTarget target)
{
	video::IImage* i = m_VideoDriver->createScreenShot(
		(video::ECOLOR_FORMAT)format,
		(video::E_RENDER_TARGET)target);

	return Image::Wrap(i);
}

void VideoDriver::DeleteAllDynamicLights()
{
	m_VideoDriver->deleteAllDynamicLights();
}

void VideoDriver::DisableFeature(VideoDriverFeature feature, bool flag)
{
	m_VideoDriver->disableFeature((video::E_VIDEO_DRIVER_FEATURE)feature, flag);
}

void VideoDriver::DisableFeature(VideoDriverFeature feature)
{
	m_VideoDriver->disableFeature((video::E_VIDEO_DRIVER_FEATURE)feature);
}

void VideoDriver::Draw2DImage(Texture^ texture, Recti^ destRect, Recti^ sourceRect, Recti^ clipRect, List<Color^>^ colors, bool useAlphaChannelOfTexture)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(destRect != nullptr);
	LIME_ASSERT(sourceRect != nullptr);

	video::SColor* colorList = nullptr;
	if (colors != nullptr)
	{
		LIME_ASSERT(colors->Count == 4);
		colorList = new video::SColor[4];
		for (int i = 0; i < 4; i++)
			colorList[i] = *colors[i]->m_NativeValue;
	}

	m_VideoDriver->draw2DImage(
		texture->m_Texture,
		*destRect->m_NativeValue,
		*sourceRect->m_NativeValue,
		LIME_SAFEREF(clipRect, m_NativeValue),
		colorList,
		useAlphaChannelOfTexture);

	if (colorList != nullptr)
		delete[] colorList;
}

void VideoDriver::Draw2DImage(Texture^ texture, Recti^ destRect, Recti^ sourceRect, Recti^ clipRect, List<Color^>^ colors)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(destRect != nullptr);
	LIME_ASSERT(sourceRect != nullptr);

	video::SColor* colorList = nullptr;
	if (colors != nullptr)
	{
		LIME_ASSERT(colors->Count == 4);
		colorList = new video::SColor[4];
		for (int i = 0; i < 4; i++)
			colorList[i] = *colors[i]->m_NativeValue;
	}

	m_VideoDriver->draw2DImage(
		texture->m_Texture,
		*destRect->m_NativeValue,
		*sourceRect->m_NativeValue,
		LIME_SAFEREF(clipRect, m_NativeValue),
		colorList);

	if (colorList != nullptr)
		delete[] colorList;
}

void VideoDriver::Draw2DImage(Texture^ texture, Recti^ destRect, Recti^ sourceRect, Recti^ clipRect)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(destRect != nullptr);
	LIME_ASSERT(sourceRect != nullptr);

	m_VideoDriver->draw2DImage(
		texture->m_Texture,
		*destRect->m_NativeValue,
		*sourceRect->m_NativeValue,
		LIME_SAFEREF(clipRect, m_NativeValue));
}

void VideoDriver::Draw2DImage(Texture^ texture, Recti^ destRect, Recti^ sourceRect)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(destRect != nullptr);
	LIME_ASSERT(sourceRect != nullptr);

	m_VideoDriver->draw2DImage(
		texture->m_Texture,
		*destRect->m_NativeValue,
		*sourceRect->m_NativeValue);
}

void VideoDriver::Draw2DImage(Texture^ texture, Vector2Di^ destPos, Recti^ sourceRect, Recti^ clipRect, Color^ color, bool useAlphaChannelOfTexture)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(destPos != nullptr);
	LIME_ASSERT(sourceRect != nullptr);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw2DImage(
		texture->m_Texture,
		*destPos->m_NativeValue,
		*sourceRect->m_NativeValue,
		LIME_SAFEREF(clipRect, m_NativeValue),
		*color->m_NativeValue,
		useAlphaChannelOfTexture);
}

void VideoDriver::Draw2DImage(Texture^ texture, Vector2Di^ destPos, Recti^ sourceRect, Recti^ clipRect, Color^ color)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(destPos != nullptr);
	LIME_ASSERT(sourceRect != nullptr);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw2DImage(
		texture->m_Texture,
		*destPos->m_NativeValue,
		*sourceRect->m_NativeValue,
		LIME_SAFEREF(clipRect, m_NativeValue),
		*color->m_NativeValue);
}

void VideoDriver::Draw2DImage(Texture^ texture, Vector2Di^ destPos, Recti^ sourceRect, Recti^ clipRect)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(destPos != nullptr);
	LIME_ASSERT(sourceRect != nullptr);

	m_VideoDriver->draw2DImage(
		texture->m_Texture,
		*destPos->m_NativeValue,
		*sourceRect->m_NativeValue,
		LIME_SAFEREF(clipRect, m_NativeValue));
}

void VideoDriver::Draw2DImage(Texture^ texture, Vector2Di^ destPos, Recti^ sourceRect)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(destPos != nullptr);
	LIME_ASSERT(sourceRect != nullptr);

	m_VideoDriver->draw2DImage(
		texture->m_Texture,
		*destPos->m_NativeValue,
		*sourceRect->m_NativeValue);
}

void VideoDriver::Draw2DImage(Texture^ texture, Vector2Di^ destPos)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(destPos != nullptr);

	m_VideoDriver->draw2DImage(
		texture->m_Texture,
		*destPos->m_NativeValue);
}

void VideoDriver::Draw2DImageBatch(Texture^ texture, List<Vector2Di^>^ positions, List<Recti^>^ sourceRects, Recti^ clipRect,
	Color^ color, bool useAlphaChannelOfTexture)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(positions != nullptr);
	LIME_ASSERT(positions->Count > 0);
	LIME_ASSERT(sourceRects != nullptr);
	LIME_ASSERT(sourceRects->Count > 0);
	LIME_ASSERT(positions->Count == sourceRects->Count);
	LIME_ASSERT(color != nullptr);

	core::array<core::vector2di> p;
	for (int i = 0; i < positions->Count; i++)
	{
		LIME_ASSERT(positions[i] != nullptr);
		p.push_back(*positions[i]->m_NativeValue);
	}

	core::array<core::recti> s;
	for (int i = 0; i < sourceRects->Count; i++)
	{
		LIME_ASSERT(sourceRects[i] != nullptr);
		s.push_back(*sourceRects[i]->m_NativeValue);
	}

	m_VideoDriver->draw2DImageBatch(
		texture->m_Texture,
		p,
		s,
		LIME_SAFEREF(clipRect, m_NativeValue),
		*color->m_NativeValue,
		useAlphaChannelOfTexture);
}

void VideoDriver::Draw2DImageBatch(Texture^ texture, List<Vector2Di^>^ positions, List<Recti^>^ sourceRects, Recti^ clipRect,
	Color^ color)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(positions != nullptr);
	LIME_ASSERT(positions->Count > 0);
	LIME_ASSERT(sourceRects != nullptr);
	LIME_ASSERT(sourceRects->Count > 0);
	LIME_ASSERT(positions->Count == sourceRects->Count);
	LIME_ASSERT(color != nullptr);

	core::array<core::vector2di> p;
	for (int i = 0; i < positions->Count; i++)
	{
		LIME_ASSERT(positions[i] != nullptr);
		p.push_back(*positions[i]->m_NativeValue);
	}

	core::array<core::recti> s;
	for (int i = 0; i < sourceRects->Count; i++)
	{
		LIME_ASSERT(sourceRects[i] != nullptr);
		s.push_back(*sourceRects[i]->m_NativeValue);
	}

	m_VideoDriver->draw2DImageBatch(
		texture->m_Texture,
		p,
		s,
		LIME_SAFEREF(clipRect, m_NativeValue),
		*color->m_NativeValue);
}

void VideoDriver::Draw2DImageBatch(Texture^ texture, List<Vector2Di^>^ positions, List<Recti^>^ sourceRects, Recti^ clipRect)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(positions != nullptr);
	LIME_ASSERT(positions->Count > 0);
	LIME_ASSERT(sourceRects != nullptr);
	LIME_ASSERT(sourceRects->Count > 0);
	LIME_ASSERT(positions->Count == sourceRects->Count);

	core::array<core::vector2di> p;
	for (int i = 0; i < positions->Count; i++)
	{
		LIME_ASSERT(positions[i] != nullptr);
		p.push_back(*positions[i]->m_NativeValue);
	}

	core::array<core::recti> s;
	for (int i = 0; i < sourceRects->Count; i++)
	{
		LIME_ASSERT(sourceRects[i] != nullptr);
		s.push_back(*sourceRects[i]->m_NativeValue);
	}

	m_VideoDriver->draw2DImageBatch(
		texture->m_Texture,
		p,
		s,
		LIME_SAFEREF(clipRect, m_NativeValue));
}

void VideoDriver::Draw2DImageBatch(Texture^ texture, List<Vector2Di^>^ positions, List<Recti^>^ sourceRects)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(positions != nullptr);
	LIME_ASSERT(positions->Count > 0);
	LIME_ASSERT(sourceRects != nullptr);
	LIME_ASSERT(sourceRects->Count > 0);
	LIME_ASSERT(positions->Count == sourceRects->Count);

	core::array<core::vector2di> p;
	for (int i = 0; i < positions->Count; i++)
	{
		LIME_ASSERT(positions[i] != nullptr);
		p.push_back(*positions[i]->m_NativeValue);
	}

	core::array<core::recti> s;
	for (int i = 0; i < sourceRects->Count; i++)
	{
		LIME_ASSERT(sourceRects[i] != nullptr);
		s.push_back(*sourceRects[i]->m_NativeValue);
	}

	m_VideoDriver->draw2DImageBatch(
		texture->m_Texture,
		p,
		s);
}

void VideoDriver::Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices,
	int kerningWidth, Recti^ clipRect, Color^ color, bool useAlphaChannelOfTexture)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(sourceRects != nullptr);
	LIME_ASSERT(sourceRects->Count > 0);
	LIME_ASSERT(indices != nullptr);
	LIME_ASSERT(indices->Count > 0);
	LIME_ASSERT(color != nullptr);

	int sc = sourceRects->Count;

	core::array<core::recti> s;
	for (int i = 0; i < sc; i++)
	{
		LIME_ASSERT(sourceRects[i] != nullptr);
		s.push_back(*sourceRects[i]->m_NativeValue);
	}

	core::array<s32> j;
	for (int i = 0; i < indices->Count; i++)
	{
		LIME_ASSERT(indices[i] < sc);
		j.push_back(indices[i]);
	}

	m_VideoDriver->draw2DImageBatch(
		texture->m_Texture,
		*position->m_NativeValue,
		s,
		j,
		kerningWidth,
		LIME_SAFEREF(clipRect, m_NativeValue),
		*color->m_NativeValue,
		useAlphaChannelOfTexture);
}

void VideoDriver::Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices,
	int kerningWidth, Recti^ clipRect, Color^ color)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(sourceRects != nullptr);
	LIME_ASSERT(sourceRects->Count > 0);
	LIME_ASSERT(indices != nullptr);
	LIME_ASSERT(indices->Count > 0);
	LIME_ASSERT(color != nullptr);

	int sc = sourceRects->Count;

	core::array<core::recti> s;
	for (int i = 0; i < sc; i++)
	{
		LIME_ASSERT(sourceRects[i] != nullptr);
		s.push_back(*sourceRects[i]->m_NativeValue);
	}

	core::array<s32> j;
	for (int i = 0; i < indices->Count; i++)
	{
		LIME_ASSERT(indices[i] < sc);
		j.push_back(indices[i]);
	}

	m_VideoDriver->draw2DImageBatch(
		texture->m_Texture,
		*position->m_NativeValue,
		s,
		j,
		kerningWidth,
		LIME_SAFEREF(clipRect, m_NativeValue),
		*color->m_NativeValue);
}

void VideoDriver::Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices,
	int kerningWidth, Recti^ clipRect)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(sourceRects != nullptr);
	LIME_ASSERT(sourceRects->Count > 0);
	LIME_ASSERT(indices != nullptr);
	LIME_ASSERT(indices->Count > 0);

	int sc = sourceRects->Count;

	core::array<core::recti> s;
	for (int i = 0; i < sc; i++)
	{
		LIME_ASSERT(sourceRects[i] != nullptr);
		s.push_back(*sourceRects[i]->m_NativeValue);
	}

	core::array<s32> j;
	for (int i = 0; i < indices->Count; i++)
	{
		LIME_ASSERT(indices[i] < sc);
		j.push_back(indices[i]);
	}

	m_VideoDriver->draw2DImageBatch(
		texture->m_Texture,
		*position->m_NativeValue,
		s,
		j,
		kerningWidth,
		LIME_SAFEREF(clipRect, m_NativeValue));
}

void VideoDriver::Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices,
	int kerningWidth)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(sourceRects != nullptr);
	LIME_ASSERT(sourceRects->Count > 0);
	LIME_ASSERT(indices != nullptr);
	LIME_ASSERT(indices->Count > 0);

	int sc = sourceRects->Count;

	core::array<core::recti> s;
	for (int i = 0; i < sc; i++)
	{
		LIME_ASSERT(sourceRects[i] != nullptr);
		s.push_back(*sourceRects[i]->m_NativeValue);
	}

	core::array<s32> j;
	for (int i = 0; i < indices->Count; i++)
	{
		LIME_ASSERT(indices[i] < sc);
		j.push_back(indices[i]);
	}

	m_VideoDriver->draw2DImageBatch(
		texture->m_Texture,
		*position->m_NativeValue,
		s,
		j,
		kerningWidth);
}

void VideoDriver::Draw2DImageBatch(Texture^ texture, Vector2Di^ position, List<Recti^>^ sourceRects, List<int>^ indices)
{
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(sourceRects != nullptr);
	LIME_ASSERT(sourceRects->Count > 0);
	LIME_ASSERT(indices != nullptr);
	LIME_ASSERT(indices->Count > 0);

	int sc = sourceRects->Count;

	core::array<core::recti> s;
	for (int i = 0; i < sc; i++)
	{
		LIME_ASSERT(sourceRects[i] != nullptr);
		s.push_back(*sourceRects[i]->m_NativeValue);
	}

	core::array<s32> j;
	for (int i = 0; i < indices->Count; i++)
	{
		LIME_ASSERT(indices[i] < sc);
		j.push_back(indices[i]);
	}

	m_VideoDriver->draw2DImageBatch(
		texture->m_Texture,
		*position->m_NativeValue,
		s,
		j);
}

void VideoDriver::Draw2DLine(int x1, int y1, int x2, int y2, Color^ color)
{
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw2DLine(
		core::vector2di(x1, y1),
		core::vector2di(x2, y2),
		*color->m_NativeValue);
}

void VideoDriver::Draw2DLine(Vector2Di^ start, Vector2Di^ end, Color^ color)
{
	LIME_ASSERT(start != nullptr);
	LIME_ASSERT(end != nullptr);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw2DLine(
		*start->m_NativeValue,
		*end->m_NativeValue,
		*color->m_NativeValue);
}

void VideoDriver::Draw2DPolygon(int x, int y, float radius, Color^ color, int vertexCount)
{
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(vertexCount >= 2);

	m_VideoDriver->draw2DPolygon(
		core::vector2di(x, y),
		radius,
		*color->m_NativeValue,
		vertexCount);
}

void VideoDriver::Draw2DPolygon(Vector2Di^ center, float radius, Color^ color, int vertexCount)
{
	LIME_ASSERT(center != nullptr);
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(vertexCount >= 2);

	m_VideoDriver->draw2DPolygon(
		*center->m_NativeValue,
		radius,
		*color->m_NativeValue,
		vertexCount);
}

void VideoDriver::Draw2DRectangle(Recti^ pos, Color^ colorLeftUp, Color^ colorRightUp, Color^ colorLeftDown, Color^ colorRightDown, Recti^ clip)
{
	LIME_ASSERT(pos != nullptr);
	LIME_ASSERT(colorLeftUp != nullptr);
	LIME_ASSERT(colorRightUp != nullptr);
	LIME_ASSERT(colorLeftDown != nullptr);
	LIME_ASSERT(colorRightDown != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_VideoDriver->draw2DRectangle(
		*pos->m_NativeValue,
		*colorLeftUp->m_NativeValue,
		*colorRightUp->m_NativeValue,
		*colorLeftDown->m_NativeValue,
		*colorRightDown->m_NativeValue,
		clip->m_NativeValue);
}

void VideoDriver::Draw2DRectangle(Recti^ pos, Color^ colorLeftUp, Color^ colorRightUp, Color^ colorLeftDown, Color^ colorRightDown)
{
	LIME_ASSERT(pos != nullptr);
	LIME_ASSERT(colorLeftUp != nullptr);
	LIME_ASSERT(colorRightUp != nullptr);
	LIME_ASSERT(colorLeftDown != nullptr);
	LIME_ASSERT(colorRightDown != nullptr);

	m_VideoDriver->draw2DRectangle(
		*pos->m_NativeValue,
		*colorLeftUp->m_NativeValue,
		*colorRightUp->m_NativeValue,
		*colorLeftDown->m_NativeValue,
		*colorRightDown->m_NativeValue);
}

void VideoDriver::Draw2DRectangle(Recti^ pos, Color^ color, Recti^ clip)
{
	LIME_ASSERT(pos != nullptr);
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(clip != nullptr);
	
	m_VideoDriver->draw2DRectangle(
		*color->m_NativeValue,
		*pos->m_NativeValue,
		clip->m_NativeValue);
}

void VideoDriver::Draw2DRectangle(Recti^ pos, Color^ color)
{
	LIME_ASSERT(pos != nullptr);
	LIME_ASSERT(color != nullptr);
	
	m_VideoDriver->draw2DRectangle(
		*color->m_NativeValue,
		*pos->m_NativeValue);
}

void VideoDriver::Draw2DRectangle(int x1, int y1, int x2, int y2, Color^ color)
{
	LIME_ASSERT(color != nullptr);
	
	m_VideoDriver->draw2DRectangle(
		*color->m_NativeValue,
		core::recti(x1, y1, x2, y2));
}

void VideoDriver::Draw2DRectangleOutline(Recti^ pos, Color^ color)
{
	LIME_ASSERT(pos != nullptr);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw2DRectangleOutline(
		*pos->m_NativeValue,
		*color->m_NativeValue);
}

void VideoDriver::Draw2DRectangleOutline(int x1, int y1, int x2, int y2, Color^ color)
{
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw2DRectangleOutline(
		core::recti(x1, y1, x2, y2),
		*color->m_NativeValue);
}

void VideoDriver::Draw2DVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned short>^ indices16bit, Scene::PrimitiveType pType)
{
	LIME_ASSERT(vertices != nullptr);
	LIME_ASSERT(vertices->Length <= 0xFFFF);
	LIME_ASSERT(indices16bit != nullptr);

	if (vertices->Length == 0 || indices16bit->Length == 0)
		return;

	unsigned int primCount = calculatePrimitiveCount(indices16bit->Length, pType);

	S3DVertex* vertexList = new S3DVertex[vertices->Length];
	for (int i = 0; i < vertices->Length; i++)
	{
		LIME_ASSERT(vertices[i] != nullptr);
		vertexList[i] = *vertices[i]->m_NativeValue;
	}

	u16* indexList = new u16[indices16bit->Length];
	Marshal::Copy((array<short>^)indices16bit, 0, IntPtr(indexList), indices16bit->Length);

	m_VideoDriver->draw2DVertexPrimitiveList(
		vertexList,
		vertices->Length,
		indexList,
		primCount,
		EVT_STANDARD,
		(scene::E_PRIMITIVE_TYPE)pType,
		EIT_16BIT);

	delete[] indexList;
	delete[] vertexList;
}

void VideoDriver::Draw2DVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned short>^ indices16bit)
{
	Draw2DVertexPrimitiveList(vertices, indices16bit, Scene::PrimitiveType::Triangles);
}

void VideoDriver::Draw2DVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned int>^ indices32bit, Scene::PrimitiveType pType)
{
	LIME_ASSERT(vertices != nullptr);
	LIME_ASSERT(indices32bit != nullptr);

	if (vertices->Length == 0 || indices32bit->Length == 0)
		return;

	unsigned int primCount = calculatePrimitiveCount(indices32bit->Length, pType);

	S3DVertex* vertexList = new S3DVertex[vertices->Length];
	for (int i = 0; i < vertices->Length; i++)
	{
		LIME_ASSERT(vertices[i] != nullptr);
		vertexList[i] = *vertices[i]->m_NativeValue;
	}

	u32* indexList = new u32[indices32bit->Length];
	Marshal::Copy((array<int>^)indices32bit, 0, IntPtr(indexList), indices32bit->Length);

	m_VideoDriver->draw2DVertexPrimitiveList(
		vertexList,
		vertices->Length,
		indexList,
		primCount,
		EVT_STANDARD,
		(scene::E_PRIMITIVE_TYPE)pType,
		EIT_32BIT);

	delete[] indexList;
	delete[] vertexList;
}

void VideoDriver::Draw2DVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned int>^ indices32bit)
{
	Draw2DVertexPrimitiveList(vertices, indices32bit, Scene::PrimitiveType::Triangles);
}

void VideoDriver::Draw2DVertexPrimitiveList(Scene::VertexBuffer^ vertexBuffer, Scene::IndexBuffer^ indexBuffer, Scene::PrimitiveType pType)
{
	LIME_ASSERT(vertexBuffer != nullptr);
	LIME_ASSERT(indexBuffer != nullptr);

	scene::IVertexBuffer* vb = vertexBuffer->m_VertexBuffer;
	scene::IIndexBuffer* ib = indexBuffer->m_IndexBuffer;

	if (vb->size() == 0 || ib->size() == 0)
		return;

	unsigned int primCount = calculatePrimitiveCount(ib->size(), pType);

	m_VideoDriver->draw2DVertexPrimitiveList(
		vb->pointer(),
		vb->size(),
		ib->pointer(),
		primCount,
		vb->getType(),
		(scene::E_PRIMITIVE_TYPE)pType,
		ib->getType());
}

void VideoDriver::Draw2DVertexPrimitiveList(Scene::VertexBuffer^ vertexBuffer, Scene::IndexBuffer^ indexBuffer)
{
	Draw2DVertexPrimitiveList(vertexBuffer, indexBuffer, Scene::PrimitiveType::Triangles);
}

void VideoDriver::Draw3DBox(AABBox^ box, Color^ color)
{
	LIME_ASSERT(box != nullptr);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw3DBox(
		*box->m_NativeValue,
		*color->m_NativeValue);
}

void VideoDriver::Draw3DLine(float x1, float y1, float z1, float x2, float y2, float z2, Color^ color)
{
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw3DLine(
		core::vector3df(x1, y1, z1),
		core::vector3df(x2, y2, z2),
		*color->m_NativeValue);
}

void VideoDriver::Draw3DLine(Vector3Df^ start, Vector3Df^ end, Color^ color)
{
	LIME_ASSERT(start != nullptr);
	LIME_ASSERT(end != nullptr);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw3DLine(
		*start->m_NativeValue,
		*end->m_NativeValue,
		*color->m_NativeValue);
}

void VideoDriver::Draw3DLine(Line3Df^ line, Color^ color)
{
	LIME_ASSERT(line != nullptr);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw3DLine(
		line->m_NativeValue->start,
		line->m_NativeValue->end,
		*color->m_NativeValue);
}

void VideoDriver::Draw3DTriangle(Vector3Df^ pointA, Vector3Df^ pointB, Vector3Df^ pointC, Color^ color)
{
	LIME_ASSERT(pointA != nullptr);
	LIME_ASSERT(pointB != nullptr);
	LIME_ASSERT(pointC != nullptr);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw3DTriangle(
		core::triangle3df(*pointA->m_NativeValue, *pointB->m_NativeValue, *pointC->m_NativeValue),
		*color->m_NativeValue);
}

void VideoDriver::Draw3DTriangle(Triangle3Df^ triangle, Color^ color)
{
	LIME_ASSERT(triangle != nullptr);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->draw3DTriangle(
		*triangle->m_NativeValue,
		*color->m_NativeValue);
}

void VideoDriver::DrawMeshBuffer(Scene::MeshBuffer^ mb)
{
	m_VideoDriver->drawMeshBuffer(LIME_SAFEREF(mb, m_MeshBuffer));
}

void VideoDriver::DrawMeshBufferNormals(Scene::MeshBuffer^ mb, float length, Color^ color)
{
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->drawMeshBufferNormals(
		LIME_SAFEREF(mb, m_MeshBuffer),
		length,
		*color->m_NativeValue);
}

void VideoDriver::DrawMeshBufferNormals(Scene::MeshBuffer^ mb, float length)
{
	m_VideoDriver->drawMeshBufferNormals(
		LIME_SAFEREF(mb, m_MeshBuffer),
		length);
}

void VideoDriver::DrawMeshBufferNormals(Scene::MeshBuffer^ mb)
{
	m_VideoDriver->drawMeshBufferNormals(LIME_SAFEREF(mb, m_MeshBuffer));
}

void VideoDriver::DrawPixel(int x, int y, Color^ color)
{
	LIME_ASSERT(x >= 0 && x < CurrentRenderTargetSize->Width);
	LIME_ASSERT(y >= 0 && y < CurrentRenderTargetSize->Height);
	LIME_ASSERT(color != nullptr);

	m_VideoDriver->drawPixel((unsigned int)x, (unsigned int)y, *color->m_NativeValue);
}

void VideoDriver::DrawStencilShadow(bool clearStencilBuffer, Color^ leftUpEdge, Color^ rightUpEdge, Color^ leftDownEdge, Color^ rightDownEdge)
{
	LIME_ASSERT(leftUpEdge != nullptr);
	LIME_ASSERT(rightUpEdge != nullptr);
	LIME_ASSERT(leftDownEdge != nullptr);
	LIME_ASSERT(rightDownEdge != nullptr);

	m_VideoDriver->drawStencilShadow(
		clearStencilBuffer,
		*leftUpEdge->m_NativeValue,
		*rightUpEdge->m_NativeValue,
		*leftDownEdge->m_NativeValue,
		*rightDownEdge->m_NativeValue);
}

void VideoDriver::DrawStencilShadow(bool clearStencilBuffer, Color^ allEdges)
{
	LIME_ASSERT(allEdges != nullptr);

	m_VideoDriver->drawStencilShadow(
		clearStencilBuffer,
		*allEdges->m_NativeValue,
		*allEdges->m_NativeValue,
		*allEdges->m_NativeValue,
		*allEdges->m_NativeValue);
}

void VideoDriver::DrawStencilShadow(bool clearStencilBuffer)
{
	m_VideoDriver->drawStencilShadow(clearStencilBuffer);
}

void VideoDriver::DrawStencilShadow()
{
	m_VideoDriver->drawStencilShadow();
}

void VideoDriver::DrawStencilShadowVolume(List<Vector3Df^>^ triangles, bool zfail, Scene::DebugSceneType debugDataVisible)
{
	LIME_ASSERT(triangles != nullptr);
	LIME_ASSERT(triangles->Count > 0);
	LIME_ASSERT((triangles->Count % 3) == 0);

	core::array<core::vector3df> t;
	for (int i = 0; i < triangles->Count; i++)
	{
		LIME_ASSERT(triangles[i] != nullptr);
		t.push_back(*triangles[i]->m_NativeValue);
	}

	m_VideoDriver->drawStencilShadowVolume(t, zfail, (scene::E_DEBUG_SCENE_TYPE)debugDataVisible);
}

void VideoDriver::DrawStencilShadowVolume(List<Vector3Df^>^ triangles, bool zfail)
{
	LIME_ASSERT(triangles != nullptr);
	LIME_ASSERT(triangles->Count > 0);
	LIME_ASSERT((triangles->Count % 3) == 0);

	core::array<core::vector3df> t;
	for (int i = 0; i < triangles->Count; i++)
	{
		LIME_ASSERT(triangles[i] != nullptr);
		t.push_back(*triangles[i]->m_NativeValue);
	}

	m_VideoDriver->drawStencilShadowVolume(t, zfail);
}

void VideoDriver::DrawStencilShadowVolume(List<Vector3Df^>^ triangles)
{
	LIME_ASSERT(triangles != nullptr);
	LIME_ASSERT(triangles->Count > 0);
	LIME_ASSERT((triangles->Count % 3) == 0);

	core::array<core::vector3df> t;
	for (int i = 0; i < triangles->Count; i++)
	{
		LIME_ASSERT(triangles[i] != nullptr);
		t.push_back(*triangles[i]->m_NativeValue);
	}

	m_VideoDriver->drawStencilShadowVolume(t);
}

void VideoDriver::DrawVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned short>^ indices16bit, Scene::PrimitiveType pType)
{
	LIME_ASSERT(vertices != nullptr);
	LIME_ASSERT(vertices->Length <= 0xFFFF);
	LIME_ASSERT(indices16bit != nullptr);

	if (vertices->Length == 0 || indices16bit->Length == 0)
		return;

	unsigned int primCount = calculatePrimitiveCount(indices16bit->Length, pType);

	video::S3DVertex* vertexList = new S3DVertex[vertices->Length];
	for (int i = 0; i < vertices->Length; i++)
	{
		LIME_ASSERT(vertices[i] != nullptr);
		vertexList[i] = *vertices[i]->m_NativeValue;
	}

	u16* indexList = new u16[indices16bit->Length];
	Marshal::Copy((array<short>^)indices16bit, 0, IntPtr(indexList), indices16bit->Length);

	m_VideoDriver->drawVertexPrimitiveList(vertexList, vertices->Length, indexList, primCount,
		EVT_STANDARD, (scene::E_PRIMITIVE_TYPE)pType, EIT_16BIT);

	delete[] indexList;
	delete[] vertexList;
}

void VideoDriver::DrawVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned short>^ indices16bit)
{
	DrawVertexPrimitiveList(vertices, indices16bit, Scene::PrimitiveType::Triangles);
}

void VideoDriver::DrawVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned int>^ indices32bit, Scene::PrimitiveType pType)
{
	LIME_ASSERT(vertices != nullptr);
	LIME_ASSERT(indices32bit != nullptr);

	if (vertices->Length == 0 || indices32bit->Length == 0)
		return;

	unsigned int primCount = calculatePrimitiveCount(indices32bit->Length, pType);

	video::S3DVertex* vertexList = new S3DVertex[vertices->Length];
	for (int i = 0; i < vertices->Length; i++)
	{
		LIME_ASSERT(vertices[i] != nullptr);
		vertexList[i] = *vertices[i]->m_NativeValue;
	}

	u32* indexList = new u32[indices32bit->Length];
	Marshal::Copy((array<int>^)indices32bit, 0, IntPtr(indexList), indices32bit->Length);

	m_VideoDriver->drawVertexPrimitiveList(vertexList, vertices->Length, indexList, primCount,
		EVT_STANDARD, (scene::E_PRIMITIVE_TYPE)pType, EIT_32BIT);

	delete[] indexList;
	delete[] vertexList;
}

void VideoDriver::DrawVertexPrimitiveList(array<Vertex3D^>^ vertices, array<unsigned int>^ indices32bit)
{
	DrawVertexPrimitiveList(vertices, indices32bit, Scene::PrimitiveType::Triangles);
}

void VideoDriver::DrawVertexPrimitiveList(Scene::VertexBuffer^ vertexBuffer, Scene::IndexBuffer^ indexBuffer, Scene::PrimitiveType pType)
{
	LIME_ASSERT(vertexBuffer != nullptr);
	LIME_ASSERT(indexBuffer != nullptr);

	scene::IVertexBuffer* vb = vertexBuffer->m_VertexBuffer;
	scene::IIndexBuffer* ib = indexBuffer->m_IndexBuffer;

	if (vb->size() == 0 || ib->size() == 0)
		return;

	unsigned int primCount = calculatePrimitiveCount(ib->size(), pType);

	m_VideoDriver->drawVertexPrimitiveList(
		vb->pointer(),
		vb->size(),
		ib->pointer(),
		primCount,
		vb->getType(),
		(scene::E_PRIMITIVE_TYPE)pType,
		ib->getType());
}

void VideoDriver::DrawVertexPrimitiveList(Scene::VertexBuffer^ vertexBuffer, Scene::IndexBuffer^ indexBuffer)
{
	DrawVertexPrimitiveList(vertexBuffer, indexBuffer, Scene::PrimitiveType::Triangles);
}

void VideoDriver::EnableClipPlane(int index, bool enable)
{
	LIME_ASSERT(index >= 0 && index < (int)Attributes->GetValue("MaxUserClipPlanes"));
	m_VideoDriver->enableClipPlane(index, enable);
}

void VideoDriver::EnableClipPlane(int index)
{
	LIME_ASSERT(index >= 0 && index < (int)Attributes->GetValue("MaxUserClipPlanes"));
	m_VideoDriver->enableClipPlane(index, true);
}

void VideoDriver::EnableMaterial2D(bool enable)
{
	m_VideoDriver->enableMaterial2D(enable);
}

void VideoDriver::EnableMaterial2D()
{
	m_VideoDriver->enableMaterial2D();
}

bool VideoDriver::EndScene()
{
	return m_VideoDriver->endScene();
}

Texture^ VideoDriver::FindTexture(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	video::ITexture* t = m_VideoDriver->findTexture(Lime::StringToPath(filename));
	return Texture::Wrap(t);
}

Light^ VideoDriver::GetDynamicLight(int index)
{
	LIME_ASSERT(index >= 0 && index < DynamicLightCount);
	return gcnew Light((video::SLight*)&m_VideoDriver->getDynamicLight(index)); // !!! cast to non-const
}

ImageLoader^ VideoDriver::GetImageLoader(int index)
{
	LIME_ASSERT(index >= 0 && index < ImageLoaderCount);

	video::IImageLoader* l = m_VideoDriver->getImageLoader(index);
	return ImageLoader::Wrap(l);
}

Material^ VideoDriver::GetMaterialFromAttributes(IO::Attributes^ attributes)
{
	LIME_ASSERT(attributes != nullptr);

	video::SMaterial m;
	m_VideoDriver->fillMaterialStructureFromAttributes(m, LIME_SAFEREF(attributes, m_Attributes));

	return gcnew Material(m);
}

MaterialRenderer^ VideoDriver::GetMaterialRenderer(int index)
{
	LIME_ASSERT(index >= 0 && index < MaterialRendererCount);
	
	video::IMaterialRenderer* r = m_VideoDriver->getMaterialRenderer(index);
	return MaterialRenderer::Wrap(r);
}

MaterialRenderer^ VideoDriver::GetMaterialRenderer(MaterialType material)
{
	video::IMaterialRenderer* r = m_VideoDriver->getMaterialRenderer((unsigned int)material);
	return MaterialRenderer::Wrap(r);
}

String^ VideoDriver::GetMaterialRendererName(int index)
{
	LIME_ASSERT(index >= 0 && index < MaterialRendererCount);

	const char* n = m_VideoDriver->getMaterialRendererName(index);
	return n == nullptr ? nullptr : gcnew String(n);
}

String^ VideoDriver::GetMaterialRendererName(MaterialType material)
{
	const char* n = m_VideoDriver->getMaterialRendererName((unsigned int)material);
	return n == nullptr ? nullptr : gcnew String(n);
}

int VideoDriver::GetOcclusionQueryResult(Scene::SceneNode^ node)
{
	return m_VideoDriver->getOcclusionQueryResult(LIME_SAFEREF(node, m_SceneNode));
}

Texture^ VideoDriver::GetTexture(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	video::ITexture* t = m_VideoDriver->getTexture(Lime::StringToPath(filename));
	return Texture::Wrap(t);
}

Texture^ VideoDriver::GetTexture(IO::ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);

	video::ITexture* t = m_VideoDriver->getTexture(file->m_ReadFile);
	return Texture::Wrap(t);
}

Texture^ VideoDriver::GetTexture(int index)
{
	LIME_ASSERT(index >= 0 && index < TextureCount);

	video::ITexture* t = m_VideoDriver->getTextureByIndex(index);
	return Texture::Wrap(t);
}

bool VideoDriver::GetTextureCreationFlag(TextureCreationFlag flag)
{
	return m_VideoDriver->getTextureCreationFlag((video::E_TEXTURE_CREATION_FLAG)flag);
}

Matrix^ VideoDriver::GetTransform(TransformationState state)
{
	return gcnew Matrix(m_VideoDriver->getTransform((video::E_TRANSFORMATION_STATE)state));
}

void VideoDriver::MakeColorKeyTexture(Texture^ texture, Color^ color)
{
	LIME_ASSERT(color != nullptr);
	m_VideoDriver->makeColorKeyTexture(LIME_SAFEREF(texture, m_Texture), *color->m_NativeValue);
}

void VideoDriver::MakeColorKeyTexture(Texture^ texture, Vector2Di^ colorKeyPixelPos)
{
	LIME_ASSERT(colorKeyPixelPos != nullptr);
	m_VideoDriver->makeColorKeyTexture(LIME_SAFEREF(texture, m_Texture), *colorKeyPixelPos->m_NativeValue);
}

void VideoDriver::MakeNormalMapTexture(Texture^ texture, float amplitude)
{
	m_VideoDriver->makeNormalMapTexture(LIME_SAFEREF(texture, m_Texture), amplitude);
}

void VideoDriver::MakeNormalMapTexture(Texture^ texture)
{
	m_VideoDriver->makeNormalMapTexture(LIME_SAFEREF(texture, m_Texture));
}

bool VideoDriver::QueryFeature(VideoDriverFeature feature)
{
	return m_VideoDriver->queryFeature((video::E_VIDEO_DRIVER_FEATURE)feature);
}

void VideoDriver::RemoveAllHardwareBuffers()
{
	m_VideoDriver->removeAllHardwareBuffers();
}

void VideoDriver::RemoveAllOcclusionQueries()
{
	m_VideoDriver->removeAllOcclusionQueries();
}

void VideoDriver::RemoveAllTextures()
{
	m_VideoDriver->removeAllTextures();
}

void VideoDriver::RemoveHardwareBuffer(Scene::MeshBuffer^ mb)
{
	m_VideoDriver->removeHardwareBuffer(LIME_SAFEREF(mb, m_MeshBuffer));
}

void VideoDriver::RemoveOcclusionQuery(Scene::SceneNode^ node)
{
	m_VideoDriver->removeOcclusionQuery(LIME_SAFEREF(node, m_SceneNode));
}

void VideoDriver::RemoveTexture(Texture^ texture)
{
	m_VideoDriver->removeTexture(LIME_SAFEREF(texture, m_Texture));
}

void VideoDriver::RenameTexture(Texture^ texture, String^ newName)
{
	LIME_ASSERT(newName != nullptr);
	m_VideoDriver->renameTexture(LIME_SAFEREF(texture, m_Texture), Lime::StringToPath(newName));
}

void VideoDriver::ResizeNotify(Dimension2Di^ size)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width >= 0);
	LIME_ASSERT(size->Height >= 0);

	m_VideoDriver->OnResize((core::dimension2du&)*size->m_NativeValue);
}

void VideoDriver::RunAllOcclusionQueries(bool visible)
{
	m_VideoDriver->runAllOcclusionQueries(visible);
}

void VideoDriver::RunAllOcclusionQueries()
{
	m_VideoDriver->runAllOcclusionQueries();
}

void VideoDriver::RunOcclusionQuery(Scene::SceneNode^ node, bool visible)
{
	m_VideoDriver->runOcclusionQuery(LIME_SAFEREF(node, m_SceneNode), visible);
}

void VideoDriver::RunOcclusionQuery(Scene::SceneNode^ node)
{
	m_VideoDriver->runOcclusionQuery(LIME_SAFEREF(node, m_SceneNode));
}

bool VideoDriver::SetClipPlane(int index, Plane3Df^ plane, bool enable)
{
	LIME_ASSERT(index >= 0 && index < (int)Attributes->GetValue("MaxUserClipPlanes"));
	LIME_ASSERT(plane != nullptr);

	return m_VideoDriver->setClipPlane(
		index,
		*plane->m_NativeValue,
		enable);
}

bool VideoDriver::SetClipPlane(int index, Plane3Df^ plane)
{
	LIME_ASSERT(index >= 0 && index < (int)Attributes->GetValue("MaxUserClipPlanes"));
	LIME_ASSERT(plane != nullptr);

	return m_VideoDriver->setClipPlane(
		index,
		*plane->m_NativeValue);
}

void VideoDriver::SetMaterial(Material^ material)
{
	LIME_ASSERT(material != nullptr);
	m_VideoDriver->setMaterial(*material->m_NativeValue);
}

void VideoDriver::SetMaterialRendererName(MaterialType materialType, String^ name)
{
	m_VideoDriver->setMaterialRendererName(
		(video::E_MATERIAL_TYPE) materialType,
		LIME_SAFESTRINGTOSTRINGC_C_STR(name));
}

void VideoDriver::SetMinHardwareBufferVertexCount(int count)
{
	LIME_ASSERT(count >= 0);
	m_VideoDriver->setMinHardwareBufferVertexCount(count);
}

bool VideoDriver::SetRenderTarget(Texture^ texture, ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth, u8 clearStencil)
{
	LIME_ASSERT(clearColor != nullptr);
	return m_VideoDriver->setRenderTarget(LIME_SAFEREF(texture, m_Texture), (u16)clearFlag, *clearColor->m_NativeValue, clearDepth, clearStencil);
}

bool VideoDriver::SetRenderTarget(Texture^ texture, ClearBufferFlag clearFlag, Color^ clearColor, f32 clearDepth)
{
	LIME_ASSERT(clearColor != nullptr);
	return m_VideoDriver->setRenderTarget(LIME_SAFEREF(texture, m_Texture), (u16)clearFlag, *clearColor->m_NativeValue, clearDepth);
}

bool VideoDriver::SetRenderTarget(Texture^ texture, ClearBufferFlag clearFlag, Color^ clearColor)
{
	LIME_ASSERT(clearColor != nullptr);
	return m_VideoDriver->setRenderTarget(LIME_SAFEREF(texture, m_Texture), (u16)clearFlag, *clearColor->m_NativeValue);
}

bool VideoDriver::SetRenderTarget(Texture^ texture, ClearBufferFlag clearFlag)
{
	return m_VideoDriver->setRenderTarget(LIME_SAFEREF(texture, m_Texture), (u16)clearFlag);
}

bool VideoDriver::SetRenderTarget(Texture^ texture)
{
	return m_VideoDriver->setRenderTarget(LIME_SAFEREF(texture, m_Texture));
}

void VideoDriver::SetTextureCreationFlag(TextureCreationFlag flag, bool enabled)
{
	m_VideoDriver->setTextureCreationFlag((video::E_TEXTURE_CREATION_FLAG)flag, enabled);
}

void VideoDriver::SetTransform(TransformationState state, Matrix^ mat)
{
	LIME_ASSERT(mat != nullptr);
	m_VideoDriver->setTransform((video::E_TRANSFORMATION_STATE)state, *mat->m_NativeValue);
}

void VideoDriver::TurnLight(int index, bool turnOn)
{
	LIME_ASSERT(index >= 0 && index < DynamicLightCount);
	m_VideoDriver->turnLightOn(index, turnOn);
}

void VideoDriver::UpdateAllOcclusionQueries(bool block)
{
	m_VideoDriver->updateAllOcclusionQueries(block);
}

void VideoDriver::UpdateAllOcclusionQueries()
{
	m_VideoDriver->updateAllOcclusionQueries();
}

void VideoDriver::UpdateOcclusionQuery(Scene::SceneNode^ node, bool block)
{
	m_VideoDriver->updateOcclusionQuery(LIME_SAFEREF(node, m_SceneNode), block);
}

void VideoDriver::UpdateOcclusionQuery(Scene::SceneNode^ node)
{
	m_VideoDriver->updateOcclusionQuery(LIME_SAFEREF(node, m_SceneNode));
}

bool VideoDriver::WriteImage(Image^ image, String^ filename, unsigned int param)
{
	LIME_ASSERT(image != nullptr);
	LIME_ASSERT(filename != nullptr);

	return m_VideoDriver->writeImageToFile(
		LIME_SAFEREF(image, m_Image),
		Lime::StringToPath(filename),
		param);
}

bool VideoDriver::WriteImage(Image^ image, String^ filename)
{
	LIME_ASSERT(image != nullptr);
	LIME_ASSERT(filename != nullptr);

	return m_VideoDriver->writeImageToFile(
		LIME_SAFEREF(image, m_Image),
		Lime::StringToPath(filename));
}

bool VideoDriver::WriteImage(Image^ image, IO::WriteFile^ file, unsigned int param)
{
	LIME_ASSERT(image != nullptr);
	LIME_ASSERT(file != nullptr);

	return m_VideoDriver->writeImageToFile(
		LIME_SAFEREF(image, m_Image),
		LIME_SAFEREF(file, m_WriteFile),
		param);
}

bool VideoDriver::WriteImage(Image^ image, IO::WriteFile^ file)
{
	LIME_ASSERT(image != nullptr);
	LIME_ASSERT(file != nullptr);

	return m_VideoDriver->writeImageToFile(
		LIME_SAFEREF(image, m_Image),
		LIME_SAFEREF(file, m_WriteFile));
}

IO::Attributes^ VideoDriver::Attributes::get()
{
	const io::IAttributes& a = m_VideoDriver->getDriverAttributes();
	return IO::Attributes::Wrap((io::IAttributes*)&a); // !!! cast to non-const pointer
}

Video::ColorFormat VideoDriver::ColorFormat::get()
{
	return (Video::ColorFormat)m_VideoDriver->getColorFormat();
}

Video::DriverType VideoDriver::DriverType::get()
{
	return (Video::DriverType)m_VideoDriver->getDriverType();
}

Recti^ VideoDriver::ViewPort::get()
{
	return gcnew Recti(m_VideoDriver->getViewPort());
}

void VideoDriver::ViewPort::set(Recti^ value)
{
	m_VideoDriver->setViewPort(*value->m_NativeValue);
}

Dimension2Di^ VideoDriver::ScreenSize::get()
{
	return gcnew Dimension2Di(m_VideoDriver->getScreenSize());
}

Dimension2Di^ VideoDriver::CurrentRenderTargetSize::get()
{
	return gcnew Dimension2Di(m_VideoDriver->getCurrentRenderTargetSize());
}

Dimension2Di^ VideoDriver::MaxTextureSize::get()
{
	return gcnew Dimension2Di(m_VideoDriver->getMaxTextureSize());
}

List<VideoDriverFeature>^ VideoDriver::FeatureList::get()
{
	List<VideoDriverFeature>^ l = gcnew List<VideoDriverFeature>();

	for each(VideoDriverFeature f in Enum::GetValues(VideoDriverFeature::typeid))
		if (m_VideoDriver->queryFeature((video::E_VIDEO_DRIVER_FEATURE)f))
			l->Add(f);

	return l;
}

Video::Fog^ VideoDriver::Fog::get()
{
	video::SColor c;
	video::E_FOG_TYPE t;
	float s;
	float e;
	float d;
	bool p;
	bool r;

	m_VideoDriver->getFog(c, t, s, e, d, p, r);

	return gcnew Video::Fog(gcnew Color(c), (FogType)t, s, e, d, p, r);
}

void VideoDriver::Fog::set(Video::Fog^ value)
{
	LIME_ASSERT(value != nullptr);
	LIME_ASSERT(value->Color != nullptr);

	m_VideoDriver->setFog(
		*value->Color->m_NativeValue,
		(video::E_FOG_TYPE)value->Type,
		value->Start,
		value->End,
		value->Density,
		value->PixelFog,
		value->RangeFog);
}

int VideoDriver::FPS::get()
{
	return m_VideoDriver->getFPS();
}

Video::GPUProgrammingServices^ VideoDriver::GPUProgrammingServices::get()
{
	video::IGPUProgrammingServices* s = m_VideoDriver->getGPUProgrammingServices();
	return Video::GPUProgrammingServices::Wrap(s);
}

int VideoDriver::ImageLoaderCount::get()
{
	return m_VideoDriver->getImageLoaderCount();
}

Material^ VideoDriver::Material2D::get()
{
	return Material::Wrap(&m_VideoDriver->getMaterial2D());
}

int VideoDriver::PrimitiveCountDrawn::get()
{
	return m_VideoDriver->getPrimitiveCountDrawn();
}

int VideoDriver::MaxDynamicLightCount::get()
{
	return m_VideoDriver->getMaximalDynamicLightAmount();
}

int VideoDriver::DynamicLightCount::get()
{
	return m_VideoDriver->getDynamicLightCount();
}

Video::ExposedVideoData^ VideoDriver::ExposedVideoData::get()
{
	return gcnew Video::ExposedVideoData(m_VideoDriver->getExposedVideoData());
}

int VideoDriver::MaxPrimitiveCount::get()
{
	return m_VideoDriver->getMaximalPrimitiveCount();
}

int VideoDriver::MaterialRendererCount::get()
{
	return m_VideoDriver->getMaterialRendererCount();
}

Scene::MeshManipulator^ VideoDriver::MeshManipulator::get()
{
	scene::IMeshManipulator* m = m_VideoDriver->getMeshManipulator();
	return Scene::MeshManipulator::Wrap(m);
}

String^ VideoDriver::Name::get()
{
	return gcnew String(m_VideoDriver->getName());
}

int VideoDriver::TextureCount::get()
{
	return m_VideoDriver->getTextureCount();
}

List<Texture^>^ VideoDriver::TextureList::get()
{
	List<Texture^>^ l = gcnew List<Texture^>();

	for (unsigned int i = 0; i < m_VideoDriver->getTextureCount(); i++)
	{
		video::ITexture* t = m_VideoDriver->getTextureByIndex(i);
		l->Add(Texture::Wrap(t));
	}

	return l;
}

String^ VideoDriver::VendorInfo::get()
{
	return gcnew String(m_VideoDriver->getVendorInfo().c_str());
}

String^ VideoDriver::ToString()
{
	return String::Format("VideoDriver: Name={0}; ScreenSize={1}", Name, ScreenSize);
}

unsigned int VideoDriver::calculatePrimitiveCount(unsigned int indexCount, Scene::PrimitiveType pType)
{
	unsigned int c = 0;

	switch (pType)
	{
	case Scene::PrimitiveType::Points:
	case Scene::PrimitiveType::PointSprites:
	case Scene::PrimitiveType::LineLoop:
	case Scene::PrimitiveType::Polygon:
		c = indexCount;
		break;

	case Scene::PrimitiveType::LineStrip:
		LIME_ASSERT(indexCount >= 2);
		c = indexCount - 1;
		break;

	case Scene::PrimitiveType::Lines:
		LIME_ASSERT(indexCount == (indexCount / 2) * 2);
		c = indexCount / 2;
		break;

	case Scene::PrimitiveType::TriangleStrip:
	case Scene::PrimitiveType::TriangleFan:
		LIME_ASSERT(indexCount >= 3);
		c = indexCount - 2;
		break;

	case Scene::PrimitiveType::Triangles:
		LIME_ASSERT(indexCount == (indexCount / 3) * 3);
		c = indexCount / 3;
		break;

	case Scene::PrimitiveType::QuadStrip:
		LIME_ASSERT(indexCount == (indexCount / 2) * 2);
		LIME_ASSERT(indexCount >= 4);
		c = (indexCount - 2) / 2;
		break;

	case Scene::PrimitiveType::Quads:
		LIME_ASSERT(indexCount == (indexCount / 4) * 4);
		c = indexCount / 4;
		break;
	}

	return c;
}

} // end namespace Video
} // end namespace IrrlichtLime