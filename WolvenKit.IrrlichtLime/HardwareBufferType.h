#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Hardware buffer types.
	/// </summary>
	public enum class HardwareBufferType
	{
		/// <summary>
		/// Does not change anything.
		/// </summary>
		None = EBT_NONE,

		/// <summary>
		/// Change the vertex mapping.
		/// </summary>
		Vertex = EBT_VERTEX,

		/// <summary>
		/// Change the index mapping.
		/// </summary>
		Index = EBT_INDEX,

		/// <summary>
		/// Change both vertex and index mapping to the same value.
		/// </summary>
		VertexAndIndex = EBT_VERTEX_AND_INDEX
	};

} // end namespace Scene
} // end namespace IrrlichtLime
