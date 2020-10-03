// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "COctreeTriangleSelector.h"
#include "ISceneNode.h"

#include "os.h"

namespace irr
{
namespace scene
{

//! constructor
COctreeTriangleSelector::COctreeTriangleSelector(const IMesh* mesh,
		ISceneNode* node, s32 minimalPolysPerNode)
	: CTriangleSelector(mesh, node, false)
	, Root(0), NodeCount(0)
	, MinimalPolysPerNode(minimalPolysPerNode)
{
	#ifdef _DEBUG
	setDebugName("COctreeTriangleSelector");
	#endif

	if (!Triangles.empty())
	{
		const u32 start = os::Timer::getRealTime();

		// create the triangle octree
		Root = new SOctreeNode();
		Root->Triangles = Triangles;
		constructOctree(Root);

		c8 tmp[256];
		sprintf(tmp, "Needed %ums to create OctreeTriangleSelector.(%d nodes, %u polys)",
			os::Timer::getRealTime() - start, NodeCount, Triangles.size());
		os::Printer::log(tmp, ELL_INFORMATION);
	}
}

COctreeTriangleSelector::COctreeTriangleSelector(const IMeshBuffer* meshBuffer, irr::u32 materialIndex, ISceneNode* node, s32 minimalPolysPerNode)
	: CTriangleSelector(meshBuffer, materialIndex, node)
	, Root(0), NodeCount(0)
	, MinimalPolysPerNode(minimalPolysPerNode)
{
	#ifdef _DEBUG
	setDebugName("COctreeTriangleSelector");
	#endif

	if (!Triangles.empty())
	{
		const u32 start = os::Timer::getRealTime();

		// create the triangle octree
		Root = new SOctreeNode();
		Root->Triangles = Triangles;
		constructOctree(Root);

		c8 tmp[256];
		sprintf(tmp, "Needed %ums to create OctreeTriangleSelector.(%d nodes, %u polys)",
			os::Timer::getRealTime() - start, NodeCount, Triangles.size());
		os::Printer::log(tmp, ELL_INFORMATION);
	}
}

//! destructor
COctreeTriangleSelector::~COctreeTriangleSelector()
{
	delete Root;
}


void COctreeTriangleSelector::constructOctree(SOctreeNode* node)
{
	++NodeCount;

	node->Box.reset(node->Triangles[0].pointA);

	// get bounding box
	const u32 cnt = node->Triangles.size();
	for (u32 i=0; i<cnt; ++i)
	{
		node->Box.addInternalPoint(node->Triangles[i].pointA);
		node->Box.addInternalPoint(node->Triangles[i].pointB);
		node->Box.addInternalPoint(node->Triangles[i].pointC);
	}

	// calculate children

	if (!node->Box.isEmpty() && (s32)node->Triangles.size() > MinimalPolysPerNode)
	{
		const core::vector3df& middle = node->Box.getCenter();
		core::vector3df edges[8];
		node->Box.getEdges(edges);

		core::aabbox3d<f32> box;
		core::array<core::triangle3df> keepTriangles(node->Triangles.size()); // reserving enough memory, so we don't get re-allocations per child

		for (s32 ch=0; ch<8; ++ch)
		{
			box.reset(middle);
			box.addInternalPoint(edges[ch]);
			node->Child[ch] = new SOctreeNode();

			for (s32 i=0; i<(s32)node->Triangles.size(); ++i)
			{
				if (node->Triangles[i].isTotalInsideBox(box))
				{
					node->Child[ch]->Triangles.push_back(node->Triangles[i]);
					//node->Triangles.erase(i);
					//--i;
				}
				else
				{
					keepTriangles.push_back(node->Triangles[i]);
				}
			}
			memcpy(node->Triangles.pointer(), keepTriangles.pointer(),
				sizeof(core::triangle3df)*keepTriangles.size());

			node->Triangles.set_used(keepTriangles.size());
			keepTriangles.set_used(0);
		}
		keepTriangles.clear();	// release memory early, for large meshes it can matter.
		node->Triangles.reallocate(node->Triangles.size(), true); // shrink memory to minimum necessary

		// Note: We use an extra loop to construct child-nodes instead of doing
		// that in above loop to avoid memory fragmentation which happens if
		// the code has to switch between allocating memory for this node and
		// the child nodes (thanks @Squarefox for noting this).
		for (s32 ch=0; ch<8; ++ch)
		{
			if (node->Child[ch]->Triangles.empty())
			{
				delete node->Child[ch];
				node->Child[ch] = 0;
			}
			else
				constructOctree(node->Child[ch]);
		}
	}
}


//! Gets all triangles which lie within a specific bounding box.
void COctreeTriangleSelector::getTriangles(core::triangle3df* triangles,
					s32 arraySize, s32& outTriangleCount,
					const core::aabbox3d<f32>& box,
					const core::matrix4* transform, bool useNodeTransform,
					irr::core::array<SCollisionTriangleRange>* outTriangleInfo) const
{
	core::matrix4 mat(core::matrix4::EM4CONST_NOTHING);
	core::aabbox3d<f32> invbox = box;

	if (SceneNode && useNodeTransform)
	{
		if ( SceneNode->getAbsoluteTransformation().getInverse(mat) )
			mat.transformBoxEx(invbox);
		else
			// TODO: case not handled well, we can only return all triangles
			return CTriangleSelector::getTriangles(triangles, arraySize, outTriangleCount, transform, useNodeTransform, outTriangleInfo);
	}

	if (transform)
		mat = *transform;
	else
		mat.makeIdentity();

	if (SceneNode && useNodeTransform)
		mat *= SceneNode->getAbsoluteTransformation();

	s32 trianglesWritten = 0;

	if (Root)
		getTrianglesFromOctree(Root, trianglesWritten,
			arraySize, invbox, &mat, triangles);

	if ( outTriangleInfo )
	{
		SCollisionTriangleRange triRange;
		triRange.RangeSize = trianglesWritten;
		triRange.Selector = const_cast<COctreeTriangleSelector*>(this);
		triRange.SceneNode = SceneNode;
		triRange.MeshBuffer = MeshBuffer;
		triRange.MaterialIndex = MaterialIndex;
		outTriangleInfo->push_back(triRange);
	}

	outTriangleCount = trianglesWritten;
}


void COctreeTriangleSelector::getTrianglesFromOctree(
		SOctreeNode* node, s32& trianglesWritten,
		s32 maximumSize, const core::aabbox3d<f32>& box,
		const core::matrix4* mat, core::triangle3df* triangles) const
{
	if (!box.intersectsWithBox(node->Box))
		return;

	const u32 cnt = node->Triangles.size();

	for (u32 i=0; i<cnt; ++i)
	{
		const core::triangle3df& srcTri = node->Triangles[i];
		// This isn't an accurate test, but it's fast, and the
		// API contract doesn't guarantee complete accuracy.
		if (srcTri.isTotalOutsideBox(box))
			continue;

		core::triangle3df& dstTri = triangles[trianglesWritten];
		mat->transformVect(dstTri.pointA, srcTri.pointA );
		mat->transformVect(dstTri.pointB, srcTri.pointB );
		mat->transformVect(dstTri.pointC, srcTri.pointC );
		++trianglesWritten;

		// Halt when the out array is full.
		if (trianglesWritten == maximumSize)
			return;
	}

	for (u32 i=0; i<8; ++i)
		if (node->Child[i])
			getTrianglesFromOctree(node->Child[i], trianglesWritten,
			maximumSize, box, mat, triangles);
}


//! Gets all triangles which have or may have contact with a 3d line.
// new version: from user Piraaate
void COctreeTriangleSelector::getTriangles(core::triangle3df* triangles, s32 arraySize,
		s32& outTriangleCount, const core::line3d<f32>& line,
		const core::matrix4* transform, bool useNodeTransform,
		irr::core::array<SCollisionTriangleRange>* outTriangleInfo) const
{
#if 0
	core::aabbox3d<f32> box(line.start);
	box.addInternalPoint(line.end);

	// TODO: Could be optimized for line a little bit more.
	COctreeTriangleSelector::getTriangles(triangles, arraySize, outTriangleCount,
		box, transform);
#else

	core::matrix4 mat ( core::matrix4::EM4CONST_NOTHING );

	core::vector3df vectStartInv ( line.start ), vectEndInv ( line.end );
	if (SceneNode && useNodeTransform)
	{
		mat = SceneNode->getAbsoluteTransformation();
		mat.makeInverse();
		mat.transformVect(vectStartInv, line.start);
		mat.transformVect(vectEndInv, line.end);
	}
	core::line3d<f32> invline(vectStartInv, vectEndInv);

	mat.makeIdentity();

	if (transform)
		mat = (*transform);

	if (SceneNode && useNodeTransform)
		mat *= SceneNode->getAbsoluteTransformation();

	s32 trianglesWritten = 0;

	if (Root)
		getTrianglesFromOctree(Root, trianglesWritten, arraySize, invline, &mat, triangles);

	if ( outTriangleInfo )
	{
		SCollisionTriangleRange triRange;
		triRange.RangeSize = trianglesWritten;
		triRange.Selector = const_cast<COctreeTriangleSelector*>(this);
		triRange.SceneNode = SceneNode;
		triRange.MeshBuffer = MeshBuffer;
		triRange.MaterialIndex = MaterialIndex;
		outTriangleInfo->push_back(triRange);
	}

	outTriangleCount = trianglesWritten;
#endif
}

void COctreeTriangleSelector::getTrianglesFromOctree(SOctreeNode* node,
		s32& trianglesWritten, s32 maximumSize, const core::line3d<f32>& line,
		const core::matrix4* transform, core::triangle3df* triangles) const
{
	if (!node->Box.intersectsWithLine(line))
		return;

	s32 cnt = node->Triangles.size();
	if (cnt + trianglesWritten > maximumSize)
		cnt -= cnt + trianglesWritten - maximumSize;

	s32 i;

	if ( transform->isIdentity() )
	{
		for (i=0; i<cnt; ++i)
		{
			triangles[trianglesWritten] = node->Triangles[i];
			++trianglesWritten;
		}
	}
	else
	{
		for (i=0; i<cnt; ++i)
		{
			triangles[trianglesWritten] = node->Triangles[i];
			transform->transformVect(triangles[trianglesWritten].pointA);
			transform->transformVect(triangles[trianglesWritten].pointB);
			transform->transformVect(triangles[trianglesWritten].pointC);
			++trianglesWritten;
		}
	}

	for (i=0; i<8; ++i)
		if (node->Child[i])
			getTrianglesFromOctree(node->Child[i], trianglesWritten,
			maximumSize, line, transform, triangles);
}


} // end namespace scene
} // end namespace irr
