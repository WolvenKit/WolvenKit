#pragma once
#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {

	/// <summary>
	/// An enumeration for the different device types supported by the Irrlicht Engine.
	/// </summary>
	public enum class DeviceType
	{
		/// <summary>
		/// A device native to Microsoft Windows.
		/// This device uses the Win32 API and works in all versions of Windows.
		/// </summary>
		Win32 = EIDT_WIN32,

		/// <summary>
		/// A device native to Windows CE devices.
		/// This device works on Windows Mobile, Pocket PC and Microsoft SmartPhone devices.
		/// </summary>
		WinCE = EIDT_WINCE,

		/// <summary>
		/// A device native to Unix style operating systems.
		/// This device uses the X11 windowing system and works in Linux, Solaris, FreeBSD, OSX and other operating systems which support X11.
		/// </summary>
		X11 = EIDT_X11,

		/// <summary>
		/// A device native to Mac OSX.
		/// This device uses Apple's Cocoa API and works in Mac OSX 10.2 and above.
		/// </summary>
		OSX = EIDT_OSX,

		/// <summary>
		/// A device which uses Simple DirectMedia Layer.
		/// The SDL device works under all platforms supported by SDL.
		/// </summary>
		SDL = EIDT_SDL,

		/// <summary>
		/// A device for raw framebuffer access.
		/// Best used with embedded devices and mobile systems.
		/// Does not need X11 or other graphical subsystems.
		/// May support hw-acceleration via OpenGL-ES for FBDirect.
		/// </summary>
		FrameBuffer = EIDT_FRAMEBUFFER,

		/// <summary>
		/// A simple text only device supported by all platforms.
		/// This device allows applications to run from the command line without opening a window.
		/// It can render the output of the software drivers to the console as ASCII.
		/// It only supports mouse and keyboard in Windows operating systems.
		/// </summary>
		Console = EIDT_CONSOLE,

		/// <summary>
		/// This selection allows Irrlicht to choose the best device from the ones available.
		/// If this selection is chosen then Irrlicht will try to use the IrrlichtDevice native to your operating system.
		/// If this is unavailable then the X11, SDL and then console device will be tried.
		/// This ensures that Irrlicht will run even if your platform is unsupported, although it may not be able to render anything.
		/// </summary>
		Best = EIDT_BEST
	};

} // end namespace IrrlichtLime
