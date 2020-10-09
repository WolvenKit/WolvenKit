#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ref class CameraSceneNode;
ref class SceneNode;
ref class TriangleSelector;

public ref class SceneCollisionManager : ReferenceCounted
{
public:

	bool GetCollisionPoint(Line3Df^ ray, TriangleSelector^ selector, [Out] Vector3Df^% collisionPoint, [Out] Triangle3Df^% collisionTriangle, [Out] SceneNode^% collisionNode);

	Vector3Df^ GetCollisionResultPosition(TriangleSelector^ selector, Vector3Df^ ellipsoidPosition, Vector3Df^ ellipsoidRadius, Vector3Df^ ellipsoidDirectionAndSpeed, [Out] Triangle3Df^% collisionTriangle, [Out] Vector3Df^% collisionPosition, [Out] bool% falling, [Out] SceneNode^% collisionNode, float slidingSpeed, Vector3Df^ gravityDirectionAndSpeed);
	Vector3Df^ GetCollisionResultPosition(TriangleSelector^ selector, Vector3Df^ ellipsoidPosition, Vector3Df^ ellipsoidRadius, Vector3Df^ ellipsoidDirectionAndSpeed, [Out] Triangle3Df^% collisionTriangle, [Out] Vector3Df^% collisionPosition, [Out] bool% falling, [Out] SceneNode^% collisionNode, float slidingSpeed);
	Vector3Df^ GetCollisionResultPosition(TriangleSelector^ selector, Vector3Df^ ellipsoidPosition, Vector3Df^ ellipsoidRadius, Vector3Df^ ellipsoidDirectionAndSpeed, [Out] Triangle3Df^% collisionTriangle, [Out] Vector3Df^% collisionPosition, [Out] bool% falling, [Out] SceneNode^% collisionNode);

	Line3Df^ GetRayFromScreenCoordinates(Vector2Di^ pos, CameraSceneNode^ camera);
	Line3Df^ GetRayFromScreenCoordinates(Vector2Di^ pos);

	SceneNode^ GetSceneNodeAndCollisionPointFromRay(Line3Df^ ray, [Out] Vector3Df^% collisionPoint, [Out] Triangle3Df^% collisionTriangle, int idBitMask, SceneNode^ collisionRootNode, bool noDebugObjects);
	SceneNode^ GetSceneNodeAndCollisionPointFromRay(Line3Df^ ray, [Out] Vector3Df^% collisionPoint, [Out] Triangle3Df^% collisionTriangle, int idBitMask, SceneNode^ collisionRootNode);
	SceneNode^ GetSceneNodeAndCollisionPointFromRay(Line3Df^ ray, [Out] Vector3Df^% collisionPoint, [Out] Triangle3Df^% collisionTriangle, int idBitMask);
	SceneNode^ GetSceneNodeAndCollisionPointFromRay(Line3Df^ ray, [Out] Vector3Df^% collisionPoint, [Out] Triangle3Df^% collisionTriangle);

	SceneNode^ GetSceneNodeFromCameraBB(CameraSceneNode^ camera, int idBitMask, bool noDebugObjects);
	SceneNode^ GetSceneNodeFromCameraBB(CameraSceneNode^ camera, int idBitMask);
	SceneNode^ GetSceneNodeFromCameraBB(CameraSceneNode^ camera);

	SceneNode^ GetSceneNodeFromRayBB(Line3Df^ ray, int idBitMask, SceneNode^ collisionRootNode, bool noDebugObjects);
	SceneNode^ GetSceneNodeFromRayBB(Line3Df^ ray, int idBitMask, SceneNode^ collisionRootNode);
	SceneNode^ GetSceneNodeFromRayBB(Line3Df^ ray, int idBitMask);
	SceneNode^ GetSceneNodeFromRayBB(Line3Df^ ray);

	SceneNode^ GetSceneNodeFromScreenCoordinatesBB(Vector2Di^ pos, int idBitMask, SceneNode^ collisionRootNode, bool noDebugObjects);
	SceneNode^ GetSceneNodeFromScreenCoordinatesBB(Vector2Di^ pos, int idBitMask, SceneNode^ collisionRootNode);
	SceneNode^ GetSceneNodeFromScreenCoordinatesBB(Vector2Di^ pos, int idBitMask);
	SceneNode^ GetSceneNodeFromScreenCoordinatesBB(Vector2Di^ pos);

	Vector2Di^ GetScreenCoordinatesFrom3DPosition(Vector3Df^ pos, CameraSceneNode^ camera, bool useViewPort);
	Vector2Di^ GetScreenCoordinatesFrom3DPosition(Vector3Df^ pos, CameraSceneNode^ camera);
	Vector2Di^ GetScreenCoordinatesFrom3DPosition(Vector3Df^ pos);

internal:

	static SceneCollisionManager^ Wrap(scene::ISceneCollisionManager* ref);
	SceneCollisionManager(scene::ISceneCollisionManager* ref);

	scene::ISceneCollisionManager* m_SceneCollisionManager;
};

} // end namespace Scene
} // end namespace IrrlichtLime