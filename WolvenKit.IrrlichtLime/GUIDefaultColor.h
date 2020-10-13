#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Enumeration for skin colors.
	/// </summary>
	public enum class GUIDefaultColor
	{
		/// <summary>
		/// Dark shadow for three-dimensional display elements.
		/// </summary>
		_3dDarkShadow = EGDC_3D_DARK_SHADOW,

		/// <summary>
		/// Shadow color for three-dimensional display elements (for edges facing away from the light source).
		/// </summary>
		_3dShadow = EGDC_3D_SHADOW,

		/// <summary>
		/// Face color for three-dimensional display elements and for dialog box backgrounds.
		/// </summary>
		_3dFace = EGDC_3D_FACE,

		/// <summary>
		/// Highlight color for three-dimensional display elements (for edges facing the light source).
		/// </summary>
		_3dHighLight = EGDC_3D_HIGH_LIGHT,

		/// <summary>
		/// Light color for three-dimensional display elements (for edges facing the light source).
		/// </summary>
		_3dLight = EGDC_3D_LIGHT,

		/// <summary>
		/// Active window border.
		/// </summary>
		ActiveBorder = EGDC_ACTIVE_BORDER,

		/// <summary>
		/// Active window title bar text.
		/// </summary>
		ActiveCaption = EGDC_ACTIVE_CAPTION,

		/// <summary>
		/// Background color of multiple document interface (MDI) applications.
		/// </summary>
		AppWorkspace = EGDC_APP_WORKSPACE,

		/// <summary>
		/// Text on a button.
		/// </summary>
		ButtonText = EGDC_BUTTON_TEXT,

		/// <summary>
		/// Grayed (disabled) text.
		/// </summary>
		GrayText = EGDC_GRAY_TEXT,

		/// <summary>
		/// Item(s) selected in a control.
		/// </summary>
		HighLight = EGDC_HIGH_LIGHT,

		/// <summary>
		/// Text of item(s) selected in a control.
		/// </summary>
		HighLightText = EGDC_HIGH_LIGHT_TEXT,

		/// <summary>
		/// Inactive window border.
		/// </summary>
		InactiveBorder = EGDC_INACTIVE_BORDER,

		/// <summary>
		/// Inactive window caption.
		/// </summary>
		InactiveCaption = EGDC_INACTIVE_CAPTION,

		/// <summary>
		/// Tool tip text color.
		/// </summary>
		TooltipText = EGDC_TOOLTIP,

		/// <summary>
		/// Tool tip background color.
		/// </summary>
		TooltipBackground = EGDC_TOOLTIP_BACKGROUND,

		/// <summary>
		/// Scrollbar gray area.
		/// </summary>
		ScrollBar = EGDC_SCROLLBAR,

		/// <summary>
		/// Window background.
		/// </summary>
		WindowBackground = EGDC_WINDOW,

		/// <summary>
		/// Window symbols like on close buttons, scroll bars and check boxes.
		/// </summary>
		WindowSymbol = EGDC_WINDOW_SYMBOL,

		/// <summary>
		/// Icons in a list or tree.
		/// </summary>
		Icon = EGDC_ICON,

		/// <summary>
		/// Selected icons in a list or tree.
		/// </summary>
		IconHighLight = EGDC_ICON_HIGH_LIGHT,

		/// <summary>
		/// Grayed (disabled) window symbols like on close buttons, scroll bars and check boxes.
		/// </summary>
		GrayWindowSymbol = EGDC_GRAY_WINDOW_SYMBOL,

		/// <summary>
		/// Window background for editable field (editbox, checkbox-field).
		/// </summary>
		Editable = EGDC_EDITABLE,

		/// <summary>
		/// Grayed (disabled) window background for editable field (editbox, checkbox-field).
		/// </summary>
		GrayEditable = EGDC_GRAY_EDITABLE,

		/// <summary>
		/// Show focus of window background for editable field (editbox or when checkbox-field is pressed).
		/// </summary>
		FocusedEditable = EGDC_FOCUSED_EDITABLE
	};

} // end namespace GUI
} // end namespace IrrlichtLime
