#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class SScaleKey
{
public:

	property Vector3Df^ Scale { Vector3Df^ get(); void set(Vector3Df^); }
	property float Frame { float get(); void set(float); }

internal:

	static SScaleKey^ Wrap(scene::ISkinnedMesh::SScaleKey* ref);
	SScaleKey(scene::ISkinnedMesh::SScaleKey* ref);

	scene::ISkinnedMesh::SScaleKey* m_ScaleKey;
};

} // end namespace Scene
} // end namespace IrrlichtLime
