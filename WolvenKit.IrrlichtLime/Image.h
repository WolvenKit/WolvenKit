#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

public ref class Image : ReferenceCounted
{
public:

	static int GetBitsPerPixelFromFormat(Video::ColorFormat format);
	static bool IsCompressedFormat(Video::ColorFormat format);
	static bool IsRenderTargetOnlyFormat(Video::ColorFormat format);
	static System::Drawing::Imaging::PixelFormat GetPixelFormat(Video::ColorFormat format);

	void CopyTo(Image^ target, Vector2Di^ targetPos, Recti^ sourceRect, Recti^ clipRect);
	void CopyTo(Image^ target, Vector2Di^ targetPos, Recti^ sourceRect);
	void CopyTo(Image^ target, Vector2Di^ targetPos);
	void CopyTo(Image^ target);

	System::Drawing::Bitmap^ CopyToBitmap();

	void CopyToScaling(Image^ target);
	array<unsigned char>^ CopyToScaling(int width, int height, Video::ColorFormat format, int pitch);
	array<unsigned char>^ CopyToScaling(int width, int height, Video::ColorFormat format);
	array<unsigned char>^ CopyToScaling(int width, int height);

	void CopyToScalingBoxFilter(Image^ target, int bias, bool blend);
	void CopyToScalingBoxFilter(Image^ target, int bias);
	void CopyToScalingBoxFilter(Image^ target);

	void CopyToWithAlpha(Image^ target, Vector2Di^ targetPos, Recti^ sourceRect, Color^ color, Recti^ clipRect);
	void CopyToWithAlpha(Image^ target, Vector2Di^ targetPos, Recti^ sourceRect, Color^ color);

	void Fill(Color^ color);
	array<u8>^ GetData();
	Color^ GetPixel(int x, int y);
	void SetPixel(int x, int y, Color^ color, bool blend);
	void SetPixel(int x, int y, Color^ color);

	property int BitsPerPixel { int get(); }
	property int BytesPerPixel { int get(); }
	property Video::ColorFormat ColorFormat { Video::ColorFormat get(); }
	property bool Compressed { bool get(); }
	property Dimension2Di^ Dimension { Dimension2Di^ get(); }
	property bool HasMipMaps { bool get(); }
	property int ImageDataSizeInBytes { int get(); }
	property int ImageDataSizeInPixels { int get(); }

	property int RedMask { int get(); }
	property int GreenMask { int get(); }
	property int BlueMask { int get(); }
	property int AlphaMask { int get(); }
	property int Pitch { int get(); }

	virtual String^ ToString() override;

internal:

	static Image^ Wrap(video::IImage* ref);
	Image(video::IImage* ref);

	video::IImage* m_Image;
};

} // end namespace Video
} // end namespace IrrlichtLime