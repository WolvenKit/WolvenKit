#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public ref class BillboardSceneNode : SceneNode
{
public:

	void GetSize([Out] float% height, [Out] float% bottomWidth, [Out] float% topWidth);
	void SetSize(float height, float bottomWidth, float topWidth);

	property Video::Color^ BottomColor { Video::Color^ get(); void set(Video::Color^ value); }
	property float BottomWidth { float get(); void set(float value); }
	property float Height { float get(); void set(float value); }
	property Video::Color^ TopColor { Video::Color^ get(); void set(Video::Color^ value); }
	property float TopWidth { float get(); void set(float value); }

internal:

	static BillboardSceneNode^ Wrap(scene::IBillboardSceneNode* ref);
	BillboardSceneNode(scene::IBillboardSceneNode* ref);

	scene::IBillboardSceneNode* m_BillboardSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime