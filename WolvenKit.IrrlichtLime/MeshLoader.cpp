#include "stdafx.h"
#include "AnimatedMesh.h"
#include "MeshLoader.h"
#include "MeshLoaderHelper.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

MeshLoader^ MeshLoader::Wrap(scene::IMeshLoader* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew MeshLoader(ref);
}

MeshLoader::MeshLoader(scene::IMeshLoader* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_MeshLoader = ref;
}

AnimatedMesh^ MeshLoader::CreateMesh(IO::ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);

	scene::IAnimatedMesh* m = m_MeshLoader->createMesh(LIME_SAFEREF(file, m_ReadFile));
	return AnimatedMesh::Wrap(m);
}

bool MeshLoader::IsALoadableFileExtension(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return m_MeshLoader->isALoadableFileExtension(Lime::StringToPath(filename));
}

MeshLoaderHelper^ MeshLoader::getMeshLoaderHelper()
{
	scene::IMeshLoaderHelper* h = m_MeshLoader->getMeshLoaderHelper();
	return MeshLoaderHelper::Wrap(h);
}

} // end namespace Scene
} // end namespace IrrlichtLime