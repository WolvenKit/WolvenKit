#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Enumeration for default sizes.
	/// </summary>
	public enum class GUIDefaultSize
	{
		/// <summary>
		/// Default with / height of scrollbar. Also width of drop-down button in comboboxes.
		/// </summary>
		ScrollBarSize = EGDS_SCROLLBAR_SIZE,

		/// <summary>
		/// Height of menu.
		/// </summary>
		MenuHeight = EGDS_MENU_HEIGHT,

		/// <summary>
		/// Width and height of a window titlebar button (like minimize/maximize/close buttons). The titlebar height is also calculated from that.
		/// </summary>
		WindowButtonWidth = EGDS_WINDOW_BUTTON_WIDTH,

		/// <summary>
		/// Width of a checkbox check.
		/// </summary>
		CheckBoxWidth = EGDS_CHECK_BOX_WIDTH,

		[Obsolete("Deprecated. This may be removed by Irrlicht 1.9.")]
		/// <summary>
		/// Width of the message box.
		/// </summary>
		MessageBoxWidth = EGDS_MESSAGE_BOX_WIDTH,

		[Obsolete("Deprecated. This may be removed by Irrlicht 1.9.")]
		/// <summary>
		/// Height of the message box.
		/// </summary>
		MessageBoxHeight = EGDS_MESSAGE_BOX_HEIGHT,

		/// <summary>
		/// Width of a default button.
		/// </summary>
		ButtonWidth = EGDS_BUTTON_WIDTH,

		/// <summary>
		/// Height of a default button (OK and cancel buttons).
		/// </summary>
		ButtonHeight = EGDS_BUTTON_HEIGHT,

		/// <summary>
		/// Left distance for text from background.
		/// </summary>
		TextDistanceX = EGDS_TEXT_DISTANCE_X,

		/// <summary>
		/// Top distance for text from background.
		/// </summary>
		TextDistanceY = EGDS_TEXT_DISTANCE_Y,

		/// <summary>
		/// Distance for text in the title bar, from the left of the window rect.
		/// </summary>
		TitleBarTextDistanceX = EGDS_TITLEBARTEXT_DISTANCE_X,

		/// <summary>
		/// Distance for text in the title bar, from the top of the window rect.
		/// </summary>
		TitleBarTextDistanceY = EGDS_TITLEBARTEXT_DISTANCE_Y,

		/// <summary>
		/// Free space in a messagebox between borders and contents on all sides.
		/// </summary>
		MessageBoxGapSpace = EGDS_MESSAGE_BOX_GAP_SPACE,

		/// <summary>
		/// Minimal space to reserve for messagebox text-width.
		/// </summary>
		MessageBoxMinTextWidth = EGDS_MESSAGE_BOX_MIN_TEXT_WIDTH,

		/// <summary>
		/// Maximal space to reserve for messagebox text-width.
		/// </summary>
		MessageBoxMaxTextWidth = EGDS_MESSAGE_BOX_MAX_TEXT_WIDTH,

		/// <summary>
		/// Minimal space to reserve for messagebox text-height.
		/// </summary>
		MessageBoxMinTextHeight = EGDS_MESSAGE_BOX_MIN_TEXT_HEIGHT,

		/// <summary>
		/// Maximal space to reserve for messagebox text-height.
		/// </summary>
		MessageBoxMaxTextHeight = EGDS_MESSAGE_BOX_MAX_TEXT_HEIGHT,

		/// <summary>
		/// Pixels to move an unscaled button image to the right when a button is pressed and the unpressed image looks identical.
		/// </summary>
		ButtonPressedImageOffsetX = EGDS_BUTTON_PRESSED_IMAGE_OFFSET_X,

		/// <summary>
		/// Pixels to move an unscaled button image down when a button is pressed and the unpressed image looks identical.
		/// </summary>
		ButtonPressedImageOffsetY = EGDS_BUTTON_PRESSED_IMAGE_OFFSET_Y,

		/// <summary>
		/// Pixels to move the button text to the right when a button is pressed.
		/// </summary>
		ButtonPressedTextOffsetX = EGDS_BUTTON_PRESSED_TEXT_OFFSET_X,

		/// <summary>
		/// Pixels to move the button text down when a button is pressed.
		/// </summary>
		ButtonPressedTextOffsetY = EGDS_BUTTON_PRESSED_TEXT_OFFSET_Y,

		/// <summary>
		/// Pixels to move an unscaled button sprite to the right when a button is pressed.
		/// </summary>
		ButtonPressedSpriteOffsetX = EGDS_BUTTON_PRESSED_SPRITE_OFFSET_X,

		/// <summary>
		/// Pixels to move an unscaled button sprite down when a button is pressed.
		/// </summary>
		ButtonPressedSpriteOffsetY = EGDS_BUTTON_PRESSED_SPRITE_OFFSET_Y
	};

} // end namespace GUI
} // end namespace IrrlichtLime
