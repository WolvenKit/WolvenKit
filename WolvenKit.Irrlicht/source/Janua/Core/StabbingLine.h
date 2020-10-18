/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once

#include "LineSegment.h"
#include "PortalQuad.h"
#include <vector>

using std::vector;

class StabbingLine
{
public:

	StabbingLine(void);
	
	static bool StabbingLineBetweenPortalsExist( vector<PortalQuad>& portalQuads );

	~StabbingLine(void);
};

