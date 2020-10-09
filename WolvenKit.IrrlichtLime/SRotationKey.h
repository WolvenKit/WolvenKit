#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class SRotationKey
{
public:

	property Quaternion^ Rotation { Quaternion^ get(); void set(Quaternion^); }
	property float Frame { float get(); void set(float); }

internal:

	static SRotationKey^ Wrap(scene::ISkinnedMesh::SRotationKey* ref);
	SRotationKey(scene::ISkinnedMesh::SRotationKey* ref);

	scene::ISkinnedMesh::SRotationKey* m_RotationKey;
};

} // end namespace Scene
} // end namespace IrrlichtLime
