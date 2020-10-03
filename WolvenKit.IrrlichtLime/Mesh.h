#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video { ref class Material; }
namespace Scene {

ref class MeshBuffer;

public ref class Mesh : ReferenceCounted
{
public:

	static Mesh^ Create();

	void AddMeshBufferEx(MeshBuffer^ buffer);
	
	MeshBuffer^ GetMeshBuffer(Video::Material^ material);
	MeshBuffer^ GetMeshBuffer(int index);

	// void RecalculateBoundingBox(); //vl

	// void RemoveMeshBuffer(int index); //vl
	// void RemoveMeshBuffer(int index, int count); //vl

	/// <summary>Flag the meshbuffer as changed, reloads hardware buffers.
	/// This method has to be called every time the vertices or indices have changed. Otherwise, changes won't be updated on the GPU in the next render cycle.</summary>
	/// <param name="buffer">Type of buffer to flag as changed. Default: <see cref="HardwareBufferType::VertexAndIndex"/>.</param>
	void SetDirty(HardwareBufferType buffer);

	/// <summary>Flag the meshbuffer as changed, reloads hardware buffers.
	/// This method has to be called every time the vertices or indices have changed. Otherwise, changes won't be updated on the GPU in the next render cycle.</summary>
	void SetDirty();

	void SetHardwareMappingHint(HardwareMappingHint mappingHint, HardwareBufferType buffer);
	void SetMaterialFlag(Video::MaterialFlag flag, bool newvalue);

	property AABBox^ BoundingBox { AABBox^ get(); void set(AABBox^ value); }
	property int MeshBufferCount { int get(); }
	property array<MeshBuffer^>^ MeshBuffers { array<MeshBuffer^>^ get(); }

	virtual String^ ToString() override;

internal:

	static Mesh^ Wrap(scene::IMesh* ref);
	Mesh(scene::IMesh* ref);

	scene::IMesh* m_Mesh;
};

} // end namespace Scene
} // end namespace IrrlichtLime