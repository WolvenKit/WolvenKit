#ifndef IRRASSIMPEXPORT_H
#define IRRASSIMPEXPORT_H

#include <irrlicht.h>

#include <assimp/scene.h>          // Output data structure
#include <assimp/postprocess.h>    // Post processing flags
#include <assimp/Exporter.hpp>

#include "IrrAssimpUtils.h"

class IrrAssimpExport
{
    public:
        IrrAssimpExport();
        virtual ~IrrAssimpExport();
        void writeFile(irr::scene::IMesh* mesh, irr::core::stringc format, irr::core::stringc filename);

    protected:
    private:
        aiScene* AssimpScene;

        void createMeshes(irr::scene::IMesh* mesh);
        void createMaterials(const irr::scene::IMesh* mesh);
        void createAnimations(const irr::scene::ISkinnedMesh* mesh);
        aiNode* createNode(const irr::scene::ISkinnedMesh::SJoint* joint);
};

#endif // IRRASSIMPEXPORT_H
