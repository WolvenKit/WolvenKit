#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Interpolation modes.
	/// </summary>
	public enum class InterpolationMode
	{
		/// <summary>
		/// Constant does use the current key-values without interpolation.
		/// </summary>
		Constant = EIM_CONSTANT,

		/// <summary>
		/// Linear interpolation.
		/// </summary>
		Linear = EIM_LINEAR
	};

} // end namespace Scene
} // end namespace IrrlichtLime
