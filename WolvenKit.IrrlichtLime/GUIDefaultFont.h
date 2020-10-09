#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Customizable fonts.
	/// </summary>
	public enum class GUIDefaultFont
	{
		/// <summary>
		/// For static text, edit boxes, lists and most other places.
		/// </summary>
		Default = EGDF_DEFAULT,

		/// <summary>
		/// Font for buttons.
		/// </summary>
		Button = EGDF_BUTTON,

		/// <summary>
		/// Font for window title bars.
		/// </summary>
		Window = EGDF_WINDOW,

		/// <summary>
		/// Font for menu items.
		/// </summary>
		Menu = EGDF_MENU,

		/// <summary>
		/// Font for tool tips.
		/// </summary>
		Tooltip = EGDF_TOOLTIP
	};

} // end namespace GUI
} // end namespace IrrlichtLime
