#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {

	/// <summary>
	/// Enumeration for all mouse input events.
	/// </summary>
	public enum class MouseEventType
	{
		/// <summary>
		/// Left mouse button was pressed down.
		/// </summary>
		LeftDown = EMIE_LMOUSE_PRESSED_DOWN,

		/// <summary>
		/// Right mouse button was pressed down.
		/// </summary>
		RightDown = EMIE_RMOUSE_PRESSED_DOWN,

		/// <summary>
		/// Middle mouse button was pressed down.
		/// </summary>
		MiddleDown = EMIE_MMOUSE_PRESSED_DOWN,

		/// <summary>
		/// Left mouse button was left up.
		/// </summary>
		LeftUp = EMIE_LMOUSE_LEFT_UP,

		/// <summary>
		/// Right mouse button was left up.
		/// </summary>
		RightUp = EMIE_RMOUSE_LEFT_UP,

		/// <summary>
		/// Middle mouse button was left up.
		/// </summary>
		MiddleUp = EMIE_MMOUSE_LEFT_UP,

		/// <summary>
		/// The mouse cursor changed its position.
		/// </summary>
		Move = EMIE_MOUSE_MOVED,

		/// <summary>
		/// The mouse wheel was moved.
		/// Use Wheel value in event data to find out in what direction and how fast.
		/// </summary>
		Wheel = EMIE_MOUSE_WHEEL,

		/// <summary>
		/// Left mouse button double click.
		/// This event is generated after the second <see cref="LeftDown"/> event.
		/// </summary>
		LeftDoubleClick = EMIE_LMOUSE_DOUBLE_CLICK,

		/// <summary>
		/// Right mouse button double click.
		/// This event is generated after the second <see cref="RightDown"/> event.
		/// </summary>
		RightDoubleClick = EMIE_RMOUSE_DOUBLE_CLICK,

		/// <summary>
		/// Middle mouse button double click.
		/// This event is generated after the second <see cref="MiddleDown"/> event.
		/// </summary>
		MiddleDoubleClick = EMIE_MMOUSE_DOUBLE_CLICK,

		/// <summary>
		/// Left mouse button triple click.
		/// This event is generated after the third <see cref="LeftDown"/> event.
		/// </summary>
		LeftTripleClick = EMIE_LMOUSE_TRIPLE_CLICK,

		/// <summary>
		/// Right mouse button triple click.
		/// This event is generated after the third <see cref="RightDown"/> event.
		/// </summary>
		RightTripleClick = EMIE_RMOUSE_TRIPLE_CLICK,

		/// <summary>
		/// Middle mouse button triple click.
		/// This event is generated after the third <see cref="MiddleDown"/> event.
		/// </summary>
		MiddleTripleClick = EMIE_MMOUSE_TRIPLE_CLICK
	};

} // end namespace IrrlichtLime
