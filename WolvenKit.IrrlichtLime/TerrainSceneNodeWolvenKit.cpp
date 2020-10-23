#include "stdafx.h"
#include "Mesh.h"
#include "ReadFile.h"
#include "SceneNode.h"
#include "TerrainSceneNodeWolvenKit.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

TerrainSceneNodeWolvenKit^ TerrainSceneNodeWolvenKit::Wrap(scene::ITerrainSceneNodeWolvenKit* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew TerrainSceneNodeWolvenKit(ref);
}

TerrainSceneNodeWolvenKit::TerrainSceneNodeWolvenKit(scene::ITerrainSceneNodeWolvenKit* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_TerrainSceneNode = ref;
}

bool TerrainSceneNodeWolvenKit::LoadHeightMap(IO::ReadFile^ file, int dimension,
    float maxHeight, float minHeight, float tileSize)
{
	return m_TerrainSceneNode->loadHeightMap(
		LIME_SAFEREF(file, m_ReadFile),
		dimension, maxHeight, minHeight, tileSize);
}

Scene::Mesh^ TerrainSceneNodeWolvenKit::Mesh::get()
{
    scene::IMesh* m = m_TerrainSceneNode->getMesh();
    return Scene::Mesh::Wrap(m);
}

} // end namespace Scene
} // end namespace IrrlichtLime