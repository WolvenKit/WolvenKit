#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video { ref class Light; }
namespace Scene {

public ref class LightSceneNode : SceneNode
{
public:

	property bool CastShadows { bool get(); void set(bool value); }
	property Video::Light^ LightData { Video::Light^ get(); void set(Video::Light^ value); }
	property Video::LightType LightType { Video::LightType get(); void set(Video::LightType value); }
	property float Radius { float get(); void set(float value); }
	property bool Visible { virtual void set(bool value) override; }

internal:

	static LightSceneNode^ Wrap(scene::ILightSceneNode* ref);
	LightSceneNode(scene::ILightSceneNode* ref);

	scene::ILightSceneNode* m_LightSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime