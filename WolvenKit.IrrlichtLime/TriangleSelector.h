#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Scene {

ref class SceneNode;

public ref class TriangleSelector : ReferenceCounted
{
public:

	SceneNode^ GetSceneNodeForTriangle(int triangleIndex);

	TriangleSelector^ GetSelector(int selectorIndex);

	List<Triangle3Df^>^ GetTriangles(AABBox^ box, int maxTriangleCount, Matrix^ transform);
	List<Triangle3Df^>^ GetTriangles(AABBox^ box, int maxTriangleCount);
	List<Triangle3Df^>^ GetTriangles(Line3Df^ line, int maxTriangleCount, Matrix^ transform);
	List<Triangle3Df^>^ GetTriangles(Line3Df^ line, int maxTriangleCount);
	List<Triangle3Df^>^ GetTriangles(int maxTriangleCount, Matrix^ transform);
	List<Triangle3Df^>^ GetTriangles(int maxTriangleCount);

	property int SelectorCount { int get(); }
	property int TriangleCount { int get(); }

	virtual String^ ToString() override;

internal:

	static TriangleSelector^ Wrap(scene::ITriangleSelector* ref);
	TriangleSelector(scene::ITriangleSelector* ref);

	scene::ITriangleSelector* m_TriangleSelector;
};

} // end namespace Scene
} // end namespace IrrlichtLime