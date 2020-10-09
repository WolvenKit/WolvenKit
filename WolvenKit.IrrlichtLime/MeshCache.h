#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ref class AnimatedMesh;

public ref class MeshCache : ReferenceCounted
{
public:

	void AddMesh(String^ name, AnimatedMesh^ mesh);
	void Clear(bool unusedOnly);
	void Clear();

	AnimatedMesh^ GetMesh(int index);
	AnimatedMesh^ GetMesh(String^ name);

	int GetMeshIndex(Mesh^ mesh);

	IO::NamedPath^ GetMeshName(Mesh^ mesh);
	IO::NamedPath^ GetMeshName(int index);

	bool IsMeshLoaded(String^ name);

	void RemoveMesh(Mesh^ mesh);

	bool RenameMesh(Mesh^ mesh, String^ name);
	bool RenameMesh(int index, String^ name);

	property int MeshCount { int get(); }

	virtual String^ ToString() override;

internal:

	static MeshCache^ Wrap(scene::IMeshCache* ref);
	MeshCache(scene::IMeshCache* ref);

	scene::IMeshCache* m_MeshCache;
};

} // end namespace Scene
} // end namespace IrrlichtLime