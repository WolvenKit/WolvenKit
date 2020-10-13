#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace IO { ref class ReadFile; }
namespace Scene {

ref class SceneNode;

public ref class SceneLoader : ReferenceCounted
{
public:

	bool IsALoadableFileExtension(String^ filename);
	bool IsALoadableFileFormat(IO::ReadFile^ file);

	bool LoadScene(IO::ReadFile^ file, SceneNode^ rootNode);
	bool LoadScene(IO::ReadFile^ file);

internal:

	static SceneLoader^ Wrap(scene::ISceneLoader* ref);
	SceneLoader(scene::ISceneLoader* ref);

	scene::ISceneLoader* m_SceneLoader;
};

} // end namespace Scene
} // end namespace IrrlichtLime