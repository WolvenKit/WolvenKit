#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Hardware mapping hints.
	/// </summary>
	public enum class HardwareMappingHint
	{
		/// <summary>
		/// Don't store on the hardware.
		/// </summary>
		Never = EHM_NEVER,

		/// <summary>
		/// Rarely changed, usually stored completely on the hardware.
		/// </summary>
		Static = EHM_STATIC,

		/// <summary>
		/// Sometimes changed, driver optimized placement.
		/// </summary>
		Dynamic = EHM_DYNAMIC,

		/// <summary>
		/// Always changed, cache optimizing on the GPU.
		/// </summary>
		Stream = EHM_STREAM
	};

} // end namespace Scene
} // end namespace IrrlichtLime
