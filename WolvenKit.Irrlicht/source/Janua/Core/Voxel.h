/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once

class Voxel
{
public:

	enum VoxelStatus {
		EMPTY = 0,
		SOLID
	};


	Voxel(void);
	Voxel(VoxelStatus status);

	~Voxel(void);

	VoxelStatus getStatus() const { return status; }
	void setStatus(VoxelStatus val) { status = val; }

private:

	VoxelStatus status;

};


