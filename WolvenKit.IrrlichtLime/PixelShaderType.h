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
	public enum class PixelShaderType
	{
		/// <summary>
		/// Pixel shader 1.1.
		/// </summary>
		PS_1_1 = EPST_PS_1_1,

		/// <summary>
		/// Pixel shader 1.2.
		/// </summary>
		PS_1_2 = EPST_PS_1_2,

		/// <summary>
		/// Pixel shader 1.3.
		/// </summary>
		PS_1_3 = EPST_PS_1_3,

		/// <summary>
		/// Pixel shader 1.4.
		/// </summary>
		PS_1_4 = EPST_PS_1_4,

		/// <summary>
		/// Pixel shader 2.0.
		/// </summary>
		PS_2_0 = EPST_PS_2_0,

		/// <summary>
		/// Pixel shader 2.0a.
		/// </summary>
		PS_2_a = EPST_PS_2_a,

		/// <summary>
		/// Pixel shader 2.0b.
		/// </summary>
		PS_2_b = EPST_PS_2_b,

		/// <summary>
		/// Pixel shader 3.0.
		/// </summary>
		PS_3_0 = EPST_PS_3_0,

		/// <summary>
		/// Pixel shader 4.0.
		/// </summary>
		PS_4_0 = EPST_PS_4_0,

		/// <summary>
		/// Pixel shader 4.1.
		/// </summary>
		PS_4_1 = EPST_PS_4_1,

		/// <summary>
		/// Pixel shader 5.0.
		/// </summary>
		PS_5_0 = EPST_PS_5_0
	};

} // end namespace Video
} // end namespace IrrlichtLime
