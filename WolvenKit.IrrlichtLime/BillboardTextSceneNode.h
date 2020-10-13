#pragma once

#include "stdafx.h"
#include "BillboardSceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public ref class BillboardTextSceneNode : BillboardSceneNode
{
public:

	void SetText(String^ text);
	void SetTextColor(Video::Color^ color);

internal:

	static BillboardTextSceneNode^ Wrap(scene::IBillboardTextSceneNode* ref);
	BillboardTextSceneNode(scene::IBillboardTextSceneNode* ref);

	scene::IBillboardTextSceneNode* m_BillboardTextSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime