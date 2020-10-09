#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	[Flags]
	/// <summary>
	/// Enumeration flags telling the video driver in which format textures should be created.
	/// </summary>
	public enum class TextureCreationFlag
	{
		/// <summary>
		/// Forces the driver to create 16 bit textures always, independent of which format the file on disk has.
		/// When choosing this you may lose some color detail, but gain much speed and memory.
		/// 16 bit textures can be transferred twice as fast as 32 bit textures and only use half of the space in memory.
		/// When using this flag, it does not make sense to use the flags <c>Always32Bit</c>, <c>OptimizedForQuality</c>, or <c>OptimizedForSpeed</c> at the same time.
		/// </summary>
		Always16Bit = ETCF_ALWAYS_16_BIT,

		/// <summary>
		/// Forces the driver to create 32 bit textures always, independent of which format the file on disk has.
		/// Please note that some drivers (like the software device) will ignore this, because they are only able to create and use 16 bit textures.
		/// When using this flag, it does not make sense to use the flags <c>Always16Bit</c>, <c>OptimizedForQuality</c>, or <c>OptimizedForSpeed</c> at the same time.
		/// </summary>
		Always32Bit = ETCF_ALWAYS_32_BIT,

		/// <summary>
		/// Lets the driver decide in which format the textures are created and tries to make the textures look as good as possible.
		/// Usually it simply chooses the format in which the texture was stored on disk.
		/// When using this flag, it does not make sense to use the flags <c>Always16Bit</c>, <c>Always32Bit</c>, or <c>OptimizedForSpeed</c> at the same time.
		/// </summary>
		OptimizedForQuality = ETCF_OPTIMIZED_FOR_QUALITY,

		/// <summary>
		/// Lets the driver decide in which format the textures are created and tries to create them maximizing render speed.
		/// When using this flag, it does not make sense to use the flags <c>Always16Bit</c>, <c>Always32Bit</c>, or <c>OptimizedForQuality</c> at the same time.
		/// </summary>
		OptimizedForSpeed = ETCF_OPTIMIZED_FOR_SPEED,

		/// <summary>
		/// Automatically creates mip map levels for the textures.
		/// </summary>
		CreateMipMaps = ETCF_CREATE_MIP_MAPS,

		/// <summary>
		/// Discard any alpha layer and use non-alpha color format.
		/// </summary>
		NoAlphaChannel = ETCF_NO_ALPHA_CHANNEL,

		/// <summary>
		/// Allow the Driver to use non-power-2 textures.
		/// BurningVideo can handle non-power-2 textures in 2D (GUI), but not in 3D.
		/// </summary>
		AllowNonPower2 = ETCF_ALLOW_NON_POWER_2,

		/// <summary>
		/// Allow the driver to keep a copy of the texture in memory.
		/// Enabling this makes calls to <c>TexturePainter.Lock()</c> a lot faster, but costs main memory.
		/// Currently only used in combination with OpenGL drivers.
		/// NOTE: Disabling this does not yet work correctly with alpha-textures. So the default is off for now
		/// (but might change with Irrlicht 1.9 if we get the alpha-troubles fixed).
		/// </summary>
		AllowMemoryCopy = ETCF_ALLOW_MEMORY_COPY
	};

} // end namespace Video
} // end namespace IrrlichtLime
