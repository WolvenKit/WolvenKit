#include "stdafx.h"
#include "DummyTransformationSceneNode.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

DummyTransformationSceneNode^ DummyTransformationSceneNode::Wrap(scene::IDummyTransformationSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew DummyTransformationSceneNode(ref);
}

DummyTransformationSceneNode::DummyTransformationSceneNode(scene::IDummyTransformationSceneNode* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_DummyTransformationSceneNode = ref;
}

Matrix^ DummyTransformationSceneNode::RelativeTransformationMatrix::get()
{
	return gcnew Matrix(&m_DummyTransformationSceneNode->getRelativeTransformationMatrix());
}

} // end namespace Scene
} // end namespace IrrlichtLime