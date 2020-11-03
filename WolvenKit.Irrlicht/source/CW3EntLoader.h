// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// Copyright (C) 2002-2020 by Jean-Louis Boudrand
// adapted to irrlicht by vonleebpl(at)gmail.com

#ifndef __C_W3ENT_LOADER_H_INCLUDED__
#define __C_W3ENT_LOADER_H_INCLUDED__

#include <list>
#include "IMeshLoader.h"
#include "irrString.h"
#include "SMesh.h"
#include "SAnimatedMesh.h"
#include "IMeshManipulator.h"
#include "ISkinnedMesh.h"

#include "CW3Skeleton.h"
#include "CW3DataCache.h"
#include "CW3Animation.h"
#include "Utils_RedEngine.h"
#include "MeshCombiner.h"
#include "CSceneManagerWolvenKit.h"


namespace irr
{

namespace io
{
    class IFileSystem;
    class IReadFile;
} // end namespace io
namespace scene
{
    enum EMeshVertexType
    {
        EMVT_STATIC,
        EMVT_SKINNED
    };

    // Information to load a mesh from the buffer
    struct SMeshInfos
    {
        SMeshInfos() : numVertices(0), numIndices(0), numBonesPerVertex(4), firstVertex(0), firstIndice(0), vertexType(EMVT_STATIC), materialID(0){}

        u32 numVertices;
        u32 numIndices;
        u32 numBonesPerVertex;

        u32 firstVertex;
        u32 firstIndice;

        EMeshVertexType vertexType;

        u32 materialID;
    };

    // Informations about the .buffer file
    struct SVertexBufferInfos
    {
        SVertexBufferInfos() : verticesCoordsOffset(0), uvOffset(0), normalsOffset(0), indicesOffset(0), nbVertices(0), nbIndices(0), lod(1){}

        u32 verticesCoordsOffset;
        u32 uvOffset;
        u32 normalsOffset;
        u32 indicesOffset;
        u16 nbVertices;
        u32 nbIndices;
        u8 lod;
    };

    struct SBufferInfos
    {
        SBufferInfos() : verticesBufferOffset(0), verticesBufferSize(0), indicesBufferOffset(0), indicesBufferSize(0),
            quantizationScale(core::vector3df(1, 1, 1)), quantizationOffset(core::vector3df(0, 0, 0)), verticesBuffer(core::array<SVertexBufferInfos>()){}

        u32 verticesBufferOffset;
        u32 verticesBufferSize;
        u32 indicesBufferOffset;
        u32 indicesBufferSize;

        core::vector3df quantizationScale;
        core::vector3df quantizationOffset;

        core::array<SVertexBufferInfos> verticesBuffer;
    };

    struct SPropertyHeader
    {
        core::stringc propName;
        core::stringc propType;
        s32 propSize;
        u32 endPos;
    };


    struct W3_DataInfos
    {
        s32 adress;
        s32 size;
    };

    class IMeshManipulator;

    //! Meshloader capable of loading w2ent meshes.
    class CW3EntLoader : public IMeshLoader
    {
    public:

        //! Constructor
        CW3EntLoader(scene::ISceneManager* smgr, io::IFileSystem* fs);

        //! Destructor
        ~CW3EntLoader();

        //! returns true if the file maybe is able to be loaded by this class
        //! based on the file extension (e.g. ".cob")
        virtual bool isALoadableFileExtension(const io::path& filename) const;

        //! creates/loads an animated mesh from the file.
        //! \return Pointer to the created mesh. Returns 0 if loading failed.
        //! If you no longer need the mesh, you should call IAnimatedMesh::drop().
        //! See IReferenceCounted::drop() for more information.
        virtual IAnimatedMesh* createMesh(io::IReadFile* file);
        video::SMaterial createMaterial(io::IReadFile* file);
        IMesh* createStaticMesh(io::IReadFile* file);

        core::array<video::SMaterial> Materials;
        CW3Skeleton Skeleton;
        scene::ISkinnedMesh* meshToAnimate;

        std::list<SW3Animation*> Animations() { return _animations; };

    private:

        std::list<SW3Animation*> _animations;

        scene::ISceneManager* _sceneManager;
        io::IFileSystem* _fileSystem;
        video::IVideoDriver* _videoDriver;

        scene::ISkinnedMesh* _animatedMesh;
        core::array<scene::ISkinnedMesh*> Meshes;

        scene::SMesh* _staticMesh;
        core::array<scene::SMesh*> _staticMeshes;


        // Strings table
        core::array<core::stringc> Strings;
        // Files table
        core::array<core::stringc> Files;

        u32 NbBonesPos;
        u32 FrameOffset;

        bool ConfigLoadSkeleton;
        bool ConfigLoadOnlyBestLOD;
        bool IsStaticMesh;
        io::path ConfigGameTexturesPath;
        io::path ConfigGamePath;


        // Main function
        bool load(io::IReadFile* file);

        // load the different types of data
        bool W3_load(io::IReadFile* file);
        void W3_CMesh(io::IReadFile* file, W3_DataInfos infos);
        video::SMaterial W3_CMaterialInstance(io::IReadFile* file, W3_DataInfos infos);
        void W3_CMeshComponent(io::IReadFile* file, W3_DataInfos infos);
        void W3_CEntityTemplate(io::IReadFile* file, W3_DataInfos infos);   // Not handled yet
        void W3_CEntity(io::IReadFile* file, W3_DataInfos infos);           // Not handled yet
        CW3Skeleton W3_CSkeleton(io::IReadFile* file, W3_DataInfos infos);
        void W3_CAnimationBufferBitwiseCompressed(io::IReadFile* file, W3_DataInfos infos, u32 animIdx);
        void W3_CSkeletalAnimation(io::IReadFile* file, W3_DataInfos infos);
        video::SMaterial W3_CMaterialGraph(io::IReadFile* file, W3_DataInfos infos);
        void W3_CUnknown(io::IReadFile* file, W3_DataInfos infos);

        // load a mesh buffer from the buffer file
        bool W3_ReadBuffer(io::IReadFile* file, SBufferInfos bufferInfos, SMeshInfos meshInfos);
        bool W3_ReadBufferStatic(io::IReadFile* file, SBufferInfos bufferInfos, SMeshInfos meshInfos);

        // animation helper functions
        SAnimationBufferBitwiseCompressedData ReadSAnimationBufferBitwiseCompressedDataProperty(io::IReadFile* file);
        SAnimationBufferOrientationCompressionMethod ReadAnimationBufferOrientationCompressionMethodProperty(io::IReadFile* file);
        core::array<core::array<SAnimationBufferBitwiseCompressedData> > ReadSAnimationBufferBitwiseCompressedBoneTrackProperty(io::IReadFile* file);
        void readAnimBuffer(    core::array<core::array<SAnimationBufferBitwiseCompressedData> >& inf,
                                io::IReadFile* dataFile,
                                SAnimationBufferOrientationCompressionMethod c,
                                u32 animIdx);
        
        SW3Animation* CW3EntLoader::getAnimationByIdx(int idx);


        void ReadBones(io::IReadFile* file);

        video::ITexture* getTexture(io::path filename);
        int getTextureLayerFromTextureType(core::stringc textureType);

        core::stringc searchParent(core::stringc bonename);

        // To read the properties
        bool ReadPropertyHeader(io::IReadFile* file, SPropertyHeader& propHeader);
        bool ReadPropertyHeader(io::IReadFile* file, SPropertyHeader& propHeader, u16& extra);

        SBufferInfos ReadSMeshCookedDataProperty(io::IReadFile* file);
        core::array<SMeshInfos> ReadSMeshChunkPackedProperty(io::IReadFile* file);

        void ReadUnknowProperty(io::IReadFile* file);
        EMeshVertexType ReadEMVTProperty(io::IReadFile* file);
        
        void ReadRenderChunksProperty(io::IReadFile* file, SBufferInfos* buffer);
        void ReadMaterialsProperty(io::IReadFile* file);
        video::SMaterial ReadIMaterialProperty(io::IReadFile* file, bool& valid);
        core::array<core::vector3df> ReadBonesPosition(io::IReadFile* file);
        void ReadRenderLODSProperty(io::IReadFile* file);

        // read external files
        video::SMaterial ReadMaterialFile(core::stringc filename);
        video::SMaterial ReadW2MIFile(core::stringc filename);
        video::SMaterial ReadW2MGFile(core::stringc filename);
        ISkinnedMesh* ReadW2MESHFile(core::stringc filename);

        void computeLocal(ISkinnedMesh::SJoint* joint);

        bool checkBones(io::IReadFile* file, char nbBones);

        // debug log
        //Log* log;
        void writeLogBoolProperty(core::stringc name, bool value);
        void writeLogHeader(const io::IReadFile* f);

        

    };

} // end namespace scene
} // end namespace irr

#endif
