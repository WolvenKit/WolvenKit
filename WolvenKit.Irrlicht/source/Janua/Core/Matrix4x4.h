/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once

#pragma warning(disable: 4201)
/**
* A 4x4 Transformation Matrix.
* 
*/
class Matrix4x4
{
public:

	/**
		Row major order matrix elements
	*/
	union 
	{
		float vec[16];
		struct
		{
			//M[row][column]
			float M11; //first row and the first column of the  matrix.
			float M12;
			float M13;
			float M14;
			float M21;
			float M22;
			float M23;
			float M24;
			float M31;
			float M32;
			float M33;
			float M34;
			float M41;
			float M42;
			float M43;
			float M44;
		};
	}; 

	Matrix4x4(void);
	virtual ~Matrix4x4(void);
};

