#include "StdAfx.h"
#include "VoxelContainer.h"

#include <queue>

using std::logic_error;
using std::queue;

VoxelContainer::VoxelContainer(const Vector3f voxelSize, int voxelCountX, int voxelCountY, int voxelCountZ )
{
	if( voxelSize.x <= 0.0f || voxelSize.y <= 0.0f || voxelSize.z <= 0.0f)
		throw new logic_error("Invalid voxel size.");

	if( voxelCountX <= 0 || voxelCountY <= 0  || voxelCountZ <= 0 )
		throw new logic_error("Invalid voxel count.");
	
	

	m_voxelSize = voxelSize;
	m_voxelCounts.x = voxelCountX;
	m_voxelCounts.y = voxelCountY;
	m_voxelCounts.z = voxelCountZ;

}

VoxelContainer::~VoxelContainer(void)
{

}

AABB VoxelContainer::getVoxelAABBFromIndex( const Point3i& voxelIndex, const AABB& worldBounds ) const
{
	if( isPositionOutOfBounds(voxelIndex) )
		throw logic_error("Voxel index out of bounds.");

	Vector3f fromPos, toPos;

	fromPos.x = voxelIndex.x * m_voxelSize.x + worldBounds.minPoint.x;
	fromPos.y = voxelIndex.y * m_voxelSize.y + worldBounds.minPoint.y;
	fromPos.z = voxelIndex.z * m_voxelSize.z + worldBounds.minPoint.z;

	toPos = fromPos + m_voxelSize;

	return AABB(fromPos, toPos);
}

Vector3f VoxelContainer::getVoxelPositionFromIndex( const Point3i& voxelIndex, const AABB& worldBounds) const
{
	if( isPositionOutOfBounds(voxelIndex) )
		throw logic_error("Voxel index out of bounds.");

	Vector3f min = Vector3f(voxelIndex.x * m_voxelSize.x + worldBounds.minPoint.x,
					 voxelIndex.y * m_voxelSize.y + worldBounds.minPoint.y,
					 voxelIndex.z * m_voxelSize.z + worldBounds.minPoint.z);
	min += Vector3f(m_voxelSize.x / 2, m_voxelSize.y / 2, m_voxelSize.z / 2);
	return min;
}


bool VoxelContainer::isPositionOutOfBounds(const Point3i& voxelPosition) const
{

	return (voxelPosition.x < 0 || voxelPosition.y < 0  || voxelPosition.z < 0 || voxelPosition.x >= m_voxelCounts.x || voxelPosition.y >= m_voxelCounts.y || voxelPosition.z >= m_voxelCounts.z);
}

Voxel VoxelContainer::voxelAt( const Point3i& voxelIndex ) const
{
	//Check valid index.
	if( isPositionOutOfBounds(voxelIndex) )
		throw new logic_error("Invalid voxel position.");

	//If exists voxel in that place, return it. Otherwise return empty Voxel.
	if( m_voxels.find(voxelIndex) != m_voxels.cend() )
		return Voxel(Voxel::SOLID);
	else
		return Voxel(Voxel::EMPTY);


}

Vector3f VoxelContainer::getVoxelSize() const
{
	return m_voxelSize;
}

Point3i VoxelContainer::getVoxelCounts() const
{
	return m_voxelCounts;
}

vector<AABB> VoxelContainer::getAllVoxelAABBFromVolume( const AABB& objectBounds, const AABB& worldBounds )
{
	
	Point3i fromVoxelPos, toVoxelPos;

	//Get the min and max voxel indices.
	fromVoxelPos = getVoxelIndexFromPoint(objectBounds.minPoint, worldBounds);
	toVoxelPos = getVoxelIndexFromPoint(objectBounds.maxPoint, worldBounds);

	vector<AABB> voxelsAABB;

	//Calculate the total voxels needed. Include the last voxel too.
	int totalVoxels = (toVoxelPos.x - fromVoxelPos.x + 1) *  (toVoxelPos.y - fromVoxelPos.y + 1) *  (toVoxelPos.z - fromVoxelPos.z + 1);
	voxelsAABB.reserve(totalVoxels);

	for( int z = fromVoxelPos.z ; z <= toVoxelPos.z; z++)
	{
		for( int y = fromVoxelPos.y ; y <= toVoxelPos.y; y++)
		{
			for( int x = fromVoxelPos.x ; x <= toVoxelPos.x; x++)
			{
				voxelsAABB.push_back(getVoxelAABBFromIndex( Point3i( x,y,z), worldBounds ));
			}
		}
	}

	return voxelsAABB;
}

Point3i VoxelContainer::getVoxelIndexFromPoint( const Vector3f& pointPosition, const AABB& worldBounds ) const
{

	Point3i voxelIndex;

	voxelIndex.x = static_cast<int>( (pointPosition.x - worldBounds.minPoint.x ) / m_voxelSize.x );
	voxelIndex.y = static_cast<int>( (pointPosition.y - worldBounds.minPoint.y )  / m_voxelSize.y );
	voxelIndex.z = static_cast<int>( (pointPosition.z - worldBounds.minPoint.z )  / m_voxelSize.z );

	//Check valid position.
	if( isPositionOutOfBounds(voxelIndex) )
		throw new logic_error("Point out of voxel container.");

	return voxelIndex;
}

void VoxelContainer::addVoxelAt( const Point3i& voxelIndex )
{

	//Check valid position.
	if( isPositionOutOfBounds(voxelIndex) )
		throw new logic_error("Invalid voxel index.");

	//add if not exists.
	if( m_voxels.find(voxelIndex) == m_voxels.cend() )
		m_voxels.insert(voxelIndex);
}

vector<Point3i> VoxelContainer::getAllSolidVoxels() const
{
	vector<Point3i> indices;

	if( m_voxels.empty() )
		return indices;

	for ( set<Point3i>::iterator it = m_voxels.begin(); it != m_voxels.end(); ++it )
	{
		indices.push_back( *it );
	}

	return indices;
}


unsigned int VoxelContainer::getAllSolidVoxelsCount() const
{
	return m_voxels.size();
}

unsigned int VoxelContainer::getTotalNumberOfVoxelsInContainer() const
{
	return m_voxelCounts.x * m_voxelCounts.y * m_voxelCounts.z;

}


vector<Vector3f> VoxelContainer::getAllSolidVoxelPositionsInWorldSpace(const AABB& worldBounds ) const
{
	
	vector<Vector3f> points;

	if( getAllSolidVoxelsCount() == 0 )
		return points;

	for ( set<Point3i>::iterator it = m_voxels.begin(); it != m_voxels.end(); ++it )
	{
		//Transform voxel index to position in world space.
		points.push_back( getVoxelPositionFromIndex( *it, worldBounds) );
	}

	return points;
}

void VoxelContainer::exploreNeighbourVoxel( const Point3i& currentVoxelIndex, const NEIGHBOUR_DIRECTION direction, set<Point3i>& exploredVoxels, queue<Point3i>& voxelQueue) const
{

	//Get near voxel depending on direction.
	Point3i neighbourPoint = getNeighbourVoxel(currentVoxelIndex, direction);

	//Check if it is a voxel within bounds.
	if( isPositionOutOfBounds(neighbourPoint) == false)
	{
		//Add to the queue to explore it later.
		if( exploredVoxels.find(neighbourPoint) == exploredVoxels.end())
		{
			exploredVoxels.insert(neighbourPoint);
			voxelQueue.push(neighbourPoint);
		}
	}
}

/*
void VoxelContainer::getNearEmptyVoxels( const Point3i& seedPoint, vector<Point3i>& emptyVoxelIndices) const
{
	//TODO: Maybe this is not voxel container responsability.


	//The queue that holds the voxels to explore.
	queue<Point3i> voxelQueue;

	//List of already explored voxels.
	set<Point3i> exploredVoxels;

	//Add the seed to the voxels queue.
	voxelQueue.push(seedPoint);
	exploredVoxels.insert(seedPoint);

	Point3i currentVoxelPoint;

	//Iterate while there is pending voxels to explore
	while( voxelQueue.empty() == false )
	{

		//Get last element of the queue.
		currentVoxelPoint = voxelQueue.front();

		//Remove last element from the queue.
		voxelQueue.pop();

		//If the current voxel is empty then add its neighbours to the queue.
		if(voxelAt(currentVoxelPoint).getStatus() == Voxel::EMPTY)
		{

			//Add the originating voxel point to the empty list.
			emptyVoxelIndices.push_back(currentVoxelPoint);

			//Explore its neighbour voxels.
			exploreNeighbourVoxel(currentVoxelPoint, POSITIVE_X, exploredVoxels, voxelQueue);
			exploreNeighbourVoxel(currentVoxelPoint, NEGATIVE_X, exploredVoxels, voxelQueue);

			exploreNeighbourVoxel(currentVoxelPoint, POSITIVE_Y, exploredVoxels, voxelQueue);
			exploreNeighbourVoxel(currentVoxelPoint, NEGATIVE_Y, exploredVoxels, voxelQueue);

			exploreNeighbourVoxel(currentVoxelPoint, POSITIVE_Z, exploredVoxels, voxelQueue);
			exploreNeighbourVoxel(currentVoxelPoint, NEGATIVE_Z, exploredVoxels, voxelQueue);

		}

	}
}
*/
Point3i VoxelContainer::getNeighbourVoxel( const Point3i& voxelIndex, const NEIGHBOUR_DIRECTION dir ) const
{
	//TODO: see if diagonal moves are needed too.
	Point3i newPos = voxelIndex;
	
	switch (dir)
	{
	case POSITIVE_X:
		newPos.x += 1;
		break;
	case NEGATIVE_X:
		newPos.x -= 1;
		break;
	case POSITIVE_Y:
		newPos.y += 1;
		break;
	case NEGATIVE_Y:
		newPos.y -= 1;
		break;
	case POSITIVE_Z:
		newPos.z += 1;
		break;
	case NEGATIVE_Z:
		newPos.z -= 1;
		break;
	}

	return newPos;
}

vector<Point3i> VoxelContainer::getAllVoxelPointsInRange( const Point3i& minIndex, const Point3i& maxIndex )const
{

	if( isPositionOutOfBounds(minIndex) || isPositionOutOfBounds(maxIndex)  )
		throw logic_error("Index out of bounds.");

	if( minIndex.x >  maxIndex.x || 
		minIndex.y >  maxIndex.y || 
		minIndex.z >  maxIndex.z )
		throw logic_error("Invalid Range");

	vector<Point3i> voxelsAABB;

	//Calculate the total voxels needed. Include the last voxel too.
	int totalVoxels = (maxIndex.x - minIndex.x + 1) *  (maxIndex.y - minIndex.y + 1) *  (maxIndex.z - minIndex.z + 1);
	voxelsAABB.reserve(totalVoxels);

	for( int z = minIndex.z ; z <= maxIndex.z; z++)
	{
		for( int y = minIndex.y ; y <= maxIndex.y; y++)
		{
			for( int x = minIndex.x ; x <= maxIndex.x; x++)
			{
				voxelsAABB.push_back(Point3i( x,y,z));
			}
		}
	}

	return voxelsAABB;
}


