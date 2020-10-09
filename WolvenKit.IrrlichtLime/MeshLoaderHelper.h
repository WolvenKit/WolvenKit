#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	ref class AnimatedMeshSceneNode;
	ref class SkinnedMesh;
	ref class MeshLoader;

	public ref class MeshLoaderHelper : ReferenceCounted
	{
	public:

		SkinnedMesh^ loadRig(String^ filename, AnimatedMesh^ mesh );

		SkinnedMesh^ applyAnimation(String^ animName, SkinnedMesh^ mesh);

		List<String^>^ loadAnimation(String^ filename, SkinnedMesh^ mesh);

		MeshLoader^ getMeshLoader();

	internal:

		static MeshLoaderHelper^ Wrap(scene::IMeshLoaderHelper* ref);
		MeshLoaderHelper(scene::IMeshLoaderHelper* ref);

		scene::IMeshLoaderHelper* m_MeshLoaderHelper;
	};
}
}