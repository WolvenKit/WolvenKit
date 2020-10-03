// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_OCTREE_SCENE_NODE_H_INCLUDED__
#define __I_OCTREE_SCENE_NODE_H_INCLUDED__

#include "IMeshSceneNode.h"

namespace irr
{
namespace scene
{

//! Settings if/how octree scene nodes are using hardware mesh-buffers
/** VBO = Vertex buffer object = meshbuffers bound on the graphic-card instead of uploaded each frame.
	It can not be generally said which mode is optimal for drawing as this depends
	on the scene. So you have to try and experiment for your meshes which one works best.
*/
enum EOCTREENODE_VBO
{
	//! No VBO's used. Vertices+indices send to graphic-card on each render.
	EOV_NO_VBO,

	//! VBO's used. Draw the complete meshbuffers if any polygon in it is visible.
	//! This allows VBO's for the meshbuffers to be completely static, but basically means
	//! the octree is not used as an octree (not it still does do all the octree calculations)
	//! Might work in very specific cases, but if this is gives you the best fastest results
	//! you should probably compare as well to simply using a static mesh with no octree at all.
	//! In most cases the other 2 options should work better with an octree.
	EOV_USE_VBO,

	//! VBO's used. The index-buffer information is updated each frame
	//! with only the visible parts of a tree-node.
	//! So the vertex-buffer is static and the index-buffer is dynamic.
	//! This is the default
	EOV_USE_VBO_WITH_VISIBITLY
};

//! Kind of checks polygons of the octree scene nodes use against camera
enum EOCTREE_POLYGON_CHECKS
{
	//! Check against box of the camera frustum
	//! This is the default
	EOPC_BOX,

	//! against the camera frustum
	EOPC_FRUSTUM

};

//! A scene node displaying a static mesh
class IOctreeSceneNode : public irr::scene::IMeshSceneNode
{
public:

	//! Constructor
	/** Use setMesh() to set the mesh to display.
	*/
	IOctreeSceneNode(ISceneNode* parent, ISceneManager* mgr, s32 id,
			const core::vector3df& position = core::vector3df(0,0,0),
			const core::vector3df& rotation = core::vector3df(0,0,0),
			const core::vector3df& scale = core::vector3df(1,1,1))
		: IMeshSceneNode(parent, mgr, id, position, rotation, scale) {}

	//! Set if/how vertex buffer object are used for the meshbuffers
	/** NOTE: When there is already a mesh in the node this will rebuild
	the octree. */
	virtual void setUseVBO(EOCTREENODE_VBO useVBO) = 0;

	//! Get if/how vertex buffer object are used for the meshbuffers
	virtual EOCTREENODE_VBO getUseVBO() const = 0;

	//! Set the kind of tests polygons do for visibility against the camera
	virtual void setPolygonChecks(EOCTREE_POLYGON_CHECKS checks)  = 0;

	//! Get the kind of tests polygons do for visibility against the camera
	virtual EOCTREE_POLYGON_CHECKS getPolygonChecks() const = 0;
};

} // end namespace scene
} // end namespace irr


#endif

