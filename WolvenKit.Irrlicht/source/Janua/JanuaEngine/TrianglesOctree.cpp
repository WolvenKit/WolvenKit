#include "StdAfx.h"
#include "TrianglesOctree.h"


const Vector3f TrianglesOctree::NODE_COMBINATIONS[] = {
		Vector3f(-1, -1, -1),
		Vector3f(1, -1, -1),
		Vector3f(-1, -1, 1),
		Vector3f(1, -1, 1),
		Vector3f(-1, 1, -1),
		Vector3f(1, 1, -1),
		Vector3f(-1, 1, 1),
		Vector3f(1, 1, 1)
	};



TrianglesOctree::TrianglesOctree()
{
	
}


TrianglesOctree::~TrianglesOctree()
{
}

void TrianglesOctree::build(const Scene* scene, const AABB sceneAABB, const Vector3f voxelSize)
{
	this->rootNode = new OctreeNode();
	this->rootNode->aabb = sceneAABB;

	//Build triangle list from all the models
	vector<Triangle> sceneTriangles;
	for (int i = 0; i < scene->getModelInstancesCount(); i++)
	{
		const ModelInstance& modelInstance = scene->getModelInstance(i);

		//Transform the model space triangle to world space.
		vector<Triangle> meshTriangles;
		modelInstance.getModelTrianglesWorldSpace(meshTriangles);

		//Add all
		sceneTriangles.insert(sceneTriangles.end(), meshTriangles.begin(), meshTriangles.end());
	}
	
	//Build the tree
	buildRecursive(this->rootNode, sceneTriangles, voxelSize);
}



void TrianglesOctree::buildRecursive(OctreeNode* parentNode, vector<Triangle> &parentTriangles, const Vector3f voxelSize)
{
	Vector3f center = parentNode->aabb.getCenter();
	Vector3f extents = parentNode->aabb.getExtents();
	Vector3f size = parentNode->aabb.getSize();

	for(int i = 0; i < 8; i++)
	{
		Vector3f min = center + Vector3f(extents.x * NODE_COMBINATIONS[i].x, extents.y * NODE_COMBINATIONS[i].y, extents.z * NODE_COMBINATIONS[i].z);
		Vector3f max = min + extents;

		//Add node to parent
		OctreeNode* node = new OctreeNode();
		node->aabb = AABB(min, max);
		parentNode->children.push_back(node);

		//Find out triangles that collides with the AABB
		vector<Triangle> nodeTriangles;
		getTrianglesInAABB(parentTriangles, node->aabb, nodeTriangles);


		//Smaller than a voxel?
		if(size.x <= voxelSize.x || size.y <= voxelSize.y || size.z <= voxelSize.z)
		{
			//End recursion
			node->triangles = nodeTriangles;
		}
		else
		{
			//Recurse
			buildRecursive(node, nodeTriangles, voxelSize);
		}
	}
}


void TrianglesOctree::getTrianglesInAABB(vector<Triangle> &triangles, AABB aabb, vector<Triangle> &outTriangles)
{
	for(unsigned int i = 0; i < triangles.size(); i++)
	{
		//Test for intersection between the triangle and the AABB.
		if(testTriangleAABB(triangles[i], aabb))
		{
			outTriangles.push_back(triangles[i]);
		}
	}
}


bool TrianglesOctree::testTriangleAABB(const Triangle &t, const AABB &aabb) const
{
	float triverts[3][3];
	Vector3f center = aabb.getCenter();
	float boxCenter[] = {center.x, center.y, center.z};
	Vector3f extents = aabb.getExtents();
	float boxHalfSize[] = {extents.x, extents.y, extents.z};

	//Store the triangle in a format that the colission algorithm can receive.
	triverts[0][0] = t.a.x;
	triverts[0][1] = t.a.y;
	triverts[0][2] = t.a.z;

	triverts[1][0] = t.b.x;
	triverts[1][1] = t.b.y;
	triverts[1][2] = t.b.z;

	triverts[2][0] = t.c.x;
	triverts[2][1] = t.c.y;
	triverts[2][2] = t.c.z;

	//Test for intersection between the triangle and the AABB.
	if(CollisionUtils::triBoxOverlap(boxCenter, boxHalfSize, triverts) == 1)
	{
		return true;
	}

	return false;
}

void TrianglesOctree::detectSolidVoxels(VoxelContainer& voxelContainer, const AABB sceneAABB)
{
	//Iterate over all voxels of the scene
	vector<AABB> sceneVoxels = voxelContainer.getAllVoxelAABBFromVolume(sceneAABB, sceneAABB);
	for(unsigned int i = 0; i < sceneVoxels.size(); i++)
	{
		AABB voxelAABB = sceneVoxels[i];
		Vector3f voxelMidPoint = voxelAABB.getCenter();

		//Get leaf nodes of the octree that collide with the voxel
		vector<OctreeNode*> nodes;
		getLeafNodesForAABB(voxelAABB, nodes);
		bool collisionFound = false;
		for(unsigned int j = 0; j < nodes.size() && !collisionFound; j++)
		{
			//Check collision againts voxel triangles
			for(unsigned int t = 0; t < nodes[j]->triangles.size() && !collisionFound; t++)
			{
				if(testTriangleAABB(nodes[j]->triangles[t], voxelAABB))
				{
					//The Voxel is solid.
					voxelContainer.addVoxelAt(voxelContainer.getVoxelIndexFromPoint(voxelMidPoint, sceneAABB));
					collisionFound = true;
				}
			}
		}
	}
}

void TrianglesOctree::getLeafNodesForAABB(const AABB &aabb, vector<OctreeNode*> &nodes)
{
	getLeafNodesForAABBRecursive(aabb, this->rootNode, nodes);
}

void TrianglesOctree::getLeafNodesForAABBRecursive(const AABB &aabb, OctreeNode* node, vector<TrianglesOctree::OctreeNode*> &nodes)
{
	float aabbMin[3];
	float aabbMax[3];
	aabb.getExtremesArrays(aabbMin, aabbMax);

	//Leaf
	if(node->isLeaf())
	{
		nodes.push_back(node);
		return;
	}
	else
	{
		//Recurse
		for(unsigned int i = 0; i < node->children.size(); i++)
		{
			float childMin[3];
			float childMax[3];
			node->children[i]->aabb.getExtremesArrays(childMin, childMax);

			//AABB-AABB test
			if(CollisionUtils::boxBoxOverlapTest(aabbMin, aabbMax, childMin, childMax))
			{
				getLeafNodesForAABBRecursive(aabb, node->children[i], nodes);
			}
		}
	}
}

void TrianglesOctree::dispose()
{
	disposeRecursive(this->rootNode);
}

void TrianglesOctree::disposeRecursive(OctreeNode* node)
{
	if(node->isLeaf())
	{
		delete node;
	}
	else
	{
		for(unsigned int i = 0; i < node->children.size(); i++)
		{
			disposeRecursive(node->children[i]);
		}
		delete node;
	}
}