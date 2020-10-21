#include "StdAfx.h"
#include "Voxel.h"

namespace Janua
{
	Voxel::Voxel(void)
	{
		status = EMPTY;
	}

	Voxel::Voxel(VoxelStatus  voxelStatus)
	{
		status = voxelStatus;
	}


	Voxel::~Voxel(void)
	{

	}
}