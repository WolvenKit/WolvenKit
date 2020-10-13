#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public ref class VolumeLightSceneNode : SceneNode
{
public:

	property Video::Color^ FootColor { Video::Color^ get(); void set(Video::Color^ value);  }
	property int SubDivideU { int get(); void set(int value); }
	property int SubDivideV { int get(); void set(int value); }
	property Video::Color^ TailColor { Video::Color^ get(); void set(Video::Color^ value);  }

internal:

	static VolumeLightSceneNode^ Wrap(scene::IVolumeLightSceneNode* ref);
	VolumeLightSceneNode(scene::IVolumeLightSceneNode* ref);

	scene::IVolumeLightSceneNode* m_VolumeLightSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime