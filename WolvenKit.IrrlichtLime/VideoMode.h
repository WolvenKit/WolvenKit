#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

public value class VideoMode
{
public:

	static VideoModeAspectRatio GetAspectRatio(int width, int height)
	{
		float r = (float)width / (float)height;

		if (r == 3.0f/2.0f)
			return VideoModeAspectRatio::_3x2;
		else if (r == 4.0f/3.0f)
			return VideoModeAspectRatio::_4x3;
		else if (r == 5.0f/3.0f)
			return VideoModeAspectRatio::_5x3;
		else if (r == 5.0f/4.0f)
			return VideoModeAspectRatio::_5x4;
		else if (r == 16.0f/9.0f)
			return VideoModeAspectRatio::_16x9;
		else if (r == 16.0f/10.0f)
			return VideoModeAspectRatio::_16x10;
		
		// check for "almost 16:9" == 1.778
		if (width == 848 && height == 480 || // ratio is 1.766
			width == 854 && height == 480 || // ratio is 1.779
			width == 1360 && height == 768 || // ratio is 1.771
			width == 1366 && height == 768) // ratio is 1.779
			return VideoModeAspectRatio::_16x9;

		return VideoModeAspectRatio::Other;
	}

	int Depth;
	Dimension2Di^ Resolution;
	VideoModeAspectRatio AspectRatio;

	VideoMode(Dimension2Di^ resolution, int depth)
	{
		LIME_ASSERT(resolution->Width > 0);
		LIME_ASSERT(resolution->Height > 0);
		LIME_ASSERT(depth > 0);

		Resolution = resolution;
		Depth = depth;
		AspectRatio = GetAspectRatio(resolution->Width, resolution->Height);
	}

	VideoMode(int width, int height, int depth)
	{
		LIME_ASSERT(width > 0);
		LIME_ASSERT(height > 0);
		LIME_ASSERT(depth > 0);

		Resolution = gcnew Dimension2Di(width, height);
		Depth = depth;
		AspectRatio = GetAspectRatio(width, height);
	}

	property bool Wide
	{
		bool get()
		{
			return ((float)Resolution->Width / (float)Resolution->Height) > 1.37f; // magic value taken from http://en.wikipedia.org/wiki/Widescreen
		}
	}

	virtual String^ ToString() override
	{
		return String::Format("{0} x {1} x {2}bpp", Resolution->Width, Resolution->Height, Depth);
	}

internal:

	VideoMode(const core::dimension2di& resolution, int depth)
		: Resolution(gcnew Dimension2Di(resolution))
		, Depth(depth)
		, AspectRatio(GetAspectRatio(resolution.Width, resolution.Height)) {}
};

} // end namespace Video
} // end namespace IrrlichtLime