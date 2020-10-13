#include "stdafx.h"
#include "Image.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

int Image::GetBitsPerPixelFromFormat(Video::ColorFormat format)
{
	return video::IImage::getBitsPerPixelFromFormat((ECOLOR_FORMAT)format);
}

bool Image::IsCompressedFormat(Video::ColorFormat format)
{
	return video::IImage::isCompressedFormat((ECOLOR_FORMAT)format);
}

bool Image::IsRenderTargetOnlyFormat(Video::ColorFormat format)
{
	return video::IImage::isRenderTargetOnlyFormat((ECOLOR_FORMAT)format);
}

System::Drawing::Imaging::PixelFormat Image::GetPixelFormat(Video::ColorFormat format)
{
	switch ((ECOLOR_FORMAT)format)
	{
	case ECF_A1R5G5B5:
		return System::Drawing::Imaging::PixelFormat::Format16bppArgb1555;

	case ECF_R5G6B5:
		return System::Drawing::Imaging::PixelFormat::Format16bppRgb565;

	case ECF_R8G8B8:
		return System::Drawing::Imaging::PixelFormat::Format24bppRgb;

	case ECF_A8R8G8B8:
		return System::Drawing::Imaging::PixelFormat::Format32bppArgb;

	case ECF_A16B16G16R16F:
		return System::Drawing::Imaging::PixelFormat::Format64bppArgb;

	case ECF_R16F:
	case ECF_G16R16F:
	case ECF_R32F:
	case ECF_G32R32F:
	case ECF_A32B32G32R32F:
	default:
		return System::Drawing::Imaging::PixelFormat::Undefined;
	}
}

Image^ Image::Wrap(video::IImage* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew Image(ref);
}

Image::Image(video::IImage* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_Image = ref;
}

void Image::CopyTo(Image^ target, Vector2Di^ targetPos, Recti^ sourceRect, Recti^ clipRect)
{
	LIME_ASSERT(target != nullptr);
	LIME_ASSERT(targetPos != nullptr);
	LIME_ASSERT(sourceRect != nullptr);

	m_Image->copyTo(
		target->m_Image,
		*targetPos->m_NativeValue,
		*sourceRect->m_NativeValue,
		LIME_SAFEREF(clipRect, m_NativeValue));
}

void Image::CopyTo(Image^ target, Vector2Di^ targetPos, Recti^ sourceRect)
{
	LIME_ASSERT(target != nullptr);
	LIME_ASSERT(targetPos != nullptr);
	LIME_ASSERT(sourceRect != nullptr);

	m_Image->copyTo(
		target->m_Image,
		*targetPos->m_NativeValue,
		*sourceRect->m_NativeValue);
}

void Image::CopyTo(Image^ target, Vector2Di^ targetPos)
{
	LIME_ASSERT(target != nullptr);
	LIME_ASSERT(targetPos != nullptr);

	m_Image->copyTo(
		target->m_Image,
		*targetPos->m_NativeValue);
}

void Image::CopyTo(Image^ target)
{
	LIME_ASSERT(target != nullptr);
	m_Image->copyTo(target->m_Image);
}

System::Drawing::Bitmap^ Image::CopyToBitmap()
{
	LIME_ASSERT(GetPixelFormat(ColorFormat) != System::Drawing::Imaging::PixelFormat::Undefined);

	System::Drawing::Bitmap^ b = gcnew System::Drawing::Bitmap(
		m_Image->getDimension().Width,
		m_Image->getDimension().Height,
		GetPixelFormat(ColorFormat));

	System::Drawing::Imaging::BitmapData^ d = b->LockBits(
		System::Drawing::Rectangle(0, 0, b->Width, b->Height),
		System::Drawing::Imaging::ImageLockMode::WriteOnly,
		b->PixelFormat);

	m_Image->copyToScaling(
		d->Scan0.ToPointer(),
		m_Image->getDimension().Width,
		m_Image->getDimension().Height,
		m_Image->getColorFormat());

	b->UnlockBits(d);
	return b;
}

void Image::CopyToScaling(Image^ target)
{
	LIME_ASSERT(target != nullptr);
	m_Image->copyToScaling(target->m_Image);
}

array<unsigned char>^ Image::CopyToScaling(int width, int height, Video::ColorFormat format, int pitch)
{
	LIME_ASSERT(width > 0);
	LIME_ASSERT(height > 0);
	LIME_ASSERT(pitch >= 0);

	int s = width * height * (video::IImage::getBitsPerPixelFromFormat((video::ECOLOR_FORMAT)format) / 8) + pitch * height;
	unsigned char* a = new unsigned char[s];

	m_Image->copyToScaling(
		a,
		width,
		height,
		(video::ECOLOR_FORMAT)format,
		pitch);

	array<unsigned char>^ r = gcnew array<unsigned char>(s);
	Marshal::Copy(IntPtr(a), r, 0, s);

	delete[] a;
	return r;
}

array<unsigned char>^ Image::CopyToScaling(int width, int height, Video::ColorFormat format)
{
	LIME_ASSERT(width > 0);
	LIME_ASSERT(height > 0);

	int s = width * height * (video::IImage::getBitsPerPixelFromFormat((video::ECOLOR_FORMAT)format) / 8);
	unsigned char* a = new unsigned char[s];

	m_Image->copyToScaling(
		a,
		width,
		height,
		(video::ECOLOR_FORMAT)format);

	array<unsigned char>^ r = gcnew array<unsigned char>(s);
	Marshal::Copy(IntPtr(a), r, 0, s);

	delete[] a;
	return r;
}

array<unsigned char>^ Image::CopyToScaling(int width, int height)
{
	LIME_ASSERT(width > 0);
	LIME_ASSERT(height > 0);

	int s = width * height * (video::IImage::getBitsPerPixelFromFormat(video::ECF_A8R8G8B8) / 8);
	unsigned char* a = new unsigned char[s];

	m_Image->copyToScaling(
		a,
		width,
		height);

	array<unsigned char>^ r = gcnew array<unsigned char>(s);
	Marshal::Copy(IntPtr(a), r, 0, s);

	delete[] a;
	return r;
}

void Image::CopyToScalingBoxFilter(Image^ target, int bias, bool blend)
{
	LIME_ASSERT(target != nullptr);
	m_Image->copyToScalingBoxFilter(target->m_Image, bias, blend);
}

void Image::CopyToScalingBoxFilter(Image^ target, int bias)
{
	LIME_ASSERT(target != nullptr);
	m_Image->copyToScalingBoxFilter(target->m_Image, bias);
}

void Image::CopyToScalingBoxFilter(Image^ target)
{
	LIME_ASSERT(target != nullptr);
	m_Image->copyToScalingBoxFilter(target->m_Image);
}

void Image::CopyToWithAlpha(Image^ target, Vector2Di^ targetPos, Recti^ sourceRect, Color^ color, Recti^ clipRect)
{
	LIME_ASSERT(target != nullptr);
	LIME_ASSERT(targetPos != nullptr);
	LIME_ASSERT(sourceRect != nullptr);
	LIME_ASSERT(color != nullptr);

	m_Image->copyToWithAlpha(
		target->m_Image,
		*targetPos->m_NativeValue,
		*sourceRect->m_NativeValue,
		*color->m_NativeValue,
		LIME_SAFEREF(clipRect, m_NativeValue));
}

void Image::CopyToWithAlpha(Image^ target, Vector2Di^ targetPos, Recti^ sourceRect, Color^ color)
{
	LIME_ASSERT(target != nullptr);
	LIME_ASSERT(targetPos != nullptr);
	LIME_ASSERT(sourceRect != nullptr);
	LIME_ASSERT(color != nullptr);

	m_Image->copyToWithAlpha(
		target->m_Image,
		*targetPos->m_NativeValue,
		*sourceRect->m_NativeValue,
		*color->m_NativeValue);
}

void Image::Fill(Color^ color)
{
	LIME_ASSERT(color != nullptr);
	m_Image->fill(*color->m_NativeValue);
}

array<u8>^ Image::GetData()
{
	int s = m_Image->getImageDataSizeInBytes();
	array<u8>^ r = gcnew array<u8>(s);

	u8* a = (u8*) m_Image->getData();
	Marshal::Copy(IntPtr(a), r, 0, s);

	return r;
}

Color^ Image::GetPixel(int x, int y)
{
	LIME_ASSERT(x >= 0 && x < Dimension->Width);
	LIME_ASSERT(y >= 0 && y < Dimension->Height);

	return gcnew Color(m_Image->getPixel(x, y));
}

void Image::SetPixel(int x, int y, Color^ color, bool blend)
{
	LIME_ASSERT(x >= 0 && x < Dimension->Width);
	LIME_ASSERT(y >= 0 && y < Dimension->Height);
	LIME_ASSERT(color != nullptr);

	m_Image->setPixel(x, y, *color->m_NativeValue, blend);
}

void Image::SetPixel(int x, int y, Color^ color)
{
	LIME_ASSERT(x >= 0 && x < Dimension->Width);
	LIME_ASSERT(y >= 0 && y < Dimension->Height);
	LIME_ASSERT(color != nullptr);

	m_Image->setPixel(x, y, *color->m_NativeValue);
}

int Image::BitsPerPixel::get()
{
	return m_Image->getBitsPerPixel();
}

int Image::BytesPerPixel::get()
{
	return m_Image->getBytesPerPixel();
}

Video::ColorFormat Image::ColorFormat::get()
{
	return (Video::ColorFormat)m_Image->getColorFormat();
}

bool Image::Compressed::get()
{
	return IsCompressedFormat(this->ColorFormat);
}

Dimension2Di^ Image::Dimension::get()
{
	return gcnew Dimension2Di(m_Image->getDimension());
}

bool Image::HasMipMaps::get()
{
	return m_Image->getMipMapsData() != nullptr;
}

int Image::ImageDataSizeInBytes::get()
{
	return m_Image->getImageDataSizeInBytes();
}

int Image::ImageDataSizeInPixels::get()
{
	return m_Image->getImageDataSizeInPixels();
}

int Image::RedMask::get()
{
	return m_Image->getRedMask();
}

int Image::GreenMask::get()
{
	return m_Image->getGreenMask();
}

int Image::BlueMask::get()
{
	return m_Image->getBlueMask();
}

int Image::AlphaMask::get()
{
	return m_Image->getAlphaMask();
}

int Image::Pitch::get()
{
	return m_Image->getPitch();
}

String^ Image::ToString()
{
	return String::Format("Image: Dimension={0}; ColorFormat={1}", Dimension, ColorFormat);
}

} // end namespace Video
} // end namespace IrrlichtLime