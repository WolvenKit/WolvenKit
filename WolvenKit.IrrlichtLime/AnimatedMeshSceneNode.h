#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

ref class AnimatedMesh;
ref class BoneSceneNode;
ref class Mesh;
ref class SceneManager;
ref class SceneNode;
ref class ShadowVolumeSceneNode;

public ref class AnimatedMeshSceneNode : SceneNode
{
public:

	ShadowVolumeSceneNode^ AddShadowVolumeSceneNode(Scene::Mesh^ shadowMesh, int id, bool zfailmethod, float infinity);
	ShadowVolumeSceneNode^ AddShadowVolumeSceneNode(Scene::Mesh^ shadowMesh, int id, bool zfailmethod);
	ShadowVolumeSceneNode^ AddShadowVolumeSceneNode(Scene::Mesh^ shadowMesh, int id);
	ShadowVolumeSceneNode^ AddShadowVolumeSceneNode(Scene::Mesh^ shadowMesh);
	ShadowVolumeSceneNode^ AddShadowVolumeSceneNode();

	void AnimateJoints(bool calculateAbsolutePositions);
	void AnimateJoints();

	SceneNode^ Clone(SceneNode^ newParent, Scene::SceneManager^ newManager);
	SceneNode^ Clone(SceneNode^ newParent);
	SceneNode^ Clone();

	BoneSceneNode^ GetJointNode(int jointIndex);
	BoneSceneNode^ GetJointNode(String^ jointName);

	//SMD3QuaternionTag* getMD3TagTransformation(const core::stringc &tagname);

	//void setAnimationEndCallback(IAnimationEndCallBack *callback=0); // not implemented yet

	bool SetFrameLoop(int begin, int end);
	void SetJointMode(JointUpdateOnRender mode);

	bool SetMD2Animation(AnimationTypeMD2 animationType);
	bool SetMD2Animation(String^ animationName);

	void SetRenderFromIdentity(bool on);
	void SetTransitionTime(float timeInSeconds);

	property float AnimationSpeed { float get(); void set(float value); }
	property float CurrentFrame { float get(); void set(float value); }
	property int EndFrame { int get(); }
	property int JointCount { int get(); }
	property bool LoopMode { bool get(); void set(bool value); }
	property AnimatedMesh^ Mesh { AnimatedMesh^ get(); void set(AnimatedMesh^ value); }
	property int StartFrame { int get(); }
	property bool ReadOnlyMaterials { bool get(); void set(bool value); }

internal:

	static AnimatedMeshSceneNode^ Wrap(scene::IAnimatedMeshSceneNode* ref);
	AnimatedMeshSceneNode(scene::IAnimatedMeshSceneNode* ref);

	scene::IAnimatedMeshSceneNode* m_AnimatedMeshSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime