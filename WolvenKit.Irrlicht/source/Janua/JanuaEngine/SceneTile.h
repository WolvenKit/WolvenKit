#pragma once
/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once

#include "stdafx.h"
#include "..\Core\AABB.h"
#include "..\Core\Cell.h"

using std::vector;

//TODO: add namespace

/**
* A SceneTile is a subregion of the Scene. It is formed by an AABB.
* it is used to subdivide the scene into more manageable regions.
*/
class SceneTile
{
public:
	
	SceneTile(const Point3i fromVoxelIndex, const Point3i toVoxelIndex);
	~SceneTile(void);

	void addCell(const shared_ptr<Cell> cell);


	void setNumberOfSolidVoxelsInside(int numberOfSolidVoxels);

	/**
	* Returns a float from 0.0 to 1.0 indicating how much is that scene filled with solid voxels and cells.
	* @return  0.0 is empty and 1.0 is full.
	*/
	float getOccupancyLevel() const;

	/**
	* Returns the total number of voxels that fit in the SceneTile volume.
	*/
	int getNumberOfVoxelsInside() const;

	/**
	* Returns the total number of Solid voxels that are present in the SceneTile volume.
	*/
	int getNumberOfSolidVoxelsInside() const { return m_numberOfVoxels; };

	Point3i getTileFromIndex() const { return m_fromVoxelIndex; };
	Point3i getTileToIndex() const { return m_toVoxelIndex; };

	const vector<shared_ptr<Cell>> getCells() const { return m_cells; };

private:
	Point3i m_fromVoxelIndex, m_toVoxelIndex;
	vector<shared_ptr<Cell>> m_cells;
	int m_numberOfVoxels;

};

