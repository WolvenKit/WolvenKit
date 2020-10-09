#include "stdafx.h"
#include "IndexBuffer.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

IndexBuffer^ IndexBuffer::Wrap(scene::IIndexBuffer* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew IndexBuffer(ref);
}

IndexBuffer::IndexBuffer(scene::IIndexBuffer* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_IndexBuffer = ref;
}

IndexBuffer^ IndexBuffer::Create(Video::IndexType type)
{
	scene::IIndexBuffer* i = new scene::CIndexBuffer((video::E_INDEX_TYPE)type);
	return gcnew IndexBuffer(i);
}

void IndexBuffer::Add(int index)
{
	LIME_ASSERT(index >= 0);
	LIME_ASSERT((Type == Video::IndexType::_16Bit && index <= 0xffff) || Type == Video::IndexType::_32Bit)

	m_IndexBuffer->push_back(index);
}

int IndexBuffer::Get(int i)
{
	LIME_ASSERT(i >= 0 && i < Count);
	return (*m_IndexBuffer)[i];
}

void IndexBuffer::Set(int i, int index)
{
	LIME_ASSERT(i >= 0 && i < Count);
	LIME_ASSERT(index >= 0);
	LIME_ASSERT((Type == Video::IndexType::_16Bit && index <= 0xffff) || Type == Video::IndexType::_32Bit)

	m_IndexBuffer->setValue(i, index);
}

void IndexBuffer::Clear()
{
	m_IndexBuffer->reallocate(0);
}

void IndexBuffer::Reallocate(int newAllocatedCount)
{
	LIME_ASSERT(newAllocatedCount >= 0);
	m_IndexBuffer->reallocate(newAllocatedCount);
}

void IndexBuffer::SetCount(int newCount)
{
	LIME_ASSERT(newCount >= 0);
	m_IndexBuffer->set_used(newCount);
}

void IndexBuffer::SetDirty()
{
	m_IndexBuffer->setDirty();
}

int IndexBuffer::AllocatedCount::get()
{
	return m_IndexBuffer->allocated_size();
}

int IndexBuffer::Count::get()
{
	return m_IndexBuffer->size();
}

Scene::HardwareMappingHint IndexBuffer::HardwareMappingHint::get()
{
	return (Scene::HardwareMappingHint)m_IndexBuffer->getHardwareMappingHint();
}

void IndexBuffer::HardwareMappingHint::set(Scene::HardwareMappingHint value)
{
	m_IndexBuffer->setHardwareMappingHint((scene::E_HARDWARE_MAPPING)value);
}

array<int>^ IndexBuffer::Indices::get()
{
	int c = m_IndexBuffer->size();
	array<int>^ a = gcnew array<int>(c);

	for (int i = 0; i < c; i++)
		a[i] = (*m_IndexBuffer)[i];

	return a;
}

Video::IndexType IndexBuffer::Type::get()
{
	return (Video::IndexType)m_IndexBuffer->getType();
}

String^ IndexBuffer::ToString()
{
	return String::Format("IndexBuffer: {0} {1} indices", Count, Type);
}

} // end namespace Scene
} // end namespace IrrlichtLime