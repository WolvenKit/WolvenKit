#pragma once
#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public enum class MeshWriterType
{
	IrrMesh = EMWT_IRR_MESH,
	Collada = EMWT_COLLADA,
	Stl = EMWT_STL,
	Obj = EMWT_OBJ,
	Ply = EMWT_PLY,
	B3d = EMWT_B3D,
	Fbx = EMWT_FBX
};

} // end namespace Scene
} // end namespace IrrlichtLime