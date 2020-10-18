#ifndef JANUA_RUNTIME_H
#define JANUA_RUNTIME_H

/* ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */


#pragma pack(push)  /* push current alignment to stack */
#pragma pack(1)     /* set alignment to 1 byte boundary */

#define FLOAT32 float
#define INT32	int
#define UINT32	unsigned int
#define UINT8	unsigned char
#define CHAR	unsigned char

/*Float vector 3*/
typedef struct
{
	FLOAT32 x;
	FLOAT32 y;
	FLOAT32 z;
} janua_vector3f;

/*Integer vector 3*/
typedef struct
{
	INT32 x;
	INT32 y;
	INT32 z;
} janua_vector3i;

/*LRB header.*/
typedef struct
{
	CHAR			magic[4];		 /*"LRB!" (4C 52 42 21)*/
	UINT8			version;		 /*1*/
	janua_vector3f	voxel_size;		 /*The size of voxel in x, y and z.*/
	janua_vector3f	scene_min_point; /* The scene minumum point.*/
	janua_vector3f	scene_max_point; /* The scene maximum point.*/
} janua_lrb_header;

/*LRB Section*/
typedef struct
{
	UINT32	offset;	  /*Offset to section, in bytes, from start of buffer.*/
	UINT32	size;	  /*Size of section in file, in bytes */
} janua_lrb_section;

/*LRB Cell*/
typedef struct
{
	janua_vector3i	min_pos;			/*Min cell position as index.*/
	janua_vector3i	max_pos;			/*Max cell position as index.*/
	UINT32			cells_pvs_offset;	/*The offset position to the cell pvs list.*/
	UINT32			cells_model_offset;	/*The offset position to the cell model list.*/
} janua_lrb_cell;

/*LRB Portal*/
typedef struct
{
	UINT32			from_cell;		/*From which cell id.*/
	UINT32			to_cell;		/*To which cell id.*/
	janua_vector3i  min_point;		/*Minimum voxel index*/
	janua_vector3i  max_point;		/*Maximum voxel index*/
	janua_vector3i  normal_dir;		/*Normal Direction*/
} janua_lrb_portal;

/*LRB cell PVS list*/
typedef struct
{
	UINT32			num;				/*Number of potentially visible cell ids.*/
	UINT32*			visible_cell_ids;	/*List of cell ids. size is the same as num field.*/
} janua_lrb_cell_pvs_list;

/*LRB models PVS list*/
typedef struct
{
	UINT32			num;				/*Number of potentially visible model ids.*/
	UINT32*			visible_model_ids;	/*List of model ids. size is the same as num field.*/
} janua_lrb_model_pvs_list;

/*LRB header.*/
typedef struct
{
	janua_lrb_header	header;
	janua_lrb_section	cells;
	janua_lrb_section	portals;
	janua_lrb_section	cell_pvs_list;
	janua_lrb_section	model_pvs_list;
} janua_lrb_format;

#pragma pack(pop)   /* restore original alignment from stack */

#ifdef __cplusplus
extern "C"{
#endif 

/*Max query result models*/
#define JANUA_MAX_QUERY_RESULT_MODELS 65536
/*Max number of total models in scene*/
#define JANUA_MAX_NUMBER_OF_MODELS 1048576

/*Function return codes*/
#define JANUA_RETURN_CODE_INVALID_BUFFER 1
#define JANUA_RETURN_CODE_INVALID_HANDLER 2
#define JANUA_RETURN_CODE_OUT_OF_MEMORY 3
#define JANUA_RETURN_CODE_OUT_OF_SCENE_BOUNDS 4
#define JANUA_RETURN_CODE_OK 0

/*The Janua engine handler*/
typedef struct
{
	/*Pointer to the PVS database*/
	char* buffer;
		
	/*Stores one bit per possible model id. If bit is set, then the model id is present in the result. 32 model ids fit in each UINT32 value*/
	UINT32 model_ids_bitvector[JANUA_MAX_NUMBER_OF_MODELS/32];

} janua_handler;

/*The Janua visibility query results*/
typedef struct
{
	unsigned int model_ids_count;
	int model_ids[JANUA_MAX_QUERY_RESULT_MODELS];
} janua_query_result;


void janua_release_engine( janua_handler* handler );
int janua_handler_load_database( janua_handler *handler, char *buffer );
int janua_query_visibility_from_position( janua_handler *handler, const float pos_x, const float pos_y, const float pos_z, janua_query_result* result );



/***************************** DEBUG ***************************************/

/*Result from janua_get_cells_data_from_position*/
typedef struct
{
	int current_cell_index;
	unsigned int neighbour_cells_count;
	int neighbour_cells_index[JANUA_MAX_QUERY_RESULT_MODELS];
} janua_get_cells_data_result;

int janua_get_cells_data_from_position( janua_handler* handler, const float pos_x, const float pos_y, const float pos_z, janua_get_cells_data_result* result );

/*Result from janua_dump_debug*/
typedef struct
{
	int cell_id;
	unsigned int models_count;
	int models[400];
} janua_dump_debug_cell;

/*Result from janua_dump_debug*/
typedef struct
{
	unsigned int cells_count;
	janua_dump_debug_cell cells[80];
} janua_dump_debug_result;

int janua_dump_debug( janua_handler* handler, janua_dump_debug_result* result );

/***************************** END DEBUG ***************************************/

#ifdef __cplusplus
}
#endif

#endif /*JANUA_RUNTIME_H*/
