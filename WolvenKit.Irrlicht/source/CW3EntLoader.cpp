// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h
// Copyright (C) 2002-2020 by Jean-Louis Boudrand
// adapted to irrlicht by vonleebpl(at)gmail.com

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_W3ENT_LOADER_

#include "CW3EntLoader.h"
#include "CW3MeshLoaderHelper.h"
#include "CMeshTextureLoader.h"
#include "ISceneManager.h"
#include "IVideoDriver.h"
#include "IFileSystem.h"
#include "IReadFile.h"
#include "IWriteFile.h"

#include "Utils_Halffloat.h"
#include "Utils_Loaders_Irr.h"

#include "os.h"
#include "debug.h"

namespace irr
{
namespace scene
{

//! Constructor
CW3EntLoader::CW3EntLoader(scene::ISceneManager* smgr, io::IFileSystem* fs)
    : meshToAnimate(nullptr),
    _sceneManager(smgr),
    _fileSystem(fs),
    _videoDriver(smgr->getVideoDriver()),
    _animatedMesh(nullptr),
    _staticMesh(nullptr),
    FrameOffset(0),
    ConfigLoadSkeleton(true),
    ConfigLoadOnlyBestLOD(false),
    IsStaticMesh(false)
{
	#ifdef _DEBUG
    setDebugName("CW3ENTLoader");
	#endif

    TextureLoader = DBG_NEW CMeshTextureLoader(_fileSystem, _videoDriver);
    LoaderHelper = DBG_NEW CW3MeshLoaderHelper(this, _sceneManager, _fileSystem);
}

CW3EntLoader::~CW3EntLoader()
{
    _fileSystem = nullptr;
    _sceneManager = nullptr;
    _videoDriver = nullptr;

    Strings.clear();
    Materials.clear();
    Files.clear();
    Meshes.clear();
   
    //LoaderHelper and textureLoader are destructed in base class
}


//! returns true if the file maybe is able to be loaded by this class
//! based on the file extension (e.g. ".bsp")
bool CW3EntLoader::isALoadableFileExtension(const io::path& filename) const
{
    io::IReadFile* file = _sceneManager->getFileSystem()->createAndOpenFile(filename);
    if (!file)
        return false;

    bool checkIsLoadable = (getRedEngineFileType(file) == REV_WITCHER_3);
    file->drop();

    return checkIsLoadable;
}


//! creates/loads an animated mesh from the file.
//! \return Pointer to the created mesh. Returns 0 if loading failed.
//! If you no longer need the mesh, you should call IAnimatedMesh::drop().
//! See IReferenceCounted::drop() for more information.
IAnimatedMesh* CW3EntLoader::createMesh(io::IReadFile* f)
{
	if (!f)
        return nullptr;

    IsStaticMesh = false;

    #ifdef _IRR_WCHAR_FILESYSTEM
        ConfigGamePath = _sceneManager->getParameters()->getAttributeAsStringW("TW_GAME_PATH");
        ConfigGameTexturesPath = _sceneManager->getParameters()->getAttributeAsStringW("TW_TW3_TEX_PATH");
    #else
        ConfigGamePath = SceneManager->getParameters()->getAttributeAsString("TW_GAME_PATH");
        ConfigGameTexturesPath = SceneManager->getParameters()->getAttributeAsString("TW_TW3_TEX_PATH");
    #endif

    //ConfigLoadSkeleton = _sceneManager->getParameters()->getAttributeAsBool("TW_TW3_LOAD_SKEL");
    //ConfigLoadOnlyBestLOD = _sceneManager->getParameters()->getAttributeAsBool("TW_TW3_LOAD_BEST_LOD_ONLY");

    //Clear up
    Strings.clear();
    Materials.clear();
    Files.clear();
    Meshes.clear();
    _animations.clear();

    writeLogHeader(f);
    os::Printer::log("Start loading", f->getFileName().c_str(), ELL_DEBUG);


    _animatedMesh = _sceneManager->createSkinnedMesh();

	if (load(f))
	{
        _animatedMesh->finalize();
	}
	else
	{
		_animatedMesh->drop();
        _animatedMesh = nullptr;
	}

    os::Printer::log("LOADING FINISHED", ELL_DEBUG);
    //SceneManager->getParameters()->setAttribute("TW_FEEDBACK", Feedback.c_str());

	return _animatedMesh;
}

video::SMaterial CW3EntLoader::createMaterial(io::IReadFile* f)
{
    video::SMaterial material;

    if (!f)
    {
        return material;
    }

#ifdef _IRR_WCHAR_FILESYSTEM
    ConfigGamePath = _sceneManager->getParameters()->getAttributeAsStringW("TW_GAME_PATH");
    ConfigGameTexturesPath = _sceneManager->getParameters()->getAttributeAsStringW("TW_TW3_TEX_PATH");
#else
    ConfigGamePath = SceneManager->getParameters()->getAttributeAsString("TW_GAME_PATH");
    ConfigGameTexturesPath = SceneManager->getParameters()->getAttributeAsString("TW_TW3_TEX_PATH");
#endif

    //Clear up
    Strings.clear();
    Materials.clear();
    Files.clear();
    Meshes.clear();
    _animations.clear();

    writeLogHeader(f);
    os::Printer::log("Start loading", f->getFileName().c_str(), ELL_DEBUG);

    if (load(f))
    {
        return Materials[0];
    }

    os::Printer::log("LOADING FINISHED", ELL_DEBUG);

    return material;
}

IMesh* CW3EntLoader::createStaticMesh(io::IReadFile* f)
{
    if (!f)
        return nullptr;

    IsStaticMesh = true;
#ifdef _IRR_WCHAR_FILESYSTEM
    ConfigGamePath = _sceneManager->getParameters()->getAttributeAsStringW("TW_GAME_PATH");
    ConfigGameTexturesPath = _sceneManager->getParameters()->getAttributeAsStringW("TW_TW3_TEX_PATH");
#else
    ConfigGamePath = SceneManager->getParameters()->getAttributeAsString("TW_GAME_PATH");
    ConfigGameTexturesPath = SceneManager->getParameters()->getAttributeAsString("TW_TW3_TEX_PATH");
#endif

    //Clear up
    Strings.clear();
    Materials.clear();
    Files.clear();
    Meshes.clear();

    writeLogHeader(f);
    os::Printer::log("Start loading", f->getFileName().c_str(), ELL_DEBUG);

    _staticMesh = DBG_NEW SMesh();

    if (!load(f))
    {
        _staticMesh->drop();
        _staticMesh = nullptr;
    }

    os::Printer::log("LOADING FINISHED", ELL_DEBUG);

    _staticMesh->recalculateBoundingBox();
    return _staticMesh;

}

void CW3EntLoader::writeLogBoolProperty(core::stringc name, bool value)
{
    os::Printer::log((formatString("-> %s is %s", name.c_str(), value?"enabled":"disabled")).c_str(), ELL_DEBUG);
}

void CW3EntLoader::writeLogHeader(const io::IReadFile* f)
{
#ifdef _DEBUG

    os::Printer::log("", ELL_DEBUG);
    os::Printer::log((formatString("-> File : %s", f->getFileName().c_str())).c_str(), ELL_DEBUG);

    writeLogBoolProperty("Load Skeleton", ConfigLoadSkeleton);
    writeLogBoolProperty("Load only best LOD", ConfigLoadOnlyBestLOD);

    os::Printer::log("_________________________________________________________\n\n\n", ELL_DEBUG);

#endif // _DEBUG
}


bool CW3EntLoader::W3_load(io::IReadFile* file)
{
    RedEngineFileHeader header;
    loadTW3FileHeader(file, header);
    Strings = header.Strings;
    Files = header.Files;

    //log->addLineAndFlush("Read strings and files");
    os::Printer::log("Read strings and files", ELL_DEBUG);


    file->seek(12);
    core::array<s32> headerData = readDataArray<s32>(file, 38);
    s32 contentChunkStart = headerData[19];
    s32 contentChunkSize = headerData[20];

    core::array<W3_DataInfos> meshes;
    file->seek(contentChunkStart);
    for (s32 i = 0; i < contentChunkSize; ++i)
    {
        W3_DataInfos infos;
        u16 dataType = readU16(file);
        core::stringc dataTypeName = Strings[dataType];

        os::Printer::log((formatString("dataTypeName=%s", dataTypeName.c_str())).c_str(), ELL_DEBUG);

        file->seek(6, true);

        file->read(&infos.size, 4);
        file->read(&infos.adress, 4);
        //std::cout << "begin at " << infos.adress << " and end at " << infos.adress + infos.size << std::endl;

        file->seek(8, true);

        s32 back = file->getPos();
        if (dataTypeName == "CMesh")
        {
            meshes.push_back(infos);
            //W3_CMesh(file, infos);
            os::Printer::log("Mesh found", ELL_DEBUG);
        }
        else if (dataTypeName == "CMaterialInstance")
        {
            os::Printer::log("Material found", ELL_DEBUG);

            video::SMaterial mat = W3_CMaterialInstance(file, infos);
            os::Printer::log("Material loaded", ELL_DEBUG);
            Materials.push_back(mat);

            //W3_CMaterialInstances(file, infos);
            //os::Printer::log("Added to mat list", ELL_DEBUG);
        }
        else if (dataTypeName == "CEntityTemplate")
        {
            W3_CEntityTemplate(file, infos);
        }
        else if (dataTypeName == "CEntity")
        {
            W3_CEntity(file, infos);
        }
        else if (dataTypeName == "CMeshComponent")
        {
            W3_CMeshComponent(file, infos);
        }
        else if (dataTypeName == "CSkeleton")
        {
            W3_CSkeleton(file, infos);
        }
        else if (dataTypeName == "CAnimationBufferBitwiseCompressed" && meshToAnimate)
        {
            SW3Animation* anim = getAnimationByIdx(i+1);
            if (anim)
                W3_CAnimationBufferBitwiseCompressed(file, infos, u32(i+1));
        }
        else if (dataTypeName == "CSkeletalAnimation")
        { 
            W3_CSkeletalAnimation(file, infos);
        }
        else
        {
            W3_CUnknown(file, infos);
        }
        file->seek(back);
    }

    // BUG: clean cache before reading mesh, static classes should not keep data stored
    if (meshes.size() > 0)
    {
        CW3DataCache::_instance.clear();
    }
    for (u32 i = 0; i < meshes.size(); ++i)
    {
        os::Printer::log("Loading mesh...", ELL_DEBUG);
        W3_CMesh(file, meshes[i]);
        os::Printer::log("done", ELL_DEBUG);
    }

    return true;
}
SW3Animation* CW3EntLoader::getAnimationByIdx(int idx)
{
    for (auto i : _animations)
    {
        if (i->chunkIdx == idx)
            return i;
    }
    return 0;
}

void CW3EntLoader::W3_CSkeletalAnimation(io::IReadFile* file, W3_DataInfos infos)
{
    file->seek(infos.adress + 1);
    os::Printer::log("W3_CSkeletalAnimation", ELL_DEBUG);

    float duration, fps;
    int animBuffer;
    core::stringc name;

    while (1)
    {
        SPropertyHeader propHeader;
        if (!ReadPropertyHeader(file, propHeader))
            break;

        if (propHeader.propName == "name") // it's CName
            name = Strings[readU16(file)];
        if (propHeader.propName == "animBuffer")
            animBuffer = readU32(file);
        if (propHeader.propName == "framesPerSecond")
            fps = readF32(file);
        if (propHeader.propName == "duration")
            duration = readF32(file);

        file->seek(propHeader.endPos);
    }

    _animations.push_back(DBG_NEW SW3Animation(name, animBuffer, fps, duration));
}

bool CW3EntLoader::W3_ReadBuffer(io::IReadFile* file, SBufferInfos bufferInfos, SMeshInfos meshInfos)
{
    SVertexBufferInfos vBufferInf;
    u32 nbVertices = 0;
    u32 firstVertexOffset = 0;
    u32 nbIndices = 0;
    u32 firstIndiceOffset = 0;
    for (u32 i = 0; i < bufferInfos.verticesBuffer.size(); ++i)
    {
        nbVertices += bufferInfos.verticesBuffer[i].nbVertices;
        if (nbVertices > meshInfos.firstVertex)
        {
            vBufferInf = bufferInfos.verticesBuffer[i];
            // the index of the first vertex in the buffer
            firstVertexOffset = meshInfos.firstVertex - (nbVertices - vBufferInf.nbVertices);
            //std::cout << "firstVertexOffset=" << firstVertexOffset << std::endl;
            break;
        }
    }
    for (u32 i = 0; i < bufferInfos.verticesBuffer.size(); ++i)
    {
        nbIndices += bufferInfos.verticesBuffer[i].nbIndices;
        if (nbIndices > meshInfos.firstIndice)
        {
            vBufferInf = bufferInfos.verticesBuffer[i];
            firstIndiceOffset = meshInfos.firstIndice - (nbIndices - vBufferInf.nbIndices);
            //std::cout << "firstIndiceOffset=" << firstVertexOffset << std::endl;
            break;
        }
    }

    // Check if it's the best LOD
    if (ConfigLoadOnlyBestLOD && vBufferInf.lod != 1)
        return false;

    io::IReadFile* bufferFile = _fileSystem->createAndOpenFile(file->getFileName() + ".1.buffer");
    if (!bufferFile)
    {
        os::Printer::log(" failed to open .buffer file ", ELL_ERROR);
        return false;
    }


    scene::SSkinMeshBuffer* buffer = _animatedMesh->addMeshBuffer();
    buffer->VertexType = video::EVT_STANDARD;
    //std::cout << "Num vertices=" << meshInfos.numVertices << std::endl;
    buffer->Vertices_Standard.reallocate(meshInfos.numVertices);

    u32 vertexSize = 8;
    if (meshInfos.vertexType == EMVT_SKINNED)
        vertexSize += meshInfos.numBonesPerVertex * 2;

    //std::cout << "first vertex = " << meshInfos.firstVertex << std::endl;
    // Maybe it's simply 1 verticesBufferInfo/buffer, seems correct and more simple
    //if (bufferInfos.verticesBuffer.size() == _animatedMesh->getMeshBufferCount())
    //    std::cout << "--> 1 verticesBufferInfo/buffer" << std::endl;


    bufferFile->seek(vBufferInf.verticesCoordsOffset + firstVertexOffset * vertexSize);
    //std::cout << "POS vCoords=" << bufferFile->getPos() << std::endl;

    const video::SColor defaultColor(255, 255, 255, 255);
    for (u32 i = 0; i < meshInfos.numVertices; ++i)
    {
        u16 x, y, z, w;

        bufferFile->read(&x, 2);
        bufferFile->read(&y, 2);
        bufferFile->read(&z, 2);
        bufferFile->read(&w, 2);

        // skip skinning data
        if (meshInfos.vertexType == EMVT_SKINNED && !ConfigLoadSkeleton)
        {
            bufferFile->seek(meshInfos.numBonesPerVertex * 2, true);
        }
        else if (meshInfos.vertexType == EMVT_SKINNED)
        {
            unsigned char * skinningData = DBG_NEW unsigned char[meshInfos.numBonesPerVertex * 2];
            bufferFile->read(&skinningData[0], meshInfos.numBonesPerVertex * 2);

            for (u32 j = 0; j < meshInfos.numBonesPerVertex; ++j)
            {
                unsigned char boneId = skinningData[j];
                unsigned char weightStrength = skinningData[j + meshInfos.numBonesPerVertex];

                if (boneId >= _animatedMesh->getJointCount()) // If bone don't exist
                    continue;

                if (weightStrength != 0)
                {
                    scene::ISkinnedMesh::SJoint* joint = _animatedMesh->getAllJoints()[boneId];
                    u32 bufferId = _animatedMesh->getMeshBufferCount() - 1;
                    f32 fWeightStrength = weightStrength / 255.f;

                    scene::ISkinnedMesh::SWeight* weight = _animatedMesh->addWeight(joint);
                    weight->buffer_id = bufferId;
                    weight->strength = fWeightStrength;
                    weight->vertex_id = i;
                    //std::cout << "TEST:" << fweight << ", " << bufferId << ", " << i << std::endl;

                    CW3DataCache::_instance.addVertexEntry(boneId, bufferId, i, fWeightStrength);
                }
            }

        }

        buffer->Vertices_Standard.push_back(video::S3DVertex());
        //buffer->Vertices_Standard[i].Pos = core::vector3df(x, y, z) / 65535.f * bufferInfos.quantizationScale + bufferInfos.quantizationOffset;

        f32 xf = x / 65535.0f;
        f32 yf = y / 65535.0f;
        f32 zf = z / 65535.0f;

        buffer->Vertices_Standard[i].Pos = core::vector3df(xf, yf, zf) * bufferInfos.quantizationScale + bufferInfos.quantizationOffset;
        buffer->Vertices_Standard[i].Color = defaultColor;
        //std::cout << "Position=" << x << ", " << y << ", " << z << std::endl;
    }
    bufferFile->seek(vBufferInf.uvOffset + firstVertexOffset * 4);
    //std::cout << "POS vUV=" << bufferFile->getPos() << std::endl;

    for (u32 i = 0; i < meshInfos.numVertices; ++i)
    {
        u16 u, v;
        bufferFile->read(&u, 2);
        bufferFile->read(&v, 2);

        f32 uf = halfToFloat(u);
        f32 vf = halfToFloat(v);

        buffer->Vertices_Standard[i].TCoords = core::vector2df(uf, vf);
    }


    // Not sure...
    /*
    bufferFile->seek(vBufferInf.normalsOffset + firstVertexOffset * 8);
    std::cout << "POS vNormals=" << bufferFile->getPos() << std::endl;
    for (u32 i = 0; i < meshInfos.numVertices; ++i)
    {
        s16 x, y, z, w;

        bufferFile->read(&x, 2);
        bufferFile->read(&y, 2);
        bufferFile->read(&z, 2);
        bufferFile->read(&w, 2);

        //std::cout << "Position=" << x * infos.quantizationScale.X<< ", " << y * infos.quantizationScale.Y<< ", " << z << std::endl;
        buffer->Vertices_Standard[i].Normal = core::vector3df(x, y, z);
        buffer->Vertices_Standard[i].Normal.normalize();
    }
    */


    // Indices -------------------------------------------------------------------
    bufferFile->seek(bufferInfos.indicesBufferOffset + vBufferInf.indicesOffset + firstIndiceOffset * 2);

    //std::cout << "POS Indices=" << bufferFile->getPos() - bufferInfos.indicesBufferOffset << std::endl;
    //std::cout << "num indices=" << meshInfos.numIndices << std::endl;
    buffer->Indices.set_used(meshInfos.numIndices);
    for (u32 i = 0; i < meshInfos.numIndices; ++i)
    {
        const u16 indice = readU16(bufferFile);

        // Indice need to be inversed for the normals
        if (i % 3 == 0)
            buffer->Indices[i] = indice;
        else if (i % 3 == 1)
            buffer->Indices[i+1] = indice;
        else if (i % 3 == 2)
            buffer->Indices[i-1] = indice;
    }

    _sceneManager->getMeshManipulator()->recalculateNormals(buffer);
    bufferFile->drop();

    return true;
}

bool CW3EntLoader::W3_ReadBufferStatic(io::IReadFile* file, SBufferInfos bufferInfos, SMeshInfos meshInfos)
{
    SVertexBufferInfos vBufferInf;
    u32 nbVertices = 0;
    u32 firstVertexOffset = 0;
    u32 nbIndices = 0;
    u32 firstIndiceOffset = 0;
    for (u32 i = 0; i < bufferInfos.verticesBuffer.size(); ++i)
    {
        nbVertices += bufferInfos.verticesBuffer[i].nbVertices;
        if (nbVertices > meshInfos.firstVertex)
        {
            vBufferInf = bufferInfos.verticesBuffer[i];
            // the index of the first vertex in the buffer
            firstVertexOffset = meshInfos.firstVertex - (nbVertices - vBufferInf.nbVertices);
            //std::cout << "firstVertexOffset=" << firstVertexOffset << std::endl;
            break;
        }
    }
    for (u32 i = 0; i < bufferInfos.verticesBuffer.size(); ++i)
    {
        nbIndices += bufferInfos.verticesBuffer[i].nbIndices;
        if (nbIndices > meshInfos.firstIndice)
        {
            vBufferInf = bufferInfos.verticesBuffer[i];
            firstIndiceOffset = meshInfos.firstIndice - (nbIndices - vBufferInf.nbIndices);
            //std::cout << "firstIndiceOffset=" << firstVertexOffset << std::endl;
            break;
        }
    }

    // Check if it's the best LOD
    if (ConfigLoadOnlyBestLOD && vBufferInf.lod != 1)
        return false;

    io::IReadFile* bufferFile = _fileSystem->createAndOpenFile(file->getFileName() + ".1.buffer");
    if (!bufferFile)
    {
        os::Printer::log(" failed to open .buffer file ", ELL_ERROR);
        return false;
    }

    scene::SMeshBuffer* buffer = DBG_NEW SMeshBuffer();
    _staticMesh->addMeshBuffer(buffer);
    buffer->drop(); // owned by the static mesh now

    u32 vertexSize = 8;
    bufferFile->seek(vBufferInf.verticesCoordsOffset + firstVertexOffset * vertexSize);

    const video::SColor defaultColor(255, 255, 255, 255);

    buffer->Vertices.set_used(meshInfos.numVertices);

    for (u32 i = 0; i < meshInfos.numVertices; ++i)
    {
        u16 x, y, z, w;

        bufferFile->read(&x, 2);
        bufferFile->read(&y, 2);
        bufferFile->read(&z, 2);
        bufferFile->read(&w, 2);

        f32 xf = x / 65535.0f;
        f32 yf = y / 65535.0f;
        f32 zf = z / 65535.0f;

        buffer->Vertices[i].Pos = core::vector3df(xf, yf, zf) * bufferInfos.quantizationScale + bufferInfos.quantizationOffset;
        buffer->Vertices[i].Color = defaultColor;
    }
    bufferFile->seek(vBufferInf.uvOffset + firstVertexOffset * 4);

    for (u32 i = 0; i < meshInfos.numVertices; ++i)
    {
        u16 u, v;
        bufferFile->read(&u, 2);
        bufferFile->read(&v, 2);

        f32 uf = halfToFloat(u);
        f32 vf = halfToFloat(v);

        buffer->Vertices[i].TCoords = core::vector2df(uf, vf);
    }

    // Indices -------------------------------------------------------------------
    bufferFile->seek(bufferInfos.indicesBufferOffset + vBufferInf.indicesOffset + firstIndiceOffset * 2);

    //std::cout << "POS Indices=" << bufferFile->getPos() - bufferInfos.indicesBufferOffset << std::endl;
    //std::cout << "num indices=" << meshInfos.numIndices << std::endl;
    buffer->Indices.set_used(meshInfos.numIndices);
    for (u32 i = 0; i < meshInfos.numIndices; ++i)
    {
        const u16 indice = readU16(bufferFile);

        // Indice need to be inversed for the normals
        if (i % 3 == 0)
            buffer->Indices[i] = indice;
        else if (i % 3 == 1)
            buffer->Indices[i + 1] = indice;
        else if (i % 3 == 2)
            buffer->Indices[i - 1] = indice;
    }

    _sceneManager->getMeshManipulator()->recalculateNormals(buffer);
    bufferFile->drop();

    return true;
}

bool CW3EntLoader::ReadPropertyHeader(io::IReadFile* file, SPropertyHeader& propHeader)
{
    u16 propName = readU16(file);
    u16 propType = readU16(file);

    if (propName == 0 || propType == 0 || propName >= Strings.size() || propType >= Strings.size())
    {
        return false;
    }

    propHeader.propName = Strings[propName];
    propHeader.propType = Strings[propType];

    const long back = file->getPos();
    propHeader.propSize = readS32(file);
    propHeader.endPos = back + propHeader.propSize;

    return true;
}

bool CW3EntLoader::ReadPropertyHeader(io::IReadFile* file, SPropertyHeader& propHeader, u16& extra)
{
    u16 propName = readU16(file);
    u16 propType = readU16(file);
    extra = propName + propType;

    if (propName == 0 || propType == 0 || propName >= Strings.size() || propType >= Strings.size())
    {
        return false;
    }

    propHeader.propName = Strings[propName];
    propHeader.propType = Strings[propType];

    const long back = file->getPos();
    propHeader.propSize = readS32(file);
    propHeader.endPos = back + propHeader.propSize;

    return true;
}


SAnimationBufferBitwiseCompressedData CW3EntLoader::ReadSAnimationBufferBitwiseCompressedDataProperty(io::IReadFile* file)
{
    file->seek(1, true);
    SAnimationBufferBitwiseCompressedData dataInf;

    while(1)
    {
        SPropertyHeader propHeader;
        if (!ReadPropertyHeader(file, propHeader))
            break;

        //std::cout << "@" << file->getPos() <<", property = " << propHeader.propName.c_str() << ", type = " << propHeader.propType.c_str() << std::endl;
        if (propHeader.propName == "dataAddr")
            dataInf.dataAddr = readU32(file);
        if (propHeader.propName == "dataAddrFallback")
            dataInf.dataAddrFallback = readU32(file);
        if (propHeader.propName == "numFrames")
            dataInf.numFrames = readU16(file);
        if (propHeader.propName == "dt")
            dataInf.dt = readF32(file);
        if (propHeader.propName == "compression")
            dataInf.compression = readS8(file);

        file->seek(propHeader.endPos);
    }
    return dataInf;
}

core::array<core::array<SAnimationBufferBitwiseCompressedData> > CW3EntLoader::ReadSAnimationBufferBitwiseCompressedBoneTrackProperty(io::IReadFile* file)
{
    s32 arraySize = readS32(file);
    file->seek(1, true);
    os::Printer::log((formatString("Array size = %d", arraySize)).c_str(), ELL_DEBUG);

    core::array<core::array<SAnimationBufferBitwiseCompressedData> > inf;
    inf.push_back(core::array<SAnimationBufferBitwiseCompressedData>());

    int i = 0;              // array index
    while(i <= arraySize)   // the array index = bone index
    {
        SPropertyHeader propHeader;
        if (!ReadPropertyHeader(file, propHeader))
        {
            ++i;
            if (i == arraySize) // end of the array
                break;

            // go back and re-read
            file->seek(-1, true);
            ReadPropertyHeader(file, propHeader);
            inf.push_back(core::array<SAnimationBufferBitwiseCompressedData>());

            os::Printer::log((formatString("New bone : (index = %d)", i)).c_str(), ELL_DEBUG);
        }


        //std::cout << "@" << file->getPos() <<", property = " << propHeader.propName.c_str() << ", type = " << propHeader.propType.c_str() << std::endl;
        if (propHeader.propType == "SAnimationBufferBitwiseCompressedData")
        {
            SAnimationBufferBitwiseCompressedData animInf = ReadSAnimationBufferBitwiseCompressedDataProperty(file);

            if (propHeader.propName == "position")
                animInf.type = EATT_POSITION;
            else if (propHeader.propName == "orientation")
                animInf.type = EATT_ORIENTATION;
            else if (propHeader.propName == "scale")
                animInf.type = EATT_SCALE;

            inf[inf.size() - 1].push_back(animInf);
        }

        file->seek(propHeader.endPos);
    }

    return inf;
}



void CW3EntLoader::ReadMaterialsProperty(io::IReadFile* file)
{
    s32 nbChunks = readS32(file);

    core::array<video::SMaterial> matMats;

    for (s32 i = 0; i < nbChunks; ++i)
    {
        u32 matValue = readU32(file);
        u32 matFileID = 0xFFFFFFFF - matValue;

        if (matFileID < Files.size()) // Refer to a w2mi file
        {
            matMats.push_back(ReadMaterialFile(Files[matFileID]));
        }
        //else
        //{
            //u32 value = matValue;
            //matMats.push_back(Materials[value-1]);
        //}

    }
    for (u32 i = 0; i < matMats.size(); ++i)
    {
        Materials.push_front(matMats[matMats.size() - 1 - i]);
    }
}

EMeshVertexType CW3EntLoader::ReadEMVTProperty(io::IReadFile* file)
{
    u16 enumStringId = readU16(file);

    EMeshVertexType vertexType = EMVT_STATIC;

    core::stringc enumString = Strings[enumStringId];
    if (enumString == "MVT_SkinnedMesh")
    {
        vertexType = EMVT_SKINNED;
    }

    return vertexType;
}

SAnimationBufferOrientationCompressionMethod CW3EntLoader::ReadAnimationBufferOrientationCompressionMethodProperty(io::IReadFile* file)
{
    u16 enumStringId = readU16(file);
    core::stringc enumString = Strings[enumStringId];

    if (enumString == "ABOCM_PackIn48bitsW")
        return ABOCM_PackIn48bitsW;
    
    return (SAnimationBufferOrientationCompressionMethod)0;
}

core::array<SMeshInfos> CW3EntLoader::ReadSMeshChunkPackedProperty(io::IReadFile* file)
{
    core::array<SMeshInfos> meshes;
    SMeshInfos meshInfos;

    s32 nbChunks = readS32(file);

    //std::cout << "NB = -> " << nbChunks << std::endl;

    file->seek(1, true);

    s32 chunkId = 0;

    while(1)
    {
        SPropertyHeader propHeader;

        // invalid property = next chunk
        if (!ReadPropertyHeader(file, propHeader))
        {
            meshes.push_back(meshInfos);
            chunkId++;

            if (chunkId >= nbChunks)
                break;
            else
            {
                SMeshInfos newMeshInfos;
                newMeshInfos.vertexType = meshInfos.vertexType;
                newMeshInfos.numBonesPerVertex = meshInfos.numBonesPerVertex;
                meshInfos = newMeshInfos;

                file->seek(-1, true);
                ReadPropertyHeader(file, propHeader);
            }
        }

        //std::cout << "@" << file->getPos() <<", property = " << propHeader.propName.c_str() << ", type = " << propHeader.propType.c_str() << std::endl;

        if (propHeader.propName == "numIndices")
        {
            meshInfos.numIndices = readU32(file);
            //std::cout << "numIndices = " << meshInfos.numIndices << std::endl;
        }
        else if (propHeader.propName == "numVertices")
        {
            meshInfos.numVertices = readU32(file);
            //std::cout << "numVertices = " << meshInfos.numVertices << std::endl;
        }
        else if (propHeader.propName == "firstVertex")
        {
            meshInfos.firstVertex = readU32(file);
            //std::cout << "first vertex found (=" << meshInfos.firstVertex << ")" << std::endl;
        }
        else if (propHeader.propName == "firstIndex")
        {
            meshInfos.firstIndice = readU32(file);
            //std::cout << "firstIndice = " << meshInfos.firstIndice << std::endl;
        }
        else if (propHeader.propName == "vertexType")
        {
            meshInfos.vertexType = ReadEMVTProperty(file);
        }
        else if (propHeader.propName == "numBonesPerVertex")
        {
            meshInfos.numBonesPerVertex = readU8(file);
        }
        else if (propHeader.propName == "materialID")
        {
            meshInfos.materialID = readU32(file);
            //std::cout << "material ID = " << meshInfos.materialID << std::endl;
        }

        file->seek(propHeader.endPos);
    }


    return meshes;
}

void CW3EntLoader::ReadRenderChunksProperty(io::IReadFile* file, SBufferInfos* buffer)
{
    s32 nbElements = readS32(file); // array size (= bytes count here)
    //std::cout << "nbElem = " << nbElements << ", @= " << file->getPos() << ", end @=" << back + propSize << std::endl;
    //const long back = file->getPos();

    //file->seek(1, true);
    u8 nbBuffers = readU8(file);
    //std::cout << "nbBuffers = " << (u32)nbBuffers << std::endl;

    //while(file->getPos() - back < nbElements)
    for (u32 i = 0; i < nbBuffers; ++i)
    {
        //std::cout << "@@@ -> " << file->getPos() << std::endl;
        SVertexBufferInfos buffInfos;
        file->seek(1, true); // Unknown

        file->read(&buffInfos.verticesCoordsOffset, 4);
        file->read(&buffInfos.uvOffset, 4);
        file->read(&buffInfos.normalsOffset, 4);

        file->seek(9, true); // Unknown
        file->read(&buffInfos.indicesOffset, 4);
        file->seek(1, true); // 0x1D

        file->read(&buffInfos.nbVertices, 2);
        //std::cout << "Nb VERT=" << buffInfos.nbVertices << std::endl;
        file->read(&buffInfos.nbIndices, 4);
        file->seek(3, true); // Unknown
        buffInfos.lod = readU8(file); // lod ?

        buffer->verticesBuffer.push_back(buffInfos);
    }
}

video::SMaterial CW3EntLoader::ReadIMaterialProperty(io::IReadFile* file)
{
    os::Printer::log("IMaterial", ELL_DEBUG);
    video::SMaterial mat;
    mat.MaterialType = video::EMT_SOLID;

    s32 nbProperty = readS32(file);
    //std::cout << "nb property = " << nbProperty << std::endl;
    //std::cout << "adress = " << file->getPos() << std::endl;

    // Read the properties of the material
    for (s32 i = 0; i < nbProperty; ++i)
    {
        os::Printer::log("Property...", ELL_DEBUG);

        const s32 back = file->getPos();
        s32 propSize = readS32(file);

        u16 propId, propTypeId;
        file->read(&propId, 2);
        file->read(&propTypeId, 2);

        if (propId >= Strings.size())
            break;

        os::Printer::log((formatString("The property is %s of the type %s", Strings[propId].c_str(), Strings[propTypeId].c_str())).c_str(), ELL_DEBUG);

        const s32 textureLayer = getTextureLayerFromTextureType(Strings[propId]);
        if (textureLayer != -1)
        {
            u8 texId = readU8(file);
            texId = 255 - texId;

            if (texId < Files.size())
            {
                video::ITexture* texture = nullptr;
                texture = getTexture(Files[texId]);

                if (texture)
                {
                    os::Printer::log((formatString("load texture %s ", Files[texId].c_str())).c_str(), ELL_DEBUG);
                    mat.setTexture(textureLayer, texture);

                    if (textureLayer == 1)
                    {
                        mat.MaterialType = video::EMT_NORMAL_MAP_SOLID;
                    }
                }
                else
                {
                    os::Printer::log((formatString("Error : the file %s can't be opened.", Files[texId].c_str())).c_str(), ELL_ERROR);
                }
            }
        }
        file->seek(back + propSize);

        os::Printer::log("...OK", ELL_DEBUG);
    }
    os::Printer::log("IMaterial OK", ELL_DEBUG);

    return mat;
}

core::array<core::vector3df> CW3EntLoader::ReadBonesPosition(io::IReadFile* file)
{
    s32 nbBones = readS32(file);

    file->seek(1, true);

    core::array<core::vector3df> positions;
    for (s32 i = 0; i < nbBones; ++i)
    {
        file->seek(8, true);
        float x = readF32(file);
        file->seek(8, true);
        float y = readF32(file);
        file->seek(8, true);
        float z = readF32(file);
        file->seek(8, true);
        float w = readF32(file);

        core::vector3df position = core::vector3df(x, y, z);
        positions.push_back(position);

        //std::cout << "position = " << x << ", " << y << ", " << z << ", " << w << std::endl;
        file->seek(3, true);
    }
    return positions;
}

void CW3EntLoader::ReadRenderLODSProperty(io::IReadFile* file)
{
    // LOD distances ?
    u32 arraySize = readU32(file);
    for (u32 i = 0; i < arraySize; ++i)
    {
        f32 value = readF32(file);
        //std::cout << "Value : " << value << std::endl;
    }
}

SBufferInfos CW3EntLoader::ReadSMeshCookedDataProperty(io::IReadFile* file)
{
    SBufferInfos bufferInfos;

    file->seek(1, true);

    SPropertyHeader propHeader;
    while(ReadPropertyHeader(file, propHeader))
    {
        //std::cout << "@" << file->getPos() <<", property = " << propHeader.propName.c_str() << ", type = " << propHeader.propType.c_str() << std::endl;

        if (propHeader.propName == "indexBufferSize")
        {
            bufferInfos.indicesBufferSize = readU32(file);
        }
        else if (propHeader.propName == "indexBufferOffset")
        {
            bufferInfos.indicesBufferOffset = readU32(file);
        }
        else if (propHeader.propName == "vertexBufferSize")
        {
            bufferInfos.verticesBufferSize = readU32(file);
        }
        else if (propHeader.propName == "quantizationScale")
        {
            bufferInfos.quantizationScale = readVector3df(file);
        }
        else if (propHeader.propName == "quantizationOffset")
        {
            bufferInfos.quantizationOffset = readVector3df(file);
        }
        else if (propHeader.propName == "bonePositions")
        {
            core::array<core::vector3df> positions = ReadBonesPosition(file);
            NbBonesPos = positions.size();
        }
        //else if (propHeader.propName == "collisionInitPositionOffset")
        //    ReadVector3Property(file, &bufferInfos);
        else if (propHeader.propName == "renderChunks")
            ReadRenderChunksProperty(file, &bufferInfos);
        else if (propHeader.propName == "renderLODs")
            ReadRenderLODSProperty(file);
        //else
        //    ReadUnknowProperty(file);
        file->seek(propHeader.endPos);
    }

    return bufferInfos;
}

float read16bitsFloat(io::IReadFile* file)
{
    u32 bits = readU16(file) << 16;
    f32 f;
    memcpy(&f, &bits, 4);
    return f;
}

// need a test file
float read24bitsFloat(io::IReadFile* file)
{
    u32 bits = readU16(file) << 16;
    bits |= readU8(file) << 8;
    f32 f;
    memcpy(&f, &bits, 4);
    return f;
}

float readCompressedFloat(io::IReadFile* file, u8 compressionSize)
{
    if (compressionSize == 16)
        return read16bitsFloat(file);
    else if (compressionSize == 24) // Not tested yet !
        return read24bitsFloat(file);
    else
        return readF32(file); // Not tested yet !
}

/*
// old version
float bits12ToFloat(s16 value)
{
    if (value & 0x0800)
        value = value;
    else
        value = -value;

    value = (value & 0x000007FF);
    float fVal = value / 2047.f;
    return fVal;
}
*/

// Fixed by Ákos Köte, thx
float bits12ToFloat(s16 value)
{
    float fVal = (2047.0f - value) * (1 / 2048.0f);
    return fVal;
}

float bits16ToFloat(u16 value)
{
    float fVal = (32767.0f - value) * (1 / 32768.0f);
    return fVal;
}

core::stringc getAnimTrackString(EAnimTrackType type)
{
    if (type == EATT_POSITION)
        return "EATT_POSITION";
    else if (type == EATT_ORIENTATION)
        return "EATT_ORIENTATION";
    else
        return "EATT_SCALE";
}

void CW3EntLoader::readAnimBuffer(  core::array<core::array<SAnimationBufferBitwiseCompressedData> >& inf,
                                    io::IReadFile* dataFile, 
                                    SAnimationBufferOrientationCompressionMethod c,
                                    u32 idx)
{
    // Create bones to store the keys if they doesn't exist
    /*
    if (meshToAnimate->getJointCount() < inf.size())
    {
        for (u32 i = meshToAnimate->getJointCount(); i < inf.size(); ++i)
            meshToAnimate->addJoint();
    }
    */
    SW3Animation* anim = getAnimationByIdx(idx);

    for (u32 i = 0; i < inf.size(); ++i)            // number of bones
    {
        //scene::ISkinnedMesh::SJoint* joint = meshToAnimate->getAllJoints()[i];
        //os::Printer::log((formatString("---> JOINT : %s", joint->Name.c_str())).c_str(), ELL_DEBUG);

        // init animation lists
        core::array<u32> _positionsKeyframes;
        core::array<u32> _orientationsKeyframes;
        core::array<u32> _scalesKeyframes;
        core::array<core::vector3df> _positions;
        core::array<core::quaternion> _orientations;
        core::array<core::vector3df> _scales;

        for (u32 j = 0; j < inf[i].size(); ++j)     // animation data for particular bone
        {
            SAnimationBufferBitwiseCompressedData infos = inf[i][j];  // definitions of where the data is in a file and compression method
            dataFile->seek(infos.dataAddr);

#ifdef _DEBUG_W3
            // Debug infos
            os::Printer::log((formatString("--> Type : %s", getAnimTrackString(infos.type).c_str())).c_str(), ELL_DEBUG);

            os::Printer::log((formatString("numFrames = %d", infos.numFrames)).c_str(), ELL_DEBUG);
            os::Printer::log((formatString("dt = %f", infos.dt)).c_str(), ELL_DEBUG);
            os::Printer::log((formatString("@ pos in file = %d", dataFile->getPos())).c_str(), ELL_DEBUG);
            //std::cout << "compression=" << (int)infos.compression << std::endl;
#endif // _DEBUG
            // TODO
            for (u32 f = 0; f < infos.numFrames; ++f)
            {
                u32 keyframe = f;
                keyframe += FrameOffset;

                //std::cout << "Adress = " << dataFile->getPos() << std::endl;
                u8 compressionSize = 0;             // no compression
                if (infos.compression == 1)
                    compressionSize = 24;
                else if (infos.compression == 2)
                    compressionSize = 16;

                if (infos.type == EATT_POSITION)
                {
                    //std::cout << "compressionSize= " << (u32)compressionSize << std::endl;
                    f32 px = readCompressedFloat(dataFile, compressionSize);
                    f32 py = readCompressedFloat(dataFile, compressionSize);
                    f32 pz = readCompressedFloat(dataFile, compressionSize);
#ifdef _DEBUG_W3  
                    os::Printer::log((formatString("Position value = %f, %f, %f", px, py, pz)).c_str(), ELL_DEBUG);
#endif
                    _positionsKeyframes.push_back(keyframe - FrameOffset);      // FrameOffset is global TODO: fix after removing old code
                    _positions.push_back(core::vector3df(px, py, pz));

                    /*
                    scene::ISkinnedMesh::SPositionKey* key = meshToAnimate->addPositionKey(joint);
                    key->position = core::vector3df(px, py, pz);
                    key->frame = keyframe;
                    */

                }
                if (infos.type == EATT_ORIENTATION)
                {
                    core::quaternion orientation;
                    if (c == ABOCM_PackIn48bitsW)
                    {
                        uint64_t b1 = readU8(dataFile);
                        uint64_t b2 = readU8(dataFile);
                        uint64_t b3 = readU8(dataFile);
                        uint64_t b4 = readU8(dataFile);
                        uint64_t b5 = readU8(dataFile);
                        uint64_t b6 = readU8(dataFile);
                        uint64_t bits = b6 | (b5 << 8) | (b4 << 16) | (b3 << 24) | (b2 << 32) | (b1 << 40);
                        //dataFile->read(&bits, sizeof(uint64_t));


                        f32 fx, fy, fz, fw;

                        s16 x = 0, y = 0, z = 0, w = 0;
                        x = (s16)((bits & 0x0000FFF000000000) >> 36);
                        y = (s16)((bits & 0x0000000FFF000000) >> 24);
                        z = (s16)((bits & 0x0000000000FFF000) >> 12);
                        w = (s16)(bits & 0x0000000000000FFF);

                        fx = bits12ToFloat(x);
                        fy = bits12ToFloat(y);
                        fz = bits12ToFloat(z);
                        fw = -bits12ToFloat(w);

                        orientation = core::quaternion(fx, fy, fz, fw);
                        core::vector3df euler;
                        orientation.toEuler(euler);
                        euler *= core::RADTODEG;
#ifdef _DEBUG_W3                   
                        os::Printer::log((formatString("Quaternion : x=%f, y=%f, z=%f, w=%f", fx, fy, fz, fw)).c_str(), ELL_DEBUG);
                        os::Printer::log((formatString("Quaternion mult : x=%f, y=%f, z=%f, w=%f", fx * fx + fy * fy + fz * fz + fw * fw)).c_str(), ELL_DEBUG);
                        os::Printer::log((formatString("Euler : x=%f, y=%f, z=%f", euler.X, euler.Y, euler.Z)).c_str(), ELL_DEBUG);
#endif // _DEBUG_w3                      
                    }
                    else
                    {
                        //orientation is packed in 8 bytes
                        u16 plain[4];
                        plain[0] = readU16(dataFile);
                        plain[1] = readU16(dataFile);
                        plain[2] = readU16(dataFile);
                        plain[3] = readU16(dataFile);

                        f32 fx, fy, fz, fw;

                        fx = bits16ToFloat(plain[0]);
                        fy = bits16ToFloat(plain[1]);
                        fz = bits16ToFloat(plain[2]);
                        fw = -bits16ToFloat(plain[3]);

                        orientation = core::quaternion(fx, fy, fz, fw);
                        core::vector3df euler;
                        orientation.toEuler(euler);
                        euler *= core::RADTODEG;
#ifdef _DEBUG_W3
                        os::Printer::log((formatString("Quaternion : x=%f, y=%f, z=%f, w=%f", fx, fy, fz, fw)).c_str(), ELL_DEBUG);
                        os::Printer::log((formatString("Quaternion mult : x=%f, y=%f, z=%f, w=%f", fx * fx + fy * fy + fz * fz + fw * fw)).c_str(), ELL_DEBUG);
                        os::Printer::log((formatString("Euler : x=%f, y=%f, z=%f", euler.X, euler.Y, euler.Z)).c_str(), ELL_DEBUG);
#endif // _DEBUG_W3
                    }

                    //scene::ISkinnedMesh::SRotationKey* key = meshToAnimate->addRotationKey(joint);
                    //key->rotation = orientation;
                    //key->frame = keyframe;

                    _orientationsKeyframes.push_back(keyframe - FrameOffset);
                    _orientations.push_back(orientation);
                }

                if (infos.type == EATT_SCALE)
                {
                    f32 sx = readCompressedFloat(dataFile, compressionSize);
                    f32 sy = readCompressedFloat(dataFile, compressionSize);
                    f32 sz = readCompressedFloat(dataFile, compressionSize);

                    os::Printer::log((formatString("Scale value = %f, %f, %f", sx, sy, sz)).c_str(), ELL_DEBUG);

                    //scene::ISkinnedMesh::SScaleKey* key = meshToAnimate->addScaleKey(meshToAnimate->getAllJoints()[i]);
                    //key->scale = core::vector3df(sx, sy, sz);
                    //key->frame = keyframe;

                    _scalesKeyframes.push_back(keyframe - FrameOffset);
                    _scales.push_back(core::vector3df(sx, sy, sz));
                }
            }   // frames loop
        }       // animation data for partuclar bone

        anim->positionsKeyframes.push_back(_positionsKeyframes);
        anim->positions.push_back(_positions);
        anim->orientationsKeyframes.push_back(_orientationsKeyframes);
        anim->orientations.push_back(_orientations);
        anim->scalesKeyframes.push_back(_scalesKeyframes);
        anim->scales.push_back(_scales);

    }
}

void CW3EntLoader::W3_CUnknown(io::IReadFile* file, W3_DataInfos infos)
{
    file->seek(infos.adress + 1);
    //std::cout << "W3_CUnknown, @infos.adress=" << infos.adress << ", end @" << infos.adress + infos.size << std::endl;
    os::Printer::log("W3_CUknown", ELL_WARNING);

    SPropertyHeader propHeader;
    while (ReadPropertyHeader(file, propHeader))
    {
        //std::cout << "-> @" << file->getPos() <<", property = " << propHeader.propName.c_str() << ", type = " << propHeader.propType.c_str() << std::endl;
        file->seek(propHeader.endPos);
    }
    os::Printer::log("W3_CUknown end", ELL_WARNING);
}


void CW3EntLoader::W3_CAnimationBufferBitwiseCompressed(io::IReadFile* file, W3_DataInfos infos, u32 idx)
{
    file->seek(infos.adress + 1);
    os::Printer::log("W3_CAnimationBufferBitwiseCompressed", ELL_WARNING);

    core::array<core::array<SAnimationBufferBitwiseCompressedData> > inf;
    core::array<s8> data;
    io::IReadFile* dataFile = 0;
    SAnimationBufferOrientationCompressionMethod compress = ABOCM_PackIn64bitsW;

    f32 animDuration = 1.0f;
    u32 numFrames = 0;
    u16 defferedData = 0;

    SPropertyHeader propHeader;
    while (ReadPropertyHeader(file, propHeader))
    {
        if (propHeader.propType == "array:129,0,SAnimationBufferBitwiseCompressedBoneTrack")
        {
            inf = ReadSAnimationBufferBitwiseCompressedBoneTrackProperty(file);

        }
        else if (propHeader.propName == "data")
        {
            u32 arraySize = readU32(file);
            data = readDataArray<s8>(file, arraySize);
        }
        else if (propHeader.propName == "orientationCompressionMethod")
        {
            compress = ReadAnimationBufferOrientationCompressionMethodProperty(file);
        }
        else if (propHeader.propName == "duration")
        {
            animDuration = readF32(file);
            os::Printer::log((formatString("duration = %f", animDuration)).c_str(), ELL_DEBUG);
        }
        else if (propHeader.propName == "numFrames")
        {
            numFrames = readU32(file);
            os::Printer::log((formatString("numFrames = %d", numFrames)).c_str(), ELL_DEBUG);
        }
        else if (propHeader.propName == "deferredData")
        {
            defferedData = readU16(file);
        }

        //std::cout << "-> @" << file->getPos() <<", property = " << propHeader.propName.c_str() << ", type = " << propHeader.propType.c_str() << std::endl;
        file->seek(propHeader.endPos);
    }

    f32 animationSpeed = (f32)numFrames / animDuration;
    // meshToAnimate->setAnimationSpeed(animationSpeed);    // moved to helper
    SW3Animation* anim = getAnimationByIdx(idx);
    anim->animationSpeed = animationSpeed;

    if (defferedData == 0)
        dataFile = _fileSystem->createMemoryReadFile(data.pointer(), data.size(), "tempData");
    else
    {
        core::stringc filename = file->getFileName() + "." + toStr(defferedData) + ".buffer";
        os::Printer::log((formatString("Filename deffered = %s", filename.c_str())).c_str(), ELL_DEBUG);
        dataFile = _fileSystem->createAndOpenFile(filename);
    }


    if (dataFile)
    {
        readAnimBuffer(inf, dataFile, compress, idx);
        dataFile->drop();
    }

    FrameOffset += numFrames;
    os::Printer::log("W3_CAnimationBufferBitwiseCompressed end", ELL_DEBUG);
}

// sometimes toEuler give NaN numbers
void chechNaNErrors(core::vector3df& vector3)
{
    if (std::isnan(vector3.X) || std::isinf(vector3.X))
        vector3.X = 0.f;

    if (std::isnan(vector3.Y) || std::isinf(vector3.Y))
        vector3.Y = 0.f;

    if (std::isnan(vector3.Z) || std::isinf(vector3.Z))
        vector3.Z = 0.f;
}

CW3Skeleton CW3EntLoader::W3_CSkeleton(io::IReadFile* file, W3_DataInfos infos)
{
    file->seek(infos.adress + 1);
    os::Printer::log("W3_CSkeleton", ELL_DEBUG);

    CW3Skeleton skeleton;
    SPropertyHeader propHeader;

    while (ReadPropertyHeader(file, propHeader))
    {

        if (propHeader.propName == "bones")
        {
            // array
            s32 nbBones = readS32(file);
            file->seek(1, true);

            skeleton.nbBones = nbBones;

            for (s32 i = 0; i < nbBones; ++i)
            {
                SPropertyHeader h;
                ReadPropertyHeader(file, h);  // name + StringANSI

                u8 nameSize = readU8(file);
                core::stringc name = readString(file, nameSize);
                skeleton.names.push_back(name);

                // An other property (nameAsCName)
                file->seek(13, true); // nameAsCName + CName + size + CName string ID + 3 0x00 octets
            }
        }
        else if (propHeader.propName == "parentIndices")
        {
            //std::cout << "@EndOfProperty = " << propHeader.endPos << std::endl;
            s32 nbBones = readS32(file);

            for (s32 i = 0; i < nbBones; ++i)
            {
                s16 parentId = readS16(file);
                //std::cout << "parent ID=" << parentId << std::endl;

                skeleton.parentId.push_back(parentId);
            }
        }

        file->seek(propHeader.endPos);
    }

    // Now there are the transformations
    file->seek(-2, true);
    //std::cout << file->getPos() << std::endl;

    for (u32 i = 0; i < skeleton.nbBones; ++i)
    {
        //std::cout << "bone = " << skeleton.names[i].c_str() << std::endl;
        // position (vector 4) + quaternion (4 float) + scale (vector 4)
        core::vector3df position;
        position.X = readF32(file);
        position.Y = readF32(file);
        position.Z = readF32(file);
        readF32(file); // the w component

        core::quaternion orientation;
        orientation.X = readF32(file);
        orientation.Y = readF32(file);
        orientation.Z = readF32(file);
        orientation.W = readF32(file);

        core::vector3df scale;
        scale.X = readF32(file);
        scale.Y = readF32(file);
        scale.Z = readF32(file);
        readF32(file); // the w component

        core::matrix4 posMat;
        posMat.setTranslation(position);

        core::matrix4 rotMat;
        core::vector3df euler;
        orientation.toEuler(euler);
        chechNaNErrors(euler);

        rotMat.setRotationRadians(euler);

        core::matrix4 scaleMat;
        scaleMat.setScale(scale);

        core::matrix4 localTransform = posMat * rotMat * scaleMat;
        orientation.makeInverse();                        // vl: what for??
        skeleton.matrix.push_back(localTransform);
        skeleton.positions.push_back(position);
        skeleton.rotations.push_back(orientation);
        skeleton.scales.push_back(scale);

    }

    Skeleton = skeleton;
    os::Printer::log("W3_CSkeleton end", ELL_DEBUG);
    
    return skeleton;
}

void CW3EntLoader::W3_CMeshComponent(io::IReadFile* file, W3_DataInfos infos)
{
    file->seek(infos.adress + 1);
    //std::cout << "W3_CMeshComponent, @infos.adress=" << infos.adress << ", end @" << infos.adress + infos.size << std::endl;
    os::Printer::log("W3_CMeshComponent", ELL_DEBUG);

    SPropertyHeader propHeader;
    while (ReadPropertyHeader(file, propHeader))
    {
        //std::cout << "-> @" << file->getPos() <<", property = " << property.c_str() << ", type = " << propertyType.c_str() << std::endl;

        if (propHeader.propName == "mesh")
        {
            u32 meshComponentValue = readU32(file);
            u32 fileId = 0xFFFFFFFF - meshComponentValue;
            CW3DataCache::_instance._bufferID += _animatedMesh->getMeshBufferCount();
            scene::ISkinnedMesh* mesh = ReadW2MESHFile(ConfigGamePath + Files[fileId]);
            CW3DataCache::_instance._bufferID -= _animatedMesh->getMeshBufferCount();
            if (mesh)
            {
                // Merge in the main mesh
                combineMeshes(_animatedMesh, mesh, true);
                //Meshes.push_back(mesh);
            }
            else
            {
                os::Printer::log((formatString("Fail to load %s", Files[fileId].c_str())).c_str(), ELL_ERROR);
            }
        }

        file->seek(propHeader.endPos);
    }

    os::Printer::log("W3_CMeshComponent end", ELL_DEBUG);
}

void CW3EntLoader::W3_CEntityTemplate(io::IReadFile* file, W3_DataInfos infos)
{
    file->seek(infos.adress + 1);
    os::Printer::log("W3_CEntityTemplate", ELL_DEBUG);

    //std::cout << "W3_CEntityTemplate, @infos.adress=" << infos.adress << ", end @" << infos.adress + infos.size << std::endl;

    SPropertyHeader propHeader;
    while (ReadPropertyHeader(file, propHeader))
    {

        //std::cout << "-> @" << file->getPos() <<", property = " << propHeader.propName.c_str() << ", type = " << propHeader.propType.c_str() << std::endl;

        if (propHeader.propName == "flatCompiledData") // array of u8
        {
            s32 arraySize = readS32(file);
            arraySize -= 4;

            //std::cout << file->getPos() << std::endl;

            //u8 data[arraySize];
            u8* data = DBG_NEW u8[arraySize];
            file->read(data, arraySize);


            io::IReadFile* entityFile = _fileSystem->createMemoryReadFile(data, arraySize, "tmpMemFile.w2ent_MEMORY", true);
            if (!entityFile)
                os::Printer::log("fail", ELL_ERROR);

            CW3EntLoader w3Loader(_sceneManager, _fileSystem);
            IAnimatedMesh* m = w3Loader.createMesh(entityFile);
            if (m)
                m->drop();

            entityFile->drop();
        }

        file->seek(propHeader.endPos);
    }

    os::Printer::log("W3_CEntityTemplate end", ELL_DEBUG);
}

void CW3EntLoader::W3_CEntity(io::IReadFile* file, W3_DataInfos infos)
{
    file->seek(infos.adress + 1);
    //std::cout << "W3_CEntity, @infos.adress=" << infos.adress << ", end @" << infos.adress + infos.size << std::endl;
}

bool CW3EntLoader::checkBones(io::IReadFile* file, char nbBones)
{
    const long back = file->getPos();
    for (char i = 0; i < nbBones; ++i)
    {
        u16 jointName = readU16(file);
        if (jointName == 0 || jointName >= Strings.size())
        {
            file->seek(back);
            return false;
        }

    }
    file->seek(back);
    return true;
}

char readBonesNumber(io::IReadFile* file)
{
    s8 nbBones = readS8(file);

    s8 o = readS8(file);
    if (o != 1)
        file->seek(-1, true);

    return nbBones;
}

void CW3EntLoader::W3_CMesh(io::IReadFile* file, W3_DataInfos infos)
{
    os::Printer::log("W3_CMesh", ELL_DEBUG);

    SBufferInfos bufferInfos;
    core::array<SMeshInfos> meshes;

    bool isStatic = false;

    file->seek(infos.adress + 1);

    SPropertyHeader propHeader;
    while (ReadPropertyHeader(file, propHeader))
    {
        //std::cout << "-> @" << file->getPos() <<", property = " << propHeader.propName.c_str() << ", type = " << propHeader.propType.c_str() << std::endl;
        if (propHeader.propType == "SMeshCookedData")
        {
            os::Printer::log("Buffer infos", ELL_DEBUG);
            bufferInfos = ReadSMeshCookedDataProperty(file);
        }
        else if (propHeader.propName == "chunks")
        {
            os::Printer::log("Chunks", ELL_DEBUG);
            meshes = ReadSMeshChunkPackedProperty(file);
        }
        else if (propHeader.propName == "materials")
        {
            os::Printer::log("Materials", ELL_DEBUG);
            ReadMaterialsProperty(file);
        }
        else if (propHeader.propName == "isStatic")
        {
            isStatic = readBool(file);
        }

        file->seek(propHeader.endPos);
   }

   os::Printer::log((formatString("All properties read, @=%d", file->getPos())).c_str(), ELL_DEBUG);

   if (IsStaticMesh)
   {
       for (u32 i = 0; i < meshes.size(); ++i)
       {
           os::Printer::log("Read buffer...", ELL_DEBUG);
           if (!W3_ReadBufferStatic(file, bufferInfos, meshes[i]))
               continue;

           if (meshes[i].materialID < Materials.size())
           {
               _staticMesh->getMeshBuffer(_staticMesh->getMeshBufferCount() - 1)->getMaterial() = Materials[meshes[i].materialID];
               _staticMesh->getMeshBuffer(_staticMesh->getMeshBufferCount() - 1)->recalculateBoundingBox();
           }

           os::Printer::log("OK", ELL_DEBUG);
       }
   }
   else
   {
       if (!isStatic && NbBonesPos > 0 && ConfigLoadSkeleton)
       {
           ReadBones(file);
       }

       for (u32 i = 0; i < meshes.size(); ++i)
       {
           os::Printer::log("Read buffer...", ELL_DEBUG);
           if (!W3_ReadBuffer(file, bufferInfos, meshes[i]))
               continue;

           //std::cout << "Read a buffer, Material ID = "  << meshes[i].materialID << std::endl;
           if (meshes[i].materialID < Materials.size())
           {
               //std::cout << "Material assigned to meshbuffer" << std::endl;
               _animatedMesh->getMeshBuffer(_animatedMesh->getMeshBufferCount() - 1)->getMaterial() = Materials[meshes[i].materialID];
           }
           else
           {
               //std::cout << "Error, mat " << meshes[i].materialID << "doesn't exist" << std::endl;
               /*
               if (Materials.size() >= 1)
                   _animatedMesh->getMeshBuffer(_animatedMesh->getMeshBufferCount() - 1)->getMaterial() = Materials[0];
               */
           }
           os::Printer::log("OK", ELL_DEBUG);
       }
   }
   os::Printer::log("W3_CMesh end", ELL_DEBUG);
}

void CW3EntLoader::ReadBones(io::IReadFile* file)
{
    os::Printer::log("Load bones", ELL_DEBUG);

    // cancel property
    file->seek(-4, true);

    /*
    file->seek(2, true);
    char offsetInd;
    file->read(&offsetInd, 1);
    file->seek(offsetInd * 7, true);
    */


    // TODO
    os::Printer::log((formatString("NbBonesPos = %d", NbBonesPos)).c_str(), ELL_DEBUG);
    long pos;
    unsigned char nbRead;
    do
    {
        pos = file->getPos();
        nbRead = readBonesNumber(file);

        if (nbRead == NbBonesPos)
        {
            if (!checkBones(file, nbRead))
            {
                nbRead = -1;
            }
        }

        if (file->getPos() >= file->getSize())
            return;
    }   while (nbRead != NbBonesPos);

    file->seek(pos);

    // Name of the bones
    char nbBones = readBonesNumber(file);

    //log->addAndFlush("nbBones = " + (s32)nbBones);
    //std::cout << "m size= " << meshes.size() << std::endl;

    for (char i = 0; i < nbBones; ++i)
    {
        u16 jointName = readU16(file);
        os::Printer::log((formatString("joint id = %d", jointName)).c_str(), ELL_DEBUG);

        scene::ISkinnedMesh::SJoint* joint = nullptr;
        //if (!_animatedMesh->getJointCount())
             joint = _animatedMesh->addJoint();
        //else
        //     joint = _animatedMesh->addJoint(_animatedMesh->getAllJoints()[0]);
        joint->Name = Strings[jointName];
    }

    // The matrix of the bones
    readBonesNumber(file);
    for (char i = 0; i < nbBones; ++i)
    {
        ISkinnedMesh::SJoint* joint = _animatedMesh->getAllJoints()[i];
        core::matrix4 matrix;

        // the matrix
        for (u32 j = 0; j < 16; ++j)
        {
            f32 value = readF32(file);
            matrix[j] = value;
        }


        core::vector3df position = matrix.getTranslation();
        core::matrix4 invRot;
        matrix.getInverse(invRot);
        //invRot.rotateVect(position);

        core::vector3df rotation = invRot.getRotationDegrees();       //vl: why this shit???
        //core::vector3df rotation = matrix.getRotationDegrees();

        position = - position;
        core::vector3df scale = matrix.getScale();

        if (joint)
        {
            //Build GlobalMatrix:
            core::matrix4 positionMatrix;
            positionMatrix.setTranslation(position);
            core::matrix4 rotationMatrix;
            rotationMatrix.setRotationDegrees(rotation);
            core::matrix4 scaleMatrix;
            scaleMatrix.setScale(scale);

            joint->GlobalMatrix = scaleMatrix * rotationMatrix * positionMatrix;
            joint->LocalMatrix = joint->GlobalMatrix;

            joint->Animatedposition = joint->LocalMatrix.getTranslation();
            joint->Animatedrotation = core::quaternion(joint->LocalMatrix.getRotationDegrees()).makeInverse();    // vl: why???
            //joint->Animatedrotation = core::quaternion(joint->LocalMatrix.getRotationDegrees()); 
            joint->Animatedscale = joint->LocalMatrix.getScale();

            CW3DataCache::_instance.addBoneEntry(joint->Name, matrix);
            joint->OffsetMatrix = matrix;
        }
    }

    // 1 float per bone ???
    readBonesNumber(file);
    for (char i = 0; i < nbBones; ++i)
    {
        float value = readF32(file);
        os::Printer::log((formatString("value = %f", value)).c_str(), ELL_DEBUG);
    }

    // 1 s32 par bone. parent ID ? no
    readBonesNumber(file);
    for (char i = 0; i < nbBones; ++i)
    {
        u32 unk = readU32(file);
        //std::cout << "= " << joints[parent]->Name.c_str() << "->" << joints[i]->Name.c_str() << std::endl;
    }
    os::Printer::log("Bones loaded", ELL_DEBUG);
}


scene::ISkinnedMesh* CW3EntLoader::ReadW2MESHFile(core::stringc filename)
{
    ISkinnedMesh* mesh = nullptr;
    io::IReadFile* meshFile = _fileSystem->createAndOpenFile(filename);
    if (!meshFile)
    {
        os::Printer::log((formatString("Fail to open the w2mesh file : %s", filename.c_str())).c_str(), ELL_ERROR);
    }
    else
    {
        CW3EntLoader w3Loader(_sceneManager, _fileSystem);
        mesh = reinterpret_cast<ISkinnedMesh*>(w3Loader.createMesh(meshFile));
        if (!mesh)
            os::Printer::log((formatString("Fail to load the w2mesh file : %s", filename.c_str())).c_str(), ELL_ERROR);

        meshFile->drop();
    }
    return mesh;
}

// In the materials, file can be w2mi (material) or w2mg (shader)
// We check that and load the material in the case of a w2mi file
video::SMaterial CW3EntLoader::ReadMaterialFile(core::stringc filename)
{
    if (core::hasFileExtension(filename, "w2mi"))
        return ReadW2MIFile(filename);
    else if (core::hasFileExtension(filename, "w2mg"))
        ; // shader, not handled
    else
        os::Printer::log((formatString("Unknown type of file for a material : %s", filename.c_str())).c_str(), ELL_ERROR);

    video::SMaterial material;
    return material;
}

video::SMaterial CW3EntLoader::ReadW2MIFile(core::stringc filename)
{
    os::Printer::log((formatString("Read W2MI : %s", filename.c_str())).c_str(), ELL_DEBUG);

    video::SMaterial material;
    io::path fullFilename = ConfigGameTexturesPath + filename;
    io::IReadFile* matFile = _fileSystem->createAndOpenFile(fullFilename);

    if (!matFile)
    {
        os::Printer::log((formatString("Fail to open the w2mi file : %s", fullFilename.c_str())).c_str(), ELL_ERROR);
    }
    else
    {
        CW3EntLoader w2miLoader(_sceneManager, _fileSystem);
        material = w2miLoader.createMaterial(matFile);
        matFile->drop();
    }

    return material;
}

video::SMaterial CW3EntLoader::W3_CMaterialInstance(io::IReadFile* file, W3_DataInfos infos)
{
    file->seek(infos.adress + 1);

    video::SMaterial mat;

    const s32 endOfChunk = infos.adress + infos.size;

    while (file->getPos() < endOfChunk)
    {
        os::Printer::log("Read property...", ELL_DEBUG);

        SPropertyHeader propHeader;
        u16 extra;
        bool rc = ReadPropertyHeader(file, propHeader, extra);

        if(propHeader.propName == "baseMaterial")
        {
            // base material
            u32 fileId = readU32(file);
            fileId = 0xFFFFFFFF - fileId;

            os::Printer::log("baseMat found", ELL_DEBUG);
            os::Printer::log((formatString("base material : %s", Files[fileId].c_str())).c_str(), ELL_DEBUG);
            mat = ReadMaterialFile(Files[fileId]);

            file->seek(propHeader.endPos);
        }
        else
        {
            os::Printer::log("non material found", ELL_DEBUG);
            // read and ignore
            file->seek(-2, true);
            video::SMaterial tempMat = ReadIMaterialProperty(file);
            if (extra > 0)
            {
                return tempMat;
            }
            return mat;
        }
         
        os::Printer::log("Done", ELL_DEBUG);
    }

    os::Printer::log("", ELL_DEBUG);
    return mat;
}


// Check the file format version and load the mesh if it's ok
bool CW3EntLoader::load(io::IReadFile* file)
{
    file->seek(4, true); // CR2W
    //core::stringc unused = readString(file, 4); // CR2W - this leaked memory.  Rather than allocate and read 4 bytes, just skip them

    const s32 fileFormatVersion = readS32(file);
    os::Printer::log((formatString("File format version : %d", fileFormatVersion)).c_str(), ELL_DEBUG);

    if (getTWFileFormatVersion(file) == REV_WITCHER_3)
    {
        return W3_load(file);
    }
    else
    {
        os::Printer::log("Incorrect file format version", ELL_ERROR);
        return false;
    }
}


video::ITexture* CW3EntLoader::getTexture(io::path filename)
{
    if (!core::hasFileExtension(filename.c_str(), "xbm"))
    {
        return _videoDriver->getTexture(filename);
    }

    video::ITexture* texture = nullptr;

    io::path fullFilename = ConfigGameTexturesPath + filename;
    if (_fileSystem->existFile(fullFilename))
    {
        texture = getMeshTextureLoader()->getTexture(fullFilename);
    }

    /*
    if (texture)
        return texture;

    // Else, if extracted with wcc_lite, we check all the possible filename
    core::array<io::path> possibleExtensions;
    possibleExtensions.push_back(".dds");
    possibleExtensions.push_back(".bmp");
    possibleExtensions.push_back(".jpg");
    possibleExtensions.push_back(".jpeg");
    possibleExtensions.push_back(".tga");
    possibleExtensions.push_back(".png");

    io::path baseFilename;
    core::cutFilenameExtension(baseFilename, filename);

    for (u32 i = 0; i < possibleExtensions.size(); ++i)
    {
        filename = ConfigGameTexturesPath + baseFilename + possibleExtensions[i];

        if (_fileSystem->existFile(filename))
            texture = _sceneManager->getVideoDriver()->getTexture(filename);

        if (texture)
            return texture;
    }
    */

    return texture;
}

s32 CW3EntLoader::getTextureLayerFromTextureType(core::stringc textureType)
{
    if (textureType == "Diffuse")
        return 0;
    else if (textureType == "Normal")
        return 1;
    else
        return -1;
}


} // end namespace scene
} // end namespace irr


#endif // _IRR_COMPILE_WITH_W3ENT_LOADER_

