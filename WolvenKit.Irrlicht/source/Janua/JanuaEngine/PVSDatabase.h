/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once

#include "..\Core\VoxelContainer.h"
#include <memory>
#include "..\Core\Cell.h"
#include "..\Core\Portal.h"
#include "..\Core\AABB.h"


using std::shared_ptr;

/**
* PVSDatabase contains information about the Potentially Visible Set.
* It is composed of Cells and Portals that are generated based on the voxelized Scene.
*/
class PVSDatabase
{
public:

	/**
	* Create a PVSDatabase by the given cells, scene AABB and Voxel size.
	* @param cells			The set of Cells.
	* @param sceneAABB		The  Axis Aligned Bounding Box of the scene.
	* @param voxelSize		The voxel X, Y and Z dimensions.
	*/
	PVSDatabase(vector<shared_ptr<Cell>> cells, const AABB sceneAABB, const Vector3f voxelSize);

	virtual ~PVSDatabase(void);

	static vector<shared_ptr<Cell>> getNeighbourCells(const Cell& cell);

	/**
	* Returns the Scene Axis Aligned Bounding Box.
	* @return The Scene AABB.
	*/
	AABB getSceneAABB() const { return m_sceneAABB; };

	//TODO: remove in the future.
	vector<shared_ptr<Cell>> m_cells; //The cells contained in the scene. 
	
	/**
	* Inserts all the Cells in the PVS Database at the end of the vector.
	* @param cells	The cell vector.
	*/
	void getAllCells(vector<shared_ptr<Cell>>& cells) const;

	/**
	* Inserts all the Portals in the PVS Database at the end of the vector.
	* @param portals	The portals vector.
	*/
	void getAllPortals(vector<shared_ptr<Portal>>& portals) const;

	/**
	* Returns the Voxel dimensions.
	* @return The voxel dimensions in X, Y and Z.
	*/
	const Vector3f getVoxelSize() const { return m_voxelSize; };

private:

	AABB m_sceneAABB;
	Vector3f m_voxelSize;
	
};

