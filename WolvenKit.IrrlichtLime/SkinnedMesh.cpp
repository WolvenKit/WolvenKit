#include "stdafx.h"
#include "MeshBuffer.h"
#include "AnimatedMesh.h"
#include "SkinnedMesh.h"
#include "SJoint.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

SkinnedMesh^ SkinnedMesh::Wrap(scene::ISkinnedMesh* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SkinnedMesh(ref);
}

SkinnedMesh::SkinnedMesh(scene::ISkinnedMesh* ref) : AnimatedMesh(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_SkinnedMesh = ref;
	
}

void SkinnedMesh::AnimateMesh(float frame, float blend)
{
	m_SkinnedMesh->animateMesh(frame, blend);
}

void SkinnedMesh::ConvertMeshToTangents()
{
	m_SkinnedMesh->convertMeshToTangents();
}

void SkinnedMesh::FinalizeMeshPopulation()
{
	m_SkinnedMesh->finalize();
}


void SkinnedMesh::AddMeshBuffer(MeshBuffer^ meshBuffer)
{
	LIME_ASSERT(meshBuffer != nullptr);

	SSkinMeshBuffer* buffer = m_SkinnedMesh->addMeshBuffer();
	buffer->Vertices_Standard.reallocate(meshBuffer->VertexCount);
	
	for (int i = 0; i < meshBuffer->VertexCount; i++)
	{
		buffer->Vertices_Standard.push_back(video::S3DVertex());
		Video::Vertex3D^ v = reinterpret_cast<Video::Vertex3D^>(meshBuffer->GetVertex(i)); //vl

		buffer->Vertices_Standard[i].Pos = core::vector3df(v->Position->X, v->Position->Y, v->Position->Z);
		buffer->Vertices_Standard[i].Color = video::SColor(v->Color->Alpha, v->Color->Red, v->Color->Green, v->Color->Blue);
		buffer->Vertices_Standard[i].TCoords = core::vector2df(v->TCoords->X, v->TCoords->Y);
	}
	buffer->Indices.set_used(meshBuffer->IndexCount);

	for (int i = 0; i < meshBuffer->IndexCount; i++)
	{
		buffer->Indices[i] = ((array<unsigned short>^)meshBuffer->Indices)[i];
	}
	
}

SJoint^ SkinnedMesh::AddJoint()
{
	SJoint^ newJoint = gcnew SJoint(m_SkinnedMesh->addJoint());
	return newJoint;
}

List<SJoint^>^ SkinnedMesh::GetAllJoints()
{
	core::array<irr::scene::ISkinnedMesh::SJoint*> ret = m_SkinnedMesh->getAllJoints();
	List<SJoint^>^ Joints = gcnew List<SJoint^>;
	for (u32 i = 0; i < ret.size(); ++i)
	{
		Joints->Add(gcnew SJoint(ret[i]));
	}
	return Joints;
}

String^ SkinnedMesh::GetJointName(int index)
{
	LIME_ASSERT(index >= 0 && index < JointCount);
	return gcnew String(m_SkinnedMesh->getJointName(index));
}

int SkinnedMesh::GetJointIndex(String^ name)
{
	LIME_ASSERT(name != nullptr);
	return m_SkinnedMesh->getJointNumber(LIME_SAFESTRINGTOSTRINGC_C_STR(name));
}

SRotationKey^ SkinnedMesh::AddRotationKey(SJoint^ joint)
{
	return gcnew SRotationKey(m_SkinnedMesh->addRotationKey(joint->m_Joint));
}

SPositionKey^ SkinnedMesh::AddPositionKey(SJoint^ joint)
{
	return gcnew SPositionKey(m_SkinnedMesh->addPositionKey(joint->m_Joint));
}

SScaleKey^ SkinnedMesh::AddScaleKey(SJoint^ joint)
{
	return gcnew SScaleKey(m_SkinnedMesh->addScaleKey(joint->m_Joint));
}

SWeight^ SkinnedMesh::AddWeight(SJoint^ joint)
{
	return gcnew SWeight(m_SkinnedMesh->addWeight(joint->m_Joint));
}

bool SkinnedMesh::SetHardwareSkinning(bool turnOn)
{
	return m_SkinnedMesh->setHardwareSkinning(turnOn);
}

void SkinnedMesh::SetInterpolationMode(InterpolationMode mode)
{
	m_SkinnedMesh->setInterpolationMode((scene::E_INTERPOLATION_MODE)mode);
}

void SkinnedMesh::SkinMesh()
{
	m_SkinnedMesh->skinMesh();
}

void SkinnedMesh::UpdateNormalsWhenAnimating(bool turnOn)
{
	m_SkinnedMesh->updateNormalsWhenAnimating(turnOn);
}

bool SkinnedMesh::UseAnimationFrom(SkinnedMesh^ mesh)
{
	LIME_ASSERT(mesh != nullptr);
	return m_SkinnedMesh->useAnimationFrom(LIME_SAFEREF(mesh, m_SkinnedMesh));
}

int SkinnedMesh::JointCount::get()
{
	return m_SkinnedMesh->getJointCount();
}

bool SkinnedMesh::Static::get()
{
	return m_SkinnedMesh->isStatic();
}

} // end namespace Scene
} // end namespace IrrlichtLime