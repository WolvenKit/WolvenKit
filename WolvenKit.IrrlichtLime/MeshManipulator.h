#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ref class AnimatedMesh;
ref class Mesh;
ref class MeshBuffer;

public ref class MeshManipulator : ReferenceCounted
{
public:

	AnimatedMesh^ CreateAnimatedMesh(Mesh^ mesh, AnimatedMeshType type);
	AnimatedMesh^ CreateAnimatedMesh(Mesh^ mesh);

	Mesh^ CreateForsythOptimizedMesh(Mesh^ mesh);

	Mesh^ CreateMeshCopy(Mesh^ mesh);

	Mesh^ CreateMeshUniquePrimitives(Mesh^ mesh);

	Mesh^ CreateMeshWelded(Mesh^ mesh, float tolerance);
	Mesh^ CreateMeshWelded(Mesh^ mesh);

	Mesh^ CreateMeshWith1TCoords(Mesh^ mesh);

	Mesh^ CreateMeshWith2TCoords(Mesh^ mesh);

	Mesh^ CreateMeshWithTangents(Mesh^ mesh, bool recalculateNormals, bool smooth, bool angleWeighted, bool recalculateTangents);
	Mesh^ CreateMeshWithTangents(Mesh^ mesh, bool recalculateNormals, bool smooth, bool angleWeighted);
	Mesh^ CreateMeshWithTangents(Mesh^ mesh, bool recalculateNormals, bool smooth);
	Mesh^ CreateMeshWithTangents(Mesh^ mesh, bool recalculateNormals);
	Mesh^ CreateMeshWithTangents(Mesh^ mesh);

	void FlipSurfaces(Mesh^ mesh);

	int GetPolyCount(AnimatedMesh^ animatedMesh);
	int GetPolyCount(Mesh^ mesh);

	void HeightmapOptimizeMesh(Mesh^ mesh, float tolerance);
	void HeightmapOptimizeMesh(Mesh^ mesh);
	void HeightmapOptimizeMesh(MeshBuffer^ buffer, float tolerance);
	void HeightmapOptimizeMesh(MeshBuffer^ buffer);

	void MakePlanarTextureMapping(Mesh^ mesh, float resolutionS, float resolutionT, unsigned __int8 axis, Vector3Df^ offset);
	void MakePlanarTextureMapping(Mesh^ mesh, float resolution);
	void MakePlanarTextureMapping(Mesh^ mesh);
	void MakePlanarTextureMapping(MeshBuffer^ buffer, float resolutionS, float resolutionT, unsigned __int8 axis, Vector3Df^ offset);
	void MakePlanarTextureMapping(MeshBuffer^ buffer, float resolution);
	void MakePlanarTextureMapping(MeshBuffer^ buffer);

	void RecalculateNormals(MeshBuffer^ buffer, bool smooth, bool angleWeighted);
	void RecalculateNormals(MeshBuffer^ buffer, bool smooth);
	void RecalculateNormals(MeshBuffer^ buffer);
	void RecalculateNormals(Mesh^ mesh, bool smooth, bool angleWeighted);
	void RecalculateNormals(Mesh^ mesh, bool smooth);
	void RecalculateNormals(Mesh^ mesh);

	void RecalculateTangents(Mesh^ mesh, bool recalculateNormals, bool smooth, bool angleWeighted);
	void RecalculateTangents(Mesh^ mesh, bool recalculateNormals, bool smooth);
	void RecalculateTangents(Mesh^ mesh, bool recalculateNormals);
	void RecalculateTangents(Mesh^ mesh);

	void RecalculateTangents(MeshBuffer^ buffer, bool recalculateNormals, bool smooth, bool angleWeighted);
	void RecalculateTangents(MeshBuffer^ buffer, bool recalculateNormals, bool smooth);
	void RecalculateTangents(MeshBuffer^ buffer, bool recalculateNormals);
	void RecalculateTangents(MeshBuffer^ buffer);

	void Scale(MeshBuffer^ buffer, Vector3Df^ factor);
	void Scale(Mesh^ mesh, Vector3Df^ factor);

	void ScaleTCoords(MeshBuffer^ buffer, Vector2Df^ factor, int level);
	void ScaleTCoords(MeshBuffer^ buffer, Vector2Df^ factor);
	void ScaleTCoords(Mesh^ mesh, Vector2Df^ factor, int level);
	void ScaleTCoords(Mesh^ mesh, Vector2Df^ factor);

	void SetVertexColorAlpha(Mesh^ mesh, int alpha);
	void SetVertexColorAlpha(MeshBuffer^ buffer, int alpha);

	void SetVertexColors(Mesh^ mesh, Video::Color^ color);
	void SetVertexColors(MeshBuffer^ buffer, Video::Color^ color);

	void Transform(MeshBuffer^ buffer, Matrix^ m);
	void Transform(Mesh^ mesh, Matrix^ m);

internal:

	static MeshManipulator^ Wrap(scene::IMeshManipulator* ref);
	MeshManipulator(scene::IMeshManipulator* ref);

	scene::IMeshManipulator* m_MeshManipulator;
};

} // end namespace Scene
} // end namespace IrrlichtLime