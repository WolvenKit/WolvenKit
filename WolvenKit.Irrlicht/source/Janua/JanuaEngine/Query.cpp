#include "StdAfx.h"
#include "Query.h"

using std::logic_error;

Query::Query(const PVSDatabase& pvsDatabase) : m_pvsDatabase(pvsDatabase)
{
}


const QueryResult Query::getPotentiallyVisibleObjectsFromRegion( const Vector3f position )
{
	//TODO: Optimize this.

	vector<shared_ptr<Cell>> cells;

	const Vector3f voxelSize = m_pvsDatabase.getVoxelSize();
	
	AABB sceneAABB = m_pvsDatabase.getSceneAABB();
	
	int cellIndex = -1;

	//For each existing cell.
	m_pvsDatabase.getAllCells(cells);
	for( unsigned int c = 0 ; c < cells.size() ; ++c)
	{

		Point3i minIndex = cells[c]->minPoint;
		Point3i maxIndex = cells[c]->maxPoint;

		AABB cellAABB( Vector3f (
								minIndex.x * voxelSize.x + sceneAABB.minPoint.x,
								minIndex.y * voxelSize.y + sceneAABB.minPoint.y,
								minIndex.z * voxelSize.z + sceneAABB.minPoint.z	),
					   Vector3f(
								maxIndex.x * voxelSize.x + sceneAABB.minPoint.x + voxelSize.x,
								maxIndex.y * voxelSize.y + sceneAABB.minPoint.y + voxelSize.y,
								maxIndex.z * voxelSize.z + sceneAABB.minPoint.z + voxelSize.z));

		//If position it is in the cell.
		if( position.x >= cellAABB.minPoint.x && position.x <= cellAABB.maxPoint.x &&
			position.y >= cellAABB.minPoint.y && position.y <= cellAABB.maxPoint.y &&
			position.z >= cellAABB.minPoint.z && position.z <= cellAABB.maxPoint.z )
		{
			cellIndex = c;
			break;
		}
	}

	vector<int> modelIds;
	
	if( cellIndex == -1 )
	{
		return QueryResult(modelIds);
	}
	else//If position was inside a cell.
	{
		vector<int> cellModelIds;
		
		const Cell& baseCell = *(cells[cellIndex]);
		baseCell.getModelsIds(cellModelIds);
		
		//Add the models of the base cell.
		modelIds.insert(modelIds.end(), cellModelIds.begin(), cellModelIds.end() )	;

		//Get the other visible cells from that particular cell.
		vector<shared_ptr<Cell>> pvsCells( baseCell.getVisibleCells() );

		//For each cell in the PVS
		for( unsigned int i = 0 ; i < pvsCells.size() ; i++)
		{
			cellModelIds.clear();

			//Add the models to the pvs
			pvsCells[i]->getModelsIds(cellModelIds);

			//insert the models.
			modelIds.insert(modelIds.end(), cellModelIds.begin(), cellModelIds.end() )	;

		}
	}
	
	//Sort and remove duplicates.
	std::sort( modelIds.begin(), modelIds.end() );
	modelIds.erase( unique( modelIds.begin(), modelIds.end() ), modelIds.end() );
	
	//Return visible set.
	return QueryResult(modelIds);
}

Query::~Query(void)
{
}
