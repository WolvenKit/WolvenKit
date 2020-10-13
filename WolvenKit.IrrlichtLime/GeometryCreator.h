#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video { ref class Image; ref class VideoDriver; }
namespace Scene {

ref class Mesh;

public ref class GeometryCreator : ReferenceCounted
{
public:

	Mesh^ CreateArrowMesh(int cylinderTesselation, int coneTesselation, float arrowHeight, float cylinderHeight, float cylinderWidth, float coneWidth, Video::Color^ cylinderColor, Video::Color^ coneColor);
	Mesh^ CreateArrowMesh(int cylinderTesselation, int coneTesselation, float arrowHeight, float cylinderHeight, float cylinderWidth, float coneWidth, Video::Color^ arrowColor);
	Mesh^ CreateArrowMesh(int cylinderTesselation, int coneTesselation, float arrowHeight, float cylinderHeight, float cylinderWidth, float coneWidth);
	Mesh^ CreateArrowMesh(int cylinderTesselation, int coneTesselation, float arrowHeight, float cylinderHeight);
	Mesh^ CreateArrowMesh(int cylinderTesselation, int coneTesselation);
	Mesh^ CreateArrowMesh();

	Mesh^ CreateConeMesh(float radius, float length, int tesselation, Video::Color^ topColor, Video::Color^ bottomColor, float oblique);
	Mesh^ CreateConeMesh(float radius, float length, int tesselation, Video::Color^ topColor, Video::Color^ bottomColor);
	Mesh^ CreateConeMesh(float radius, float length, int tesselation, Video::Color^ coneColor);
	Mesh^ CreateConeMesh(float radius, float length, int tesselation);

	Mesh^ CreateCubeMesh(Vector3Df^ size);
	Mesh^ CreateCubeMesh();

	Mesh^ CreateCylinderMesh(float radius, float length, int tesselation, Video::Color^ color, bool closeTop, float oblique);
	Mesh^ CreateCylinderMesh(float radius, float length, int tesselation, Video::Color^ color, bool closeTop);
	Mesh^ CreateCylinderMesh(float radius, float length, int tesselation, Video::Color^ color);
	Mesh^ CreateCylinderMesh(float radius, float length, int tesselation);

	Mesh^ CreateHillPlaneMesh(Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material, float hillHeight, Dimension2Df^ countHills, Dimension2Df^ textureRepeatCount);

	Mesh^ CreatePlaneMesh(Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material, Dimension2Df^ textureRepeatCount);
	Mesh^ CreatePlaneMesh(Dimension2Df^ tileSize, Dimension2Di^ tileCount, Video::Material^ material);
	Mesh^ CreatePlaneMesh(Dimension2Df^ tileSize, Dimension2Di^ tileCount);
	Mesh^ CreatePlaneMesh(Dimension2Df^ tileSize);

	Mesh^ CreateSphereMesh(float radius, int polyCountX, int polyCountY);
	Mesh^ CreateSphereMesh(float radius);
	Mesh^ CreateSphereMesh();

	Mesh^ CreateTerrainMesh(Video::Image^ texture, Video::Image^ heightmap, Dimension2Df^ stretchSize, float maxHeight, Video::VideoDriver^ driver, Dimension2Di^ defaultVertexBlockSize, bool debugBorders);
	Mesh^ CreateTerrainMesh(Video::Image^ texture, Video::Image^ heightmap, Dimension2Df^ stretchSize, float maxHeight, Video::VideoDriver^ driver, Dimension2Di^ defaultVertexBlockSize);

	Mesh^ CreateVolumeLightMesh(int subdivideU, int subdivideV, Video::Color^ footColor, Video::Color^ tailColor, float lightPointDistance, Vector3Df^ lightDimensions);
	Mesh^ CreateVolumeLightMesh(int subdivideU, int subdivideV, Video::Color^ footColor, Video::Color^ tailColor, float lightPointDistance);
	Mesh^ CreateVolumeLightMesh(int subdivideU, int subdivideV, Video::Color^ footColor, Video::Color^ tailColor);
	Mesh^ CreateVolumeLightMesh(int subdivideU, int subdivideV);
	Mesh^ CreateVolumeLightMesh();

internal:

	static GeometryCreator^ Wrap(scene::IGeometryCreator* ref);
	GeometryCreator(scene::IGeometryCreator* ref);

	scene::IGeometryCreator* m_GeometryCreator;
};

} // end namespace Scene
} // end namespace IrrlichtLime