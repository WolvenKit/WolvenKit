#include "stdafx.h"
#include "AnimatedMesh.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

AnimatedMesh^ AnimatedMesh::Wrap(scene::IAnimatedMesh* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew AnimatedMesh(ref);
}

AnimatedMesh::AnimatedMesh(scene::IAnimatedMesh* ref)
	: Mesh(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_AnimatedMesh = ref;
}

Mesh^ AnimatedMesh::GetMesh(int frame, int detailLevel, int startFrameLoop, int endFrameLoop)
{
	scene::IMesh* m = m_AnimatedMesh->getMesh(frame, detailLevel, startFrameLoop, endFrameLoop);
	return Mesh::Wrap(m);
}

Mesh^ AnimatedMesh::GetMesh(int frame, int detailLevel, int startFrameLoop)
{
	scene::IMesh* m = m_AnimatedMesh->getMesh(frame, detailLevel, startFrameLoop);
	return Mesh::Wrap(m);
}

Mesh^ AnimatedMesh::GetMesh(int frame, int detailLevel)
{
	scene::IMesh* m = m_AnimatedMesh->getMesh(frame, detailLevel);
	return Mesh::Wrap(m);
}

Mesh^ AnimatedMesh::GetMesh(int frame)
{
	scene::IMesh* m = m_AnimatedMesh->getMesh(frame);
	return Mesh::Wrap(m);
}

float AnimatedMesh::AnimationSpeed::get()
{
	return m_AnimatedMesh->getAnimationSpeed();
}

void AnimatedMesh::AnimationSpeed::set(float value)
{
	m_AnimatedMesh->setAnimationSpeed(value);
}

int AnimatedMesh::FrameCount::get()
{
	return m_AnimatedMesh->getFrameCount();
}

AnimatedMeshType AnimatedMesh::MeshType::get()
{
	return (AnimatedMeshType)m_AnimatedMesh->getMeshType();
}

} // end namespace Scene
} // end namespace IrrlichtLime