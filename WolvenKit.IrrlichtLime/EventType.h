#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {

	/// <summary>
	/// Enumeration for all event types there are.
	/// </summary>
	public enum class EventType
	{
		/// <summary>
		/// An event of the graphical user interface.
		/// GUI events are created by the GUI environment or the GUI elements in response to mouse or keyboard events.
		/// When a GUI element receives an event it will either process it and return true, or pass the event to its parent.
		/// If an event is not absorbed before it reaches the root element then it will then be passed to the user receiver.
		/// </summary>
		GUI = EET_GUI_EVENT,

		/// <summary>
		/// A mouse input event.
		/// Mouse events are created by the device and passed to <c>IrrlichtDevice.PostEventFromUser()</c> in response to mouse input received from the operating system.
		/// Mouse events are first passed to the user receiver, then to the GUI environment and its elements,
		/// then finally the input receiving scene manager where it is passed to the active camera.
		/// </summary>
		Mouse = EET_MOUSE_INPUT_EVENT,

		/// <summary>
		/// A key input event.
		/// Like mouse events, keyboard events are created by the device and passed to <c>IrrlichtDevice.PostEventFromUser()</c>.
		/// They take the same path as mouse events.
		/// </summary>
		Key = EET_KEY_INPUT_EVENT,

		/// <summary>
		/// A joystick (joypad, gamepad) input event.
		/// Joystick events are created by polling all connected joysticks once per <c>device.Run()</c> and then passing the events to <c>IrrlichtDevice.PostEventFromUser()</c>.
		/// They take the same path as mouse events.
		/// This even fully implemented for Windows and SDL.
		/// Implemented with POV hat issues for Linux.
		/// Not implemeted for MacOS / Other.
		/// </summary>
		Joystick = EET_JOYSTICK_INPUT_EVENT,

		/// <summary>
		/// A log event.
		/// Log events are only passed to the user receiver if there is one. If they are absorbed by the user receiver then no text will be sent to the console.
		/// </summary>
		Log = EET_LOG_TEXT_EVENT,

		/// <summary>
		/// A user event with user data.
		/// This is not used by Irrlicht and can be used to send user specific data though the system.
		/// The Irrlicht 'window handle' can be obtained from <c>IrrlichtDevice.GetExposedVideoData()</c>.
		/// The usage and behavior depends on the operating system.
		/// Windows: send a WM_USER message to the Irrlicht window; the wParam and lParam will be used to populate the UserData1 and UserData2 members of the <c>UserEvent</c>.
		/// Linux: send a ClientMessage via XSendEvent to the Irrlicht window; the data.l[0] and data.l[1] members will be cast to s32 and used as UserData1 and UserData2.
		/// MacOS: not yet implemented.
		/// </summary>
		User = EET_USER_EVENT
	};

} // end namespace IrrlichtLime
