#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Texture coord clamp mode outside [0.0, 1.0].
	/// </summary>
	public enum class TextureClamp
	{
		/// <summary>
		/// Texture repeats.
		/// </summary>
		Repeat = ETC_REPEAT,

		/// <summary>
		/// Texture is clamped to the last pixel.
		/// </summary>
		Clamp = ETC_CLAMP,

		/// <summary>
		/// Texture is clamped to the edge pixel.
		/// </summary>
		ClampToEdge = ETC_CLAMP_TO_EDGE,

		/// <summary>
		/// Texture is clamped to the border pixel (if exists).
		/// </summary>
		ClampToBorder = ETC_CLAMP_TO_BORDER,

		/// <summary>
		/// Texture is alternatingly mirrored (0..1..0..1..0..).
		/// </summary>
		Mirror = ETC_MIRROR,

		/// <summary>
		/// Texture is mirrored once and then clamped (0..1..0).
		/// </summary>
		MirrorClamp = ETC_MIRROR_CLAMP,

		/// <summary>
		/// Texture is mirrored once and then clamped to edge.
		/// </summary>
		MirrorClampToEdge = ETC_MIRROR_CLAMP_TO_EDGE,

		/// <summary>
		/// Texture is mirrored once and then clamped to border.
		/// </summary>
		MirrorClampToBorder = ETC_MIRROR_CLAMP_TO_BORDER
	};

} // end namespace Video
} // end namespace IrrlichtLime
