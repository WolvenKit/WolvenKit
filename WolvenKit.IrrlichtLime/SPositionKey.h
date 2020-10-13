#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class SPositionKey
{
public:

	property Vector3Df^ Position { Vector3Df^ get(); void set(Vector3Df^); }
	property float Frame { float get(); void set(float); }

internal:

	static SPositionKey^ Wrap(scene::ISkinnedMesh::SPositionKey* ref);
	SPositionKey(scene::ISkinnedMesh::SPositionKey* ref);

	scene::ISkinnedMesh::SPositionKey* m_PositionKey;
};

} // end namespace Scene
} // end namespace IrrlichtLime
