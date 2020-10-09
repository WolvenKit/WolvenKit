#include "stdafx.h"
#include "BillboardSceneNode.h"
#include "BillboardTextSceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

BillboardTextSceneNode^ BillboardTextSceneNode::Wrap(scene::IBillboardTextSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew BillboardTextSceneNode(ref);
}

BillboardTextSceneNode::BillboardTextSceneNode(scene::IBillboardTextSceneNode* ref)
	: BillboardSceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_BillboardTextSceneNode = ref;
}

void BillboardTextSceneNode::SetText(String^ text)
{
	m_BillboardTextSceneNode->setText(LIME_SAFESTRINGTOSTRINGW_C_STR(text));
}

void BillboardTextSceneNode::SetTextColor(Video::Color^ color)
{
	LIME_ASSERT(color != nullptr);
	m_BillboardTextSceneNode->setTextColor(*color->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime