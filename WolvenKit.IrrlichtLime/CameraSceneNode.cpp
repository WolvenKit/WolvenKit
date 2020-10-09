#include "stdafx.h"
#include "CameraSceneNode.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

CameraSceneNode^ CameraSceneNode::Wrap(scene::ICameraSceneNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew CameraSceneNode(ref);
}

CameraSceneNode::CameraSceneNode(scene::ICameraSceneNode* ref)
	: SceneNode(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_CameraSceneNode = ref;
}

void CameraSceneNode::UpdateMatrices()
{
	m_CameraSceneNode->updateMatrices();
}

void CameraSceneNode::SetProjectionMatrix(Matrix^ projection, bool isOrthogonal)
{
	LIME_ASSERT(projection != nullptr);
	m_CameraSceneNode->setProjectionMatrix(*projection->m_NativeValue, isOrthogonal);
}

void CameraSceneNode::SetProjectionMatrix(Matrix^ projection)
{
	LIME_ASSERT(projection != nullptr);
	m_CameraSceneNode->setProjectionMatrix(*projection->m_NativeValue);
}

float CameraSceneNode::AspectRatio::get()
{
	return m_CameraSceneNode->getAspectRatio();
}

void CameraSceneNode::AspectRatio::set(float value)
{
	m_CameraSceneNode->setAspectRatio(value);
}

float CameraSceneNode::FarValue::get()
{
	return m_CameraSceneNode->getFarValue();
}

void CameraSceneNode::FarValue::set(float value)
{
	m_CameraSceneNode->setFarValue(value);
}

float CameraSceneNode::FOV::get()
{
	return m_CameraSceneNode->getFOV();
}

void CameraSceneNode::FOV::set(float value)
{
	m_CameraSceneNode->setFOV(value);
}

bool CameraSceneNode::InputReceiverEnabled::get()
{
	return m_CameraSceneNode->isInputReceiverEnabled();
}

void CameraSceneNode::InputReceiverEnabled::set(bool value)
{
	m_CameraSceneNode->setInputReceiverEnabled(value);
}

float CameraSceneNode::NearValue::get()
{
	return m_CameraSceneNode->getNearValue();
}

void CameraSceneNode::NearValue::set(float value)
{
	m_CameraSceneNode->setNearValue(value);
}

bool CameraSceneNode::Orthogonal::get()
{
	return m_CameraSceneNode->isOrthogonal();
}

Matrix^ CameraSceneNode::ProjectionMatrix::get()
{
	return gcnew Matrix(m_CameraSceneNode->getProjectionMatrix());
}

void CameraSceneNode::Rotation::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_CameraSceneNode->setRotation(*value->m_NativeValue);
}

Vector3Df^ CameraSceneNode::Target::get()
{
	return gcnew Vector3Df(m_CameraSceneNode->getTarget());
}

void CameraSceneNode::Target::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_CameraSceneNode->setTarget(*value->m_NativeValue);
}

bool CameraSceneNode::TargetAndRotationBinding::get()
{
	return m_CameraSceneNode->getTargetAndRotationBinding();
}

void CameraSceneNode::TargetAndRotationBinding::set(bool value)
{
	m_CameraSceneNode->bindTargetAndRotation(value);
}

Vector3Df^ CameraSceneNode::UpVector::get()
{
	return gcnew Vector3Df(m_CameraSceneNode->getUpVector());
}

void CameraSceneNode::UpVector::set(Vector3Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_CameraSceneNode->setUpVector(*value->m_NativeValue);
}

Scene::ViewFrustum^ CameraSceneNode::ViewFrustum::get()
{
	const scene::SViewFrustum* f = m_CameraSceneNode->getViewFrustum();
	return gcnew Scene::ViewFrustum((scene::SViewFrustum*)f); // !!! cast to non-const pointer
}

Matrix^ CameraSceneNode::ViewMatrix::get()
{
	return gcnew Matrix(m_CameraSceneNode->getViewMatrix());
}

Matrix^ CameraSceneNode::ViewMatrixAffector::get()
{
	return gcnew Matrix(m_CameraSceneNode->getViewMatrixAffector());
}

void CameraSceneNode::ViewMatrixAffector::set(Matrix^ value)
{
	LIME_ASSERT(value != nullptr);
	m_CameraSceneNode->setViewMatrixAffector(*value->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime