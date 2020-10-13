#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// These flags allow to define the interpretation of vertex color when lighting is enabled.
	/// <para>Without lighting being enabled the vertex color is the only value defining the fragment color.
	/// Once lighting is enabled, the four values for diffuse, ambient, emissive, and specular take over.
	/// With these flags it is possible to define which lighting factor shall be defined by the vertex color
	/// instead of the lighting factor which is the same for all faces of that material.</para>
	/// <para>The default is to use vertex color for the diffuse value, another pretty common value is to use
	/// vertex color for both diffuse and ambient factor.</para>
	/// </summary>
	public enum class ColorMaterial
	{
		/// <summary>
		/// Don't use vertex color for lighting.
		/// </summary>
		None = ECM_NONE,

		/// <summary>
		/// Use vertex color for diffuse light, this is default.
		/// </summary>
		Diffuse = ECM_DIFFUSE,

		/// <summary>
		/// Use vertex color for ambient light.
		/// </summary>
		Ambient = ECM_AMBIENT,

		/// <summary>
		/// Use vertex color for emissive light.
		/// </summary>
		Emissive = ECM_EMISSIVE,

		/// <summary>
		/// Use vertex color for specular light.
		/// </summary>
		Specular = ECM_SPECULAR,

		/// <summary>
		/// Use vertex color for both diffuse and ambient light.
		/// </summary>
		DiffuseAndAmbient = ECM_DIFFUSE_AND_AMBIENT
	};

} // end namespace Video
} // end namespace IrrlichtLime
