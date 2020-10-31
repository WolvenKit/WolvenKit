#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video { ref class Material; }
namespace Scene {

public ref class MeshBuffer : ReferenceCounted
{
public:

	static MeshBuffer^ Create(Video::VertexType vertexType, Video::IndexType indexType);

	void Append(MeshBuffer^ other);
	void Append(array<Video::Vertex3D^>^ verticesStandard, array<unsigned short>^ indices16bit);
	void Append(array<Video::Vertex3DTTCoords^>^ verticesTTCoords, array<unsigned short>^ indices16bit);
	void Append(array<Video::Vertex3DTangents^>^ verticesTangents, array<unsigned short>^ indices16bit);
	void Append(array<Video::Vertex3D^>^ verticesStandard, array<unsigned int>^ indices32bit);
	void Append(array<Video::Vertex3D^>^ verticesStandard, array<unsigned int>^ indices32bit, PrimitiveType ptype);
	void Append(array<Video::Vertex3DTTCoords^>^ verticesTTCoords, array<unsigned int>^ indices32bit);
	void Append(array<Video::Vertex3DTangents^>^ verticesTangents, array<unsigned int>^ indices32bit);
	void Append(array<Video::Vertex3DTTCoords^>^ verticesTTCoords, array<unsigned int>^ indices32bit, PrimitiveType ptype);

	Vector3Df^ GetNormal(int vertexIndex);
	Vector3Df^ GetPosition(int vertexIndex);
	Vector2Df^ GetTCoords(int vertexIndex);
	Object^ GetVertex(int vertexIndex);
	//Video::IVertex3D^ GetVertex(int vertexIndex);

	void RecalculateBoundingBox();

	void SetDirty(HardwareBufferType buffer);
	void SetHardwareMappingHint(HardwareMappingHint mappingHint, HardwareBufferType buffer);

	void SetMaterial(Video::Material^ newMaterialToCopyFrom);

	void UpdateIndices(array<unsigned short>^ indices16bit, int startIndex);
	void UpdateIndices(array<unsigned int>^ indices32bit, int startIndex);
	void UpdateVertices(array<Video::Vertex3D^>^ verticesStandard, int startIndex);
	void UpdateVertices(array<Video::Vertex3DTTCoords^>^ verticesTTCoords, int startIndex);
	void UpdateVertices(array<Video::Vertex3DTangents^>^ verticesTangents, int startIndex);

	property AABBox^ BoundingBox { AABBox^ get(); void set(AABBox^ value); }
	property HardwareMappingHint HardwareMappingHintForIndex { HardwareMappingHint get(); }
	property HardwareMappingHint HardwareMappingHintForVertex { HardwareMappingHint get(); }
	property int IndexCount { int get(); }
	property Video::IndexType IndexType { Video::IndexType get(); }
	property Object^ Indices { Object^ get(); }
	property Video::Material^ Material { Video::Material^ get(); }
	property int VertexCount { int get(); }
	property Video::VertexType VertexType { Video::VertexType get(); }
	property Object^ Vertices { Object^ get(); }

	virtual String^ ToString() override;

internal:

	static MeshBuffer^ Wrap(scene::IMeshBuffer* ref);
	MeshBuffer(scene::IMeshBuffer* ref);

	scene::IMeshBuffer* m_MeshBuffer;
};

} // end namespace Scene
} // end namespace IrrlichtLime