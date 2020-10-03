#include "stdafx.h"
#include "AnimatedMesh.h"
#include "Mesh.h"
#include "MeshBuffer.h"
#include "MeshManipulator.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

MeshManipulator^ MeshManipulator::Wrap(scene::IMeshManipulator* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew MeshManipulator(ref);
}

MeshManipulator::MeshManipulator(scene::IMeshManipulator* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_MeshManipulator = ref;
}

AnimatedMesh^ MeshManipulator::CreateAnimatedMesh(Mesh^ mesh, AnimatedMeshType type)
{
	scene::IAnimatedMesh* m = m_MeshManipulator->createAnimatedMesh(
		LIME_SAFEREF(mesh, m_Mesh),
		(scene::E_ANIMATED_MESH_TYPE)type);

	return AnimatedMesh::Wrap(m);
}

AnimatedMesh^ MeshManipulator::CreateAnimatedMesh(Mesh^ mesh)
{
	scene::IAnimatedMesh* m = m_MeshManipulator->createAnimatedMesh(LIME_SAFEREF(mesh, m_Mesh));
	return AnimatedMesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateForsythOptimizedMesh(Mesh^ mesh)
{
	scene::IMesh* m = m_MeshManipulator->createForsythOptimizedMesh(LIME_SAFEREF(mesh, m_Mesh));
	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshCopy(Mesh^ mesh)
{
	scene::IMesh* m = m_MeshManipulator->createMeshCopy(LIME_SAFEREF(mesh, m_Mesh));
	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshUniquePrimitives(Mesh^ mesh)
{
	scene::IMesh* m = m_MeshManipulator->createMeshUniquePrimitives(LIME_SAFEREF(mesh, m_Mesh));
	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshWelded(Mesh^ mesh, float tolerance)
{
	scene::IMesh* m = m_MeshManipulator->createMeshWelded(LIME_SAFEREF(mesh, m_Mesh), tolerance);
	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshWelded(Mesh^ mesh)
{
	scene::IMesh* m = m_MeshManipulator->createMeshWelded(LIME_SAFEREF(mesh, m_Mesh));
	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshWith1TCoords(Mesh^ mesh)
{
	scene::IMesh* m = m_MeshManipulator->createMeshWith1TCoords(LIME_SAFEREF(mesh, m_Mesh));
	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshWith2TCoords(Mesh^ mesh)
{
	scene::IMesh* m = m_MeshManipulator->createMeshWith2TCoords(LIME_SAFEREF(mesh, m_Mesh));
	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshWithTangents(Mesh^ mesh, bool recalculateNormals, bool smooth, bool angleWeighted, bool recalculateTangents)
{
	scene::IMesh* m = m_MeshManipulator->createMeshWithTangents(
		LIME_SAFEREF(mesh, m_Mesh),
		recalculateNormals,
		smooth,
		angleWeighted,
		recalculateTangents);

	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshWithTangents(Mesh^ mesh, bool recalculateNormals, bool smooth, bool angleWeighted)
{
	scene::IMesh* m = m_MeshManipulator->createMeshWithTangents(
		LIME_SAFEREF(mesh, m_Mesh),
		recalculateNormals,
		smooth,
		angleWeighted);

	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshWithTangents(Mesh^ mesh, bool recalculateNormals, bool smooth)
{
	scene::IMesh* m = m_MeshManipulator->createMeshWithTangents(
		LIME_SAFEREF(mesh, m_Mesh),
		recalculateNormals,
		smooth);

	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshWithTangents(Mesh^ mesh, bool recalculateNormals)
{
	scene::IMesh* m = m_MeshManipulator->createMeshWithTangents(
		LIME_SAFEREF(mesh, m_Mesh),
		recalculateNormals);

	return Mesh::Wrap(m);
}

Mesh^ MeshManipulator::CreateMeshWithTangents(Mesh^ mesh)
{
	scene::IMesh* m = m_MeshManipulator->createMeshWithTangents(LIME_SAFEREF(mesh, m_Mesh));
	return Mesh::Wrap(m);
}

void MeshManipulator::FlipSurfaces(Mesh^ mesh)
{
	m_MeshManipulator->flipSurfaces(LIME_SAFEREF(mesh, m_Mesh));
}

int MeshManipulator::GetPolyCount(AnimatedMesh^ animatedMesh)
{
	return m_MeshManipulator->getPolyCount(LIME_SAFEREF(animatedMesh, m_AnimatedMesh));
}

int MeshManipulator::GetPolyCount(Mesh^ mesh)
{
	return m_MeshManipulator->getPolyCount(LIME_SAFEREF(mesh, m_Mesh));
}

void MeshManipulator::HeightmapOptimizeMesh(Mesh^ mesh, float tolerance)
{
	m_MeshManipulator->heightmapOptimizeMesh(
		LIME_SAFEREF(mesh, m_Mesh),
		tolerance);
}

void MeshManipulator::HeightmapOptimizeMesh(Mesh^ mesh)
{
	m_MeshManipulator->heightmapOptimizeMesh(
		LIME_SAFEREF(mesh, m_Mesh));
}

void MeshManipulator::HeightmapOptimizeMesh(MeshBuffer^ buffer, float tolerance)
{
	m_MeshManipulator->heightmapOptimizeMesh(
		LIME_SAFEREF(buffer, m_MeshBuffer),
		tolerance);
}

void MeshManipulator::HeightmapOptimizeMesh(MeshBuffer^ buffer)
{
	m_MeshManipulator->heightmapOptimizeMesh(
		LIME_SAFEREF(buffer, m_MeshBuffer));
}

void MeshManipulator::MakePlanarTextureMapping(Mesh^ mesh, float resolutionS, float resolutionT, unsigned __int8 axis, Vector3Df^ offset)
{
	LIME_ASSERT(offset != nullptr);
	LIME_ASSERT(axis <= 2); // The axis along which the texture is projected. The allowed values are 0 (X), 1(Y), and 2(Z).

	m_MeshManipulator->makePlanarTextureMapping(
		LIME_SAFEREF(mesh, m_Mesh),
		resolutionS,
		resolutionT,
		axis,
		*offset->m_NativeValue);
}

void MeshManipulator::MakePlanarTextureMapping(Mesh^ mesh, float resolution)
{
	m_MeshManipulator->makePlanarTextureMapping(LIME_SAFEREF(mesh, m_Mesh), resolution);
}

void MeshManipulator::MakePlanarTextureMapping(Mesh^ mesh)
{
	m_MeshManipulator->makePlanarTextureMapping(LIME_SAFEREF(mesh, m_Mesh));
}

void MeshManipulator::MakePlanarTextureMapping(MeshBuffer^ buffer, float resolutionS, float resolutionT, unsigned __int8 axis, Vector3Df^ offset)
{
	LIME_ASSERT(offset != nullptr);
	LIME_ASSERT(axis <= 2); // The axis along which the texture is projected. The allowed values are 0 (X), 1(Y), and 2(Z).

	m_MeshManipulator->makePlanarTextureMapping(
		LIME_SAFEREF(buffer, m_MeshBuffer),
		resolutionS,
		resolutionT,
		axis,
		*offset->m_NativeValue);
}

void MeshManipulator::MakePlanarTextureMapping(MeshBuffer^ buffer, float resolution)
{
	m_MeshManipulator->makePlanarTextureMapping(LIME_SAFEREF(buffer, m_MeshBuffer), resolution);
}

void MeshManipulator::MakePlanarTextureMapping(MeshBuffer^ buffer)
{
	m_MeshManipulator->makePlanarTextureMapping(LIME_SAFEREF(buffer, m_MeshBuffer));
}

void MeshManipulator::RecalculateNormals(MeshBuffer^ buffer, bool smooth, bool angleWeighted)
{
	m_MeshManipulator->recalculateNormals(LIME_SAFEREF(buffer, m_MeshBuffer), smooth, angleWeighted);
}

void MeshManipulator::RecalculateNormals(MeshBuffer^ buffer, bool smooth)
{
	m_MeshManipulator->recalculateNormals(LIME_SAFEREF(buffer, m_MeshBuffer), smooth);
}

void MeshManipulator::RecalculateNormals(MeshBuffer^ buffer)
{
	m_MeshManipulator->recalculateNormals(LIME_SAFEREF(buffer, m_MeshBuffer));
}

void MeshManipulator::RecalculateNormals(Mesh^ mesh, bool smooth, bool angleWeighted)
{
	m_MeshManipulator->recalculateNormals(LIME_SAFEREF(mesh, m_Mesh), smooth, angleWeighted);
}

void MeshManipulator::RecalculateNormals(Mesh^ mesh, bool smooth)
{
	m_MeshManipulator->recalculateNormals(LIME_SAFEREF(mesh, m_Mesh), smooth);
}

void MeshManipulator::RecalculateNormals(Mesh^ mesh)
{
	m_MeshManipulator->recalculateNormals(LIME_SAFEREF(mesh, m_Mesh));
}

void MeshManipulator::RecalculateTangents(Mesh^ mesh, bool recalculateNormals, bool smooth, bool angleWeighted)
{
	m_MeshManipulator->recalculateTangents(LIME_SAFEREF(mesh, m_Mesh), recalculateNormals, smooth, angleWeighted);
}

void MeshManipulator::RecalculateTangents(Mesh^ mesh, bool recalculateNormals, bool smooth)
{
	m_MeshManipulator->recalculateTangents(LIME_SAFEREF(mesh, m_Mesh), recalculateNormals, smooth);
}

void MeshManipulator::RecalculateTangents(Mesh^ mesh, bool recalculateNormals)
{
	m_MeshManipulator->recalculateTangents(LIME_SAFEREF(mesh, m_Mesh), recalculateNormals);
}

void MeshManipulator::RecalculateTangents(Mesh^ mesh)
{
	m_MeshManipulator->recalculateTangents(LIME_SAFEREF(mesh, m_Mesh));
}

void MeshManipulator::RecalculateTangents(MeshBuffer^ buffer, bool recalculateNormals, bool smooth, bool angleWeighted)
{
	m_MeshManipulator->recalculateTangents(LIME_SAFEREF(buffer, m_MeshBuffer), recalculateNormals, smooth, angleWeighted);
}

void MeshManipulator::RecalculateTangents(MeshBuffer^ buffer, bool recalculateNormals, bool smooth)
{
	m_MeshManipulator->recalculateTangents(LIME_SAFEREF(buffer, m_MeshBuffer), recalculateNormals, smooth);
}

void MeshManipulator::RecalculateTangents(MeshBuffer^ buffer, bool recalculateNormals)
{
	m_MeshManipulator->recalculateTangents(LIME_SAFEREF(buffer, m_MeshBuffer), recalculateNormals);
}

void MeshManipulator::RecalculateTangents(MeshBuffer^ buffer)
{
	m_MeshManipulator->recalculateTangents(LIME_SAFEREF(buffer, m_MeshBuffer));
}

void MeshManipulator::Scale(MeshBuffer^ buffer, Vector3Df^ factor)
{
	LIME_ASSERT(factor != nullptr);
	m_MeshManipulator->scale(LIME_SAFEREF(buffer, m_MeshBuffer), *factor->m_NativeValue);
}

void MeshManipulator::Scale(Mesh^ mesh, Vector3Df^ factor)
{
	LIME_ASSERT(factor != nullptr);
	m_MeshManipulator->scale(LIME_SAFEREF(mesh, m_Mesh), *factor->m_NativeValue);
}

void MeshManipulator::ScaleTCoords(MeshBuffer^ buffer, Vector2Df^ factor, int level)
{
	LIME_ASSERT(factor != nullptr);
	LIME_ASSERT(level >= 1);

	m_MeshManipulator->scaleTCoords(LIME_SAFEREF(buffer, m_MeshBuffer), *factor->m_NativeValue, level);
}

void MeshManipulator::ScaleTCoords(MeshBuffer^ buffer, Vector2Df^ factor)
{
	LIME_ASSERT(factor != nullptr);
	m_MeshManipulator->scaleTCoords(LIME_SAFEREF(buffer, m_MeshBuffer), *factor->m_NativeValue);
}

void MeshManipulator::ScaleTCoords(Mesh^ mesh, Vector2Df^ factor, int level)
{
	LIME_ASSERT(factor != nullptr);
	LIME_ASSERT(level >= 1);

	m_MeshManipulator->scaleTCoords(LIME_SAFEREF(mesh, m_Mesh), *factor->m_NativeValue, level);
}

void MeshManipulator::ScaleTCoords(Mesh^ mesh, Vector2Df^ factor)
{
	LIME_ASSERT(factor != nullptr);
	m_MeshManipulator->scaleTCoords(LIME_SAFEREF(mesh, m_Mesh), *factor->m_NativeValue);
}

void MeshManipulator::SetVertexColorAlpha(Mesh^ mesh, int alpha)
{
	LIME_ASSERT(alpha >= 0 && alpha <= 255);
	m_MeshManipulator->setVertexColorAlpha(LIME_SAFEREF(mesh, m_Mesh), alpha);
}

void MeshManipulator::SetVertexColorAlpha(MeshBuffer^ buffer, int alpha)
{
	LIME_ASSERT(alpha >= 0 && alpha <= 255);
	m_MeshManipulator->setVertexColorAlpha(LIME_SAFEREF(buffer, m_MeshBuffer), alpha);
}

void MeshManipulator::SetVertexColors(Mesh^ mesh, Video::Color^ color)
{
	LIME_ASSERT(color != nullptr);
	m_MeshManipulator->setVertexColors(LIME_SAFEREF(mesh, m_Mesh), *color->m_NativeValue);
}

void MeshManipulator::SetVertexColors(MeshBuffer^ buffer, Video::Color^ color)
{
	LIME_ASSERT(color != nullptr);
	m_MeshManipulator->setVertexColors(LIME_SAFEREF(buffer, m_MeshBuffer), *color->m_NativeValue);
}

void MeshManipulator::Transform(MeshBuffer^ buffer, Matrix^ m)
{
	LIME_ASSERT(m != nullptr);
	m_MeshManipulator->transform(LIME_SAFEREF(buffer, m_MeshBuffer), *m->m_NativeValue);
}

void MeshManipulator::Transform(Mesh^ mesh, Matrix^ m)
{
	LIME_ASSERT(m != nullptr);
	m_MeshManipulator->transform(LIME_SAFEREF(mesh, m_Mesh), *m->m_NativeValue);
}

} // end namespace Scene
} // end namespace IrrlichtLime