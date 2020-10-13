#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video {

public ref class Fog
{
public:

	Color^ Color;
	FogType Type;
	float Start;
	float End;
	float Density;
	bool PixelFog;
	bool RangeFog;

	Fog(Video::Color^ color, FogType type, float start, float end, float density, bool pixelFog, bool rangeFog)
		: Color(color)
		, Type(type)
		, Start(start)
		, End(end)
		, Density(density)
		, PixelFog(pixelFog)
		, RangeFog(rangeFog) {}

	Fog(Video::Color^ color, FogType type, float start, float end, float density, bool pixelFog)
		: Color(color)
		, Type(type)
		, Start(start)
		, End(end)
		, Density(density)
		, PixelFog(pixelFog)
		, RangeFog(false) {}

	Fog(Video::Color^ color, FogType type, float start, float end, float density)
		: Color(color)
		, Type(type)
		, Start(start)
		, End(end)
		, Density(density)
		, PixelFog(false)
		, RangeFog(false) {}

	Fog(Video::Color^ color, FogType type, float start, float end)
		: Color(color)
		, Type(type)
		, Start(start)
		, End(end)
		, Density(0.01f)
		, PixelFog(false)
		, RangeFog(false) {}

	Fog(Video::Color^ color, FogType type)
		: Color(color)
		, Type(type)
		, Start(50.0f)
		, End(100.0f)
		, Density(0.01f)
		, PixelFog(false)
		, RangeFog(false) {}

	Fog(Video::Color^ color)
		: Color(color)
		, Type(FogType::Linear)
		, Start(50.0f)
		, End(100.0f)
		, Density(0.01f)
		, PixelFog(false)
		, RangeFog(false) {}

	Fog()
		: Color(gcnew Video::Color(255, 255, 255, 0))
		, Type(FogType::Linear)
		, Start(50.0f)
		, End(100.0f)
		, Density(0.01f)
		, PixelFog(false)
		, RangeFog(false) {}

	virtual String^ ToString() override
	{
		return String::Format("Fog: Type={0}; Color={1}", Type, Color);
	}
};

} // end namespace Video
} // end namespace IrrlichtLime