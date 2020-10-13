// Copyright (C) 2002-2007 Nikolaus Gebhardt
// Copyright (C) 2007-2012 Christian Stehno
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_IRR_DEVICE_FB_H_INCLUDED__
#define __C_IRR_DEVICE_FB_H_INCLUDED__

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_FB_DEVICE_

#include "CIrrDeviceStub.h"
#include "SIrrCreationParameters.h"
#include "IrrlichtDevice.h"
#include "IImagePresenter.h"
#include "ICursorControl.h"

#define KeySym s32
#include <linux/fb.h>
#include <linux/kd.h>

namespace irr
{
	class CIrrDeviceFB : public CIrrDeviceStub, public video::IImagePresenter
	{
	public:

		//! constructor
		CIrrDeviceFB(const SIrrlichtCreationParameters& params);

		//! destructor
		virtual ~CIrrDeviceFB();

		//! runs the device. Returns false if device wants to be deleted
		virtual bool run() _IRR_OVERRIDE_;

		//! Cause the device to temporarily pause execution and let other processes to run
		// This should bring down processor usage without major performance loss for Irrlicht
		virtual void yield() _IRR_OVERRIDE_;

		//! Pause execution and let other processes to run for a specified amount of time.
		virtual void sleep(u32 timeMs, bool pauseTimer) _IRR_OVERRIDE_;

		//! sets the caption of the window
		virtual void setWindowCaption(const wchar_t* text) _IRR_OVERRIDE_;

		//! returns if window is active. if not, nothing need to be drawn
		virtual bool isWindowActive() const _IRR_OVERRIDE_;

		//! returns if window has focus
		virtual bool isWindowFocused() const _IRR_OVERRIDE_;

		//! returns if window is minimized
		virtual bool isWindowMinimized() const _IRR_OVERRIDE_;

		//! Minimizes window
		virtual void minimizeWindow() _IRR_OVERRIDE_;

		//! Maximizes window
		virtual void maximizeWindow() _IRR_OVERRIDE_;

		//! Restores original window size
		virtual void restoreWindow() _IRR_OVERRIDE_;

		//! returns current window position (not supported for this device)
		virtual core::position2di getWindowPosition() _IRR_OVERRIDE_
		{
			return core::position2di(-1, -1);
		}

		//! presents a surface in the client area
		virtual bool present(video::IImage* surface, void* windowId = 0, core::rect<s32>* src=0 ) _IRR_OVERRIDE_;

		//! notifies the device that it should close itself
		virtual void closeDevice() _IRR_OVERRIDE_;

		//! Sets if the window should be resizeable in windowed mode.
		virtual void setResizable(bool resize=false) _IRR_OVERRIDE_;

		//! Returns the type of this device
		virtual E_DEVICE_TYPE getType() const _IRR_OVERRIDE_;

	private:

		//! create the driver
		void createDriver();

		bool createWindow(const core::dimension2d<u32>& windowSize, u32 bits);

		//! Implementation of the cursor control
		class CCursorControl : public gui::ICursorControl
		{
		public:

			CCursorControl(CIrrDeviceFB* dev, bool null)
				: Device(dev), IsVisible(true), Null(null)
			{
				Device->grab();
			}

			~CCursorControl()
			{
				Device->drop();
			}

			//! Changes the visible state of the mouse cursor.
			virtual void setVisible(bool visible) _IRR_OVERRIDE_
			{
				IsVisible = visible;
			}

			//! Returns if the cursor is currently visible.
			virtual bool isVisible() const _IRR_OVERRIDE_
			{
				return IsVisible;
			}

			//! Sets the new position of the cursor.
			virtual void setPosition(const core::position2d<f32> &pos) _IRR_OVERRIDE_
			{
				setPosition(pos.X, pos.Y);
			}

			//! Sets the new position of the cursor.
			virtual void setPosition(f32 x, f32 y) _IRR_OVERRIDE_
			{
				setPosition((s32)(x*Device->CreationParams.WindowSize.Width), (s32)(y*Device->CreationParams.WindowSize.Height));
			}

			//! Sets the new position of the cursor.
			virtual void setPosition(const core::position2d<s32> &pos) _IRR_OVERRIDE_
			{
				setPosition(pos.X, pos.Y);
			}

			//! Sets the new position of the cursor.
			virtual void setPosition(s32 x, s32 y) _IRR_OVERRIDE_
			{
			}

			//! Returns the current position of the mouse cursor.
			virtual const core::position2d<s32>& getPosition() _IRR_OVERRIDE_
			{
				updateCursorPos();
				return CursorPos;
			}

			//! Returns the current position of the mouse cursor.
			virtual core::position2d<f32> getRelativePosition() _IRR_OVERRIDE_
			{
				updateCursorPos();
				return core::position2d<f32>(CursorPos.X / (f32)Device->CreationParams.WindowSize.Width,
					CursorPos.Y / (f32)Device->CreationParams.WindowSize.Height);
			}

			virtual void setReferenceRect(core::rect<s32>* rect=0) _IRR_OVERRIDE_
			{
			}

		private:

			void updateCursorPos()
			{
			}

			core::position2d<s32> CursorPos;
			CIrrDeviceFB* Device;
			bool IsVisible;
			bool Null;
		};

		friend class CCursorControl;

		int Framebuffer;
		int EventDevice;
		int KeyboardDevice;
		struct fb_fix_screeninfo fbfixscreeninfo;
		struct fb_var_screeninfo fbscreeninfo;
		struct fb_var_screeninfo oldscreeninfo;
		long KeyboardMode;
		u8* SoftwareImage;

		u32 Pitch;
		video::ECOLOR_FORMAT FBColorFormat;
		bool Close;

		struct SKeyMap
		{
			SKeyMap() {}
			SKeyMap(s32 x11, s32 win32)
				: X11Key(x11), Win32Key(win32)
			{
			}

			KeySym X11Key;
			s32 Win32Key;

			bool operator<(const SKeyMap& o) const
			{
				return X11Key<o.X11Key;
			}
		};

		core::array<SKeyMap> KeyMap;
	};


} // end namespace irr

#endif // _IRR_USE_FB_DEVICE_
#endif // __C_IRR_DEVICE_FB_H_INCLUDED__

