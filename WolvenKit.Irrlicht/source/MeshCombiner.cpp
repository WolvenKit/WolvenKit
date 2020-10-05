// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// Copyright (C) 2002-2020 by Jean-Louis Boudrand
// adapted to irrlicht by vonleebpl(at)gmail.com

#include "IrrCompileConfig.h"

//#define _IRR_COMPILE_WITH_W3ENT_LOADER_
#ifdef _IRR_COMPILE_WITH_W3ENT_LOADER_

#include "MeshCombiner.h"

namespace irr
{
    namespace scene
    {

        scene::ISkinnedMesh* copySkinnedMesh(scene::ISceneManager* smgr, scene::IMesh* meshToCopy, bool preserveBones)
        {
            if (!meshToCopy)
                return nullptr;

            scene::ISkinnedMesh* clone = smgr->createSkinnedMesh();
            combineMeshes(clone, meshToCopy, preserveBones);

            return clone;
            /*
            scene::ISkinnedMesh* newMesh = Smgr->createSkinnedMesh();

            for (u32 i = 0; i < meshToCopy->getMeshBufferCount(); ++i)
            {
                scene::SSkinMeshBuffer* buffer = newMesh->addMeshBuffer();
                (*buffer) = (*(scene::SSkinMeshBuffer*)meshToCopy->getMeshBuffer(i));
            }
            */
            /*
            for (u32 i = 0; i < meshToCopy->getJointCount(); ++i)
            {
                scene::ISkinnedMesh::SJoint* joint = newMesh->addJoint();
                (*joint) = *(meshToCopy->getAllJoints()[i]);
            }
            */
        }

        // Clones a static IMesh into a modifiable SMesh.
        // not yet 32bit
        void combineMeshes(scene::ISkinnedMesh* newMesh, scene::IMesh* addition, bool preserveBones)
        {
            if (!newMesh || !addition)
                return;

            const u32 sourceMeshBufferCount = newMesh->getMeshBufferCount();
            const u32 meshBufferCount = addition->getMeshBufferCount();
            for (u32 b = 0; b < meshBufferCount; ++b)
            {
                const scene::IMeshBuffer* const mb = addition->getMeshBuffer(b);
                switch (mb->getVertexType())
                {
                case video::EVT_STANDARD:
                {
                    scene::SSkinMeshBuffer* buffer = newMesh->addMeshBuffer();
                    buffer->VertexType = video::EVT_STANDARD;

                    buffer->Material = mb->getMaterial();
                    const u32 vcount = mb->getVertexCount();
                    buffer->Vertices_Standard.reallocate(vcount);
                    video::S3DVertex* vertices = (video::S3DVertex*)mb->getVertices();
                    for (u32 i = 0; i < vcount; ++i)
                        buffer->Vertices_Standard.push_back(vertices[i]);
                    const u32 icount = mb->getIndexCount();
                    buffer->Indices.reallocate(icount);
                    const u16* indices = mb->getIndices();
                    for (u32 i = 0; i < icount; ++i)
                        buffer->Indices.push_back(indices[i]);
                }
                break;
                case video::EVT_2TCOORDS:
                {
                    scene::SSkinMeshBuffer* buffer = newMesh->addMeshBuffer();
                    buffer->VertexType = video::EVT_2TCOORDS;

                    buffer->Material = mb->getMaterial();
                    const u32 vcount = mb->getVertexCount();
                    buffer->Vertices_2TCoords.reallocate(vcount);
                    video::S3DVertex2TCoords* vertices = (video::S3DVertex2TCoords*)mb->getVertices();
                    for (u32 i = 0; i < vcount; ++i)
                        buffer->Vertices_2TCoords.push_back(vertices[i]);
                    const u32 icount = mb->getIndexCount();
                    buffer->Indices.reallocate(icount);
                    const u16* indices = mb->getIndices();
                    for (u32 i = 0; i < icount; ++i)
                        buffer->Indices.push_back(indices[i]);
                }
                break;
                case video::EVT_TANGENTS:
                {
                    scene::SSkinMeshBuffer* buffer = newMesh->addMeshBuffer();
                    buffer->VertexType = video::EVT_TANGENTS;

                    buffer->Material = mb->getMaterial();
                    const u32 vcount = mb->getVertexCount();
                    buffer->Vertices_Tangents.reallocate(vcount);
                    video::S3DVertexTangents* vertices = (video::S3DVertexTangents*)mb->getVertices();
                    for (u32 i = 0; i < vcount; ++i)
                        buffer->Vertices_Tangents.push_back(vertices[i]);
                    const u32 icount = mb->getIndexCount();
                    buffer->Indices.reallocate(icount);
                    const u16* indices = mb->getIndices();
                    for (u32 i = 0; i < icount; ++i)
                        buffer->Indices.push_back(indices[i]);
                }
                break;
                }// end switch

            }// end for all mesh buffers

            newMesh->setBoundingBox(addition->getBoundingBox());

            if (addition->getMeshType() != scene::EAMT_SKINNED || !preserveBones)
                return;

            scene::ISkinnedMesh* skinnedMesh = static_cast<scene::ISkinnedMesh*>(addition);
            const u32 meshSourceJointCount = newMesh->getJointCount();
            const u32 jointCount = skinnedMesh->getJointCount();
            for (u32 j = 0; j < jointCount; ++j)
            {
                const scene::ISkinnedMesh::SJoint* const joint = skinnedMesh->getAllJoints()[j];
                scene::ISkinnedMesh::SJoint* jointClone = newMesh->addJoint();
                jointClone->Name = joint->Name;
                jointClone->Animatedposition = joint->Animatedposition;
                jointClone->Animatedrotation = joint->Animatedrotation;
                jointClone->Animatedscale = joint->Animatedscale;
                jointClone->AttachedMeshes = joint->AttachedMeshes;

                jointClone->GlobalMatrix = joint->GlobalMatrix;
                jointClone->LocalMatrix = joint->LocalMatrix;

                jointClone->PositionKeys = joint->PositionKeys;
                jointClone->RotationKeys = joint->RotationKeys;
                jointClone->ScaleKeys = joint->ScaleKeys;
                for (u32 w = 0; w < joint->Weights.size(); ++w)
                {
                    const scene::ISkinnedMesh::SWeight weight = joint->Weights[w];
                    scene::ISkinnedMesh::SWeight* weightClone = newMesh->addWeight(jointClone);
                    weightClone->buffer_id = weight.buffer_id + sourceMeshBufferCount;
                    weightClone->strength = weight.strength;
                    weightClone->vertex_id = weight.vertex_id;
                }
            }
            // Add children
            for (u32 j = 0; j < jointCount; ++j)
            {
                const scene::ISkinnedMesh::SJoint* const joint = skinnedMesh->getAllJoints()[j];
                scene::ISkinnedMesh::SJoint* jointClone = newMesh->getAllJoints()[meshSourceJointCount + j];
                for (u32 c = 0; c < joint->Children.size(); ++c)
                {
                    jointClone->Children.push_back(newMesh->getAllJoints()[newMesh->getJointNumber(joint->Children[c]->Name.c_str())]);
                }
            }


            /*
            const u32 bufferIdOffset = newMesh->getMeshBufferCount();
            for (u32 i = 0; i < addition->getMeshBufferCount(); ++i)
            {
                scene::SSkinMeshBuffer* buffer = newMesh->addMeshBuffer();
                (*buffer) = (*(scene::SSkinMeshBuffer*)addition->getMeshBuffer(i));
            }

            for (u32 i = 0; i < addition->getJointCount(); ++i)
            {
                const scene::ISkinnedMesh::SJoint* jointToCopy = addition->getAllJoints()[i];
                scene::ISkinnedMesh::SJoint* joint = 0;
                if (newMesh->getJointNumber(jointToCopy->Name.c_str()) == -1)
                {
                    joint = newMesh->addJoint();
                    (*joint) = (*jointToCopy);

                    for (u32 j = 0; j < joint->Weights.size(); ++j)
                    {
                        joint->Weights[j].buffer_id += bufferIdOffset;
                    }
                }
                else
                {
                    joint = newMesh->getAllJoints()[newMesh->getJointNumber(jointToCopy->Name.c_str())];
                    for (u32 j = 0; j < jointToCopy->Weights.size(); ++j)
                    {
                        scene::ISkinnedMesh::SWeight* w = newMesh->addWeight(joint);
                        (*w) = jointToCopy->Weights[j];
                        w->buffer_id += bufferIdOffset;
                    }
                }


            }
            */
        }

        void combineMeshes(scene::SMesh* newMesh, scene::SMesh* addition)
        {
            if (!newMesh || !addition)
                return;

            const u32 sourceMeshBufferCount = newMesh->getMeshBufferCount();
            const u32 meshBufferCount = addition->getMeshBufferCount();
            for (u32 b = 0; b < meshBufferCount; ++b)
            {
                const scene::IMeshBuffer* const mb = addition->getMeshBuffer(b);
                switch (mb->getVertexType())
                {
                case video::EVT_STANDARD:
                {
                    scene::SSkinMeshBuffer *buffer = new scene::SSkinMeshBuffer();
                    buffer->VertexType = video::EVT_STANDARD;

                    buffer->Material = mb->getMaterial();
                    const u32 vcount = mb->getVertexCount();
                    buffer->Vertices_Standard.reallocate(vcount);
                    video::S3DVertex* vertices = (video::S3DVertex*)mb->getVertices();
                    for (u32 i = 0; i < vcount; ++i)
                        buffer->Vertices_Standard.push_back(vertices[i]);
                    const u32 icount = mb->getIndexCount();
                    buffer->Indices.reallocate(icount);
                    const u16* indices = mb->getIndices();
                    for (u32 i = 0; i < icount; ++i)
                        buffer->Indices.push_back(indices[i]);

                    newMesh->addMeshBuffer(buffer);
                }
                break;
                case video::EVT_2TCOORDS:
                {
                    scene::SSkinMeshBuffer *buffer = new scene::SSkinMeshBuffer();
                    buffer->VertexType = video::EVT_2TCOORDS;

                    buffer->Material = mb->getMaterial();
                    const u32 vcount = mb->getVertexCount();
                    buffer->Vertices_2TCoords.reallocate(vcount);
                    video::S3DVertex2TCoords* vertices = (video::S3DVertex2TCoords*)mb->getVertices();
                    for (u32 i = 0; i < vcount; ++i)
                        buffer->Vertices_2TCoords.push_back(vertices[i]);
                    const u32 icount = mb->getIndexCount();
                    buffer->Indices.reallocate(icount);
                    const u16* indices = mb->getIndices();
                    for (u32 i = 0; i < icount; ++i)
                        buffer->Indices.push_back(indices[i]);

                    newMesh->addMeshBuffer(buffer);
                }
                break;
                case video::EVT_TANGENTS:
                {
                    scene::SSkinMeshBuffer *buffer = new scene::SSkinMeshBuffer();
                    buffer->VertexType = video::EVT_TANGENTS;

                    buffer->Material = mb->getMaterial();
                    const u32 vcount = mb->getVertexCount();
                    buffer->Vertices_Tangents.reallocate(vcount);
                    video::S3DVertexTangents* vertices = (video::S3DVertexTangents*)mb->getVertices();
                    for (u32 i = 0; i < vcount; ++i)
                        buffer->Vertices_Tangents.push_back(vertices[i]);
                    const u32 icount = mb->getIndexCount();
                    buffer->Indices.reallocate(icount);
                    const u16* indices = mb->getIndices();
                    for (u32 i = 0; i < icount; ++i)
                        buffer->Indices.push_back(indices[i]);

                    newMesh->addMeshBuffer(buffer);
                }
                break;
                }// end switch

            }// end for all mesh buffers

            newMesh->setBoundingBox(addition->getBoundingBox());
        }

    }
}
#endif