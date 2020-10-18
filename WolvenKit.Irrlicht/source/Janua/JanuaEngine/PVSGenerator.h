/*  ******************************************************************************* **
 * GIGC - Grupo de Investigación de Gráficos por Computadora - UTN FRBA - Argentina
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *  **
 * <copyright> copyright (c) 2013 </copyright>	
 * <autor> Leandro Roberto Barbagallo </autor>
 * <license href="https://github.com/gigc/Janua">MIT</license>
 ********************************************************************************** */

#pragma once
#include "Scene.h"
#include "..\Core\VoxelContainer.h"
#include "PVSDatabase.h"
#include "..\Core\Cell.h"
#include "..\Core\Ray.h"
#include "..\Core\PortalQuad.h"
#include "..\Core\CollisionUtils.h"
#include "TrianglesOctree.h"
#include "SceneTile.h"

using std::vector;
using std::pair;

/**
* The PVSGenerator processes the visibility information from a given Scene.
* It generas a PVSDatabase as output containing the occlusion data.
*/
class PVSGenerator
{
public:
	PVSGenerator(const Scene& pScene);//, const Vector3f cellSize);

	/**
	* Processes the scene and produces a PVSDatabase containing the occlusion data.
	* @return	A pointer to the PVSDatabase generated.
	*/
	shared_ptr<PVSDatabase> generatePVSDatabase();

	/** For debugging only */
	PortalQuad getPortalRectangle(const Portal& portal, const Vector3f& voxelSize) const;
	/** For debugging only */
	vector<Vector3f> getAllSolidVoxelPositionsInWorldSpace() const;

	~PVSGenerator(void);
	
private:

	const Scene &scene;
	Vector3f cellSize;
	AABB m_SceneAABB;
	shared_ptr<VoxelContainer> m_voxelContainer;
	vector<shared_ptr<SceneTile>> m_sceneTiles;

	AABB getSceneAABB();
	
	void voxelizeModels( VoxelContainer& voxelContainer, const AABB sceneAABB); //Generate voxels from the models in the scene.

	void generateCellsFromEmptyVoxelsUsingTiles( VoxelContainer& voxelContainer, vector<shared_ptr<Cell>>& cells) const; //Convert empty space to axis aligned Cells

	void testExpansion( Point3i& minVoxelPos, Point3i& maxVoxelPoint, VoxelContainer::NEIGHBOUR_DIRECTION dir, const VoxelContainer& voxelContainer, const SceneTile& tile) const; //Expand the cell to one direction.

	bool tryNewAABB( const Point3i &minVoxelPos, const Point3i &maxVoxelPoint, const VoxelContainer::NEIGHBOUR_DIRECTION& expandDirection, const VoxelContainer& voxelContainer, const SceneTile& tile ) const; //test if the expanded cell only contains empty voxels.

	bool isVoxelInsideAnExistingCells( const vector<shared_ptr<Cell>>& existingCells, const Point3i& point ) const; //Verify if a voxel is already contained in a list of C.ells.

	bool isVoxelInsideCell(const Cell& cell, const Point3i& point) const; //Check if a voxel is contained in a particular Cell.

	void getCellFromPoint( const vector<shared_ptr<Cell>>& existingCells, const Point3i& point, int& cellIndex,  int startingCell = 0) const; //Find which Cell contains a given point. Return the index of the cell.

	void buildConectivityGraph( vector<shared_ptr<Cell>>& cells,  vector<shared_ptr<Portal>>& portals,  const VoxelContainer& voxelContainer); //Create connections betweeen Cells through Portals.

	void generatePVS(vector<shared_ptr<Cell>>& cells,  vector<shared_ptr<Portal>>& portals,  const VoxelContainer& voxelContainer);

	void getCellsSharedVoxels(const pair<Cell, Cell> cells, vector<Point3i>& sharedVoxels) const; //Get the shared voxels between two cells (only originating cell's voxels)

	void getCellsSharedVoxelsOnlyExternals(const pair<Cell, Cell> cells, vector<Point3i>& sharedVoxels) const; //Get the shared voxels between two cells.(only neighbour cell's voxels)
	
	void getMinMaxPointFromVoxels(const vector<Point3i> voxels, Point3i& minPoint, Point3i& maxPoint ) const; //Get the minumum and maximum (AABB) points for a given set of voxels.

	Point3i getPortalFacingWallPlane( const vector<Point3i> voxels, const Point3i& minPoint, const Point3i& maxPoint, const pair<Cell,Cell>& cellPairs ) const; //Returns the normal of the plane that conforms a Portal.

	void getCellExternalVoxels(const Cell& cell, vector<Point3i>& externalVoxels ) const; //Returns the cell´s surrounding voxels.

	void findVisibleCells(const shared_ptr<Cell>& startingCell , vector<shared_ptr<Portal>>& portalSequence, vector<shared_ptr<Cell>>& visibleCellSet, const VoxelContainer& voxelContainer, int &callDepth);
	
	void findVisibleCellsNoneRecursive(const shared_ptr<Cell>& startingCell, vector<shared_ptr<Portal>>& portalSequence, vector<shared_ptr<Cell>>& visibleCellSet, const VoxelContainer& voxelContainer);

	bool stabbingLineExists(const shared_ptr<Cell>& cell, const vector<shared_ptr<Portal>>& portalSequence , const shared_ptr<Portal>& nPortal, const VoxelContainer& voxelContainer) const;

	bool testRay( const AABB& voxelAABB, const Ray& ray ) const;

	Point3i findNextUnexploredVoxel(const vector<shared_ptr<Cell>>& cells, VoxelContainer& voxelContainer) const;
	
	Point3i findSeedPointInTile(const SceneTile& tile, VoxelContainer& voxelContainer) const;

	void addModelsToCells(const vector<shared_ptr<Cell>>& cells, VoxelContainer& voxelContainer, const AABB sceneAABB);

	bool portalSequenceContainsCoplanarPortals(const vector<PortalQuad>& portalQuads) const;

	void createSceneTiles();

};

