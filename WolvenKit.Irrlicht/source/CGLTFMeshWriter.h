// Copyright (C) 2014 Lauri Kasanen
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

// Modified version with rigging/skinning support

#ifndef __IRR_GLTF_MESH_WRITER_H_INCLUDED__
#define __IRR_GLTF_MESH_WRITER_H_INCLUDED__

#include "IMeshWriter.h"
#include "IWriteFile.h"
#include "IVideoDriver.h"

#include "ISceneNode.h"


namespace irr
{
namespace io
{
	class IFileSystem;
}
namespace scene
{

	//! class to write B3D mesh files
	class CGLTFMeshWriter : public IMeshWriter
	{
	public:
		CGLTFMeshWriter(ISceneManager* smgr, video::IVideoDriver* driver, io::IFileSystem* fs);
		CGLTFMeshWriter::~CGLTFMeshWriter();

		//! Returns the type of the mesh writer
		virtual EMESH_WRITER_TYPE getType() const;

		//! writes a mesh
		virtual bool writeMesh(io::IWriteFile* file, scene::IMesh* mesh, s32 flags = EMWF_NONE);

	protected:

		ISceneManager* _smgr;
		io::IFileSystem* FileSystem;
		video::IVideoDriver* VideoDriver;
		io::path Directory;

	};
} // namespace scene
} // namespace irr
#endif