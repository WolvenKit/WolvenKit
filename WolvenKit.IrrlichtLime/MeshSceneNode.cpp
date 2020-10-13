#include "stdafx.h"
#include "Mesh.h"
#include "MeshSceneNode.h"
#include "ShadowVolumeSceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

MeshSceneNode^ MeshSceneNode::Wrap(scene::IMeshSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew MeshSceneNode(ref);
}

MeshSceneNode::MeshSceneNode(scene::IMeshSceneNode* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_MeshSceneNode = ref;
}

ShadowVolumeSceneNode^ MeshSceneNode::AddShadowVolumeSceneNode(Scene::Mesh^ shadowMesh, int id, bool zfailmethod, float infinity)
{
	scene::IShadowVolumeSceneNode* n = m_MeshSceneNode->addShadowVolumeSceneNode(
		LIME_SAFEREF(shadowMesh, m_Mesh),
		id,
		zfailmethod,
		infinity);

	return ShadowVolumeSceneNode::Wrap(n);
}

ShadowVolumeSceneNode^ MeshSceneNode::AddShadowVolumeSceneNode(Scene::Mesh^ shadowMesh, int id, bool zfailmethod)
{
	scene::IShadowVolumeSceneNode* n = m_MeshSceneNode->addShadowVolumeSceneNode(
		LIME_SAFEREF(shadowMesh, m_Mesh),
		id,
		zfailmethod);

	return ShadowVolumeSceneNode::Wrap(n);
}

ShadowVolumeSceneNode^ MeshSceneNode::AddShadowVolumeSceneNode(Scene::Mesh^ shadowMesh, int id)
{
	scene::IShadowVolumeSceneNode* n = m_MeshSceneNode->addShadowVolumeSceneNode(
		LIME_SAFEREF(shadowMesh, m_Mesh),
		id);

	return ShadowVolumeSceneNode::Wrap(n);
}

ShadowVolumeSceneNode^ MeshSceneNode::AddShadowVolumeSceneNode(Scene::Mesh^ shadowMesh)
{
	scene::IShadowVolumeSceneNode* n = m_MeshSceneNode->addShadowVolumeSceneNode(
		LIME_SAFEREF(shadowMesh, m_Mesh));

	return ShadowVolumeSceneNode::Wrap(n);
}

ShadowVolumeSceneNode^ MeshSceneNode::AddShadowVolumeSceneNode()
{
	scene::IShadowVolumeSceneNode* n = m_MeshSceneNode->addShadowVolumeSceneNode();
	return ShadowVolumeSceneNode::Wrap(n);
}

Scene::Mesh^ MeshSceneNode::Mesh::get()
{
	return Scene::Mesh::Wrap(m_MeshSceneNode->getMesh());
}

void MeshSceneNode::Mesh::set(Scene::Mesh^ value)
{
	m_MeshSceneNode->setMesh(LIME_SAFEREF(value, m_Mesh));
}

bool MeshSceneNode::ReadOnlyMeterials::get()
{
	return m_MeshSceneNode->isReadOnlyMaterials();
}

void MeshSceneNode::ReadOnlyMeterials::set(bool value)
{
	m_MeshSceneNode->setReadOnlyMaterials(value);
}

} // end namespace Scene
} // end namespace IrrlichtLime