#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Enumeration for different types of lights.
	/// </summary>
	public enum class LightType
	{
		/// <summary>
		/// Point light, it has a position in space and radiates light in all directions.
		/// </summary>
		Point = ELT_POINT,

		/// <summary>
		/// Spot light, it has a position in space, a direction, and a limited cone of influence.
		/// </summary>
		Spot = ELT_SPOT,

		/// <summary>
		/// Directional light, coming from a direction from an infinite distance.
		/// </summary>
		Directional = ELT_DIRECTIONAL
	};

} // end namespace Video
} // end namespace IrrlichtLime
