#include "stdafx.h"
#include "DynamicMeshBuffer.h"
#include "Mesh.h"
#include "MeshBuffer.h"
#include "ReadFile.h"
#include "SceneNode.h"
#include "TerrainSceneNodeWolvenKit.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

TerrainSceneNodeWolvenKit^ TerrainSceneNodeWolvenKit::Wrap(scene::ITerrainSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew TerrainSceneNodeWolvenKit(ref);
}

TerrainSceneNodeWolvenKit::TerrainSceneNodeWolvenKit(scene::ITerrainSceneNode* ref)
	: TerrainSceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_TerrainSceneNode = ref;
}

bool TerrainSceneNodeWolvenKit::LoadHeightMap(IO::ReadFile^ file, int dimension,
    float maxHeight, float minHeight, float tileSize, Vector3Df^ anchor)
{
	LIME_ASSERT(anchor != nullptr);

	return m_TerrainSceneNode->loadHeightMap(
		LIME_SAFEREF(file, m_ReadFile),
		dimension, maxHeight, minHeight, tileSize,
		*anchor->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime