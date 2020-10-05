// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// Copyright (C) 2002-2020 by Jean-Louis Boudrand
// adapted to irrlicht by vonleebpl(at)gmail.com

#ifndef MESHCOMBINER
#define MESHCOMBINER

#include <ISceneManager.h>
#include <SMesh.h>

namespace irr
{
	namespace scene
	{

		void combineMeshes(scene::ISkinnedMesh* newMesh, scene::IMesh* addition, bool preserveBones);
        void combineMeshes(scene::SMesh* newMesh, scene::SMesh* addition);
		scene::ISkinnedMesh* copySkinnedMesh(scene::ISceneManager* smgr, scene::IMesh* meshToCopy, bool preserveBones);

	}
}
#endif // MESHCOMBINER

