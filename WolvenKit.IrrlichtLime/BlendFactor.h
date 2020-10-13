#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Flag for <c>MaterialType.OneTextureBlend</c>, ( BlendFactor ) BlendFunc = source * sourceFactor + dest * destFactor.
	/// </summary>
	public enum class BlendFactor
	{
		/// <summary>
		/// src &amp; dest (0, 0, 0, 0).
		/// </summary>
		Zero = EBF_ZERO,

		/// <summary>
		/// src &amp; dest (1, 1, 1, 1).
		/// </summary>
		One = EBF_ONE,

		/// <summary>
		/// src (destR, destG, destB, destA).
		/// </summary>
		DstColor = EBF_DST_COLOR,

		/// <summary>
		/// src (1-destR, 1-destG, 1-destB, 1-destA).
		/// </summary>
		OneMinusDstColor = EBF_ONE_MINUS_DST_COLOR,

		/// <summary>
		/// dest (srcR, srcG, srcB, srcA).
		/// </summary>
		SrcColor = EBF_SRC_COLOR,

		/// <summary>
		/// dest (1-srcR, 1-srcG, 1-srcB, 1-srcA).
		/// </summary>
		OneMinusSrcColor = EBF_ONE_MINUS_SRC_COLOR,

		/// <summary>
		/// src &amp; dest (srcA, srcA, srcA, srcA).
		/// </summary>
		SrcAlpha = EBF_SRC_ALPHA,

		/// <summary>
		/// src &amp; dest (1-srcA, 1-srcA, 1-srcA, 1-srcA).
		/// </summary>
		OneMinusSrcAlpha = EBF_ONE_MINUS_SRC_ALPHA,

		/// <summary>
		/// src &amp; dest (destA, destA, destA, destA).
		/// </summary>
		DstAlpha = EBF_DST_ALPHA,

		/// <summary>
		/// src &amp; dest (1-destA, 1-destA, 1-destA, 1-destA).
		/// </summary>
		OneMinusDstAlpha = EBF_ONE_MINUS_DST_ALPHA,

		/// <summary>
		/// src (min(srcA, 1-destA), idem, ...).
		/// </summary>
		SrcAlphaSaturate = EBF_SRC_ALPHA_SATURATE
	};

} // end namespace Video
} // end namespace IrrlichtLime
