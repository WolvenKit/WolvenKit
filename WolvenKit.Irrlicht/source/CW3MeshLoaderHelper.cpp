// Copyright (C) 2002-2020 vonLeebpl(at)gmail.com
// based on project of Jean - Louis Boudrand
// This file is part of the "Irrlicht Engine" adapted to WolvenKit.
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_W3ENT_LOADER_

#include "CW3MeshLoaderHelper.h"
#include "os.h"

namespace irr
{
namespace scene
{

	ISkinnedMesh* CW3MeshLoaderHelper::loadRig(const io::path& filename, IAnimatedMesh* mesh)
	{

		io::IReadFile* file = _fileSystem->createAndOpenFile(filename);
		if (!file)
		{
			os::Printer::log("Could not load rig, because file could not be opened: ", filename, ELL_ERROR);
			return nullptr;
		}

		file->seek(0);
		scene::IAnimatedMesh* lmesh = _loader->createMesh(file);
		file->drop();

		if (lmesh)
			lmesh->drop(); // we don't need anything that can be there


		scene::ISkinnedMesh* newMesh = scene::copySkinnedMesh(_smgr, mesh, false);
				scene::CW3Skeleton skeleton = _loader->Skeleton;

		//scene::ISkinnedMesh* newMesh = scene::copySkinnedMesh(_smgr, node->getMesh()->getMesh(0), false);
		bool success = skeleton.applyToModel(newMesh);
		if (!success)
		{
			os::Printer::log("The skeleton can't be applied to the model. Are you sure that you have selected the good w2rig file ?", ELL_ERROR);
			return nullptr;
		}
		
		// Apply the skinning
		scene::CW3DataCache::_instance.setOwner(newMesh);
		scene::CW3DataCache::_instance.apply();

		newMesh->setDirty();
		newMesh->finalize();

		_loader->meshToAnimate = newMesh;

		//node->setMesh(newMesh);

		//setMaterialsSettings(node);

		return newMesh;
	}

	
	
	SW3Animation* CW3MeshLoaderHelper::getAnimationByName(const char* animName)
	{
		for (auto const& a : _loader->Animations())
		{
			if (a->name == animName)
				return a;
		}
		return nullptr;
	}

	ISkinnedMesh* CW3MeshLoaderHelper::applyAnimation(const char* animName, ISkinnedMesh* mesh)
	{
		SW3Animation* anim = getAnimationByName(animName);
		if (!anim)
		{
			os::Printer::log("Animation not available: ", animName, ELL_ERROR);
			return mesh;
		}
		
		scene::ISkinnedMesh* lmesh = scene::copySkinnedMesh(_smgr, mesh, true);
		if (!lmesh)
		{
			os::Printer::log("Failed to copy mesh!", ELL_ERROR);
			return mesh;
		}

		//scene::ISkinnedMesh* mesh = dynamic_cast<ISkinnedMesh*>(_node->getMesh());
		lmesh->setAnimationSpeed(anim->animationSpeed);
		for (u32 i = 0; i < mesh->getAllJoints().size(); ++i)
		{
			scene::ISkinnedMesh::SJoint* joint = lmesh->getAllJoints()[i];
			joint->PositionKeys.clear();
			joint->RotationKeys.clear();
			joint->ScaleKeys.clear();

			for (u32 j = 0; j < anim->positions[i].size(); ++j)
			{
				scene::ISkinnedMesh::SPositionKey* key = lmesh->addPositionKey(joint);
				key->position = anim->positions[i][j];
				key->frame = (f32)(anim->positionsKeyframes[i][j]);
			}

			for (u32 j = 0; j < anim->orientations[i].size(); ++j)
			{
				scene::ISkinnedMesh::SRotationKey* key = lmesh->addRotationKey(joint);
				key->rotation = anim->orientations[i][j];
				key->frame = (f32)(anim->orientationsKeyframes[i][j]);
			}

			for (u32 j = 0; j < anim->scales[i].size(); ++j)
			{
				scene::ISkinnedMesh::SScaleKey* key = lmesh->addScaleKey(joint);
				key->scale = anim->scales[i][j];
				key->frame = (f32)(anim->scalesKeyframes[i][j]);
			}
		}

		lmesh->setDirty();
		lmesh->finalize();

		return lmesh;
	}

	//! loads animation file and stores animations in loader
	core::array<core::stringc> CW3MeshLoaderHelper::loadAnimation(const io::path& filename, ISkinnedMesh* mesh)
	{
		io::IReadFile* file = _fileSystem->createAndOpenFile(filename);
		if (!file)
		{
			os::Printer::log("Could not load animations, because file could not be opened: ", filename, ELL_ERROR);
			return _animList;
		}

		// use the loader to add the animation to the new model
		_loader->meshToAnimate = mesh;

		scene::IAnimatedMesh* lmesh = _loader->createMesh(file);
		if (lmesh)
			lmesh->drop();
		
		file->drop();

		for (auto const& a : _loader->Animations())
		{
			_animList.push_back(a->name.c_str());
		}

		return _animList;
	}


	void CW3MeshLoaderHelper::setMaterialsSettings(IAnimatedMeshSceneNode* node)
	{
		if (node)
		{
			// materials with normal maps are not handled
			for (u32 i = 0; i < node->getMaterialCount(); ++i)
			{
				video::SMaterial& material = node->getMaterial(i);
				//if (material.MaterialType == video::EMT_NORMAL_MAP_SOLID
				//	|| material.MaterialType == video::EMT_PARALLAX_MAP_SOLID)
                if(material.MaterialType == video::EMT_PARALLAX_MAP_SOLID)
				{
					material.MaterialType = video::EMT_SOLID;
				}
				else if (material.MaterialType == video::EMT_NORMAL_MAP_TRANSPARENT_ADD_COLOR
					|| material.MaterialType == video::EMT_PARALLAX_MAP_TRANSPARENT_ADD_COLOR)
				{
					material.MaterialType = video::EMT_TRANSPARENT_ADD_COLOR;
				}
				else if (material.MaterialType == video::EMT_NORMAL_MAP_TRANSPARENT_VERTEX_ALPHA
					|| material.MaterialType == video::EMT_PARALLAX_MAP_TRANSPARENT_VERTEX_ALPHA)
				{
					material.MaterialType = video::EMT_TRANSPARENT_VERTEX_ALPHA;
				}
			}

			node->setMaterialFlag(video::EMF_LIGHTING, false);
			node->setMaterialFlag(video::EMF_BACK_FACE_CULLING, false);

			for (u32 i = 1; i < _IRR_MATERIAL_MAX_TEXTURES_; ++i)
				node->setMaterialTexture(i, nullptr);
		}
	}


} //namespace scene
} //namespace irr

#endif
