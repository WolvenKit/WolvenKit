/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once
#include "..\Core\Vector3f.h"
#include "..\Core\Triangle.h"
#include "..\Core\AABB.h"
#include "..\Core\CollisionUtils.h"
#include "..\Core\VoxelContainer.h"
#include "Scene.h"

#include <vector>
using std::vector;


/**
* An Octree that is built from all the models triangles
*/
class TrianglesOctree
{

public:

	/**
	* A node of the octree
	*/
	struct OctreeNode
	{
		AABB aabb;
		vector<OctreeNode*> children;
		vector<Triangle> triangles;

		bool isLeaf()
		{
			return children.size() == 0;
		}
	};



	TrianglesOctree();
	~TrianglesOctree();

	/**
	* Builds the octree
	*/
	void build(const Scene* scene, const AABB sceneAABB, const Vector3f voxelSize);

	/**
	* Check all the voxels of the scene and the solid ones to the voxelContainer.
	* It check collisions against the triangles octree
	*/
	void detectSolidVoxels(VoxelContainer& voxelContainer, const AABB sceneAABB);

	/**
	* Free resources
	*/
	void dispose();

private:

	void buildRecursive(OctreeNode* parentNode, vector<Triangle> &triangles, const Vector3f voxelSize);
	void getTrianglesInAABB(vector<Triangle> &triangles, AABB aabb, vector<Triangle> &outTriangles);
	bool testTriangleAABB(const Triangle &t, const AABB &aabb) const;
	void getLeafNodesForAABB(const AABB &aabb, vector<OctreeNode*> &nodes);
	void getLeafNodesForAABBRecursive(const AABB &aabb, OctreeNode* node, vector<OctreeNode*> &nodes);
	void disposeRecursive(OctreeNode* node);

public:

	/**
	* Root node of the octree
	*/
	OctreeNode* rootNode;

private:

	static const Vector3f NODE_COMBINATIONS[];

};

