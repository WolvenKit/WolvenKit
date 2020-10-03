#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class SWeight
{
public:

	property unsigned short BufferId { unsigned short get(); void set(unsigned short); }
	property unsigned int VertexId { unsigned int get(); void set(unsigned int); }
	property float Strength { float get(); void set(float); }

internal:

	static SWeight^ Wrap(scene::ISkinnedMesh::SWeight* ref);
	SWeight(scene::ISkinnedMesh::SWeight* ref);

	scene::ISkinnedMesh::SWeight* m_Weight;
};

} // end namespace Scene
} // end namespace IrrlichtLime
