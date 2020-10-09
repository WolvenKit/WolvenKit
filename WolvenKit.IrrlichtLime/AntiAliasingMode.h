#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	[Flags]
	/// <summary>
	/// These flags are used to specify the anti-aliasing and smoothing modes.
	/// <para>Techniques supported are multisampling, geometry smoothing, and alpha to coverage.
	/// Some drivers don't support a per-material setting of the anti-aliasing modes.
	/// In those cases, FSAA / multisampling is defined by the device mode chosen upon creation via <c>IrrlichtCreationParameters</c>.</para>
	/// </summary>
	public enum class AntiAliasingMode
	{
		/// <summary>
		/// Use to turn off anti-aliasing for this material.
		/// </summary>
		Off = EAAM_OFF,

		/// <summary>
		/// Default anti-aliasing mode.
		/// </summary>
		Simple = EAAM_SIMPLE,

		/// <summary>
		/// High-quality anti-aliasing, not always supported, automatically enables <see cref="Simple"/> mode.
		/// </summary>
		Quality = EAAM_QUALITY,

		/// <summary>
		/// Line smoothing. Careful, enabling this can lead to software emulation under OpenGL.
		/// </summary>
		LineSmooth = EAAM_LINE_SMOOTH,

		/// <summary>
		/// Point smoothing, often in software and slow, only with OpenGL.
		/// </summary>
		PointSmooth = EAAM_POINT_SMOOTH,

		/// <summary>
		/// All typical anti-alias and smooth modes.
		/// </summary>
		FullBasic = EAAM_FULL_BASIC,

		/// <summary>
		/// Enhanced anti-aliasing for transparent materials. Usually used with <c>MaterialType.TransparentAlphaChannelRef</c> and multisampling.
		/// </summary>
		AlphaToCoverage = EAAM_ALPHA_TO_COVERAGE
	};

} // end namespace Video
} // end namespace IrrlichtLime
