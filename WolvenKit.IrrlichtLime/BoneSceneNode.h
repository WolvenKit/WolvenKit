#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class BoneSceneNode : SceneNode
{
public:

	void UpdateAbsolutePositionOfAllChildren();

	property BoneAnimationMode AnimationMode { BoneAnimationMode get(); void set(BoneAnimationMode value); }
	property int BoneIndex { int get(); }
	property BoneSkinningSpace SkinningSpace { BoneSkinningSpace get(); void set(BoneSkinningSpace value); }

	property int PositionHint { int get(); void set(int value); }
	property int RotationHint { int get(); void set(int value); }
	property int ScaleHint { int get(); void set(int value); }

internal:

	static BoneSceneNode^ Wrap(scene::IBoneSceneNode* ref);
	BoneSceneNode(scene::IBoneSceneNode* ref);

	scene::IBoneSceneNode* m_BoneSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime