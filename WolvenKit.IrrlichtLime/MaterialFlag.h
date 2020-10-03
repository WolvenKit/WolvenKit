#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Material flags.
	/// </summary>
	public enum class MaterialFlag
	{
		/// <summary>
		/// Draw as wireframe or filled triangles? Default: false.
		/// </summary>
		Wireframe = EMF_WIREFRAME,

		/// <summary>
		/// Draw as point cloud or filled triangles? Default: false.
		/// </summary>
		PointCloud = EMF_POINTCLOUD,

		/// <summary>
		/// Flat or Gouraud shading? Default: true.
		/// </summary>
		GouraudShading = EMF_GOURAUD_SHADING,

		/// <summary>
		/// Will this material be lighted? Default: true.
		/// </summary>
		Lighting = EMF_LIGHTING,

		/// <summary>
		/// Is the ZBuffer enabled? Default: true.
		/// </summary>
		ZBuffer = EMF_ZBUFFER,

		/// <summary>
		/// May be written to the ZBuffer or is it read-only. Default: true.
		/// This flag is ignored, if the material type is a transparent type.
		/// </summary>
		ZWrite = EMF_ZWRITE_ENABLE,

		/// <summary>
		/// Is backface culling enabled? Default: true.
		/// </summary>
		BackFaceCulling = EMF_BACK_FACE_CULLING,

		/// <summary>
		/// Is frontface culling enabled? Default: false.
		/// Overrides <see cref="BackFaceCulling"/> if both are enabled.
		/// </summary>
		FrontFaceCulling = EMF_FRONT_FACE_CULLING,

		/// <summary>
		/// Is bilinear filtering enabled? Default: true.
		/// </summary>
		BilinearFilter = EMF_BILINEAR_FILTER,

		/// <summary>
		/// Is trilinear filtering enabled? Default: false.
		/// If the trilinear filter flag is enabled, the bilinear filtering flag is ignored.
		/// </summary>
		TrilinearFilter = EMF_TRILINEAR_FILTER,

		/// <summary>
		/// Is anisotropic filtering? Default: false.
		/// In Irrlicht you can use anisotropic texture filtering in conjunction with bilinear or trilinear texture filtering to improve rendering results.
		/// Primitives will look less blurry with this flag switched on.
		/// </summary>
		AnisotropicFilter = EMF_ANISOTROPIC_FILTER,

		/// <summary>
		/// Is fog enabled? Default: false.
		/// </summary>
		Fog = EMF_FOG_ENABLE,

		/// <summary>
		/// Normalizes normals. Default: false.
		/// You can enable this if you need to scale a dynamic lighted model.
		/// <para>Usually, its normals will get scaled too then and it will get darker.
		/// If you enable this flag, the normals will be normalized again, and the model will look as bright as it should.</para>
		/// </summary>
		NormalizeNormals = EMF_NORMALIZE_NORMALS,

		/// <summary>
		/// Access to all layers texture wrap settings. Overwrites separate layer settings.
		/// </summary>
		TextureWrap = EMF_TEXTURE_WRAP,

		/// <summary>
		/// Anti-aliasing mode.
		/// </summary>
		AntiAliasing = EMF_ANTI_ALIASING,

		/// <summary>
		/// <c>ColorPlane</c> bits, for enabling the color planes.
		/// </summary>
		ColorMask = EMF_COLOR_MASK,

		/// <summary>
		/// <c>ColorMaterial</c> enumeration for vertex color interpretation.
		/// </summary>
		ColorMaterial = EMF_COLOR_MATERIAL,

		/// <summary>
		/// Flag for enabling/disabling mipmap usage.
		/// </summary>
		Mipmaps = EMF_USE_MIP_MAPS,

		/// <summary>
		/// Flag for blend operation.
		/// </summary>
		BlendOperation = EMF_BLEND_OPERATION,

		/// <summary>
		/// Flag for polygon offset.
		/// </summary>
		PolygonOffset = EMF_POLYGON_OFFSET,

		/// <summary>
		/// Flag for blend factor.
		/// </summary>
		BlendFactor = EMF_BLEND_FACTOR
	};

} // end namespace Video
} // end namespace IrrlichtLime
