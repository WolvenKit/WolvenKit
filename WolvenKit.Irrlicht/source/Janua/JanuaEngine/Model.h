/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once
#include "..\Core\Vector3f.h"
#include "..\Core\Triangle.h"

#include <vector>
using std::vector;

/**
* A Model is a 3D mesh that consists of triangles.
* Each model has a a list of vertices and indices of those vertices that specify how triangles are formed.
*/
class Model
{
public:
	
	/**
	* Create a Model with the triangles given. 
	* Indicate the parameters carefully as no bounds checks are performed.
	* For example a model with a single triangle has:  
	*  -pvertices: [x1, y1, z1, x2, y2, z2, x3, y3, z3]
	*  -pverticesCount: 3
	*  -pindices: [0, 1, 2]
	*  -pTriangleCount: 1
	* @param pvertices			The array of vertices one next to the other. Each vertex has X, Y, Z float coordinates in model space.
	* @param pverticesCount		The total number of vertices.
	* @param pindices			The array of indices. Each triangle has 3 indices that refence 3 different vertices.
	* @param pTriangleCount		The total number of triangles.
	*/
	Model(const float pvertices[], int pverticesCount, const int pindices[], int pTriangleCount);

	virtual ~Model(void);

	/**
	* Returns the Triangle at the given index.
	* @param triangleId		The zero based triangle index. Has the to be less that the total triangle count.
	* @return				The Triange at the given Index.
	*/
	Triangle getTriangle(int triangleId) const;

	/**
	* Returns the total number of triangles of the Model.
	* @return	Number of triangles.
	*/
	int getTriangleCount() const;


private:
	int getIndicesCount() const;
	int getIndex(int indexId) const;

	vector<float> vertices;
	vector<int> indices;

};

