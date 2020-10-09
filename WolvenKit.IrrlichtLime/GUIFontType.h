#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// An enum for the different types of GUI font.
	/// </summary>
	public enum class GUIFontType
	{
		/// <summary>
		/// Bitmap fonts loaded from an XML file or a texture.
		/// </summary>
		Bitmap = EGFT_BITMAP,

		/// <summary>
		/// Scalable vector fonts loaded from an XML file.
		/// These fonts reside in system memory and use no video memory until they are displayed.
		/// These are slower than bitmap fonts but can be easily scaled and rotated.
		/// </summary>
		Vector = EGFT_VECTOR,

		/// <summary>
		/// A font which uses a the native API provided by the operating system. Currently not used.
		/// </summary>
		OS = EGFT_OS,

		/// <summary>
		/// An external font type provided by the user.
		/// </summary>
		Custom = EGFT_CUSTOM
	};

} // end namespace GUI
} // end namespace IrrlichtLime
