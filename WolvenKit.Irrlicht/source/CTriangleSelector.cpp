// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "CTriangleSelector.h"
#include "ISceneNode.h"
#include "IMeshBuffer.h"
#include "IAnimatedMeshSceneNode.h"
#include "SSkinMeshBuffer.h"

namespace irr
{
namespace scene
{

//! constructor
CTriangleSelector::CTriangleSelector(ISceneNode* node)
: SceneNode(node), MeshBuffer(0), MaterialIndex(0), AnimatedNode(0), LastMeshFrame(0)
{
	#ifdef _DEBUG
	setDebugName("CTriangleSelector");
	#endif

	BoundingBox.reset(0.f, 0.f, 0.f);
}


//! constructor
CTriangleSelector::CTriangleSelector(const core::aabbox3d<f32>& box, ISceneNode* node)
: SceneNode(node), MeshBuffer(0), MaterialIndex(0), AnimatedNode(0), LastMeshFrame(0)
{
	#ifdef _DEBUG
	setDebugName("CTriangleSelector");
	#endif

	BoundingBox=box;
	// TODO
}


//! constructor
CTriangleSelector::CTriangleSelector(const IMesh* mesh, ISceneNode* node, bool separateMeshbuffers)
: SceneNode(node), MeshBuffer(0), MaterialIndex(0), AnimatedNode(0), LastMeshFrame(0)
{
	#ifdef _DEBUG
	setDebugName("CTriangleSelector");
	#endif

	createFromMesh(mesh, separateMeshbuffers);
}

CTriangleSelector::CTriangleSelector(const IMeshBuffer* meshBuffer, irr::u32 materialIndex, ISceneNode* node)
	: SceneNode(node), MeshBuffer(meshBuffer), MaterialIndex(materialIndex), AnimatedNode(0), LastMeshFrame(0)
{
	#ifdef _DEBUG
	setDebugName("CTriangleSelector");
	#endif

	createFromMeshBuffer(meshBuffer);
}

CTriangleSelector::CTriangleSelector(IAnimatedMeshSceneNode* node, bool separateMeshbuffers)
: SceneNode(node), AnimatedNode(node), LastMeshFrame(0)
{
	#ifdef _DEBUG
	setDebugName("CTriangleSelector");
	#endif

	if (!AnimatedNode)
		return;

	IAnimatedMesh* animatedMesh = AnimatedNode->getMesh();
	if (!animatedMesh)
		return;

	LastMeshFrame = (u32)AnimatedNode->getFrameNr();
	IMesh* mesh = animatedMesh->getMesh(LastMeshFrame);

	if (mesh)
		createFromMesh(mesh, separateMeshbuffers);
}


void CTriangleSelector::createFromMesh(const IMesh* mesh, bool createBufferRanges)
{
	BufferRanges.clear();
	Triangles.clear();

	const u32 cnt = mesh->getMeshBufferCount();
	u32 totalFaceCount = 0;
	for (u32 j=0; j<cnt; ++j)
	{
		SCollisionTriangleRange range;
		range.MeshBuffer = mesh->getMeshBuffer(j);
		range.MaterialIndex = j;
		range.RangeSize = range.MeshBuffer->getIndexCount() / 3;

		if ( createBufferRanges )
		{
			range.RangeStart = totalFaceCount;

			BufferRanges.push_back(range);
		}

		totalFaceCount += range.RangeSize;
	}
	Triangles.set_used(totalFaceCount);

	updateFromMesh(mesh);
}

void CTriangleSelector::createFromMeshBuffer(const IMeshBuffer* meshBuffer)
{
	BufferRanges.clear();
	Triangles.clear();

	if ( meshBuffer )
	{
		Triangles.set_used(meshBuffer->getIndexCount() / 3);
	}

	updateFromMeshBuffer(meshBuffer);
}

template <typename TIndex>
static void updateTriangles(u32& triangleCount, core::array<core::triangle3df>& triangles, u32 idxCnt, const TIndex* indices, const u8* vertices, u32 vertexPitch, const core::matrix4* bufferTransform)
{
	if ( bufferTransform )
	{
		for (u32 index = 0; index < idxCnt; index += 3)
		{
			core::triangle3df& tri = triangles[triangleCount++];
			bufferTransform->transformVect( tri.pointA, (*reinterpret_cast<const video::S3DVertex*>(&vertices[indices[index + 0]*vertexPitch])).Pos );
			bufferTransform->transformVect( tri.pointB, (*reinterpret_cast<const video::S3DVertex*>(&vertices[indices[index + 1]*vertexPitch])).Pos );
			bufferTransform->transformVect( tri.pointC, (*reinterpret_cast<const video::S3DVertex*>(&vertices[indices[index + 2]*vertexPitch])).Pos );
		}
	}
	else
	{
		for (u32 index = 0; index < idxCnt; index += 3)
		{
			core::triangle3df& tri = triangles[triangleCount++];
			tri.pointA = (*reinterpret_cast<const video::S3DVertex*>(&vertices[indices[index + 0]*vertexPitch])).Pos;
			tri.pointB = (*reinterpret_cast<const video::S3DVertex*>(&vertices[indices[index + 1]*vertexPitch])).Pos;
			tri.pointC = (*reinterpret_cast<const video::S3DVertex*>(&vertices[indices[index + 2]*vertexPitch])).Pos;
		}
	}
}

void CTriangleSelector::updateFromMesh(const IMesh* mesh) const
{
	if (!mesh)
		return;

	bool skinnnedMesh = mesh->getMeshType() == EAMT_SKINNED;
	u32 meshBuffers = mesh->getMeshBufferCount();
	u32 triangleCount = 0;

	for (u32 i = 0; i < meshBuffers; ++i)
	{
		IMeshBuffer* buf = mesh->getMeshBuffer(i);
		u32 idxCnt = buf->getIndexCount();
		u32 vertexPitch = getVertexPitchFromType(buf->getVertexType());
		u8* vertices = (u8*)buf->getVertices();

		const core::matrix4* bufferTransform = 0;
		if ( skinnnedMesh )
		{
			bufferTransform = &(((scene::SSkinMeshBuffer*)buf)->Transformation);
			if ( bufferTransform->isIdentity() )
				bufferTransform = 0;
		}

		switch ( buf->getIndexType() )
		{
			case video::EIT_16BIT:
			{
				const u16* indices = buf->getIndices();
				updateTriangles(triangleCount, Triangles, idxCnt, indices, vertices, vertexPitch, bufferTransform);
			}
			break;
			case video::EIT_32BIT:
			{
				const u32* indices = (u32*)buf->getIndices();
				updateTriangles(triangleCount, Triangles, idxCnt, indices, vertices, vertexPitch, bufferTransform);
			}
			break;
		}
	}

	// Update bounding box
	updateBoundingBox();
}

void CTriangleSelector::updateFromMeshBuffer(const IMeshBuffer* meshBuffer) const
{
	if ( !meshBuffer )
		return;

	u32 idxCnt = meshBuffer->getIndexCount();
	u32 vertexPitch = getVertexPitchFromType(meshBuffer->getVertexType());
	u8* vertices = (u8*)meshBuffer->getVertices();
	u32 triangleCount = 0;
	switch ( meshBuffer->getIndexType() )
	{
		case video::EIT_16BIT:
		{
			const u16* indices = meshBuffer->getIndices();
			updateTriangles(triangleCount, Triangles, idxCnt, indices, vertices, vertexPitch, 0);
		}
		break;
		case video::EIT_32BIT:
		{
			const u32* indices = (u32*)meshBuffer->getIndices();
			updateTriangles(triangleCount, Triangles, idxCnt, indices, vertices, vertexPitch, 0);
		}
		break;
	}
}

void CTriangleSelector::updateBoundingBox() const
{
	if ( !Triangles.empty() )
	{
		BoundingBox.reset( Triangles[0].pointA );
		for (u32 i=0; i < Triangles.size(); ++i)
		{
			const core::triangle3df& tri = Triangles[i];
			BoundingBox.addInternalPoint(tri.pointA);
			BoundingBox.addInternalPoint(tri.pointB);
			BoundingBox.addInternalPoint(tri.pointC);
		}
	}
	else
	{
		BoundingBox.reset(0.f, 0.f, 0.f);
	}
}

void CTriangleSelector::update(void) const
{
	if (!AnimatedNode)
		return; //< harmless no-op

	const u32 currentFrame = (u32)AnimatedNode->getFrameNr();
	if (currentFrame == LastMeshFrame)
		return; //< Nothing to do

	LastMeshFrame = currentFrame;
	IAnimatedMesh * animatedMesh = AnimatedNode->getMesh();

	if (animatedMesh)
	{
		IMesh * mesh = animatedMesh->getMesh(LastMeshFrame);

		if (mesh)
			updateFromMesh(mesh);
	}
}


//! Gets all triangles.
void CTriangleSelector::getTriangles(core::triangle3df* triangles,
					s32 arraySize, s32& outTriangleCount,
					const core::matrix4* transform, bool useNodeTransform, 
					irr::core::array<SCollisionTriangleRange>* outTriangleInfo) const
{
	// Update my triangles if necessary
	update();

	u32 cnt = Triangles.size();
	if (cnt > (u32)arraySize)
		cnt = (u32)arraySize;

	core::matrix4 mat;
	if (transform)
		mat = *transform;
	if (SceneNode&&useNodeTransform)
		mat *= SceneNode->getAbsoluteTransformation();

	for (u32 i=0; i<cnt; ++i)
	{
		mat.transformVect( triangles[i].pointA, Triangles[i].pointA );
		mat.transformVect( triangles[i].pointB, Triangles[i].pointB );
		mat.transformVect( triangles[i].pointC, Triangles[i].pointC );
	}

	if ( outTriangleInfo )
	{
		if ( BufferRanges.empty() )
		{
			SCollisionTriangleRange triRange;

			triRange.RangeStart = 0;
			triRange.RangeSize = cnt;
			triRange.Selector = const_cast<CTriangleSelector*>(this);
			triRange.SceneNode = SceneNode;
			triRange.MeshBuffer = MeshBuffer;
			triRange.MaterialIndex = MaterialIndex;
			outTriangleInfo->push_back(triRange);
		}
		else
		{
			irr::u32 rangeIndex = 0;
			for (u32 i=0; i<cnt; )
			{
				while ( i >= (BufferRanges[rangeIndex].RangeStart + BufferRanges[rangeIndex].RangeSize) )
					++rangeIndex;

				SCollisionTriangleRange triRange;

				triRange.MaterialIndex = BufferRanges[rangeIndex].MaterialIndex;
				triRange.MeshBuffer = BufferRanges[rangeIndex].MeshBuffer;
				triRange.RangeStart = BufferRanges[rangeIndex].RangeStart;
				triRange.RangeSize = core::min_( cnt-BufferRanges[rangeIndex].RangeStart, BufferRanges[rangeIndex].RangeSize);
				triRange.Selector = const_cast<CTriangleSelector*>(this);
				triRange.SceneNode = SceneNode;
				outTriangleInfo->push_back(triRange);

				i += triRange.RangeSize;
			}
		}
	}

	outTriangleCount = cnt;
}


//! Gets all triangles which lie within a specific bounding box.
void CTriangleSelector::getTriangles(core::triangle3df* triangles,
					s32 arraySize, s32& outTriangleCount,
					const core::aabbox3d<f32>& box,
					const core::matrix4* transform, bool useNodeTransform, 
					irr::core::array<SCollisionTriangleRange>* outTriangleInfo) const
{
	// Update my triangles if necessary
	update();

	core::matrix4 mat(core::matrix4::EM4CONST_NOTHING);
	core::aabbox3df tBox(box);

	if (SceneNode && useNodeTransform)
	{
		if ( SceneNode->getAbsoluteTransformation().getInverse(mat) )
			mat.transformBoxEx(tBox);
		else
		{
			// TODO: else is not yet handled optimally. 
			// If a node has an axis scaled to 0 we return all triangles without any check
			return getTriangles(triangles, arraySize, outTriangleCount,
					transform, useNodeTransform, outTriangleInfo );
		}
	}
	if (transform)
		mat = *transform;
	else
		mat.makeIdentity();
	if (SceneNode && useNodeTransform)
		mat *= SceneNode->getAbsoluteTransformation();

	outTriangleCount = 0;

	if (!tBox.intersectsWithBox(BoundingBox))
		return;

	s32 triangleCount = 0;
	const u32 cnt = Triangles.size();

	if ( outTriangleInfo && !BufferRanges.empty() )
	{
		irr::u32 activeRange = 0;
		SCollisionTriangleRange triRange;
		triRange.Selector = const_cast<CTriangleSelector*>(this);
		triRange.SceneNode = SceneNode;
		triRange.RangeStart = triangleCount;
		triRange.MeshBuffer = BufferRanges[activeRange].MeshBuffer;
		triRange.MaterialIndex = BufferRanges[activeRange].MaterialIndex;

		for (u32 i=0; i<cnt; ++i)
		{
			// This isn't an accurate test, but it's fast, and the
			// API contract doesn't guarantee complete accuracy.
			if (Triangles[i].isTotalOutsideBox(tBox))
			   continue;

			if ( i >= BufferRanges[activeRange].RangeStart + BufferRanges[activeRange].RangeSize )
			{
				triRange.RangeSize = triangleCount-triRange.RangeStart;
				if ( triRange.RangeSize > 0 )
					outTriangleInfo->push_back(triRange);

				++activeRange;
				triRange.RangeStart = triangleCount;
				triRange.MeshBuffer = BufferRanges[activeRange].MeshBuffer;
				triRange.MaterialIndex = BufferRanges[activeRange].MaterialIndex;
			}

			triangles[triangleCount] = Triangles[i];
			mat.transformVect(triangles[triangleCount].pointA);
			mat.transformVect(triangles[triangleCount].pointB);
			mat.transformVect(triangles[triangleCount].pointC);

			++triangleCount;

			if (triangleCount == arraySize)
				break;
		}
		triRange.RangeSize = triangleCount-triRange.RangeStart;
		if ( triRange.RangeSize > 0 )
			outTriangleInfo->push_back(triRange);
	}
	else
	{
		for (u32 i=0; i<cnt; ++i)
		{
			// This isn't an accurate test, but it's fast, and the
			// API contract doesn't guarantee complete accuracy.
			if (Triangles[i].isTotalOutsideBox(tBox))
			   continue;

			triangles[triangleCount] = Triangles[i];
			mat.transformVect(triangles[triangleCount].pointA);
			mat.transformVect(triangles[triangleCount].pointB);
			mat.transformVect(triangles[triangleCount].pointC);

			++triangleCount;

			if (triangleCount == arraySize)
				break;
		}

		if ( outTriangleInfo )
		{
			SCollisionTriangleRange triRange;
			triRange.RangeSize = triangleCount;
			triRange.Selector = const_cast<CTriangleSelector*>(this);
			triRange.SceneNode = SceneNode;
			triRange.MeshBuffer = MeshBuffer;
			triRange.MaterialIndex = MaterialIndex;
			outTriangleInfo->push_back(triRange);
		}
	}

	outTriangleCount = triangleCount;
}


//! Gets all triangles which have or may have contact with a 3d line.
void CTriangleSelector::getTriangles(core::triangle3df* triangles,
					s32 arraySize, s32& outTriangleCount,
					const core::line3d<f32>& line,
					const core::matrix4* transform, bool useNodeTransform, 
					irr::core::array<SCollisionTriangleRange>* outTriangleInfo) const
{
	// Update my triangles if necessary
	update();

	core::aabbox3d<f32> box(line.start);
	box.addInternalPoint(line.end);

	// TODO: Could be optimized for line a little bit more.
	getTriangles(triangles, arraySize, outTriangleCount,
				box, transform, useNodeTransform, outTriangleInfo);
}


//! Returns amount of all available triangles in this selector
s32 CTriangleSelector::getTriangleCount() const
{
	return Triangles.size();
}


/* Get the number of TriangleSelectors that are part of this one.
Only useful for MetaTriangleSelector others return 1
*/
u32 CTriangleSelector::getSelectorCount() const
{
	return 1;
}


/* Get the TriangleSelector based on index based on getSelectorCount.
Only useful for MetaTriangleSelector others return 'this' or 0
*/
ITriangleSelector* CTriangleSelector::getSelector(u32 index)
{
	if (index)
		return 0;
	else
		return this;
}


/* Get the TriangleSelector based on index based on getSelectorCount.
Only useful for MetaTriangleSelector others return 'this' or 0
*/
const ITriangleSelector* CTriangleSelector::getSelector(u32 index) const
{
	if (index)
		return 0;
	else
		return this;
}


} // end namespace scene
} // end namespace irr
