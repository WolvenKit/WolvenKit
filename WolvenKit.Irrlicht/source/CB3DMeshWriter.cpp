// Copyright (C) 2014 Lauri Kasanen
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

// TODO: replace printf's by logging messages

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_B3D_WRITER_

#include "CB3DMeshWriter.h"
#include "os.h"
#include "ISkinnedMesh.h"
#include "IMeshBuffer.h"
#include "IWriteFile.h"
#include "ITexture.h"
#include "irrMap.h"


namespace irr
{
namespace scene
{

using namespace core;
using namespace video;

CB3DMeshWriter::CB3DMeshWriter()
{
	#ifdef _DEBUG
	setDebugName("CB3DMeshWriter");
	#endif
}


//! Returns the type of the mesh writer
EMESH_WRITER_TYPE CB3DMeshWriter::getType() const
{
    return EMWT_B3D;
}


//! writes a mesh
bool CB3DMeshWriter::writeMesh(io::IWriteFile* file, IMesh* const mesh, s32 flags)
{
    if (!file || !mesh)
        return false;
#ifdef __BIG_ENDIAN__
    os::Printer::log("B3D export does not support big-endian systems.", ELL_ERROR);
    return false;
#endif

    Size = 0;
    file->write("BB3D", 4);
    file->write(&Size, sizeof(u32)); // Updated later once known.

    int version = 1;
    write(file, &version, sizeof(int));

    //

    const u32 numBeshBuffers = mesh->getMeshBufferCount();
    array<SB3dTexture> texs;
    map<ITexture *, u32> tex2id;	// TODO: texture pointer as key not sufficient as same texture can have several id's
    u32 texsizes = 0;
    for (u32 i = 0; i < numBeshBuffers; i++)
	{
        const IMeshBuffer * const mb = mesh->getMeshBuffer(i);
        const SMaterial &mat = mb->getMaterial();

        for (u32 j = 0; j < MATERIAL_MAX_TEXTURES; j++)
		{
            if (mat.getTexture(j))
			{
                SB3dTexture t;
				t.TextureName = core::stringc(mat.getTexture(j)->getName().getPath());

				// TODO: need some description of Blitz3D texture-flags to figure this out. But Blend should likely depend on material-type.
				t.Flags = j == 2 ? 65536 : 1;
				t.Blend = 2;

				// TODO: evaluate texture matrix
				t.Xpos = 0;
				t.Ypos = 0;
				t.Xscale = 1;
				t.Yscale = 1;
				t.Angle = 0;

                texs.push_back(t);
                texsizes += 7*4 + t.TextureName.size() + 1;
                tex2id[mat.getTexture(j)] = texs.size() - 1;
            }
        }
    }

    write(file, "TEXS", 4);
    write(file, &texsizes, 4);

    u32 numTexture = texs.size();
    for (u32 i = 0; i < numTexture; i++)
	{
        write(file, texs[i].TextureName.c_str(), texs[i].TextureName.size() + 1);
        write(file, &texs[i].Flags, 7*4);
    }

    //

    const u32 brushsize = (7 * 4 + 1) * numBeshBuffers + numBeshBuffers * 4 * MATERIAL_MAX_TEXTURES + 4;
    write(file, "BRUS", 4);
    write(file, &brushsize, 4);
    u32 brushcheck = Size;
    const u32 usedtex = MATERIAL_MAX_TEXTURES;
    write(file, &usedtex, 4);

    for (u32 i = 0; i < numBeshBuffers; i++)
	{
        const IMeshBuffer * const mb = mesh->getMeshBuffer(i);
        const SMaterial &mat = mb->getMaterial();

        write(file, "", 1);

        float f = 1;
        write(file, &f, 4);
        write(file, &f, 4);
        write(file, &f, 4);
        write(file, &f, 4);

        f = 0;
        write(file, &f, 4);

        u32 tmp = 1;
        write(file, &tmp, 4);
        tmp = 0;
        write(file, &tmp, 4);

        for (u32 j = 0; j < MATERIAL_MAX_TEXTURES; j++)
		{
            if (mat.getTexture(j))
			{
                const u32 id = tex2id[mat.getTexture(j)];
                write(file, &id, 4);
            }
			else
			{
                const int id = -1;
                write(file, &id, 4);
            }
        }
    }

    // Check brushsize
    brushcheck = Size - brushcheck;
    if (brushcheck != brushsize)
	{
        printf("Failed in brush size calculation, size %u advanced %u\n",
            brushsize, brushcheck);
	}

    write(file, "NODE", 4);

    // Calculate node size
    u32 nodesize = 41 + 8 + 4 + 8;
    u32 bonesSize = 0;

    if(ISkinnedMesh *skinnedMesh = getSkinned(mesh))
    {
        if (!skinnedMesh->isStatic())
        {
            bonesSize += 20;
        }

        const core::array<ISkinnedMesh::SJoint*> rootJoints = getRootJoints(skinnedMesh);
        for (u32 i = 0; i < rootJoints.size(); i++)
        {
            bonesSize += getJointChunkSize(skinnedMesh, rootJoints[i]);
        }
        nodesize += bonesSize;

        // -------------------

    }

    // VERT data
    nodesize += 12;

    const u32 texcoords = getUVlayerCount(mesh);
    for (u32 i = 0; i < numBeshBuffers; i++)
    {
        nodesize += 8 + 4;
        const IMeshBuffer * const mb = mesh->getMeshBuffer(i);

        nodesize += mb->getVertexCount() * 10 * 4;

        nodesize += mb->getVertexCount() * texcoords * 2 * 4;
        nodesize += mb->getIndexCount() * 4;
    }
    write(file, &nodesize, 4);
    u32 nodecheck = Size;

    // Node
    write(file, "", 1);
    float f = 0;
    write(file, &f, 4);
    write(file, &f, 4);
    write(file, &f, 4);

    f = 1;
    write(file, &f, 4);
    write(file, &f, 4);
    write(file, &f, 4);

    write(file, &f, 4);
    f = 0;
    write(file, &f, 4);
    write(file, &f, 4);
    write(file, &f, 4);

    // Mesh
    write(file, "MESH", 4);
    const u32 meshsize = nodesize - 41 - 8 - bonesSize;
    write(file, &meshsize, 4);
	s32 brushID = -1;
    write(file, &brushID, 4);



    // Verts
    write(file, "VRTS", 4);
    u32 vertsize = 12;

    for (u32 i = 0; i < numBeshBuffers; i++)
    {
        const IMeshBuffer * const mb = mesh->getMeshBuffer(i);

        vertsize += mb->getVertexCount() * 10 * 4 +
                    mb->getVertexCount() * texcoords * 2 * 4;
    }
    write(file, &vertsize, 4);
    u32 vertcheck = Size;

    int flagsB3D = 3;
    write(file, &flagsB3D, 4);

    write(file, &texcoords, 4);
    flagsB3D = 2;
    write(file, &flagsB3D, 4);

    for (u32 i = 0; i < numBeshBuffers; i++)
    {
        const IMeshBuffer * const mb = mesh->getMeshBuffer(i);
        irr::u32 numVertices = mb->getVertexCount();
        for (u32 j = 0; j < numVertices; j++)
		{
            const vector3df &pos = mb->getPosition(j);
            write(file, &pos.X, 4);
            write(file, &pos.Y, 4);
            write(file, &pos.Z, 4);

            const vector3df &n = mb->getNormal(j);
            write(file, &n.X, 4);
            write(file, &n.Y, 4);
            write(file, &n.Z, 4);

            const u32 zero = 0;
            switch (mb->getVertexType())
			{
                case EVT_STANDARD:
                {
                    S3DVertex *v = (S3DVertex *) mb->getVertices();
                    const SColorf col(v[j].Color);
                    write(file, &col.r, 4);
                    write(file, &col.g, 4);
                    write(file, &col.b, 4);
                    write(file, &col.a, 4);

                    write(file, &v[j].TCoords.X, 4);
                    write(file, &v[j].TCoords.Y, 4);
                    if (texcoords == 2)
                    {
                        write(file, &zero, 4);
                        write(file, &zero, 4);
                    }
                }
                break;
                case EVT_2TCOORDS:
                {
                    S3DVertex2TCoords *v = (S3DVertex2TCoords *) mb->getVertices();
                    const SColorf col(v[j].Color);
                    write(file, &col.r, 4);
                    write(file, &col.g, 4);
                    write(file, &col.b, 4);
                    write(file, &col.a, 4);

                    write(file, &v[j].TCoords.X, 4);
                    write(file, &v[j].TCoords.Y, 4);
                    write(file, &v[j].TCoords2.X, 4);
                    write(file, &v[j].TCoords2.Y, 4);
                }
                break;
                case EVT_TANGENTS:
                {
                    S3DVertexTangents *v = (S3DVertexTangents *) mb->getVertices();
                    const SColorf col(v[j].Color);
                    write(file, &col.r, 4);
                    write(file, &col.g, 4);
                    write(file, &col.b, 4);
                    write(file, &col.a, 4);

                    write(file, &v[j].TCoords.X, 4);
                    write(file, &v[j].TCoords.Y, 4);
                    if (texcoords == 2)
                    {
                        write(file, &zero, 4);
                        write(file, &zero, 4);
                    }
                }
                break;
            }
        }
    }
    // Check vertsize
    vertcheck = Size - vertcheck;
    if (vertcheck != vertsize)
	{
        printf("Failed in vertex size calculation, size %u advanced %u\n",
            vertsize, vertcheck);
	}

    u32 currentMeshBufferIndex = 0;
    // Tris
    for (u32 i = 0; i < numBeshBuffers; i++)
    {
        const IMeshBuffer * const mb = mesh->getMeshBuffer(i);
        write(file, "TRIS", 4);
        const u32 trisize = 4 + mb->getIndexCount() * 4;
        write(file, &trisize, 4);

        u32 tricheck = Size;

        write(file, &i, 4);

        u32 numIndices = mb->getIndexCount();
        const u16 * const idx = (u16 *) mb->getIndices();
        for (u32 j = 0; j < numIndices; j += 3)
		{
            u32 tmp = idx[j] + currentMeshBufferIndex;
            write(file, &tmp, sizeof(u32));

            tmp = idx[j + 1] + currentMeshBufferIndex;
            write(file, &tmp, sizeof(u32));

            tmp = idx[j + 2] + currentMeshBufferIndex;
            write(file, &tmp, sizeof(u32));
        }

        // Check that tris calculation was ok
        tricheck = Size - tricheck;
        if (tricheck != trisize)
		{
            printf("Failed in tris size calculation, size %u advanced %u\n",
                trisize, tricheck);
		}

        currentMeshBufferIndex += mb->getVertexCount();
    }

    if(ISkinnedMesh *skinnedMesh = getSkinned(mesh))
    {
        // Write animation data
        if (!skinnedMesh->isStatic())
        {
            write(file, "ANIM", 4);

            const u32 animsize = 12;
            write(file, &animsize, 4);

            const u32 flags = 0;
            const u32 frames = skinnedMesh->getFrameCount();
            const f32 fps = skinnedMesh->getAnimationSpeed();

            write(file, &flags, 4);
            write(file, &frames, 4);
            write(file, &fps, 4);
        }

        // Write joints
        core::array<ISkinnedMesh::SJoint*> rootJoints = getRootJoints(skinnedMesh);

        for (u32 i = 0; i < rootJoints.size(); i++)
        {
            writeJointChunk(file, skinnedMesh, rootJoints[i]);
        }
    }

    // Check that node calculation was ok
    nodecheck = Size - nodecheck;
    if (nodecheck != nodesize)
	{
        printf("Failed in node size calculation, size %u advanced %u\n",
            nodesize, nodecheck);
	}
    file->seek(4);
    file->write(&Size, 4);

    file->flush();
    file->drop();

    return true;
}



void CB3DMeshWriter::writeJointChunk(io::IWriteFile* file, ISkinnedMesh* mesh , ISkinnedMesh::SJoint* joint)
{
    // Node
    write(file, "NODE", 4);

    // Calculate node size
    u32 nodesize = getJointChunkSize(mesh, joint);
    nodesize -= 8; // The declaration + size of THIS chunk shouldn't be added to the size

    write(file, &nodesize, 4);


    core::stringc name = joint->Name;
    write(file, name.c_str(), name.size());
    write(file, "", 1);

    core::vector3df pos = joint->Animatedposition;
    // Position
    write(file, &pos.X, 4);
    write(file, &pos.Y, 4);
    write(file, &pos.Z, 4);

    // Scale
    core::vector3df scale = joint->Animatedscale;
    if (scale == core::vector3df(0, 0, 0))
        scale = core::vector3df(1, 1, 1);

    write(file, &scale.X, 4);
    write(file, &scale.Y, 4);
    write(file, &scale.Z, 4);

    // Rotation
    core::quaternion quat = joint->Animatedrotation;
    write(file, &quat.W, 4);
    write(file, &quat.X, 4);
    write(file, &quat.Y, 4);
    write(file, &quat.Z, 4);

    // Bone
    write(file, "BONE", 4);
    u32 bonesize = 8 * joint->Weights.size();
    write(file, &bonesize, 4);

    // Skinning ------------------
    for (u32 i = 0; i < joint->Weights.size(); i++)
    {
        const u32 vertexID = joint->Weights[i].vertex_id;
        const u32 bufferID = joint->Weights[i].buffer_id;
        const f32 weight = joint->Weights[i].strength;

        u32 b3dVertexID = vertexID;
        for (u32 j = 0; j < bufferID; j++)
        {
            b3dVertexID += mesh->getMeshBuffer(j)->getVertexCount();
        }

        write(file, &b3dVertexID, 4);
        write(file, &weight, 4);
    }
    // ---------------------------

    // Animation keys
    if (joint->PositionKeys.size())
    {
        write(file, "KEYS", 4);
        u32 keysSize = 4 * joint->PositionKeys.size() * 4; // X, Y and Z pos + frame
        keysSize += 4;  // Flag to define the type of the key
        write(file, &keysSize, 4);

        u32 flag = 1; // 1 = flag for position keys
        write(file, &flag, 4);

        for (u32 i = 0; i < joint->PositionKeys.size(); i++)
        {
            const s32 frame = static_cast<s32>(joint->PositionKeys[i].frame);
            const core::vector3df pos = joint->PositionKeys[i].position;

            write (file, &frame, 4);

            write (file, &pos.X, 4);
            write (file, &pos.Y, 4);
            write (file, &pos.Z, 4);

        }
    }
    if (joint->RotationKeys.size())
    {
        write(file, "KEYS", 4);
        u32 keysSize = 4 * joint->RotationKeys.size() * 5; // W, X, Y and Z rot + frame
        keysSize += 4; // Flag
        write(file, &keysSize, 4);

        u32 flag = 4;
        write(file, &flag, 4);

        for (u32 i = 0; i < joint->RotationKeys.size(); i++)
        {
            const s32 frame = static_cast<s32>(joint->RotationKeys[i].frame);
            const core::quaternion rot = joint->RotationKeys[i].rotation;

            write (file, &frame, 4);

            write (file, &rot.W, 4);
            write (file, &rot.X, 4);
            write (file, &rot.Y, 4);
            write (file, &rot.Z, 4);
        }
    }
    if (joint->ScaleKeys.size())
    {
        write(file, "KEYS", 4);
        u32 keysSize = 4 * joint->ScaleKeys.size() * 4; // X, Y and Z scale + frame
        keysSize += 4; // Flag
        write(file, &keysSize, 4);

        u32 flag = 2;
        write(file, &flag, 4);

        for (u32 i = 0; i < joint->ScaleKeys.size(); i++)
        {
            const s32 frame = static_cast<s32>(joint->ScaleKeys[i].frame);
            const core::vector3df scale = joint->ScaleKeys[i].scale;

            write (file, &frame, 4);

            write (file, &scale.X, 4);
            write (file, &scale.Y, 4);
            write (file, &scale.Z, 4);
        }
    }

    for (u32 i = 0; i < joint->Children.size(); i++)
    {
        writeJointChunk(file, mesh, joint->Children[i]);
    }
}


ISkinnedMesh* CB3DMeshWriter::getSkinned (IMesh *mesh)
{
	if (mesh->getMeshType() == EAMT_SKINNED)
    {
		return static_cast<ISkinnedMesh*>(mesh);
    }
    return 0;
}

u32 CB3DMeshWriter::getJointChunkSize(const ISkinnedMesh* mesh, ISkinnedMesh::SJoint* joint)
{
    u32 chunkSize = 8 + 40; // Chunk declaration + chunk data
    chunkSize += joint->Name.size() + 1; // the NULL character at the end of the string

    u32 boneSize = joint->Weights.size() * 8; // vertex_id + weight = 8 bits per weight block
    boneSize += 8; // declaration + size of he BONE chunk

    u32 keysSize = 0;
    if (joint->PositionKeys.size() != 0)
    {
        keysSize += 8; // KEYS + chunk size
        keysSize += 4; // flags

        keysSize += (joint->PositionKeys.size() * 16);
    }
    if (joint->RotationKeys.size() != 0)
    {
        keysSize += 8; // KEYS + chunk size
        keysSize += 4; // flags

        keysSize += (joint->RotationKeys.size() * 20);
    }
    if (joint->ScaleKeys.size() != 0)
    {
        keysSize += 8; // KEYS + chunk size
        keysSize += 4; // flags

        keysSize += (joint->ScaleKeys.size() * 16);
    }

    chunkSize += boneSize;
    chunkSize += keysSize;

    for (u32 i = 0; i < joint->Children.size(); ++i)
    {
        chunkSize += (getJointChunkSize(mesh, joint->Children[i]));
    }
    return chunkSize;
}

core::array<ISkinnedMesh::SJoint*> CB3DMeshWriter::getRootJoints(const ISkinnedMesh* mesh)
{
    core::array<ISkinnedMesh::SJoint*> roots;

    core::array<ISkinnedMesh::SJoint*> allJoints = mesh->getAllJoints();
    for (u32 i = 0; i < allJoints.size(); i++)
    {
        bool isRoot = true;
        ISkinnedMesh::SJoint* testedJoint = allJoints[i];
        for (u32 j = 0; j < allJoints.size(); j++)
        {
           ISkinnedMesh::SJoint* testedJoint2 = allJoints[j];
           for (u32 k = 0; k < testedJoint2->Children.size(); k++)
           {
               if (testedJoint == testedJoint2->Children[k])
                    isRoot = false;
           }
        }
        if (isRoot)
            roots.push_back(testedJoint);
    }

    return roots;
}

u32 CB3DMeshWriter::getUVlayerCount(IMesh* mesh)
{
    const u32 numBeshBuffers = mesh->getMeshBufferCount();
    for (u32 i = 0; i < numBeshBuffers; i++)
    {
        const IMeshBuffer * const mb = mesh->getMeshBuffer(i);

        if (mb->getVertexType() == EVT_2TCOORDS)
        {
            return 2;
        }
    }
    return 1;
}

void CB3DMeshWriter::write(io::IWriteFile* file, const void *ptr, const u32 bytes)
{
	file->write(ptr, bytes);
	Size += bytes;
}

} // end namespace
} // end namespace

#endif // _IRR_COMPILE_WITH_B3D_WRITER_

