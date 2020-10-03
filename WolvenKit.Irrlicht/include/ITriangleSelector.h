// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_TRIANGLE_SELECTOR_H_INCLUDED__
#define __I_TRIANGLE_SELECTOR_H_INCLUDED__

#include "IReferenceCounted.h"
#include "triangle3d.h"
#include "aabbox3d.h"
#include "matrix4.h"
#include "line3d.h"
#include "irrArray.h"

namespace irr
{
namespace scene
{

class ISceneNode;
class ITriangleSelector;
class IMeshBuffer;

//! Additional information about the triangle arrays returned by ITriangleSelector::getTriangles
/** ITriangleSelector are free to fill out this information fully, partly or ignore it.
    Usually they will try to fill it when they can and set values to 0 otherwise.
*/
struct SCollisionTriangleRange
{
	SCollisionTriangleRange()
		: RangeStart(0), RangeSize(0)
		, Selector(0), SceneNode(0)
		, MeshBuffer(0), MaterialIndex(0)
	{}

	//! Check if this triangle index inside the range
	/**
	\param triangleIndex Index to an element inside the array of triangles returned by ITriangleSelector::getTriangles
	*/
	bool isIndexInRange(irr::u32 triangleIndex) const
	{
		return triangleIndex >= RangeStart && triangleIndex < RangeStart+RangeSize;
	}

	//! First index in the returned triangle array for which this struct is valid
	irr::u32 RangeStart;

	//! Number of elements in the returned triangle array for which this struct is valid (starting with RangeStart)
	irr::u32 RangeSize;

	//! Real selector which contained those triangles (useful when working with MetaTriangleSelector)
	ITriangleSelector* Selector;

	//! SceneNode from which the triangles are from
	ISceneNode* SceneNode;

	//! Meshbuffer from which the triangles are from
	//! Is 0 when the ITriangleSelector doesn't support meshbuffer selection
	const IMeshBuffer* MeshBuffer;

	//! Index of selected material in the SceneNode. Usually only valid when MeshBuffer is also set, otherwise always 0
	irr::u32 MaterialIndex;
};

//! Interface to return triangles with specific properties.
/** Every ISceneNode may have a triangle selector, available with
ISceneNode::getTriangleSelector() or ISceneManager::createTriangleSelector.
This is used for doing collision detection: For example if you know, that a
collision may have happened in the area between (1,1,1) and (10,10,10), you
can get all triangles of the scene node in this area with the
ITriangleSelector easily and check every triangle if it collided. */
class ITriangleSelector : public virtual IReferenceCounted
{
public:

	//! Get amount of all available triangles in this selector
	virtual s32 getTriangleCount() const = 0;

	//! Gets the triangles for one associated node.
	/**
	This returns all triangles for one scene node associated with this
	selector.  If there is more than one scene node associated (e.g. for
	an IMetaTriangleSelector) this this function may be called multiple
	times to retrieve all triangles.
	\param triangles Array where the resulting triangles will be
	written to.
	\param arraySize Size of the target array.
	\param outTriangleCount: Amount of triangles which have been written
	into the array.
	\param transform Pointer to matrix for transforming the triangles
	before they are returned. Useful for example to scale all triangles
	down into an ellipsoid space.
	\param useNodeTransform When the selector has a node then transform the
	triangles by that node's transformation matrix.
	\param outTriangleInfo When a pointer to an array is passed then that
	array is filled with additional information about the returned triangles.
	One element of SCollisionTriangleRange added for each range of triangles which
	has distinguishable information. For example one range per meshbuffer.
	*/
	virtual void getTriangles(core::triangle3df* triangles, s32 arraySize,
		s32& outTriangleCount, const core::matrix4* transform=0,
		bool useNodeTransform=true,
		irr::core::array<SCollisionTriangleRange>* outTriangleInfo=0) const = 0;

	//! Gets the triangles for one associated node which may lie within a specific bounding box.
	/**
	This returns all triangles for one scene node associated with this
	selector.  If there is more than one scene node associated (e.g. for
	an IMetaTriangleSelector) this this function may be called multiple
	times to retrieve all triangles.

	This method will return at least the triangles that intersect the box,
	but may return other triangles as well.
	\param triangles Array where the resulting triangles will be written
	to.
	\param arraySize Size of the target array.
	\param outTriangleCount Amount of triangles which have been written
	into the array.
	\param box Only triangles which are in this axis aligned bounding box
	will be written into the array.
	\param transform Pointer to matrix for transforming the triangles
	before they are returned. Useful for example to scale all triangles
	down into an ellipsoid space.
	\param useNodeTransform When the selector has a node then transform the
	triangles by that node's transformation matrix.
	\param outTriangleInfo When a pointer to an array is passed then that
	array is filled with additional information about the returned triangles.
	One element of SCollisionTriangleRange added for each range of triangles which
	has distinguishable information. For example one range per meshbuffer. */
	virtual void getTriangles(core::triangle3df* triangles, s32 arraySize,
		s32& outTriangleCount, const core::aabbox3d<f32>& box,
		const core::matrix4* transform=0, bool useNodeTransform=true,
		irr::core::array<SCollisionTriangleRange>* outTriangleInfo=0) const = 0;

	//! Gets the triangles for one associated node which have or may have contact with a 3d line.
	/**
	This returns all triangles for one scene node associated with this
	selector.  If there is more than one scene node associated (e.g. for
	an IMetaTriangleSelector) this this function may be called multiple
	times to retrieve all triangles.

	Please note that unoptimized triangle selectors also may return
	triangles which are not in contact at all with the 3d line.
	\param triangles Array where the resulting triangles will be written
	to.
	\param arraySize Size of the target array.
	\param outTriangleCount Amount of triangles which have been written
	into the array.
	\param line Only triangles which may be in contact with this 3d line
	will be written into the array.
	\param transform Pointer to matrix for transforming the triangles
	before they are returned. Useful for example to scale all triangles
	down into an ellipsoid space.
	\param useNodeTransform When the selector has a node then transform the
	triangles by that node's transformation matrix.
	\param outTriangleInfo When a pointer to an array is passed then that
	array is filled with additional information about the returned triangles.
	One element of SCollisionTriangleRange added for each range of triangles which
	has distinguishable information. For example one range per meshbuffer. */
	virtual void getTriangles(core::triangle3df* triangles, s32 arraySize,
		s32& outTriangleCount, const core::line3d<f32>& line,
		const core::matrix4* transform=0, bool useNodeTransform=true,
		irr::core::array<SCollisionTriangleRange>* outTriangleInfo=0) const = 0;

	//! Get number of TriangleSelectors that are part of this one
	/** Only useful for MetaTriangleSelector, others return 1
	*/
	virtual u32 getSelectorCount() const = 0;

	//! Get TriangleSelector based on index based on getSelectorCount
	/** Only useful for MetaTriangleSelector, others return 'this' or 0
	*/
	virtual ITriangleSelector* getSelector(u32 index) = 0;

	//! Get TriangleSelector based on index based on getSelectorCount
	/** Only useful for MetaTriangleSelector, others return 'this' or 0
	*/
	virtual const ITriangleSelector* getSelector(u32 index) const = 0;

	//! Get scene node associated with a given triangle.
	/**	With CMetaTriangleSelector-selectors it's possible to find out a node
	belonging to a certain triangle index.
	NOTE: triangleIndex has nothing to do with the order of triangles returned by getTriangles functions!
	So you can _not_ use this function to find out anything about to which node returned triangles belong.
	Use STriangleCollisionInfo struct for that.
	\param triangleIndex: the index of the triangle for which you want to find.
	\return The scene node associated with that triangle.
	*/
	virtual ISceneNode* getSceneNodeForTriangle(u32 triangleIndex) const = 0;
};

} // end namespace scene
} // end namespace irr

#endif
