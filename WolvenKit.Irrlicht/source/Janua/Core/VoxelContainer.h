/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once
#include "AABB.h"
#include "Vector3f.h"
#include "Point3i.h"
#include "Voxel.h"

#include <vector>
#include <set>
#include <queue>

using std::vector;
using std::set;
using std::queue;

//Contains voxels inside a Axis aligned box.
//The container holds voxelCountX, voxelsCountY and VoxelsCountZ number of voxels of size voxelSize.
class VoxelContainer
{
public:

	enum NEIGHBOUR_DIRECTION
	{
		POSITIVE_X,
		NEGATIVE_X,
		POSITIVE_Y,
		NEGATIVE_Y,
		POSITIVE_Z,
		NEGATIVE_Z
	};
	
	VoxelContainer(const Vector3f voxelSize, int voxelCountX, int voxelCountY, int voxelCountZ );
	virtual ~VoxelContainer(void);

	//TODO: Change for something more optimized
	vector<AABB> getAllVoxelAABBFromVolume(const AABB& bounds, const AABB& worldBounds); 

	vector<Point3i> getAllVoxelPointsInRange( const Point3i& minPoint, const Point3i& maxPoint ) const;

	//Returns a voxel a at given position in the container.
	Voxel voxelAt(const Point3i& voxelPosition) const;

	//Adds a new solid voxel at a given position in the container.
	void addVoxelAt(const Point3i& voxelIndex);

	//Returns the AABB in world space from a given voxel postion.
	AABB getVoxelAABBFromIndex( const Point3i& voxelIndex, const AABB& worldBounds) const;  
	
	//Given a voxel index and the sceen bounds, returns the world space voxel center point.
	Vector3f getVoxelPositionFromIndex( const Point3i& voxelIndex, const AABB& worldBounds) const;  

	//Returns the voxel position inside a container from a 3d point in space.
	Point3i getVoxelIndexFromPoint(const Vector3f& pointPosition, const AABB& worldBounds) const;

	Vector3f getVoxelSize()const;  //Returns the size of the voxels.

	Point3i getVoxelCounts() const; //Returns the number of voxels in each dimension.

	unsigned int getTotalNumberOfVoxelsInContainer() const; //Returns the number of voxels that fit in this container, either solid or empty.

	//Returns the indices of all the solid voxels in the container.
	vector<Point3i> getAllSolidVoxels() const;

	//Returns the number of solid voxels in the container.
	unsigned int getAllSolidVoxelsCount() const;

	//Returns all the solid voxels centers in world space.
	vector<Vector3f> getAllSolidVoxelPositionsInWorldSpace(const AABB& worldBounds ) const;

	//void getNearEmptyVoxels(const Point3i& seedPoint, vector<Point3i>& emptyVoxelIndices ) const;
	
	bool isPositionOutOfBounds(const Point3i& voxelIndex) const; //Checks if a index is within voxel container bounds.
	
	Point3i findFirstEmptyVoxel();

private:

	Point3i m_voxelCounts; //The number of voxels in x, y and z.
	Vector3f m_voxelSize; //The size of the voxel in x, y and z.

	set<Point3i> m_voxels; //TODO: Replace with a hierarchical structure like SVO

	Point3i getNeighbourVoxel(const Point3i& voxelIndex, const NEIGHBOUR_DIRECTION dir) const;

	void exploreNeighbourVoxel( const Point3i& currentVoxelIndex, const NEIGHBOUR_DIRECTION direction, set<Point3i>& exploredVoxels, queue<Point3i>& voxelQueue) const;

	
};

