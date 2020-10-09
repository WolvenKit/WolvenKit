#include "stdafx.h"
#include "SScaleKey.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

SScaleKey^ SScaleKey::Wrap(scene::ISkinnedMesh::SScaleKey* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SScaleKey(ref);
}

SScaleKey::SScaleKey(scene::ISkinnedMesh::SScaleKey* ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ScaleKey = ref;
}

float SScaleKey::Frame::get()
{
	return m_ScaleKey->frame;
}

void SScaleKey::Frame::set(float frame)
{
	m_ScaleKey->frame = frame;
}

Vector3Df^ SScaleKey::Scale::get()
{
	return gcnew Vector3Df(m_ScaleKey->scale);
}

void SScaleKey::Scale::set(Vector3Df^ scale)
{
	m_ScaleKey->scale.X = scale->X;
	m_ScaleKey->scale.Y = scale->Y;
	m_ScaleKey->scale.Z = scale->Z;
}

} // end namespace Scene
} // end namespace IrrlichtLime
