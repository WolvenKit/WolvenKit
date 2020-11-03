#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"
#include "MeshWriterType.h"


using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime { ref class Event;
namespace IO { ref class Attributes; ref class FileSystem; ref class ReadFile; ref class WriteFile; }
namespace GUI { ref class GUIEnvironment; ref class GUIFont; }
namespace Video { ref class Image; ref class Texture; ref class VideoDriver; }
namespace Scene {

ref class AnimatedMesh;
ref class AnimatedMeshSceneNode;
ref class BillboardSceneNode;
ref class BillboardTextSceneNode;
ref class CameraSceneNode;
ref class CollisionResponseSceneNodeAnimator;
ref class DummyTransformationSceneNode;
ref class GeometryCreator;
ref class LightSceneNode;
ref class Mesh;
ref class MeshCache;
ref class MeshLoader;
ref class MeshManipulator;
ref class MeshSceneNode;
ref class MeshWriter;
ref class MetaTriangleSelector;
ref class ParticleSystemSceneNode;
ref class SceneCollisionManager;
ref class SceneLoader;
ref class SceneNode;
ref class SceneNodeAnimator;
ref class SkinnedMesh;
ref class TerrainSceneNode;
ref class TerrainSceneNodeWolvenKit;
ref class TextSceneNode;
ref class TriangleSelector;
ref class VolumeLightSceneNode;

public ref class SceneManager : ReferenceCounted
{
public:

	AnimatedMeshSceneNode^ AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, bool alsoAddIfMeshPointerZero);
	AnimatedMeshSceneNode^ AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);
	AnimatedMeshSceneNode^ AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation);
	AnimatedMeshSceneNode^ AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position);
	AnimatedMeshSceneNode^ AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent, int id);
	AnimatedMeshSceneNode^ AddAnimatedMeshSceneNode(AnimatedMesh^ mesh, SceneNode^ parent);
	AnimatedMeshSceneNode^ AddAnimatedMeshSceneNode(AnimatedMesh^ mesh);

	AnimatedMesh^ AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder, int tesselationCone, float heightTotal, float heightCylinder, float diameterCylinder, float diameterCone);
	AnimatedMesh^ AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder, int tesselationCone, float heightTotal, float heightCylinder);
	AnimatedMesh^ AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder, int tesselationCone, float heightTotal);
	AnimatedMesh^ AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder, int tesselationCone);
	AnimatedMesh^ AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone, int tesselationCylinder);
	AnimatedMesh^ AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder, Video::Color^ vtxColorCone);
	AnimatedMesh^ AddArrowMesh(String^ name, Video::Color^ vtxColorCylinder);
	AnimatedMesh^ AddArrowMesh(String^ name);

	BillboardSceneNode^ AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position, int id, Video::Color^ colorTop, Video::Color^ colorBottom);
	BillboardSceneNode^ AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position, int id, Video::Color^ colorTop);
	BillboardSceneNode^ AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position, int id);
	BillboardSceneNode^ AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position);
	BillboardSceneNode^ AddBillboardSceneNode(SceneNode^ parent, Dimension2Df^ size);
	BillboardSceneNode^ AddBillboardSceneNode(SceneNode^ parent);
	BillboardSceneNode^ AddBillboardSceneNode();

	BillboardTextSceneNode^ AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position, int id, Video::Color^ colorTop, Video::Color^ colorBottom);
	BillboardTextSceneNode^ AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position, int id);
	BillboardTextSceneNode^ AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent, Dimension2Df^ size, Vector3Df^ position);
	BillboardTextSceneNode^ AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent, Dimension2Df^ size);
	BillboardTextSceneNode^ AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font, SceneNode^ parent);
	BillboardTextSceneNode^ AddBillboardTextSceneNode(String^ text, GUI::GUIFont^ font);
	BillboardTextSceneNode^ AddBillboardTextSceneNode(String^ text);

	CameraSceneNode^ AddCameraSceneNode(SceneNode^ parent, Vector3Df^ position, Vector3Df^ lookat, int id, bool makeActive);
	CameraSceneNode^ AddCameraSceneNode(SceneNode^ parent, Vector3Df^ position, Vector3Df^ lookat, int id);
	CameraSceneNode^ AddCameraSceneNode(SceneNode^ parent, Vector3Df^ position, Vector3Df^ lookat);
	CameraSceneNode^ AddCameraSceneNode(SceneNode^ parent, Vector3Df^ position);
	CameraSceneNode^ AddCameraSceneNode(SceneNode^ parent);
	CameraSceneNode^ AddCameraSceneNode();

	CameraSceneNode^ AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap, bool noVerticalMovement, float jumpSpeed, bool invertMouse, bool makeActive);
	CameraSceneNode^ AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap, bool noVerticalMovement, float jumpSpeed, bool invertMouse);
	CameraSceneNode^ AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap, bool noVerticalMovement, float jumpSpeed);
	CameraSceneNode^ AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap, bool noVerticalMovement);
	CameraSceneNode^ AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id, KeyMap^ keyMap);
	CameraSceneNode^ AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed, int id);
	CameraSceneNode^ AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed, float moveSpeed);
	CameraSceneNode^ AddCameraSceneNodeFPS(SceneNode^ parent, float rotateSpeed);
	CameraSceneNode^ AddCameraSceneNodeFPS(SceneNode^ parent);
	CameraSceneNode^ AddCameraSceneNodeFPS();

	CameraSceneNode^ AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed, float zoomSpeed, float translationSpeed, int id, bool makeActive);
	CameraSceneNode^ AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed, float zoomSpeed, float translationSpeed, int id);
	CameraSceneNode^ AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed, float zoomSpeed, float translationSpeed);
	CameraSceneNode^ AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed, float zoomSpeed);
	CameraSceneNode^ AddCameraSceneNodeMaya(SceneNode^ parent, float rotateSpeed);
	CameraSceneNode^ AddCameraSceneNodeMaya(SceneNode^ parent);
	CameraSceneNode^ AddCameraSceneNodeMaya();

	CameraSceneNode^ AddCameraSceneNodeWolvenKit();

	MeshSceneNode^ AddCubeSceneNode(float size, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);
	MeshSceneNode^ AddCubeSceneNode(float size, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation);
	MeshSceneNode^ AddCubeSceneNode(float size, SceneNode^ parent, int id, Vector3Df^ position);
	MeshSceneNode^ AddCubeSceneNode(float size, SceneNode^ parent, int id);
	MeshSceneNode^ AddCubeSceneNode(float size, SceneNode^ parent);
	MeshSceneNode^ AddCubeSceneNode(float size);
	MeshSceneNode^ AddCubeSceneNode();

	DummyTransformationSceneNode^ AddDummyTransformationSceneNode(SceneNode^ parent, int id);
	DummyTransformationSceneNode^ AddDummyTransformationSceneNode(SceneNode^ parent);
	DummyTransformationSceneNode^ AddDummyTransformationSceneNode();

	SceneNode^ AddEmptySceneNode(SceneNode^ parent, int id);
	SceneNode^ AddEmptySceneNode(SceneNode^ parent);
	SceneNode^ AddEmptySceneNode();

	void AddExternalMeshLoader(MeshLoader^ externalLoader);
	void AddExternalSceneLoader(SceneLoader^ externalLoader);

	AnimatedMesh^ AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material, float hillHeight, Dimension2Df^ countHills, Dimension2Df^ textureRepeatCount);
	AnimatedMesh^ AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material, float hillHeight, Dimension2Df^ countHills);
	AnimatedMesh^ AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material, float hillHeight);
	AnimatedMesh^ AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material);
	AnimatedMesh^ AddHillPlaneMesh(String^ name, Dimension2Df^ tileSize, Dimension2Di^ tileCount);

	LightSceneNode^ AddLightSceneNode(SceneNode^ parent, Vector3Df^ position, Video::Colorf^ color, float radius, int id);
	LightSceneNode^ AddLightSceneNode(SceneNode^ parent, Vector3Df^ position, Video::Colorf^ color, float radius);
	LightSceneNode^ AddLightSceneNode(SceneNode^ parent, Vector3Df^ position, Video::Colorf^ color);
	LightSceneNode^ AddLightSceneNode(SceneNode^ parent, Vector3Df^ position);
	LightSceneNode^ AddLightSceneNode(SceneNode^ parent);
	LightSceneNode^ AddLightSceneNode();

	MeshSceneNode^ AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, bool alsoAddIfMeshIsNull);
	MeshSceneNode^ AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);
	MeshSceneNode^ AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation);
	MeshSceneNode^ AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id, Vector3Df^ position);
	MeshSceneNode^ AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent, int id);
	MeshSceneNode^ AddMeshSceneNode(Mesh^ mesh, SceneNode^ parent);
	MeshSceneNode^ AddMeshSceneNode(Mesh^ mesh);

	MeshSceneNode^ AddOctreeSceneNode(Mesh^ mesh, SceneNode^ parent, int id, int minimalPolysPerNode, bool alsoAddIfMeshPointerZero);
	MeshSceneNode^ AddOctreeSceneNode(Mesh^ mesh, SceneNode^ parent, int id, int minimalPolysPerNode);
	MeshSceneNode^ AddOctreeSceneNode(Mesh^ mesh, SceneNode^ parent, int id);
	MeshSceneNode^ AddOctreeSceneNode(Mesh^ mesh, SceneNode^ parent);
	MeshSceneNode^ AddOctreeSceneNode(Mesh^ mesh);

	ParticleSystemSceneNode^ AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);
	ParticleSystemSceneNode^ AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation);
	ParticleSystemSceneNode^ AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent, int id, Vector3Df^ position);
	ParticleSystemSceneNode^ AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent, int id);
	ParticleSystemSceneNode^ AddParticleSystemSceneNode(bool withDefaultEmitter, SceneNode^ parent);
	ParticleSystemSceneNode^ AddParticleSystemSceneNode(bool withDefaultEmitter);
	ParticleSystemSceneNode^ AddParticleSystemSceneNode();

	SceneNode^ AddSceneNode(String^ sceneNodeTypeName, SceneNode^ parent);
	SceneNode^ AddSceneNode(String^ sceneNodeTypeName);

	SceneNode^ AddSkyBoxSceneNode(Video::Texture^ topTexture, Video::Texture^ bottomTexture, Video::Texture^ leftTexture, Video::Texture^ rightTexture, Video::Texture^ frontTexture, Video::Texture^ backTexture, SceneNode^ parent, int id);
	SceneNode^ AddSkyBoxSceneNode(Video::Texture^ topTexture, Video::Texture^ bottomTexture, Video::Texture^ leftTexture, Video::Texture^ rightTexture, Video::Texture^ frontTexture, Video::Texture^ backTexture, SceneNode^ parent);
	SceneNode^ AddSkyBoxSceneNode(Video::Texture^ topTexture, Video::Texture^ bottomTexture, Video::Texture^ leftTexture, Video::Texture^ rightTexture, Video::Texture^ frontTexture, Video::Texture^ backTexture);
	SceneNode^ AddSkyBoxSceneNode(String^ topFile, String^ bottomFile, String^ leftFile, String^ rightFile, String^ frontFile, String^ backFile, SceneNode^ parent, int id);
	SceneNode^ AddSkyBoxSceneNode(String^ topFile, String^ bottomFile, String^ leftFile, String^ rightFile, String^ frontFile, String^ backFile, SceneNode^ parent);
	SceneNode^ AddSkyBoxSceneNode(String^ topFile, String^ bottomFile, String^ leftFile, String^ rightFile, String^ frontFile, String^ backFile);

	SceneNode^ AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage, float radius, SceneNode^ parent, int id);
	SceneNode^ AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage, float radius, SceneNode^ parent);
	SceneNode^ AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage, float radius);
	SceneNode^ AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes, float texturePercentage, float spherePercentage);
	SceneNode^ AddSkyDomeSceneNode(Video::Texture^ texture, int horiRes, int vertRes);
	SceneNode^ AddSkyDomeSceneNode(Video::Texture^ texture);

	AnimatedMesh^ AddSphereMesh(String^ name, float radius, int polyCountX, int polyCountY);
	AnimatedMesh^ AddSphereMesh(String^ name, float radius);
	AnimatedMesh^ AddSphereMesh(String^ name);

	MeshSceneNode^ AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);
	MeshSceneNode^ AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation);
	MeshSceneNode^ AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent, int id, Vector3Df^ position);
	MeshSceneNode^ AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent, int id);
	MeshSceneNode^ AddSphereSceneNode(float radius, int polyCount, SceneNode^ parent);
	MeshSceneNode^ AddSphereSceneNode(float radius, int polyCount);
	MeshSceneNode^ AddSphereSceneNode(float radius);
	MeshSceneNode^ AddSphereSceneNode();

	AnimatedMesh^ AddTerrainMesh(String^ meshname, Video::Image^ texture, Video::Image^ heightmap, Dimension2Df^ stretchSize, float maxHeight, Dimension2Di^ defaultVertexBlockSize);
	AnimatedMesh^ AddTerrainMesh(String^ meshname, Video::Image^ texture, Video::Image^ heightmap, Dimension2Df^ stretchSize, float maxHeight);
	AnimatedMesh^ AddTerrainMesh(String^ meshname, Video::Image^ texture, Video::Image^ heightmap, Dimension2Df^ stretchSize);
	AnimatedMesh^ AddTerrainMesh(String^ meshname, Video::Image^ texture, Video::Image^ heightmap);

	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize, int smoothFactor, bool addAlsoIfHeightmapEmpty);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize, int smoothFactor);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id, Vector3Df^ position);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent, int id);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName, SceneNode^ parent);
	TerrainSceneNode^ AddTerrainSceneNode(String^ heightMapFileName);

	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize, int smoothFactor, bool addAlsoIfHeightmapEmpty);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize, int smoothFactor);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD, TerrainPatchSize patchSize);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor, int maxLOD);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale, Video::Color^ vertexColor);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id, Vector3Df^ position);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent, int id);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile, SceneNode^ parent);
	TerrainSceneNode^ AddTerrainSceneNode(IO::ReadFile^ heightMapFile);

	TerrainSceneNodeWolvenKit^ AddTerrainSceneNodeWolvenKit(String^ heightMapFileName, SceneNode^ parent, int id, unsigned int dimension, float maxHeight, float minHeight, float tileSize, Vector3Df^ anchor);

	TextSceneNode^ AddTextSceneNode(GUI::GUIFont^ font, String^ text, Video::Color^ color, SceneNode^ parent, Vector3Df^ position, int id);
	TextSceneNode^ AddTextSceneNode(GUI::GUIFont^ font, String^ text, Video::Color^ color, SceneNode^ parent, Vector3Df^ position);
	TextSceneNode^ AddTextSceneNode(GUI::GUIFont^ font, String^ text, Video::Color^ color, SceneNode^ parent);
	TextSceneNode^ AddTextSceneNode(GUI::GUIFont^ font, String^ text, Video::Color^ color);
	TextSceneNode^ AddTextSceneNode(GUI::GUIFont^ font, String^ text);

	void AddToDeletionQueue(SceneNode^ node);

	AnimatedMesh^ AddVolumeLightMesh(String^ name, int subdivU, int subdivV, Video::Color^ footColor, Video::Color^ tailColor);
	AnimatedMesh^ AddVolumeLightMesh(String^ name, int subdivU, int subdivV, Video::Color^ footColor);
	AnimatedMesh^ AddVolumeLightMesh(String^ name, int subdivU, int subdivV);
	AnimatedMesh^ AddVolumeLightMesh(String^ name);

	VolumeLightSceneNode^ AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV, Video::Color^ foot, Video::Color^ tail, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);
	VolumeLightSceneNode^ AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV, Video::Color^ foot, Video::Color^ tail, Vector3Df^ position, Vector3Df^ rotation);
	VolumeLightSceneNode^ AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV, Video::Color^ foot, Video::Color^ tail, Vector3Df^ position);
	VolumeLightSceneNode^ AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV, Video::Color^ foot, Video::Color^ tail);
	VolumeLightSceneNode^ AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV, Video::Color^ foot);
	VolumeLightSceneNode^ AddVolumeLightSceneNode(SceneNode^ parent, int id, int subdivU, int subdivV);
	VolumeLightSceneNode^ AddVolumeLightSceneNode(SceneNode^ parent, int id);
	VolumeLightSceneNode^ AddVolumeLightSceneNode(SceneNode^ parent);
	VolumeLightSceneNode^ AddVolumeLightSceneNode();

	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation, Vector3Df^ scale);
	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent, int id, Vector3Df^ position, Vector3Df^ rotation);
	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent, int id, Vector3Df^ position);
	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent, int id);
	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength, SceneNode^ parent);
	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed, float waveLength);
	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight, float waveSpeed);
	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh, float waveHeight);
	SceneNode^ AddWaterSurfaceSceneNode(Mesh^ mesh);

	void Clear();

	CollisionResponseSceneNodeAnimator^ CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node, Vector3Df^ ellipsoidRadius, Vector3Df^ gravityPerSecond, Vector3Df^ ellipsoidTranslation, float slidingValue);
	CollisionResponseSceneNodeAnimator^ CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node, Vector3Df^ ellipsoidRadius, Vector3Df^ gravityPerSecond, Vector3Df^ ellipsoidTranslation);
	CollisionResponseSceneNodeAnimator^ CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node, Vector3Df^ ellipsoidRadius, Vector3Df^ gravityPerSecond);
	CollisionResponseSceneNodeAnimator^ CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node, Vector3Df^ ellipsoidRadius);
	CollisionResponseSceneNodeAnimator^ CreateCollisionResponseAnimator(TriangleSelector^ world, SceneNode^ node);

	SceneNodeAnimator^ CreateDeleteAnimator(float time);

	SceneNodeAnimator^ CreateFlyCircleAnimator(Vector3Df^ center, float radius, float speed, Vector3Df^ direction, float startPosition, float radiusEllipsoid);
	SceneNodeAnimator^ CreateFlyCircleAnimator(Vector3Df^ center, float radius, float speed, Vector3Df^ direction, float startPosition);
	SceneNodeAnimator^ CreateFlyCircleAnimator(Vector3Df^ center, float radius, float speed, Vector3Df^ direction);
	SceneNodeAnimator^ CreateFlyCircleAnimator(Vector3Df^ center, float radius, float speed);
	SceneNodeAnimator^ CreateFlyCircleAnimator(Vector3Df^ center, float radius);
	SceneNodeAnimator^ CreateFlyCircleAnimator(Vector3Df^ center);
	SceneNodeAnimator^ CreateFlyCircleAnimator();

	SceneNodeAnimator^ CreateFlyStraightAnimator(Vector3Df^ startPoint, Vector3Df^ endPoint, float timeForWay, bool loop, bool pingpong);
	SceneNodeAnimator^ CreateFlyStraightAnimator(Vector3Df^ startPoint, Vector3Df^ endPoint, float timeForWay, bool loop);
	SceneNodeAnimator^ CreateFlyStraightAnimator(Vector3Df^ startPoint, Vector3Df^ endPoint, float timeForWay);

	SceneNodeAnimator^ CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime, float speed, float tightness, bool loop, bool pingpong);
	SceneNodeAnimator^ CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime, float speed, float tightness, bool loop);
	SceneNodeAnimator^ CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime, float speed, float tightness);
	SceneNodeAnimator^ CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime, float speed);
	SceneNodeAnimator^ CreateFollowSplineAnimator(List<Vector3Df^>^ points, float startTime);
	SceneNodeAnimator^ CreateFollowSplineAnimator(List<Vector3Df^>^ points);
	
	MeshWriter^ CreateMeshWriter(MeshWriterType type);

	MetaTriangleSelector^ CreateMetaTriangleSelector();

	SceneManager^ CreateNewSceneManager(bool cloneContent);
	SceneManager^ CreateNewSceneManager();

	TriangleSelector^ CreateOctreeTriangleSelector(Mesh^ mesh, SceneNode^ node, int minimalPolysPerNode);
	TriangleSelector^ CreateOctreeTriangleSelector(Mesh^ mesh, SceneNode^ node);

	SceneNodeAnimator^ CreateRotationAnimator(Vector3Df^ rotationSpeed);

	SceneNodeAnimator^ CreateSceneNodeAnimator(String^ typeName, SceneNode^ targetNode);
	SceneNodeAnimator^ CreateSceneNodeAnimator(String^ typeName);

	SkinnedMesh^ CreateSkinnedMesh();

	TriangleSelector^ CreateTerrainTriangleSelector(TerrainSceneNode^ node, int lodLevel);
	TriangleSelector^ CreateTerrainTriangleSelector(TerrainSceneNode^ node);

	SceneNodeAnimator^ CreateTextureAnimator(List<Video::Texture^>^ textures, float timePerFrame, bool loop);
	SceneNodeAnimator^ CreateTextureAnimator(List<Video::Texture^>^ textures, float timePerFrame);

	TriangleSelector^ CreateTriangleSelector(AnimatedMeshSceneNode^ node);
	TriangleSelector^ CreateTriangleSelector(Mesh^ mesh, SceneNode^ node);
	TriangleSelector^ CreateTriangleSelectorFromBoundingBox(SceneNode^ node);

	void DrawAll();

	String^ GetAnimatorTypeName(SceneNodeAnimatorType type);

	AnimatedMesh^ GetMesh(String^ filename);
	AnimatedMesh^ GetMesh(IO::ReadFile^ file);

    Mesh^ GetStaticMesh(String^ filename);


	MeshLoader^ GetMeshLoader(int index);
	SceneLoader^ GetSceneLoader(int index);

	SceneNode^ GetSceneNodeFromID(int id, SceneNode^ start);
	SceneNode^ GetSceneNodeFromID(int id);
	SceneNode^ GetSceneNodeFromName(String^ name, SceneNode^ start);
	SceneNode^ GetSceneNodeFromName(String^ name);
	SceneNode^ GetSceneNodeFromType(SceneNodeType type, SceneNode^ start);
	SceneNode^ GetSceneNodeFromType(SceneNodeType type);
	List<SceneNode^>^ GetSceneNodesFromType(SceneNodeType type, SceneNode^ start);
	List<SceneNode^>^ GetSceneNodesFromType(SceneNodeType type);

	String^ GetSceneNodeTypeName(SceneNodeType type);

	bool IsCulled(SceneNode^ node);

	bool LoadScene(String^ filename, SceneNode^ node);
	bool LoadScene(String^ filename);
	bool LoadScene(IO::ReadFile^ file, SceneNode^ node);
	bool LoadScene(IO::ReadFile^ file);

	bool PostEvent(Event^ e);

	bool RegisterNodeForRendering(SceneNode^ node, SceneNodeRenderPass pass);
	bool RegisterNodeForRendering(SceneNode^ node);

	bool SaveScene(String^ filename, SceneNode^ node);
	bool SaveScene(String^ filename);
	bool SaveScene(IO::WriteFile^ file, SceneNode^ node);
	bool SaveScene(IO::WriteFile^ file);

	property CameraSceneNode^ ActiveCamera { CameraSceneNode^ get(); void set(CameraSceneNode^ value); }
	property Video::Colorf^ AmbientLight { Video::Colorf^ get(); void set(Video::Colorf^ value); }
	property IO::Attributes^ Attributes { IO::Attributes^ get(); }
	property IO::FileSystem^ FileSystem { IO::FileSystem^ get(); }
	property Scene::GeometryCreator^ GeometryCreator { Scene::GeometryCreator^ get(); }
	property GUI::GUIEnvironment^ GUIEnvironment { GUI::GUIEnvironment^ get(); }
	property Scene::MeshCache^ MeshCache { Scene::MeshCache^ get(); }
	property int MeshLoaderCount { int get(); }
	property Scene::MeshManipulator^ MeshManipulator { Scene::MeshManipulator^ get(); }
	property SceneNode^ RootNode { SceneNode^ get(); }
	property Scene::SceneCollisionManager^ SceneCollisionManager { Scene::SceneCollisionManager^ get(); }
	property int SceneLoaderCount { int get(); }
	property Scene::SceneNodeRenderPass SceneNodeRenderPass { Scene::SceneNodeRenderPass get(); }
	property Video::Color^ ShadowColor { Video::Color^ get(); void set(Video::Color^ value); }
	property Video::VideoDriver^ VideoDriver { Video::VideoDriver^ get(); }

internal:

	static SceneManager^ Wrap(scene::ISceneManager* ref);
	SceneManager(scene::ISceneManager* ref);

	scene::ISceneManager* m_SceneManager;
};

} // end namespace Scene
} // end namespace IrrlichtLime