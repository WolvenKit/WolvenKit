#pragma once

#include "stdafx.h"
#include "Mesh.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video { ref class Material; }
namespace Scene {

ref class MeshBuffer;

public ref class StaticMesh : Mesh
{
public:

	static StaticMesh^ Create();

    void AddMeshBuffer(MeshBuffer^ buffer);

	void Clear();

	void RecalculateBoundingBox();

	void RemoveMeshBuffer(int index);
	void RemoveMeshBuffer(int index, int count);

	virtual String^ ToString() override;

internal:

	static StaticMesh^ Wrap(scene::SMesh* ref);
	StaticMesh(scene::SMesh* ref);

	scene::SMesh* m_Mesh;
};

} // end namespace Scene
} // end namespace IrrlichtLime