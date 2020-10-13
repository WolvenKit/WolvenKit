#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video {

ref class MaterialLayer;
ref class Texture;

/// <summary>
/// Parameters for a material renderer.
/// </summary>
public ref class Material : Lime::NativeValue<video::SMaterial>
{
public:

	/// <summary>
	/// Identity material.
	/// Solid, lit material with white colors.
	/// </summary>
	static property Material^ Identity { Material^ get() { return gcnew Material(); } }

	/// <summary>
	/// Identity material with no lighting setup.
	/// </summary>
	static property Material^ IdentityNoLighting { Material^ get() { Material^ m = gcnew Material(); m->Lighting = false; return m; } }

	/// <summary>
	/// Identity material with red wireframe setup.
	/// Intended for debugging purposes.
	/// </summary>
	static property Material^ IdentityRedWireframe { Material^ get() { Material^ m = gcnew Material(); m->EmissiveColor = gcnew Color(255, 0, 0); m->ZBuffer = ComparisonFunc::Always; m->Wireframe = true; return m; } }

	/// <summary>
	/// Maximum number of texture a Material can have.
	/// Material might ignore some textures in most function, like assignment and comparison,
	/// when <c>IrrlichtCreationParameters.MaxTextureUnits</c> is set to a lower number.
	/// </summary>
	static property int MaxTextures { int get() { return video::MATERIAL_MAX_TEXTURES; } }

	/// <summary>
	/// Default constructor.
	/// Creates a solid, lit material with white colors.
	/// </summary>
	Material();

	/// <summary>
	/// Copy constructor.
	/// </summary>
	Material(Material^ other);

	/// <summary>
	/// Get the material flag.
	/// </summary>
	bool GetFlag(MaterialFlag flag);

	/// <summary>
	/// Get specific texture.
	/// </summary>
	/// <param name="index">Texture index. Should be in range [0,MaxTextures-1].</param>
	Texture^ GetTexture(int index);

	/// <summary>
	/// Get the texture transformation matrix.
	/// </summary>
	/// <param name="index">Texture index. Should be in range [0,MaxTextures-1].</param>
	Matrix^ GetTextureMatrix(int index);

	/// <summary>
	/// Set the material flag.
	/// </summary>
	void SetFlag(MaterialFlag flag, bool value);

	/// <summary>
	/// Set specific texture.
	/// </summary>
	/// <param name="index">Texture index. Should be in range [0,MaxTextures-1].</param>
	void SetTexture(int index, Texture^ tex);

	/// <summary>
	/// Set the texture transformation matrix.
	/// </summary>
	/// <param name="index">Texture index. Should be in range [0,MaxTextures-1].</param>
	void SetTextureMatrix(int index, Matrix^ mat);

	/// <summary>
	/// Type of the material.
	/// Specifies how everything is blended together.
	/// </summary>
	property Video::MaterialType Type { Video::MaterialType get(); void set(Video::MaterialType value); }

	/// <summary>
	/// How much ambient light (a global light) is reflected by this material.
	/// The default is full white, meaning objects are completely globally illuminated.
	/// Reduce this if you want to see diffuse or specular light effects.
	/// </summary>
	property Color^ AmbientColor { Color^ get(); void set(Color^ value); }

	/// <summary>
	/// The blend operation of choice.
	/// </summary>
	property Video::BlendOperation BlendOperation { Video::BlendOperation get(); void set(Video::BlendOperation value); }

	/// <summary>
	/// How much diffuse light coming from a light source is reflected by this material.
	/// The default is full white.
	/// </summary>
	property Color^ DiffuseColor { Color^ get(); void set(Color^ value); }

	/// <summary>
	/// Light emitted by this material.
	/// Default is to emit no light.
	/// </summary>
	property Color^ EmissiveColor { Color^ get(); void set(Color^ value); }

	/// <summary>
	/// How much specular light (highlights from a light) is reflected.
	/// The default is to reflect white specular light.
	/// See <c>Shininess</c> on how to enable specular lights.
	/// </summary>
	property Color^ SpecularColor { Color^ get(); void set(Color^ value); }

	/// <summary>
	/// Value affecting the size of specular highlights.
	/// <para>A value of 20 is common. If set to 0, no specular highlights are being used.
	/// To activate, simply set the shininess of a material to a value in the range [0.5,128].
	/// You can change the color of the highlights using <c>SpecularColor</c>.</para>
	/// <para>The specular color of the dynamic lights (<c>Light.SpecularColor</c>) will influence the the highlight color too,
	/// but they are set to a useful value by default when creating the light scene node.</para>
	/// </summary>
	property float Shininess { float get(); void set(float value); }

	/// <summary>
	/// Free parameter, dependent on the material type.
	/// Mostly ignored, used for example in <see cref="MaterialType::ParallaxMapSolid"/> and <see cref="MaterialType::TransparentAlphaChannel"/>.
	/// </summary>
	property float MaterialTypeParam { float get(); void set(float value); }

	/// <summary>
	/// Second free parameter, dependent on the material type.
	/// Mostly ignored.
	/// </summary>
	property float MaterialTypeParam2 { float get(); void set(float value); }

	/// <summary>
	/// Thickness of non-3dimensional elements such as lines and points.
	/// </summary>
	property float Thickness { float get(); void set(float value); }

	/// <summary>
	/// Is the ZBuffer enabled?
	/// Default is <see cref="ComparisonFunc::LessEqual"/>.
	/// If you want to disable depth test for this material just set this parameter to <see cref="ComparisonFunc::Disabled"/>.
	/// </summary>
	property ComparisonFunc ZBuffer { ComparisonFunc get(); void set(ComparisonFunc value); }

	/// <summary>
	/// The antialiasing mode.
	/// Default is <see cref="AntiAliasingMode::Simple"/>.
	/// </summary>
	property AntiAliasingMode AntiAliasing { AntiAliasingMode get(); void set(AntiAliasingMode value); }

	/// <summary>
	/// Defines the enabled color planes.
	/// Only enabled color planes will be rendered to the current render target.
	/// Typical use is to disable all colors when rendering only to depth or stencil buffer, or using Red and Green for stereo rendering.
	/// </summary>
	property ColorPlane ColorMask { ColorPlane get(); void set(ColorPlane value); }

	/// <summary>
	/// Defines the interpretation of vertex color in the lighting equation.
	/// When lighting is enabled, vertex color can be used instead of the material values for light modulation.
	/// This allows to easily change e.g. the diffuse light behavior of each face.
	/// The default, <see cref="Video::ColorMaterial::Diffuse"/>, will result in a very similar rendering as with lighting turned off, just with light shading.
	/// </summary>
	property Video::ColorMaterial ColorMaterial { Video::ColorMaterial get(); void set(Video::ColorMaterial value); }

	/// <summary>
	/// A constant z-buffer offset for a polygon/line/point.
	/// The range of the value is driver specific.
	/// On OpenGL you get units which are multiplied by the smallest value that is guaranteed to produce a resolvable offset.
	/// On D3D9 you can pass a range between -1 and 1. But you should likely divide it by the range of the depthbuffer.
	/// Like dividing by 65535.0 for a 16 bit depthbuffer. Thought it still might produce too large of a bias.
	/// Some article (https://aras-p.info/blog/2008/06/12/depth-bias-and-the-power-of-deceiving-yourself/)
	/// recommends multiplying by 2.0*4.8e-7 (and strangely on both 16 bit and 24 bit).
	/// </summary>
	property f32 PolygonOffsetDepthBias { f32 get(); void set(f32 values); }

	/// <summary>
	/// Variable z-buffer offset based on the slope of the polygon.
	/// For polygons looking flat at a camera you could use 0 (for example in a 2D game).
	/// But in most cases you will have polygons rendered at a certain slope.
	/// The driver will calculate the slope for you and this value allows to scale that slope.
	/// The complete polygon offset is: PolygonOffsetSlopeScale * slope + PolygonOffsetDepthBias.
	/// A good default here is to use 1.f if you want to push the polygons away from the camera and -1.f to pull them towards the camera.
	/// </summary>
	property f32 PolygonOffsetSlopeScale { f32 get(); void set(f32 values); }

	/// <summary>
	/// Draw as wireframe or filled triangles?
	/// Default is false.
	/// </summary>
	property bool Wireframe { bool get(); void set(bool value); }

	/// <summary>
	/// Draw as point cloud or filled triangles?
	/// Default is false.
	/// </summary>
	property bool PointCloud { bool get(); void set(bool value); }

	/// <summary>
	/// Flat or Gouraud shading?
	/// Default is true.
	/// </summary>
	property bool GouraudShading { bool get(); void set(bool value); }

	/// <summary>
	/// Will this material be lighted?
	/// Default is true.
	/// </summary>
	property bool Lighting { bool get(); void set(bool value); }

	/// <summary>
	/// Is the zbuffer writable or is it read-only.
	/// Default is true.
	/// This flag is forced to false if the Type is a transparent material type and the <c>SceneParameters.AllowZWriteOnTransparent</c> is not set.
	/// If you set this parameter to true, make sure that <c>ZBuffer</c> value is other than <see cref="ComparisonFunc::Disabled"/>.
	/// </summary>
	property bool ZWrite { bool get(); void set(bool value); }

	/// <summary>
	/// Give more control how the <c>ZWrite</c> is interpreted.
	/// Default is false.
	/// When set to true: writing will just be based on <c>ZBuffer</c>, transparency is ignored.
	/// When set to false: only write zbuffer when When <c>ZBuffer</c> is true and <c>Transparent</c> is false.
	/// <para>Note that there is also the global flag <c>SceneParameters.AllowZWriteOnTransparent</c> which when set
	/// acts like all materials have set this value to <c>true</c>.</para>
	/// </summary>
	property bool ZWriteFineControl { bool get(); void set(bool value); }

	/// <summary>
	/// Is backface culling enabled?
	/// Default is true.
	/// </summary>
	property bool BackfaceCulling { bool get(); void set(bool value); }

	/// <summary>
	/// Is frontface culling enabled?
	/// Default is false.
	/// </summary>
	property bool FrontfaceCulling { bool get(); void set(bool value); }

	/// <summary>
	/// Is fog enabled?
	/// Default is false.
	/// </summary>
	property bool Fog { bool get(); void set(bool value); }

	/// <summary>
	/// Should normals be normalized?
	/// Always use this if the mesh lit and scaled.
	/// Default is false.
	/// </summary>
	property bool NormalizeNormals { bool get(); void set(bool value); }

	/// <summary>
	/// Shall mipmaps be used if available?
	/// Sometimes, disabling mipmap usage can be useful.
	/// Default is true.
	/// </summary>
	property bool Mipmaps { bool get(); void set(bool value); }

	/// <summary>
	/// Is this a transparent meterial.
	/// Takes into account material type, blend operation and blend factor.
	/// </summary>
	property bool Transparent { bool get(); }

	/// <summary>
	/// Texture layers.
	/// </summary>
	property List<MaterialLayer^>^ Layer { List<MaterialLayer^>^ get(); }

	virtual String^ ToString() override;

internal:

	static Material^ Wrap(video::SMaterial* ref);
	Material(video::SMaterial* ref);
	Material(const video::SMaterial& copy);
};

} // end namespace Video
} // end namespace IrrlichtLime
