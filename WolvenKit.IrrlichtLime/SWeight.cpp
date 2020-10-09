#include "stdafx.h"
#include "SWeight.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

SWeight^ SWeight::Wrap(scene::ISkinnedMesh::SWeight* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SWeight(ref);
}

SWeight::SWeight(scene::ISkinnedMesh::SWeight* ref)
{
	LIME_ASSERT(ref != nullptr);
	m_Weight = ref;
}

unsigned short SWeight::BufferId::get()
{
	return m_Weight->buffer_id;
}

void SWeight::BufferId::set(unsigned short bufferid)
{
	m_Weight->buffer_id = bufferid;
}

unsigned int SWeight::VertexId::get()
{
	return m_Weight->vertex_id;
}

void SWeight::VertexId::set(unsigned int vertexid)
{
	m_Weight->vertex_id = vertexid;
}

float SWeight::Strength::get()
{
	return m_Weight->strength;
}

void SWeight::Strength::set(float strength)
{
	m_Weight->strength = strength;
}

} // end namespace Scene
} // end namespace IrrlichtLime
