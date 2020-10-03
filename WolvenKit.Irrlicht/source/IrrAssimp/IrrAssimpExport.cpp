#include "IrrAssimpExport.h"
#include <iostream>

using namespace irr;

IrrAssimpExport::IrrAssimpExport() : AssimpScene(0)
{
    //ctor
}

IrrAssimpExport::~IrrAssimpExport()
{
    //dtor
}

aiColor3D IrrToAssimpColor(video::SColor color)
{
    return aiColor3D(color.getRed() / 255.f, color.getGreen() / 255.f, color.getBlue() / 255.f);
}

aiVector3D IrrToAssimpVector(core::vector3df vect)
{
    return aiVector3D(vect.X, vect.Y, vect.Z);
}

aiQuaternion IrrToAssimpQuaternion(core::quaternion quat)
{
    return aiQuaternion(quat.W, quat.X, quat.Y, quat.Z);
}

aiMatrix4x4 IrrToAssimpMatrix(core::matrix4 irrMatrix)
{
    aiMatrix4x4 assimpMatrix;

    assimpMatrix.a1 = irrMatrix[0];
    assimpMatrix.b1 = irrMatrix[1];
    assimpMatrix.c1 = irrMatrix[2];
    assimpMatrix.d1 = irrMatrix[3];

    assimpMatrix.a2 = irrMatrix[4];
    assimpMatrix.b2 = irrMatrix[5];
    assimpMatrix.c2 = irrMatrix[6];
    assimpMatrix.d2 = irrMatrix[7];

    assimpMatrix.a3 = irrMatrix[8];
    assimpMatrix.b3 = irrMatrix[9];
    assimpMatrix.c3 = irrMatrix[10];
    assimpMatrix.d3 = irrMatrix[11];

    assimpMatrix.a4 = irrMatrix[12];
    assimpMatrix.b4 = irrMatrix[13];
    assimpMatrix.c4 = irrMatrix[14];
    assimpMatrix.d4 = irrMatrix[15];

    return assimpMatrix;
}

core::array<scene::ISkinnedMesh::SJoint*> getRootJoints(const scene::ISkinnedMesh* mesh)
{
    core::array<scene::ISkinnedMesh::SJoint*> roots;

    core::array<scene::ISkinnedMesh::SJoint*> allJoints = mesh->getAllJoints();
    for (u32 i = 0; i < allJoints.size(); i++)
    {
        bool isRoot = true;
        scene::ISkinnedMesh::SJoint* testedJoint = allJoints[i];
        for (u32 j = 0; j < allJoints.size(); j++)
        {
           scene::ISkinnedMesh::SJoint* testedJoint2 = allJoints[j];
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

aiNode* IrrAssimpExport::createNode(const scene::ISkinnedMesh::SJoint* joint)
{
    aiNode* node = new aiNode();
    node->mName = aiString(joint->Name.c_str());
    node->mTransformation = IrrToAssimpMatrix(joint->LocalMatrix);

    node->mNumMeshes = joint->AttachedMeshes.size();
    node->mMeshes = new unsigned int[joint->AttachedMeshes.size()];
    for (u32 i = 0; i < joint->AttachedMeshes.size(); ++i)
    {
        node->mMeshes[i] = joint->AttachedMeshes[i];
    }

    node->mNumChildren = joint->Children.size();
    node->mChildren = new aiNode*[joint->Children.size()];
    for (u32 i = 0; i < joint->Children.size(); ++i)
    {
        aiNode* child = createNode(joint->Children[i]);
        node->mChildren[i] = child;
    }
    return node;
}

void IrrAssimpExport::createAnimations(const irr::scene::ISkinnedMesh* mesh)
{
    if (mesh->getFrameCount() == 0)
    {
        AssimpScene->mNumAnimations = 0;
        return;
    }
    // irr mesh anim is per frame, fbx uses seconds, find denominator
    double fts = 0;
    if (mesh->getAnimationSpeed() > 0)
        fts = 1.0 / mesh->getAnimationSpeed();

    AssimpScene->mNumAnimations = 1;
    AssimpScene->mAnimations = new aiAnimation*[1];
    AssimpScene->mAnimations[0] = new aiAnimation();

    AssimpScene->mAnimations[0]->mChannels = new aiNodeAnim*[mesh->getJointCount()];
    AssimpScene->mAnimations[0]->mNumChannels = mesh->getJointCount();

    AssimpScene->mAnimations[0]->mDuration = mesh->getFrameCount();
    AssimpScene->mAnimations[0]->mTicksPerSecond = mesh->getAnimationSpeed();
    AssimpScene->mAnimations[0]->mName = aiString("default");

    for (u32 i = 0; i < mesh->getJointCount(); ++i)
    {
        const scene::ISkinnedMesh::SJoint* joint = mesh->getAllJoints()[i];

        AssimpScene->mAnimations[0]->mChannels[i] = new aiNodeAnim();
        AssimpScene->mAnimations[0]->mChannels[i]->mNodeName = aiString(joint->Name.c_str());


        AssimpScene->mAnimations[0]->mChannels[i]->mNumPositionKeys = joint->PositionKeys.size();
        AssimpScene->mAnimations[0]->mChannels[i]->mPositionKeys = new aiVectorKey[joint->PositionKeys.size()];
        for (u32 j = 0; j < joint->PositionKeys.size(); ++j)
        {
            const scene::ISkinnedMesh::SPositionKey key = joint->PositionKeys[j];

            AssimpScene->mAnimations[0]->mChannels[i]->mPositionKeys[j].mTime = key.frame * fts;
            AssimpScene->mAnimations[0]->mChannels[i]->mPositionKeys[j].mValue = IrrToAssimpVector(key.position);
        }

        AssimpScene->mAnimations[0]->mChannels[i]->mNumRotationKeys = joint->RotationKeys.size();
        AssimpScene->mAnimations[0]->mChannels[i]->mRotationKeys = new aiQuatKey[joint->RotationKeys.size()];
        for (u32 j = 0; j < joint->RotationKeys.size(); ++j)
        {
            scene::ISkinnedMesh::SRotationKey key = joint->RotationKeys[j];

            AssimpScene->mAnimations[0]->mChannels[i]->mRotationKeys[j].mTime = key.frame * fts;
            //AssimpScene->mAnimations[0]->mChannels[i]->mRotationKeys[j].mValue = IrrToAssimpQuaternion(key.rotation);
            AssimpScene->mAnimations[0]->mChannels[i]->mRotationKeys[j].mValue = IrrToAssimpQuaternion(key.rotation.makeInverse());
        }

        AssimpScene->mAnimations[0]->mChannels[i]->mNumScalingKeys = joint->ScaleKeys.size();
        AssimpScene->mAnimations[0]->mChannels[i]->mScalingKeys = new aiVectorKey[joint->ScaleKeys.size()];
        for (u32 j = 0; j < joint->ScaleKeys.size(); ++j)
        {
            const scene::ISkinnedMesh::SScaleKey key = joint->ScaleKeys[j];

            AssimpScene->mAnimations[0]->mChannels[i]->mScalingKeys[j].mTime = key.frame * fts;
            AssimpScene->mAnimations[0]->mChannels[i]->mScalingKeys[j].mValue = IrrToAssimpVector(key.scale);
        }
    }
}

void IrrAssimpExport::createMaterials(const scene::IMesh* mesh)
{
    AssimpScene->mNumMaterials = mesh->getMeshBufferCount();
    AssimpScene->mMaterials = new aiMaterial*[AssimpScene->mNumMaterials];
    for (unsigned int i = 0; i < mesh->getMeshBufferCount(); ++i)
    {
        AssimpScene->mMaterials[i] = new aiMaterial();
        AssimpScene->mMaterials[i]->mNumProperties = 0;


        video::SMaterial mat = mesh->getMeshBuffer(i)->getMaterial();

        aiColor3D diffuseColor = IrrToAssimpColor(mat.DiffuseColor);
        aiColor3D ambiantColor = IrrToAssimpColor(mat.AmbientColor);
        aiColor3D emissiveColor = IrrToAssimpColor(mat.EmissiveColor);
        aiColor3D specularColor = IrrToAssimpColor(mat.SpecularColor);
        float shininess = mat.Shininess;

        AssimpScene->mMaterials[i]->AddProperty(&diffuseColor, 1, AI_MATKEY_COLOR_DIFFUSE);
        AssimpScene->mMaterials[i]->AddProperty(&ambiantColor, 1, AI_MATKEY_COLOR_AMBIENT);
        AssimpScene->mMaterials[i]->AddProperty(&emissiveColor, 1, AI_MATKEY_COLOR_EMISSIVE);
        AssimpScene->mMaterials[i]->AddProperty(&specularColor, 1, AI_MATKEY_COLOR_SPECULAR);
        AssimpScene->mMaterials[i]->AddProperty(&shininess, 1, AI_MATKEY_SHININESS);

        if (mat.getTexture(0))
        {
            aiString textureName = aiString(to_char_string(mat.getTexture(0)->getName().getPath()).c_str());
            AssimpScene->mMaterials[i]->AddProperty(&textureName, AI_MATKEY_TEXTURE_DIFFUSE(0));
        }
        if (mat.getTexture(1))
        {
            // Normal map
            if (   mat.MaterialType == video::EMT_NORMAL_MAP_SOLID
                || mat.MaterialType == video::EMT_NORMAL_MAP_TRANSPARENT_ADD_COLOR
                || mat.MaterialType == video::EMT_NORMAL_MAP_TRANSPARENT_VERTEX_ALPHA
                || mat.MaterialType == video::EMT_PARALLAX_MAP_SOLID
                || mat.MaterialType == video::EMT_PARALLAX_MAP_TRANSPARENT_ADD_COLOR
                || mat.MaterialType == video::EMT_PARALLAX_MAP_TRANSPARENT_VERTEX_ALPHA)
            {
                aiString textureName = aiString(to_char_string(mat.getTexture(1)->getName().getPath()).c_str());
                AssimpScene->mMaterials[i]->AddProperty(&textureName, AI_MATKEY_TEXTURE_NORMALS(0));
            }

        }
    }
}

void IrrAssimpExport::createMeshes(scene::IMesh* mesh)
{
    AssimpScene->mNumMeshes = mesh->getMeshBufferCount();
    AssimpScene->mMeshes = new aiMesh*[AssimpScene->mNumMeshes];
    for (unsigned int i = 0; i < mesh->getMeshBufferCount(); ++i)
    {
        aiMesh* assimpMesh = new aiMesh();
        irr::scene::IMeshBuffer* buffer = mesh->getMeshBuffer(i);
        video::E_VERTEX_TYPE verticesType = buffer->getVertexType();

        assimpMesh->mNumVertices = buffer->getVertexCount();
        assimpMesh->mVertices = new aiVector3D[assimpMesh->mNumVertices];
        assimpMesh->mNormals = new aiVector3D[assimpMesh->mNumVertices];

        assimpMesh->mTextureCoords[0] = new aiVector3D[assimpMesh->mNumVertices];
        assimpMesh->mNumUVComponents[0] = 2;

        assimpMesh->mColors[0] = new aiColor4D[assimpMesh->mNumVertices];

        if (verticesType == video::EVT_2TCOORDS)
        {
            assimpMesh->mTextureCoords[1] = new aiVector3D[assimpMesh->mNumVertices];
            assimpMesh->mNumUVComponents[1] = 2;
        }
        if (verticesType == video::EVT_TANGENTS)
        {
            assimpMesh->mTangents = new aiVector3D[assimpMesh->mNumVertices];
            assimpMesh->mBitangents = new aiVector3D[assimpMesh->mNumVertices];
        }

        video::S3DVertex* vertices = (video::S3DVertex*)buffer->getVertices();

        video::S3DVertex2TCoords* tCoordsVertices;
        verticesType == video::EVT_2TCOORDS ? tCoordsVertices = (video::S3DVertex2TCoords*) vertices : tCoordsVertices = 0;

        video::S3DVertexTangents* tangentsVertices;
        verticesType == video::EVT_TANGENTS ? tangentsVertices = (video::S3DVertexTangents*) vertices : tangentsVertices = 0;

        for (unsigned int j = 0; j < buffer->getVertexCount(); ++j)
        {
            video::S3DVertex vertex = vertices[j];

            core::vector3df position = vertex.Pos;
            core::vector3df normal = vertex.Normal;
            core::vector2df uv = vertex.TCoords;
            video::SColor color = vertex.Color;

            assimpMesh->mVertices[j] = aiVector3D(position.X, position.Y, position.Z);
            assimpMesh->mNormals[j] = aiVector3D(normal.X, normal.Y, normal.Z);
            assimpMesh->mTextureCoords[0][j] = aiVector3D(uv.X, uv.Y, 0);
            assimpMesh->mColors[0][j] = aiColor4D(color.getRed() / 255.f, color.getGreen() / 255.f, color.getBlue() / 255.f, color.getAlpha() / 255.f);

            if (verticesType == video::EVT_2TCOORDS)
            {
                video::S3DVertex2TCoords tCoordsVertex = tCoordsVertices[j];
                core::vector2df uv2 = tCoordsVertex.TCoords2;
                assimpMesh->mTextureCoords[1][j] = aiVector3D(uv2.X, uv2.Y, 0);
            }
            if (verticesType == video::EVT_TANGENTS)
            {
                video::S3DVertexTangents tangentsVertex = tangentsVertices[j];
                core::vector3df tangent = tangentsVertex.Tangent;
                core::vector3df binormal = tangentsVertex.Binormal;

                assimpMesh->mTangents[j] = aiVector3D(tangent.X, tangent.Y, tangent.Z);
                assimpMesh->mBitangents[j] = aiVector3D(binormal.X, binormal.Y, binormal.Z);
            }
        }

        assimpMesh->mNumFaces = buffer->getIndexCount() / 3;
        assimpMesh->mFaces = new aiFace[assimpMesh->mNumFaces];
        for (unsigned int j = 0; j < assimpMesh->mNumFaces; ++j)
        {
            aiFace face;
            face.mNumIndices = 3;
            face.mIndices = new unsigned int[3];
            face.mIndices[0] = buffer->getIndices()[3 * j + 0];
            face.mIndices[1] = buffer->getIndices()[3 * j + 1];
            face.mIndices[2] = buffer->getIndices()[3 * j + 2];
            assimpMesh->mFaces[j] = face;
        }

        assimpMesh->mMaterialIndex = i;
        assimpMesh->mPrimitiveTypes = aiPrimitiveType::aiPrimitiveType_TRIANGLE;

        // bones and weights
        
        if (mesh->getMeshType() == scene::EAMT_SKINNED)
        {
            scene::ISkinnedMesh* skinned = static_cast<scene::ISkinnedMesh*>(mesh);
            const u32 nbOfBones = skinned->getJointCount();

            u32 bonesCounter = 0;
            aiBone** bones = new aiBone*[nbOfBones];
            for (u32 j = 0; j < nbOfBones; ++j)
            {
                const scene::ISkinnedMesh::SJoint* joint = skinned->getAllJoints()[j];
                if (joint->Weights.size() > 0)
                {
                    
                    bones[bonesCounter] = new aiBone();
                    
                    bones[bonesCounter]->mName = aiString(joint->Name.c_str());
                    aiMatrix4x4 aiMatx;
                    //assimpMesh->mBones[j]->mOffsetMatrix = IrrToAssimpMatrix(joint->OffsetMatrix);
                    bones[bonesCounter]->mOffsetMatrix = IrrToAssimpMatrix(joint->OffsetMatrix);
                    bones[bonesCounter]->mNumWeights = joint->Weights.size();

                    bones[bonesCounter]->mWeights = new aiVertexWeight[joint->Weights.size()];
                    for (u32 k = 0; k < bones[bonesCounter]->mNumWeights; ++k)
                    {
                        //assimpMesh->mBones[j]->mWeights[k] = new aiVertexWeight();
                        bones[bonesCounter]->mWeights[k].mVertexId = joint->Weights[k].vertex_id;
                        bones[bonesCounter]->mWeights[k].mWeight = joint->Weights[k].strength;
                    }
                    ++bonesCounter;
                }
            }
            assimpMesh->mBones = new aiBone * [bonesCounter];
            for (u32 j = 0; j < nbOfBones; ++j)
            {
                assimpMesh->mBones[j] = bones[j];
            }
            assimpMesh->mNumBones = bonesCounter;
            
            delete[] bones;
            
        }
        
        AssimpScene->mMeshes[i] = assimpMesh;
    }
}



void IrrAssimpExport::writeFile(scene::IMesh* mesh, core::stringc format, core::stringc filename)
{
    Assimp::Exporter exporter;
	
    AssimpScene = new aiScene();

    AssimpScene->mRootNode = new aiNode("ROOT");
	AssimpScene->mRootNode->mNumMeshes = mesh->getMeshBufferCount();
    AssimpScene->mRootNode->mMeshes = new unsigned int[mesh->getMeshBufferCount()];
    for (unsigned int i = 0; i < mesh->getMeshBufferCount(); ++i)
        AssimpScene->mRootNode->mMeshes[i] = i;
		
    // Load materials
    createMaterials(mesh);

    // Load meshes
    createMeshes(mesh);
	
	
#if (IRRLICHT_VERSION_MAJOR >= 2) || (IRRLICHT_VERSION_MAJOR == 1 && IRRLICHT_VERSION_MINOR >= 9)
	if (mesh->getMeshType() == scene::EAMT_SKINNED)
    {
		scene::ISkinnedMesh* skinned = static_cast<scene::ISkinnedMesh*>(mesh);
        createAnimations(skinned);

        core::array<scene::ISkinnedMesh::SJoint*> roots = getRootJoints(skinned);
        AssimpScene->mRootNode->mNumChildren = roots.size();
        AssimpScene->mRootNode->mChildren = new aiNode*[roots.size()];
        for (u32 i = 0; i < roots.size(); ++i)
        {
            AssimpScene->mRootNode->mChildren[i] = createNode(roots[i]);
        }
    }
#endif

    exporter.Export(AssimpScene, format.c_str(), to_char_string(filename).c_str(), aiProcess_FlipUVs);


	// Delete the scene
	delete AssimpScene->mRootNode;
	AssimpScene->mRootNode = 0;

    /*
    for (unsigned int i = 0; i < AssimpScene->mNumMeshes; ++i)
        delete AssimpScene->mMeshes[i]; */
	delete[] AssimpScene->mMeshes;
	AssimpScene->mMeshes = 0;

	for (unsigned int i = 0; i < AssimpScene->mNumMaterials; ++i)
		delete AssimpScene->mMaterials[i];
	delete[] AssimpScene->mMaterials;
	AssimpScene->mMaterials = 0;

	if (AssimpScene->HasAnimations())
	{
		for (unsigned int i = 0; i < AssimpScene->mNumAnimations; ++i)
			delete AssimpScene->mAnimations[i];
		delete[] AssimpScene->mAnimations;
		AssimpScene->mAnimations = 0;
	}

	delete AssimpScene;
}

