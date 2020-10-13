#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Alignment types for a GUI element relative to its parent.
	/// </summary>
	public enum class GUIAlignment
	{
		/// <summary>
		/// Aligned to parent's top or left side (default).
		/// </summary>
		UpperLeft = EGUIA_UPPERLEFT,

		/// <summary>
		/// Aligned to parent's bottom or right side.
		/// </summary>
		LowerRight = EGUIA_LOWERRIGHT,

		/// <summary>
		/// Aligned to the center of parent.
		/// </summary>
		Center = EGUIA_CENTER,

		/// <summary>
		/// Stretched to fit parent.
		/// </summary>
		Scale = EGUIA_SCALE
	};

} // end namespace GUI
} // end namespace IrrlichtLime
