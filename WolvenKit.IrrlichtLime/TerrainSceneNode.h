#pragma once

#include "stdafx.h"
#include "SceneNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace IO { ref class ReadFile; }
namespace Scene {

ref class DynamicMeshBuffer;
ref class Mesh;
ref class MeshBuffer;

public ref class TerrainSceneNode : SceneNode
{
public:

	AABBox^ GetPatchBoundingBox(int patchX, int patchZ);
	List<int>^ GetCurrentLODOfPatches();
	float GetHeight(float x, float z);
	List<int>^ GetIndicesForPatch(int patchX, int patchZ, int lodLevel);
	List<int>^ GetIndicesForPatch(int patchX, int patchZ);
	DynamicMeshBuffer^ GetMeshBufferForLOD(int lodLevel);
	DynamicMeshBuffer^ GetMeshBufferForLOD();

	bool LoadHeightMap(IO::ReadFile^ file, Video::Color^ vertexColor, int smoothFactor);
	bool LoadHeightMap(IO::ReadFile^ file, Video::Color^ vertexColor);
	bool LoadHeightMap(IO::ReadFile^ file);

	bool LoadHeightMapRAW(IO::ReadFile^ file, int bitsPerPixel, bool signedData, bool floatVals, int widthAndHeight, Video::Color^ vertexColor, int smoothFactor);
	bool LoadHeightMapRAW(IO::ReadFile^ file, int bitsPerPixel, bool signedData, bool floatVals, int widthAndHeight, Video::Color^ vertexColor);
	bool LoadHeightMapRAW(IO::ReadFile^ file, int bitsPerPixel, bool signedData, bool floatVals, int widthAndHeight);
	bool LoadHeightMapRAW(IO::ReadFile^ file, int bitsPerPixel, bool signedData, bool floatVals);
	bool LoadHeightMapRAW(IO::ReadFile^ file, int bitsPerPixel, bool signedData);
	bool LoadHeightMapRAW(IO::ReadFile^ file, int bitsPerPixel);
	bool LoadHeightMapRAW(IO::ReadFile^ file);

	bool OverrideLODDistance(int lodLevel, double newDistance);
	void ScaleTexture(float scale, float scale2);
	void ScaleTexture(float scale);
	void SetCameraMovementDelta(float delta);
	void SetCameraRotationDelta(float delta);
	void SetDynamicSelectorUpdate(bool flag);
	void SetLODOfPatch(int patchX, int patchZ, int lodLevel);

	property int IndexCount { int get(); }
	property Scene::Mesh^ Mesh { Scene::Mesh^ get(); }
	property MeshBuffer^ RenderBuffer { MeshBuffer^ get(); }
	property Vector3Df^ TerrainCenter { Vector3Df^ get(); }

internal:

	static TerrainSceneNode^ Wrap(scene::ITerrainSceneNode* ref);
	TerrainSceneNode(scene::ITerrainSceneNode* ref);

	scene::ITerrainSceneNode* m_TerrainSceneNode;
};

} // end namespace Scene
} // end namespace IrrlichtLime