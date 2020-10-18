#include "StdAfx.h"
#include "PVSDatabase.h"
#include "..\Core\VoxelContainer.h"
#include <memory>


PVSDatabase::PVSDatabase( vector<shared_ptr<Cell>> cells, const AABB sceneAABB, const Vector3f voxelSize )
	: m_cells(cells), m_sceneAABB(sceneAABB), m_voxelSize(voxelSize)
{

}

PVSDatabase::~PVSDatabase(void)
{
}

vector<shared_ptr<Cell>> PVSDatabase::getNeighbourCells(const Cell& cell)
{

	vector<shared_ptr<Cell>> neigbourCells;

	for(vector<shared_ptr<Portal>>::size_type c = 0 ; c < cell.getPortals().size(); ++c)
	{

		shared_ptr<Cell> p(cell.getPortals().at(c)->toCell);


		neigbourCells.push_back( p );
	}

	return neigbourCells;
}

void PVSDatabase::getAllCells(vector<shared_ptr<Cell>>& cells) const
{
	cells.insert(cells.end(),  m_cells.begin(), m_cells.end());
}


void PVSDatabase::getAllPortals(vector<shared_ptr<Portal>>& p_portals) const
{
	vector< shared_ptr<Portal> > portals;


	for( unsigned int c = 0 ; c < m_cells.size() ; c++ )
	{

		const vector< shared_ptr<Portal> >&  cellPortals = m_cells[c]->getPortals();

		portals.insert( portals.end(), cellPortals.begin(), cellPortals.end() );
	}

	//Erase duplicates
	std::sort( portals.begin(), portals.end() );
	portals.erase( std::unique( portals.begin(), portals.end() ), portals.end() );

	p_portals.insert( p_portals.end(), portals.begin(), portals.end() );
}