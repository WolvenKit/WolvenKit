#include "JanuaRuntime.h"

/*Fill the results when the position given was out of Janua's cells.*/
void janua_fill_result_invalid_location( janua_query_result* result )
{
	int c;

	result->model_ids_count = 0;

	for( c = 0 ; c < JANUA_MAX_QUERY_RESULT_MODELS ; c++ )
	{
		result->model_ids[c] = -1;
	}
}

void janua_release_engine( janua_handler* handler )
{
	if( handler == 0L )
		return ;

	handler->buffer = 0L;
}

int janua_handler_load_database( janua_handler* handler, char* buffer )
{
	if( handler == 0L )
		return JANUA_RETURN_CODE_INVALID_HANDLER;

	if( buffer == 0L )
		return JANUA_RETURN_CODE_INVALID_BUFFER;

	handler->buffer = buffer; 

	/*TODO: do db integrity checking here*/

	return JANUA_RETURN_CODE_OK;
}

/*Adds all the models that are in a given cell to the result list*/
void janua_add_models_ids_from_cell_number(janua_handler* handler, janua_lrb_format* fmt, unsigned int current_cell_index, janua_query_result* result, int* add_model_result)
{
	int buffer_pos;
	unsigned int c;
	int model_id;
	janua_lrb_model_pvs_list* current_model_pvs_list;
	janua_lrb_cell* current_cell;
	UINT32 *model_ids_bitvector;

	/*Get the Cell based on the cell Index.*/
	current_cell = (janua_lrb_cell*) (handler->buffer + fmt->cells.offset + current_cell_index * sizeof( janua_lrb_cell ) );

	/*Position the buffer position there*/
	buffer_pos = current_cell->cells_model_offset;

	/*Get the model PVS list.*/
	current_model_pvs_list = (janua_lrb_model_pvs_list*) (handler->buffer + buffer_pos );

	/*Save the current cell's model id's into result*/
	buffer_pos += sizeof(UINT32);

	model_ids_bitvector = handler->model_ids_bitvector;

	for( c = 0 ; c < current_model_pvs_list->num ; ++c )
	{
		model_id = *((UINT32*)(handler->buffer + buffer_pos));

		/*Check if the bit corresponding to the model is set.*/
		/*This check prevents adding the same model twice in the result list.*/
		if( (model_ids_bitvector[model_id / 32] & (1<<(model_id % 32)) ) == 0 )
		{
			/*Check if model id's are beyond limit of the result capacity*/
			if( result->model_ids_count == JANUA_MAX_QUERY_RESULT_MODELS )
			{
				*add_model_result =  JANUA_RETURN_CODE_OUT_OF_MEMORY;
				return;
			}
			
			/*The model was not present already, so add it to the result list.*/
			result->model_ids[result->model_ids_count] = model_id;
			++(result->model_ids_count);

			/*Set the model id bit to 1.*/
			model_ids_bitvector[ model_id / 32] |= 1 << (model_id % 32);
		}

		/*Point to the next model id number*/
		buffer_pos += sizeof(UINT32);
	}

	*add_model_result =  JANUA_RETURN_CODE_OK;
	return;
}

int janua_query_visibility_from_position( janua_handler* handler, const float pos_x, const float pos_y, const float pos_z, janua_query_result* result )
{
	unsigned int current_cell_index;
	unsigned int pvs_cell_index;
	unsigned int c;
	unsigned int buffer_pos;
	int add_model_result;
	char cell_found = 0;
	int voxel_index_x, voxel_index_y, voxel_index_z;
	janua_lrb_cell* current_cell;
	janua_lrb_format* fmt;
	janua_lrb_cell_pvs_list* current_cell_pvs_list = 0;
	
	if( handler == 0L )
		return JANUA_RETURN_CODE_INVALID_HANDLER;
	
	/*Get Cell index from position*/
	fmt = (janua_lrb_format*) handler->buffer;

	if( fmt->cells.size <= 0 )
		return JANUA_RETURN_CODE_INVALID_BUFFER;

	/*Check for invalid voxel size*/
	if( fmt->header.voxel_size.x == 0.0f || fmt->header.voxel_size.y == 0.0f || fmt->header.voxel_size.z == 0.0f)
		return JANUA_RETURN_CODE_INVALID_BUFFER;

	/*Check if position is out of bounds*/
	if( pos_x < fmt->header.scene_min_point.x || pos_x > fmt->header.scene_max_point.x ||
		pos_y < fmt->header.scene_min_point.y || pos_y > fmt->header.scene_max_point.y ||
		pos_z < fmt->header.scene_min_point.z || pos_z > fmt->header.scene_max_point.z )
	{
		janua_fill_result_invalid_location( result );

		return JANUA_RETURN_CODE_OUT_OF_SCENE_BOUNDS;
	}

	/*Transform position coordinates into voxel indices*/
	voxel_index_x = (unsigned int) ( (pos_x - fmt->header.scene_min_point.x) / fmt->header.voxel_size.x );
	voxel_index_y = (unsigned int) ( (pos_y - fmt->header.scene_min_point.y) / fmt->header.voxel_size.y );
	voxel_index_z = (unsigned int) ( (pos_z - fmt->header.scene_min_point.z) / fmt->header.voxel_size.z );

	buffer_pos = fmt->cells.offset;
	current_cell = 0L;

	/*Find the cell*/
	for( current_cell_index = 0 ; current_cell_index < fmt->cells.size / sizeof( janua_lrb_cell ) ; current_cell_index++ )
	{
		current_cell = (janua_lrb_cell*) (handler->buffer + buffer_pos);
		
		/*Check if the input point is contained there*/
		if( voxel_index_x >= current_cell->min_pos.x && voxel_index_x <= current_cell->max_pos.x &&
			voxel_index_y >= current_cell->min_pos.y && voxel_index_y <= current_cell->max_pos.y &&
			voxel_index_z >= current_cell->min_pos.z && voxel_index_z <= current_cell->max_pos.z )
		{
 			cell_found = 1;
			break; /*found the cell and it is in current_cell and current_cell_index*/
		}

		buffer_pos += sizeof( janua_lrb_cell );
	}

	/*No cell found*/
	if( cell_found != 1 )
	{
		janua_fill_result_invalid_location( result );

		return JANUA_RETURN_CODE_OK;
	}
	
	/*initialize the model ids bitvector*/
	for( c = 0 ; c < JANUA_MAX_NUMBER_OF_MODELS/32 ; ++c)
		handler->model_ids_bitvector[c] = 0;

	/*Initialize the result*/
	result->model_ids_count = 0;

	/*Add the models that are in the current cell*/
	janua_add_models_ids_from_cell_number( handler, fmt, current_cell_index, result, &add_model_result);

	/*Other unexpected result*/
	if( add_model_result != JANUA_RETURN_CODE_OK ) 
	{
		return add_model_result;
	}

	/*Get the other model Ids that are in the current cell's PVS list*/
	/*Get the cell's pvs list*/
	buffer_pos = current_cell->cells_pvs_offset; 
	current_cell_pvs_list = (janua_lrb_cell_pvs_list*) (handler->buffer +  current_cell->cells_pvs_offset);
	buffer_pos += sizeof(UINT32);


	/*Go for each visible cell and add their models into the result*/
	for( c = 0 ; c < current_cell_pvs_list->num ; c++ )
	{
		pvs_cell_index = *((UINT32*)( handler->buffer + buffer_pos));

		/*Add the models that are in the visible cell*/
		janua_add_models_ids_from_cell_number(handler, fmt, pvs_cell_index, result, &add_model_result);

		/*Other unexpected result*/
		if( add_model_result != JANUA_RETURN_CODE_OK ) 
		{
			return add_model_result;
		}

		buffer_pos += sizeof(UINT32);
	}
	
	/*Clear the ids of the rest of the array*/
	for( c = result->model_ids_count ; c < JANUA_MAX_QUERY_RESULT_MODELS ; c++ )
	{
		result->model_ids[c] = -1;
	}

	return JANUA_RETURN_CODE_OK;
}

/***************************** DEBUG ***************************************/
int janua_get_cells_data_from_position( janua_handler* handler, const float pos_x, const float pos_y, const float pos_z, janua_get_cells_data_result* result )
{
	unsigned int current_cell_index;
	unsigned int pvs_cell_index;
	unsigned int c;
	unsigned int buffer_pos;
	char cell_found = 0;
	int voxel_index_x, voxel_index_y, voxel_index_z;
	janua_lrb_cell* current_cell = 0;
	janua_lrb_format* fmt;
	janua_lrb_cell_pvs_list* current_cell_pvs_list = 0;
	
	if( handler == 0L )
		return JANUA_RETURN_CODE_INVALID_HANDLER;
	
	/*Get Cell index from position*/
	fmt = (janua_lrb_format*) handler->buffer;

	if( fmt->cells.size <= 0 )
		return JANUA_RETURN_CODE_INVALID_BUFFER;

	/*Check for invalid voxel size*/
	if( fmt->header.voxel_size.x == 0.0f || fmt->header.voxel_size.y == 0.0f || fmt->header.voxel_size.z == 0.0f)
		return JANUA_RETURN_CODE_INVALID_BUFFER;

	/*Check if position is out of bounds*/
	if( pos_x < fmt->header.scene_min_point.x || pos_x > fmt->header.scene_max_point.x ||
		pos_y < fmt->header.scene_min_point.y || pos_y > fmt->header.scene_max_point.y ||
		pos_z < fmt->header.scene_min_point.z || pos_z > fmt->header.scene_max_point.z )
	{
		result->current_cell_index = -1;
		result->neighbour_cells_count = 0;
		return JANUA_RETURN_CODE_OK;
	}

	/*Transform position coordinates into voxel indices*/
	voxel_index_x = (unsigned int) ( (pos_x - fmt->header.scene_min_point.x) / fmt->header.voxel_size.x );
	voxel_index_y = (unsigned int) ( (pos_y - fmt->header.scene_min_point.y) / fmt->header.voxel_size.y );
	voxel_index_z = (unsigned int) ( (pos_z - fmt->header.scene_min_point.z) / fmt->header.voxel_size.z );

	buffer_pos = fmt->cells.offset;

	/*Find the cell*/
	for( current_cell_index = 0 ; current_cell_index < fmt->cells.size / sizeof( janua_lrb_cell ) ; current_cell_index++ )
	{
		current_cell = (janua_lrb_cell*) (handler->buffer + buffer_pos);
		
		/*Check if the input point is contained there*/
		if( voxel_index_x >= current_cell->min_pos.x && voxel_index_x <= current_cell->max_pos.x &&
			voxel_index_y >= current_cell->min_pos.y && voxel_index_y <= current_cell->max_pos.y &&
			voxel_index_z >= current_cell->min_pos.z && voxel_index_z <= current_cell->max_pos.z )
		{
 			cell_found = 1;
			break; /*found the cell and it is in current_cell and current_cell_index*/
		}

		buffer_pos += sizeof( janua_lrb_cell );
	}

	/*No cell found*/
	if( cell_found != 1 )
	{
		result->current_cell_index = -1;
		result->neighbour_cells_count = 0;
		return JANUA_RETURN_CODE_OK;
	}

	/*Initialize the result*/
	result->current_cell_index = current_cell_index;
	result->neighbour_cells_count = 0;

	/*Get the other model Ids that are in the current cell's PVS list*/
	/*Get the cell's pvs list*/
	buffer_pos = current_cell->cells_pvs_offset; 
	current_cell_pvs_list = (janua_lrb_cell_pvs_list*) (handler->buffer +  current_cell->cells_pvs_offset);
	buffer_pos += sizeof(UINT32);

	for( c = 0 ; c < current_cell_pvs_list->num ; c++ )
	{
		pvs_cell_index = *((UINT32*)( handler->buffer + buffer_pos));

		/*add the cell index*/
		result->neighbour_cells_index[result->neighbour_cells_count] = pvs_cell_index;
		result->neighbour_cells_count++;

		buffer_pos += sizeof(UINT32);
	}
	
	/*Clear the ids of the rest of the array*/
	for( c = result->neighbour_cells_count ; c < JANUA_MAX_QUERY_RESULT_MODELS ; c++ )
	{
		result->neighbour_cells_index[c] = -1;
	}

	return JANUA_RETURN_CODE_OK;
}

int janua_dump_debug( janua_handler* handler, janua_dump_debug_result* result )
{
	unsigned int current_cell_index;
	unsigned int buffer_pos_cell;
	unsigned int buffer_pos_model;
	janua_lrb_cell* current_cell;
	janua_lrb_format* fmt;
	unsigned int c;
	janua_lrb_model_pvs_list* current_model_pvs_list = 0;
	unsigned int model_id;
	janua_dump_debug_cell debug_cell;
	
	if( handler == 0L )
		return JANUA_RETURN_CODE_INVALID_HANDLER;
	
	/*Get Cell index from position*/
	fmt = (janua_lrb_format*) handler->buffer;

	if( fmt->cells.size <= 0 )
		return JANUA_RETURN_CODE_INVALID_BUFFER;

	/*Check for invalid voxel size*/
	if( fmt->header.voxel_size.x == 0.0f || fmt->header.voxel_size.y == 0.0f || fmt->header.voxel_size.z == 0.0f)
		return JANUA_RETURN_CODE_INVALID_BUFFER;


	buffer_pos_cell = fmt->cells.offset;

	/*Iterate over cells*/
	result->cells_count = 0;
	for( current_cell_index = 0 ; current_cell_index < fmt->cells.size / sizeof( janua_lrb_cell ) ; current_cell_index++ )
	{
		/*Current cell id*/
		current_cell = (janua_lrb_cell*) (handler->buffer + buffer_pos_cell);
		debug_cell.cell_id = current_cell_index;

		/*Go to the first model pvs list of the cell. Position the buffer position there*/
		buffer_pos_model = fmt->model_pvs_list.offset;

		/*Start advancing the buffer position until we find the cell's model list*/
		for( c = 0 ; c < current_cell_index ; c++ )
		{
			current_model_pvs_list = (janua_lrb_model_pvs_list*) (handler->buffer +  buffer_pos_model );
			buffer_pos_model += sizeof( UINT32 ) + sizeof(UINT32) * current_model_pvs_list->num ;
		}

		/*Get the cell's model pvs list*/
		current_model_pvs_list = (janua_lrb_model_pvs_list*) (handler->buffer +  buffer_pos_model );
		debug_cell.models_count = current_model_pvs_list->num;

		/*Save the current cell's model id's into the cell's array*/
		buffer_pos_model += sizeof(UINT32);
		for( c = 0 ; c < current_model_pvs_list->num ; ++c )
		{
			model_id = *((UINT32*)(handler->buffer + buffer_pos_model));
			debug_cell.models[c] = model_id;

			/*Point to the next model id number*/
			buffer_pos_model += sizeof(UINT32);
		}


		/*Point to the next cell*/
		result->cells[current_cell_index] = debug_cell;
		result->cells_count++;
		buffer_pos_cell += sizeof( janua_lrb_cell );
	}

	return JANUA_RETURN_CODE_OK;
}
/***************************** END DEBUG ***************************************/