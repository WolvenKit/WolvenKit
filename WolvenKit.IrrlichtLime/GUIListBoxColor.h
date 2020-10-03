#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Enumeration for listbox colors.
	/// </summary>
	public enum class GUIListBoxColor
	{
		/// <summary>
		/// Color of text.
		/// </summary>
		Text = EGUI_LBC_TEXT,

		/// <summary>
		/// Color of selected text.
		/// </summary>
		SelectedText = EGUI_LBC_TEXT_HIGHLIGHT,

		/// <summary>
		/// Color of icon.
		/// </summary>
		Icon = EGUI_LBC_ICON,

		/// <summary>
		/// Color of selected icon.
		/// </summary>
		SelectedIcon = EGUI_LBC_ICON_HIGHLIGHT
	};

} // end namespace GUI
} // end namespace IrrlichtLime
