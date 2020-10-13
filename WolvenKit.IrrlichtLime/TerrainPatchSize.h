#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Enumeration for patch sizes specifying the size of patches in the <c>TerrainSceneNode</c>.
	/// </summary>
	public enum class TerrainPatchSize
	{
		/// <summary>
		/// Patch size of 9, at most, use 4 levels of detail with this patch size.
		/// </summary>
		_9 = ETPS_9,

		/// <summary>
		/// Patch size of 17, at most, use 5 levels of detail with this patch size.
		/// </summary>
		_17 = ETPS_17,

		/// <summary>
		/// Patch size of 33, at most, use 6 levels of detail with this patch size.
		/// </summary>
		_33 = ETPS_33,

		/// <summary>
		/// Patch size of 65, at most, use 7 levels of detail with this patch size.
		/// </summary>
		_65 = ETPS_65,

		/// <summary>
		/// Patch size of 129, at most, use 8 levels of detail with this patch size.
		/// </summary>
		_129 = ETPS_129
	};

} // end namespace Scene
} // end namespace IrrlichtLime
