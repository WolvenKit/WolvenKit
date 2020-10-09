#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class CameraSceneNode : SceneNode
{
public:

	void UpdateMatrices();

	void SetProjectionMatrix(Matrix^ projection, bool isOrthogonal);
	void SetProjectionMatrix(Matrix^ projection);

	property float AspectRatio { float get(); void set(float value); }
	property float FarValue { float get(); void set(float value); }
	property float FOV { float get(); void set(float value); }
	property bool InputReceiverEnabled { bool get(); void set(bool value); }
	property float NearValue { float get(); void set(float value); }
	property bool Orthogonal { bool get(); }
	property Matrix^ ProjectionMatrix { Matrix^ get(); }
	property Vector3Df^ Rotation { virtual void set(Vector3Df^ value) override; }
	property Vector3Df^ Target { Vector3Df^ get(); void set(Vector3Df^ value); }
	property bool TargetAndRotationBinding { bool get(); void set(bool value); }
	property Vector3Df^ UpVector { Vector3Df^ get(); void set(Vector3Df^ value); }
	property Scene::ViewFrustum^ ViewFrustum { Scene::ViewFrustum^ get(); }
	property Matrix^ ViewMatrix { Matrix^ get(); }
	property Matrix^ ViewMatrixAffector { Matrix^ get(); void set(Matrix^ value); }

internal:

	static CameraSceneNode^ Wrap(scene::ICameraSceneNode* ref);
	CameraSceneNode(scene::ICameraSceneNode* ref);

	scene::ICameraSceneNode* m_CameraSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime