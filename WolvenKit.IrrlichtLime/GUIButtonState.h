#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Current state of buttons used for drawing sprites.
	/// <para>Note that up to 3 states can be active at the same time:
	/// <see cref="ButtonUp"/> or <see cref="ButtonDown"/>,
	/// <see cref="MouseOver"/> or <see cref="MouseOff"/>,
	/// <see cref="Focused"/> or <see cref="NotFocused"/>.</para>
	/// </summary>
	public enum class GUIButtonState
	{
		/// <summary>
		/// The button is not pressed.
		/// </summary>
		ButtonUp = EGBS_BUTTON_UP,

		/// <summary>
		/// The button is currently pressed down.
		/// </summary>
		ButtonDown = EGBS_BUTTON_DOWN,

		/// <summary>
		/// The mouse cursor is over the button.
		/// </summary>
		MouseOver = EGBS_BUTTON_MOUSE_OVER,

		/// <summary>
		/// The mouse cursor is not over the button.
		/// </summary>
		MouseOff = EGBS_BUTTON_MOUSE_OFF,

		/// <summary>
		/// The button has the focus.
		/// </summary>
		Focused = EGBS_BUTTON_FOCUSED,

		/// <summary>
		/// The button doesn't have the focus.
		/// </summary>
		NotFocused = EGBS_BUTTON_NOT_FOCUSED,

		/// <summary>
		/// The button is disabled. All other states are ignored in that case.
		/// </summary>
		ButtonDisabled = EGBS_BUTTON_DISABLED
	};

} // end namespace GUI
} // end namespace IrrlichtLime
