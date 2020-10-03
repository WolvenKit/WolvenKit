#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Values defining the blend operation.
	/// </summary>
	public enum class BlendOperation
	{
		/// <summary>
		/// No blending happens.
		/// </summary>
		None = EBO_NONE,

		/// <summary>
		/// Default blending adds the color values.
		/// </summary>
		Add = EBO_ADD,

		/// <summary>
		/// This mode subtracts the color values.
		/// </summary>
		Subtract = EBO_SUBTRACT,

		/// <summary>
		/// This modes subtracts destination from source.
		/// </summary>
		RevSubtract = EBO_REVSUBTRACT,

		/// <summary>
		/// Choose minimum value of each color channel.
		/// </summary>
		Min = EBO_MIN,

		/// <summary>
		/// Choose maximum value of each color channel.
		/// </summary>
		Max = EBO_MAX,

		/// <summary>
		/// Choose minimum value of each color channel after applying blend factors, not widely supported.
		/// </summary>
		MinFactor = EBO_MIN_FACTOR,

		/// <summary>
		/// Choose maximum value of each color channel after applying blend factors, not widely supported.
		/// </summary>
		MaxFactor = EBO_MAX_FACTOR,

		/// <summary>
		/// Choose minimum value of each color channel based on alpha value, not widely supported.
		/// </summary>
		MinAlpha = EBO_MIN_ALPHA,

		/// <summary>
		/// Choose maximum value of each color channel based on alpha value, not widely supported.
		/// </summary>
		MaxAlpha = EBO_MAX_ALPHA
	};

} // end namespace Video
} // end namespace IrrlichtLime
