#include "stdafx.h"
#include "Light.h"
#include "LightSceneNode.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

LightSceneNode^ LightSceneNode::Wrap(scene::ILightSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew LightSceneNode(ref);
}

LightSceneNode::LightSceneNode(scene::ILightSceneNode* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_LightSceneNode = ref;
}

bool LightSceneNode::CastShadows::get()
{
	return m_LightSceneNode->getCastShadow();
}

void LightSceneNode::CastShadows::set(bool value)
{
	m_LightSceneNode->enableCastShadow(value);
}

Video::Light^ LightSceneNode::LightData::get()
{
	return gcnew Video::Light(&m_LightSceneNode->getLightData());
}

void LightSceneNode::LightData::set(Video::Light^ value)
{
	LIME_ASSERT(value != nullptr);
	m_LightSceneNode->setLightData(*value->m_NativeValue);
}

Video::LightType LightSceneNode::LightType::get()
{
	return (Video::LightType)m_LightSceneNode->getLightType();
}

void LightSceneNode::LightType::set(Video::LightType value)
{
	m_LightSceneNode->setLightType((video::E_LIGHT_TYPE)value);
}

float LightSceneNode::Radius::get()
{
	return m_LightSceneNode->getRadius();
}

void LightSceneNode::Radius::set(float value)
{
	m_LightSceneNode->setRadius(value);
}

void LightSceneNode::Visible::set(bool value)
{
	m_LightSceneNode->setVisible(value);
}

} // end namespace Scene
} // end namespace IrrlichtLime