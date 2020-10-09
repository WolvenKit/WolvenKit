#include "stdafx.h"
#include "SceneLoader.h"
#include "SceneNode.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

SceneLoader^ SceneLoader::Wrap(scene::ISceneLoader* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SceneLoader(ref);
}

SceneLoader::SceneLoader(scene::ISceneLoader* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_SceneLoader = ref;
}

bool SceneLoader::IsALoadableFileExtension(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return m_SceneLoader->isALoadableFileExtension(Lime::StringToPath(filename));
}

bool SceneLoader::IsALoadableFileFormat(IO::ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);
	return m_SceneLoader->isALoadableFileFormat(LIME_SAFEREF(file, m_ReadFile));
}

bool SceneLoader::LoadScene(IO::ReadFile^ file, SceneNode^ rootNode)
{
	LIME_ASSERT(file != nullptr);

	return m_SceneLoader->loadScene(
		LIME_SAFEREF(file, m_ReadFile),
		nullptr,
		LIME_SAFEREF(rootNode, m_SceneNode));
}

bool SceneLoader::LoadScene(IO::ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);

	return m_SceneLoader->loadScene(
		LIME_SAFEREF(file, m_ReadFile));
}

} // end namespace Scene
} // end namespace IrrlichtLime