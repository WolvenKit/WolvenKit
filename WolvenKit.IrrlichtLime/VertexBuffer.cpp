#include "stdafx.h"
#include "ReferenceCounted.h"
#include "VertexBuffer.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

VertexBuffer^ VertexBuffer::Wrap(scene::IVertexBuffer* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew VertexBuffer(ref);
}

VertexBuffer::VertexBuffer(scene::IVertexBuffer* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_VertexBuffer = ref;
}

VertexBuffer^ VertexBuffer::Create()
{
	scene::IVertexBuffer* v = new scene::CVertexBuffer(video::EVT_STANDARD);
	return gcnew VertexBuffer(v);
}

void VertexBuffer::Add(Video::Vertex3D^ vertex)
{
	LIME_ASSERT(vertex != nullptr);
	m_VertexBuffer->push_back(*vertex->m_NativeValue);
}

Video::Vertex3D^ VertexBuffer::Get(int index)
{
	LIME_ASSERT(index >= 0 && index < Count);
	return gcnew Video::Vertex3D((*m_VertexBuffer)[index]);
}

void VertexBuffer::Set(int index, Video::Vertex3D^ vertex)
{
	LIME_ASSERT(index >= 0 && index < Count);
	LIME_ASSERT(vertex != nullptr);

	(*m_VertexBuffer)[index] = *vertex->m_NativeValue;
}

void VertexBuffer::Clear()
{
	m_VertexBuffer->reallocate(0);
}

void VertexBuffer::Reallocate(int newAllocatedCount)
{
	LIME_ASSERT(newAllocatedCount >= 0);
	m_VertexBuffer->reallocate(newAllocatedCount);
}

void VertexBuffer::SetCount(int newCount)
{
	LIME_ASSERT(newCount >= 0);
	m_VertexBuffer->set_used(newCount);
}

void VertexBuffer::SetDirty()
{
	m_VertexBuffer->setDirty();
}

int VertexBuffer::AllocatedCount::get()
{
	return m_VertexBuffer->allocated_size();
}

int VertexBuffer::Count::get()
{
	return m_VertexBuffer->size();
}

Scene::HardwareMappingHint VertexBuffer::HardwareMappingHint::get()
{
	return (Scene::HardwareMappingHint)m_VertexBuffer->getHardwareMappingHint();
}

void VertexBuffer::HardwareMappingHint::set(Scene::HardwareMappingHint value)
{
	m_VertexBuffer->setHardwareMappingHint((scene::E_HARDWARE_MAPPING)value);
}

Video::VertexType VertexBuffer::Type::get()
{
	return (Video::VertexType)m_VertexBuffer->getType();
}

array<Video::Vertex3D^>^ VertexBuffer::Vertices::get()
{
	int c = m_VertexBuffer->size();
	array<Video::Vertex3D^>^ a = gcnew array<Video::Vertex3D^>(c);

	for (int i = 0; i < c; i++)
		a[i] = gcnew Video::Vertex3D((*m_VertexBuffer)[i]);

	return a;
}

String^ VertexBuffer::ToString()
{
	return String::Format("VertexBuffer: {0} {1} vertices", Count, Type);
}

} // end namespace Scene
} // end namespace IrrlichtLime