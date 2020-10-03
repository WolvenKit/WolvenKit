#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

public ref class SJoint
{
public:

	void AddChildren(SJoint^ children);

	property Matrix^ LocalMatrix { Matrix^ get(); void set(Matrix^); }
	property Matrix^ GlobalMatrix { Matrix^ get(); void set(Matrix^); }
	property Vector3Df^ Animatedposition { Vector3Df^ get(); void set(Vector3Df^); }
	property Quaternion^ Animatedrotation { Quaternion^ get(); void set(Quaternion^); }
	property Vector3Df^ Animatedscale { Vector3Df^ get(); void set(Vector3Df^); }

	property List<SJoint^>^ Children { List<SJoint^>^ get(); };
	property String^ Name { String^ get(); void set(String^); }

private:

	//List<SJoint^>^ _Children = gcnew List<SJoint^>();

internal:

	static SJoint^ Wrap(scene::ISkinnedMesh::SJoint* ref);
	SJoint(scene::ISkinnedMesh::SJoint* ref);

	scene::ISkinnedMesh::SJoint* m_Joint;

	/*SJoint() : UseAnimationFrom(0), GlobalSkinningSpace(false),
		positionHint(-1), scaleHint(-1), rotationHint(-1)
	{
	}

	//! The name of this joint
	core::stringc Name;

	//! Local matrix of this joint
	core::matrix4 LocalMatrix;

	//! List of child joints
	core::array<SJoint*> Children;

	//! List of attached meshes
	core::array<u32> AttachedMeshes;

	//! Animation keys causing translation change
	core::array<SPositionKey> PositionKeys;

	//! Animation keys causing scale change
	core::array<SScaleKey> ScaleKeys;

	//! Animation keys causing rotation change
	core::array<SRotationKey> RotationKeys;

	//! Skin weights
	core::array<SWeight> Weights;

	//! Unnecessary for loaders, will be overwritten on finalize
	core::matrix4 GlobalMatrix;
	core::matrix4 GlobalAnimatedMatrix;
	core::matrix4 LocalAnimatedMatrix;
	core::vector3df Animatedposition;
	core::vector3df Animatedscale;
	core::quaternion Animatedrotation;

	core::matrix4 GlobalInversedMatrix; //the x format pre-calculates this

private:
	//! Internal members used by CSkinnedMesh
	friend class CSkinnedMesh;

	SJoint *UseAnimationFrom;
	bool GlobalSkinningSpace;

	s32 positionHint;
	s32 scaleHint;
	s32 rotationHint;*/
};

} // end namespace Scene
} // end namespace IrrlichtLime
