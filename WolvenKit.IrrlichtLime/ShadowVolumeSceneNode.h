#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

ref class Mesh;

public ref class ShadowVolumeSceneNode : SceneNode
{
public:

	void SetShadowMesh(Mesh^ mesh);
	void UpdateShadowVolumes();

internal:

	static ShadowVolumeSceneNode^ Wrap(scene::IShadowVolumeSceneNode* ref);
	ShadowVolumeSceneNode(scene::IShadowVolumeSceneNode* ref);

	scene::IShadowVolumeSceneNode* m_ShadowVolumeSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime