#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Special render targets, which usually map to dedicated hardware.
	/// These render targets (besides <see cref="FrameBuffer"/> and <see cref="RenderTexture"/>) need not be supported by gfx cards.
	/// </summary>
	public enum class RenderTarget
	{
		/// <summary>
		/// Render target is the main color frame buffer.
		/// </summary>
		FrameBuffer = ERT_FRAME_BUFFER,

		/// <summary>
		/// Render target is a render texture.
		/// </summary>
		RenderTexture = ERT_RENDER_TEXTURE,

		/// <summary>
		/// Multi-Render target textures.
		/// </summary>
		MultiRenderTextures = ERT_MULTI_RENDER_TEXTURES,

		/// <summary>
		/// Render target is the main color frame buffer.
		/// </summary>
		StereoLeftBuffer = ERT_STEREO_LEFT_BUFFER,

		/// <summary>
		/// Render target is the right color buffer (left is the main buffer).
		/// </summary>
		StereoRightBuffer = ERT_STEREO_RIGHT_BUFFER,

		/// <summary>
		/// Render to both stereo buffers at once.
		/// </summary>
		StereoBothBuffers = ERT_STEREO_BOTH_BUFFERS,

		/// <summary>
		/// Auxiliary buffer 0.
		/// </summary>
		AuxBuffer0 = ERT_AUX_BUFFER0,

		/// <summary>
		/// Auxiliary buffer 1.
		/// </summary>
		AuxBuffer1 = ERT_AUX_BUFFER1,

		/// <summary>
		/// Auxiliary buffer 2.
		/// </summary>
		AuxBuffer2 = ERT_AUX_BUFFER2,

		/// <summary>
		/// Auxiliary buffer 3.
		/// </summary>
		AuxBuffer3 = ERT_AUX_BUFFER3,

		/// <summary>
		/// Auxiliary buffer 4.
		/// </summary>
		AuxBuffer4 = ERT_AUX_BUFFER4
	};

} // end namespace Video
} // end namespace IrrlichtLime
