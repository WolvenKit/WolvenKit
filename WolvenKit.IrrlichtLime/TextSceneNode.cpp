#include "stdafx.h"
#include "SceneNode.h"
#include "TextSceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

TextSceneNode^ TextSceneNode::Wrap(scene::ITextSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew TextSceneNode(ref);
}

TextSceneNode::TextSceneNode(scene::ITextSceneNode* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_TextSceneNode = ref;
}

void TextSceneNode::SetText(String^ text)
{
	m_TextSceneNode->setText(LIME_SAFESTRINGTOSTRINGW_C_STR(text));
}

void TextSceneNode::SetTextColor(Video::Color^ color)
{
	LIME_ASSERT(color != nullptr);
	m_TextSceneNode->setTextColor(*color->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime