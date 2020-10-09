// Copyright (C) 2002-2020 vonLeebpl(at)gmail.com
// This file is part of the "Irrlicht Engine" adapted to WolvenKit.
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __CW3_MESH_LOADER_HELPER_H_INCLUDED__
#define __CW3_MESH_LOADER_HELPER_H_INCLUDED__

#include "IMeshLoaderHelper.h"
#include "CW3EntLoader.h"

namespace irr
{
namespace scene
{

	class CW3MeshLoaderHelper : public IMeshLoaderHelper
	{
	public:
		CW3MeshLoaderHelper(CW3EntLoader* loader, scene::ISceneManager* smgr, io::IFileSystem* fs) :
			_loader(loader), _smgr(smgr), _fileSystem(fs) {};

		virtual								~CW3MeshLoaderHelper() { _animList.clear(); };
	
		virtual ISkinnedMesh*				loadRig(const io::path& filename, IAnimatedMesh* mesh) _IRR_OVERRIDE_;

		virtual core::array<core::stringc>	loadAnimation(const io::path& filename, ISkinnedMesh* mesh) _IRR_OVERRIDE_;

		virtual ISkinnedMesh*				applyAnimation(const char* animName, ISkinnedMesh* mesh) _IRR_OVERRIDE_;

		virtual IMeshLoader*				getMeshLoader() const 
		{
			return _loader;
		}
	private:
		void setMaterialsSettings(IAnimatedMeshSceneNode* node);
		SW3Animation* CW3MeshLoaderHelper::getAnimationByName(const char* animName);
		
	protected:
		io::IFileSystem* _fileSystem;
		CW3EntLoader* _loader;
		scene::ISceneManager* _smgr;

		core::array<core::stringc> _animList;

	};
} // namespace scene
} // namespace irr
#endif

