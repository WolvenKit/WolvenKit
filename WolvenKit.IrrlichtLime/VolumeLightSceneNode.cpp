#include "stdafx.h"
#include "VolumeLightSceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

VolumeLightSceneNode^ VolumeLightSceneNode::Wrap(scene::IVolumeLightSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew VolumeLightSceneNode(ref);
}

VolumeLightSceneNode::VolumeLightSceneNode(scene::IVolumeLightSceneNode* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_VolumeLightSceneNode = ref;
}

Video::Color^ VolumeLightSceneNode::FootColor::get()
{
	return gcnew Video::Color(m_VolumeLightSceneNode->getFootColor());
}

void VolumeLightSceneNode::FootColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_VolumeLightSceneNode->setFootColor(*value->m_NativeValue);
}

int VolumeLightSceneNode::SubDivideU::get()
{
	return m_VolumeLightSceneNode->getSubDivideU();
}

void VolumeLightSceneNode::SubDivideU::set(int value)
{
	LIME_ASSERT(value >= 0);
	m_VolumeLightSceneNode->setSubDivideU(value);
}

int VolumeLightSceneNode::SubDivideV::get()
{
	return m_VolumeLightSceneNode->getSubDivideV();
}

void VolumeLightSceneNode::SubDivideV::set(int value)
{
	LIME_ASSERT(value >= 0);
	m_VolumeLightSceneNode->setSubDivideV(value);
}

Video::Color^ VolumeLightSceneNode::TailColor::get()
{
	return gcnew Video::Color(m_VolumeLightSceneNode->getTailColor());
}

void VolumeLightSceneNode::TailColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_VolumeLightSceneNode->setTailColor(*value->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime