#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"
#include "MeshWriterType.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime { ref class Event;
namespace IO { ref class Attributes; ref class FileSystem; ref class ReadFile; ref class WriteFile; }
namespace Video { ref class Image; ref class Texture; ref class VideoDriver; }
namespace Scene {

ref class CameraSceneNode;
ref class LightSceneNode;
ref class Mesh;
ref class MeshManipulator;
ref class MeshSceneNode;
ref class MeshWriter;
ref class SceneNode;
ref class TerrainSceneNodeWolvenKit;

public ref class SceneManagerWolvenKit : ReferenceCounted
{
public:
	static SceneManagerWolvenKit^ Create(IrrlichtDevice^ device);

	CameraSceneNode^ AddCameraSceneNodeWolvenKit();

	SceneNode^ AddEmptySceneNode();

	LightSceneNode^ AddLightSceneNode(SceneNode^ parent, Vector3Df^ position, Video::Colorf^ color, float radius);
	MeshSceneNode^ AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation);

	SceneNode^ AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage);

	TerrainSceneNodeWolvenKit^ AddTerrainSceneNodeWolvenKit(String^ heightMapFileName, SceneNode^ parent, int id, int dimension, float maxHeight, float minHeight, float tileSize, Vector3Df^ anchor);

	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);

	MeshWriter^ CreateMeshWriter(MeshWriterType type);

	void SelectNode(SceneNode^ node);
	void DeselectNode();

	void DrawAll();

	AnimatedMesh^ GetMesh(String^ filename);
	Mesh^ GetStaticMesh(String^ filename);

	bool PostEvent(Event^ e);

	property Video::Colorf^ AmbientLight { Video::Colorf^ get(); void set(Video::Colorf^ value); }
	property IO::Attributes^ Attributes { IO::Attributes^ get(); }
	property CameraSceneNode^ ActiveCamera { CameraSceneNode^ get(); void set(CameraSceneNode^ value); }
	property Scene::MeshManipulator^ MeshManipulator { Scene::MeshManipulator^ get(); }
	
internal:

	static SceneManagerWolvenKit^ Wrap(scene::ISceneManager* ref);
	SceneManagerWolvenKit(scene::ISceneManager* ref);

	scene::ISceneManager* m_SceneManager;
};

} // end namespace Scene
} // end namespace IrrlichtLime