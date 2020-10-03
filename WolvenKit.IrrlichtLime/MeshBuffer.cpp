#include "stdafx.h"
#include "Material.h"
#include "MeshBuffer.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

MeshBuffer^ MeshBuffer::Wrap(scene::IMeshBuffer* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew MeshBuffer(ref);
}

MeshBuffer::MeshBuffer(scene::IMeshBuffer* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_MeshBuffer = ref;
}

MeshBuffer^ MeshBuffer::Create(Video::VertexType vertexType, Video::IndexType indexType)
{
	switch (indexType)
	{
	case Video::IndexType::_16Bit:
		switch (vertexType)
		{
		case Video::VertexType::Standard:
			return gcnew MeshBuffer(new CMeshBuffer<video::S3DVertex>);

		case Video::VertexType::TTCoords:
			return gcnew MeshBuffer(new CMeshBuffer<video::S3DVertex2TCoords>);

		case Video::VertexType::Tangents:
			return gcnew MeshBuffer(new CMeshBuffer<video::S3DVertexTangents>);
		}

		LIME_ASSERT2(false, "Unexpected vertexType: " + vertexType.ToString());
		return nullptr;

	case Video::IndexType::_32Bit:
		return gcnew MeshBuffer(new CDynamicMeshBuffer((video::E_VERTEX_TYPE)vertexType, (video::E_INDEX_TYPE)indexType));
	}

	LIME_ASSERT2(false, "Unexpected combination of vertexType,indexType: " + vertexType.ToString() + "," + indexType.ToString());
	return nullptr;
}

void MeshBuffer::Append(MeshBuffer^ other)
{
	m_MeshBuffer->append(LIME_SAFEREF(other, m_MeshBuffer));
}

void MeshBuffer::Append(array<Video::Vertex3D^>^ verticesStandard, array<unsigned short>^ indices16bit)
{
	LIME_ASSERT(this->VertexType == Video::VertexType::Standard);
	LIME_ASSERT(this->IndexType == Video::IndexType::_16Bit);
	LIME_ASSERT(verticesStandard != nullptr);
	LIME_ASSERT(indices16bit != nullptr);

	int vc = verticesStandard->Length;
	video::S3DVertex* va = new video::S3DVertex[vc];
	for (int i = 0; i < vc; i++)
		va[i] = *verticesStandard[i]->m_NativeValue;

	unsigned short* ia = new unsigned short[indices16bit->Length];
	Marshal::Copy((array<short>^)indices16bit, 0, IntPtr(ia), indices16bit->Length);

	m_MeshBuffer->append(va, vc, ia, indices16bit->Length);

	delete[] ia;
	delete[] va;
}

void MeshBuffer::Append(array<Video::Vertex3DTTCoords^>^ verticesTTCoords, array<unsigned short>^ indices16bit)
{
	LIME_ASSERT(this->VertexType == Video::VertexType::TTCoords);
	LIME_ASSERT(this->IndexType == Video::IndexType::_16Bit);
	LIME_ASSERT(verticesTTCoords != nullptr);
	LIME_ASSERT(indices16bit != nullptr);

	int vc = verticesTTCoords->Length;
	video::S3DVertex* va = new video::S3DVertex2TCoords[vc];
	for (int i = 0; i < vc; i++)
		va[i] = *verticesTTCoords[i]->m_NativeValue;

	unsigned short* ia = new unsigned short[indices16bit->Length];
	Marshal::Copy((array<short>^)indices16bit, 0, IntPtr(ia), indices16bit->Length);

	m_MeshBuffer->append(va, vc, ia, indices16bit->Length);

	delete[] ia;
	delete[] va;
}

void MeshBuffer::Append(array<Video::Vertex3DTangents^>^ verticesTangents, array<unsigned short>^ indices16bit)
{
	LIME_ASSERT(this->VertexType == Video::VertexType::Tangents);
	LIME_ASSERT(this->IndexType == Video::IndexType::_16Bit);
	LIME_ASSERT(verticesTangents != nullptr);
	LIME_ASSERT(indices16bit != nullptr);

	int vc = verticesTangents->Length;
	video::S3DVertex* va = new video::S3DVertexTangents[vc];
	for (int i = 0; i < vc; i++)
		va[i] = *verticesTangents[i]->m_NativeValue;

	unsigned short* ia = new unsigned short[indices16bit->Length];
	Marshal::Copy((array<short>^)indices16bit, 0, IntPtr(ia), indices16bit->Length);

	m_MeshBuffer->append(va, vc, ia, indices16bit->Length);

	delete[] ia;
	delete[] va;
}

void MeshBuffer::Append(array<Video::Vertex3D^>^ verticesStandard, array<unsigned int>^ indices32bit)
{
	LIME_ASSERT(this->VertexType == Video::VertexType::Standard);
	LIME_ASSERT(this->IndexType == Video::IndexType::_32Bit);
	LIME_ASSERT(verticesStandard != nullptr);
	LIME_ASSERT(indices32bit != nullptr);

	// as i know:
	// 1) 32bit meshbuffers is only possible with IDynamicMeshBuffer, so i will cast to it
	// 2) append() doesn't have ability to be used with 32 bit indices, so we are going to implement it here manually

	scene::IDynamicMeshBuffer* mb = (scene::IDynamicMeshBuffer*)m_MeshBuffer;
	scene::IIndexBuffer& ib = mb->getIndexBuffer();
	scene::IVertexBuffer& vb = mb->getVertexBuffer();

	unsigned int ibSize = ib.size();
	unsigned int vbSize = vb.size();

	ib.set_used(ibSize + indices32bit->Length);
	for (int i = 0; i < indices32bit->Length; i++)
		ib.setValue(i + ibSize, indices32bit[i] + vbSize); // simple "ib[i + ibSize] = ...;" leads to error C2106: '=' : left operand must be l-value

	vb.set_used(vbSize + verticesStandard->Length);
	for (int i = 0; i < verticesStandard->Length; i++)
		vb[i + vbSize] = *verticesStandard[i]->m_NativeValue;
}

void MeshBuffer::Append(array<Video::Vertex3DTTCoords^>^ verticesTTCoords, array<unsigned int>^ indices32bit)
{
	LIME_ASSERT(this->VertexType == Video::VertexType::TTCoords);
	LIME_ASSERT(this->IndexType == Video::IndexType::_32Bit);
	LIME_ASSERT(verticesTTCoords != nullptr);
	LIME_ASSERT(indices32bit != nullptr);

	scene::IDynamicMeshBuffer* mb = (scene::IDynamicMeshBuffer*)m_MeshBuffer;
	scene::IIndexBuffer& ib = mb->getIndexBuffer();
	scene::IVertexBuffer& vb = mb->getVertexBuffer();

	unsigned int ibSize = ib.size();
	unsigned int vbSize = vb.size();

	ib.set_used(ibSize + indices32bit->Length);
	for (int i = 0; i < indices32bit->Length; i++)
		ib.setValue(i + ibSize, indices32bit[i] + vbSize);

	vb.set_used(vbSize + verticesTTCoords->Length);
	for (int i = 0; i < verticesTTCoords->Length; i++)
		vb[i + vbSize] = *verticesTTCoords[i]->m_NativeValue;
}

void MeshBuffer::Append(array<Video::Vertex3DTangents^>^ verticesTangents, array<unsigned int>^ indices32bit)
{
	LIME_ASSERT(this->VertexType == Video::VertexType::Tangents);
	LIME_ASSERT(this->IndexType == Video::IndexType::_32Bit);
	LIME_ASSERT(verticesTangents != nullptr);
	LIME_ASSERT(indices32bit != nullptr);

	scene::IDynamicMeshBuffer* mb = (scene::IDynamicMeshBuffer*)m_MeshBuffer;
	scene::IIndexBuffer& ib = mb->getIndexBuffer();
	scene::IVertexBuffer& vb = mb->getVertexBuffer();

	unsigned int ibSize = ib.size();
	unsigned int vbSize = vb.size();

	ib.set_used(ibSize + indices32bit->Length);
	for (int i = 0; i < indices32bit->Length; i++)
		ib.setValue(i + ibSize, indices32bit[i] + vbSize);

	vb.set_used(vbSize + verticesTangents->Length);
	for (int i = 0; i < verticesTangents->Length; i++)
		vb[i + vbSize] = *verticesTangents[i]->m_NativeValue;
}

Vector3Df^ MeshBuffer::GetNormal(int vertexIndex)
{
	LIME_ASSERT(vertexIndex >= 0 && vertexIndex < VertexCount);
	return gcnew Vector3Df(m_MeshBuffer->getNormal(vertexIndex));
}

Vector3Df^ MeshBuffer::GetPosition(int vertexIndex)
{
	LIME_ASSERT(vertexIndex >= 0 && vertexIndex < VertexCount);
	return gcnew Vector3Df(m_MeshBuffer->getPosition(vertexIndex));
}

Vector2Df^ MeshBuffer::GetTCoords(int vertexIndex)
{
	LIME_ASSERT(vertexIndex >= 0 && vertexIndex < VertexCount);
	return gcnew Vector2Df(m_MeshBuffer->getTCoords(vertexIndex));
}

Object^ MeshBuffer::GetVertex(int vertexIndex)
{
	LIME_ASSERT(vertexIndex >= 0 && vertexIndex < VertexCount);

	void* va = m_MeshBuffer->getVertices();

	switch (m_MeshBuffer->getVertexType())
	{
	case video::EVT_STANDARD:
		return gcnew Video::Vertex3D(((video::S3DVertex*)va)[vertexIndex]);

	case video::EVT_2TCOORDS:
		return gcnew Video::Vertex3DTTCoords(((video::S3DVertex2TCoords*)va)[vertexIndex]);

	case video::EVT_TANGENTS:
		return gcnew Video::Vertex3DTangents(((video::S3DVertexTangents*)va)[vertexIndex]);
	}

	LIME_ASSERT2(false, "Unexpected VertexType: " + this->VertexType.ToString());
	return nullptr;
}

void MeshBuffer::RecalculateBoundingBox()
{
	m_MeshBuffer->recalculateBoundingBox();
}

void MeshBuffer::SetDirty(HardwareBufferType buffer)
{
	m_MeshBuffer->setDirty((scene::E_BUFFER_TYPE)buffer);
}

void MeshBuffer::SetHardwareMappingHint(HardwareMappingHint mappingHint, HardwareBufferType buffer)
{
	m_MeshBuffer->setHardwareMappingHint((scene::E_HARDWARE_MAPPING)mappingHint, (scene::E_BUFFER_TYPE)buffer);
}

void MeshBuffer::SetMaterial(Video::Material^ newMaterialToCopyFrom)
{
	LIME_ASSERT(newMaterialToCopyFrom != nullptr);
	m_MeshBuffer->getMaterial() = *newMaterialToCopyFrom->m_NativeValue;
}

void MeshBuffer::UpdateIndices(array<unsigned short>^ indices16bit, int startIndex)
{
	LIME_ASSERT(this->IndexType == Video::IndexType::_16Bit);
	LIME_ASSERT(indices16bit != nullptr);
	LIME_ASSERT(startIndex + indices16bit->Length <= this->IndexCount);

	unsigned short* p = m_MeshBuffer->getIndices();
	Marshal::Copy((array<short>^)indices16bit, 0, IntPtr(p + startIndex), indices16bit->Length);
}

void MeshBuffer::UpdateIndices(array<unsigned int>^ indices32bit, int startIndex)
{
	LIME_ASSERT(this->IndexType == Video::IndexType::_32Bit);
	LIME_ASSERT(indices32bit != nullptr);
	LIME_ASSERT(startIndex + indices32bit->Length <= this->IndexCount);

	unsigned int* p = (unsigned int*)m_MeshBuffer->getIndices();
	Marshal::Copy((array<int>^)indices32bit, 0, IntPtr(p + startIndex), indices32bit->Length);
}

void MeshBuffer::UpdateVertices(array<Video::Vertex3D^>^ verticesStandard, int startIndex)
{
	LIME_ASSERT(this->VertexType == Video::VertexType::Standard);
	LIME_ASSERT(verticesStandard != nullptr);
	LIME_ASSERT(startIndex + verticesStandard->Length <= this->VertexCount);

	video::S3DVertex* p = (video::S3DVertex*)m_MeshBuffer->getVertices();

	for (int i = 0; i < verticesStandard->Length; i++)
		p[i + startIndex] = *verticesStandard[i]->m_NativeValue;
}

void MeshBuffer::UpdateVertices(array<Video::Vertex3DTTCoords^>^ verticesTTCoords, int startIndex)
{
	LIME_ASSERT(this->VertexType == Video::VertexType::TTCoords);
	LIME_ASSERT(verticesTTCoords != nullptr);
	LIME_ASSERT(startIndex + verticesTTCoords->Length <= this->VertexCount);

	video::S3DVertex2TCoords* p = (video::S3DVertex2TCoords*)m_MeshBuffer->getVertices();

	for (int i = 0; i < verticesTTCoords->Length; i++)
		p[i + startIndex] = *verticesTTCoords[i]->m_NativeValue;
}

void MeshBuffer::UpdateVertices(array<Video::Vertex3DTangents^>^ verticesTangents, int startIndex)
{
	LIME_ASSERT(this->VertexType == Video::VertexType::Tangents);
	LIME_ASSERT(verticesTangents != nullptr);
	LIME_ASSERT(startIndex + verticesTangents->Length <= this->VertexCount);

	video::S3DVertexTangents* p = (video::S3DVertexTangents*)m_MeshBuffer->getVertices();

	for (int i = 0; i < verticesTangents->Length; i++)
		p[i + startIndex] = *verticesTangents[i]->m_NativeValue;
}

AABBox^ MeshBuffer::BoundingBox::get()
{
	return gcnew AABBox(m_MeshBuffer->getBoundingBox());
}

void MeshBuffer::BoundingBox::set(AABBox^ value)
{
	LIME_ASSERT(value != nullptr);
	m_MeshBuffer->setBoundingBox(*value->m_NativeValue);
}

HardwareMappingHint MeshBuffer::HardwareMappingHintForIndex::get()
{
	return (HardwareMappingHint)m_MeshBuffer->getHardwareMappingHint_Index();
}

HardwareMappingHint MeshBuffer::HardwareMappingHintForVertex::get()
{
	return (HardwareMappingHint)m_MeshBuffer->getHardwareMappingHint_Vertex();
}

int MeshBuffer::IndexCount::get()
{
	return m_MeshBuffer->getIndexCount();
}

Video::IndexType MeshBuffer::IndexType::get()
{
	return (Video::IndexType)m_MeshBuffer->getIndexType();
}

Object^ MeshBuffer::Indices::get()
{
	int ic = m_MeshBuffer->getIndexCount();
	void* ia = m_MeshBuffer->getIndices();

	switch (m_MeshBuffer->getIndexType())
	{
	case video::EIT_16BIT:
		{
			array<unsigned short>^ a = gcnew array<unsigned short>(ic);
			for (int i = 0; i < ic; i++)
				a[i] = ((unsigned short*)ia)[i];

			return a;
		}

	case video::EIT_32BIT:
		{
			array<unsigned int>^ a = gcnew array<unsigned int>(ic);
			for (int i = 0; i < ic; i++)
				a[i] = ((unsigned int*)ia)[i];

			return a;
		}
	}

	LIME_ASSERT2(false, "Unexpected IndexType: " + this->IndexType.ToString());
	return nullptr;
}

Video::Material^ MeshBuffer::Material::get()
{
	return Video::Material::Wrap(&m_MeshBuffer->getMaterial());
}

int MeshBuffer::VertexCount::get()
{
	return m_MeshBuffer->getVertexCount();
}

Video::VertexType MeshBuffer::VertexType::get()
{
	return (Video::VertexType)m_MeshBuffer->getVertexType();
}

Object^ MeshBuffer::Vertices::get()
{
	int vc = m_MeshBuffer->getVertexCount();
	void* va = m_MeshBuffer->getVertices();

	switch (m_MeshBuffer->getVertexType())
	{
	case video::EVT_STANDARD:
		{
			array<Video::Vertex3D^>^ a = gcnew array<Video::Vertex3D^>(vc);
			for (int i = 0; i < vc; i++)
				a[i] = gcnew Video::Vertex3D(((video::S3DVertex*)va)[i]);

			return a;
		}

	case video::EVT_2TCOORDS:
		{
			array<Video::Vertex3DTTCoords^>^ a = gcnew array<Video::Vertex3DTTCoords^>(vc);
			for (int i = 0; i < vc; i++)
				a[i] = gcnew Video::Vertex3DTTCoords(((video::S3DVertex2TCoords*)va)[i]);

			return a;
		}

	case video::EVT_TANGENTS:
		{
			array<Video::Vertex3DTangents^>^ a = gcnew array<Video::Vertex3DTangents^>(vc);
			for (int i = 0; i < vc; i++)
				a[i] = gcnew Video::Vertex3DTangents(((video::S3DVertexTangents*)va)[i]);

			return a;
		}
	}

	LIME_ASSERT2(false, "Unexpected VertexType: " + this->VertexType.ToString());
	return nullptr;
}

String^ MeshBuffer::ToString()
{
	return String::Format("MeshBuffer: {0} {1} vertices and {2} {3} indices", VertexCount, VertexType, IndexCount, IndexType);
}

} // end namespace Scene
} // end namespace IrrlichtLime