#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	[Flags]
	/// <summary>
	/// Enumeration for the flags of clear buffer.
	/// </summary>
	public enum class ClearBufferFlag
	{
		/// <summary>
		/// None.
		/// </summary>
		None = ECBF_NONE,

		/// <summary>
		/// Color buffer.
		/// </summary>
		Color = ECBF_COLOR,

		/// <summary>
		/// Depth buffer.
		/// </summary>
		Depth = ECBF_DEPTH,

		/// <summary>
		/// Stencil buffer.
		/// </summary>
		Stencil = ECBF_STENCIL,

		/// <summary>
		/// All buffers (color, depth, stencil).
		/// </summary>
		All = ECBF_ALL
	};

} // end namespace Video
} // end namespace IrrlichtLime
