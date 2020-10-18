#pragma once

#include "stdafx.h"
#include "TerrainSceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace IO { ref class ReadFile; }
namespace Scene {

public ref class TerrainSceneNodeWolvenKit : TerrainSceneNode
{
public:

	bool LoadHeightMap(IO::ReadFile^ file, int dimension, 
		float maxHeight, float minHeight, float tileSize, Vector3Df^ anchor);

internal:

	static TerrainSceneNodeWolvenKit^ Wrap(scene::ITerrainSceneNode* ref);
	TerrainSceneNodeWolvenKit(scene::ITerrainSceneNode* ref);
};

} // end namespace Scene
} // end namespace IrrlichtLime