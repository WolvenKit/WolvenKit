#include "stdafx.h"
#include "AnimatedMesh.h"
#include "AnimatedMeshSceneNode.h"
#include "Attributes.h"
#include "BillboardSceneNode.h"
#include "BillboardTextSceneNode.h"
#include "CameraSceneNode.h"
#include "CollisionResponseSceneNodeAnimator.h"
#include "DummyTransformationSceneNode.h"
#include "Event.h"
#include "FileSystem.h"
#include "GeometryCreator.h"
#include "GUIEnvironment.h"
#include "GUIFont.h"
#include "Image.h"
#include "LightSceneNode.h"
#include "Mesh.h"
#include "MeshCache.h"
#include "MeshLoader.h"
#include "MeshManipulator.h"
#include "MeshSceneNode.h"
#include "MeshWriter.h"
#include "MetaTriangleSelector.h"
#include "ParticleSystemSceneNode.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"
#include "SceneCollisionManager.h"
#include "SceneLoader.h"
#include "SceneManager.h"
#include "SceneNode.h"
#include "SceneNodeAnimator.h"
#include "SkinnedMesh.h"
#include "TerrainSceneNode.h"
#include "TerrainSceneNodeWolvenKit.h"
#include "TextSceneNode.h"
#include "Texture.h"
#include "TriangleSelector.h"
#include "VideoDriver.h"
#include "VolumeLightSceneNode.h"
#include "WriteFile.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

SceneManager^ SceneManager::Wrap(scene::ISceneManager* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SceneManager(ref);
}

SceneManager::SceneManager(scene::ISceneManager* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_SceneManager = ref;
}

MeshWriter^ SceneManager::CreateMeshWriter(MeshWriterType type)
{
	return MeshWriter::Wrap(m_SceneManager->createMeshWriter((EMESH_WRITER_TYPE)type));
}


AnimatedMeshSceneNode^ SceneManager::AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id,
	Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, bool alsoAddIfMeshPointerZero)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::IAnimatedMeshSceneNode* n = m_SceneManager->addAnimatedMeshSceneNode(
		LIME_SAFEREF(mesh, m_AnimatedMesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		alsoAddIfMeshPointerZero);

	return AnimatedMeshSceneNode::Wrap(n);
}

AnimatedMeshSceneNode^ SceneManager::AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id,
	Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::IAnimatedMeshSceneNode* n = m_SceneManager->addAnimatedMeshSceneNode(
		LIME_SAFEREF(mesh, m_AnimatedMesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue);

	return AnimatedMeshSceneNode::Wrap(n);
}

AnimatedMeshSceneNode^ SceneManager::AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id,
	Vector3Df^ position, Vector3Df^ rotation)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::IAnimatedMeshSceneNode* n = m_SceneManager->addAnimatedMeshSceneNode(
		LIME_SAFEREF(mesh, m_AnimatedMesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	return AnimatedMeshSceneNode::Wrap(n);
}

AnimatedMeshSceneNode^ SceneManager::AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id,
	Vector3Df^ position)
{
	LIME_ASSERT(position != nullptr);

	scene::IAnimatedMeshSceneNode* n = m_SceneManager->addAnimatedMeshSceneNode(
		LIME_SAFEREF(mesh, m_AnimatedMesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue);

	return AnimatedMeshSceneNode::Wrap(n);
}

AnimatedMeshSceneNode^ SceneManager::AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id)
{
	scene::IAnimatedMeshSceneNode* n = m_SceneManager->addAnimatedMeshSceneNode(
		LIME_SAFEREF(mesh, m_AnimatedMesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return AnimatedMeshSceneNode::Wrap(n);
}

AnimatedMeshSceneNode^ SceneManager::AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent)
{
	scene::IAnimatedMeshSceneNode* n = m_SceneManager->addAnimatedMeshSceneNode(
		LIME_SAFEREF(mesh, m_AnimatedMesh),
		LIME_SAFEREF(parent, m_SceneNode));

	return AnimatedMeshSceneNode::Wrap(n);
}

AnimatedMeshSceneNode^ SceneManager::AddAnimatedMeshSceneNode(AnimatedMesh^ mesh)
{
	scene::IAnimatedMeshSceneNode* n = m_SceneManager->addAnimatedMeshSceneNode(
		LIME_SAFEREF(mesh, m_AnimatedMesh));

	return AnimatedMeshSceneNode::Wrap(n);
}

AnimatedMesh^ SceneManager::AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder,
	int tesselationCone, float heightTotal, float heightCylinder, float diameterCylinder, float diameterCone)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(vtxColorCylinder != nullptr);
	LIME_ASSERT(vtxColorCone != nullptr);
	LIME_ASSERT(tesselationCylinder > 0);
	LIME_ASSERT(tesselationCone > 0);
	LIME_ASSERT(heightTotal > heightCylinder);
	LIME_ASSERT(diameterCone > diameterCylinder);

	scene::IAnimatedMesh* m = m_SceneManager->addArrowMesh(
		Lime::StringToPath(name),
		*vtxColorCylinder->m_NativeValue,
		*vtxColorCone->m_NativeValue,
		tesselationCylinder,
		tesselationCone,
		heightTotal,
		heightCylinder,
		diameterCylinder,
		diameterCone);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder,
	int tesselationCone, float heightTotal, float heightCylinder)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(vtxColorCylinder != nullptr);
	LIME_ASSERT(vtxColorCone != nullptr);
	LIME_ASSERT(tesselationCylinder > 0);
	LIME_ASSERT(tesselationCone > 0);
	LIME_ASSERT(heightTotal > heightCylinder);

	scene::IAnimatedMesh* m = m_SceneManager->addArrowMesh(
		Lime::StringToPath(name),
		*vtxColorCylinder->m_NativeValue,
		*vtxColorCone->m_NativeValue,
		tesselationCylinder,
		tesselationCone,
		heightTotal,
		heightCylinder);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder,
	int tesselationCone, float heightTotal)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(vtxColorCylinder != nullptr);
	LIME_ASSERT(vtxColorCone != nullptr);
	LIME_ASSERT(tesselationCylinder > 0);
	LIME_ASSERT(tesselationCone > 0);
	LIME_ASSERT(heightTotal > 0.6f); // 0.6f is a default value for heightCylinder argument

	scene::IAnimatedMesh* m = m_SceneManager->addArrowMesh(
		Lime::StringToPath(name),
		*vtxColorCylinder->m_NativeValue,
		*vtxColorCone->m_NativeValue,
		tesselationCylinder,
		tesselationCone,
		heightTotal);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder,
	int tesselationCone)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(vtxColorCylinder != nullptr);
	LIME_ASSERT(vtxColorCone != nullptr);
	LIME_ASSERT(tesselationCylinder > 0);
	LIME_ASSERT(tesselationCone > 0);

	scene::IAnimatedMesh* m = m_SceneManager->addArrowMesh(
		Lime::StringToPath(name),
		*vtxColorCylinder->m_NativeValue,
		*vtxColorCone->m_NativeValue,
		tesselationCylinder,
		tesselationCone);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(vtxColorCylinder != nullptr);
	LIME_ASSERT(vtxColorCone != nullptr);
	LIME_ASSERT(tesselationCylinder > 0);

	scene::IAnimatedMesh* m = m_SceneManager->addArrowMesh(
		Lime::StringToPath(name),
		*vtxColorCylinder->m_NativeValue,
		*vtxColorCone->m_NativeValue,
		tesselationCylinder);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(vtxColorCylinder != nullptr);
	LIME_ASSERT(vtxColorCone != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addArrowMesh(
		Lime::StringToPath(name),
		*vtxColorCylinder->m_NativeValue,
		*vtxColorCone->m_NativeValue);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(vtxColorCylinder != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addArrowMesh(
		Lime::StringToPath(name),
		*vtxColorCylinder->m_NativeValue);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddArrowMesh(String^ name)
{
	LIME_ASSERT(name != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addArrowMesh(Lime::StringToPath(name));
	return AnimatedMesh::Wrap(m);
}

BillboardSceneNode^ SceneManager::AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position, int id,
	Video::Color^ colorTop, Video::Color^ colorBottom)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(colorTop != nullptr);
	LIME_ASSERT(colorBottom != nullptr);

	scene::IBillboardSceneNode* n = m_SceneManager->addBillboardSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*size->m_NativeValue,
		*position->m_NativeValue,
		id,
		*colorTop->m_NativeValue,
		*colorBottom->m_NativeValue);

	return BillboardSceneNode::Wrap(n);
}

BillboardSceneNode^ SceneManager::AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position, int id,
	Video::Color^ colorTop)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(colorTop != nullptr);

	scene::IBillboardSceneNode* n = m_SceneManager->addBillboardSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*size->m_NativeValue,
		*position->m_NativeValue,
		id,
		*colorTop->m_NativeValue);

	return BillboardSceneNode::Wrap(n);
}

BillboardSceneNode^ SceneManager::AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position, int id)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(position != nullptr);

	scene::IBillboardSceneNode* n = m_SceneManager->addBillboardSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*size->m_NativeValue,
		*position->m_NativeValue,
		id);

	return BillboardSceneNode::Wrap(n);
}

BillboardSceneNode^ SceneManager::AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(position != nullptr);

	scene::IBillboardSceneNode* n = m_SceneManager->addBillboardSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*size->m_NativeValue,
		*position->m_NativeValue);

	return BillboardSceneNode::Wrap(n);
}

BillboardSceneNode^ SceneManager::AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size)
{
	LIME_ASSERT(size != nullptr);

	scene::IBillboardSceneNode* n = m_SceneManager->addBillboardSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*size->m_NativeValue);

	return BillboardSceneNode::Wrap(n);
}

BillboardSceneNode^ SceneManager::AddBillboardSceneNode(SceneNode^ parent)
{
	scene::IBillboardSceneNode* n = m_SceneManager->addBillboardSceneNode(
		LIME_SAFEREF(parent, m_SceneNode));

	return BillboardSceneNode::Wrap(n);
}

BillboardSceneNode^ SceneManager::AddBillboardSceneNode()
{
	scene::IBillboardSceneNode* n = m_SceneManager->addBillboardSceneNode();
	return BillboardSceneNode::Wrap(n);
}

BillboardTextSceneNode^ SceneManager::AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent, Dimension2Df^ size,
	Vector3Df^ position, int id, Video::Color^ colorTop, Video::Color^ colorBottom)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(colorTop != nullptr);
	LIME_ASSERT(colorBottom != nullptr);

	scene::IBillboardTextSceneNode* n = m_SceneManager->addBillboardTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFEREF(parent, m_SceneNode),
		*size->m_NativeValue,
		*position->m_NativeValue,
		id,
		*colorTop->m_NativeValue,
		*colorBottom->m_NativeValue);

	return BillboardTextSceneNode::Wrap(n);
}

BillboardTextSceneNode^ SceneManager::AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent, Dimension2Df^ size,
	Vector3Df^ position, int id)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(position != nullptr);

	scene::IBillboardTextSceneNode* n = m_SceneManager->addBillboardTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFEREF(parent, m_SceneNode),
		*size->m_NativeValue,
		*position->m_NativeValue,
		id);

	return BillboardTextSceneNode::Wrap(n);
}

BillboardTextSceneNode^ SceneManager::AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent, Dimension2Df^ size,
	Vector3Df^ position)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(position != nullptr);

	scene::IBillboardTextSceneNode* n = m_SceneManager->addBillboardTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFEREF(parent, m_SceneNode),
		*size->m_NativeValue,
		*position->m_NativeValue);

	return BillboardTextSceneNode::Wrap(n);
}

BillboardTextSceneNode^ SceneManager::AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent, Dimension2Df^ size)
{
	LIME_ASSERT(size != nullptr);

	scene::IBillboardTextSceneNode* n = m_SceneManager->addBillboardTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFEREF(parent, m_SceneNode),
		*size->m_NativeValue);

	return BillboardTextSceneNode::Wrap(n);
}

BillboardTextSceneNode^ SceneManager::AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent)
{
	scene::IBillboardTextSceneNode* n = m_SceneManager->addBillboardTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFEREF(parent, m_SceneNode));

	return BillboardTextSceneNode::Wrap(n);
}

BillboardTextSceneNode^ SceneManager::AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font)
{
	scene::IBillboardTextSceneNode* n = m_SceneManager->addBillboardTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));

	return BillboardTextSceneNode::Wrap(n);
}

BillboardTextSceneNode^ SceneManager::AddBillboardTextSceneNode(String^ text)
{
	scene::IBillboardTextSceneNode* n = m_SceneManager->addBillboardTextSceneNode(
		nullptr,
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));

	return BillboardTextSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNode(SceneNode^ parent, Vector3Df^ position, Vector3Df^ lookat, int id, bool makeActive)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(lookat != nullptr);

	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*position->m_NativeValue,
		*lookat->m_NativeValue,
		id,
		makeActive);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNode(SceneNode^ parent, Vector3Df^ position, Vector3Df^ lookat, int id)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(lookat != nullptr);

	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*position->m_NativeValue,
		*lookat->m_NativeValue,
		id);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNode(SceneNode^ parent, Vector3Df^ position, Vector3Df^ lookat)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(lookat != nullptr);

	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*position->m_NativeValue,
		*lookat->m_NativeValue);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNode(SceneNode^ parent, Vector3Df^ position)
{
	LIME_ASSERT(position != nullptr);

	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*position->m_NativeValue);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNode(SceneNode^ parent)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNode(
		LIME_SAFEREF(parent, m_SceneNode));

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNode()
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNode();
	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap, bool noVerticalMovement, float jumpSpeed, bool invertMouse, bool makeActive)
{
	SKeyMap* keyMapArray = 0;
	int keyMapSize = 0;
	
	if (keyMap != nullptr)
		keyMapSize = keyMap->GetSKeyMapArray(keyMapArray); // allocates keyMapArray

	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		moveSpeed,
		id,
		keyMapArray, keyMapSize,
		noVerticalMovement,
		jumpSpeed,
		invertMouse,
		makeActive);

	if (keyMapArray != 0)
		delete[] keyMapArray;

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap, bool noVerticalMovement, float jumpSpeed, bool invertMouse)
{
	SKeyMap* keyMapArray = 0;
	int keyMapSize = 0;
	
	if (keyMap != nullptr)
		keyMapSize = keyMap->GetSKeyMapArray(keyMapArray); // allocates keyMapArray

	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		moveSpeed,
		id,
		keyMapArray, keyMapSize,
		noVerticalMovement,
		jumpSpeed,
		invertMouse);

	if (keyMapArray != 0)
		delete[] keyMapArray;

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap, bool noVerticalMovement, float jumpSpeed)
{
	SKeyMap* keyMapArray = 0;
	int keyMapSize = 0;
	
	if (keyMap != nullptr)
		keyMapSize = keyMap->GetSKeyMapArray(keyMapArray); // allocates keyMapArray

	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		moveSpeed,
		id,
		keyMapArray, keyMapSize,
		noVerticalMovement,
		jumpSpeed);

	if (keyMapArray != 0)
		delete[] keyMapArray;

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap, bool noVerticalMovement)
{
	SKeyMap* keyMapArray = 0;
	int keyMapSize = 0;
	
	if (keyMap != nullptr)
		keyMapSize = keyMap->GetSKeyMapArray(keyMapArray); // allocates keyMapArray

	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		moveSpeed,
		id,
		keyMapArray, keyMapSize,
		noVerticalMovement);

	if (keyMapArray != 0)
		delete[] keyMapArray;

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap)
{
	SKeyMap* keyMapArray = 0;
	int keyMapSize = 0;
	
	if (keyMap != nullptr)
		keyMapSize = keyMap->GetSKeyMapArray(keyMapArray); // allocates keyMapArray

	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		moveSpeed,
		id,
		keyMapArray, keyMapSize);

	if (keyMapArray != 0)
		delete[] keyMapArray;

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		moveSpeed,
		id);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		moveSpeed);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS(SceneNode^ parent)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS(
		LIME_SAFEREF(parent, m_SceneNode));

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeFPS()
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeFPS();
	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed, float zoomSpeed, float translationSpeed, int id, bool makeActive)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeMaya(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		zoomSpeed,
		translationSpeed,
		id,
		makeActive);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed, float zoomSpeed, float translationSpeed, int id)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeMaya(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		zoomSpeed,
		translationSpeed,
		id);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed, float zoomSpeed, float translationSpeed)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeMaya(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		zoomSpeed,
		translationSpeed);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed, float zoomSpeed)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeMaya(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed,
		zoomSpeed);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeMaya(
		LIME_SAFEREF(parent, m_SceneNode),
		rotateSpeed);

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeMaya(SceneNode^ parent)
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeMaya(
		LIME_SAFEREF(parent, m_SceneNode));

	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeMaya()
{
	scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeMaya();
	return CameraSceneNode::Wrap(n);
}

CameraSceneNode^ SceneManager::AddCameraSceneNodeWolvenKit()
{
    scene::ICameraSceneNode* n = m_SceneManager->addCameraSceneNodeWolvenKit();
    return CameraSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddCubeSceneNode(float size, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addCubeSceneNode(
		size,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddCubeSceneNode(float size, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addCubeSceneNode(
		size,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddCubeSceneNode(float size, SceneNode^ parent, int id, Vector3Df^ position)
{
	LIME_ASSERT(position != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addCubeSceneNode(
		size,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddCubeSceneNode(float size, SceneNode^ parent, int id)
{
	scene::IMeshSceneNode* n = m_SceneManager->addCubeSceneNode(
		size,
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddCubeSceneNode(float size, SceneNode^ parent)
{
	scene::IMeshSceneNode* n = m_SceneManager->addCubeSceneNode(
		size,
		LIME_SAFEREF(parent, m_SceneNode));

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddCubeSceneNode(float size)
{
	scene::IMeshSceneNode* n = m_SceneManager->addCubeSceneNode(size);
	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddCubeSceneNode()
{
	scene::IMeshSceneNode* n = m_SceneManager->addCubeSceneNode();
	return MeshSceneNode::Wrap(n);
}

DummyTransformationSceneNode^ SceneManager::AddDummyTransformationSceneNode(SceneNode^ parent, int id)
{
	scene::IDummyTransformationSceneNode* n = m_SceneManager->addDummyTransformationSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return DummyTransformationSceneNode::Wrap(n);
}

DummyTransformationSceneNode^ SceneManager::AddDummyTransformationSceneNode(SceneNode^ parent)
{
	scene::IDummyTransformationSceneNode* n = m_SceneManager->addDummyTransformationSceneNode(
		LIME_SAFEREF(parent, m_SceneNode));

	return DummyTransformationSceneNode::Wrap(n);
}

DummyTransformationSceneNode^ SceneManager::AddDummyTransformationSceneNode()
{
	scene::IDummyTransformationSceneNode* n = m_SceneManager->addDummyTransformationSceneNode();
	return DummyTransformationSceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddEmptySceneNode(SceneNode^ parent, int id)
{
	scene::ISceneNode* n = m_SceneManager->addEmptySceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddEmptySceneNode(SceneNode^ parent)
{
	scene::ISceneNode* n = m_SceneManager->addEmptySceneNode(
		LIME_SAFEREF(parent, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddEmptySceneNode()
{
	scene::ISceneNode* n = m_SceneManager->addEmptySceneNode();
	return SceneNode::Wrap(n);
}

void SceneManager::AddExternalMeshLoader(MeshLoader^ externalLoader)
{
	LIME_ASSERT(externalLoader != nullptr);
	m_SceneManager->addExternalMeshLoader(LIME_SAFEREF(externalLoader, m_MeshLoader));
}

void SceneManager::AddExternalSceneLoader(SceneLoader^ externalLoader)
{
	LIME_ASSERT(externalLoader != nullptr);
	m_SceneManager->addExternalSceneLoader(LIME_SAFEREF(externalLoader, m_SceneLoader));
}

AnimatedMesh^ SceneManager::AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material,
	float hillHeight, Dimension2Df^ countHills, Dimension2Df^ textureRepeatCount)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(tileSize != nullptr);
	LIME_ASSERT(tileCount != nullptr);
	LIME_ASSERT(tileCount->Width >= 0);
	LIME_ASSERT(tileCount->Height >= 0);
	LIME_ASSERT(countHills != nullptr);
	LIME_ASSERT(textureRepeatCount != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addHillPlaneMesh(
		Lime::StringToPath(name),
		*tileSize->m_NativeValue,
		(core::dimension2du&)*tileCount->m_NativeValue,
		LIME_SAFEREF(material, m_NativeValue),
		hillHeight,
		*countHills->m_NativeValue,
		*textureRepeatCount->m_NativeValue);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material,
	float hillHeight, Dimension2Df^ countHills)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(tileSize != nullptr);
	LIME_ASSERT(tileCount != nullptr);
	LIME_ASSERT(tileCount->Width >= 0);
	LIME_ASSERT(tileCount->Height >= 0);
	LIME_ASSERT(countHills != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addHillPlaneMesh(
		Lime::StringToPath(name),
		*tileSize->m_NativeValue,
		(core::dimension2du&)*tileCount->m_NativeValue,
		LIME_SAFEREF(material, m_NativeValue),
		hillHeight,
		*countHills->m_NativeValue);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material,
	float hillHeight)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(tileSize != nullptr);
	LIME_ASSERT(tileCount != nullptr);
	LIME_ASSERT(tileCount->Width >= 0);
	LIME_ASSERT(tileCount->Height >= 0);

	scene::IAnimatedMesh* m = m_SceneManager->addHillPlaneMesh(
		Lime::StringToPath(name),
		*tileSize->m_NativeValue,
		(core::dimension2du&)*tileCount->m_NativeValue,
		LIME_SAFEREF(material, m_NativeValue),
		hillHeight);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(tileSize != nullptr);
	LIME_ASSERT(tileCount != nullptr);
	LIME_ASSERT(tileCount->Width >= 0);
	LIME_ASSERT(tileCount->Height >= 0);

	scene::IAnimatedMesh* m = m_SceneManager->addHillPlaneMesh(
		Lime::StringToPath(name),
		*tileSize->m_NativeValue,
		(core::dimension2du&)*tileCount->m_NativeValue,
		LIME_SAFEREF(material, m_NativeValue));

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(tileSize != nullptr);
	LIME_ASSERT(tileCount != nullptr);
	LIME_ASSERT(tileCount->Width >= 0);
	LIME_ASSERT(tileCount->Height >= 0);

	scene::IAnimatedMesh* m = m_SceneManager->addHillPlaneMesh(
		Lime::StringToPath(name),
		*tileSize->m_NativeValue,
		(core::dimension2du&)*tileCount->m_NativeValue);

	return AnimatedMesh::Wrap(m);
}

LightSceneNode^ SceneManager::AddLightSceneNode(SceneNode^ parent, Vector3Df^ position, Video::Colorf^ color, float radius, int id)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(color != nullptr);

	scene::ILightSceneNode* l = m_SceneManager->addLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*position->m_NativeValue,
		*color->m_NativeValue,
		radius,
		id);

	return LightSceneNode::Wrap(l);
}

LightSceneNode^ SceneManager::AddLightSceneNode(SceneNode^ parent, Vector3Df^ position, Video::Colorf^ color, float radius)
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

LightSceneNode^ SceneManager::AddLightSceneNode(SceneNode^ parent, Vector3Df^ position, Video::Colorf^ color)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(color != nullptr);

	scene::ILightSceneNode* l = m_SceneManager->addLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*position->m_NativeValue,
		*color->m_NativeValue);

	return LightSceneNode::Wrap(l);
}

LightSceneNode^ SceneManager::AddLightSceneNode(SceneNode^ parent, Vector3Df^ position)
{
	LIME_ASSERT(position != nullptr);

	scene::ILightSceneNode* l = m_SceneManager->addLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		*position->m_NativeValue);

	return LightSceneNode::Wrap(l);
}

LightSceneNode^ SceneManager::AddLightSceneNode(SceneNode^ parent)
{
	scene::ILightSceneNode* l = m_SceneManager->addLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode));

	return LightSceneNode::Wrap(l);
}

LightSceneNode^ SceneManager::AddLightSceneNode()
{
	scene::ILightSceneNode* l = m_SceneManager->addLightSceneNode();
	return LightSceneNode::Wrap(l);
}

MeshSceneNode^ SceneManager::AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, bool alsoAddIfMeshIsNull)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addMeshSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		alsoAddIfMeshIsNull);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addMeshSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addMeshSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position)
{
	LIME_ASSERT(position != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addMeshSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id)
{
	scene::IMeshSceneNode* n = m_SceneManager->addMeshSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent)
{
	scene::IMeshSceneNode* n = m_SceneManager->addMeshSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode));

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddMeshSceneNode(Mesh^ mesh)
{
	scene::IMeshSceneNode* n = m_SceneManager->addMeshSceneNode(LIME_SAFEREF(mesh, m_Mesh));
	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddOctreeSceneNode(Mesh^ mesh, SceneNode^ parent, int id, int minimalPolysPerNode, bool alsoAddIfMeshPointerZero)
{
	scene::IMeshSceneNode* n = m_SceneManager->addOctreeSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		minimalPolysPerNode,
		alsoAddIfMeshPointerZero);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddOctreeSceneNode(Mesh^ mesh, SceneNode^ parent, int id, int minimalPolysPerNode)
{
	scene::IMeshSceneNode* n = m_SceneManager->addOctreeSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		minimalPolysPerNode);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddOctreeSceneNode(Mesh^ mesh, SceneNode^ parent, int id)
{
	scene::IMeshSceneNode* n = m_SceneManager->addOctreeSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddOctreeSceneNode(Mesh^ mesh, SceneNode^ parent)
{
	scene::IMeshSceneNode* n = m_SceneManager->addOctreeSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(parent, m_SceneNode));

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddOctreeSceneNode(Mesh^ mesh)
{
	scene::IMeshSceneNode* n = m_SceneManager->addOctreeSceneNode(
		LIME_SAFEREF(mesh, m_Mesh));

	return MeshSceneNode::Wrap(n);
}

ParticleSystemSceneNode^ SceneManager::AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent, int id,
	Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::IParticleSystemSceneNode* n = m_SceneManager->addParticleSystemSceneNode(
		withDefaultEmitter,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue);

	return ParticleSystemSceneNode::Wrap(n);
}

ParticleSystemSceneNode^ SceneManager::AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent, int id,
	Vector3Df^ position, Vector3Df^ rotation)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::IParticleSystemSceneNode* n = m_SceneManager->addParticleSystemSceneNode(
		withDefaultEmitter,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	return ParticleSystemSceneNode::Wrap(n);
}

ParticleSystemSceneNode^ SceneManager::AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent, int id,
	Vector3Df^ position)
{
	LIME_ASSERT(position != nullptr);

	scene::IParticleSystemSceneNode* n = m_SceneManager->addParticleSystemSceneNode(
		withDefaultEmitter,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue);

	return ParticleSystemSceneNode::Wrap(n);
}

ParticleSystemSceneNode^ SceneManager::AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent, int id)
{
	scene::IParticleSystemSceneNode* n = m_SceneManager->addParticleSystemSceneNode(
		withDefaultEmitter,
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return ParticleSystemSceneNode::Wrap(n);
}

ParticleSystemSceneNode^ SceneManager::AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent)
{
	scene::IParticleSystemSceneNode* n = m_SceneManager->addParticleSystemSceneNode(
		withDefaultEmitter,
		LIME_SAFEREF(parent, m_SceneNode));

	return ParticleSystemSceneNode::Wrap(n);
}

ParticleSystemSceneNode^ SceneManager::AddParticleSystemSceneNode(bool withDefaultEmitter)
{
	scene::IParticleSystemSceneNode* n = m_SceneManager->addParticleSystemSceneNode(withDefaultEmitter);
	return ParticleSystemSceneNode::Wrap(n);
}

ParticleSystemSceneNode^ SceneManager::AddParticleSystemSceneNode()
{
	scene::IParticleSystemSceneNode* n = m_SceneManager->addParticleSystemSceneNode();
	return ParticleSystemSceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSceneNode(String^ sceneNodeTypeName, SceneNode^ parent)
{
	scene::ISceneNode* n = m_SceneManager->addSceneNode(
		LIME_SAFESTRINGTOSTRINGC_C_STR(sceneNodeTypeName),
		LIME_SAFEREF(parent, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSceneNode(String^ sceneNodeTypeName)
{
	scene::ISceneNode* n = m_SceneManager->addSceneNode(
		LIME_SAFESTRINGTOSTRINGC_C_STR(sceneNodeTypeName));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyBoxSceneNode(Video::Texture^ topTexture, Video::Texture^ bottomTexture, Video::Texture^ leftTexture,
	Video::Texture^ rightTexture, Video::Texture^ frontTexture, Video::Texture^ backTexture, SceneNode^ parent, int id)
{
	scene::ISceneNode* n = m_SceneManager->addSkyBoxSceneNode(
		LIME_SAFEREF(topTexture, m_Texture),
		LIME_SAFEREF(bottomTexture, m_Texture),
		LIME_SAFEREF(leftTexture, m_Texture),
		LIME_SAFEREF(rightTexture, m_Texture),
		LIME_SAFEREF(frontTexture, m_Texture),
		LIME_SAFEREF(backTexture, m_Texture),
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyBoxSceneNode(Video::Texture^ topTexture, Video::Texture^ bottomTexture, Video::Texture^ leftTexture,
	Video::Texture^ rightTexture, Video::Texture^ frontTexture, Video::Texture^ backTexture, SceneNode^ parent)
{
	scene::ISceneNode* n = m_SceneManager->addSkyBoxSceneNode(
		LIME_SAFEREF(topTexture, m_Texture),
		LIME_SAFEREF(bottomTexture, m_Texture),
		LIME_SAFEREF(leftTexture, m_Texture),
		LIME_SAFEREF(rightTexture, m_Texture),
		LIME_SAFEREF(frontTexture, m_Texture),
		LIME_SAFEREF(backTexture, m_Texture),
		LIME_SAFEREF(parent, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyBoxSceneNode(Video::Texture^ topTexture, Video::Texture^ bottomTexture, Video::Texture^ leftTexture,
	Video::Texture^ rightTexture, Video::Texture^ frontTexture, Video::Texture^ backTexture)
{
	scene::ISceneNode* n = m_SceneManager->addSkyBoxSceneNode(
		LIME_SAFEREF(topTexture, m_Texture),
		LIME_SAFEREF(bottomTexture, m_Texture),
		LIME_SAFEREF(leftTexture, m_Texture),
		LIME_SAFEREF(rightTexture, m_Texture),
		LIME_SAFEREF(frontTexture, m_Texture),
		LIME_SAFEREF(backTexture, m_Texture));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyBoxSceneNode(String^ topFile, String^ bottomFile, String^ leftFile, String^ rightFile, String^ frontFile,
	String^ backFile, SceneNode^ parent, int id)
{
	LIME_ASSERT(topFile != nullptr);
	LIME_ASSERT(bottomFile != nullptr);
	LIME_ASSERT(leftFile != nullptr);
	LIME_ASSERT(rightFile != nullptr);
	LIME_ASSERT(frontFile != nullptr);
	LIME_ASSERT(backFile != nullptr);

	video::ITexture* t = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(topFile));
	video::ITexture* b = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(bottomFile));
	video::ITexture* l = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(leftFile));
	video::ITexture* r = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(rightFile));
	video::ITexture* f = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(frontFile));
	video::ITexture* k = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(backFile));

	scene::ISceneNode* n = m_SceneManager->addSkyBoxSceneNode(
		t, b, l, r, f, k,
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyBoxSceneNode(String^ topFile, String^ bottomFile, String^ leftFile, String^ rightFile, String^ frontFile,
	String^ backFile, SceneNode^ parent)
{
	LIME_ASSERT(topFile != nullptr);
	LIME_ASSERT(bottomFile != nullptr);
	LIME_ASSERT(leftFile != nullptr);
	LIME_ASSERT(rightFile != nullptr);
	LIME_ASSERT(frontFile != nullptr);
	LIME_ASSERT(backFile != nullptr);

	video::ITexture* t = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(topFile));
	video::ITexture* b = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(bottomFile));
	video::ITexture* l = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(leftFile));
	video::ITexture* r = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(rightFile));
	video::ITexture* f = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(frontFile));
	video::ITexture* k = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(backFile));

	scene::ISceneNode* n = m_SceneManager->addSkyBoxSceneNode(
		t, b, l, r, f, k,
		LIME_SAFEREF(parent, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyBoxSceneNode(String^ topFile, String^ bottomFile, String^ leftFile, String^ rightFile, String^ frontFile,
	String^ backFile)
{
	LIME_ASSERT(topFile != nullptr);
	LIME_ASSERT(bottomFile != nullptr);
	LIME_ASSERT(leftFile != nullptr);
	LIME_ASSERT(rightFile != nullptr);
	LIME_ASSERT(frontFile != nullptr);
	LIME_ASSERT(backFile != nullptr);

	video::ITexture* t = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(topFile));
	video::ITexture* b = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(bottomFile));
	video::ITexture* l = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(leftFile));
	video::ITexture* r = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(rightFile));
	video::ITexture* f = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(frontFile));
	video::ITexture* k = m_SceneManager->getVideoDriver()->getTexture(Lime::StringToPath(backFile));

	scene::ISceneNode* n = m_SceneManager->addSkyBoxSceneNode(t, b, l, r, f, k);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage, float radius, SceneNode^ parent, int id)
{
	LIME_ASSERT(horiRes > 0);
	LIME_ASSERT(vertRes > 0);
	LIME_ASSERT(texturePercentage >= 0.0f && texturePercentage <= 1.0f);
	LIME_ASSERT(spherePercentage >= 0.0f && spherePercentage <= 2.0f);
	LIME_ASSERT(radius > 0.0f);

	scene::ISceneNode* n = m_SceneManager->addSkyDomeSceneNode(
		LIME_SAFEREF(texture, m_Texture),
		horiRes,
		vertRes,
		texturePercentage,
		spherePercentage,
		radius,
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage, float radius, SceneNode^ parent)
{
	LIME_ASSERT(horiRes > 0);
	LIME_ASSERT(vertRes > 0);
	LIME_ASSERT(texturePercentage >= 0.0f && texturePercentage <= 1.0f);
	LIME_ASSERT(spherePercentage >= 0.0f && spherePercentage <= 2.0f);
	LIME_ASSERT(radius > 0.0f);

	scene::ISceneNode* n = m_SceneManager->addSkyDomeSceneNode(
		LIME_SAFEREF(texture, m_Texture),
		horiRes,
		vertRes,
		texturePercentage,
		spherePercentage,
		radius,
		LIME_SAFEREF(parent, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage, float radius)
{
	LIME_ASSERT(horiRes > 0);
	LIME_ASSERT(vertRes > 0);
	LIME_ASSERT(texturePercentage >= 0.0f && texturePercentage <= 1.0f);
	LIME_ASSERT(spherePercentage >= 0.0f && spherePercentage <= 2.0f);
	LIME_ASSERT(radius > 0.0f);

	scene::ISceneNode* n = m_SceneManager->addSkyDomeSceneNode(
		LIME_SAFEREF(texture, m_Texture),
		horiRes,
		vertRes,
		texturePercentage,
		spherePercentage,
		radius);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage)
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

SceneNode^ SceneManager::AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes)
{
	LIME_ASSERT(horiRes > 0);
	LIME_ASSERT(vertRes > 0);

	scene::ISceneNode* n = m_SceneManager->addSkyDomeSceneNode(
		LIME_SAFEREF(texture, m_Texture),
		horiRes,
		vertRes);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddSkyDomeSceneNode(Video::Texture^ texture)
{
	scene::ISceneNode* n = m_SceneManager->addSkyDomeSceneNode(LIME_SAFEREF(texture, m_Texture));
	return SceneNode::Wrap(n);
}

AnimatedMesh^ SceneManager::AddSphereMesh(String^ name, float radius, int polyCountX, int polyCountY)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(radius > 0.0f);
	LIME_ASSERT(polyCountX > 0);
	LIME_ASSERT(polyCountY > 0);

	scene::IAnimatedMesh* m = m_SceneManager->addSphereMesh(
		Lime::StringToPath(name),
		radius,
		polyCountX,
		polyCountY);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddSphereMesh(String^ name, float radius)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(radius > 0.0f);

	scene::IAnimatedMesh* m = m_SceneManager->addSphereMesh(
		Lime::StringToPath(name),
		radius);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddSphereMesh(String^ name)
{
	LIME_ASSERT(name != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addSphereMesh(Lime::StringToPath(name));
	return AnimatedMesh::Wrap(m);
}

MeshSceneNode^ SceneManager::AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent, int id,
	Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale)
{
	LIME_ASSERT(polyCount < 256);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addSphereSceneNode(
		radius,
		polyCount,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent, int id,
	Vector3Df^ position, Vector3Df^ rotation)
{
	LIME_ASSERT(polyCount < 256);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addSphereSceneNode(
		radius,
		polyCount,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent, int id,
	Vector3Df^ position)
{
	LIME_ASSERT(polyCount < 256);
	LIME_ASSERT(position != nullptr);

	scene::IMeshSceneNode* n = m_SceneManager->addSphereSceneNode(
		radius,
		polyCount,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent, int id)
{
	LIME_ASSERT(polyCount < 256);

	scene::IMeshSceneNode* n = m_SceneManager->addSphereSceneNode(
		radius,
		polyCount,
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent)
{
	LIME_ASSERT(polyCount < 256);

	scene::IMeshSceneNode* n = m_SceneManager->addSphereSceneNode(
		radius,
		polyCount,
		LIME_SAFEREF(parent, m_SceneNode));

	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddSphereSceneNode(float radius, int polyCount)
{
	LIME_ASSERT(polyCount < 256);

	scene::IMeshSceneNode* n = m_SceneManager->addSphereSceneNode(radius, polyCount);
	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddSphereSceneNode(float radius)
{
	scene::IMeshSceneNode* n = m_SceneManager->addSphereSceneNode(radius);
	return MeshSceneNode::Wrap(n);
}

MeshSceneNode^ SceneManager::AddSphereSceneNode()
{
	scene::IMeshSceneNode* n = m_SceneManager->addSphereSceneNode();
	return MeshSceneNode::Wrap(n);
}

AnimatedMesh^ SceneManager::AddTerrainMesh(String^ meshname, Video::Image^ texture, Video::Image^ heightmap, Dimension2Df^ stretchSize,
	float maxHeight, Dimension2Di^ defaultVertexBlockSize)
{
	LIME_ASSERT(meshname != nullptr);
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(heightmap != nullptr);
	LIME_ASSERT(stretchSize != nullptr);
	LIME_ASSERT(defaultVertexBlockSize != nullptr);
	LIME_ASSERT(defaultVertexBlockSize->Width >= 0);
	LIME_ASSERT(defaultVertexBlockSize->Height >= 0);

	scene::IAnimatedMesh* m = m_SceneManager->addTerrainMesh(
		Lime::StringToPath(meshname),
		LIME_SAFEREF(texture, m_Image),
		LIME_SAFEREF(heightmap, m_Image),
		*stretchSize->m_NativeValue,
		maxHeight,
		(core::dimension2du&)*defaultVertexBlockSize->m_NativeValue);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddTerrainMesh(String^ meshname, Video::Image^ texture, Video::Image^ heightmap, Dimension2Df^ stretchSize,
	float maxHeight)
{
	LIME_ASSERT(meshname != nullptr);
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(heightmap != nullptr);
	LIME_ASSERT(stretchSize != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addTerrainMesh(
		Lime::StringToPath(meshname),
		LIME_SAFEREF(texture, m_Image),
		LIME_SAFEREF(heightmap, m_Image),
		*stretchSize->m_NativeValue,
		maxHeight);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddTerrainMesh(String^ meshname, Video::Image^ texture, Video::Image^ heightmap, Dimension2Df^ stretchSize)
{
	LIME_ASSERT(meshname != nullptr);
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(heightmap != nullptr);
	LIME_ASSERT(stretchSize != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addTerrainMesh(
		Lime::StringToPath(meshname),
		LIME_SAFEREF(texture, m_Image),
		LIME_SAFEREF(heightmap, m_Image),
		*stretchSize->m_NativeValue);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddTerrainMesh(String^ meshname, Video::Image^ texture, Video::Image^ heightmap)
{
	LIME_ASSERT(meshname != nullptr);
	LIME_ASSERT(texture != nullptr);
	LIME_ASSERT(heightmap != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addTerrainMesh(
		Lime::StringToPath(meshname),
		LIME_SAFEREF(texture, m_Image),
		LIME_SAFEREF(heightmap, m_Image));

	return AnimatedMesh::Wrap(m);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize, int smoothFactor,
	bool addAlsoIfHeightmapEmpty)
{
	LIME_ASSERT(heightMapFileName != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);
	LIME_ASSERT(maxLOD > 0);
	LIME_ASSERT((int)pow((float)maxLOD - 1, 2) < (int)patchSize);
	LIME_ASSERT(smoothFactor >= 0);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue,
		maxLOD,
		(scene::E_TERRAIN_PATCH_SIZE)patchSize,
		smoothFactor,
		addAlsoIfHeightmapEmpty);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize, int smoothFactor)
{
	LIME_ASSERT(heightMapFileName != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);
	LIME_ASSERT(maxLOD > 0);
	LIME_ASSERT((int)pow((float)maxLOD - 1, 2) < (int)patchSize);
	LIME_ASSERT(smoothFactor >= 0);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue,
		maxLOD,
		(scene::E_TERRAIN_PATCH_SIZE)patchSize,
		smoothFactor);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize)
{
	LIME_ASSERT(heightMapFileName != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);
	LIME_ASSERT(maxLOD > 0);
	LIME_ASSERT((int)pow((float)maxLOD - 1, 2) < (int)patchSize);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue,
		maxLOD,
		(scene::E_TERRAIN_PATCH_SIZE)patchSize);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD)
{
	LIME_ASSERT(heightMapFileName != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);
	LIME_ASSERT(maxLOD > 0);
	LIME_ASSERT((int)pow((float)maxLOD - 1, 2) < (int)scene::ETPS_17); // scene::ETPS_17 is a default value for patchSize

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue,
		maxLOD);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor)
{
	LIME_ASSERT(heightMapFileName != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale)
{
	LIME_ASSERT(heightMapFileName != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation)
{
	LIME_ASSERT(heightMapFileName != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position)
{
	LIME_ASSERT(heightMapFileName != nullptr);
	LIME_ASSERT(position != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id)
{
	LIME_ASSERT(heightMapFileName != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent)
{
	LIME_ASSERT(heightMapFileName != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName),
		LIME_SAFEREF(parent, m_SceneNode));

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(String^ heightMapFileName)
{
	LIME_ASSERT(heightMapFileName != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		Lime::StringToPath(heightMapFileName));

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize, int smoothFactor,
	bool addAlsoIfHeightmapEmpty)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);
	LIME_ASSERT(maxLOD > 0);
	LIME_ASSERT((int)pow((float)maxLOD - 1, 2) < (int)patchSize);
	LIME_ASSERT(smoothFactor >= 0);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue,
		maxLOD,
		(scene::E_TERRAIN_PATCH_SIZE)patchSize,
		smoothFactor,
		addAlsoIfHeightmapEmpty);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize, int smoothFactor)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);
	LIME_ASSERT(maxLOD > 0);
	LIME_ASSERT((int)pow((float)maxLOD - 1, 2) < (int)patchSize);
	LIME_ASSERT(smoothFactor >= 0);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue,
		maxLOD,
		(scene::E_TERRAIN_PATCH_SIZE)patchSize,
		smoothFactor);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);
	LIME_ASSERT(maxLOD > 0);
	LIME_ASSERT((int)pow((float)maxLOD - 1, 2) < (int)patchSize);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue,
		maxLOD,
		(scene::E_TERRAIN_PATCH_SIZE)patchSize);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);
	LIME_ASSERT(maxLOD > 0);
	LIME_ASSERT((int)pow((float)maxLOD - 1, 2) < (int)scene::ETPS_17); // scene::ETPS_17 is a default value for patchSize

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue,
		maxLOD);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);
	LIME_ASSERT(vertexColor != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue,
		*vertexColor->m_NativeValue);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation, Vector3Df^ scale)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position,
	Vector3Df^ rotation)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position)
{
	LIME_ASSERT(position != nullptr);

	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id)
{
	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent)
{
	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile),
		LIME_SAFEREF(parent, m_SceneNode));

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNode^ SceneManager::AddTerrainSceneNode(IO::ReadFile^ heightMapFile)
{
	scene::ITerrainSceneNode* n = m_SceneManager->addTerrainSceneNode(
		LIME_SAFEREF(heightMapFile, m_ReadFile));

	return TerrainSceneNode::Wrap(n);
}

TerrainSceneNodeWolvenKit^ SceneManager::AddTerrainSceneNodeWolvenKit(String^ heightMapFileName, SceneNode^ parent, int id, int dimension , float maxHeight, float minHeight, float tileSize, Vector3Df^ anchor)
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

TextSceneNode^ SceneManager::AddTextSceneNode(GUI::GUIFont^ font, String^ text, Video::Color^ color, SceneNode^ parent, Vector3Df^ position, int id)
{
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(position != nullptr);

	scene::ITextSceneNode* n = m_SceneManager->addTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		*color->m_NativeValue,
		LIME_SAFEREF(parent, m_SceneNode),
		*position->m_NativeValue,
		id);

	return TextSceneNode::Wrap(n);
}

TextSceneNode^ SceneManager::AddTextSceneNode(GUI::GUIFont^ font, String^ text, Video::Color^ color, SceneNode^ parent, Vector3Df^ position)
{
	LIME_ASSERT(color != nullptr);
	LIME_ASSERT(position != nullptr);

	scene::ITextSceneNode* n = m_SceneManager->addTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		*color->m_NativeValue,
		LIME_SAFEREF(parent, m_SceneNode),
		*position->m_NativeValue);

	return TextSceneNode::Wrap(n);
}

TextSceneNode^ SceneManager::AddTextSceneNode(GUI::GUIFont^ font, String^ text, Video::Color^ color, SceneNode^ parent)
{
	LIME_ASSERT(color != nullptr);

	scene::ITextSceneNode* n = m_SceneManager->addTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		*color->m_NativeValue,
		LIME_SAFEREF(parent, m_SceneNode));

	return TextSceneNode::Wrap(n);
}

TextSceneNode^ SceneManager::AddTextSceneNode(GUI::GUIFont^ font, String^ text, Video::Color^ color)
{
	LIME_ASSERT(color != nullptr);

	scene::ITextSceneNode* n = m_SceneManager->addTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		*color->m_NativeValue);

	return TextSceneNode::Wrap(n);
}

TextSceneNode^ SceneManager::AddTextSceneNode(GUI::GUIFont^ font, String^ text)
{
	scene::ITextSceneNode* n = m_SceneManager->addTextSceneNode(
		LIME_SAFEREF(font, m_GUIFont),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));

	return TextSceneNode::Wrap(n);
}

void SceneManager::AddToDeletionQueue(SceneNode^ node)
{
	m_SceneManager->addToDeletionQueue(LIME_SAFEREF(node, m_SceneNode));
}

AnimatedMesh^ SceneManager::AddVolumeLightMesh(String^ name, int subdivU, int subdivV, Video::Color^ footColor, Video::Color^ tailColor)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(subdivU > 0);
	LIME_ASSERT(subdivV > 0);
	LIME_ASSERT(footColor != nullptr);
	LIME_ASSERT(tailColor != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addVolumeLightMesh(
		Lime::StringToPath(name),
		subdivU,
		subdivV,
		*footColor->m_NativeValue,
		*tailColor->m_NativeValue);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddVolumeLightMesh(String^ name, int subdivU, int subdivV, Video::Color^ footColor)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(subdivU > 0);
	LIME_ASSERT(subdivV > 0);
	LIME_ASSERT(footColor != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addVolumeLightMesh(
		Lime::StringToPath(name),
		subdivU,
		subdivV,
		*footColor->m_NativeValue);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddVolumeLightMesh(String^ name, int subdivU, int subdivV)
{
	LIME_ASSERT(name != nullptr);
	LIME_ASSERT(subdivU > 0);
	LIME_ASSERT(subdivV > 0);

	scene::IAnimatedMesh* m = m_SceneManager->addVolumeLightMesh(
		Lime::StringToPath(name),
		subdivU,
		subdivV);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::AddVolumeLightMesh(String^ name)
{
	LIME_ASSERT(name != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->addVolumeLightMesh(Lime::StringToPath(name));
	return AnimatedMesh::Wrap(m);
}

VolumeLightSceneNode^ SceneManager::AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV,
	Video::Color^ foot, Video::Color^ tail, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale)
{
	LIME_ASSERT(subdivU > 0);
	LIME_ASSERT(subdivV > 0);
	LIME_ASSERT(foot != nullptr);
	LIME_ASSERT(tail != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);
	LIME_ASSERT(scale != nullptr);

	scene::IVolumeLightSceneNode* n = m_SceneManager->addVolumeLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		subdivU,
		subdivV,
		*foot->m_NativeValue,
		*tail->m_NativeValue,
		*position->m_NativeValue,
		*rotation->m_NativeValue,
		*scale->m_NativeValue);

	return VolumeLightSceneNode::Wrap(n);
}

VolumeLightSceneNode^ SceneManager::AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV,
	Video::Color^ foot, Video::Color^ tail, Vector3Df^ position, Vector3Df^ rotation)
{
	LIME_ASSERT(subdivU > 0);
	LIME_ASSERT(subdivV > 0);
	LIME_ASSERT(foot != nullptr);
	LIME_ASSERT(tail != nullptr);
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::IVolumeLightSceneNode* n = m_SceneManager->addVolumeLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		subdivU,
		subdivV,
		*foot->m_NativeValue,
		*tail->m_NativeValue,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	return VolumeLightSceneNode::Wrap(n);
}

VolumeLightSceneNode^ SceneManager::AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV,
	Video::Color^ foot, Video::Color^ tail, Vector3Df^ position)
{
	LIME_ASSERT(subdivU > 0);
	LIME_ASSERT(subdivV > 0);
	LIME_ASSERT(foot != nullptr);
	LIME_ASSERT(tail != nullptr);
	LIME_ASSERT(position != nullptr);

	scene::IVolumeLightSceneNode* n = m_SceneManager->addVolumeLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		subdivU,
		subdivV,
		*foot->m_NativeValue,
		*tail->m_NativeValue,
		*position->m_NativeValue);

	return VolumeLightSceneNode::Wrap(n);
}

VolumeLightSceneNode^ SceneManager::AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV,
	Video::Color^ foot, Video::Color^ tail)
{
	LIME_ASSERT(subdivU > 0);
	LIME_ASSERT(subdivV > 0);
	LIME_ASSERT(foot != nullptr);
	LIME_ASSERT(tail != nullptr);

	scene::IVolumeLightSceneNode* n = m_SceneManager->addVolumeLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		subdivU,
		subdivV,
		*foot->m_NativeValue,
		*tail->m_NativeValue);

	return VolumeLightSceneNode::Wrap(n);
}

VolumeLightSceneNode^ SceneManager::AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV, Video::Color^ foot)
{
	LIME_ASSERT(subdivU > 0);
	LIME_ASSERT(subdivV > 0);
	LIME_ASSERT(foot != nullptr);

	scene::IVolumeLightSceneNode* n = m_SceneManager->addVolumeLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		subdivU,
		subdivV,
		*foot->m_NativeValue);

	return VolumeLightSceneNode::Wrap(n);
}

VolumeLightSceneNode^ SceneManager::AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV)
{
	LIME_ASSERT(subdivU > 0);
	LIME_ASSERT(subdivV > 0);

	scene::IVolumeLightSceneNode* n = m_SceneManager->addVolumeLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		subdivU,
		subdivV);

	return VolumeLightSceneNode::Wrap(n);
}

VolumeLightSceneNode^ SceneManager::AddVolumeLightSceneNode(SceneNode^ parent, int id)
{
	scene::IVolumeLightSceneNode* n = m_SceneManager->addVolumeLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return VolumeLightSceneNode::Wrap(n);
}

VolumeLightSceneNode^ SceneManager::AddVolumeLightSceneNode(SceneNode^ parent)
{
	scene::IVolumeLightSceneNode* n = m_SceneManager->addVolumeLightSceneNode(
		LIME_SAFEREF(parent, m_SceneNode));

	return VolumeLightSceneNode::Wrap(n);
}

VolumeLightSceneNode^ SceneManager::AddVolumeLightSceneNode()
{
	scene::IVolumeLightSceneNode* n = m_SceneManager->addVolumeLightSceneNode();
	return VolumeLightSceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent,
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

SceneNode^ SceneManager::AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent,
	int id, Vector3Df^ position, Vector3Df^ rotation)
{
	LIME_ASSERT(position != nullptr);
	LIME_ASSERT(rotation != nullptr);

	scene::ISceneNode* n = m_SceneManager->addWaterSurfaceSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		waveHeight,
		waveSpeed,
		waveLength,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue,
		*rotation->m_NativeValue);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent,
	int id, Vector3Df^ position)
{
	LIME_ASSERT(position != nullptr);

	scene::ISceneNode* n = m_SceneManager->addWaterSurfaceSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		waveHeight,
		waveSpeed,
		waveLength,
		LIME_SAFEREF(parent, m_SceneNode),
		id,
		*position->m_NativeValue);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent,
	int id)
{
	scene::ISceneNode* n = m_SceneManager->addWaterSurfaceSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		waveHeight,
		waveSpeed,
		waveLength,
		LIME_SAFEREF(parent, m_SceneNode),
		id);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent)
{
	scene::ISceneNode* n = m_SceneManager->addWaterSurfaceSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		waveHeight,
		waveSpeed,
		waveLength,
		LIME_SAFEREF(parent, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength)
{
	scene::ISceneNode* n = m_SceneManager->addWaterSurfaceSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		waveHeight,
		waveSpeed,
		waveLength);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed)
{
	scene::ISceneNode* n = m_SceneManager->addWaterSurfaceSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		waveHeight,
		waveSpeed);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight)
{
	scene::ISceneNode* n = m_SceneManager->addWaterSurfaceSceneNode(
		LIME_SAFEREF(mesh, m_Mesh),
		waveHeight);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::AddWaterSurfaceSceneNode(Mesh^ mesh)
{
	scene::ISceneNode* n = m_SceneManager->addWaterSurfaceSceneNode(LIME_SAFEREF(mesh, m_Mesh));
	return SceneNode::Wrap(n);
}

void SceneManager::Clear()
{
	m_SceneManager->clear();
}

CollisionResponseSceneNodeAnimator^ SceneManager::CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node, Vector3Df^ ellipsoidRadius,
	Vector3Df^ gravityPerSecond, Vector3Df^ ellipsoidTranslation, float slidingValue)
{
	LIME_ASSERT(ellipsoidRadius != nullptr);
	LIME_ASSERT(gravityPerSecond != nullptr);
	LIME_ASSERT(ellipsoidTranslation != nullptr);

	scene::ISceneNodeAnimatorCollisionResponse* a = m_SceneManager->createCollisionResponseAnimator(
		LIME_SAFEREF(world, m_TriangleSelector),
		LIME_SAFEREF(node, m_SceneNode),
		*ellipsoidRadius->m_NativeValue,
		*gravityPerSecond->m_NativeValue,
		*ellipsoidTranslation->m_NativeValue,
		slidingValue);

	return CollisionResponseSceneNodeAnimator::Wrap(a);
}

CollisionResponseSceneNodeAnimator^ SceneManager::CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node, Vector3Df^ ellipsoidRadius,
	Vector3Df^ gravityPerSecond, Vector3Df^ ellipsoidTranslation)
{
	LIME_ASSERT(ellipsoidRadius != nullptr);
	LIME_ASSERT(gravityPerSecond != nullptr);
	LIME_ASSERT(ellipsoidTranslation != nullptr);

	scene::ISceneNodeAnimatorCollisionResponse* a = m_SceneManager->createCollisionResponseAnimator(
		LIME_SAFEREF(world, m_TriangleSelector),
		LIME_SAFEREF(node, m_SceneNode),
		*ellipsoidRadius->m_NativeValue,
		*gravityPerSecond->m_NativeValue,
		*ellipsoidTranslation->m_NativeValue);

	return CollisionResponseSceneNodeAnimator::Wrap(a);
}

CollisionResponseSceneNodeAnimator^ SceneManager::CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node, Vector3Df^ ellipsoidRadius,
	Vector3Df^ gravityPerSecond)
{
	LIME_ASSERT(ellipsoidRadius != nullptr);
	LIME_ASSERT(gravityPerSecond != nullptr);

	scene::ISceneNodeAnimatorCollisionResponse* a = m_SceneManager->createCollisionResponseAnimator(
		LIME_SAFEREF(world, m_TriangleSelector),
		LIME_SAFEREF(node, m_SceneNode),
		*ellipsoidRadius->m_NativeValue,
		*gravityPerSecond->m_NativeValue);

	return CollisionResponseSceneNodeAnimator::Wrap(a);
}

CollisionResponseSceneNodeAnimator^ SceneManager::CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node, Vector3Df^ ellipsoidRadius)
{
	LIME_ASSERT(ellipsoidRadius != nullptr);

	scene::ISceneNodeAnimatorCollisionResponse* a = m_SceneManager->createCollisionResponseAnimator(
		LIME_SAFEREF(world, m_TriangleSelector),
		LIME_SAFEREF(node, m_SceneNode),
		*ellipsoidRadius->m_NativeValue);

	return CollisionResponseSceneNodeAnimator::Wrap(a);
}

CollisionResponseSceneNodeAnimator^ SceneManager::CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node)
{
	scene::ISceneNodeAnimatorCollisionResponse* a = m_SceneManager->createCollisionResponseAnimator(
		LIME_SAFEREF(world, m_TriangleSelector),
		LIME_SAFEREF(node, m_SceneNode));

	return CollisionResponseSceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateDeleteAnimator(float time)
{
	LIME_ASSERT(time >= 0.0f);

	scene::ISceneNodeAnimator* a = m_SceneManager->createDeleteAnimator((unsigned int)(time * 1000));
	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyCircleAnimator(Vector3Df^ center, float radius, float speed, Vector3Df^ direction, float startPosition, float radiusEllipsoid)
{
	LIME_ASSERT(center != nullptr);
	LIME_ASSERT(direction != nullptr);
	
	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyCircleAnimator(
		*center->m_NativeValue,
		radius,
		speed,
		*direction->m_NativeValue,
		startPosition,
		radiusEllipsoid);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyCircleAnimator(Vector3Df^ center, float radius, float speed, Vector3Df^ direction, float startPosition)
{
	LIME_ASSERT(center != nullptr);
	LIME_ASSERT(direction != nullptr);
	
	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyCircleAnimator(
		*center->m_NativeValue,
		radius,
		speed,
		*direction->m_NativeValue,
		startPosition);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyCircleAnimator(Vector3Df^ center, float radius, float speed, Vector3Df^ direction)
{
	LIME_ASSERT(center != nullptr);
	LIME_ASSERT(direction != nullptr);
	
	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyCircleAnimator(
		*center->m_NativeValue,
		radius,
		speed,
		*direction->m_NativeValue);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyCircleAnimator(Vector3Df^ center, float radius, float speed)
{
	LIME_ASSERT(center != nullptr);
	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyCircleAnimator(*center->m_NativeValue, radius, speed);
	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyCircleAnimator(Vector3Df^ center, float radius)
{
	LIME_ASSERT(center != nullptr);
	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyCircleAnimator(*center->m_NativeValue, radius);
	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyCircleAnimator(Vector3Df^ center)
{
	LIME_ASSERT(center != nullptr);
	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyCircleAnimator(*center->m_NativeValue);
	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyCircleAnimator()
{
	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyCircleAnimator();
	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyStraightAnimator(Vector3Df^ startPoint, Vector3Df^ endPoint, float timeForWay, bool loop, bool pingpong)
{
	LIME_ASSERT(startPoint != nullptr);
	LIME_ASSERT(endPoint != nullptr);

	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyStraightAnimator(
		*startPoint->m_NativeValue,
		*endPoint->m_NativeValue,
		(unsigned int)(timeForWay * 1000),
		loop,
		pingpong);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyStraightAnimator(Vector3Df^ startPoint, Vector3Df^ endPoint, float timeForWay, bool loop)
{
	LIME_ASSERT(startPoint != nullptr);
	LIME_ASSERT(endPoint != nullptr);

	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyStraightAnimator(
		*startPoint->m_NativeValue,
		*endPoint->m_NativeValue,
		(unsigned int)(timeForWay * 1000),
		loop);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFlyStraightAnimator(Vector3Df^ startPoint, Vector3Df^ endPoint, float timeForWay)
{
	LIME_ASSERT(startPoint != nullptr);
	LIME_ASSERT(endPoint != nullptr);

	scene::ISceneNodeAnimator* a = m_SceneManager->createFlyStraightAnimator(
		*startPoint->m_NativeValue,
		*endPoint->m_NativeValue,
		(unsigned int)(timeForWay * 1000));

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime, float speed, float tightness, bool loop, bool pingpong)
{
	LIME_ASSERT(points != nullptr);
	LIME_ASSERT(points->Count >= 2);
	
	core::array<core::vector3df> p;
	for (int i = 0; i < points->Count; i++)
		p.push_back(*points[i]->m_NativeValue);

	scene::ISceneNodeAnimator* a = m_SceneManager->createFollowSplineAnimator(
		(int)(startTime * 1000),
		p,
		speed,
		tightness,
		loop,
		pingpong);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime, float speed, float tightness, bool loop)
{
	LIME_ASSERT(points != nullptr);
	LIME_ASSERT(points->Count >= 2);
	
	core::array<core::vector3df> p;
	for (int i = 0; i < points->Count; i++)
		p.push_back(*points[i]->m_NativeValue);

	scene::ISceneNodeAnimator* a = m_SceneManager->createFollowSplineAnimator(
		(int)(startTime * 1000),
		p,
		speed,
		tightness,
		loop);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime, float speed, float tightness)
{
	LIME_ASSERT(points != nullptr);
	LIME_ASSERT(points->Count >= 2);
	
	core::array<core::vector3df> p;
	for (int i = 0; i < points->Count; i++)
		p.push_back(*points[i]->m_NativeValue);

	scene::ISceneNodeAnimator* a = m_SceneManager->createFollowSplineAnimator(
		(int)(startTime * 1000),
		p,
		speed,
		tightness);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime, float speed)
{
	LIME_ASSERT(points != nullptr);
	LIME_ASSERT(points->Count >= 2);
	
	core::array<core::vector3df> p;
	for (int i = 0; i < points->Count; i++)
		p.push_back(*points[i]->m_NativeValue);

	scene::ISceneNodeAnimator* a = m_SceneManager->createFollowSplineAnimator(
		(int)(startTime * 1000),
		p,
		speed);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime)
{
	LIME_ASSERT(points != nullptr);
	LIME_ASSERT(points->Count >= 2);
	
	core::array<core::vector3df> p;
	for (int i = 0; i < points->Count; i++)
		p.push_back(*points[i]->m_NativeValue);

	scene::ISceneNodeAnimator* a = m_SceneManager->createFollowSplineAnimator(
		(int)(startTime * 1000),
		p);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateFollowSplineAnimator(List<Vector3Df^>^ points)
{
	LIME_ASSERT(points != nullptr);
	LIME_ASSERT(points->Count >= 2);
	
	core::array<core::vector3df> p;
	for (int i = 0; i < points->Count; i++)
		p.push_back(*points[i]->m_NativeValue);

	scene::ISceneNodeAnimator* a = m_SceneManager->createFollowSplineAnimator(
		0,
		p);

	return SceneNodeAnimator::Wrap(a);
}

MetaTriangleSelector^ SceneManager::CreateMetaTriangleSelector()
{
	scene::IMetaTriangleSelector* s = m_SceneManager->createMetaTriangleSelector();
	return MetaTriangleSelector::Wrap(s);
}

SceneManager^ SceneManager::CreateNewSceneManager(bool cloneContent)
{
	scene::ISceneManager* m = m_SceneManager->createNewSceneManager(cloneContent);
	return SceneManager::Wrap(m);
}

SceneManager^ SceneManager::CreateNewSceneManager()
{
	scene::ISceneManager* m = m_SceneManager->createNewSceneManager();
	return SceneManager::Wrap(m);
}

TriangleSelector^ SceneManager::CreateOctreeTriangleSelector(Mesh^ mesh, SceneNode^ node, int minimalPolysPerNode)
{
	scene::ITriangleSelector* s = m_SceneManager->createOctreeTriangleSelector(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(node, m_SceneNode),
		minimalPolysPerNode);

	return TriangleSelector::Wrap(s);
}

TriangleSelector^ SceneManager::CreateOctreeTriangleSelector(Mesh^ mesh, SceneNode^ node)
{
	scene::ITriangleSelector* s = m_SceneManager->createOctreeTriangleSelector(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(node, m_SceneNode));

	return TriangleSelector::Wrap(s);
}

SceneNodeAnimator^ SceneManager::CreateRotationAnimator(Vector3Df^ rotationSpeed)
{
	LIME_ASSERT(rotationSpeed != nullptr);

	scene::ISceneNodeAnimator* a = m_SceneManager->createRotationAnimator(*rotationSpeed->m_NativeValue);
	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateSceneNodeAnimator(String^ typeName, SceneNode^ targetNode)
{
	LIME_ASSERT(typeName != nullptr);

	scene::ISceneNodeAnimator* a = m_SceneManager->createSceneNodeAnimator(
		LIME_SAFESTRINGTOSTRINGC_C_STR(typeName),
		LIME_SAFEREF(targetNode, m_SceneNode));

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateSceneNodeAnimator(String^ typeName)
{
	LIME_ASSERT(typeName != nullptr);

	scene::ISceneNodeAnimator* a = m_SceneManager->createSceneNodeAnimator(
		LIME_SAFESTRINGTOSTRINGC_C_STR(typeName));

	return SceneNodeAnimator::Wrap(a);
}

SkinnedMesh^ SceneManager::CreateSkinnedMesh()
{
	scene::ISkinnedMesh* m = m_SceneManager->createSkinnedMesh();
	return SkinnedMesh::Wrap(m);
}

TriangleSelector^ SceneManager::CreateTerrainTriangleSelector(TerrainSceneNode^ node, int lodLevel)
{
	LIME_ASSERT(lodLevel >= 0);

	scene::ITriangleSelector* s = m_SceneManager->createTerrainTriangleSelector(
		LIME_SAFEREF(node, m_TerrainSceneNode),
		lodLevel);

	return TriangleSelector::Wrap(s);
}

TriangleSelector^ SceneManager::CreateTerrainTriangleSelector(TerrainSceneNode^ node)
{
	scene::ITriangleSelector* s = m_SceneManager->createTerrainTriangleSelector(
		LIME_SAFEREF(node, m_TerrainSceneNode));

	return TriangleSelector::Wrap(s);
}

SceneNodeAnimator^ SceneManager::CreateTextureAnimator(List<Video::Texture^>^ textures, float timePerFrame, bool loop)
{
	LIME_ASSERT(textures != nullptr);
	LIME_ASSERT(textures->Count > 0);

	core::array<video::ITexture*> r;
	for (int i = 0; i < textures->Count; i++)
	{
		LIME_ASSERT(textures[i] != nullptr);
		r.push_back(LIME_SAFEREF(textures[i], m_Texture));
	}

	scene::ISceneNodeAnimator* a = m_SceneManager->createTextureAnimator(
		r,
		(s32)(timePerFrame * 1000),
		loop);

	return SceneNodeAnimator::Wrap(a);
}

SceneNodeAnimator^ SceneManager::CreateTextureAnimator(List<Video::Texture^>^ textures, float timePerFrame)
{
	LIME_ASSERT(textures != nullptr);
	LIME_ASSERT(textures->Count > 0);

	core::array<video::ITexture*> r;
	for (int i = 0; i < textures->Count; i++)
	{
		LIME_ASSERT(textures[i] != nullptr);
		r.push_back(LIME_SAFEREF(textures[i], m_Texture));
	}

	scene::ISceneNodeAnimator* a = m_SceneManager->createTextureAnimator(
		r,
		(s32)(timePerFrame * 1000));

	return SceneNodeAnimator::Wrap(a);
}

TriangleSelector^ SceneManager::CreateTriangleSelector(AnimatedMeshSceneNode^ node)
{
	scene::ITriangleSelector* s = m_SceneManager->createTriangleSelector(
		LIME_SAFEREF(node, m_AnimatedMeshSceneNode));

	return TriangleSelector::Wrap(s);
}

TriangleSelector^ SceneManager::CreateTriangleSelector(Mesh^ mesh, SceneNode^ node)
{
	scene::ITriangleSelector* s = m_SceneManager->createTriangleSelector(
		LIME_SAFEREF(mesh, m_Mesh),
		LIME_SAFEREF(node, m_SceneNode));

	return TriangleSelector::Wrap(s);
}

TriangleSelector^ SceneManager::CreateTriangleSelectorFromBoundingBox(SceneNode^ node)
{
	scene::ITriangleSelector* s = m_SceneManager->createTriangleSelectorFromBoundingBox(
		LIME_SAFEREF(node, m_SceneNode));

	return TriangleSelector::Wrap(s);
}

void SceneManager::DrawAll()
{
	m_SceneManager->drawAll();
}

String^ SceneManager::GetAnimatorTypeName(SceneNodeAnimatorType type)
{
	return gcnew String(m_SceneManager->getAnimatorTypeName((scene::ESCENE_NODE_ANIMATOR_TYPE)type));
}

AnimatedMesh^ SceneManager::GetMesh(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->getMesh(Lime::StringToPath(filename));
	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ SceneManager::GetMesh(IO::ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);

	scene::IAnimatedMesh* m = m_SceneManager->getMesh(file->m_ReadFile);
	return AnimatedMesh::Wrap(m);
}

Mesh^ SceneManager::GetStaticMesh(String^ filename)
{
	return nullptr;
}

MeshLoader^ SceneManager::GetMeshLoader(int index)
{
	LIME_ASSERT(index >= 0 && index < MeshLoaderCount);

	scene::IMeshLoader* l = m_SceneManager->getMeshLoader(index);
	return MeshLoader::Wrap(l);
}

SceneLoader^ SceneManager::GetSceneLoader(int index)
{
	LIME_ASSERT(index >= 0 && index < SceneLoaderCount);

	scene::ISceneLoader* l = m_SceneManager->getSceneLoader(index);
	return SceneLoader::Wrap(l);
}

SceneNode^ SceneManager::GetSceneNodeFromID(int id, SceneNode^ start)
{
	scene::ISceneNode* n = m_SceneManager->getSceneNodeFromId(id, LIME_SAFEREF(start, m_SceneNode));
	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::GetSceneNodeFromID(int id)
{
	scene::ISceneNode* n = m_SceneManager->getSceneNodeFromId(id);
	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::GetSceneNodeFromName(String^ name, SceneNode^ start)
{
	scene::ISceneNode* n = m_SceneManager->getSceneNodeFromName(
		LIME_SAFESTRINGTOSTRINGC_C_STR(name),
		LIME_SAFEREF(start, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::GetSceneNodeFromName(String^ name)
{
	scene::ISceneNode* n = m_SceneManager->getSceneNodeFromName(
		LIME_SAFESTRINGTOSTRINGC_C_STR(name));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::GetSceneNodeFromType(SceneNodeType type, SceneNode^ start)
{
	scene::ISceneNode* n = m_SceneManager->getSceneNodeFromType((scene::ESCENE_NODE_TYPE)type, LIME_SAFEREF(start, m_SceneNode));
	return SceneNode::Wrap(n);
}

SceneNode^ SceneManager::GetSceneNodeFromType(SceneNodeType type)
{
	scene::ISceneNode* n = m_SceneManager->getSceneNodeFromType((scene::ESCENE_NODE_TYPE)type);
	return SceneNode::Wrap(n);
}

List<SceneNode^>^ SceneManager::GetSceneNodesFromType(SceneNodeType type, SceneNode^ start)
{
	List<SceneNode^>^ l = gcnew List<SceneNode^>();

	core::array<scene::ISceneNode*> n;
	m_SceneManager->getSceneNodesFromType(
		(scene::ESCENE_NODE_TYPE)type,
		n,
		LIME_SAFEREF(start, m_SceneNode));

	for (unsigned int i = 0; i < n.size(); i++)
		l->Add(SceneNode::Wrap(n[i]));

	return l;
}

List<SceneNode^>^ SceneManager::GetSceneNodesFromType(SceneNodeType type)
{
	List<SceneNode^>^ l = gcnew List<SceneNode^>();

	core::array<scene::ISceneNode*> n;
	m_SceneManager->getSceneNodesFromType((scene::ESCENE_NODE_TYPE)type, n);

	for (unsigned int i = 0; i < n.size(); i++)
		l->Add(SceneNode::Wrap(n[i]));

	return l;
}

String^ SceneManager::GetSceneNodeTypeName(SceneNodeType type)
{
	return gcnew String(m_SceneManager->getSceneNodeTypeName((scene::ESCENE_NODE_TYPE)type));
}

bool SceneManager::IsCulled(SceneNode^ node)
{
	LIME_ASSERT(node != nullptr);
	return m_SceneManager->isCulled(LIME_SAFEREF(node, m_SceneNode));
}

bool SceneManager::LoadScene(String^ filename, SceneNode^ node)
{
	LIME_ASSERT(filename != nullptr);
	return m_SceneManager->loadScene(Lime::StringToPath(filename), nullptr, LIME_SAFEREF(node, m_SceneNode));
}

bool SceneManager::LoadScene(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return m_SceneManager->loadScene(Lime::StringToPath(filename));
}

bool SceneManager::LoadScene(IO::ReadFile^ file, SceneNode^ node)
{
	LIME_ASSERT(file != nullptr);
	return m_SceneManager->loadScene(LIME_SAFEREF(file, m_ReadFile), nullptr, LIME_SAFEREF(node, m_SceneNode));
}

bool SceneManager::LoadScene(IO::ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);
	return m_SceneManager->loadScene(LIME_SAFEREF(file, m_ReadFile));
}

bool SceneManager::PostEvent(Event^ e)
{
	LIME_ASSERT(e != nullptr);
	return m_SceneManager->postEventFromUser(*e->m_NativeValue);
}

bool SceneManager::RegisterNodeForRendering(SceneNode^ node, Scene::SceneNodeRenderPass pass)
{
	LIME_ASSERT(node != nullptr);

	return m_SceneManager->registerNodeForRendering(
		LIME_SAFEREF(node, m_SceneNode),
		(E_SCENE_NODE_RENDER_PASS)pass) != 0;
}

bool SceneManager::RegisterNodeForRendering(SceneNode^ node)
{
	LIME_ASSERT(node != nullptr);

	return m_SceneManager->registerNodeForRendering(
		LIME_SAFEREF(node, m_SceneNode)) != 0;
}

bool SceneManager::SaveScene(String^ filename, SceneNode^ node)
{
	LIME_ASSERT(filename != nullptr);
	return m_SceneManager->saveScene(Lime::StringToPath(filename), nullptr, LIME_SAFEREF(node, m_SceneNode));
}

bool SceneManager::SaveScene(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return m_SceneManager->saveScene(Lime::StringToPath(filename));
}

bool SceneManager::SaveScene(IO::WriteFile^ file, SceneNode^ node)
{
	LIME_ASSERT(file != nullptr);
	return m_SceneManager->saveScene(LIME_SAFEREF(file, m_WriteFile), nullptr, LIME_SAFEREF(node, m_SceneNode));
}

bool SceneManager::SaveScene(IO::WriteFile^ file)
{
	LIME_ASSERT(file != nullptr);
	return m_SceneManager->saveScene(LIME_SAFEREF(file, m_WriteFile));
}

CameraSceneNode^ SceneManager::ActiveCamera::get()
{
	scene::ICameraSceneNode* n = m_SceneManager->getActiveCamera();
	return CameraSceneNode::Wrap(n);
}

void SceneManager::ActiveCamera::set(CameraSceneNode^ value)
{
	m_SceneManager->setActiveCamera(LIME_SAFEREF(value, m_CameraSceneNode));
}

Video::Colorf^ SceneManager::AmbientLight::get()
{
	return gcnew Video::Colorf(m_SceneManager->getAmbientLight());
}

void SceneManager::AmbientLight::set(Video::Colorf^ value)
{
	LIME_ASSERT(value != nullptr);
	m_SceneManager->setAmbientLight(*value->m_NativeValue);
}

IO::Attributes^ SceneManager::Attributes::get()
{
	io::IAttributes* a = m_SceneManager->getParameters();
	return IO::Attributes::Wrap(a);
}

IO::FileSystem^ SceneManager::FileSystem::get()
{
	io::IFileSystem* s = m_SceneManager->getFileSystem();
	return IO::FileSystem::Wrap(s);
}

Scene::GeometryCreator^ SceneManager::GeometryCreator::get()
{
	scene::IGeometryCreator* g = (scene::IGeometryCreator*)m_SceneManager->getGeometryCreator(); // !!! cast to non-const
	return Scene::GeometryCreator::Wrap(g);
}

GUI::GUIEnvironment^ SceneManager::GUIEnvironment::get()
{
	gui::IGUIEnvironment* g = m_SceneManager->getGUIEnvironment();
	return GUI::GUIEnvironment::Wrap(g);
}

Scene::MeshCache^ SceneManager::MeshCache::get()
{
	scene::IMeshCache* c = m_SceneManager->getMeshCache();
	return Scene::MeshCache::Wrap(c);
}

int SceneManager::MeshLoaderCount::get()
{
	return m_SceneManager->getMeshLoaderCount();
}

Scene::MeshManipulator^ SceneManager::MeshManipulator::get()
{
	scene::IMeshManipulator* m = m_SceneManager->getMeshManipulator();
	return Scene::MeshManipulator::Wrap(m);
}

SceneNode^ SceneManager::RootNode::get()
{
	scene::ISceneNode* n = m_SceneManager->getRootSceneNode();
	return SceneNode::Wrap(n);
}

Scene::SceneCollisionManager^ SceneManager::SceneCollisionManager::get()
{
	scene::ISceneCollisionManager* m = m_SceneManager->getSceneCollisionManager();
	return Scene::SceneCollisionManager::Wrap(m);
}

int SceneManager::SceneLoaderCount::get()
{
	return m_SceneManager->getSceneLoaderCount();
}

Scene::SceneNodeRenderPass SceneManager::SceneNodeRenderPass::get()
{
	return (Scene::SceneNodeRenderPass)m_SceneManager->getSceneNodeRenderPass();
}

Video::Color^ SceneManager::ShadowColor::get()
{
	return gcnew Video::Color(m_SceneManager->getShadowColor());
}

void SceneManager::ShadowColor::set(Video::Color^ value)
{
	LIME_ASSERT(value != nullptr);
	m_SceneManager->setShadowColor(*value->m_NativeValue);
}

Video::VideoDriver^ SceneManager::VideoDriver::get()
{
	video::IVideoDriver* d = m_SceneManager->getVideoDriver();
	return Video::VideoDriver::Wrap(d);
}

} // end namespace Scene
} // end namespace IrrlichtLime