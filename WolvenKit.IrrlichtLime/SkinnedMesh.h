#pragma once

#include "stdafx.h"
#include "MeshBuffer.h"
#include "AnimatedMesh.h"
#include "SJoint.h"
#include "SRotationKey.h"
#include "SPositionKey.h"
#include "SScaleKey.h"
#include "SWeight.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ref class MeshBuffer;

public ref class SkinnedMesh : AnimatedMesh
{
public:

	void AnimateMesh(float frame, float blend);
	void ConvertMeshToTangents();
	void FinalizeMeshPopulation();
    void AddMeshBuffer(MeshBuffer^ meshBuffer);

	SJoint^ AddJoint();
	List<SJoint^>^ GetAllJoints();
	String^ GetJointName(int index);
	int GetJointIndex(String^ name);

	SRotationKey^ AddRotationKey(SJoint^ joint);
	SPositionKey^ AddPositionKey(SJoint^ joint);
	SScaleKey^ AddScaleKey(SJoint^ joint);
	SWeight^ AddWeight(SJoint^ joint);

	bool SetHardwareSkinning(bool turnOn);
	void SetInterpolationMode(InterpolationMode mode);

	void SkinMesh();

	void UpdateNormalsWhenAnimating(bool turnOn);

	bool UseAnimationFrom(SkinnedMesh^ mesh);

	property int JointCount { int get(); }
	property bool Static { bool get(); }

private:

	//List<SJoint^>^ Joints = gcnew List<SJoint^>();

internal:

	static SkinnedMesh^ Wrap(scene::ISkinnedMesh* ref);
	SkinnedMesh(scene::ISkinnedMesh* ref);

	scene::ISkinnedMesh* m_SkinnedMesh;
};

} // end namespace Scene
} // end namespace IrrlichtLime