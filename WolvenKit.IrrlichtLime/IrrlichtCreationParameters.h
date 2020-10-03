#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {

public ref class IrrlichtCreationParameters : Lime::NativeValue<SIrrlichtCreationParameters>
{
public:

	IrrlichtCreationParameters()
		: Lime::NativeValue<SIrrlichtCreationParameters>(true)
	{
		m_NativeValue = new SIrrlichtCreationParameters();
	}

	property bool AlphaChannel
	{
		bool get() { return m_NativeValue->WithAlphaChannel; }
		void set(bool value) { m_NativeValue->WithAlphaChannel = value; }
	}

	property unsigned __int8 AntiAliasing
	{
		unsigned __int8 get() { return m_NativeValue->AntiAlias; }
		void set(unsigned __int8 value) { m_NativeValue->AntiAlias = value; }
	}

	property unsigned __int8 BitsPerPixel
	{
		unsigned __int8 get() { return m_NativeValue->Bits; }
		void set(unsigned __int8 value) { m_NativeValue->Bits = value; }
	}

	property IrrlichtLime::DeviceType DeviceType
	{
		IrrlichtLime::DeviceType get() { return (IrrlichtLime::DeviceType)m_NativeValue->DeviceType; }
		void set(IrrlichtLime::DeviceType value) { m_NativeValue->DeviceType = (E_DEVICE_TYPE)value; }
	}

	property bool DoubleBuffer
	{
		bool get() { return m_NativeValue->Doublebuffer; }
		void set(bool value) { m_NativeValue->Doublebuffer = value; }
	}

	property bool DriverMultithreaded
	{
		bool get() { return m_NativeValue->DriverMultithreaded; }
		void set(bool value) { m_NativeValue->DriverMultithreaded = value; }
	}

	property Video::DriverType DriverType
	{
		Video::DriverType get() { return (Video::DriverType)m_NativeValue->DriverType; }
		void set(Video::DriverType value) { m_NativeValue->DriverType = (E_DRIVER_TYPE)value; }
	}

	property bool Fullscreen
	{
		bool get() { return m_NativeValue->Fullscreen; }
		void set(bool value) { m_NativeValue->Fullscreen = value; }
	}

	property bool HandleSRGB
	{
		bool get() { return m_NativeValue->HandleSRGB; }
		void set(bool value) { m_NativeValue->HandleSRGB = value; }
	}

	property bool HighPrecisionFPU
	{
		bool get() { return m_NativeValue->HighPrecisionFPU; }
		void set(bool value) { m_NativeValue->HighPrecisionFPU = value; }
	}

	property bool IgnoreInput
	{
		bool get() { return m_NativeValue->IgnoreInput; }
		void set(bool value) { m_NativeValue->IgnoreInput = value; }
	}

	property LogLevel LoggingLevel
	{
		LogLevel get() { return (LogLevel)m_NativeValue->LoggingLevel; }
		void set(LogLevel value) { m_NativeValue->LoggingLevel = (ELOG_LEVEL)value; }
	}

	property bool StencilBuffer
	{
		bool get() { return m_NativeValue->Stencilbuffer; }
		void set(bool value) { m_NativeValue->Stencilbuffer = value; }
	}

	property bool StereoBuffer
	{
		bool get() { return m_NativeValue->Stereobuffer; }
		void set(bool value) { m_NativeValue->Stereobuffer = value; }
	}

	property bool UsePerformanceTimer
	{
		bool get() { return m_NativeValue->UsePerformanceTimer; }
		void set(bool value) { m_NativeValue->UsePerformanceTimer = value; }
	}

	property bool VSync
	{
		bool get() { return m_NativeValue->Vsync; }
		void set(bool value) { m_NativeValue->Vsync = value; }
	}

	property IntPtr WindowID
	{
		IntPtr get() { return IntPtr(m_NativeValue->WindowId); }
		void set(IntPtr value) { m_NativeValue->WindowId = value.ToPointer(); }
	}

	property Vector2Di^ WindowPosition
	{
		Vector2Di^ get() { return gcnew Vector2Di(m_NativeValue->WindowPosition); }

		void set(Vector2Di^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->WindowPosition = *value->m_NativeValue;
		}
	}

	property Dimension2Di^ WindowSize
	{
		Dimension2Di^ get() { return gcnew Dimension2Di(m_NativeValue->WindowSize); }

		void set(Dimension2Di^ value)
		{
			LIME_ASSERT(value != nullptr);
			LIME_ASSERT(value->Width >= 0);
			LIME_ASSERT(value->Height >= 0);

			m_NativeValue->WindowSize = *value->m_NativeValue;
		}
	}

	property unsigned __int8 ZBufferBits
	{
		unsigned __int8 get() { return m_NativeValue->ZBufferBits; }
		void set(unsigned __int8 value) { m_NativeValue->ZBufferBits = value; }
	}

	virtual String^ ToString() override
	{
		return String::Format("IrrlichtCreationParameters: DeviceType={0}; DriverType={1}; WindowSize={2}",
			DeviceType, DriverType, WindowSize);
	}
};

} // end namespace IrrlichtLime