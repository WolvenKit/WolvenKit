#pragma once

#include "stdafx.h"
#include "SceneNodeAnimator.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

ref class SceneNode;
ref class TriangleSelector;

public ref class CollisionResponseSceneNodeAnimator : SceneNodeAnimator
{
public:

	void Jump(float jumpSpeed);
	//void setCollisionCallback (ICollisionCallback *callback)=0 // not supported yet // TODO: implement it with event to use next: a.OnCollision += new ...

	property bool AnimateTarget { bool get(); void set(bool value); }
	property SceneNode^ CollisionNode { SceneNode^ get(); }
	property bool CollisionOccurred { bool get(); }
	property Vector3Df^ CollisionPoint { Vector3Df^ get(); }
	property Vector3Df^ CollisionResultPosition { Vector3Df^ get(); }
	property Triangle3Df^ CollisionTriangle { Triangle3Df^ get(); }
	property Vector3Df^ EllipsoidRadius { Vector3Df^ get(); void set(Vector3Df^ value); }
	property Vector3Df^ EllipsoidTranslation { Vector3Df^ get(); void set(Vector3Df^ value); }
	property bool Falling { bool get(); }
	property Vector3Df^ Gravity { Vector3Df^ get(); void set(Vector3Df^ value); }
	property SceneNode^ TargetNode { SceneNode^ get(); void set(SceneNode^ value); }
	property TriangleSelector^ World { TriangleSelector^ get(); void set(TriangleSelector^ value); }

internal:

	static CollisionResponseSceneNodeAnimator^ Wrap(scene::ISceneNodeAnimatorCollisionResponse* ref);
	CollisionResponseSceneNodeAnimator(scene::ISceneNodeAnimatorCollisionResponse* ref);

	scene::ISceneNodeAnimatorCollisionResponse* m_CollisionResponseSceneNodeAnimator;
};

} // end namespace Scene
} // end namespace IrrlichtLime