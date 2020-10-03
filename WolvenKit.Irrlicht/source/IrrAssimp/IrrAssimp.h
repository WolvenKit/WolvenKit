#ifndef IRRASSIMP_H
#define IRRASSIMP_H

#include <irrlicht.h>
#include "IrrAssimpExport.h"
#include "IrrAssimpImport.h"

class ExportFormat
{
    public:
    irr::core::stringc FileExtension;
    irr::core::stringc Id;
    irr::core::stringc Description;

    ExportFormat(irr::core::stringc fileExtension, irr::core::stringc id, irr::core::stringc description)
    : FileExtension(fileExtension), Id(id), Description(description) {}
};

class IrrAssimp
{
    public:
        explicit IrrAssimp(irr::scene::ISceneManager* smgr);
        virtual ~IrrAssimp();


        /*  Get a mesh with Assimp.
            Like ISceneManager::getMesh, check if the mesh is already in the MeshCache, and if it's not the case, Assimp load it.
        */
        irr::scene::IAnimatedMesh* getMesh(const irr::io::path& path);


        /*  Export a mesh.
            The "format" parameter correspond to the Assimp format ID.
            You can get the list via getExportFormats, or for Assimp 3.1.1, you can use the followings :
            - "collada" for the Collada export
            - "obj" for Wavefront OBJ
            - "stl" for STL
            - "stlb" for STL in binary mode
            - and "ply" for the PLY format
        */
        void exportMesh(irr::scene::IMesh* mesh, irr::core::stringc format, irr::core::stringc path);

        // Return the error of the last loading. Return an empty string if no error.
        irr::core::stringc getError();


        // Check if the file has a loadable extension
        bool isLoadable(irr::io::path path);

        // Return the list of available export formats
        static irr::core::array<ExportFormat> getExportFormats();

    private:
		irr::scene::ISceneManager* Smgr;
        irr::scene::IMeshCache* Cache;
        irr::io::IFileSystem* FileSystem;

        IrrAssimpImport Importer;
        IrrAssimpExport Exporter;

};

#endif // IRRASSIMP_H
