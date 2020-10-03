#include "stdafx.h"
#include "BillboardSceneNode.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

BillboardSceneNode^ BillboardSceneNode::Wrap(scene::IBillboardSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew BillboardSceneNode(ref);
}

BillboardSceneNode::BillboardSceneNode(scene::IBillboardSceneNode* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_BillboardSceneNode = ref;
}

void BillboardSceneNode::GetSize([Out] float% height, [Out] float% bottomWidth, [Out] float% topWidth)
{
	float h, b, t;
	m_BillboardSceneNode->getSize(h, b, t);

	height = h;
	bottomWidth = b;
	topWidth = t;
}

void BillboardSceneNode::SetSize(float height, float bottomWidth, float topWidth)
{
	LIME_ASSERT(height > 0.0f);
	LIME_ASSERT(bottomWidth > 0.0f);
	LIME_ASSERT(topWidth > 0.0f);

	m_BillboardSceneNode->setSize(height, bottomWidth, topWidth);
}

Video::Color^ BillboardSceneNode::BottomColor::get()
{
	video::SColor t, b;
	m_BillboardSceneNode->getColor(t, b);
	return gcnew Video::Color(b);
}

void BillboardSceneNode::BottomColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);

	video::SColor t, b;
	m_BillboardSceneNode->getColor(t, b);
	m_BillboardSceneNode->setColor(t, *value->m_NativeValue);
}

float BillboardSceneNode::BottomWidth::get()
{
	float h, b, t;
	m_BillboardSceneNode->getSize(h, b, t);
	return b;
}

void BillboardSceneNode::BottomWidth::set(float value)
{
	LIME_ASSERT(value > 0.0f);

	float h, b, t;
	m_BillboardSceneNode->getSize(h, b, t);
	m_BillboardSceneNode->setSize(h, value, t);
}

float BillboardSceneNode::Height::get()
{
	float h, b, t;
	m_BillboardSceneNode->getSize(h, b, t);
	return h;
}

void BillboardSceneNode::Height::set(float value)
{
	LIME_ASSERT(value > 0.0f);

	float h, b, t;
	m_BillboardSceneNode->getSize(h, b, t);
	m_BillboardSceneNode->setSize(value, b, t);
}

Video::Color^ BillboardSceneNode::TopColor::get()
{
	video::SColor t, b;
	m_BillboardSceneNode->getColor(t, b);
	return gcnew Video::Color(t);
}

void BillboardSceneNode::TopColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);

	video::SColor t, b;
	m_BillboardSceneNode->getColor(t, b);
	m_BillboardSceneNode->setColor(*value->m_NativeValue, b);
}

float BillboardSceneNode::TopWidth::get()
{
	float h, b, t;
	m_BillboardSceneNode->getSize(h, b, t);
	return t;
}

void BillboardSceneNode::TopWidth::set(float value)
{
	LIME_ASSERT(value > 0.0f);

	float h, b, t;
	m_BillboardSceneNode->getSize(h, b, t);
	m_BillboardSceneNode->setSize(h, b, value);
}

} // end namespace Scene
} // end namespace IrrlichtLime