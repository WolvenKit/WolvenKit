#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Enumeration for all primitive types there are.
	/// </summary>
	public enum class PrimitiveType
	{
		/// <summary>
		/// All vertices are non-connected points.
		/// </summary>
		Points = EPT_POINTS,

		/// <summary>
		/// All vertices form a single connected line.
		/// </summary>
		LineStrip = EPT_LINE_STRIP,

		/// <summary>
		/// Just as <see cref="LineStrip"/>, but the last and the first vertex is also connected.
		/// </summary>
		LineLoop = EPT_LINE_LOOP,

		/// <summary>
		/// Every two vertices are connected creating n/2 lines.
		/// </summary>
		Lines = EPT_LINES,

		/// <summary>
		/// After the first two vertices each vertex defines a new triangle.
		/// Always the two last and the new one form a new triangle.
		/// </summary>
		TriangleStrip = EPT_TRIANGLE_STRIP,

		/// <summary>
		/// After the first two vertices each vertex defines a new triangle.
		/// All around the common first vertex.
		/// </summary>
		TriangleFan = EPT_TRIANGLE_FAN,

		/// <summary>
		/// Explicitly set all vertices for each triangle.
		/// </summary>
		Triangles = EPT_TRIANGLES,

		/// <summary>
		/// After the first two vertices each further two vertices create a quad with the preceding two.
		/// Not supported by Direct3D.
		/// </summary>
		QuadStrip = EPT_QUAD_STRIP,

		/// <summary>
		/// Every four vertices create a quad.
		/// Not supported by Direct3D.
		/// Deprecated with newer OpenGL drivers.
		/// </summary>
		Quads = EPT_QUADS,

		/// <summary>
		/// Just as <see cref="LineLoop"/>, but filled.
		/// Not supported by Direct3D.
		/// Deprecated with newer OpenGL drivers.
		/// </summary>
		Polygon = EPT_POLYGON,

		/// <summary>
		/// The single vertices are expanded to quad billboards on the GPU.
		/// </summary>
		PointSprites = EPT_POINT_SPRITES
	};

} // end namespace Scene
} // end namespace IrrlichtLime
