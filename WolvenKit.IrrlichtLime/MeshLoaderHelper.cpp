#include "stdafx.h"
#include "MeshLoader.h"
#include "MeshLoaderHelper.h"
#include "SkinnedMesh.h"
#include "AnimatedMeshSceneNode.h"


using namespace irr;
using namespace System;

namespace IrrlichtLime 
{
namespace Scene 
{
	MeshLoaderHelper^ MeshLoaderHelper::Wrap(scene::IMeshLoaderHelper *ref)
	{
		if (ref == nullptr)
			return nullptr;

		return gcnew MeshLoaderHelper (ref);
	}

	MeshLoaderHelper::MeshLoaderHelper(scene::IMeshLoaderHelper* ref)
		: ReferenceCounted(ref)
	{
		LIME_ASSERT(ref != nullptr);
		m_MeshLoaderHelper = ref;
	}

	List<String^>^ MeshLoaderHelper::loadAnimation(String^ filename, SkinnedMesh^ mesh)
	{
		LIME_ASSERT(filename != nullptr);
		core::array<core::stringc> ret = m_MeshLoaderHelper->loadAnimation(Lime::StringToPath(filename), LIME_SAFEREF(mesh, m_SkinnedMesh));

		List<String^>^ a = gcnew List<String^>;
		for (u32 i = 0; i < ret.size(); ++i)
		{
			a->Add(gcnew String(ret[i].c_str()));
		}

		return a;
	}

	SkinnedMesh^ MeshLoaderHelper::loadRig(String^ filename, AnimatedMesh^ mesh)
	{
		LIME_ASSERT(filename != nullptr);
		scene::ISkinnedMesh* s = m_MeshLoaderHelper->loadRig(Lime::StringToPath(filename), LIME_SAFEREF(mesh, m_AnimatedMesh));
		return SkinnedMesh::Wrap(s);
	}


	SkinnedMesh^ MeshLoaderHelper::applyAnimation(String^ animName, SkinnedMesh^ mesh)
	{
		LIME_ASSERT(animName != nullptr);
		scene::ISkinnedMesh* m = m_MeshLoaderHelper->applyAnimation(LIME_SAFESTRINGTOSTRINGC_C_STR(animName), LIME_SAFEREF(mesh, m_SkinnedMesh));
		return SkinnedMesh::Wrap(m);
	}


	MeshLoader^ MeshLoaderHelper::getMeshLoader()
	{
		scene::IMeshLoader* l = m_MeshLoaderHelper->getMeshLoader();
		return MeshLoader::Wrap(l);
	}
} // namespace Scene
} // namespace IrrlichtLime