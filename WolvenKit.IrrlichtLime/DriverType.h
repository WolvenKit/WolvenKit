#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// An enumeration for all types of drivers the Irrlicht Engine supports.
	/// </summary>
	public enum class DriverType
	{
		/// <summary>
		/// Null driver, useful for applications to run the engine without visualization.
		/// The null device is able to load textures, but does not render and display any graphics.
		/// </summary>
		Null = EDT_NULL,

		/// <summary>
		/// The Irrlicht Engine Software renderer.
		/// Runs on all platforms, with every hardware. It should only be used for 2D graphics, but it can also perform some primitive 3D functions.
		/// These 3D drawing functions are quite fast, but very inaccurate, and don't even support clipping in 3D mode.
		/// </summary>
		Software = EDT_SOFTWARE,

		/// <summary>
		/// The Burning's Software Renderer, an alternative software renderer.
		/// Basically it can be described as the Irrlicht Software renderer on steroids.
		/// It rasterizes 3D geometry perfectly: it is able to perform correct 3D clipping, perspective correct texture mapping,
		/// perspective correct color mapping, and renders sub pixel correct, sub texel correct primitives.
		/// In addition, it does bilinear texel filtering and supports more materials than the <see cref="Software"/>.
		/// This renderer has been written entirely by Thomas Alten, thanks a lot for this huge contribution.
		/// </summary>
		BurningsVideo = EDT_BURNINGSVIDEO,

		/// <summary>
		/// Direct3D 9 device, only available on Win32 platforms.
		/// Performs hardware accelerated rendering of 3D and 2D primitives.
		/// </summary>
		Direct3D9 = EDT_DIRECT3D9,

		/// <summary>
		/// OpenGL device, available on most platforms.
		/// Performs hardware accelerated rendering of 3D and 2D primitives.
		/// </summary>
		OpenGL = EDT_OPENGL
	};

} // end namespace Video
} // end namespace IrrlichtLime
