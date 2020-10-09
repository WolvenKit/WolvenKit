#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class IndexBuffer : ReferenceCounted
{
public:

	static IndexBuffer^ Create(Video::IndexType type);

	void Add(int index);
	int Get(int i);
	void Set(int i, int index);

	void Clear();
	void Reallocate(int newAllocatedCount);
	void SetCount(int newCount);
	void SetDirty();

	property int AllocatedCount { int get(); }
	property int Count { int get(); }
	property Scene::HardwareMappingHint HardwareMappingHint { Scene::HardwareMappingHint get(); void set(Scene::HardwareMappingHint value); }
	property array<int>^ Indices { array<int>^ get(); }
	property Video::IndexType Type { Video::IndexType get(); }

	virtual String^ ToString() override;

internal:

	static IndexBuffer^ Wrap(scene::IIndexBuffer* ref);
	IndexBuffer(scene::IIndexBuffer* ref);

	scene::IIndexBuffer* m_IndexBuffer;
};

} // end namespace Scene
} // end namespace IrrlichtLime