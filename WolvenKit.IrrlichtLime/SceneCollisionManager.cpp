#include "stdafx.h"
#include "CameraSceneNode.h"
#include "SceneCollisionManager.h"
#include "SceneNode.h"
#include "TriangleSelector.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

SceneCollisionManager^ SceneCollisionManager::Wrap(scene::ISceneCollisionManager* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew SceneCollisionManager(ref);
}

SceneCollisionManager::SceneCollisionManager(scene::ISceneCollisionManager* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_SceneCollisionManager = ref;
}

bool SceneCollisionManager::GetCollisionPoint(Line3Df^ ray, TriangleSelector^ selector, [Out] Vector3Df^% collisionPoint,
	[Out] Triangle3Df^% collisionTriangle, [Out] SceneNode^% collisionNode)
{
	LIME_ASSERT(ray != nullptr);

	core::vector3df cp;
	core::triangle3df ct;
	scene::ISceneNode* cn;

	bool b = m_SceneCollisionManager->getCollisionPoint(
		*ray->m_NativeValue,
		LIME_SAFEREF(selector, m_TriangleSelector),
		cp, ct, cn);

	if (b)
	{
		collisionPoint = gcnew Vector3Df(cp);
		collisionTriangle = gcnew Triangle3Df(ct);
		collisionNode = SceneNode::Wrap(cn);
	}

	return b;
}

Vector3Df^ SceneCollisionManager::GetCollisionResultPosition(TriangleSelector^ selector, Vector3Df^ ellipsoidPosition, Vector3Df^ ellipsoidRadius,
	Vector3Df^ ellipsoidDirectionAndSpeed, [Out] Triangle3Df^% collisionTriangle, [Out] Vector3Df^% collisionPosition, [Out] bool% falling,
	[Out] SceneNode^% collisionNode, float slidingSpeed, Vector3Df^ gravityDirectionAndSpeed)
{
	LIME_ASSERT(ellipsoidPosition != nullptr);
	LIME_ASSERT(ellipsoidRadius != nullptr);
	LIME_ASSERT(ellipsoidDirectionAndSpeed != nullptr);
	LIME_ASSERT(gravityDirectionAndSpeed != nullptr);

	core::triangle3df ct;
	core::vector3df cp;
	bool f;
	scene::ISceneNode* cn;

	core::vector3df v = m_SceneCollisionManager->getCollisionResultPosition(
		LIME_SAFEREF(selector, m_TriangleSelector),
		*ellipsoidPosition->m_NativeValue,
		*ellipsoidRadius->m_NativeValue,
		*ellipsoidDirectionAndSpeed->m_NativeValue,
		ct, cp, f, cn,
		slidingSpeed,
		*gravityDirectionAndSpeed->m_NativeValue);

	collisionTriangle = gcnew Triangle3Df(ct);
	collisionPosition = gcnew Vector3Df(cp);
	falling = f;
	collisionNode = SceneNode::Wrap(cn);

	return gcnew Vector3Df(v);
}

Vector3Df^ SceneCollisionManager::GetCollisionResultPosition(TriangleSelector^ selector, Vector3Df^ ellipsoidPosition, Vector3Df^ ellipsoidRadius,
	Vector3Df^ ellipsoidDirectionAndSpeed, [Out] Triangle3Df^% collisionTriangle, [Out] Vector3Df^% collisionPosition, [Out] bool% falling,
	[Out] SceneNode^% collisionNode, float slidingSpeed)
{
	LIME_ASSERT(ellipsoidPosition != nullptr);
	LIME_ASSERT(ellipsoidRadius != nullptr);
	LIME_ASSERT(ellipsoidDirectionAndSpeed != nullptr);

	core::triangle3df ct;
	core::vector3df cp;
	bool f;
	scene::ISceneNode* cn;

	core::vector3df v = m_SceneCollisionManager->getCollisionResultPosition(
		LIME_SAFEREF(selector, m_TriangleSelector),
		*ellipsoidPosition->m_NativeValue,
		*ellipsoidRadius->m_NativeValue,
		*ellipsoidDirectionAndSpeed->m_NativeValue,
		ct, cp, f, cn,
		slidingSpeed);

	collisionTriangle = gcnew Triangle3Df(ct);
	collisionPosition = gcnew Vector3Df(cp);
	falling = f;
	collisionNode = SceneNode::Wrap(cn);

	return gcnew Vector3Df(v);
}

Vector3Df^ SceneCollisionManager::GetCollisionResultPosition(TriangleSelector^ selector, Vector3Df^ ellipsoidPosition, Vector3Df^ ellipsoidRadius,
	Vector3Df^ ellipsoidDirectionAndSpeed, [Out] Triangle3Df^% collisionTriangle, [Out] Vector3Df^% collisionPosition, [Out] bool% falling,
	[Out] SceneNode^% collisionNode)
{
	LIME_ASSERT(ellipsoidPosition != nullptr);
	LIME_ASSERT(ellipsoidRadius != nullptr);
	LIME_ASSERT(ellipsoidDirectionAndSpeed != nullptr);

	core::triangle3df ct;
	core::vector3df cp;
	bool f;
	scene::ISceneNode* cn;

	core::vector3df v = m_SceneCollisionManager->getCollisionResultPosition(
		LIME_SAFEREF(selector, m_TriangleSelector),
		*ellipsoidPosition->m_NativeValue,
		*ellipsoidRadius->m_NativeValue,
		*ellipsoidDirectionAndSpeed->m_NativeValue,
		ct, cp, f, cn);

	collisionTriangle = gcnew Triangle3Df(ct);
	collisionPosition = gcnew Vector3Df(cp);
	falling = f;
	collisionNode = SceneNode::Wrap(cn);

	return gcnew Vector3Df(v);
}

Line3Df^ SceneCollisionManager::GetRayFromScreenCoordinates(Vector2Di^ pos, CameraSceneNode^ camera)
{
	LIME_ASSERT(pos != nullptr);
	return gcnew Line3Df(m_SceneCollisionManager->getRayFromScreenCoordinates(*pos->m_NativeValue, LIME_SAFEREF(camera, m_CameraSceneNode)));
}

Line3Df^ SceneCollisionManager::GetRayFromScreenCoordinates(Vector2Di^ pos)
{
	LIME_ASSERT(pos != nullptr);
	return gcnew Line3Df(m_SceneCollisionManager->getRayFromScreenCoordinates(*pos->m_NativeValue));
}

SceneNode^ SceneCollisionManager::GetSceneNodeAndCollisionPointFromRay(Line3Df^ ray, [Out] Vector3Df^% collisionPoint,
	[Out] Triangle3Df^% collisionTriangle, int idBitMask, SceneNode^ collisionRootNode, bool noDebugObjects)
{
	LIME_ASSERT(ray != nullptr);

	core::vector3df cp;
	core::triangle3df ct;

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeAndCollisionPointFromRay(
		*ray->m_NativeValue,
		cp, ct,
		idBitMask,
		LIME_SAFEREF(collisionRootNode, m_SceneNode),
		noDebugObjects);

	collisionPoint = gcnew Vector3Df(cp);
	collisionTriangle = gcnew Triangle3Df(ct);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeAndCollisionPointFromRay(Line3Df^ ray, [Out] Vector3Df^% collisionPoint,
	[Out] Triangle3Df^% collisionTriangle, int idBitMask, SceneNode^ collisionRootNode)
{
	LIME_ASSERT(ray != nullptr);

	core::vector3df cp;
	core::triangle3df ct;

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeAndCollisionPointFromRay(
		*ray->m_NativeValue,
		cp, ct,
		idBitMask,
		LIME_SAFEREF(collisionRootNode, m_SceneNode));

	collisionPoint = gcnew Vector3Df(cp);
	collisionTriangle = gcnew Triangle3Df(ct);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeAndCollisionPointFromRay(Line3Df^ ray, [Out] Vector3Df^% collisionPoint,
	[Out] Triangle3Df^% collisionTriangle, int idBitMask)
{
	LIME_ASSERT(ray != nullptr);

	core::vector3df cp;
	core::triangle3df ct;

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeAndCollisionPointFromRay(
		*ray->m_NativeValue,
		cp, ct,
		idBitMask);

	collisionPoint = gcnew Vector3Df(cp);
	collisionTriangle = gcnew Triangle3Df(ct);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeAndCollisionPointFromRay(Line3Df^ ray, [Out] Vector3Df^% collisionPoint,
	[Out] Triangle3Df^% collisionTriangle)
{
	LIME_ASSERT(ray != nullptr);

	core::vector3df cp;
	core::triangle3df ct;

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeAndCollisionPointFromRay(
		*ray->m_NativeValue,
		cp, ct);

	collisionPoint = gcnew Vector3Df(cp);
	collisionTriangle = gcnew Triangle3Df(ct);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromCameraBB(CameraSceneNode^ camera, int idBitMask, bool noDebugObjects)
{
	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromCameraBB(
		LIME_SAFEREF(camera, m_CameraSceneNode),
		idBitMask,
		noDebugObjects);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromCameraBB(CameraSceneNode^ camera, int idBitMask)
{
	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromCameraBB(
		LIME_SAFEREF(camera, m_CameraSceneNode),
		idBitMask);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromCameraBB(CameraSceneNode^ camera)
{
	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromCameraBB(LIME_SAFEREF(camera, m_CameraSceneNode));
	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromRayBB(Line3Df^ ray, int idBitMask, SceneNode^ collisionRootNode, bool noDebugObjects)
{
	LIME_ASSERT(ray != nullptr);

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromRayBB(
		*ray->m_NativeValue,
		idBitMask,
		noDebugObjects,
		LIME_SAFEREF(collisionRootNode, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromRayBB(Line3Df^ ray, int idBitMask, SceneNode^ collisionRootNode)
{
	LIME_ASSERT(ray != nullptr);

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromRayBB(
		*ray->m_NativeValue,
		idBitMask,
		false,
		LIME_SAFEREF(collisionRootNode, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromRayBB(Line3Df^ ray, int idBitMask)
{
	LIME_ASSERT(ray != nullptr);

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromRayBB(
		*ray->m_NativeValue,
		idBitMask);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromRayBB(Line3Df^ ray)
{
	LIME_ASSERT(ray != nullptr);

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromRayBB(*ray->m_NativeValue);
	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromScreenCoordinatesBB(Vector2Di^ pos, int idBitMask, SceneNode^ collisionRootNode, bool noDebugObjects)
{
	LIME_ASSERT(pos != nullptr);

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromScreenCoordinatesBB(
		*pos->m_NativeValue,
		idBitMask,
		noDebugObjects,
		LIME_SAFEREF(collisionRootNode, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromScreenCoordinatesBB(Vector2Di^ pos, int idBitMask, SceneNode^ collisionRootNode)
{
	LIME_ASSERT(pos != nullptr);

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromScreenCoordinatesBB(
		*pos->m_NativeValue,
		idBitMask,
		false,
		LIME_SAFEREF(collisionRootNode, m_SceneNode));

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromScreenCoordinatesBB(Vector2Di^ pos, int idBitMask)
{
	LIME_ASSERT(pos != nullptr);

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromScreenCoordinatesBB(
		*pos->m_NativeValue,
		idBitMask);

	return SceneNode::Wrap(n);
}

SceneNode^ SceneCollisionManager::GetSceneNodeFromScreenCoordinatesBB(Vector2Di^ pos)
{
	LIME_ASSERT(pos != nullptr);

	scene::ISceneNode* n = m_SceneCollisionManager->getSceneNodeFromScreenCoordinatesBB(*pos->m_NativeValue);
	return SceneNode::Wrap(n);
}

Vector2Di^ SceneCollisionManager::GetScreenCoordinatesFrom3DPosition(Vector3Df^ pos, CameraSceneNode^ camera, bool useViewPort)
{
	LIME_ASSERT(pos != nullptr);

	return gcnew Vector2Di(
		m_SceneCollisionManager->getScreenCoordinatesFrom3DPosition(
			*pos->m_NativeValue, LIME_SAFEREF(camera, m_CameraSceneNode), useViewPort));
}

Vector2Di^ SceneCollisionManager::GetScreenCoordinatesFrom3DPosition(Vector3Df^ pos, CameraSceneNode^ camera)
{
	LIME_ASSERT(pos != nullptr);
	return gcnew Vector2Di(m_SceneCollisionManager->getScreenCoordinatesFrom3DPosition(*pos->m_NativeValue, LIME_SAFEREF(camera, m_CameraSceneNode)));
}

Vector2Di^ SceneCollisionManager::GetScreenCoordinatesFrom3DPosition(Vector3Df^ pos)
{
	LIME_ASSERT(pos != nullptr);
	return gcnew Vector2Di(m_SceneCollisionManager->getScreenCoordinatesFrom3DPosition(*pos->m_NativeValue));
}

} // end namespace Scene
} // end namespace IrrlichtLime