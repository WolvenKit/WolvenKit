#pragma once
#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	[Flags]
	/// <summary>
	/// An enumeration for all types of automatic culling for built-in scene nodes.
	/// </summary>
	public enum class CullingType
	{
		/// <summary>
		/// No culling.
		/// </summary>
		Off = EAC_OFF,

		/// <summary>
		/// Box culling.
		/// </summary>
		Box = EAC_BOX,

		/// <summary>
		/// Frustrum box culling.
		/// </summary>
		FrustumBox = EAC_FRUSTUM_BOX,

		/// <summary>
		/// Frustrum sphere culling.
		/// </summary>
		FrustumSphere = EAC_FRUSTUM_SPHERE,

		/// <summary>
		/// Occlusion query culling.
		/// </summary>
		OcclusionQuery = EAC_OCC_QUERY
	};

} // end namespace Scene
} // end namespace IrrlichtLime
