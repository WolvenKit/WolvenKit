#include "StdAfx.h"
#include "SceneTile.h"

using std::logic_error;

SceneTile::SceneTile(const Point3i fromVoxelIndex, const Point3i toVoxelIndex)
{
	m_fromVoxelIndex = fromVoxelIndex;
	m_toVoxelIndex = toVoxelIndex;

}


SceneTile::~SceneTile(void)
{
}


void SceneTile::addCell(const shared_ptr<Cell> cell)
{

	m_cells.push_back(cell);

}

void SceneTile::setNumberOfSolidVoxelsInside(int numberOfSolidVoxels)
{
	if( numberOfSolidVoxels < 0 )
		throw new logic_error("Number of solid voxels cannot be negative");

	m_numberOfVoxels = numberOfSolidVoxels;

}

int SceneTile::getNumberOfVoxelsInside() const
{
	return (m_toVoxelIndex.x - m_fromVoxelIndex.x + 1) *  (m_toVoxelIndex.y - m_fromVoxelIndex.y + 1) *  (m_toVoxelIndex.z - m_fromVoxelIndex.z + 1);
}