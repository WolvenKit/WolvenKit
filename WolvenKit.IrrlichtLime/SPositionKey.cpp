#include "stdafx.h"
#include "SPositionKey.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

SPositionKey^ SPositionKey::Wrap(scene::ISkinnedMesh::SPositionKey* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SPositionKey(ref);
}

SPositionKey::SPositionKey(scene::ISkinnedMesh::SPositionKey* ref)
{
	LIME_ASSERT(ref != nullptr);
	m_PositionKey = ref;
}

float SPositionKey::Frame::get()
{
	return m_PositionKey->frame;
}

void SPositionKey::Frame::set(float frame)
{
	m_PositionKey->frame = frame;
}

Vector3Df^ SPositionKey::Position::get()
{
	return gcnew Vector3Df(m_PositionKey->position);
}

void SPositionKey::Position::set(Vector3Df^ position)
{
	m_PositionKey->position.X = position->X;
	m_PositionKey->position.Y = position->Y;
	m_PositionKey->position.Z = position->Z;
}

} // end namespace Scene
} // end namespace IrrlichtLime
