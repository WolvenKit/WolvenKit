#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Video aspect ratios.
	/// Use <c>VideoMode.GetAspectRatio()</c> to get the value.
	/// </summary>
	public enum class VideoModeAspectRatio
	{
		/// <summary>
		/// Other aspect ratio.
		/// </summary>
		Other,

		/// <summary>
		/// 3x2 aspect ratio.
		/// </summary>
		_3x2,

		/// <summary>
		/// 4x3 aspect ratio.
		/// </summary>
		_4x3,

		/// <summary>
		/// 5x3 aspect ratio.
		/// </summary>
		_5x3,

		/// <summary>
		/// 5x4 aspect ratio.
		/// </summary>
		_5x4,

		/// <summary>
		/// 16x9 aspect ratio.
		/// </summary>
		_16x9,

		/// <summary>
		/// 16x10 aspect ratio.
		/// </summary>
		_16x10
	};

} // end namespace Video
} // end namespace IrrlichtLime
