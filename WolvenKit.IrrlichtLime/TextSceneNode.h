#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

public ref class TextSceneNode : SceneNode
{
public:

	void SetText(String^ text);
	void SetTextColor(Video::Color^ color);

internal:

	static TextSceneNode^ Wrap(scene::ITextSceneNode* ref);
	TextSceneNode(scene::ITextSceneNode* ref);

	scene::ITextSceneNode* m_TextSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime