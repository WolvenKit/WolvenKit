#include "stdafx.h"
#include "SRotationKey.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

SRotationKey^ SRotationKey::Wrap(scene::ISkinnedMesh::SRotationKey* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SRotationKey(ref);
}

SRotationKey::SRotationKey(scene::ISkinnedMesh::SRotationKey* ref)
{
	LIME_ASSERT(ref != nullptr);
	m_RotationKey = ref;
}

float SRotationKey::Frame::get()
{
	return m_RotationKey->frame;
}

void SRotationKey::Frame::set(float frame)
{
	m_RotationKey->frame = frame;
}

Quaternion^ SRotationKey::Rotation::get()
{
	return gcnew Quaternion(m_RotationKey->rotation);
}

void SRotationKey::Rotation::set(Quaternion^ position)
{
	m_RotationKey->rotation.X = position->X;
	m_RotationKey->rotation.Y = position->Y;
	m_RotationKey->rotation.Z = position->Z;
	m_RotationKey->rotation.W = position->W;
}

} // end namespace Scene
} // end namespace IrrlichtLime
