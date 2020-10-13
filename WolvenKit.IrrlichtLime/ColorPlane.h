#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	[Flags]
	/// <summary>
	/// Enumeration values for enabling/disabling color planes for rendering.
	/// </summary>
	public enum class ColorPlane
	{
		/// <summary>
		/// No color enabled.
		/// </summary>
		None = ECP_NONE,

		/// <summary>
		/// Alpha enabled.
		/// </summary>
		Alpha = ECP_ALPHA,

		/// <summary>
		/// Red enabled.
		/// </summary>
		Red = ECP_RED,

		/// <summary>
		/// Green enabled.
		/// </summary>
		Green = ECP_GREEN,

		/// <summary>
		/// Blue enabled.
		/// </summary>
		Blue = ECP_BLUE,

		/// <summary>
		/// All colors, no alpha.
		/// </summary>
		RGB = ECP_RGB,

		/// <summary>
		/// All planes enabled.
		/// </summary>
		All = ECP_ALL
	};

} // end namespace Video
} // end namespace IrrlichtLime
