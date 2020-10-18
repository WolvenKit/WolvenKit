/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once

#include "Vector3f.h"
class Triangle
{
public:
	Triangle(const Vector3f& pA, const Vector3f& pB, const Vector3f& pC);

	Vector3f a;
	Vector3f b;
	Vector3f c;

	static Triangle Transform(const Triangle pOriginalTriangle, const Matrix4x4& pTransformMatrix);

	//Triangle& Triangle::operator = (const Triangle& otherTriangle);

	~Triangle(void);
};

