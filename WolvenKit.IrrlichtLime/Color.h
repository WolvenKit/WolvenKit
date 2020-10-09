#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video {

/// <summary>
/// Class representing a 32 bit ARGB color.
/// The color values for alpha, red, green, and blue are stored in a single 32 bit unsigned int.
/// So all four values may be between 0 and 255.
/// Alpha in Irrlicht is opacity, so 0 is fully transparent, 255 is fully opaque (solid).
/// This class is used by most parts of the Irrlicht Engine to specify a color.
/// Another way is using the class SColorf, which stores the color values in 4 floats.
/// </summary>
public ref class Color : Lime::NativeValue<video::SColor>
{
public:

	/// <summary>
	/// Fully opaque black color.
	/// </summary>
	static property Color^ SolidBlack { Color^ get() { return gcnew Color(0, 0, 0); } }

	/// <summary>
	/// Fully opaque blue color.
	/// </summary>
	static property Color^ SolidBlue { Color^ get() { return gcnew Color(0, 0, 255); } }

	/// <summary>
	/// Fully opaque cyan color.
	/// </summary>
	static property Color^ SolidCyan { Color^ get() { return gcnew Color(0, 255, 255); } }

	/// <summary>
	/// Fully opaque green color.
	/// </summary>
	static property Color^ SolidGreen { Color^ get() { return gcnew Color(0, 255, 0); } }

	/// <summary>
	/// Fully opaque magenta color.
	/// </summary>
	static property Color^ SolidMagenta { Color^ get() { return gcnew Color(255, 0, 255); } }

	/// <summary>
	/// Fully opaque red color.
	/// </summary>
	static property Color^ SolidRed { Color^ get() { return gcnew Color(255, 0, 0); } }

	/// <summary>
	/// Fully opaque white color.
	/// </summary>
	static property Color^ SolidWhite { Color^ get() { return gcnew Color(255, 255, 255); } }

	/// <summary>
	/// Fully opaque yellow color.
	/// </summary>
	static property Color^ SolidYellow { Color^ get() { return gcnew Color(255, 255, 0); } }

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (Color^ v1, Color^ v2)
	{
		bool v1n = Object::ReferenceEquals(v1, nullptr);
		bool v2n = Object::ReferenceEquals(v2, nullptr);

		if (v1n && v2n)
			return true;

		if (v1n || v2n)
			return false;

		return (*v1->m_NativeValue) == (*v2->m_NativeValue);
	}

	/// <summary>
	/// Inequality operator.
	/// </summary>
	static bool operator != (Color^ v1, Color^ v2)
	{
		return !(v1 == v2);
	}

	/// <summary>
	/// Default constructor.
	/// Does nothing. The color value is not initialized to save time.
	/// </summary>
	Color()
		: Lime::NativeValue<video::SColor>(true)
	{
		m_NativeValue = new video::SColor();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	Color(Color^ copy)
		: Lime::NativeValue<video::SColor>(true)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new video::SColor(copy->m_NativeValue->color);
	}

	/// <summary>
	/// Constructs the color from a 32 bit value.
	/// </summary>
	Color(u32 argb)
		: Lime::NativeValue<video::SColor>(true)
	{
		m_NativeValue = new video::SColor(argb);
	}

	/// <summary>
	/// Constructs the color from values representing red, green, blue and alpha component.
	/// Must be values between 0 and 255.
	/// </summary>
	/// <param name="a">Alpha component. Default is 255.</param>
	Color(int r, int g, int b, int a)
		: Lime::NativeValue<video::SColor>(true)
	{
		LIME_ASSERT(r >= 0 && r <= 255);
		LIME_ASSERT(g >= 0 && g <= 255);
		LIME_ASSERT(b >= 0 && b <= 255);
		LIME_ASSERT(a >= 0 && a <= 255);

		m_NativeValue = new video::SColor(a, r, g, b);
	}

	/// <summary>
	/// Constructs the color from values representing red, green, blue and alpha component.
	/// Must be values between 0 and 255.
	/// </summary>
	Color(int r, int g, int b)
		: Lime::NativeValue<video::SColor>(true)
	{
		LIME_ASSERT(r >= 0 && r <= 255);
		LIME_ASSERT(g >= 0 && g <= 255);
		LIME_ASSERT(b >= 0 && b <= 255);

		m_NativeValue = new video::SColor(255, r, g, b);
	}

	/// <summary>
	/// Set this color from another color.
	/// </summary>
	void Set(Color^ copy)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue->set(copy->m_NativeValue->color);
	}

	/// <summary>
	/// Set this color from values representing red, green, blue and alpha component.
	/// Must be values between 0 and 255.
	/// </summary>
	/// <param name="a">Alpha component. Default is 255.</param>
	void Set(int r, int g, int b, int a)
	{
		LIME_ASSERT(r >= 0 && r <= 255);
		LIME_ASSERT(g >= 0 && g <= 255);
		LIME_ASSERT(b >= 0 && b <= 255);
		LIME_ASSERT(a >= 0 && a <= 255);

		m_NativeValue->set(a, r, g, b);
	}

	/// <summary>
	/// Set this color from values representing red, green, blue and alpha component.
	/// Must be values between 0 and 255.
	/// </summary>
	void Set(int r, int g, int b)
	{
		LIME_ASSERT(r >= 0 && r <= 255);
		LIME_ASSERT(g >= 0 && g <= 255);
		LIME_ASSERT(b >= 0 && b <= 255);

		m_NativeValue->set(m_NativeValue->getAlpha(), r, g, b);
	}

	/// <summary>
	/// Set this color from a 32 bit value.
	/// </summary>
	void Set(u32 argb)
	{
		m_NativeValue->set(argb);
	}

	/// <summary>
	/// Interpolates this color to another color.
	/// </summary>
	/// <param name="other">Other color.</param>
	/// <param name="d">Value between 0.0f and 1.0f. d=0 returns other, d=1 returns this, values between interpolate.</param>
	/// <returns>Interpolated color.</returns>
	Color^ GetInterpolated(Color^ other, f32 d)
	{
		LIME_ASSERT(other != nullptr);
		return gcnew Color(m_NativeValue->getInterpolated(*other->m_NativeValue, d));
	}

	/// <summary>
	/// Quadratic color interpolation.
	/// </summary>
	/// <param name="c1">First color to interpolate with.</param>
	/// <param name="c2">Second color to interpolate with.</param>
	/// <param name="d">Value between 0.0f and 1.0f.</param>
	/// <returns>Interpolated (quadratic) color.</returns>
	Color^ GetInterpolatedQuadratic(Color^ c1, Color^ c2, f32 d)
	{
		LIME_ASSERT(c1 != nullptr);
		LIME_ASSERT(c2 != nullptr);

		return gcnew Color(m_NativeValue->getInterpolated_quadratic(*c1->m_NativeValue, *c2->m_NativeValue, d));
	}

	/// <summary>
	/// 16 bit A1R5G5B5 value of this color.
	/// </summary>
	property u16 A1R5G5B5
	{
		u16 get() { return m_NativeValue->toA1R5G5B5(); }
	}

	/// <summary>
	/// The alpha component of the color.
	/// This component defines how opaque a color is: 0 is fully transparent, 255 is fully opaque.
	/// </summary>
	property int Alpha
	{
		int get() { return m_NativeValue->getAlpha(); }
		void set(int value) { LIME_ASSERT(value >= 0 && value <= 255); m_NativeValue->setAlpha(value); }
	}

	/// <summary>
	/// Color in A8R8G8B8 Format.
	/// </summary>
	property u32 ARGB
	{
		u32 get() { return m_NativeValue->color; }
		void set(u32 value) { m_NativeValue->color = value; }
	}

	/// <summary>
	/// Average intensity of the color in the range [0,255].
	/// </summary>
	property int Average
	{
		int get() { return m_NativeValue->getAverage(); }
	}

	/// <summary>
	/// The blue component of the color.
	/// Value between 0 and 255, specifying how blue the color is.
	/// 0 means no blue, 255 means full blue.
	/// </summary>
	property int Blue
	{
		int get() { return m_NativeValue->getBlue(); }
		void set(int value) { LIME_ASSERT(value >= 0 && value <= 255); m_NativeValue->setBlue(value); }
	}

	/// <summary>
	/// The green component of the color.
	/// Value between 0 and 255, specifying how green the color is.
	/// 0 means no green, 255 means full green.
	/// </summary>
	property int Green
	{
		int get() { return m_NativeValue->getGreen(); }
		void set(int value) { LIME_ASSERT(value >= 0 && value <= 255); m_NativeValue->setGreen(value); }
	}

	/// <summary>
	/// Lightness of the color in the range [0,255].
	/// </summary>
	property float Lightness
	{
		float get() { return m_NativeValue->getLightness(); }
	}

	/// <summary>
	/// Luminance of the color in the range [0,255].
	/// </summary>
	property float Luminance
	{
		float get() { return m_NativeValue->getLuminance(); }
	}

	/// <summary>
	/// The red component of the color.
	/// Value between 0 and 255, specifying how red the color is.
	/// 0 means no red, 255 means full red.
	/// </summary>
	property int Red
	{
		int get() { return m_NativeValue->getRed(); }
		void set(int value) { LIME_ASSERT(value >= 0 && value <= 255); m_NativeValue->setRed(value); }
	}

	virtual String^ ToString() override
	{
		return String::Format("{0:X2}, {1:X2}, {2:X2} ^ {3:X2}", Red, Green, Blue, Alpha);
	}

internal:

	Color(const video::SColor& value)
		: Lime::NativeValue<video::SColor>(true)
	{
		m_NativeValue = new video::SColor(value);
	}
};

/// <summary>
/// Class representing a color with four floats.
/// The color values for red, green, blue and alpha are each stored in a 32 bit floating point variable.
/// So all four values may be between 0.0f and 1.0f.
/// Another, faster way to define colors is using the class Color, which stores the color values in a single 32 bit integer.
/// </summary>
public ref class Colorf : Lime::NativeValue<video::SColorf>
{
public:

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (Colorf^ v1, Colorf^ v2)
	{
		bool v1n = Object::ReferenceEquals(v1, nullptr);
		bool v2n = Object::ReferenceEquals(v2, nullptr);

		if (v1n && v2n)
			return true;

		if (v1n || v2n)
			return false;

		video::SColorf& c1 = *v1->m_NativeValue;
		video::SColorf& c2 = *v2->m_NativeValue;

		return
			core::equals(c1.r, c2.r) &&
			core::equals(c1.g, c2.g) &&
			core::equals(c1.b, c2.b) &&
			core::equals(c1.a, c2.a);
	}

	/// <summary>
	/// Inequality operator.
	/// </summary>
	static bool operator != (Colorf^ v1, Colorf^ v2)
	{
		return !(v1 == v2);
	}

	/// <summary>
	/// Default constructor.
	/// Sets red, green and blue to 0.0f and alpha to 1.0f.
	/// </summary>
	Colorf()
		: Lime::NativeValue<video::SColorf>(true)
	{
		m_NativeValue = new video::SColorf();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	Colorf(Colorf^ copy)
		: Lime::NativeValue<video::SColorf>(true)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue = new video::SColorf(
			copy->m_NativeValue->r,
			copy->m_NativeValue->g,
			copy->m_NativeValue->b,
			copy->m_NativeValue->a);
	}

	/// <summary>
	/// Constructs a color from 32 bit Color.
	/// </summary>
	Colorf(Color^ copyColor)
		: Lime::NativeValue<video::SColorf>(true)
	{
		LIME_ASSERT(copyColor != nullptr);
		m_NativeValue = new video::SColorf(*copyColor->m_NativeValue);
	}

	/// <summary>
	/// Constructs a color from up to four color values: red, green, blue, and alpha.
	/// </summary>
	/// <param name="a">Alpha component. Default is 1.0f.</param>
	Colorf(float r, float g, float b, float a)
		: Lime::NativeValue<video::SColorf>(true)
	{
		LIME_ASSERT(r >= 0.0f && r <= 1.0f);
		LIME_ASSERT(g >= 0.0f && g <= 1.0f);
		LIME_ASSERT(b >= 0.0f && b <= 1.0f);
		LIME_ASSERT(a >= 0.0f && a <= 1.0f);

		m_NativeValue = new video::SColorf(r, g, b, a);
	}

	/// <summary>
	/// Constructs a color from up to four color values: red, green, blue, and alpha.
	/// </summary>
	Colorf(float r, float g, float b)
		: Lime::NativeValue<video::SColorf>(true)
	{
		LIME_ASSERT(r >= 0.0f && r <= 1.0f);
		LIME_ASSERT(g >= 0.0f && g <= 1.0f);
		LIME_ASSERT(b >= 0.0f && b <= 1.0f);

		m_NativeValue = new video::SColorf(r, g, b);
	}

	/// <summary>
	/// Set this color from another color.
	/// </summary>
	void Set(Colorf^ copy)
	{
		LIME_ASSERT(copy != nullptr);
		m_NativeValue->set(
			copy->m_NativeValue->a,
			copy->m_NativeValue->r,
			copy->m_NativeValue->g,
			copy->m_NativeValue->b);
	}

	/// <summary>
	/// Set this color from another color (32 bit integer).
	/// </summary>
	void Set(Color^ copyColor)
	{
		LIME_ASSERT(copyColor != nullptr);
		m_NativeValue->set(
			copyColor->m_NativeValue->getAlpha() / 255.0f,
			copyColor->m_NativeValue->getRed() / 255.0f,
			copyColor->m_NativeValue->getGreen() / 255.0f,
			copyColor->m_NativeValue->getBlue() / 255.0f);
	}

	/// <summary>
	/// Set this color from values representing red, green, blue and alpha component.
	/// Must be values between 0.0f and 1.0f.
	/// </summary>
	void Set(float r, float g, float b, float a)
	{
		LIME_ASSERT(r >= 0.0f && r <= 1.0f);
		LIME_ASSERT(g >= 0.0f && g <= 1.0f);
		LIME_ASSERT(b >= 0.0f && b <= 1.0f);
		LIME_ASSERT(a >= 0.0f && a <= 1.0f);

		m_NativeValue->set(a, r, g, b);
	}

	/// <summary>
	/// Set this color from values representing red, green and blue component.
	/// Must be values between 0.0f and 1.0f.
	/// Alpha component left unchanged.
	/// </summary>
	void Set(float r, float g, float b)
	{
		LIME_ASSERT(r >= 0.0f && r <= 1.0f);
		LIME_ASSERT(g >= 0.0f && g <= 1.0f);
		LIME_ASSERT(b >= 0.0f && b <= 1.0f);

		m_NativeValue->set(r, g, b);
	}

	/// <summary>
	/// Interpolates this color to another color.
	/// </summary>
	/// <param name="other">Other color.</param>
	/// <param name="d">Value between 0.0f and 1.0f. d=0 returns other, d=1 returns this, values between interpolate.</param>
	/// <returns>Interpolated color.</returns>
	Colorf^ GetInterpolated(Colorf^ other, f32 d)
	{
		LIME_ASSERT(other != nullptr);
		return gcnew Colorf(m_NativeValue->getInterpolated(*other->m_NativeValue, d));
	}

	/// <summary>
	/// Quadratic color interpolation.
	/// </summary>
	/// <param name="c1">First color to interpolate with.</param>
	/// <param name="c2">Second color to interpolate with.</param>
	/// <param name="d">Value between 0.0f and 1.0f.</param>
	/// <returns>Interpolated (quadratic) color.</returns>
	Colorf^ GetInterpolatedQuadratic(Colorf^ c1, Colorf^ c2, f32 d)
	{
		LIME_ASSERT(c1 != nullptr);
		LIME_ASSERT(c2 != nullptr);

		return gcnew Colorf(m_NativeValue->getInterpolated_quadratic(*c1->m_NativeValue, *c2->m_NativeValue, d));
	}

	/// <summary>
	/// Returns this color as array of four floats.
	/// </summary>
	array<float>^ ToArray()
	{
		array<float>^ a = gcnew array<float>(4);
		float* c = (float*)m_NativeValue;

		for (int i = 0; i < 4; i++)
			a[i] = c[i];

		return a;
	}

	/// <summary>
	/// Returns 32 bit integer color.
	/// </summary>
	Color^ ToColor()
	{
		return gcnew Color(m_NativeValue->toSColor());
	}

	/// <summary>
	/// The alpha component of the color.
	/// This component defines how opaque a color is: 0.0f is fully transparent, 1.0f is fully opaque.
	/// </summary>
	property float Alpha
	{
		float get() { return m_NativeValue->a; }
		void set(float value) { LIME_ASSERT(value >= 0.0f && value <= 1.0f); m_NativeValue->a = value; }
	}

	/// <summary>
	/// The blue component of the color.
	/// Value between 0.0f and 1.0f.
	/// </summary>
	property float Blue
	{
		float get() { return m_NativeValue->b; }
		void set(float value) { LIME_ASSERT(value >= 0.0f && value <= 1.0f); m_NativeValue->b = value; }
	}

	/// <summary>
	/// The green component of the color.
	/// Value between 0.0f and 1.0f.
	/// </summary>
	property float Green
	{
		float get() { return m_NativeValue->g; }
		void set(float value) { LIME_ASSERT(value >= 0.0f && value <= 1.0f); m_NativeValue->g = value; }
	}

	/// <summary>
	/// The red component of the color.
	/// Value between 0.0f and 1.0f.
	/// </summary>
	property float Red
	{
		float get() { return m_NativeValue->r; }
		void set(float value) { LIME_ASSERT(value >= 0.0f && value <= 1.0f); m_NativeValue->r = value; }
	}

	virtual String^ ToString() override
	{
		return String::Format("{0:F3}, {1:F3}, {2:F3} ^ {3:F3}", Red, Green, Blue, Alpha);
	}

internal:

	Colorf(const video::SColorf& value)
		: Lime::NativeValue<video::SColorf>(true)
	{
		m_NativeValue = new video::SColorf(value);
	}
};

/// <summary>
/// Class representing a color in HSL format.
/// The color values for hue, saturation and luminance are stored in 32 bit floating point variables.
/// Hue is in range [0,360], Luminance and Saturation are in percent [0,100].
/// </summary>
public ref class ColorHSL : Lime::NativeValue<video::SColorHSL>
{
public:

	/// <summary>
	/// Equality operator.
	/// </summary>
	static bool operator == (ColorHSL^ v1, ColorHSL^ v2)
	{
		bool v1n = Object::ReferenceEquals(v1, nullptr);
		bool v2n = Object::ReferenceEquals(v2, nullptr);

		if (v1n && v2n)
			return true;

		if (v1n || v2n)
			return false;

		video::SColorHSL& c1 = *v1->m_NativeValue;
		video::SColorHSL& c2 = *v2->m_NativeValue;

		return
			core::equals(c1.Hue, c2.Hue) &&
			core::equals(c1.Saturation, c2.Saturation) &&
			core::equals(c1.Luminance, c2.Luminance);
	}

	/// <summary>
	/// Inequality operator.
	/// </summary>
	static bool operator != (ColorHSL^ v1, ColorHSL^ v2)
	{
		return !(v1 == v2);
	}

	/// <summary>
	/// Default constructor.
	/// Sets hue, saturation and luminance to 0.0f.
	/// </summary>
	ColorHSL()
		: Lime::NativeValue<video::SColorHSL>(true)
	{
		m_NativeValue = new video::SColorHSL();
	}

	/// <summary>
	/// Copy constructor.
	/// </summary>
	ColorHSL(ColorHSL^ copy)
		: Lime::NativeValue<video::SColorHSL>(true)
	{
		LIME_ASSERT(copy != nullptr);

		video::SColorHSL &c = *copy->m_NativeValue;
		m_NativeValue = new video::SColorHSL(c.Hue, c.Saturation, c.Luminance);
	}

	/// <summary>
	/// Constructs a color from 32 bit Color.
	/// </summary>
	ColorHSL(Color^ copyColor)
		: Lime::NativeValue<video::SColorHSL>(true)
	{
		LIME_ASSERT(copyColor != nullptr);

		m_NativeValue = new video::SColorHSL();
		m_NativeValue->fromRGB(video::SColorf(*copyColor->m_NativeValue));
	}

	/// <summary>
	/// Constructs a color from Colorf.
	/// </summary>
	ColorHSL(Colorf^ copyColorf)
		: Lime::NativeValue<video::SColorHSL>(true)
	{
		LIME_ASSERT(copyColorf != nullptr);

		m_NativeValue = new video::SColorHSL();
		m_NativeValue->fromRGB(*copyColorf->m_NativeValue);
	}

	/// <summary>
	/// Constructs a color from specified hue, saturation and luminance values.
	/// </summary>
	/// <param name="hue">Hue component in range [0,360].</param>
	/// <param name="saturation">Saturation component in range [0,100].</param>
	/// <param name="luminance">Luminance component in range [0,100].</param>
	ColorHSL(float hue, float saturation, float luminance)
		: Lime::NativeValue<video::SColorHSL>(true)
	{
		LIME_ASSERT(hue >= 0.0f && hue <= 360.0f);
		LIME_ASSERT(saturation >= 0.0f && saturation <= 100.0f);
		LIME_ASSERT(luminance >= 0.0f && luminance <= 100.0f);

		m_NativeValue = new video::SColorHSL(hue, saturation, luminance);
	}

	/// <summary>
	/// Set this color from another ColorHSL.
	/// </summary>
	void Set(ColorHSL^ copy)
	{
		LIME_ASSERT(copy != nullptr);

		video::SColorHSL &c = *copy->m_NativeValue;
		m_NativeValue->Hue = c.Hue;
		m_NativeValue->Saturation = c.Saturation;
		m_NativeValue->Luminance = c.Luminance;
	}

	/// <summary>
	/// Set this color from another 32 bit Color.
	/// </summary>
	void Set(Color^ copyColor)
	{
		LIME_ASSERT(copyColor != nullptr);
		m_NativeValue->fromRGB(video::SColorf(*copyColor->m_NativeValue));
	}

	/// <summary>
	/// Set this color from another Colorf.
	/// </summary>
	void Set(Colorf^ copyColorf)
	{
		LIME_ASSERT(copyColorf != nullptr);
		m_NativeValue->fromRGB(*copyColorf->m_NativeValue);
	}

	/// <summary>
	/// Set this color from specified hue, saturation and luminance values.
	/// </summary>
	/// <param name="hue">Hue component in range [0,360].</param>
	/// <param name="saturation">Saturation component in range [0,100].</param>
	/// <param name="luminance">Luminance component in range [0,100].</param>
	void Set(float hue, float saturation, float luminance)
	{
		LIME_ASSERT(hue >= 0.0f && hue <= 360.0f);
		LIME_ASSERT(saturation >= 0.0f && saturation <= 100.0f);
		LIME_ASSERT(luminance >= 0.0f && luminance <= 100.0f);

		m_NativeValue->Hue = hue;
		m_NativeValue->Saturation = saturation;
		m_NativeValue->Luminance = luminance;
	}

	/// <summary>
	/// Returns 32 bit integer color.
	/// </summary>
	Color^ ToColor()
	{
		Colorf^ c = gcnew Colorf();
		m_NativeValue->toRGB(*c->m_NativeValue);

		return c->ToColor();
	}

	/// <summary>
	/// Returns color represented via four floats.
	/// </summary>
	Colorf^ ToColorf()
	{
		Colorf^ c = gcnew Colorf();
		m_NativeValue->toRGB(*c->m_NativeValue);

		return c;
	}

	/// <summary>
	/// Hue component of the color. Value in range [0,360].
	/// </summary>
	property float Hue
	{
		float get() { return m_NativeValue->Hue; }
		void set(float value) { LIME_ASSERT(value >= 0.0f && value <= 360.0f); m_NativeValue->Hue = value; }
	}

	/// <summary>
	/// Luminance component of the color. Value in range [0,100].
	/// </summary>
	property float Luminance
	{
		float get() { return m_NativeValue->Luminance; }
		void set(float value) { LIME_ASSERT(value >= 0.0f && value <= 100.0f); m_NativeValue->Luminance = value; }
	}

	/// <summary>
	/// Saturation component of the color. Value in range [0,100].
	/// </summary>
	property float Saturation
	{
		float get() { return m_NativeValue->Saturation; }
		void set(float value) { LIME_ASSERT(value >= 0.0f && value <= 100.0f); m_NativeValue->Saturation = value; }
	}

	virtual String^ ToString() override
	{
		return String::Format("Hue={0:F3}, Saturation={1:F3}, Luminance={2:F3}", Hue, Saturation, Luminance);
	}

internal:

	ColorHSL(const video::SColorHSL& value)
		: Lime::NativeValue<video::SColorHSL>(true)
	{
		m_NativeValue = new video::SColorHSL(value);
	}
};

} // end namespace Video
} // end namespace IrrlichtLime
