#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	[Flags]
	/// <summary>
	/// Enumeration bitflag for when to validate the text typed into the spinbox.
	/// Default used by Irrlicht is: <see cref="Enter"/> | <see cref="LoseFocus"/>)
	/// </summary>
	public enum class GUISpinBoxValidation
	{
		/// <summary>
		/// Does not validate typed text, probably a bad idea setting this usually.
		/// </summary>
		Never = EGUI_SBV_NEVER,

		/// <summary>
		/// Validate on each change. Was default up to Irrlicht 1.8.
		/// </summary>
		Change = EGUI_SBV_CHANGE,

		/// <summary>
		/// Validate when enter was pressed.
		/// </summary>
		Enter = EGUI_SBV_ENTER,

		/// <summary>
		/// Validate when the editbox loses the focus.
		/// </summary>
		LoseFocus = EGUI_SBV_LOSE_FOCUS
	};

} // end namespace GUI
} // end namespace IrrlichtLime
