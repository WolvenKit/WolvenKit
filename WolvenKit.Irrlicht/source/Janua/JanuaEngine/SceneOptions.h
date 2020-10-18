/* ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once
#include "..\Core\AABB.h"
#include "..\Core\Point3i.h"

/**
* SceneOptions specifies parameters abouthow a Scene should be processed.
*
*/
class SceneOptions
{
public:


	SceneOptions();
	
	/**
	* Sets the voxel size in the  X, Y and Z dimensions.
	* By default is set to maximum, so no restriction to cell size are applied.
	* @param sizeX				The X size.
	* @param sizeY				The Y size.
	* @param sizeZ				The Z size.
	*/
	void setVoxelSize(float sizeX, float sizeY, float sizeZ);

	/**
	* Sets the maximum cell size expressed in number of voxels in X, Y and Z dimensions.
	* By default is set to maximum, so no restriction to cell size are applied.
	* @param sizeX				The X size in voxels.
	* @param sizeY				The Y size in voxels.
	* @param sizeZ				The Z size in voxels.
	*/
	void setMaxCellSize(int sizeX, int sizeY, int sizeZ);

	/**
	* Sets the scene tile size expressed in number of voxels in X, Y and Z dimensions.
	* A scene tile size is specified to process the scene into more manageable parts.
	* Splitting into tiles helps to parallelize the processing.
	* The default tile size is set to 10 for X, Y and Z.
	* @param sizeX				The X size in voxels.
	* @param sizeY				The Y size in voxels.
	* @param sizeZ				The Z size in voxels.
	*/
	void setSceneTileSize(int sizeX, int sizeY, int sizeZ);
	
	/**
	* Returns the Voxel size expressed in the X, Y and Z dimensions.
	* @return	A Vector3f containing the Tile size in X, Y and Z dimensions.
	*/
	const Vector3f getVoxelSize() const {return m_voxelSize;};

	/**
	* Returns the maximum cell size expressed in number of voxels in X, Y and Z dimensions.
	* @return	A Point3i containing the cell size in X, Y and Z dimensions.
	*/
	const Point3i getMaxCellSize() const {return m_maxCellSize;};

	/**
	* Returns the SceneTile size expressed in number of voxels in X, Y and Z dimensions.
	* @return	A Point3i containing the Tile size in X, Y and Z dimensions.
	*/
	const Point3i getSceneTileSize() const {return m_sceneTileSize;};

	virtual ~SceneOptions(void);

private:

	Vector3f m_voxelSize;
	Point3i m_maxCellSize;
	Point3i m_sceneTileSize;

};

