//This software contains Autodesk® FBX® code developed by Autodesk, Inc. Copyright 2008 Autodesk, Inc. 
//All rights, reserved. Such code is provided "as is" and Autodesk, Inc. disclaims any and all warranties, 
//whether express or implied, including without limitation the implied warranties of merchantability,
//fitness for a particular purpose or non-infringement of third party rights.
//In no event shall Autodesk, Inc. be liable for any direct, indirect, incidental, special, exemplary,
//or consequential damages (including, but not limited to, procurement of substitute goods or services;
//loss of use, data, or profits; or business interruption) however caused and on any theory of liability,
//whether in contract, strict liability, or tort (including negligence or otherwise) arising in any way out of such code."

// Adapted for irrlicht by vonLeebpl vonleebpl(at)gmail.com

// Modified version with rigging/skinning support
// it's ugly way of calling collada writer first creating fbx scene 
// and import collada and then export with native fbx exporter

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_FBX_WRITER_

#include "CFBXMeshWriter.h"
#include "IFileSystem.h"
#include "ISceneManager.h"
#include "IMeshBuffer.h"
#include <iostream>

#include "os.h"
#include <string>
#include <vector>

namespace irr
{
namespace scene
{

	CFBXMeshWriter::CFBXMeshWriter(ISceneManager* smgr, video::IVideoDriver* driver, io::IFileSystem* fs)
		:_smgr(smgr), _videoDriver(driver), _fileSystem(fs)
	{
		#ifdef _DEBUG
		setDebugName("CFBXMeshWriter");
		#endif

		if (_videoDriver)
			_videoDriver->grab();

		if (_fileSystem)
			_fileSystem->grab();
	}

	FbxColor CFBXMeshWriter::irrColorToFbxColor(video::SColor color)
	{
		return FbxColor(color.getRed() / 255.0f, color.getGreen()/255.0f, color.getBlue()/255.0f, color.getAlpha() /255.0f);
	}

	FbxDouble3 CFBXMeshWriter::irrColorToFbxDouble3(video::SColor color)
	{
		return FbxDouble3(color.getRed() / 255.0f, color.getGreen() / 255.0f, color.getBlue() / 255.0f);
	}

	FbxDouble3 CFBXMeshWriter::irrVector3dfToFbxDouble3(core::vector3df vector)
	{
		return FbxDouble3(vector.X, vector.Y, vector.Z);
	}

	core::array<ISkinnedMesh::SJoint*> CFBXMeshWriter::getRootJoints(const ISkinnedMesh* mesh)
	{
		core::array<ISkinnedMesh::SJoint*> roots;

		core::array<ISkinnedMesh::SJoint*> allJoints = mesh->getAllJoints();
		for (u32 i = 0; i < allJoints.size(); i++)
		{
			bool isRoot = true;
			ISkinnedMesh::SJoint* testedJoint = allJoints[i];
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

	FbxAMatrix CFBXMeshWriter::irrMatrixToFbxMatrix(core::matrix4 matrix)
	{
		FbxAMatrix retMat;
		for (int i = 0; i < 4; i++)
		{
			FbxVector4 row = FbxVector4(matrix(i, 0), matrix(i, 1), matrix(i, 2), matrix(i, 3));
			retMat.SetRow(i, row);
		}
		return retMat;
	}


	FbxNode* CFBXMeshWriter::createSkeletonNode(FbxScene* lScene, const ISkinnedMesh::SJoint* joint)
	{
		FbxNode* lSkeletonNode = FbxNode::Create(lScene, joint->Name.c_str());
		FbxSkeleton* lSkeleton = FbxSkeleton::Create(lScene, "");
		lSkeleton->SetSkeletonType(FbxSkeleton::eLimbNode);
		lSkeletonNode->SetNodeAttribute(lSkeleton);

		FbxAMatrix fbxMat = irrMatrixToFbxMatrix(joint->LocalMatrix);

		lSkeletonNode->InheritType.Set(FbxTransform::eInheritRSrs);
		lSkeletonNode->LclTranslation.Set(fbxMat.GetT());
		lSkeletonNode->LclRotation.Set(fbxMat.GetR());
		lSkeletonNode->LclScaling.Set(fbxMat.GetS());
		//lSkeletonNode->LclTranslation.Set(irrVector3dfToFbxDouble3(joint->Animatedposition));
		//lSkeletonNode->LclRotation.Set(irrVector3dfToFbxDouble3(joint->Animatedrotation));

		core::array<ISkinnedMesh::SJoint*> children = joint->Children;
		for (u32 i = 0; i < children.size(); ++i)
		{
			lSkeletonNode->AddChild(createSkeletonNode(lScene, children[i]));
		}

		lSkeletonNode->SetNodeAttribute(lSkeleton);

		return lSkeletonNode;
	}

	//! creates fbx mesh from irrlicht mesh buffer
	//! http://docs.autodesk.com/FBX/2014/ENU/FBX-SDK-Documentation/
	//! -------------------------------------------------------------
	FbxMesh* CFBXMeshWriter::createMesh(FbxScene* lScene, scene::IMeshBuffer* buffer, FbxString meshName)
	{
		// Create a mesh.
		FbxMesh* lMesh = FbxMesh::Create(lScene, meshName);
		
		//vertex
		lMesh->InitControlPoints(buffer->getVertexCount());
		FbxVector4* lControlPoints = lMesh->GetControlPoints();

		// Create UV for Diffuse channel
		FbxGeometryElementUV* lUVDiffuseElement = lMesh->CreateElementUV(gDiffuseElementName);
		FBX_ASSERT(lUVDiffuseElement != NULL);

		lUVDiffuseElement->SetMappingMode(FbxGeometryElement::eByPolygonVertex);
		lUVDiffuseElement->SetReferenceMode(FbxGeometryElement::eIndexToDirect);
		lUVDiffuseElement->GetIndexArray().SetCount(buffer->getIndexCount());

		for (u32 j = 0; j < buffer->getVertexCount(); ++j)
		{
			/// vertex
			core::vector3df vertex = buffer->getPosition(j);
            LocalToWorld.transformVect(vertex);
			lControlPoints[j] = FbxVector4(vertex.X, vertex.Y, vertex.Z);

			// diffuse
			core::vector2df diffuse = buffer->getTCoords(j);
			lUVDiffuseElement->GetDirectArray().Add(FbxVector2(diffuse.X, -diffuse.Y));

		}

		// Create Color channel
		FbxGeometryElementVertexColor* lColorElement = lMesh->CreateElementVertexColor();
		lColorElement->SetMappingMode(FbxGeometryElement::eByPolygonVertex);
		lColorElement->SetReferenceMode(FbxGeometryElement::eDirect);
		lColorElement->GetIndexArray().SetCount(buffer->getIndexCount());

		// normal
		FbxGeometryElementNormal* lGeometryElementNormal = lMesh->CreateElementNormal();
		lGeometryElementNormal->SetMappingMode(FbxGeometryElement::eByPolygonVertex);
		lGeometryElementNormal->SetReferenceMode(FbxGeometryElement::eDirect);

		for (u32 j = 0; j < buffer->getIndexCount(); ++j)
		{
			// normal
			core::vector3df normal = buffer->getNormal(buffer->getIndices()[j]);
			lGeometryElementNormal->GetDirectArray().Add(FbxVector4(normal.X, normal.Y, normal.Z));

			//diffuse
			lUVDiffuseElement->GetIndexArray().SetAt(j, buffer->getIndices()[j]);

			//color
			video::SColor color = ((video::S3DVertex*)buffer->getVertices())[buffer->getIndices()[j]].Color;
			lColorElement->GetDirectArray().Add(irrColorToFbxColor(color));
		}

		// Create polygons. Assign texture and texture UV indices.
		u16* lPolygonVertices = buffer->getIndices();
		for (u32 j = 0; j < buffer->getIndexCount() / 3; ++j)
		{
			//we won't use the default way of assigning textures, as we have
			//textures on more than just the default (diffuse) channel.
			lMesh->BeginPolygon(-1, -1, false);

			for (u32 k = 0; k < 3; ++k)
			{
				//this function points 
				lMesh->AddPolygon(lPolygonVertices[j * 3 + k]); // Control point index. 
			}

			lMesh->EndPolygon();
		}

		return lMesh;
	}

	void CFBXMeshWriter::linkMeshToSkeleton(FbxSkin* skin, FbxNode* meshNode, FbxNode* pSkeletonRoot, ISkinnedMesh* mesh, u32 meshBufferIdx)
	{
		int i;
		FbxAMatrix lXMatrix;

		FbxNode* lRoot = pSkeletonRoot;
		FbxScene* lScene = meshNode->GetScene();
		
		// find joint in mesh by name
		core::stringc name = pSkeletonRoot->GetName();
		ISkinnedMesh::SJoint* joint = mesh->getAllJoints()[mesh->getJointNumber(name.c_str())];

		if (lScene && joint->Weights.size() >0)
		{
			lXMatrix = meshNode->EvaluateGlobalTransform();
			FbxCluster* lCluster = FbxCluster::Create(lScene, "");
			lCluster->SetLink(lRoot);
			lCluster->SetLinkMode(FbxCluster::eTotalOne);

			for (u32 i = 0; i < joint->Weights.size(); ++i)
			{
				if (joint->Weights[i].buffer_id == meshBufferIdx)
					lCluster->AddControlPointIndex(joint->Weights[i].vertex_id, joint->Weights[i].strength);
			}
			lCluster->SetTransformMatrix(lXMatrix);
			lCluster->SetTransformLinkMatrix(lRoot->EvaluateGlobalTransform());

			skin->AddCluster(lCluster);
		}

		//recurance
		for (i = 0; i < lRoot->GetChildCount(); ++i)
		{
			linkMeshToSkeleton(skin, meshNode, lRoot->GetChild(i), mesh, meshBufferIdx);
		}

	}

	// Store the Bind Pose
	void CFBXMeshWriter::storeBindPose(FbxScene* pScene, FbxNode* pNode)
	{
		// In the bind pose, we must store all the link's global matrix at the time of the bind.
		// Plus, we must store all the parent(s) global matrix of a link, even if they are not
		// themselves deforming any model.

		// In this example, since there is only one model deformed, we don't need walk through 
		// the scene
		//

		// Now list the all the link involve in the patch deformation
		FbxArray<FbxNode*> lClusteredFbxNodes;
		int   i, j;

		if (pNode && pNode->GetNodeAttribute())
		{
			int lSkinCount = 0;
			int lClusterCount = 0;
			switch (pNode->GetNodeAttribute()->GetAttributeType())
			{
			default:
				break;
			case FbxNodeAttribute::eMesh:
			case FbxNodeAttribute::eNurbs:
			case FbxNodeAttribute::ePatch:

				lSkinCount = ((FbxGeometry*)pNode->GetNodeAttribute())->GetDeformerCount(FbxDeformer::eSkin);
				//Go through all the skins and count them
				//then go through each skin and get their cluster count
				for (i = 0; i < lSkinCount; ++i)
				{
					FbxSkin* lSkin = (FbxSkin*)((FbxGeometry*)pNode->GetNodeAttribute())->GetDeformer(i, FbxDeformer::eSkin);
					lClusterCount += lSkin->GetClusterCount();
				}
				break;
			}
			//if we found some clusters we must add the node
			if (lClusterCount)
			{
				//Again, go through all the skins get each cluster link and add them
				for (i = 0; i < lSkinCount; ++i)
				{
					FbxSkin* lSkin = (FbxSkin*)((FbxGeometry*)pNode->GetNodeAttribute())->GetDeformer(i, FbxDeformer::eSkin);
					lClusterCount = lSkin->GetClusterCount();
					for (j = 0; j < lClusterCount; ++j)
					{
						FbxNode* lClusterNode = lSkin->GetCluster(j)->GetLink();
						addNodeRecursively(lClusteredFbxNodes, lClusterNode);
					}

				}

				// Add the mesh to the pose
				lClusteredFbxNodes.Add(pNode);
			}
		}

		// Now create a bind pose with the link list
		if (lClusteredFbxNodes.GetCount())
		{
			// A pose must be named. Arbitrarily use the name of the patch node.
			FbxPose* lPose = FbxPose::Create(pScene, pNode->GetName());

			// default pose type is rest pose, so we need to set the type as bind pose
			lPose->SetIsBindPose(true);

			for (i = 0; i < lClusteredFbxNodes.GetCount(); i++)
			{
				FbxNode* lKFbxNode = lClusteredFbxNodes.GetAt(i);
				FbxMatrix lBindMatrix = lKFbxNode->EvaluateGlobalTransform();

				lPose->Add(lKFbxNode, lBindMatrix);
			}

			// Add the pose to the scene
			pScene->AddPose(lPose);
		}
	}

	// Add the specified node to the node array. Also, add recursively
// all the parent node of the specified node to the array.
	void CFBXMeshWriter::addNodeRecursively(FbxArray<FbxNode*>& pNodeArray, FbxNode* pNode)
	{
		if (pNode)
		{
			addNodeRecursively(pNodeArray, pNode->GetParent());

			if (pNodeArray.Find(pNode) == -1)
			{
				// Node not in the list, add it
				pNodeArray.Add(pNode);
			}
		}
	}

	void decompose(core::vector3df vec, float& X, float& Y, float& Z)
	{
		X = vec.X;
		Y = vec.Y;
		Z = vec.Z;
	}

	void decompose(core::quaternion qt, float& X, float& Y, float& Z, float& W)
	{
		X = qt.X;
		Y = qt.Y;
		Z = qt.Z;
		W = qt.W;
	}

	void CFBXMeshWriter::createAnimation(FbxNode* node, FbxAnimLayer* animLayer, ISkinnedMesh* mesh)
	{
		// irr mesh anim is per frame, fbx uses seconds, find denominator
		double fts = 0;
		if (mesh->getAnimationSpeed() > 0)
			fts = 1.0 / mesh->getAnimationSpeed();

		// check if this fbx node has animation in mesh
		ISkinnedMesh::SJoint* joint = mesh->getAllJoints()[mesh->getJointNumber(node->GetName())];
		if (joint && (joint->PositionKeys.size() || joint->RotationKeys.size() || joint->ScaleKeys.size()))
		{
			FbxAnimCurve* xCurve = NULL; FbxAnimCurve* yCurve = NULL; FbxAnimCurve* zCurve = NULL; FbxAnimCurve* wCurve = NULL;
			int xIndex = 0; int yIndex = 0; int zIndex = 0; int wIndex = 0;
			float X, Y, Z;
			FbxTime lTime;

			if (joint->PositionKeys.size())
			{
				node->LclTranslation.GetCurveNode(animLayer, true);
				xCurve = node->LclTranslation.GetCurve(animLayer, FBXSDK_CURVENODE_COMPONENT_X, true);
				yCurve = node->LclTranslation.GetCurve(animLayer, FBXSDK_CURVENODE_COMPONENT_Y, true);
				zCurve = node->LclTranslation.GetCurve(animLayer, FBXSDK_CURVENODE_COMPONENT_Z, true);
				
				xCurve->KeyModifyBegin();
				yCurve->KeyModifyBegin();
				zCurve->KeyModifyBegin();

				for (u32 i = 0; i < joint->PositionKeys.size(); ++i)
				{
					ISkinnedMesh::SPositionKey key = joint->PositionKeys[i];
					lTime.SetSecondDouble(key.frame * fts);

					decompose(key.position, X, Y, Z);

					if (xCurve)
					{
						xIndex = xCurve->KeyAdd(lTime);
						xCurve->KeySet(xIndex, lTime, X, FbxAnimCurveDef::eInterpolationLinear);
					}

					if (yCurve)
					{
						yIndex = yCurve->KeyAdd(lTime);
						yCurve->KeySet(yIndex, lTime, Y, FbxAnimCurveDef::eInterpolationLinear);
					}

					if (zCurve)
					{
						zIndex = zCurve->KeyAdd(lTime);
						zCurve->KeySet(zIndex, lTime, Z, FbxAnimCurveDef::eInterpolationLinear);
					}
				}

				xCurve->KeyModifyEnd();
				yCurve->KeyModifyEnd();
				zCurve->KeyModifyEnd();
			} // position
			
			if (joint->RotationKeys.size())
			{
				node->LclRotation.GetCurveNode(animLayer, true);
				xCurve = node->LclRotation.GetCurve(animLayer, FBXSDK_CURVENODE_COMPONENT_X, true);
				yCurve = node->LclRotation.GetCurve(animLayer, FBXSDK_CURVENODE_COMPONENT_Y, true);
				zCurve = node->LclRotation.GetCurve(animLayer, FBXSDK_CURVENODE_COMPONENT_Z, true);
				

				xCurve->KeyModifyBegin();
				yCurve->KeyModifyBegin();
				zCurve->KeyModifyBegin();

				for (u32 i = 0; i < joint->RotationKeys.size(); ++i)
				{
					ISkinnedMesh::SRotationKey key = joint->RotationKeys[i];
					lTime.SetSecondDouble(key.frame * fts);

					core::vector3df vec;
					//key.rotation.toEuler(vec);
					core::quaternion q;
					q = key.rotation.makeInverse();
					q.toEuler(vec);
					

					decompose(vec * (float)FBXSDK_RAD_TO_DEG, X, Y, Z);

					if (xCurve)
					{
						xIndex = xCurve->KeyAdd(lTime);
						xCurve->KeySet(xIndex, lTime, X, FbxAnimCurveDef::eInterpolationLinear);
					}
				
					if (yCurve)
					{
						yIndex = yCurve->KeyAdd(lTime);
						yCurve->KeySet(yIndex, lTime, Y, FbxAnimCurveDef::eInterpolationLinear);
					}

					if (zCurve)
					{
						zIndex = zCurve->KeyAdd(lTime);
						zCurve->KeySet(zIndex, lTime, Z, FbxAnimCurveDef::eInterpolationLinear);
					}
				
				}
			} // rotation
			if (joint->ScaleKeys.size())
			{
				node->LclScaling.GetCurveNode(animLayer, true);
				xCurve = node->LclScaling.GetCurve(animLayer, FBXSDK_CURVENODE_COMPONENT_X, true);
				yCurve = node->LclScaling.GetCurve(animLayer, FBXSDK_CURVENODE_COMPONENT_Y, true);
				zCurve = node->LclScaling.GetCurve(animLayer, FBXSDK_CURVENODE_COMPONENT_Z, true);

				xCurve->KeyModifyBegin();
				yCurve->KeyModifyBegin();
				zCurve->KeyModifyBegin();

				for (u32 i = 0; i < joint->ScaleKeys.size(); ++i)
				{
					ISkinnedMesh::SScaleKey key = joint->ScaleKeys[i];
					lTime.SetSecondDouble(key.frame * fts);

					decompose(key.scale, X, Y, Z);

					if (xCurve)
					{
						xIndex = xCurve->KeyAdd(lTime);
						xCurve->KeySet(xIndex, lTime, X, FbxAnimCurveDef::eInterpolationLinear);
					}

					if (yCurve)
					{
						yIndex = yCurve->KeyAdd(lTime);
						yCurve->KeySet(yIndex, lTime, Y, FbxAnimCurveDef::eInterpolationLinear);
					}

					if (zCurve)
					{
						zIndex = zCurve->KeyAdd(lTime);
						zCurve->KeySet(zIndex, lTime, Z, FbxAnimCurveDef::eInterpolationLinear);
					}
				}

				xCurve->KeyModifyEnd();
				yCurve->KeyModifyEnd();
				zCurve->KeyModifyEnd();

			} // scale
			
		} // joint processing

		// process childs
		for (int i = 0; i < node->GetChildCount(); ++i)
		{
			createAnimation(node->GetChild(i), animLayer, mesh);
		}
	}

	bool CFBXMeshWriter::writeMesh(io::IWriteFile* file, scene::IMesh* mesh, s32 flags)
	{
		
		// Create the SDK manager.
		FbxManager* lSdkManager = FbxManager::Create();

		//Create an IOSettings object. This object holds all import/export settings.
		FbxIOSettings* ios = FbxIOSettings::Create(lSdkManager, IOSROOT);
		lSdkManager->SetIOSettings(ios);

		// Create the scene.
		FbxScene* lScene = FbxScene::Create(lSdkManager, "WolvenKit Fbx Export");
		
		//FbxAxisSystem SceneAxisSystem = lScene->GetGlobalSettings().GetAxisSystem();
		//FbxAxisSystem OurAxisSystem = FbxAxisSystem(FbxAxisSystem::EPreDefinedAxisSystem::eDirectX);
		//if (SceneAxisSystem != OurAxisSystem)
		//{
		//	OurAxisSystem.ConvertScene(lScene);
		//}
		
		
		// Get the root node of the scene.
		FbxNode* lRootNode = lScene->GetRootNode();

		//store mesh nodes with corresponding buffer index
		std::vector<std::pair<u32, FbxNode*>> meshNodes;

		for (u32 i = 0; i < mesh->getMeshBufferCount(); ++i)
		{
			FbxString meshNodeName = FbxString("meshNode_") + (int)i;
			FbxString meshName = FbxString("mesh_") + (int)i;

			// build fbx mesh
			irr::scene::IMeshBuffer* buffer = mesh->getMeshBuffer(i);
			FbxMesh* lMesh = createMesh(lScene, buffer, meshName);

			// Create a node for our mesh in the scene.
			FbxNode* lMeshNode = FbxNode::Create(lScene, meshNodeName);
			lMeshNode->SetNodeAttribute(lMesh);
			lMeshNode->SetShadingMode(FbxNode::eTextureShading);

			lRootNode->AddChild(lMeshNode);
			meshNodes.push_back(std::pair(i, lMeshNode));

			// ================================== materials and textures ============================================================

			FbxSurfacePhong* lMaterial = lMeshNode->GetSrcObject<FbxSurfacePhong>(0);
			video::SMaterial mat = mesh->getMeshBuffer(i)->getMaterial();

			if (lMaterial == NULL)
			{

				FbxString lMaterialName = FbxString("material_") + (int)i;
				FbxString lShadingName = FbxString("shading_") + (int)i;

				FbxLayer* lLayer = lMesh->GetLayer(0);

				// Create a layer element material to handle proper mapping.
				FbxLayerElementMaterial* lLayerElementMaterial = FbxLayerElementMaterial::Create(lMesh, lMaterialName.Buffer());
				
				// This allows us to control where the materials are mapped.  Using eAllSame
				// means that all faces/polygons of the mesh will be assigned the same material.
				lLayerElementMaterial->SetMappingMode(FbxLayerElement::eAllSame);
				lLayerElementMaterial->SetReferenceMode(FbxLayerElement::eIndexToDirect);

				// Save the material on the layer
				lLayer->SetMaterials(lLayerElementMaterial);

				// Add an index to the lLayerElementMaterial.  Since we have only one, and are using eAllSame mapping mode,
				// we only need to add one.
				lLayerElementMaterial->GetIndexArray().Add(0);

				lMaterial = FbxSurfacePhong::Create(lScene, lMaterialName.Buffer());

				lMaterial->Emissive.Set( irrColorToFbxDouble3( mat.EmissiveColor ));
				lMaterial->Ambient.Set(irrColorToFbxDouble3(mat.AmbientColor));
				lMaterial->AmbientFactor.Set(1.0);
				// Diffuse
				lMaterial->Diffuse.Set(irrColorToFbxDouble3(mat.DiffuseColor));
				lMaterial->DiffuseFactor.Set(1.0);

				lMaterial->ShadingModel.Set(lShadingName);
				lMaterial->Shininess.Set(mat.Shininess);

				lMaterial->Specular.Set(irrColorToFbxDouble3(mat.SpecularColor));
				lMaterial->SpecularFactor.Set(0.3);

				lMeshNode->AddMaterial(lMaterial);
			}

			for (u32 j = 0; j < 3; ++j)
			{
				if (mat.getTexture(j))
				{
					FbxFileTexture* lTexture;

					// Diffuse texture is always 0
					if (j == 0)
					{
						lTexture = FbxFileTexture::Create(lScene, "Diffuse Texture");
						lTexture->SetTextureUse(FbxTexture::eStandard);
					}
					else if (j == 1) // normals always on 1
					{
						lTexture = FbxFileTexture::Create(lScene, "Normal Texture");
						lTexture->SetTextureUse(FbxTexture::eBumpNormalMap);
					}
					else if (j == 2) // ambient always on 2
					{
						lTexture = FbxFileTexture::Create(lScene, "Ambient Texture");
						lTexture->SetTextureUse(FbxTexture::eStandard);
					}

                    core::stringc tname = (core::stringc)(_fileSystem->getFileBasename(mat.getTexture(j)->getName()));
                    if (!TexExtension.empty())
                    {
                        core::stringc ext = tname.subString(tname.findLastChar("."), 4);
                        tname = tname.replace(ext, TexExtension);
                    }

					lTexture->SetFileName(tname.c_str());
					//lTexture->SetTextureUse(FbxTexture::eStandard);
					lTexture->SetMappingType(FbxTexture::eUV);
					lTexture->SetMaterialUse(FbxFileTexture::eModelMaterial);
					lTexture->SetSwapUV(false);
					lTexture->SetTranslation(0.0, 0.0);
					lTexture->SetScale(1.0, 1.0);
					lTexture->SetRotation(0.0, 0.0);

					if (j == 0)
					{
						lTexture->UVSet.Set(FbxString(gDiffuseElementName)); // Connect texture to the proper UV
						// don't forget to connect the texture to the corresponding property of the material
						if (lMaterial)
							lMaterial->Diffuse.ConnectSrcObject(lTexture);
					}
					else if (j == 1)
					{
						lTexture->UVSet.Set(FbxString(gDiffuseElementName)); // Connect texture to the same UV set
						if (lMaterial)
							lMaterial->Bump.ConnectSrcObject(lTexture);
					}
					else if (j == 2)
					{
						lTexture->UVSet.Set(FbxString(gDiffuseElementName)); // Connect texture to the same UV set
						if (lMaterial)
							lMaterial->Ambient.ConnectSrcObject(lTexture);
					}
				}
			}

		} //mesh buffer count

		// ===========================  skeleton  =============================================== //

		#if (IRRLICHT_VERSION_MAJOR >= 2) || (IRRLICHT_VERSION_MAJOR == 1 && IRRLICHT_VERSION_MINOR >= 9)
		if (mesh->getMeshType() == scene::EAMT_SKINNED)
		{
			scene::ISkinnedMesh* skinned = static_cast<scene::ISkinnedMesh*>(mesh);
			//createAnimations(skinned);

			FbxArray<FbxNode*> lSkeletonRootNodes;
			core::array<ISkinnedMesh::SJoint*> roots = this->getRootJoints(skinned);
			for (u32 i = 0; i < roots.size(); ++i)
			{
				ISkinnedMesh::SJoint* joint = roots[i];

				// create root node
				FbxNode* lSkeletonRootNode = FbxNode::Create(lScene, joint->Name.c_str());
				lSkeletonRootNodes.Add(lSkeletonRootNode);

				// Create node attributes.
				FbxSkeleton* lRootSkeleton = FbxSkeleton::Create(lScene, "");
				lRootSkeleton->SetSkeletonType(FbxSkeleton::eRoot);
				lRootSkeleton->LimbLength.Set(0.0);
				lSkeletonRootNode->SetNodeAttribute(lRootSkeleton);

				core::array<ISkinnedMesh::SJoint*> children = joint->Children;

				for (u32 j = 0; j < children.size(); ++j)
				{
					lSkeletonRootNode->AddChild(createSkeletonNode(lScene, children[j]));
				}
				lRootNode->AddChild(lSkeletonRootNode);

				// change not real root to eEffector type -- visible as root in blender
				for (int j = 0; j < lSkeletonRootNode->GetChildCount(); ++j)
				{
					if (lSkeletonRootNode->GetChild(j)->GetChildCount() == 0)
						lSkeletonRootNode->GetChild(j)->GetSkeleton()->SetSkeletonType(FbxSkeleton::eEffector);
				}
			}

			// ANIMATION: only one at this moment, sry
			if (!skinned->isStatic())
			{
				// skinning: browse fbx nodes and build weights
				for (std::pair<u32, FbxNode*> p : meshNodes)
				{
					FbxGeometry* lMeshAttribute = (FbxGeometry*)p.second->GetNodeAttribute();
					FbxSkin* lSkin = FbxSkin::Create(lScene, "");
					for (int j = 0; j < lSkeletonRootNodes.GetCount(); ++j)
					{
						linkMeshToSkeleton(lSkin, p.second, lSkeletonRootNodes[j], skinned, p.first );
					}
					lMeshAttribute->AddDeformer(lSkin);
					storeBindPose(lScene, p.second);
				}

				// Create the Animation Stack
				FbxAnimStack* lAnimStack = FbxAnimStack::Create(lScene, "Animation");

				// The animation nodes can only exist on AnimLayers therefore it is mandatory to
				// add at least one AnimLayer to the AnimStack.
				FbxAnimLayer* lAnimLayer = FbxAnimLayer::Create(lScene, "Base Layer");
				lAnimStack->AddMember(lAnimLayer);

				for (int j = 0; j < lSkeletonRootNodes.GetCount(); ++j)
				{
					createAnimation(lSkeletonRootNodes[j], lAnimLayer, skinned);
				}
				
			}

		} // skinned mesh if
		#endif


		// set some IOSettings options 
		ios->SetBoolProp(IMP_FBX_MATERIAL, true);
		ios->SetBoolProp(IMP_FBX_TEXTURE, true);
		ios->SetBoolProp(EXP_FBX_EMBEDDED, true);
		ios->SetBoolProp(EXP_FBX_SHAPE, true);
		ios->SetBoolProp(EXP_FBX_GOBO, true);
		ios->SetBoolProp(EXP_FBX_ANIMATION, true);
		ios->SetBoolProp(EXP_FBX_GLOBAL_SETTINGS, true);

		FbxExporter* lExporter = FbxExporter::Create(lSdkManager, "");

		int pFileFormat = lSdkManager->GetIOPluginRegistry()->GetNativeWriterFormat();
	
		int lFormatIndex, lFormatCount = lSdkManager->GetIOPluginRegistry()->GetWriterFormatCount();
		int pAsciiFormat;

		//Try to export in ASCII if possible
		for (lFormatIndex = 0; lFormatIndex < lFormatCount; lFormatIndex++)
		{
			if (lSdkManager->GetIOPluginRegistry()->WriterIsFBX(lFormatIndex))
			{
				FbxString lDesc = lSdkManager->GetIOPluginRegistry()->GetWriterFormatDescription(lFormatIndex);
				const char* lASCII = "ascii";
				if (lDesc.Find(lASCII) >= 0)
				{
					pAsciiFormat = lFormatIndex;
					break;
				}
			}
		}

		//================== binary =========================================
		core::stringc fNameBin = file->getFileName().c_str();

		// need to drop and delete as irrlicht keeps file for open
		file->drop();
		std::remove(fNameBin.c_str());

		// Initialize the exporter by providing a filename.
		if (lExporter->Initialize(fNameBin.c_str(), pFileFormat, lSdkManager->GetIOSettings()) == false)
		{
			os::Printer::log("Call to binary FbxExporter::Initialize() failed.", ELL_ERROR);
			os::Printer::log("Error returned: ", lExporter->GetStatus().GetErrorString(), ELL_ERROR);
			return false;
		}

		// Export the scene.
		bool lStatus = lExporter->Export(lScene);
		if (!lStatus)
			os::Printer::log("Call to binary FbxExporter::Export() failed.", ELL_ERROR);

		//================== ascii =========================================
		

		core::stringc fNameAscii = fNameBin + core::stringc("_ascii.fbx");
		std::remove(fNameAscii.c_str());

		// Initialize the exporter by providing a filename.
		if (lExporter->Initialize(fNameAscii.c_str(), pAsciiFormat, lSdkManager->GetIOSettings()) == false)
		{
			os::Printer::log("Call to ascii FbxExporter::Initialize() failed.", ELL_ERROR);
			os::Printer::log("Error returned: ", lExporter->GetStatus().GetErrorString(), ELL_ERROR);
			return false;
		}

		// Export the scene.
		lStatus = lExporter->Export(lScene);
		if (!lStatus)
		{
			os::Printer::log("Call to ascii FbxExporter::Export() failed.", ELL_ERROR);
			os::Printer::log("Error returned: ", lExporter->GetStatus().GetErrorString(), ELL_ERROR);
		}

		//cleanup
		lExporter->Destroy();
		
		return lStatus;
		
		/*
		core::stringc fbxaFmtId, fbxFmtId, daeFmtId;
		core::array<ExportFormat> formats = IrrAssimp::getExportFormats();
		for (u32 i = 0; i < formats.size(); ++i)
		{
			const ExportFormat format = formats[i];
			if (format.Id == "fbxa")
			{
				fbxaFmtId = format.Id;
			}
			if (format.Id == "fbx")
				fbxFmtId = format.Id;
			if (format.Id == "collada")
				daeFmtId = format.Id;
		}

		core::stringc fbxaFile = file->getFileName() + core::stringc("_a.fbx");
		core::stringc daeFile = file->getFileName() + core::stringc(".dae");
		IrrAssimp assimp(_smgr);
		assimp.exportMesh(mesh, fbxaFmtId, fbxaFile);
		assimp.exportMesh(mesh, fbxFmtId, file->getFileName());
		assimp.exportMesh(mesh, daeFmtId, daeFile);


		return true;
		*/
		
	}

	// return type of mesh writer
	EMESH_WRITER_TYPE CFBXMeshWriter::getType() const
	{
		return EMWT_FBX;
	}

	CFBXMeshWriter::~CFBXMeshWriter()
	{
		if (_videoDriver)
			_videoDriver->drop();

		if (_fileSystem)
			_fileSystem->drop();
	}

} //namespace scene
} //namespace irr
#endif

