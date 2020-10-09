#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

// This class works only with video::EVT_STANDARD vertices
// Maybe in future rename this class to Vertex3DBuffer and add 2 more proper classes to support other vertices types
// (if i will decide so, don't forget to implement it using sub templates like i did with Vertex3D* and other core types)
public ref class VertexBuffer : ReferenceCounted
{
public:

	static VertexBuffer^ Create();

	void Add(Video::Vertex3D^ vertex);
	Video::Vertex3D^ Get(int index);
	void Set(int index, Video::Vertex3D^ vertex);

	void Clear();
	void Reallocate(int newAllocatedCount);
	void SetCount(int newCount);
	void SetDirty();

	property int AllocatedCount { int get(); }
	property int Count { int get(); }
	property Scene::HardwareMappingHint HardwareMappingHint { Scene::HardwareMappingHint get(); void set(Scene::HardwareMappingHint value); }
	property Video::VertexType Type { Video::VertexType get(); }
	property array<Video::Vertex3D^>^ Vertices { array<Video::Vertex3D^>^ get(); }

	virtual String^ ToString() override;

internal:

	static VertexBuffer^ Wrap(scene::IVertexBuffer* ref);
	VertexBuffer(scene::IVertexBuffer* ref);

	scene::IVertexBuffer* m_VertexBuffer;
};

} // end namespace Scene
} // end namespace IrrlichtLime