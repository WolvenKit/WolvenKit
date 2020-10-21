#include "stdafx.h"
#include "AnimatedMesh.h"
#include "AnimatedMeshSceneNode.h"
#include "Attributes.h"
#include "CameraSceneNode.h"
#include "LightSceneNode.h"
#include "Event.h"
#include "FileSystem.h"
#include "Mesh.h"
#include "MeshManipulator.h"
#include "MeshSceneNode.h"
#include "MeshWriter.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"
#include "SceneManagerWolvenKit.h"
#include "SceneNode.h"
#include "StaticMesh.h"
#include "TerrainSceneNodeWolvenKit.h"
#include "Texture.h"
#include "VideoDriver.h"
#include "WriteFile.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

SceneManagerWolvenKit^ SceneManagerWolvenKit::Create(IrrlichtDevice^ device)
{
	scene::CSceneManagerWolvenKit* ref = irr::CreateWolvenKitSceneManager(device->m_IrrlichtDevice);
    return gcnew SceneManagerWolvenKit(ref);
}

SceneManagerWolvenKit^ SceneManagerWolvenKit::Wrap(scene::ISceneManager* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SceneManagerWolvenKit(ref);
}

SceneManagerWolvenKit::SceneManagerWolvenKit(scene::ISceneManager* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_SceneManager = ref;
}

MeshWriter^ SceneManagerWolvenKit::CreateMeshWriter(MeshWriterType type)
{
	return MeshWriter::Wrap(m_SceneManager->createMeshWriter((EMESH_WRITER_TYPE)type));
}

CameraSceneNode^ SceneManagerWolvenKit::AddCameraSceneNodeWolvenKit()
{
    scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeWolvenKit();
    return CameraSceneNode::Wrap(n);
}

SceneNode^ SceneManagerWolvenKit::AddEmptySceneNode()
{
	scene::ISceneNode* n = m_SceneManager->addEmptySceneNode();
	return SceneNode::Wrap(n);
}

LightSceneNode^ SceneManagerWolvenKit::AddLightSceneNode(SceneNode^ parent, Vector3Df^ position, Video::Colorf^ color, float radius)
{
    LIME_ASSERT(position != nullptr);
    LIME_ASSERT(color != nullptr);

    scene::ILightSceneNode* l = m_SceneManager->addLightSceneNode(
        LIME_SAFEREF(parent, m_SceneNode),
        *position->m_NativeValue,
        *color->m_NativeValue,
        radius);

    return LightSceneNode::Wrap(l);
}

MeshSceneNode^ SceneManagerWolvenKit::AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addMeshSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	mesh->Drop(); // the mesh node owns it now
	return MeshSceneNode::Wrap(n);
}

SceneNode^ SceneManagerWolvenKit::AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage)
{
	LIME_ASSERT(horiRes > 0);
	LIME_ASSERT(vertRes > 0);
	LIME_ASSERT(texturePercentage >= 0.0f && texturePercentage <= 1.0f);
	LIME_ASSERT(spherePercentage >= 0.0f && spherePercentage <= 2.0f);

	scene::ISceneNode* n = m_SceneManager->addSkyDomeSceneNode(
		LIME_SAFEREF(texture, m_Texture),
		horiRes,
		vertRes,
		texturePercentage,
		spherePercentage);

	return SceneNode::Wrap(n);
}

TerrainSceneNodeWolvenKit^ SceneManagerWolvenKit::AddTerrainSceneNodeWolvenKit(String^ heightMapFileName, SceneNode^ parent, int id, int dimension , float maxHeight, float minHeight, float tileSize, Vector3Df^ anchor)
{
	LIME_ASSERT(heightMapFileName != nullptr);

	scene::ITerrainSceneNodeWolvenKit* n = m_SceneManager->addTerrainSceneNodeWolvenKit(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		dimension,
		maxHeight,
		minHeight,
		tileSize,
		*anchor->m_NativeValue);

	return TerrainSceneNodeWolvenKit::Wrap(n);
}


SceneNode^ SceneManagerWolvenKit::AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent,
	int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::ISceneNode* n = m_SceneManager->addWaterSurfaceSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		waveHeight,
		waveSpeed,
		waveLength,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue);

	return SceneNode::Wrap(n);
}

void SceneManagerWolvenKit::DrawAll()
{
	m_SceneManager->drawAll();
}

AnimatedMesh^ SceneManagerWolvenKit::GetMesh(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->getMesh(Lime::StringToPath(filename));
	return AnimatedMesh::Wrap(m);
}

Mesh^ SceneManagerWolvenKit::GetStaticMesh(String^ filename)
{
    LIME_ASSERT(filename != nullptr);

    scene::IMesh* m = m_SceneManager->getStaticMesh(Lime::StringToPath(filename));
    return StaticMesh::Wrap(m);
}

bool SceneManagerWolvenKit::PostEvent(Event^ e)
{
	LIME_ASSERT(e != nullptr);
	return m_SceneManager->postEventFromUser(*e->m_NativeValue);
}

Video::Colorf^ SceneManagerWolvenKit::AmbientLight::get()
{
    return gcnew Video::Colorf(m_SceneManager->getAmbientLight());
}

void SceneManagerWolvenKit::AmbientLight::set(Video::Colorf^ value)
{
    LIME_ASSERT(value != nullptr);
    m_SceneManager->setAmbientLight(*value->m_NativeValue);
}

IO::Attributes^ SceneManagerWolvenKit::Attributes::get()
{
    io::IAttributes* a = m_SceneManager->getParameters();
    return IO::Attributes::Wrap(a);
}

CameraSceneNode^ SceneManagerWolvenKit::ActiveCamera::get()
{
	scene::ICameraSceneNode* n = m_SceneManager->getActiveCamera();
	return CameraSceneNode::Wrap(n);
}

void SceneManagerWolvenKit::ActiveCamera::set(CameraSceneNode^ value)
{
	m_SceneManager->setActiveCamera(LIME_SAFEREF(value, m_CameraSceneNode));
}

Scene::MeshManipulator^ SceneManagerWolvenKit::MeshManipulator::get()
{
	scene::IMeshManipulator* m = m_SceneManager->getMeshManipulator();
	return Scene::MeshManipulator::Wrap(m);
}

} // end namespace Scene
} // end namespace IrrlichtLime