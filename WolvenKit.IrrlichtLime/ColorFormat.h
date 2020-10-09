#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Enumeration for the color format of textures used by the Irrlicht Engine. A color format specifies how color information is stored.
	/// <para>NOTE: Byte order in memory is usually flipped (it's probably correct in bitmap files, but flipped on reading).
	/// So for example <see cref="A8R8G8B8"/> is BGRA in memory same as in DX9's <c>D3DFMT_A8R8G8B8</c> format.</para>
	/// </summary>
	public enum class ColorFormat
	{
		/// <summary>
		/// 16 bit color format used by the software driver.
		/// It is thus preferred by all other irrlicht engine video drivers.
		/// There are 5 bits for every color component, and a single bit is left for alpha information.
		/// </summary>
		A1R5G5B5 = ECF_A1R5G5B5,

		/// <summary>
		/// Standard 16 bit color format.
		/// </summary>
		R5G6B5 = ECF_R5G6B5,

		/// <summary>
		/// 24 bit color, no alpha channel, but 8 bit for red, green and blue.
		/// </summary>
		R8G8B8 = ECF_R8G8B8,

		/// <summary>
		/// Default 32 bit color format. 8 bits are used for every component: red, green, blue and alpha.
		/// <para>Warning: this tends to be BGRA in memory (it's ARGB on file, but with usual big-endian memory it's flipped).</para>
		/// </summary>
		A8R8G8B8 = ECF_A8R8G8B8,

		/// <summary>
		/// DXT1 color format.
		/// Compressed format.
		/// </summary>
		DXT1 = ECF_DXT1,

		/// <summary>
		/// DXT2 color format.
		/// Compressed format.
		/// </summary>
		DXT2 = ECF_DXT2,

		/// <summary>
		/// DXT3 color format.
		/// Compressed format.
		/// </summary>
		DXT3 = ECF_DXT3,

		/// <summary>
		/// DXT4 color format.
		/// Compressed format.
		/// </summary>
		DXT4 = ECF_DXT4,

		/// <summary>
		/// DXT5 color format.
		/// Compressed format.
		/// </summary>
		DXT5 = ECF_DXT5,

		/// <summary>
		/// PVRTC RGB 2bpp color format.
		/// Compressed format.
		/// </summary>
		PVRTC_RGB2 = ECF_PVRTC_RGB2,

		/// <summary>
		/// PVRTC ARGB 2bpp color format.
		/// Compressed format.
		/// </summary>
		PVRTC_ARGB2 = ECF_PVRTC_ARGB2,

		/// <summary>
		/// PVRTC RGB 4bpp color format.
		/// Compressed format.
		/// </summary>
		PVRTC_RGB4 = ECF_PVRTC_RGB4,

		/// <summary>
		/// PVRTC ARGB 4bpp color format.
		/// Compressed format.
		/// </summary>
		PVRTC_ARGB4 = ECF_PVRTC_ARGB4,

		/// <summary>
		/// PVRTC2 ARGB 2bpp color format.
		/// Compressed format.
		/// </summary>
		PVRTC2_ARGB2 = ECF_PVRTC2_ARGB2,

		/// <summary>
		/// PVRTC2 ARGB 4bpp color format.
		/// Compressed format.
		/// </summary>
		PVRTC2_ARGB4 = ECF_PVRTC2_ARGB4,

		/// <summary>
		/// ETC1 RGB color format.
		/// Compressed format.
		/// </summary>
		ETC1 = ECF_ETC1,

		/// <summary>
		/// ETC2 RGB color format.
		/// Compressed format.
		/// </summary>
		ETC2_RGB = ECF_ETC2_RGB,

		/// <summary>
		/// ETC2 ARGB color format.
		/// Compressed format.
		/// </summary>
		ETC2_ARGB = ECF_ETC2_ARGB,

		/// <summary>
		/// 16 bit format using 16 bits for the red channel.
		/// May only be used for render target textures. Floating point format.
		/// </summary>
		R16F = ECF_R16F,

		/// <summary>
		/// 32 bit format using 16 bits for the red and green channels.
		/// May only be used for render target textures. Floating point format.
		/// </summary>
		G16R16F = ECF_G16R16F,

		/// <summary>
		/// 64 bit format using 16 bits for the red, green, blue and alpha channels.
		/// May only be used for render target textures. Floating point format.
		/// </summary>
		A16B16G16R16F = ECF_A16B16G16R16F,

		/// <summary>
		/// 32 bit format using 32 bits for the red channel.
		/// May only be used for render target textures. Floating point format.
		/// </summary>
		R32F = ECF_R32F,

		/// <summary>
		/// 64 bit format using 32 bits for the red and green channels.
		/// May only be used for render target textures. Floating point format.
		/// </summary>
		G32R32F = ECF_G32R32F,

		/// <summary>
		/// 128 bit format using 32 bits for the red, green, blue and alpha channels.
		/// May only be used for render target textures. Floating point format.
		/// </summary>
		A32B32G32R32F = ECF_A32B32G32R32F,

		/// <summary>
		/// 8 bit format using 8 bits for the red channel.
		/// Unsigned normalized integer format.
		/// </summary>
		R8 = ECF_R8,

		/// <summary>
		/// 16 bit format using 8 bits for the red and green channels.
		/// Unsigned normalized integer format.
		/// </summary>
		R8G8 = ECF_R8G8,

		/// <summary>
		/// 16 bit format using 16 bits for the red channel.
		/// Unsigned normalized integer format.
		/// </summary>
		R16 = ECF_R16,

		/// <summary>
		/// 32 bit format using 16 bits for the red and green channels.
		/// Unsigned normalized integer format.
		/// </summary>
		R16G16 = ECF_R16G16,

		/// <summary>
		/// 16 bit format using 16 bits for depth.
		/// Depth buffer format.
		/// </summary>
		D16 = ECF_D16,

		/// <summary>
		/// 32 bit format using 32 bits for depth.
		/// Depth buffer format.
		/// </summary>
		D32 = ECF_D32,

		/// <summary>
		/// 32 bit format using 24 bits for depth and 8 bits for stencil.
		/// Depth and stencil format.
		/// </summary>
		D24S8 = ECF_D24S8,

		/// <summary>
		/// Unknown color format.
		/// </summary>
		Unknown = ECF_UNKNOWN
	};

} // end namespace Video
} // end namespace IrrlichtLime
