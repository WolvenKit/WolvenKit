#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace IO { ref class ReadFile; }
namespace Scene {

ref class Mesh;

public ref class TerrainSceneNodeWolvenKit : SceneNode
{
public:

	bool LoadHeightMap(IO::ReadFile^ file, u32 dimension, 
		f32 maxHeight, f32 minHeight, f32 tileSize);

	property Scene::Mesh^ Mesh { Scene::Mesh^ get(); }

internal:

	static TerrainSceneNodeWolvenKit^ Wrap(scene::ITerrainSceneNodeWolvenKit* ref);
	TerrainSceneNodeWolvenKit(scene::ITerrainSceneNodeWolvenKit* ref);

	scene::ITerrainSceneNodeWolvenKit* m_TerrainSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime