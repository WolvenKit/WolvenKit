// Copyright (C) 2002-2020 by Jean-Louis Boudrand
// adapted to irrlicht by vonleebpl(at)gmail.com

#include "IrrCompileConfig.h"

//#define _IRR_COMPILE_WITH_W3ENT_LOADER_
#ifdef _IRR_COMPILE_WITH_W3ENT_LOADER_

#include "CW3Skeleton.h"

#include <iostream>

namespace irr
{
    namespace scene
    {
        CW3Skeleton::CW3Skeleton() : nbBones(0)
        {

        }

        //core::array<scene::ISkinnedMesh::SJoint*> getRootJoints(const scene::ISkinnedMesh* mesh);
        // Definition in IrrAssimpExport
        
        core::array<ISkinnedMesh::SJoint*> CW3Skeleton::getRootJoints(const scene::ISkinnedMesh* mesh)
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
        

        scene::ISkinnedMesh::SJoint* getRealParent(const scene::ISkinnedMesh* mesh, scene::ISkinnedMesh::SJoint* joint)
        {
            core::array<scene::ISkinnedMesh::SJoint*> allJoints = mesh->getAllJoints();
            for (u32 j = 0; j < allJoints.size(); j++)
            {
                scene::ISkinnedMesh::SJoint* testedJoint = allJoints[j];
                for (u32 k = 0; k < testedJoint->Children.size(); k++)
                {
                    if (joint == testedJoint->Children[k])
                        return testedJoint;
                }
            }

            return nullptr;
        }


        void computeLocal(const scene::ISkinnedMesh* mesh, scene::ISkinnedMesh::SJoint* joint)
        {
            // Parent bone is necessary to compute the local matrix from global
            scene::ISkinnedMesh::SJoint* jointParent = getRealParent(mesh, joint);

            if (jointParent)
            {
                irr::core::matrix4 globalParent = jointParent->GlobalMatrix;
                irr::core::matrix4 invGlobalParent;
                globalParent.getInverse(invGlobalParent);

                joint->LocalMatrix = invGlobalParent * joint->GlobalMatrix;
            }
            else
                joint->LocalMatrix = joint->GlobalMatrix;
        }

        void computeGlobal(const scene::ISkinnedMesh* mesh, scene::ISkinnedMesh::SJoint* joint)
        {
            scene::ISkinnedMesh::SJoint* parent = getRealParent(mesh, joint);
            if (parent)
                joint->GlobalMatrix = parent->GlobalMatrix * joint->LocalMatrix;
            else
                joint->GlobalMatrix = joint->LocalMatrix;

            for (u32 i = 0; i < joint->Children.size(); ++i)
            {
                computeGlobal(mesh, joint->Children[i]);
            }
        }

        ISkinnedMesh::SJoint* getJointByName(scene::ISkinnedMesh* mesh, core::stringc name)
        {
            //std::cout << "count= " << mesh->getJointCount() << std::endl;
            //for (u32 i = 0; i < mesh->getJointCount(); ++i)
            //    std::cout << mesh->getAllJoints()[i]->Name.c_str() << std::endl;

            s32 jointID = mesh->getJointNumber(name.c_str());
            if (jointID == -1)
                return nullptr;

            return mesh->getAllJoints()[(u32)(jointID)];
        }


        bool CW3Skeleton::applyToModel(scene::ISkinnedMesh* mesh)
        {
            // Create the bones
            for (u32 i = 0; i < nbBones; ++i)
            {
                core::stringc boneName = names[i];
                scene::ISkinnedMesh::SJoint* joint = getJointByName(mesh, boneName);
                if (!joint)
                {
                    joint = mesh->addJoint();
                    joint->Name = boneName;
                }
            }

            // Set the hierarchy
            for (u32 i = 0; i < nbBones; ++i)
            {
                short parent = parentId[i];
                if (parent != -1) // root
                {
                    scene::ISkinnedMesh::SJoint* parentJoint = getJointByName(mesh, names[parent]);
                    if (parentJoint != nullptr)
                        parentJoint->Children.push_back(mesh->getAllJoints()[i]);
                }
            }

            // Set the transformations
            for (u32 i = 0; i < nbBones; ++i)
            {
                core::stringc boneName = names[i];

                scene::ISkinnedMesh::SJoint* joint = getJointByName(mesh, boneName);
                if (!joint)
                    continue;

                core::matrix4 mat = matrix[i];
                joint->LocalMatrix = mat;

                joint->Animatedposition = positions[i];
                joint->Animatedrotation = rotations[i];
                joint->Animatedscale = scales[i];
            }

            // Compute the global matrix

            core::array<scene::ISkinnedMesh::SJoint*> roots = this->getRootJoints(mesh);
            for (u32 i = 0; i < roots.size(); ++i)
            {
                computeGlobal(mesh, roots[i]);
            }
   
            return true;
        }
    }
}
#endif