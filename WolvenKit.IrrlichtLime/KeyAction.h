#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {

	/// <summary>
	/// Enumeration for key actions. Used for example in the FPS Camera.
	/// </summary>
	public enum class KeyAction
	{
		/// <summary>
		/// Move forward.
		/// </summary>
		MoveForward = EKA_MOVE_FORWARD,

		/// <summary>
		/// Move backward.
		/// </summary>
		MoveBackward = EKA_MOVE_BACKWARD,

		/// <summary>
		/// Strafe left.
		/// </summary>
		StrafeLeft = EKA_STRAFE_LEFT,

		/// <summary>
		/// Strafe right.
		/// </summary>
		StrafeRight = EKA_STRAFE_RIGHT,

		/// <summary>
		/// Jump.
		/// </summary>
		Jump = EKA_JUMP_UP,

		/// <summary>
		/// Crouch.
		/// </summary>
		Crouch = EKA_CROUCH,

		/// <summary>
		/// Rotate left.
		/// </summary>
		RotateLeft = EKA_ROTATE_LEFT,

		/// <summary>
		/// Rotate right.
		/// </summary>
		RotateRight = EKA_ROTATE_RIGHT
	};

} // end namespace IrrlichtLime
