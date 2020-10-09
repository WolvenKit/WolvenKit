#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Enumeration for querying features of the video driver.
	/// </summary>
	public enum class VideoDriverFeature
	{
		/// <summary>
		/// Is driver able to render to a surface?
		/// </summary>
		RenderToTarget = EVDF_RENDER_TO_TARGET,

		/// <summary>
		/// Is hardware transform and lighting supported?
		/// </summary>
		HardwareTL = EVDF_HARDWARE_TL,

		/// <summary>
		/// Are multiple textures per material possible?
		/// </summary>
		Multitexture = EVDF_MULTITEXTURE,

		/// <summary>
		/// Is driver able to render with a bilinear filter applied?
		/// </summary>
		BilinearFilter = EVDF_BILINEAR_FILTER,

		/// <summary>
		/// Can the driver handle mip maps?
		/// </summary>
		Mipmap = EVDF_MIP_MAP,

		/// <summary>
		/// Can the driver update mip maps automatically?
		/// </summary>
		MipmapAutoUpdate = EVDF_MIP_MAP_AUTO_UPDATE,

		/// <summary>
		/// Are stencil buffers switched on and does the device support stencil buffers?
		/// </summary>
		StencilBuffer = EVDF_STENCIL_BUFFER,

		/// <summary>
		/// Is Vertex Shader 1.1 supported?
		/// </summary>
		VertexShader_1_1 = EVDF_VERTEX_SHADER_1_1,

		/// <summary>
		/// Is Vertex Shader 2.0 supported?
		/// </summary>
		VertexShader_2_0 = EVDF_VERTEX_SHADER_2_0,

		/// <summary>
		/// Is Vertex Shader 3.0 supported?
		/// </summary>
		VertexShader_3_0 = EVDF_VERTEX_SHADER_3_0,

		/// <summary>
		/// Is Pixel Shader 1.1 supported?
		/// </summary>
		PixelShader_1_1 = EVDF_PIXEL_SHADER_1_1,

		/// <summary>
		/// Is Pixel Shader 1.2 supported?
		/// </summary>
		PixelShader_1_2 = EVDF_PIXEL_SHADER_1_2,

		/// <summary>
		/// Is Pixel Shader 1.3 supported?
		/// </summary>
		PixelShader_1_3 = EVDF_PIXEL_SHADER_1_3,

		/// <summary>
		/// Is Pixel Shader 1.4 supported?
		/// </summary>
		PixelShader_1_4 = EVDF_PIXEL_SHADER_1_4,

		/// <summary>
		/// Is Pixel Shader 2.0 supported?
		/// </summary>
		PixelShader_2_0 = EVDF_PIXEL_SHADER_2_0,

		/// <summary>
		/// Is Pixel Shader 3.0 supported?
		/// </summary>
		PixelShader_3_0 = EVDF_PIXEL_SHADER_3_0,

		/// <summary>
		/// Are ARB vertex programs 1.0 supported?
		/// </summary>
		ARB_VertexProgram_1 = EVDF_ARB_VERTEX_PROGRAM_1,

		/// <summary>
		/// Are ARB fragment programs 1.0 supported?
		/// </summary>
		ARB_FragmentProgram_1 = EVDF_ARB_FRAGMENT_PROGRAM_1,

		/// <summary>
		/// Is GLSL supported?
		/// </summary>
		ARB_GLSL = EVDF_ARB_GLSL,

		/// <summary>
		/// Is HLSL supported?
		/// </summary>
		HLSL = EVDF_HLSL,

		/// <summary>
		/// Are non-square textures supported?
		/// </summary>
		TextureNonSquare = EVDF_TEXTURE_NSQUARE,

		/// <summary>
		/// Are non-power-of-two textures supported?
		/// </summary>
		TextureNonPOT = EVDF_TEXTURE_NPOT,

		/// <summary>
		/// Are frame buffer objects supported?
		/// </summary>
		FrameBufferObject = EVDF_FRAMEBUFFER_OBJECT,

		/// <summary>
		/// Are vertex buffer objects supported?
		/// </summary>
		VertexBufferObject = EVDF_VERTEX_BUFFER_OBJECT,

		/// <summary>
		/// Supports Alpha To Coverage.
		/// </summary>
		AlphaToCoverage = EVDF_ALPHA_TO_COVERAGE,

		/// <summary>
		/// Supports Color masks (disabling color planes in output).
		/// </summary>
		ColorMask = EVDF_COLOR_MASK,

		/// <summary>
		/// Supports multiple render targets at once.
		/// </summary>
		MultipleRenderTargets = EVDF_MULTIPLE_RENDER_TARGETS,

		/// <summary>
		/// Supports separate blend settings for multiple render targets.
		/// </summary>
		MRT_Blend = EVDF_MRT_BLEND,

		/// <summary>
		/// Supports separate color masks for multiple render targets.
		/// </summary>
		MRT_ColorMask = EVDF_MRT_COLOR_MASK,

		/// <summary>
		/// Supports separate blend functions for multiple render targets.
		/// </summary>
		MRT_BlendFunc = EVDF_MRT_BLEND_FUNC,

		/// <summary>
		/// Supports geometry shaders.
		/// </summary>
		GeomertyShader = EVDF_GEOMETRY_SHADER,

		/// <summary>
		/// Supports occlusion queries.
		/// </summary>
		OcclusionQuery = EVDF_OCCLUSION_QUERY,

		/// <summary>
		/// Supports polygon offset/depth bias for avoiding z-fighting.
		/// </summary>
		PolygonOffset = EVDF_POLYGON_OFFSET,

		/// <summary>
		/// Support for different blend functions. Without, only ADD is available.
		/// </summary>
		BlendOperations = EVDF_BLEND_OPERATIONS,

		/// <summary>
		/// Support for separate blending for RGB and Alpha.
		/// </summary>
		BlendSeparate = EVDF_BLEND_SEPARATE,

		/// <summary>
		/// Support for texture coord transformation via texture matrix.
		/// </summary>
		TextureMatrix = EVDF_TEXTURE_MATRIX,

		/// <summary>
		/// Support for DXTn compressed textures.
		/// </summary>
		TextureCompressedDXT = EVDF_TEXTURE_COMPRESSED_DXT,

		/// <summary>
		/// Support for PVRTC compressed textures.
		/// </summary>
		TextureCompressedPVRTC = EVDF_TEXTURE_COMPRESSED_PVRTC,

		/// <summary>
		/// Support for PVRTC2 compressed textures.
		/// </summary>
		TextureCompressedPVRTC2 = EVDF_TEXTURE_COMPRESSED_PVRTC2,

		/// <summary>
		/// Support for ETC1 compressed textures.
		/// </summary>
		TextureCompressedETC1 = EVDF_TEXTURE_COMPRESSED_ETC1,

		/// <summary>
		/// Support for ETC2 compressed textures.
		/// </summary>
		TextureCompressedETC2 = EVDF_TEXTURE_COMPRESSED_ETC2,

		/// <summary>
		/// Support for cube map textures.
		/// </summary>
		TextureCubemap = EVDF_TEXTURE_CUBEMAP,

		/// <summary>
		/// Support for filtering across different faces of the cubemap.
		/// </summary>
		TextureCubemapSeamless = EVDF_TEXTURE_CUBEMAP_SEAMLESS
	};

} // end namespace Video
} // end namespace IrrlichtLime
