#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Enumeration for all vertex types there are.
	/// </summary>
	public enum class VertexType
	{
		/// <summary>
		/// Standard vertex type used by the Irrlicht engine (<c>Vertex3D</c>).
		/// </summary>
		Standard = EVT_STANDARD,

		/// <summary>
		/// Vertex with two texture coordinates (<c>Vertex3DTTCoords</c>).
		/// Usually used for geometry with lightmaps or other special materials.
		/// </summary>
		TTCoords = EVT_2TCOORDS,

		/// <summary>
		/// Vertex with a tangent and binormal vector (<c>Vertex3DTangents</c>).
		/// Usually used for tangent space normal mapping.
		/// Usually tangent and binormal get send to shaders as texture coordinate sets 1 and 2.
		/// </summary>
		Tangents = EVT_TANGENTS
	};

} // end namespace Video
} // end namespace IrrlichtLime
