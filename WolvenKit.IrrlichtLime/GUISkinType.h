#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Enumeration of available default skins.
	/// </summary>
	public enum class GUISkinType
	{
		/// <summary>
		/// Default windows look and feel.
		/// </summary>
		WindowsClassic = EGST_WINDOWS_CLASSIC,

		/// <summary>
		/// Like <see cref="WindowsClassic"/>, but with metallic shaded windows and buttons.
		/// </summary>
		WindowsMetallic = EGST_WINDOWS_METALLIC,

		/// <summary>
		/// Burning's skin.
		/// </summary>
		BurningSkin = EGST_BURNING_SKIN,

		/// <summary>
		/// An unknown skin, not serializable at present.
		/// </summary>
		Unknown = EGST_UNKNOWN
	};

} // end namespace GUI
} // end namespace IrrlichtLime
