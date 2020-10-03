// Copyright (C) 2014 Lauri Kasanen
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

// Modified version with rigging/skinning support

#ifndef __IRR_B3D_MESH_WRITER_H_INCLUDED__
#define __IRR_B3D_MESH_WRITER_H_INCLUDED__

#include "IMeshWriter.h"
#include "IWriteFile.h"
#include "SB3DStructs.h"
#include "ISkinnedMesh.h"



namespace irr
{
namespace scene
{

//! class to write B3D mesh files
class CB3DMeshWriter : public IMeshWriter
{
public:

	CB3DMeshWriter();

	//! Returns the type of the mesh writer
    virtual EMESH_WRITER_TYPE getType() const;

	//! writes a mesh
    virtual bool writeMesh(io::IWriteFile* file, scene::IMesh* mesh, s32 flags=EMWF_NONE);

private:
	u32 Size;

    void writeJointChunk(io::IWriteFile* file, ISkinnedMesh* mesh , ISkinnedMesh::SJoint* joint);
    u32 getJointChunkSize(const ISkinnedMesh* mesh, ISkinnedMesh::SJoint* joint);
    core::array<ISkinnedMesh::SJoint*> getRootJoints(const ISkinnedMesh* mesh);

    u32 getUVlayerCount(IMesh *mesh);
    ISkinnedMesh* getSkinned (IMesh *mesh);

	void write(io::IWriteFile* file, const void *ptr, const u32 bytes);

};

} // end namespace
} // end namespace

#endif
