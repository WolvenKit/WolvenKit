#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video {

ref class TexturePainter;

public ref class Texture : ReferenceCounted
{
public:

	void RegenerateMipMapLevels(); // argument "void *mipmapData=0" not supported

	property bool AlphaChannel { bool get(); }
	property Video::ColorFormat ColorFormat { Video::ColorFormat get(); }
	property Video::DriverType DriverType { Video::DriverType get(); }
	property bool MipMaps { bool get(); }
	property IO::NamedPath^ Name { IO::NamedPath^ get(); }
	property Dimension2Di^ OriginalSize { Dimension2Di^ get(); }
	property TexturePainter^ Painter { TexturePainter^ get(); }
	property int Pitch { int get(); }
	property bool RenderTarget { bool get(); }
	property Dimension2Di^ Size { Dimension2Di^ get(); }

	virtual String^ ToString() override;

internal:

	static Texture^ Wrap(video::ITexture* ref);
	Texture(video::ITexture* ref);

	video::ITexture* m_Texture;

	Video::TexturePainter^ m_painter;
};

} // end namespace Video
} // end namespace IrrlichtLime