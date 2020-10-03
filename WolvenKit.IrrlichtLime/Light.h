#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video {

/// <summary>
/// Describes a dynamic point light.
/// Irrlicht supports point lights, spot lights, and directional lights.
/// </summary>
public ref class Light : Lime::NativeValue<video::SLight>
{
public:

	/// <summary>
	/// Default constructor.
	/// </summary>
	Light();

	/// <summary>
	/// Ambient color emitted by the light.
	/// </summary>
	property Colorf^ AmbientColor { Colorf^ get(); void set(Colorf^ value); }

	/// <summary>
	/// Attenuation factors (constant, linear, quadratic).
	/// Changes the light strength fading over distance.
	/// Can also be altered by setting the Radius, Attenuation will change to (0,1.0f/Radius,0).
	/// Can be overridden after radius was set.
	/// </summary>
	property Vector3Df^ Attenuation { Vector3Df^ get(); void set(Vector3Df^ value); }

	/// <summary>
	/// Does the light cast shadows?
	/// </summary>
	property bool CastShadows { bool get(); void set(bool value); }

	/// <summary>
	/// Diffuse color emitted by the light.
	/// This is the primary color you want to set.
	/// </summary>
	property Colorf^ DiffuseColor { Colorf^ get(); void set(Colorf^ value); }

	/// <summary>
	/// Direction of the light.
	/// If Type is <see cref="LightType::Point"/>, it is ignored.
	/// Changed via light scene node's rotation.
	/// </summary>
	property Vector3Df^ Direction { Vector3Df^ get(); void set(Vector3Df^ value); }

	/// <summary>
	/// The light strength's decrease between Outer and Inner cone.
	/// </summary>
	property float Falloff { float get(); void set(float value); }

	/// <summary>
	/// The angle of the spot's inner cone.
	/// Ignored for other lights.
	/// </summary>
	property float InnerCone { float get(); void set(float value); }

	/// <summary>
	/// The angle of the spot's outer cone.
	/// Ignored for other lights.
	/// </summary>
	property float OuterCone { float get(); void set(float value); }

	/// <summary>
	/// Position of the light.
	/// If Type is <see cref="LightType::Directional"/>, it is ignored.
	/// Changed via light scene node's position.
	/// </summary>
	property Vector3Df^ Position { Vector3Df^ get(); void set(Vector3Df^ value); }

	/// <summary>
	/// Radius of the light.
	/// Everything within this radius will be lighted.
	/// </summary>
	property float Radius { float get(); void set(float value); }

	/// <summary>
	/// Specular color emitted by the light.
	/// For details how to use specular highlights, see <c>Material.Shininess</c>.
	/// </summary>
	property Colorf^ SpecularColor { Colorf^ get(); void set(Colorf^ value); }

	/// <summary>
	/// Type of the light.
	/// </summary>
	property LightType Type { LightType get(); void set(LightType value); }

	virtual String^ ToString() override;

internal:

	Light(video::SLight* ref);
};

} // end namespace Video
} // end namespace IrrlichtLime
