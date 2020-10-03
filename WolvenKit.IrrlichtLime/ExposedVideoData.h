#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video {

public ref class ExposedVideoData : Lime::NativeValue<video::SExposedVideoData>
{
public:

	ExposedVideoData()
		: Lime::NativeValue<video::SExposedVideoData>(true)
	{
		m_NativeValue = new video::SExposedVideoData();
	}

	property IntPtr DeviceContext
	{
		IntPtr get() { return IntPtr(m_NativeValue->OpenGLWin32.HDc); }
		void set(IntPtr value) { m_NativeValue->OpenGLWin32.HDc = value.ToPointer(); }
	}

	property IntPtr RenderingContext
	{
		IntPtr get() { return IntPtr(m_NativeValue->OpenGLWin32.HRc); }
		void set(IntPtr value) { m_NativeValue->OpenGLWin32.HRc = value.ToPointer(); }
	}

	property IntPtr WindowID
	{
		IntPtr get() { return IntPtr(m_NativeValue->OpenGLWin32.HWnd); }
		void set(IntPtr value) { m_NativeValue->OpenGLWin32.HWnd = value.ToPointer(); }
	}

internal:

	ExposedVideoData(const video::SExposedVideoData& value)
		: Lime::NativeValue<video::SExposedVideoData>(true)
	{
		m_NativeValue = new video::SExposedVideoData(value);
	}
};

} // end namespace Video
} // end namespace IrrlichtLime