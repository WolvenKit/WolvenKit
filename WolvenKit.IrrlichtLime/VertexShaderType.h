#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Compile target enumeration for the <c>GPUProgrammingServices.AddHighLevelShaderMaterial()</c> method.
	/// </summary>
	public enum class VertexShaderType
	{
		/// <summary>
		/// Vertex shader 1.1.
		/// </summary>
		VS_1_1 = EVST_VS_1_1,

		/// <summary>
		/// Vertex shader 2.0.
		/// </summary>
		VS_2_0 = EVST_VS_2_0,

		/// <summary>
		/// Vertex shader 2.0a.
		/// </summary>
		VS_2_a = EVST_VS_2_a,

		/// <summary>
		/// Vertex shader 3.0.
		/// </summary>
		VS_3_0 = EVST_VS_3_0,

		/// <summary>
		/// Vertex shader 4.0.
		/// </summary>
		VS_4_0 = EVST_VS_4_0,

		/// <summary>
		/// Vertex shader 4.1.
		/// </summary>
		VS_4_1 = EVST_VS_4_1,

		/// <summary>
		/// Vertex shader 5.0.
		/// </summary>
		VS_5_0 = EVST_VS_5_0
	};

} // end namespace Video
} // end namespace IrrlichtLime
