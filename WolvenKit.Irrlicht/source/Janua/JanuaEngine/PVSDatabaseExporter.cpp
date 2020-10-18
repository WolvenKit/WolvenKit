#include "StdAfx.h"
#include "PVSDatabaseExporter.h"
#include "../JanuaRuntime/JanuaRuntime.h"
#include "Query.h"
#include "QueryResult.h"
#include <iostream>
#include <iomanip>
#include <string>
#include <sstream>


PVSDatabaseExporter::PVSDatabaseExporter(const PVSDatabase& pvsDatabase) : m_pvsDatabase(pvsDatabase)
{

}

unsigned int findCellIndex( const shared_ptr<Cell>& specificCell, const vector<shared_ptr<Cell>>& cells )
{
	for(unsigned int c = 0 ; c < cells.size() ; ++c)
	{
		if( cells[c] == specificCell)
			return c;
	}

	throw new std::logic_error("Cell not found");
}

//Returns the needed buffer size to store the PVS database.
int PVSDatabaseExporter::getBufferSize() const
{
	int allocatedSize;

	//Fill structures just to know the size it would require.
	save( (char*) nullptr, allocatedSize, false );

	return allocatedSize;
}

void PVSDatabaseExporter::saveToBuffer( char* buffer )
{
	int allocatedSize;
	save( buffer, allocatedSize, true );
}


void PVSDatabaseExporter::save( char* buffer, int& allocatedSize, bool saveToBufferEnabled ) const
{
	
	unsigned int buffIdx = 0; //The buffer index.
	std::ostringstream output;

	janua_lrb_format fmt;
	janua_lrb_header header;

	//Only fill these data if we are saving it to a buffer.
	if( saveToBufferEnabled )
	{
		//Fill Header
		header.magic[0] = 0x4C;
		header.magic[1] = 0x52;
		header.magic[2] = 0x42;
		header.magic[3] = 0x21;
	
		header.version = 1;

		header.voxel_size.x = m_pvsDatabase.getVoxelSize().x;
		header.voxel_size.y = m_pvsDatabase.getVoxelSize().y;
		header.voxel_size.z = m_pvsDatabase.getVoxelSize().z;

		header.scene_min_point.x = m_pvsDatabase.getSceneAABB().minPoint.x;
		header.scene_min_point.y = m_pvsDatabase.getSceneAABB().minPoint.y;
		header.scene_min_point.z = m_pvsDatabase.getSceneAABB().minPoint.z;

		header.scene_max_point.x = m_pvsDatabase.getSceneAABB().maxPoint.x;
		header.scene_max_point.y = m_pvsDatabase.getSceneAABB().maxPoint.y;
		header.scene_max_point.z = m_pvsDatabase.getSceneAABB().maxPoint.z;

		fmt.header = header;

	}

	//Advance pointer.
	buffIdx += sizeof(janua_lrb_format);

	//Create cells
	vector< shared_ptr<Cell> > cells;
	m_pvsDatabase.getAllCells( cells );

	vector<janua_lrb_cell> lrbCells( cells.size() );

	fmt.cells.offset = buffIdx;

	if( saveToBufferEnabled )
	{
		for(unsigned int c = 0 ; c < cells.size() ; ++c)
		{
		
			lrbCells[c].min_pos.x = cells[c]->minPoint.x;
			lrbCells[c].min_pos.y = cells[c]->minPoint.y;
			lrbCells[c].min_pos.z = cells[c]->minPoint.z;

			lrbCells[c].max_pos.x = cells[c]->maxPoint.x;
			lrbCells[c].max_pos.y = cells[c]->maxPoint.y;
			lrbCells[c].max_pos.z = cells[c]->maxPoint.z;

		}
	}

	fmt.cells.size =  sizeof(janua_lrb_cell) * cells.size();
	buffIdx += fmt.cells.size;
	
	
	vector< shared_ptr<Portal> > portals;
	m_pvsDatabase.getAllPortals(portals);
	vector<janua_lrb_portal> lrbPortals( portals.size() );
	
	fmt.portals.offset = buffIdx;

	if( saveToBufferEnabled ) 
	{
		for(unsigned int c = 0 ; c < portals.size() ; ++c)
		{
		
			lrbPortals[c].from_cell = findCellIndex( portals[c]->fromCell, cells);
			lrbPortals[c].to_cell = findCellIndex( portals[c]->toCell, cells);

			lrbPortals[c].min_point.x = portals[c]->minPoint.x;
			lrbPortals[c].min_point.y = portals[c]->minPoint.y;
			lrbPortals[c].min_point.z = portals[c]->minPoint.z;

			lrbPortals[c].max_point.x = portals[c]->maxPoint.x;
			lrbPortals[c].max_point.y = portals[c]->maxPoint.y;
			lrbPortals[c].max_point.z = portals[c]->maxPoint.z;

			lrbPortals[c].normal_dir.x = portals[c]->facingPlane.x;
			lrbPortals[c].normal_dir.y = portals[c]->facingPlane.y;
			lrbPortals[c].normal_dir.z = portals[c]->facingPlane.z;
		}
	}

	fmt.portals.size =  sizeof(janua_lrb_portal) * portals.size();
	buffIdx += fmt.portals.size;
	

	//Fill cell Visibility List.
	vector<janua_lrb_cell_pvs_list> lrbCellPvs( cells.size() );

	fmt.cell_pvs_list.size = 0;
	fmt.cell_pvs_list.offset = buffIdx;
	for(unsigned int c = 0 ; c < cells.size() ; ++c)
	{
		const vector<shared_ptr<Cell>>& visibleCells = cells[c]->getVisibleCells();


		lrbCellPvs[c].num = visibleCells.size();
		lrbCellPvs[c].visible_cell_ids = new unsigned int[visibleCells.size()];

		//Save the cell offset to the pvs list.
		lrbCells[c].cells_pvs_offset = buffIdx + fmt.cell_pvs_list.size;

		fmt.cell_pvs_list.size += sizeof(UINT32);
		fmt.cell_pvs_list.size += sizeof(UINT32) * visibleCells.size();

		for(unsigned int i = 0 ; i < visibleCells.size() ; ++i)
		{
			unsigned int cellId = findCellIndex( visibleCells[i], cells );
			lrbCellPvs[c].visible_cell_ids[i] = cellId;
		}
	}
	
	buffIdx += fmt.cell_pvs_list.size;
	

	//Fill cell models Visibility List.
	vector<janua_lrb_model_pvs_list> lrbModelPvs( cells.size() );
	
	fmt.model_pvs_list.size = 0;
	fmt.model_pvs_list.offset = buffIdx;
	for(unsigned int c = 0 ; c < cells.size() ; ++c)
	{
		const vector<shared_ptr<Cell>>& visibleCells = cells[c]->getVisibleCells();

		vector<int> visibleModelIds;

		cells[c]->getModelsIds(visibleModelIds);
			
		//Save the cell offset to the pvs list.
		lrbCells[c].cells_model_offset = buffIdx +  fmt.model_pvs_list.size;

		lrbModelPvs[c].num = visibleModelIds.size();
		lrbModelPvs[c].visible_model_ids = new unsigned int[visibleModelIds.size()];

		fmt.model_pvs_list.size += sizeof(UINT32);
		fmt.model_pvs_list.size += sizeof(UINT32) * visibleModelIds.size();

		for(unsigned int i = 0 ; i < visibleModelIds.size() ; ++i)
		{
			lrbModelPvs[c].visible_model_ids[i] = visibleModelIds[i];
		}
	}


	buffIdx += fmt.model_pvs_list.size;
	
	//Only save the buffer if needed
	if( saveToBufferEnabled )
	{
		memset( buffer, 0, buffIdx - 1);
	
		output.write( (char*)(&fmt), sizeof(janua_lrb_format) );

		output.write( (char*)(&(lrbCells[0])), fmt.cells.size );
		output.write( (char*)(&(lrbPortals[0])), fmt.portals.size );

		for(unsigned int c = 0 ; c < cells.size() ; ++c)
		{
			output.write( (char*)(&(lrbCellPvs[c]).num), sizeof(UINT32) );
			output.write( (char*)(lrbCellPvs[c].visible_cell_ids), sizeof(UINT32)* lrbCellPvs[c].num ); //Variable size of elements.
		}


		for(unsigned int c = 0 ; c < cells.size() ; ++c)
		{
			output.write( (char*)(&(lrbModelPvs[c]).num), sizeof(UINT32) );
			output.write( (char*)(lrbModelPvs[c].visible_model_ids), sizeof(UINT32)* lrbModelPvs[c].num ); //Variable size of elements.
		}


		output.flush();
		std::string tempStr = output.str();
		memcpy( buffer, tempStr.c_str(), tempStr.size() );
	
	}


	//Cleanup
	for(unsigned int c = 0 ; c < cells.size() ; ++c)
	{
		delete [] lrbCellPvs[c].visible_cell_ids;
		delete [] lrbModelPvs[c].visible_model_ids;
	}

	//Return buffer size.
	allocatedSize = buffIdx;
	
}

PVSDatabaseExporter::~PVSDatabaseExporter(void)
{
}
