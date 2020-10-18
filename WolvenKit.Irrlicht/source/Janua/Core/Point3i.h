/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once
#include <utility>

#pragma warning(disable: 4201)

using namespace std::rel_ops;

class Point3i
{
public:

	union 
	{
		int vec[3];
		struct
		{
			int x;
			int y;
			int z;
		};
	};


	Point3i(void);
	Point3i(int x, int y, int z);
	~Point3i(void);

	friend bool Point3i::operator < (const Point3i& lhs, const Point3i& rhs );
	friend bool Point3i::operator == (const Point3i& lhs, const Point3i& rhs );
	friend bool Point3i::operator != (const Point3i& lhs, const Point3i& rhs );

	Point3i Point3i::operator + (const Point3i& otherPoint);
	Point3i Point3i::operator - (const Point3i& otherPoint);

	friend Point3i operator + (const Point3i& lhs, const Point3i& rhs);
	friend Point3i operator - (const Point3i& lhs, const Point3i& rhs);

};

