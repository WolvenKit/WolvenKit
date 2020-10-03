#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	[Flags]
	/// <summary>
	/// Source of the alpha value to take.
	/// <para>This is currently only supported in <c>MaterialType.OneTextureBlend</c>.
	/// You can use an or'ed combination of values. Alpha values are modulated (multiplied).</para>
	/// </summary>
	public enum class AlphaSource
	{
		/// <summary>
		/// Use no alpha, somewhat redundant with other settings.
		/// </summary>
		None = EAS_NONE,

		/// <summary>
		/// Use vertex color alpha.
		/// </summary>
		VertexColor = EAS_VERTEX_COLOR,

		/// <summary>
		/// Use texture alpha channel.
		/// </summary>
		Texture = EAS_TEXTURE
	};

} // end namespace Video
} // end namespace IrrlichtLime
