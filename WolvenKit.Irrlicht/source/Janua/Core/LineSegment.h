/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once

#include "Vector3f.h"

class LineSegment
{
public:

	LineSegment(Vector3f startPoint, Vector3f endPoint);

	const Vector3f startPoint, endPoint;

	~LineSegment(void);
};

