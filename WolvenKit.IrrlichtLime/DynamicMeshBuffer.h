#pragma once

#include "stdafx.h"
#include "MeshBuffer.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

ref class IndexBuffer;
ref class VertexBuffer;

public ref class DynamicMeshBuffer : MeshBuffer
{
public:

	property Scene::IndexBuffer^ IndexBuffer { Scene::IndexBuffer^ get(); void set(Scene::IndexBuffer^ value); }
	property Scene::VertexBuffer^ VertexBuffer { Scene::VertexBuffer^ get(); void set(Scene::VertexBuffer^ value); }

internal:

	static DynamicMeshBuffer^ Wrap(scene::IDynamicMeshBuffer* ref);
	DynamicMeshBuffer(scene::IDynamicMeshBuffer* ref);

	scene::IDynamicMeshBuffer* m_DynamicMeshBuffer;
};

} // end namespace Scene
} // end namespace IrrlichtLime