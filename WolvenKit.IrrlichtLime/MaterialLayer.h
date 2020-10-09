#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video {

ref class Texture;

public ref class MaterialLayer : Lime::NativeValue<video::SMaterialLayer>
{
public:

	MaterialLayer();

	property unsigned __int8 AnisotropicFilter { unsigned __int8 get(); void set(unsigned __int8 value); }
	property bool BilinearFilter { bool get(); void set(bool value); }
	property __int8 LODBias { __int8 get(); void set(__int8 value); }
	property Video::Texture^ Texture { Video::Texture^ get(); void set(Video::Texture^ value); }
	property Matrix^ TextureMatrix { Matrix^ get(); void set(Matrix^ value); }
	property TextureClamp TextureWrapU { TextureClamp get(); void set(TextureClamp value); }
	property TextureClamp TextureWrapV { TextureClamp get(); void set(TextureClamp value); }
	property bool TrilinearFilter { bool get(); void set(bool value); }

	virtual String^ ToString() override;

internal:

	MaterialLayer(video::SMaterialLayer* ref);
};

} // end namespace Video
} // end namespace IrrlichtLime