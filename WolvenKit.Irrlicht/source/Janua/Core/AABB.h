/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */
#pragma once
#include "Vector3f.h"

//Axis aligned bounding box.
class AABB
{
public:

	AABB();
	AABB(Vector3f minPoint, Vector3f maxPoint);

	Vector3f minPoint;
	Vector3f maxPoint;

	~AABB(void);

	Vector3f getCenter() const;
	Vector3f getExtents() const;
	Vector3f getSize() const;

	void getExtremesArrays(float (&min)[3], float (&max)[3]) const;

};

inline Vector3f AABB::getCenter() const
{
	return minPoint + (maxPoint - minPoint) * 0.5f;
}

inline Vector3f AABB::getExtents() const
{
	return (maxPoint - minPoint) * 0.5f;
}

inline Vector3f AABB::getSize() const
{
	return maxPoint - minPoint;
}

inline void AABB::getExtremesArrays(float (&min)[3], float (&max)[3]) const
{
	min[0] = minPoint.x;
	min[1] = minPoint.y;
	min[2] = minPoint.z;

	max[0] = maxPoint.x;
	max[1] = maxPoint.y;
	max[2] = maxPoint.z;
}