#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Abstracted and easy to use fixed function/programmable pipeline material modes.
	/// </summary>
	public enum class MaterialType
	{
		/// <summary>
		/// Standard solid material.
		/// <para>Only first texture is used, which is supposed to be the diffuse material.</para>
		/// </summary>
		Solid = EMT_SOLID,

		/// <summary>
		/// Solid material with 2 texture layers.
		/// <para>The second is blended onto the first using the alpha value of the vertex colors.</para>
		/// <para>This material is currently not implemented in OpenGL.</para>
		/// </summary>
		Solid2Layer = EMT_SOLID_2_LAYER,

		/// <summary>
		/// Material type with standard lightmap technique.
		/// <para>There should be 2 textures: The first texture layer is a diffuse map, the second is a light map. Dynamic light is ignored.</para>
		/// </summary>
		LightMap = EMT_LIGHTMAP,

		/// <summary>
		/// Material type with lightmap technique like <see cref="LightMap"/>. But lightmap and diffuse texture are added instead of modulated.
		/// </summary>
		LightMapAdd = EMT_LIGHTMAP_ADD,

		/// <summary>
		/// Material type with standard lightmap technique.
		/// <para>There should be 2 textures: the first texture layer is a diffuse map, the second is a light map. Dynamic light is ignored.
		/// The texture colors are effectively multiplied by 2 for brightening. Like known in DirectX as D3DTOP_MODULATE2X.</para>
		/// </summary>
		LightMapM2 = EMT_LIGHTMAP_M2,

		/// <summary>
		/// Material type with standard lightmap technique.
		/// <para>There should be 2 textures: the first texture layer is a diffuse map, the second is a light map. Dynamic light is ignored.
		/// The texture colors are effectively multiplied by 4 for brightening. Like known in DirectX as D3DTOP_MODULATE4X.</para>
		/// </summary>
		LightMapM4 = EMT_LIGHTMAP_M4,

		/// <summary>
		/// Like <see cref="LightMap"/>, but also supports dynamic lighting.
		/// </summary>
		LightMapLighting = EMT_LIGHTMAP_LIGHTING,

		/// <summary>
		/// Like <see cref="LightMapM2"/>, but also supports dynamic lighting.
		/// </summary>
		LightMapLightingM2 = EMT_LIGHTMAP_LIGHTING_M2,

		/// <summary>
		/// Like <see cref="LightMapM4"/>, but also supports dynamic lighting.
		/// </summary>
		LightMapLightingM4 = EMT_LIGHTMAP_LIGHTING_M4,

		/// <summary>
		/// Detail mapped material.
		/// <para>The first texture is diffuse color map, the second is added to this and usually displayed with a bigger scale value so that it adds more detail.
		/// The detail map is added to the diffuse map using ADD_SIGNED, so that it is possible to add and subtract color from the diffuse map.
		/// For example a value of (127, 127, 127) will not change the appearance of the diffuse map at all. Often used for terrain rendering.</para>
		/// </summary>
		DetailMap = EMT_DETAIL_MAP,

		/// <summary>
		/// Look like a reflection of the environment around it.
		/// <para>To make this possible, a texture called 'sphere map' is used, which must be set as the first texture.</para>
		/// </summary>
		SphereMap = EMT_SPHERE_MAP,

		/// <summary>
		/// A reflecting material with an optional non reflecting texture layer.
		/// <para>The reflection map should be set as first texture.</para>
		/// </summary>
		Reflection2Layer = EMT_REFLECTION_2_LAYER,

		/// <summary>
		/// A transparent material.
		/// <para>Only the first texture is used. The new color is calculated by simply adding the source color and the dest color.
		/// This means if for example a billboard using a texture with black background and a red circle on it is drawn with this material,
		/// the result is that only the red circle will be drawn a little bit transparent, and everything which was black is 100% transparent and not visible.
		/// This material type is useful for particle effects.</para>
		/// </summary>
		TransparentAddColor = EMT_TRANSPARENT_ADD_COLOR,

		/// <summary>
		/// Makes the material transparent based on the texture alpha channel.
		/// <para>The final color is blended together from the destination color and the texture color, using the alpha channel value as blend factor.
		/// Only first texture is used. If you are using this material with small textures, it is a good idea to load the texture in 32-bit mode
		/// using <c>VideoDriver.SetTextureCreationFlag()</c>.
		/// Also, an alpha ref is used, which can be manipulated using <c>Material.MaterialTypeParam</c>.
		/// This value controls how sharp the edges become when going from a transparent to a solid spot on the texture.</para>
		/// </summary>
		TransparentAlphaChannel = EMT_TRANSPARENT_ALPHA_CHANNEL,

		/// <summary>
		/// Makes the material transparent based on the texture alpha channel.
		/// <para>If the alpha channel value is greater than 127, a pixel is written to the target, otherwise not.
		/// This material does not use alpha blending and is a lot faster than <see cref="TransparentAlphaChannel"/>.
		/// It is ideal for drawing stuff like leaves of plants, because the borders are not blurry but sharp.
		/// Only first texture is used. If you are using this material with small textures and 3d object,
		/// it is a good idea to load the texture in 32 bit mode using <c>VideoDriver.SetTextureCreationFlag()</c>.</para>
		/// </summary>
		TransparentAlphaChannelRef = EMT_TRANSPARENT_ALPHA_CHANNEL_REF,

		/// <summary>
		/// Makes the material transparent based on the vertex alpha value.
		/// </summary>
		TransparentVertexAlpha = EMT_TRANSPARENT_VERTEX_ALPHA,

		/// <summary>
		/// A transparent reflecting material with an optional additional non reflecting texture layer.
		/// <para>The reflection map should be set as first texture. The transparency depends on the alpha value in the vertex colors.
		/// A texture which will not reflect can be set as second texture.
		/// Please note that this material type is currently not 100% implemented in OpenGL.</para>
		/// </summary>
		TransparentReflection2Layer = EMT_TRANSPARENT_REFLECTION_2_LAYER,

		/// <summary>
		/// A solid normal map renderer.
		/// <para>First texture is the color map, the second should be the normal map.
		/// Note that you should use this material only when drawing geometry consisting of vertices of type <c>VertexType.Tangents</c>.
		/// You can convert any mesh into this format using <c>MeshManipulator.CreateMeshWithTangents()</c>.
		/// This shader runs on vertex shader 1.1 and pixel shader 1.1 capable hardware and falls back to a fixed function lighted material if this hardware is not available.
		/// Only two lights are supported by this shader, if there are more, the nearest two are chosen.</para>
		/// </summary>
		NormalMapSolid = EMT_NORMAL_MAP_SOLID,

		/// <summary>
		/// A transparent normal map renderer.
		/// <para>First texture is the color map, the second should be the normal map.
		/// Note that you should use this material only when drawing geometry consisting of vertices of type <c>VertexType.Tangents</c>.
		/// You can convert any mesh into this format using <c>MeshManipulator.CreateMeshWithTangents()</c>.
		/// This shader runs on vertex shader 1.1 and pixel shader 1.1 capable hardware and falls back to a fixed function lighted material if this hardware is not available.
		/// Only two lights are supported by this shader, if there are more, the nearest two are chosen.</para>
		/// </summary>
		NormalMapTransparentAddColor = EMT_NORMAL_MAP_TRANSPARENT_ADD_COLOR,

		/// <summary>
		/// A transparent (based on the vertex alpha value) normal map renderer.
		/// <para>First texture is the color map, the second should be the normal map.
		/// Note that you should use this material only when drawing geometry consisting of vertices of type <c>VertexType.Tangents</c>.
		/// You can convert any mesh into this format using <c>MeshManipulator.CreateMeshWithTangents()</c>.
		/// This shader runs on vertex shader 1.1 and pixel shader 1.1 capable hardware and falls back to a fixed function lighted material if this hardware is not available.
		/// Only two lights are supported by this shader, if there are more, the nearest two are chosen.</para>
		/// </summary>
		NormalMapTransparentVertexAlpha = EMT_NORMAL_MAP_TRANSPARENT_VERTEX_ALPHA,

		/// <summary>
		/// Just like <see cref="NormalMapSolid"/>, but uses parallax mapping.
		/// <para>Looks a lot more realistic. This only works when the hardware supports at least vertex shader 1.1 and pixel shader 1.4.
		/// First texture is the color map, the second should be the normal map. The normal map texture should contain the height value in the alpha component.
		/// The <c>VideoDriver.MakeNormalMapTexture()</c> writes this value automatically when creating normal maps from a heightmap when using a 32-bit texture.
		/// The height scale of the material (affecting the bumpiness) is being controlled by the <c>Material.MaterialTypeParam</c>.
		/// If set to zero, the default value (0.02f) will be applied. Otherwise the value set in <c>Material.MaterialTypeParam</c> is taken.
		/// This value depends on with which scale the texture is mapped on the material.
		/// Too high or low values of <c>Material.MaterialTypeParam</c> can result in strange artifacts.</para>
		/// </summary>
		ParallaxMapSolid = EMT_PARALLAX_MAP_SOLID,

		/// <summary>
		/// A material like <see cref="ParallaxMapSolid"/>, but transparent. Using <see cref="TransparentAddColor"/> as base material.
		/// </summary>
		ParallaxMapTransparentAddColor = EMT_PARALLAX_MAP_TRANSPARENT_ADD_COLOR,

		/// <summary>
		/// A material like <see cref="ParallaxMapSolid"/>, but transparent. Using <see cref="TransparentVertexAlpha"/> as base material.
		/// </summary>
		ParallaxMapTransparentVertexAlpha = EMT_PARALLAX_MAP_TRANSPARENT_VERTEX_ALPHA,

		/// <summary>
		/// BlendFunc = source * sourceFactor + dest * destFactor ( E_BLEND_FUNC ). Using only first texture. Generic blending method.
		/// </summary>
		OneTextureBlend = EMT_ONETEXTURE_BLEND
	};

} // end namespace Video
} // end namespace IrrlichtLime
