#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Enumeration for geometry transformation states.
	/// </summary>
	public enum class TransformationState
	{
		/// <summary>
		/// View transformation.
		/// </summary>
		View = ETS_VIEW,

		/// <summary>
		/// World transformation.
		/// </summary>
		World = ETS_WORLD,

		/// <summary>
		/// Projection transformation.
		/// </summary>
		Projection = ETS_PROJECTION,

		/// <summary>
		/// Texture transformation.
		/// </summary>
		Texture0 = ETS_TEXTURE_0,

		/// <summary>
		/// Texture transformation.
		/// </summary>
		Texture1 = ETS_TEXTURE_1,

		/// <summary>
		/// Texture transformation.
		/// </summary>
		Texture2 = ETS_TEXTURE_2,

		/// <summary>
		/// Texture transformation.
		/// </summary>
		Texture3 = ETS_TEXTURE_3,

#if _IRR_MATERIAL_MAX_TEXTURES_>4

		/// <summary>
		/// Texture transformation.
		/// </summary>
		Texture4 = ETS_TEXTURE_4,

#if _IRR_MATERIAL_MAX_TEXTURES_>5

		/// <summary>
		/// Texture transformation.
		/// </summary>
		Texture5 = ETS_TEXTURE_5,

#if _IRR_MATERIAL_MAX_TEXTURES_>6

		/// <summary>
		/// Texture transformation.
		/// </summary>
		Texture6 = ETS_TEXTURE_6,

#if _IRR_MATERIAL_MAX_TEXTURES_>7

		/// <summary>
		/// Texture transformation.
		/// </summary>
		Texture7 = ETS_TEXTURE_7,

#endif
#endif
#endif
#endif
	};

} // end namespace Video
} // end namespace IrrlichtLime
