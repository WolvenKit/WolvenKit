#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Enumeration for different types of shading languages.
	/// </summary>
	public enum class GPUShadingLanguage
	{
		/// <summary>
		/// The default language, so HLSL for Direct3D and GLSL for OpenGL.
		/// </summary>
		Default = EGSL_DEFAULT,

		/// <summary>
		/// Cg shading language.
		/// </summary>
		Cg = EGSL_CG
	};

} // end namespace Video
} // end namespace IrrlichtLime
