#include "StdAfx.h"
#include "PVSDatabaseImporter.h"
#include "..\JanuaRuntime\JanuaRuntime.h"


PVSDatabaseImporter::PVSDatabaseImporter(void)
{
}

shared_ptr<PVSDatabase> PVSDatabaseImporter::load(char* buffer)
{
	
	int buffIdx = 0;

	janua_lrb_format *fmt;

	fmt = (janua_lrb_format*)(buffer);

	assert( memcmp(fmt->header.magic, "LRB!", 4 ) == 0 );  //Check for magic number
	assert( fmt->header.version == 1 ); //Check version number


	buffIdx += sizeof(janua_lrb_format);

	const AABB sceneAABB = AABB( Vector3f( fmt->header.scene_min_point.x, fmt->header.scene_min_point.y, fmt->header.scene_min_point.z), 
								  Vector3f( fmt->header.scene_max_point.x, fmt->header.scene_max_point.y, fmt->header.scene_max_point.z) );

	const Vector3f voxelSize = Vector3f( fmt->header.voxel_size.x, fmt->header.voxel_size.y, fmt->header.voxel_size.z );

	vector<shared_ptr<Cell>> cells;

	for( unsigned int c = 0 ; c < fmt->cells.size / sizeof(janua_lrb_cell) ; ++c)
	{
		janua_lrb_cell* readCell;

		readCell = (janua_lrb_cell*)(buffer + buffIdx );


		shared_ptr<Cell> cell( new Cell( Point3i( readCell->min_pos.x,  readCell->min_pos.y,  readCell->min_pos.z),  
										 Point3i( readCell->max_pos.x,  readCell->max_pos.y,  readCell->max_pos.z) ));

		cells.push_back( cell );
		buffIdx +=  sizeof(janua_lrb_cell);
	}

	vector<shared_ptr<Portal>> portals;

	buffIdx = fmt->portals.offset;

	for( unsigned int c = 0 ; c < fmt->portals.size / sizeof(janua_lrb_portal) ; ++c)
	{
		janua_lrb_portal* readPortal;
		readPortal = (janua_lrb_portal*)(buffer + buffIdx );

		buffIdx +=  sizeof(janua_lrb_portal);

		assert( readPortal->from_cell >= 0 && readPortal->from_cell < cells.size() );
		assert( readPortal->to_cell >= 0 && readPortal->to_cell < cells.size() );

		Point3i minPoint( readPortal->min_point.x,  readPortal->min_point.y,  readPortal->min_point.z);
		Point3i maxPoint( readPortal->max_point.x,  readPortal->max_point.y,  readPortal->max_point.z);

		Point3i facingPlane( readPortal->normal_dir.x, readPortal->normal_dir.y,  readPortal->normal_dir.z);
		//TODO: Complete this!
		shared_ptr<Portal> portal( new Portal( cells[readPortal->from_cell], cells[readPortal->to_cell],  minPoint, maxPoint, facingPlane));

		cells[readPortal->from_cell]->addPortal(portal);
	}

	buffIdx = fmt->cell_pvs_list.offset;
	for( unsigned int c = 0 ; c < cells.size() ; ++c)
	{
		janua_lrb_cell_pvs_list* readCellId;
		readCellId = (janua_lrb_cell_pvs_list*)(buffer + buffIdx );

		UINT32 cellID;
		buffIdx += sizeof(UINT32);

		for(unsigned int i = 0 ; i < readCellId->num ; ++i )
		{
			cellID =  *((UINT32*) (buffer + buffIdx));

			assert( cellID >= 0 && cellID < cells.size() );

			//Add the visible cell to the cell's pvs.
			cells[c]->addVisibleCell( cells[cellID] );

			buffIdx += sizeof(UINT32);
		}
	}



	buffIdx = fmt->model_pvs_list.offset;
	for( unsigned int c = 0 ; c < cells.size() ; ++c)
	{
		janua_lrb_model_pvs_list* readModelId;
		readModelId = (janua_lrb_model_pvs_list*)(buffer + buffIdx );

		UINT32 modelID;
		buffIdx += sizeof(UINT32);

		for(unsigned int i = 0 ; i < readModelId->num ; ++i )
		{
			modelID = *((UINT32*) (buffer + buffIdx));

			assert(modelID >= 0);

			//Add the model to the cell
			cells[c]->addModelId( modelID );

			buffIdx += sizeof(UINT32);
		}
	}

	return shared_ptr<PVSDatabase>(   new PVSDatabase( cells, sceneAABB, voxelSize) );
}

PVSDatabaseImporter::~PVSDatabaseImporter(void)
{
}
