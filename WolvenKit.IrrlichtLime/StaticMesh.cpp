#include "stdafx.h"
#include "Material.h"
#include "StaticMesh.h"
#include "MeshBuffer.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

StaticMesh^ StaticMesh::Wrap(scene::SMesh* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew StaticMesh(ref);
}

StaticMesh::StaticMesh(scene::SMesh* ref)
	: Mesh(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_Mesh = ref;
}

StaticMesh^ StaticMesh::Create()
{
	scene::SMesh* m = new scene::SMesh();
	return gcnew StaticMesh(m);
}

void StaticMesh::AddMeshBuffer(MeshBuffer^ buffer)
{
	LIME_ASSERT(buffer != nullptr);

	m_Mesh->addMeshBuffer(buffer->m_MeshBuffer);
}

void StaticMesh::Clear()
{
	m_Mesh->clear();
}

void StaticMesh::RecalculateBoundingBox()
{
	m_Mesh->recalculateBoundingBox();
}

void StaticMesh::RemoveMeshBuffer(int index)
{
	LIME_ASSERT(index >= 0 && index < MeshBufferCount);
	
	scene::SMesh* m = m_Mesh;
	m->MeshBuffers[index]->drop();
	m->MeshBuffers.erase(index);
}

void StaticMesh::RemoveMeshBuffer(int index, int count)
{
	LIME_ASSERT(index >= 0 && index < MeshBufferCount);
	LIME_ASSERT(count >= 1 && index + count <= MeshBufferCount);
	
	scene::SMesh* m = m_Mesh;

	for (int i = index; i < index + count; i++)
		m->MeshBuffers[i]->drop();

	m->MeshBuffers.erase(index, count);
}

String^ StaticMesh::ToString()
{
	unsigned int totalVertices = 0;
	unsigned int totalIndices = 0;
	for (unsigned int i = 0; i < m_Mesh->getMeshBufferCount(); i++)
	{
		scene::IMeshBuffer* mb = m_Mesh->getMeshBuffer(i);
		totalVertices += mb->getVertexCount();
		totalIndices += mb->getIndexCount();
	}
	
	return String::Format(
		"StaticMesh: {0} vertices and {1} indices in {2} mesh buffer(s)",
		totalVertices, totalIndices, m_Mesh->getMeshBufferCount());
}

} // end namespace Scene
} // end namespace IrrlichtLime