#include "stdafx.h"
#include "Mesh.h"
#include "ShadowVolumeSceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

ShadowVolumeSceneNode^ ShadowVolumeSceneNode::Wrap(scene::IShadowVolumeSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ShadowVolumeSceneNode(ref);
}

ShadowVolumeSceneNode::ShadowVolumeSceneNode(scene::IShadowVolumeSceneNode* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_ShadowVolumeSceneNode = ref;
}

void ShadowVolumeSceneNode::SetShadowMesh(Mesh^ mesh)
{
	m_ShadowVolumeSceneNode->setShadowMesh(LIME_SAFEREF(mesh, m_Mesh));
}

void ShadowVolumeSceneNode::UpdateShadowVolumes()
{
	m_ShadowVolumeSceneNode->updateShadowVolumes();
}

} // end namespace Scene
} // end namespace IrrlichtLime