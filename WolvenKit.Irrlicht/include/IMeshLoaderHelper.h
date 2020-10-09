// Copyright (C) 2002-2020 vonLeebpl(at)gmail.com
// This file is part of the "Irrlicht Engine" adapted to WolvenKit.
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_MESH_LOADER_HELPER_H_INCLUDED__
#define __I_MESH_LOADER_HELPER_H_INCLUDED__

#include "IReferenceCounted.h"
#include "IAnimatedMeshSceneNode.h"
#include "path.h"

namespace irr
{
namespace scene
{
	class IAnimatedMesh;
	class ISkinnedMesh;
	class IMeshLoader;


	//! instantiate this class in MeshLoader constructor
	//! this class adds additional functions to help engines that do not store info on skeleton and anims
	//! in one file, eg. Witcher3
	class IMeshLoaderHelper : public virtual IReferenceCounted
	{
	public:
		//! Constructor
		IMeshLoaderHelper() {}

		//! Destructor
		virtual ~IMeshLoaderHelper() {}

		//! loads skeleton data and apply it to a mesh of node with skeleton added
		virtual ISkinnedMesh* loadRig(const io::path& filename, IAnimatedMesh* mesh) = 0;

		//! loads animations file and apply it to a mesh of node
		//! return a list of namea of loaded animations
		virtual core::array<core::stringc> loadAnimation(const io::path& filename, ISkinnedMesh* mesh) = 0;

		//! applies loaded animation to mesh in inode
		virtual ISkinnedMesh* applyAnimation(const char* animName, ISkinnedMesh* mesh) = 0;
		
		//! return mesh loader owning this helper
		virtual IMeshLoader* getMeshLoader() const = 0;

	};
}
}

#endif