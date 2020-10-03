#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Customizable symbols for GUI.
	/// </summary>
	public enum class GUIDefaultIcon
	{
		/// <summary>
		/// Maximize window button.
		/// </summary>
		WindowMaximize = EGDI_WINDOW_MAXIMIZE,

		/// <summary>
		/// Restore window button.
		/// </summary>
		WindowRestore = EGDI_WINDOW_RESTORE,

		/// <summary>
		/// Close window button.
		/// </summary>
		WindowClose = EGDI_WINDOW_CLOSE,

		/// <summary>
		/// Minimize window button.
		/// </summary>
		WindowMinimize = EGDI_WINDOW_MINIMIZE,

		/// <summary>
		/// Resize icon for bottom right corner of a window.
		/// </summary>
		WindowResize = EGDI_WINDOW_RESIZE,

		/// <summary>
		/// Scroll bar up button.
		/// </summary>
		CursorUp = EGDI_CURSOR_UP,

		/// <summary>
		/// Scroll bar down button.
		/// </summary>
		CursorDown = EGDI_CURSOR_DOWN,

		/// <summary>
		/// Scroll bar left button.
		/// </summary>
		CursorLeft = EGDI_CURSOR_LEFT,

		/// <summary>
		/// Scroll bar right button.
		/// </summary>
		CursorRight = EGDI_CURSOR_RIGHT,

		/// <summary>
		/// Icon for menu children.
		/// </summary>
		MenuMore = EGDI_MENU_MORE,

		/// <summary>
		/// Tick for checkbox.
		/// </summary>
		CheckBoxChecked = EGDI_CHECK_BOX_CHECKED,

		/// <summary>
		/// Down arrow for dropdown menus.
		/// </summary>
		DropDown = EGDI_DROP_DOWN,

		/// <summary>
		/// Smaller up arrow.
		/// </summary>
		CursorUp_Small = EGDI_SMALL_CURSOR_UP,

		/// <summary>
		/// Smaller down arrow.
		/// </summary>
		CursorDown_Small = EGDI_SMALL_CURSOR_DOWN,

		/// <summary>
		/// Selection dot in a radio button.
		/// </summary>
		RadioButtonChecked = EGDI_RADIO_BUTTON_CHECKED,

		/// <summary>
		/// Icon indicating that there is more content to the left (e.g. &lt;&lt;).
		/// </summary>
		MoreLeft = EGDI_MORE_LEFT,

		/// <summary>
		/// Icon indicating that there is more content to the right (e.g. &gt;&gt;).
		/// </summary>
		MoreRight = EGDI_MORE_RIGHT,

		/// <summary>
		/// Icon indicating that there is more content above.
		/// </summary>
		MoreUp = EGDI_MORE_UP,

		/// <summary>
		/// Icon indicating that there is more content below.
		/// </summary>
		MoreDown = EGDI_MORE_DOWN,

		/// <summary>
		/// Plus icon for trees.
		/// </summary>
		Expand = EGDI_EXPAND,

		/// <summary>
		/// Minus icon for trees.
		/// </summary>
		Collapse = EGDI_COLLAPSE,

		/// <summary>
		/// File icon for file selection.
		/// </summary>
		File = EGDI_FILE,

		/// <summary>
		/// Folder icon for file selection.
		/// </summary>
		Directory = EGDI_DIRECTORY
	};

} // end namespace GUI
} // end namespace IrrlichtLime
