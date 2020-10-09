#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {

/// <summary>
/// Information on a joystick, returned from <c>device.ActivateJoysticks()</c>.
/// </summary>
public ref class JoystickInfo
{
public:

	/// <summary>
	/// An indication of whether the joystick has a POV hat.
	/// </summary>
	enum class PovHatPresence
	{
		/// <summary>
		/// A hat is definitely present.
		/// </summary>
		Present = SJoystickInfo::POV_HAT_PRESENT,

		/// <summary>
		/// A hat is definitely not present.
		/// </summary>
		Absent = SJoystickInfo::POV_HAT_ABSENT,

		/// <summary>
		/// The presence or absence of a hat cannot be determined.
		/// </summary>
		Unknown = SJoystickInfo::POV_HAT_UNKNOWN
	};

	/// <summary>
	/// The number of axes that the joystick has, i.e. X, Y, Z, R, U, V.
	/// Note: with a Linux device, the POV hat (if any) will use two axes. These will be included in this count.
	/// </summary>
	u32 AxisCount;

	/// <summary>
	/// The number of buttons that the joystick has.
	/// </summary>
	u32 ButtonCount;

	/// <summary>
	/// The ID of the joystick.
	/// This is an internal Irrlicht index; it does not map directly to any particular hardware joystick.
	/// It corresponds to the <c>JoystickEvent.Joystick</c> value.
	/// </summary>
	u8 Joystick;

	/// <summary>
	/// The name that the joystick uses to identify itself.
	/// </summary>
	String^ Name;

	/// <summary>
	/// An indication of whether the joystick has a POV hat.
	/// A Windows device will identify the presence or absence of the POV hat.
	/// A Linux device cannot, and will always return <see cref="PovHatPresence::Unknown"/>.
	/// </summary>
	PovHatPresence PovHat;

internal:
	
	JoystickInfo(const SJoystickInfo& copy)
		: AxisCount(copy.Axes)
		, ButtonCount(copy.Buttons)
		, Joystick(copy.Joystick)
		, Name(gcnew String(copy.Name.c_str()))
		, PovHat((PovHatPresence)copy.PovHat) {}
};

} // end namespace IrrlichtLime
