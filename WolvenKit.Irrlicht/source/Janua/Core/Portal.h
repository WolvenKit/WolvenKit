/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once
#include "Point3i.h"
#include "Cell.h"


class Portal
{
public:

	Portal (shared_ptr<Cell> fromCell, shared_ptr<Cell> toCell, Point3i minPoint, Point3i maxPoint, Point3i facingPlane);
	~Portal(void);

	shared_ptr<Cell> fromCell; 
	shared_ptr<Cell> toCell;
	
	Point3i minPoint, maxPoint; //The voxels shared between cells.

	Point3i facingPlane; //The plane where it points at. eg. (1,0,0) YZ plane pointing to +X.

private:

};

