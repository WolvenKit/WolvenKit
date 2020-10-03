#include "IrrAssimpImport.h"
#include <iostream>

using namespace irr;

IrrAssimpImport::IrrAssimpImport(scene::ISceneManager* smgr) : Smgr(smgr), FileSystem(smgr->getFileSystem())
{
    //ctor
}

IrrAssimpImport::~IrrAssimpImport()
{
    //dtor
}

void Log(core::vector3df vect)
{
    std::cout << "Vector = " << vect.X << ", " << vect.Y << ", " << vect.Z << std::endl;
}

core::matrix4 AssimpToIrrMatrix(aiMatrix4x4 assimpMatrix)
{
    core::matrix4 irrMatrix;

    irrMatrix[0] = assimpMatrix.a1;
    irrMatrix[1] = assimpMatrix.b1;
    irrMatrix[2] = assimpMatrix.c1;
    irrMatrix[3] = assimpMatrix.d1;

    irrMatrix[4] = assimpMatrix.a2;
    irrMatrix[5] = assimpMatrix.b2;
    irrMatrix[6] = assimpMatrix.c2;
    irrMatrix[7] = assimpMatrix.d2;

    irrMatrix[8] = assimpMatrix.a3;
    irrMatrix[9] = assimpMatrix.b3;
    irrMatrix[10] = assimpMatrix.c3;
    irrMatrix[11] = assimpMatrix.d3;

    irrMatrix[12] = assimpMatrix.a4;
    irrMatrix[13] = assimpMatrix.b4;
    irrMatrix[14] = assimpMatrix.c4;
    irrMatrix[15] = assimpMatrix.d4;

    return irrMatrix;
}


scene::ISkinnedMesh::SJoint* IrrAssimpImport::findJoint(const core::stringc jointName)
{
    for (unsigned int i = 0; i < Mesh->getJointCount(); ++i)
    {
        if (core::stringc(Mesh->getJointName(i)) == jointName)
            return Mesh->getAllJoints()[i];
    }
    std::cout << "Error, no joint" << std::endl;
    return 0;
}

aiNode* IrrAssimpImport::findNode(const aiString jointName)
{
    if (AssimpScene->mRootNode->mName == jointName)
        return AssimpScene->mRootNode;

    return AssimpScene->mRootNode->FindNode(jointName);
}

void IrrAssimpImport::createNode(const aiNode* node)
{
    scene::ISkinnedMesh::SJoint* jointParent = 0;

    if (node->mParent != 0)
    {
        jointParent = findJoint(node->mParent->mName.C_Str());
    }

    scene::ISkinnedMesh::SJoint* joint = Mesh->addJoint(jointParent);
    joint->Name = node->mName.C_Str();
    joint->LocalMatrix = AssimpToIrrMatrix(node->mTransformation);

    if (jointParent)
        joint->GlobalMatrix = jointParent->GlobalMatrix * joint->LocalMatrix;
    else
        joint->GlobalMatrix = joint->LocalMatrix;

    for (unsigned int i = 0; i < node->mNumMeshes; ++i)
    {
        joint->AttachedMeshes.push_back(node->mMeshes[i]);
    }

    for (unsigned int i = 0; i < node->mNumChildren; ++i)
    {
        aiNode* childNode = node->mChildren[i];
        createNode(childNode);
    }
}

video::SColor AssimpToIrrColor(const aiColor4D color)
{
    return video::SColor(static_cast<u32>(color.a * 255), static_cast<u32>(color.r * 255), static_cast<u32>(color.g * 255), static_cast<u32>(color.b * 255));
}

video::ITexture* IrrAssimpImport::getTexture(core::stringc path, core::stringc fileDir)
{
    video::ITexture* texture = 0;

    if (FileSystem->existFile(path.c_str()))
        texture = Smgr->getVideoDriver()->getTexture(path.c_str());
    else if (FileSystem->existFile(fileDir + "/" + path.c_str()))
        texture = Smgr->getVideoDriver()->getTexture(fileDir + "/" + path.c_str());
    else if (FileSystem->existFile(fileDir + "/" + FileSystem->getFileBasename(path.c_str())))
        texture = Smgr->getVideoDriver()->getTexture(fileDir + "/" + FileSystem->getFileBasename(path.c_str()));

    return texture;
    // TODO after 1.9 release : Rewrite this with IMeshTextureLoader
}


bool IrrAssimpImport::isALoadableFileExtension(const io::path& filename) const
{
    Assimp::Importer importer;

    io::path extension;
    core::getFileNameExtension(extension, filename);
    return importer.IsExtensionSupported (to_char_string(extension).c_str());
}

scene::IAnimatedMesh* IrrAssimpImport::createMesh(io::IReadFile* file)
{
    FilePath = file->getFileName();

    Assimp::Importer Importer;
    AssimpScene = Importer.ReadFile(to_char_string(FilePath).c_str(), aiProcess_Triangulate | aiProcess_GenSmoothNormals | aiProcess_FlipUVs);
    if (!AssimpScene)
    {
        Error = Importer.GetErrorString();
        return 0;
    }
    else
        Error = "";

    // Create mesh
    Mesh = Smgr->createSkinnedMesh();

    // Load materials
    createMaterials();

    // Load nodes
    const aiNode* root = AssimpScene->mRootNode;
    createNode(root);

    // Load meshes
    createMeshes();

    // Load animations
    createAnimation();

    Mesh->setDirty();
    Mesh->finalize();

    return Mesh;
}

void IrrAssimpImport::createMaterials()
{
    // Basic material support
    const core::stringc fileDir = FileSystem->getFileDir(FilePath);
    Mats.clear();
    for (unsigned int i = 0; i < AssimpScene->mNumMaterials; ++i)
    {
        video::SMaterial material;
        material.MaterialType = video::EMT_SOLID;

        aiMaterial* mat = AssimpScene->mMaterials[i];

        aiColor4D color;
        if(AI_SUCCESS == aiGetMaterialColor(mat, AI_MATKEY_COLOR_DIFFUSE, &color)) {
            material.DiffuseColor = AssimpToIrrColor(color);
        }
        if(AI_SUCCESS == aiGetMaterialColor(mat, AI_MATKEY_COLOR_AMBIENT, &color)) {
            material.AmbientColor = AssimpToIrrColor(color);
        }
        if(AI_SUCCESS == aiGetMaterialColor(mat, AI_MATKEY_COLOR_EMISSIVE, &color)) {
            material.EmissiveColor = AssimpToIrrColor(color);
        }
        if(AI_SUCCESS == aiGetMaterialColor(mat, AI_MATKEY_COLOR_SPECULAR, &color)) {
            material.SpecularColor = AssimpToIrrColor(color);
        }
        float shininess;
        if(AI_SUCCESS == aiGetMaterialFloat(mat, AI_MATKEY_SHININESS, &shininess)) {
            material.Shininess = shininess;
        }


        if (mat->GetTextureCount(aiTextureType_DIFFUSE) > 0)
        {
            aiString path;
            mat->GetTexture(aiTextureType_DIFFUSE, 0, &path);

            video::ITexture* diffuseTexture = getTexture(path.C_Str(), fileDir);
            material.setTexture(0, diffuseTexture);
        }
        if (mat->GetTextureCount(aiTextureType_NORMALS) > 0)
        {
            aiString path;
            mat->GetTexture(aiTextureType_NORMALS, 0, &path);

            video::ITexture* normalsTexture = getTexture(path.C_Str(), fileDir);
            if (normalsTexture)
            {
                material.setTexture(1, normalsTexture);
                material.MaterialType = video::EMT_PARALLAX_MAP_SOLID;
            }
        }

        Mats.push_back(material);
    }
}

void IrrAssimpImport::createMeshes()
{
    for (unsigned int i = 0; i < AssimpScene->mNumMeshes; ++i)
    {
        //std::cout << "i=" << i << " of " << AssimpScene->mNumMeshes << std::endl;
        aiMesh* paiMesh = AssimpScene->mMeshes[i];

        scene::SSkinMeshBuffer* buffer = Mesh->addMeshBuffer();

        buffer->Vertices_Standard.reallocate(paiMesh->mNumVertices);
        buffer->Vertices_Standard.set_used(paiMesh->mNumVertices);

        for (unsigned int j = 0; j < paiMesh->mNumVertices; ++j)
        {
            const aiVector3D vertex = paiMesh->mVertices[j];
            buffer->Vertices_Standard[j].Pos = core::vector3df(vertex.x, vertex.y, vertex.z);

            if (paiMesh->HasNormals())
            {
                const aiVector3D normal = paiMesh->mNormals[j];
                buffer->Vertices_Standard[j].Normal = core::vector3df(normal.x, normal.y, normal.z);
            }

            if (paiMesh->HasVertexColors(0))
            {
                const aiColor4D color = paiMesh->mColors[0][j];
                buffer->Vertices_Standard[j].Color = AssimpToIrrColor(color);
            }
            else
            {
                buffer->Vertices_Standard[j].Color = video::SColor(255, 255, 255, 255);
            }

            if (paiMesh->GetNumUVChannels() > 0)
            {
                const aiVector3D uv = paiMesh->mTextureCoords[0][j];
                buffer->Vertices_Standard[j].TCoords = core::vector2df(uv.x, uv.y);
            }
        }
        if (paiMesh->HasTangentsAndBitangents())
        {
            buffer->convertToTangents();
            for (unsigned int j = 0; j < paiMesh->mNumVertices; ++j)
            {
                aiVector3D tangent = paiMesh->mTangents[j];
                aiVector3D bitangent = paiMesh->mBitangents[j];
                buffer->Vertices_Tangents[j].Tangent = core::vector3df(tangent.x, tangent.y, tangent.z);
                buffer->Vertices_Tangents[j].Binormal = core::vector3df(bitangent.x, bitangent.y, bitangent.z);
            }
        }
        if (paiMesh->GetNumUVChannels() > 1)
        {
            buffer->convertTo2TCoords();
            for (unsigned int j = 0; j < paiMesh->mNumVertices; ++j)
            {
                const aiVector3D uv = paiMesh->mTextureCoords[0][j];
                buffer->Vertices_2TCoords[j].TCoords2 = core::vector2df(uv.x, uv.y);
            }
        }


        buffer->Indices.reallocate(paiMesh->mNumFaces * 3);
        buffer->Indices.set_used(paiMesh->mNumFaces * 3);

        for (unsigned int j = 0; j < paiMesh->mNumFaces; ++j)
        {
            const aiFace face = paiMesh->mFaces[j];

            buffer->Indices[3*j] = face.mIndices[0];
            buffer->Indices[3*j + 1] = face.mIndices[1];
            buffer->Indices[3*j + 2] = face.mIndices[2];
        }

        buffer->Material = Mats[paiMesh->mMaterialIndex];
        buffer->recalculateBoundingBox();

        if (!paiMesh->HasNormals())
            Smgr->getMeshManipulator()->recalculateNormals(buffer);


        // Skinning
        buildSkinnedVertexArray(buffer);
        for (unsigned int j = 0; j < paiMesh->mNumBones; ++j)
        {
            aiBone* bone = paiMesh->mBones[j];

            scene::ISkinnedMesh::SJoint* joint = findJoint(core::stringc(bone->mName.C_Str()));
            if (joint == 0)
            {
                std::cout << "Error, no joint" << std::endl;
                continue;
            }

            /* The old version
            core::matrix4 boneOffset = AssimpToIrrMatrix(bone->mOffsetMatrix);
            core::matrix4 invBoneOffset;
            boneOffset.getInverse(invBoneOffset);

            core::matrix4 rotationMatrix;
            rotationMatrix.setRotationDegrees(invBoneOffset.getRotationDegrees());
            core::matrix4 translationMatrix;
            translationMatrix.setTranslation(boneOffset.getTranslation());
			core::matrix4 scaleMatrix;
            scaleMatrix.setScale(invBoneOffset.getScale());

            core::matrix4 globalBoneMatrix = scaleMatrix * rotationMatrix * translationMatrix;
            globalBoneMatrix.setInverseTranslation(globalBoneMatrix.getTranslation());

            joint->GlobalMatrix = globalBoneMatrix;
            // And compute the local from global after (joint->LocalMatrix = invGlobalParent * joint->GlobalMatrix; if it's not a root)
            */


            for (unsigned int h = 0; h < bone->mNumWeights; ++h)
            {
                aiVertexWeight weight = bone->mWeights[h];
                scene::ISkinnedMesh::SWeight* w = Mesh->addWeight(joint);
                w->buffer_id = Mesh->getMeshBufferCount() - 1;
                w->strength = weight.mWeight;
                w->vertex_id = weight.mVertexId;
            }

            skinJoint(joint, bone);
        }
        applySkinnedVertexArray(buffer);
    }
}

void IrrAssimpImport::createAnimation()
{
    int frameOffset = 0;
    for (unsigned int i = 0; i < AssimpScene->mNumAnimations; ++i)
    {
        aiAnimation* anim = AssimpScene->mAnimations[i];

        if (anim->mTicksPerSecond != 0.f)
        {
            Mesh->setAnimationSpeed(anim->mTicksPerSecond);
        }
		// Some loader of assimp give time in second for keyframe instead of frame number, which cause bug when casted to int
        if (anim->mTicksPerSecond == 1)
            Mesh->setAnimationSpeed(Mesh->getAnimationSpeed() * 60.f);

        //std::cout << "numChannels : " << anim->mNumChannels << std::endl;
        for (unsigned int j = 0; j < anim->mNumChannels; ++j)
        {
            aiNodeAnim* nodeAnim = anim->mChannels[j];
            scene::ISkinnedMesh::SJoint* joint = findJoint(nodeAnim->mNodeName.C_Str());

            for (unsigned int k = 0; k < nodeAnim->mNumPositionKeys; ++k)
            {
                aiVectorKey key = nodeAnim->mPositionKeys[k];

                scene::ISkinnedMesh::SPositionKey* irrKey = Mesh->addPositionKey(joint);

                irrKey->frame = key.mTime + frameOffset;
                if (anim->mTicksPerSecond == 1)
                    irrKey->frame *= 60.f;
                irrKey->position = core::vector3df(key.mValue.x, key.mValue.y, key.mValue.z);
            }
            for (unsigned int k = 0; k < nodeAnim->mNumRotationKeys; ++k)
            {
                aiQuatKey key = nodeAnim->mRotationKeys[k];
                aiQuaternion assimpQuat = key.mValue;

                core::quaternion quat (-assimpQuat.x, -assimpQuat.y, -assimpQuat.z, assimpQuat.w);
				quat.normalize();

                scene::ISkinnedMesh::SRotationKey* irrKey = Mesh->addRotationKey(joint);

                irrKey->frame = key.mTime + frameOffset;
                if (anim->mTicksPerSecond == 1)
                    irrKey->frame *= 60.f;
                irrKey->rotation = quat;
            }
            for (unsigned int k = 0; k < nodeAnim->mNumScalingKeys; ++k)
            {
                aiVectorKey key = nodeAnim->mScalingKeys[k];

                scene::ISkinnedMesh::SScaleKey* irrKey = Mesh->addScaleKey(joint);

                irrKey->frame = key.mTime + frameOffset;
                if (anim->mTicksPerSecond == 1)
                    irrKey->frame *= 60.f;
                irrKey->scale = core::vector3df(key.mValue.x, key.mValue.y, key.mValue.z);
            }

        }

        frameOffset += anim->mDuration;
    }
}

// Adapted from http://sourceforge.net/p/assimp/discussion/817654/thread/5462cbf5
void IrrAssimpImport::skinJoint(scene::ISkinnedMesh::SJoint *joint, aiBone* bone)
{
	if (bone->mNumWeights)
	{
	    core::matrix4 boneOffset = AssimpToIrrMatrix(bone->mOffsetMatrix);
	    core::matrix4 boneMat = joint->GlobalMatrix * boneOffset; //* InverseRootNodeWorldTransform;

        const u32 bufferId = Mesh->getMeshBufferCount() - 1;

		for (u32 i = 0; i < bone->mNumWeights; ++i)
		{
		    const aiVertexWeight weight = bone->mWeights[i];
			const u32 vertexId = weight.mVertexId;

			core::vector3df sourcePos = Mesh->getMeshBuffer(bufferId)->getPosition(vertexId);
			core::vector3df sourceNorm = Mesh->getMeshBuffer(bufferId)->getNormal(vertexId);
			core::vector3df destPos, destNormal;
			boneMat.transformVect(destPos, sourcePos);
			boneMat.rotateVect(destNormal, sourceNorm);

			skinnedVertex[vertexId].Moved = true;
            skinnedVertex[vertexId].Position += destPos * weight.mWeight;
            skinnedVertex[vertexId].Normal += destNormal * weight.mWeight;
		}
	}
}

void IrrAssimpImport::buildSkinnedVertexArray(scene::IMeshBuffer* buffer)
{
    skinnedVertex.clear();

    skinnedVertex.reallocate(buffer->getVertexCount());
    for (u32 i = 0; i < buffer->getVertexCount(); ++i)
    {
        skinnedVertex.push_back(SkinnedVertex());
    }

}

void IrrAssimpImport::applySkinnedVertexArray(scene::IMeshBuffer* buffer)
{
    for (u32 i = 0; i < buffer->getVertexCount(); ++i)
    {
        if (skinnedVertex[i].Moved)
        {
            buffer->getPosition(i) = skinnedVertex[i].Position;
            buffer->getNormal(i) = skinnedVertex[i].Normal;
        }
    }
    skinnedVertex.clear();
}
