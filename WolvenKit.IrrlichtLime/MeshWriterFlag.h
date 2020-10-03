#pragma once
#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

[Flags]
public enum class MeshWriterFlag
{
	None = EMWF_NONE,
	WriteLightmaps = EMWF_WRITE_LIGHTMAPS,
	WriteCompressed = EMWF_WRITE_COMPRESSED,
	WriteBinary = EMWF_WRITE_BINARY
};

} // end namespace Scene
} // end namespace IrrlichtLime