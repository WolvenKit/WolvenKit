#include "stdafx.h"
#include "SJoint.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

SJoint^ SJoint::Wrap(scene::ISkinnedMesh::SJoint* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SJoint(ref);
}

SJoint::SJoint(scene::ISkinnedMesh::SJoint* ref)
{
	LIME_ASSERT(ref != nullptr);
	m_Joint = ref;
}

String^ SJoint::Name::get()
{
	return gcnew String(m_Joint->Name.c_str());
}

void SJoint::Name::set(String^ name)
{
	m_Joint->Name = LIME_SAFESTRINGTOSTRINGC_C_STR(name);
}

List<SJoint^>^ SJoint::Children::get()
{
	core::array<scene::ISkinnedMesh::SJoint*> ret = m_Joint->Children;
	List<SJoint^>^ c = gcnew List<SJoint^>;
	for (u32 i = 0; i < ret.size(); ++i)
	{
		c->Add(gcnew SJoint(ret[i]));
	}

	return c;
}

void SJoint::AddChildren(SJoint^ children)
{
	scene::ISkinnedMesh::SJoint* buf = children->m_Joint;
	m_Joint->Children.insert(buf);
	//_Children->Add(children);
}

Matrix^ SJoint::LocalMatrix::get()
{
	return gcnew Matrix(m_Joint->LocalMatrix);
}

void SJoint::LocalMatrix::set(Matrix^ localmatrix)
{
	m_Joint->LocalMatrix = *localmatrix->m_NativeValue;
}

Matrix^ SJoint::GlobalMatrix::get()
{
	return gcnew Matrix(m_Joint->GlobalMatrix);
}

void SJoint::GlobalMatrix::set(Matrix^ globalmatrix)
{
	m_Joint->GlobalMatrix = *globalmatrix->m_NativeValue;
}

Vector3Df^ SJoint::Animatedposition::get()
{
	return gcnew Vector3Df(m_Joint->Animatedposition);
}

void SJoint::Animatedposition::set(Vector3Df^ animatedposition)
{
	m_Joint->Animatedposition.X = animatedposition->X;
	m_Joint->Animatedposition.Y = animatedposition->Y;
	m_Joint->Animatedposition.Z = animatedposition->Z;
}

Quaternion^ SJoint::Animatedrotation::get()
{
	return gcnew Quaternion(m_Joint->Animatedrotation);
}

void SJoint::Animatedrotation::set(Quaternion^ animatedrotation)
{
	m_Joint->Animatedrotation.X = animatedrotation->X;
	m_Joint->Animatedrotation.Y = animatedrotation->Y;
	m_Joint->Animatedrotation.Z = animatedrotation->Z;
	m_Joint->Animatedrotation.W = animatedrotation->W;
}

Vector3Df^ SJoint::Animatedscale::get()
{
	return gcnew Vector3Df(m_Joint->Animatedscale);
}

void SJoint::Animatedscale::set(Vector3Df^ animatedscale)
{
	m_Joint->Animatedscale.X = animatedscale->X;
	m_Joint->Animatedscale.Y = animatedscale->Y;
	m_Joint->Animatedscale.Z = animatedscale->Z;
}

} // end namespace Scene
} // end namespace IrrlichtLime