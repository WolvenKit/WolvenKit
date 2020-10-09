// Copyright (C) 2014 Lauri Kasanen
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// Adapted for irrlich by vonleebpl(at)gmail.com


#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_GLTF_WRITER_

#include "CGLTFMeshWriter.h"
#include "IFileSystem.h"
#include "irrAssimp/IrrAssimp.h"

namespace irr
{
namespace scene
{
	CGLTFMeshWriter::CGLTFMeshWriter(ISceneManager* smgr, video::IVideoDriver* driver, io::IFileSystem* fs)
		:_smgr(smgr), VideoDriver(driver), FileSystem(fs)
	{
		#ifdef _DEBUG
		setDebugName("CGLTFMeshWriter");
		#endif

		if (VideoDriver)
			VideoDriver->grab();

		if (FileSystem)
			FileSystem->grab();
	}

	bool CGLTFMeshWriter::writeMesh(io::IWriteFile* file, scene::IMesh* mesh, s32 flags)
	{
		core::stringc gltfFmtId;
		core::array<ExportFormat> formats = IrrAssimp::getExportFormats();
		for (u32 i = 0; i < formats.size(); ++i)
		{
			const ExportFormat format = formats[i];
			if (format.Id == "gltf2")
			{
				gltfFmtId = format.Id;
			}
		}

		IrrAssimp assimp(_smgr);
		assimp.exportMesh(mesh, gltfFmtId, file->getFileName());

		return true;
	}

	// return type of mesh writer
	EMESH_WRITER_TYPE CGLTFMeshWriter::getType() const
	{
		return EMWT_GLTF;
	}

	CGLTFMeshWriter::~CGLTFMeshWriter()
	{
		if (VideoDriver)
			VideoDriver->drop();

		if (FileSystem)
			FileSystem->drop();
	}
}
}
#endif