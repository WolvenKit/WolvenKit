#include "StdAfx.h"
#include "PVSGenerator.h"
#include "../Core/CollisionUtils.h"
#include "PVSDatabase.h"
#include "../Core/Cell.h"
#include "../Core/AABB.h"
#include "../Core/Ray.h"
#include "../Core/StabbingLine.h"
#include "../Core/Point3i.h"
#include "PVSDatabaseExporter.h"
#include "PVSDatabaseImporter.h"
#include "Utilities.h"
#include "Logger.h"
#include "SceneTile.h"

using std::min;
using std::max;
using std::logic_error;
using std::bad_alloc;
using std::shared_ptr;
using std::pair;
using std::stack;

//Max number of portals that a cell can view through.
#define MAX_PORTAL_SEQUENCE 4096
#define MAX_RANDOM_SEED_TRYOUTS 3000;
#define MAX_STACK_DEPTH 4096
#define PLANE_EPSILON 0.0001f

PVSGenerator::PVSGenerator(const Scene& pScene) : scene(pScene)
{
	cellSize = pScene.options.getVoxelSize();
}

PVSGenerator::~PVSGenerator(void)
{
}

shared_ptr<PVSDatabase> PVSGenerator::generatePVSDatabase()
{

	Logger::Log("Begin Generating PVS.");

	std::stringstream cellLog;

	//Get the scene limits.
	m_SceneAABB = getSceneAABB();

	cellLog.clear();
	cellLog << "Scene AABB min point:"  << "(" << m_SceneAABB.minPoint.x  << ", " << m_SceneAABB.minPoint.y << ", " << m_SceneAABB.minPoint.z << ")" << std::endl;
	Logger::Log(cellLog.str());

	cellLog.clear();
	cellLog << "Scene AABB max point:"  << "(" << m_SceneAABB.maxPoint.x  << ", " << m_SceneAABB.maxPoint.y << ", " << m_SceneAABB.maxPoint.z << ")" << std::endl;
	Logger::Log(cellLog.str());

	int cellCountX, cellCountY, cellCountZ;

	Vector3f dist = m_SceneAABB.maxPoint - m_SceneAABB.minPoint;

	cellCountX = static_cast<int>( ceilf(dist.x / cellSize.x) );
	cellCountY = static_cast<int>( ceilf(dist.y / cellSize.y) );
	cellCountZ = static_cast<int>( ceilf(dist.z / cellSize.z) );

		//Create a voxel container of the specified dimesions.
	shared_ptr<VoxelContainer> voxelContainer(new VoxelContainer(cellSize, cellCountX, cellCountY, cellCountZ));
		
	m_voxelContainer = voxelContainer;

	cellLog.clear();
	cellLog << "Voxel container size:"  << "(" << cellCountX  << ", " << cellCountY << ", " << cellCountZ << ")" << std::endl;
	Logger::Log(cellLog.str());

		
	Logger::Log("Begin voxelizing models.");

	//Voxelize all the models.
	voxelizeModels(*voxelContainer, m_SceneAABB);
	
	Logger::Log("End voxelizing models.");
	
	cellLog.clear();
	cellLog << "Solid voxel count: "  << voxelContainer->getAllSolidVoxelsCount() << std::endl;
	Logger::Log(cellLog.str());


	Logger::Log("Begin creating scene tiles.");
	
	//Subdivide the scene into tiles.
	createSceneTiles();
	Logger::Log("End creating scene tiles.");


	vector<shared_ptr<Cell>> cells;
	vector<shared_ptr<Portal>> portals;

	Logger::Log("Begin Generating Cells.");

	//Convert voxels to Axis aligned cells.
	generateCellsFromEmptyVoxelsUsingTiles(*voxelContainer, cells);

	Logger::Log("End Generating Cells.");
	Logger::Log("Begin building connectivity graph.");

	//See which cells connect to which other cells.
	buildConectivityGraph(cells, portals, *voxelContainer);

	cellLog.clear();
	cellLog << "Number of Cells: " << cells.size() << std::endl;

	Logger::Log(cellLog.str());

	Logger::Log("End building connectivity graph.");
	Logger::Log("Begin PVS generation.");

	//Determine the visibility set for each cell.
	generatePVS(cells, portals, *voxelContainer);

	Logger::Log("End PVS generation.");
	Logger::Log("Begin Adding Models to Cells.");

	//Set the models that are in each cell.
	addModelsToCells(cells,*voxelContainer, m_SceneAABB);

	Logger::Log("End Adding Models to Cells.");

	//Create a PVS database based on the voxel container.
	shared_ptr<PVSDatabase> pvsDb( new PVSDatabase( cells, m_SceneAABB, voxelContainer->getVoxelSize() ));

	Logger::Log("End Generating PVS.");
		
	Logger::Flush();

	return pvsDb;
}

//Now that the cells are created, associate each model to one or more cells of the scene.
void PVSGenerator::addModelsToCells(const vector<shared_ptr<Cell>>& cells, VoxelContainer& voxelContainer, const AABB sceneAABB)
{
	const Vector3f voxelSize = voxelContainer.getVoxelSize();
	vector<Point3i> cellExternalIndices;
	vector<Triangle> triangles;
	AABB voxelAABB;
	Vector3f voxelMidPoint;
	float boxHalfSize[3];
	float triverts[3][3];
	float boxCenter[3];

	for( unsigned int c = 0 ; c < cells.size() ; ++c)
	{

		Point3i minIndex = cells[c]->minPoint;
		Point3i maxIndex = cells[c]->maxPoint;

		//Convert the AABB to world space.
		AABB cellAABB(  Vector3f (
								minIndex.x * voxelSize.x + sceneAABB.minPoint.x,
								minIndex.y * voxelSize.y + sceneAABB.minPoint.y,
								minIndex.z * voxelSize.z + sceneAABB.minPoint.z	),
						Vector3f (
								maxIndex.x * voxelSize.x + sceneAABB.minPoint.x + voxelSize.x,
								maxIndex.y * voxelSize.y + sceneAABB.minPoint.y + voxelSize.y,
								maxIndex.z * voxelSize.z + sceneAABB.minPoint.z + voxelSize.z));
		AABB modelAABB;

		//For each Occludee
		for( int i = 0; i < scene.getModelInstancesCount() ; ++i)
		{
			//TODO: very heavy operation, try to cache it somewhere.
			modelAABB = scene.getModelInstance(i).getModelAABB();

			//Check if model is inside the cell. If so, add it to the cell model list.
			if( scene.getModelInstance(i).getModelType() == OCCLUDEE)
			{
				if( CollisionUtils::boxBoxOverlapTest( modelAABB.minPoint.vec,  modelAABB.maxPoint.vec,  cellAABB.minPoint.vec,  cellAABB.maxPoint.vec))
					cells[c]->addModelId( scene.getModelInstance(i).getModelId() );
			}
		}


		//Calculate the occluders.
		//Occluders are treated differently from the occludees. Occluders don't collide with cells directly because they are where solid voxels are.
		//Because of this, we have to test the cell external voxels against the actual occluder geometry.
		
		//Get all the external voxels of the cell.
		cellExternalIndices.clear();
		getCellExternalVoxels( *(cells[c]), cellExternalIndices);

		//Calculate the voxel's half size in x, y and z.
		boxHalfSize[0] = voxelSize.x / 2.0f;
		boxHalfSize[1] = voxelSize.y / 2.0f;
		boxHalfSize[2] = voxelSize.z / 2.0f;

		//For each external voxel of this cell, see if there is any occluder that collides with it.
		for( unsigned int i = 0 ; i < cellExternalIndices.size() ; ++i)
		{
			//Only consider solid external voxels because they have geometry there.
			if( voxelContainer.voxelAt(cellExternalIndices[i]).getStatus() != Voxel::SOLID )
				continue;

			//Go for each occluder and test for collision.
			for( int k = 0; k < scene.getModelInstancesCount() ; ++k)
			{
				//If it is occluder and it is not yet associated with the cell...
				if( scene.getModelInstance(k).getModelType() == OCCLUDER &&
					cells[c]->isModelIdInCell(scene.getModelInstance(k).getModelId()) == false  )
				{
					//TODO: very heavy operation, try to cache it somewhere.
					modelAABB = scene.getModelInstance(k).getModelAABB();
					voxelAABB = voxelContainer.getVoxelAABBFromIndex(cellExternalIndices[i], sceneAABB);

					//If collides with AABB of the voxel then we can test at polygon level.
					if( CollisionUtils::boxBoxOverlapTest( modelAABB.minPoint.vec,  modelAABB.maxPoint.vec,  voxelAABB.minPoint.vec,  voxelAABB.maxPoint.vec))
					{
						
						triangles.clear();

						//Transform the model space triangle to world space.
						scene.getModelInstance(k).getModelTrianglesWorldSpace(triangles);

						voxelMidPoint = voxelAABB.getCenter();
												
						boxCenter[0] = voxelMidPoint.x;
						boxCenter[1] = voxelMidPoint.y;
						boxCenter[2] = voxelMidPoint.z;

						for( unsigned int t = 0 ; t < triangles.size() ; ++t)
						{

							//Store the triangle in a format that the colission algorithm can receive.
							triverts[0][0] = triangles[t].a.x;
							triverts[0][1] = triangles[t].a.y;
							triverts[0][2] = triangles[t].a.z;

							triverts[1][0] = triangles[t].b.x;
							triverts[1][1] = triangles[t].b.y;
							triverts[1][2] = triangles[t].b.z;

							triverts[2][0] = triangles[t].c.x;
							triverts[2][1] = triangles[t].c.y;
							triverts[2][2] = triangles[t].c.z;

							//Test for intersection between the triangle and the voxel's AABB.
							if(CollisionUtils::triBoxOverlap(boxCenter, boxHalfSize, triverts) == 1)
							{
								cells[c]->addModelId( scene.getModelInstance(k).getModelId() );
								break;
							}
						}
					}
				}
			}
		}
		
		//Log progress
		if( c % ( (cells.size() / 10)  + 1) == 0 ) //Show 10% increments.
		{
			std::stringstream str;
			str << "Models to Cells %: " << ((float) c / cells.size()) * 100.0f;
			Logger::Log( str.str() );
		}
	}
}


Point3i PVSGenerator::findNextUnexploredVoxel(const vector<shared_ptr<Cell>>& cells, VoxelContainer& voxelContainer) const
{

	int i, j, k;
	Point3i voxelPos;

	for( i = 0; i < voxelContainer.getVoxelCounts().x; ++i)
	{
		voxelPos.x = i;

		for( j = 0; j < voxelContainer.getVoxelCounts().y; ++j)
		{
			voxelPos.y = j;

			for( k = 0; k < voxelContainer.getVoxelCounts().z; ++k)
			{
				voxelPos.z = k;

				if(voxelContainer.voxelAt(voxelPos).getStatus() == Voxel::EMPTY &&
					isVoxelInsideAnExistingCells(cells, voxelPos) == false)
				{
					return voxelPos;
				}
			}
		}
	}
	throw "There is none empty voxel in the scene";
}


Point3i PVSGenerator::findSeedPointInTile(const SceneTile& tile, VoxelContainer& voxelContainer ) const
{
	int i, j, k;
	Point3i voxelPos;

	const vector<shared_ptr<Cell>>& tileCells = tile.getCells();

	for( i = tile.getTileFromIndex().x; i <= tile.getTileToIndex().x; ++i)
	{
		voxelPos.x = i;

		for( j = tile.getTileFromIndex().y; j <= tile.getTileToIndex().y; ++j)
		{
			voxelPos.y = j;

			for( k = tile.getTileFromIndex().z; k <= tile.getTileToIndex().z; ++k)
			{
				voxelPos.z = k;

				if(voxelContainer.voxelAt(voxelPos).getStatus() == Voxel::EMPTY && isVoxelInsideAnExistingCells(tileCells, voxelPos) == false)
				{
					return voxelPos;
				}
			}
		}
	}
	
	throw new logic_error("Can't find empty seed voxel.");
}

AABB PVSGenerator::getSceneAABB()
{

	Vector3f mins(FLT_MAX);
	Vector3f maxs(FLT_MIN);

	if( scene.getModelInstancesCount() == 0 )
		throw new logic_error("Scene has no model instances.");

	for (int i = 0; i < scene.getModelInstancesCount(); i++)
	{
		const ModelInstance& modelInstance = scene.getModelInstance(i);

		AABB box = modelInstance.getModelAABB();

		mins.x = min(box.minPoint.x, mins.x);
		mins.y = min(box.minPoint.y, mins.y);
		mins.z = min(box.minPoint.z, mins.z);

		maxs.x = max(box.maxPoint.x, maxs.x);
		maxs.y = max(box.maxPoint.y, maxs.y);
		maxs.z = max(box.maxPoint.z, maxs.z);
	}

	return AABB(mins, maxs);
}

void PVSGenerator::voxelizeModels( VoxelContainer& voxelContainer, const AABB sceneAABB )
{

	float boxHalfSize[3];

	//Calculate the voxel's half size in x, y and z.
	boxHalfSize[0] = voxelContainer.getVoxelSize().x / 2.0f;
	boxHalfSize[1] = voxelContainer.getVoxelSize().y / 2.0f;
	boxHalfSize[2] = voxelContainer.getVoxelSize().z / 2.0f;

	try
		{
		for (int i = 0; i < scene.getModelInstancesCount(); i++)
		{
			const ModelInstance& modelInstance = scene.getModelInstance(i);

			//Only voxelize models if they are occluders.
			if( modelInstance.getModelType() == OCCLUDEE )
				continue;

			vector<Triangle> triangles;

			//Transform the model space triangle to world space.
			modelInstance.getModelTrianglesWorldSpace(triangles);

			AABB modelAABB = modelInstance.getModelAABB();

			//Get all the Voxels AABB that are bounding the model. This will be used as potential voxels to test for intersection.
			vector<AABB> boxesToTest = voxelContainer.getAllVoxelAABBFromVolume(modelAABB, sceneAABB);

			float triverts[3][3];
			float boxCenter[3];
			Vector3f voxelMidPoint;

			//For each triangle of the model.
			for (unsigned int j = 0; j < triangles.size() ; j++)
			{

				//Store the triangle in a format that the colission algorithm can receive.
				triverts[0][0] = triangles[j].a.x;
				triverts[0][1] = triangles[j].a.y;
				triverts[0][2] = triangles[j].a.z;

				triverts[1][0] = triangles[j].b.x;
				triverts[1][1] = triangles[j].b.y;
				triverts[1][2] = triangles[j].b.z;

				triverts[2][0] = triangles[j].c.x;
				triverts[2][1] = triangles[j].c.y;
				triverts[2][2] = triangles[j].c.z;

				//For all the potential voxels than can intersect the model.
				for (unsigned int c = 0; c < boxesToTest.size() ; ++c)
				{

					//Find the voxel center.
					voxelMidPoint = (boxesToTest[c].maxPoint + boxesToTest[c].minPoint) / 2.0f;

					boxCenter[0] = voxelMidPoint.x;
					boxCenter[1] = voxelMidPoint.y;
					boxCenter[2] = voxelMidPoint.z;

				
					//Test for intersection between the triangle and the voxel's AABB.
					if(CollisionUtils::triBoxOverlap(boxCenter, boxHalfSize, triverts) == 1)
						voxelContainer.addVoxelAt( voxelContainer.getVoxelIndexFromPoint(voxelMidPoint, sceneAABB) ); //Voxel is solid.
					
				}
			}
		}
	}catch( bad_alloc& ){
		Logger::Log("Error allocating memory for voxels. Consider using a bigger voxel size.");
		exit(1);
	}catch( ... ){
		Logger::Log("Unknown error in voxelize models");
		exit(1);
	}
}

//Create the scene tiles based on the size of the voxel container.
void PVSGenerator::createSceneTiles()
{
	
	//Get the Scene Tile size.
	const Point3i tileSize =  scene.options.getSceneTileSize();

	//Calculate how many tiles needed based on the scene number of voxels.
	const Point3i numberOfTiles (
		(int) ceil( (float) m_voxelContainer->getVoxelCounts().x / (float) tileSize.x),
		(int) ceil( (float) m_voxelContainer->getVoxelCounts().y / (float) tileSize.y),
		(int) ceil( (float) m_voxelContainer->getVoxelCounts().z / (float) tileSize.z));

	int x, y, z;

	Point3i from, to, voxelPos;

	try
		{
		//Create the Scene Tiles
		for( x = 0 ; x < numberOfTiles.x ; ++x )
		{
			from.x = x * tileSize.x;
			to.x = x * tileSize.x + tileSize.x - 1;

			//Clamp to the bounds.
			if( to.x >=  m_voxelContainer->getVoxelCounts().x )
				to.x = m_voxelContainer->getVoxelCounts().x - 1;

			for( y = 0 ; y < numberOfTiles.y ; ++y )
			{
				from.y = y * tileSize.y;
				to.y = y * tileSize.y + tileSize.y - 1;

				if( to.y >=  m_voxelContainer->getVoxelCounts().y )
						to.y = m_voxelContainer->getVoxelCounts().y - 1;

				for( z = 0 ; z < numberOfTiles.z ; ++z )
				{

					from.z = z * tileSize.z;
					to.z = z * tileSize.z + tileSize.z - 1;

					if( to.z >=  m_voxelContainer->getVoxelCounts().z )
						 to.z = m_voxelContainer->getVoxelCounts().z - 1;

			
					//Create the Scene Tile from the start and end voxel points.
					shared_ptr<SceneTile> tile( new SceneTile( from, to ) );

					int numberOfSolidVoxelsInsideCell = 0;

					//Add the number of solid voxels to the cell.
					//It will be used later on to check if we covered all voxels with cells.
					for( voxelPos.x = from.x ; voxelPos.x <= to.x ; ++voxelPos.x )
					{
						for( voxelPos.y = from.y ; voxelPos.y <= to.y ; ++voxelPos.y )
						{
							for( voxelPos.z = from.z ; voxelPos.z <= to.z ; ++voxelPos.z )
							{
								if( m_voxelContainer->voxelAt(voxelPos).getStatus() == Voxel::SOLID )
									numberOfSolidVoxelsInsideCell++;
							}
						}
					}

					tile->setNumberOfSolidVoxelsInside(numberOfSolidVoxelsInsideCell);

					m_sceneTiles.push_back( tile );
				}
			}
		}

	}catch( bad_alloc& ){
		Logger::Log("Error allocating memory for SceneTile. Consider setting a bigger SceneTile size");
		exit(1);
	}
}

//Subdivide the empty voxels into cells.
void PVSGenerator::generateCellsFromEmptyVoxelsUsingTiles( VoxelContainer& voxelContainer, vector<shared_ptr<Cell>>& cells ) const
{

	Point3i minVoxelPoint, maxVoxelPoint;

	int lastProgress = 0;
	int progress;
	int tileIndex;
	int expectedEmptyVoxels;
	int numberOfVoxelsInsideCell;
	int cellsCreated = 0;
	int cellsCreatedForTile = 0;
	int tilesProcessed=0;
	SceneTile* currentTile;
	
	try
	{
		//Process the SceneTiles in parallel. Each one has it's own collection of Cells and can read the voxel container concurrently.
		#pragma omp parallel for private(currentTile, tileIndex, expectedEmptyVoxels, minVoxelPoint, maxVoxelPoint, numberOfVoxelsInsideCell, cellsCreatedForTile ) shared(lastProgress, voxelContainer, cells, progress, cellsCreated, tilesProcessed)
		for( tileIndex = 0 ; tileIndex < (int) m_sceneTiles.size() ; ++tileIndex)
		{
			currentTile = (m_sceneTiles[tileIndex]).get();
			cellsCreatedForTile = 0;

			//How many empty voxels are we expecting to have in this tile.
			expectedEmptyVoxels = currentTile->getNumberOfVoxelsInside() - currentTile->getNumberOfSolidVoxelsInside();

			//If all the Tile is solid, don't generate a cell.
			if( expectedEmptyVoxels == 0 )
				continue;
		
			//Do while there are no pending empty voxels left in the tile
			while ( expectedEmptyVoxels > 0 )
			{

				//Take first seed voxel index.
				minVoxelPoint = maxVoxelPoint = findSeedPointInTile( *currentTile, voxelContainer );

				//Expand the cell until there is something that blocks the growth in that direction, then continue with the other directions.
				testExpansion( minVoxelPoint, maxVoxelPoint, VoxelContainer::POSITIVE_X, voxelContainer, *currentTile );
				testExpansion( minVoxelPoint, maxVoxelPoint, VoxelContainer::POSITIVE_Y, voxelContainer, *currentTile );
				testExpansion( minVoxelPoint, maxVoxelPoint, VoxelContainer::POSITIVE_Z, voxelContainer, *currentTile );
				testExpansion( minVoxelPoint, maxVoxelPoint, VoxelContainer::NEGATIVE_X, voxelContainer, *currentTile );
				testExpansion( minVoxelPoint, maxVoxelPoint, VoxelContainer::NEGATIVE_Y, voxelContainer, *currentTile );
				testExpansion( minVoxelPoint, maxVoxelPoint, VoxelContainer::NEGATIVE_Z, voxelContainer, *currentTile );
		
				//Calculate how many voxels are inside the cell found.
				numberOfVoxelsInsideCell = (maxVoxelPoint.x - minVoxelPoint.x + 1) * (maxVoxelPoint.y - minVoxelPoint.y + 1) * (maxVoxelPoint.z - minVoxelPoint.z + 1);

				//Expect less voxels to explore.
				expectedEmptyVoxels -= numberOfVoxelsInsideCell;

				//Create the cell and add it to the Tile.
				currentTile->addCell( shared_ptr<Cell>(new Cell(minVoxelPoint, maxVoxelPoint ) ));
				cellsCreatedForTile++;
			}

			//Show progress on the log.
			#pragma omp critical
			{
				tilesProcessed++;
				cellsCreated += cellsCreatedForTile;
				progress = (int) (((float)tilesProcessed / (float) m_sceneTiles.size()) * 100.0f);
				if( progress - lastProgress >= 10 )
				{
					std::stringstream str;
					str << "Tiles processed %: " << progress << " (" << cellsCreated << " cells)";
					Logger::Log( str.str() );
					lastProgress = progress; 
				}
			}

		}
	
		//With all the cells created in each Tile, merge them all into the unified cells vector.
		for( unsigned int tileIndex = 0 ; tileIndex < m_sceneTiles.size() ; ++tileIndex)
		{
			const vector<shared_ptr<Cell>>& tileCells = m_sceneTiles[tileIndex]->getCells();
			cells.insert( cells.end(), tileCells.begin(), tileCells.end() );
		}
	}catch( bad_alloc& ) {
		Logger::Log("Error allocating memory for Cells. Consider increasing the Max Cell size or increasing SceneTile size.");
		exit(1);
	}
}

void PVSGenerator::testExpansion( Point3i& minVoxelPoint, Point3i& maxVoxelPoint, 
								  VoxelContainer::NEIGHBOUR_DIRECTION dir, const VoxelContainer& voxelContainer, 
								  const SceneTile& tile) const
{
	
	//Where to expand.
	Point3i offsetDir(0,0,0);

	bool positiveDirection;

	//Determine in which dimension to move
	switch (dir)
	{
	case VoxelContainer::POSITIVE_X:
		offsetDir.x = 1;
		positiveDirection = true;
		break;
	case VoxelContainer::NEGATIVE_X:
		offsetDir.x = -1;
		positiveDirection = false;
		break;
	case VoxelContainer::POSITIVE_Y:
		offsetDir.y = 1;
		positiveDirection = true;
		break;
	case VoxelContainer::NEGATIVE_Y:
		offsetDir.y = -1;
		positiveDirection = false;
		break;
	case VoxelContainer::POSITIVE_Z:
		offsetDir.z = 1;
		positiveDirection = true;
		break;
	case VoxelContainer::NEGATIVE_Z:
		offsetDir.z = -1;
		positiveDirection = false;
		break;
	}

	Point3i lastValidMaxPoint, lastValidMinPoint;

	bool isNewAABBValid = true;

	//Expand AABB until it is not yet valid (collides with a solid voxel in the scene).
	while( isNewAABBValid )
	{
		lastValidMaxPoint = maxVoxelPoint;
		lastValidMinPoint = minVoxelPoint;

		//See if need to expand Max point or Min point
		if( positiveDirection )
			maxVoxelPoint = maxVoxelPoint + offsetDir;
		else
			minVoxelPoint = minVoxelPoint + offsetDir;
				
		//Don't let the AABB be bigger than the setting.
		const Point3i maxCellSize = scene.options.getMaxCellSize();
		const Point3i size( maxVoxelPoint.x - minVoxelPoint.x, maxVoxelPoint.y - minVoxelPoint.y, maxVoxelPoint.z - minVoxelPoint.z);

		if( size.x > maxCellSize.x || size.y >  maxCellSize.y || size.z >  maxCellSize.z)
			isNewAABBValid = false;
		else
			isNewAABBValid = tryNewAABB(minVoxelPoint, maxVoxelPoint, dir, voxelContainer, tile); //Try the newly expanded cell
	}

	maxVoxelPoint = lastValidMaxPoint;
	minVoxelPoint = lastValidMinPoint;
}

bool PVSGenerator::tryNewAABB( const Point3i &minVoxelPoint, const  Point3i &maxVoxelPoint, const VoxelContainer::NEIGHBOUR_DIRECTION& expandDirection, const VoxelContainer &voxelContainer, const SceneTile& tile ) const
{
	
	Point3i currentVoxelPoint;
	Point3i fromPoint, toPoint;

	fromPoint = minVoxelPoint;
	toPoint = maxVoxelPoint;

	//Determine the face of the cell that is expanding.
	switch (expandDirection)
	{
	case VoxelContainer::POSITIVE_X:
		fromPoint.x = toPoint.x = maxVoxelPoint.x;
		break;
	case VoxelContainer::NEGATIVE_X:
		fromPoint.x = toPoint.x = minVoxelPoint.x;
		break;
	case VoxelContainer::POSITIVE_Y:
		fromPoint.y = toPoint.y = maxVoxelPoint.y;
		break;
	case VoxelContainer::NEGATIVE_Y:
		fromPoint.y = toPoint.y = minVoxelPoint.y;
		break;
	case VoxelContainer::POSITIVE_Z:
		fromPoint.z = toPoint.z = maxVoxelPoint.z;
		break;
	case VoxelContainer::NEGATIVE_Z:
		fromPoint.z = toPoint.z = minVoxelPoint.z;
		break;
	}

	//Check if the new expanded range goes outside the assigned Tile.
	if( fromPoint.x < tile.getTileFromIndex().x || fromPoint.y < tile.getTileFromIndex().y || fromPoint.z < tile.getTileFromIndex().z ||
		toPoint.x > tile.getTileToIndex().x   || toPoint.y > tile.getTileToIndex().y   || toPoint.z > tile.getTileToIndex().z )
		return false;


	const vector<shared_ptr<Cell>>& tileCells = tile.getCells();

	int x, y, z;
	//Create all the voxel points for that expanding face.
	for (z = fromPoint.z ; z <= toPoint.z ; ++z)
	{
		currentVoxelPoint.z = z;

		for (y = fromPoint.y ; y <= toPoint.y ; ++y)
		{
			currentVoxelPoint.y = y;

			for (x = fromPoint.x ; x <= toPoint.x ; ++x)
			{
				currentVoxelPoint.x = x;
				
				//If at least one voxel is solid, out of scene bounds, out of Tile bounds, or is in another cell, expansion is not valid.
				//TODO: Maybe the bounds check can be done outside the loops
				if( voxelContainer.isPositionOutOfBounds(currentVoxelPoint) == true ||
					voxelContainer.voxelAt(currentVoxelPoint).getStatus() == Voxel::SOLID ||
					isVoxelInsideAnExistingCells(tileCells, currentVoxelPoint) == true )
						return false;
			}
		}
	}

	return true;
}

//Check if a point is already inside of existing collection of cells.
bool PVSGenerator::isVoxelInsideAnExistingCells( const vector<shared_ptr<Cell>>& existingCells, const Point3i& point ) const
{
	
	//TODO: Replace this linear search with something like KD-Tree.
	for ( vector<Cell>::size_type c = 0; c < existingCells.size(); ++c)
	{
		if( isVoxelInsideCell(*(existingCells[c]), point) )
			return true;
	}

	return false;
}


//Check if a point is already inside of existing collection of cells.
void PVSGenerator::getCellFromPoint( const vector<shared_ptr<Cell>>& existingCells, const Point3i& point, int& cellIndex, int startingCell /* = 0*/ ) const
{

	//TODO: replace with a hierarchical algorithm, add KD-Tree here.
	for ( vector<Cell>::size_type c = startingCell; c < existingCells.size(); ++c)
	{
		const Cell& currentCell =  *existingCells[c];

		if( isVoxelInsideCell(currentCell, point) )
		{
			cellIndex = c; //Found cell index.
			return;
		}
	}

	cellIndex = -1; //No cell found.
}

void PVSGenerator::getCellsSharedVoxels(const pair<Cell, Cell> cells, vector<Point3i>& sharedVoxels ) const
{

	vector<Point3i> cellExternalVoxels;

	getCellExternalVoxels(cells.second, cellExternalVoxels);

	for ( vector<Point3i>::size_type p = 0; p < cellExternalVoxels.size(); ++p)
	{
		if( isVoxelInsideCell(cells.first, cellExternalVoxels[p]))
			sharedVoxels.push_back(cellExternalVoxels[p]);
	}

}

//Given two neighbour cells, returns the first cell external voxels that are shared.
void PVSGenerator::getCellsSharedVoxelsOnlyExternals(const pair<Cell, Cell> cells, vector<Point3i>& sharedVoxels ) const
{
	vector<Point3i> cellExternalVoxels;
	
	//Get cell's surrounding voxels.
	//Commented out because we need only the voxels that are in the originating cell.
    getCellExternalVoxels(cells.first, cellExternalVoxels);

	//Only get voxels from the originating cell.
    //For each surrounding voxel of the first cell, see if it is inside other cell.
    for ( vector<Point3i>::size_type p = 0; p < cellExternalVoxels.size(); ++p)
    {
        if( isVoxelInsideCell(cells.second, cellExternalVoxels[p]))
            sharedVoxels.push_back(cellExternalVoxels[p]); //Add to the shared voxels list.
    }

}

//Generate the graph of portals and cells.
void PVSGenerator::buildConectivityGraph( vector<shared_ptr<Cell>>& cells,  vector<shared_ptr<Portal>>& portals, const VoxelContainer& voxelContainer)
{
	

	try 
	{

		//For each cell in the scene
		for ( vector<Cell>::size_type c = 0; c < cells.size(); ++c)
		{
			vector<Point3i> cellExternalVoxels;

			Cell& currentCell = *(cells[c]);

			//For each of the surrounding voxels of the cell.
			getCellExternalVoxels(currentCell, cellExternalVoxels);

			//All the cell external voxels that already constitute a portal.
			vector<Point3i> externalVoxelsAlreadyinPortals;

			//Check if a cell external voxel is inside another cell. 
			//If it is, then they share the same 'border' and can be considered as a portal.
			for ( vector<Point3i>::size_type p = 0; p < cellExternalVoxels.size(); ++p)
			{
		
				//Check if the voxel was already considered for a portal.
				if( std::find(  externalVoxelsAlreadyinPortals.begin(),
								externalVoxelsAlreadyinPortals.end(),
								cellExternalVoxels[p]) != externalVoxelsAlreadyinPortals.end() ) 
					continue;
			

				int cellIndex;
			
				//Get the other cell.
				getCellFromPoint(cells, cellExternalVoxels[p], cellIndex, 0); //TODO: check c + 1

				//If cell found and not the same cell 
				if( cellIndex >= 0 && c != cellIndex)
				{
				
					//Create a cell pair from Current cell and the neighbouring cell found.
					pair<Cell,Cell> cellPairs(currentCell, *cells[cellIndex]);

					//Get the voxels inside the first cell that are shared with the other cell.
					//Does not include the voxels from the other cell.
					vector<Point3i> sharedVoxels;
					getCellsSharedVoxels( cellPairs, sharedVoxels );

					//Now include the voxels from the other cell.
					vector<Point3i> sharedVoxelsExternals;
					getCellsSharedVoxelsOnlyExternals( cellPairs, sharedVoxelsExternals );

					//Add the voxels to the list of already considered voxels so portals don't repeat themselves.
					externalVoxelsAlreadyinPortals.insert(externalVoxelsAlreadyinPortals.end(), sharedVoxelsExternals.begin(), sharedVoxelsExternals.end());

					//Get the min point and max point of the cells shared voxels.
					Point3i minPoint, maxPoint; 
					getMinMaxPointFromVoxels(sharedVoxels, minPoint, maxPoint);

					Point3i facingPlane = getPortalFacingWallPlane(sharedVoxels, minPoint, maxPoint, cellPairs);

					//Create a new portal that communicates current cell with the found cell.
					shared_ptr<Portal> newPortal( new Portal(cells[c], cells[cellIndex], minPoint, maxPoint, facingPlane) );
			

					//Add the portal to the current cell.
					currentCell.addPortal(newPortal);
				}
			}
		}
	}catch( bad_alloc& )
	{
		Logger::Log("Error allocating memory for portal.");
		exit(1);
	}

}

void PVSGenerator::generatePVS( vector<shared_ptr<Cell>>& cells,  vector<shared_ptr<Portal>>& portals, const VoxelContainer& voxelContainer)
{
	
	//Based on Visibility Preprocessing For Interactive Walkthroughs
	//by Seth J. Teller and Carlo H. Séquin
	//University of California at Berkeley
	
	//Build the visibility graph.
	int c;
	int progress = 0;
	vector<Cell>::size_type i;
	int callDepth = 0;
	vector<shared_ptr<Portal>> portalSequence;
	vector<shared_ptr<Cell>> CellVisibleSet;
	int chunk = cells.size() / omp_get_max_threads();

	#pragma omp parallel for private(c, i, callDepth, portalSequence, CellVisibleSet) shared(cells, portals, voxelContainer, progress)
	for ( c = 0; c < (int) cells.size(); ++c)
	{
			
		portalSequence.clear();
		CellVisibleSet.clear();

		callDepth = 0;
		findVisibleCells(cells[c], portalSequence, CellVisibleSet, voxelContainer, callDepth);

		//Critical section in cells... although accessing cells[c]-> is not..
		#pragma omp critical
		{

			//sort and erase duplicates
			std::sort( CellVisibleSet.begin(), CellVisibleSet.end() );
			CellVisibleSet.erase( std::unique( CellVisibleSet.begin(), CellVisibleSet.end() ), CellVisibleSet.end() );

			assert( CellVisibleSet.size() <= cells.size() );

			//Add the visibility set to the cell.
			for ( i = 0; i < CellVisibleSet.size(); ++i)
			{
				cells[c]->addVisibleCell( CellVisibleSet[i] );
			}
			
			//Track visibility progress and log it.
			progress++;
			if( progress % ( (cells.size() / 10)  + 1) == 0 ) //Show 10% increments.
			{
				std::stringstream str;
				str << "PVS%: " << ((float) progress / cells.size()) * 100.0f;
				Logger::Log( str.str() );
			}
		}
	}

	
}
//gets all the external voxels surrounding a cells.
void PVSGenerator::getCellExternalVoxels( const Cell& cell, vector<Point3i>& points ) const
{
	Point3i currentVoxelPoint;
	Point3i fromPoint, toPoint;

	//For each face of the cell, find the external voxels.
	for (int faceNum = 0 ; faceNum < 6 ; ++faceNum)
	{

		fromPoint = cell.minPoint;
		toPoint = cell.maxPoint;

		//Each face has a fixed dimension
		switch (faceNum)
		{
		case 0: //(1,0,0) fixed maximum x of the cell plus 1.
			fromPoint.x = toPoint.x = cell.maxPoint.x + 1;
			break;
		case 1: //(-1,0,0)
			fromPoint.x = toPoint.x = cell.minPoint.x - 1;
			break;
		case 2: //(0,1,0)
			fromPoint.y = toPoint.y = cell.maxPoint.y + 1;
			break;
		case 3://(0,-1,0)
			fromPoint.y = toPoint.y = cell.minPoint.y - 1;
			break;
		case 4://(0,0,1)
			fromPoint.z = toPoint.z = cell.maxPoint.z + 1;
			break;
		case 5://(0,0,-1)
			fromPoint.z = toPoint.z = cell.minPoint.z - 1;
			break;
		}

		int x, y, z;
		//Create all the voxel points for that face.
		for (z = fromPoint.z ; z <= toPoint.z ; ++z)
		{
			currentVoxelPoint.z = z;

			for (y = fromPoint.y ; y <= toPoint.y ; ++y)
			{
				currentVoxelPoint.y = y;

				for (x = fromPoint.x ; x <= toPoint.x ; ++x)
				{
					currentVoxelPoint.x = x;

					//Check if out of bounds.
					if( m_voxelContainer->isPositionOutOfBounds( currentVoxelPoint ) == false)
						points.push_back(currentVoxelPoint); //Valid point.
				}
			}
		}
	}

}

bool PVSGenerator::isVoxelInsideCell( const Cell& cell, const Point3i& point ) const
{
	return ( 
		point.x >= cell.minPoint.x && point.x <= cell.maxPoint.x &&
		point.y >= cell.minPoint.y && point.y <= cell.maxPoint.y &&
		point.z >= cell.minPoint.z && point.z <= cell.maxPoint.z );
}

void PVSGenerator::getMinMaxPointFromVoxels( const vector<Point3i> voxels, Point3i& minPoint, Point3i& maxPoint ) const
{

	if( voxels.empty())
		throw logic_error("Empty voxel list.");

	minPoint = maxPoint = voxels[0];

	for( vector<Point3i>::size_type p = 0; p < voxels.size(); ++p)
	{
		Point3i voxelPoint = voxels[p];

		minPoint.x = min(minPoint.x, voxelPoint.x);
		minPoint.y = min(minPoint.y, voxelPoint.y);
		minPoint.z = min(minPoint.z, voxelPoint.z);

		maxPoint.x = max(maxPoint.x, voxelPoint.x);
		maxPoint.y = max(maxPoint.y, voxelPoint.y);
		maxPoint.z = max(maxPoint.z, voxelPoint.z);
	}
}


Point3i PVSGenerator::getPortalFacingWallPlane( const vector<Point3i> voxels, const Point3i& minPoint, const Point3i& maxPoint, const pair<Cell, Cell>& cellPairs ) const
{

	
	const Point3i positionOffsets = maxPoint - minPoint;
	Point3i newPoint;

	//Take the min point (can be max point as well) and see if it neighbours with the other cell.

		newPoint = minPoint;
		newPoint.x++;
		if( isVoxelInsideCell( cellPairs.second, newPoint) ) //Move one coordinate to the right and test against the other cell.
			return Point3i(1,0,0);

		newPoint = minPoint;
		newPoint.x--;
		if( isVoxelInsideCell( cellPairs.second, newPoint) ) //Move one coordinate to the left and test against the other cell.
			return Point3i(-1,0,0);

		newPoint = minPoint;
		newPoint.y++;
		if( isVoxelInsideCell( cellPairs.second, newPoint) ) //Move one coordinate up and test against the other cell.
			return Point3i(0,1,0);

		newPoint = minPoint;
		newPoint.y--;
		if( isVoxelInsideCell( cellPairs.second, newPoint) ) //Move one coordinate down and test against the other cell.
			return Point3i(0,-1,0);

		newPoint = minPoint;
		newPoint.z++;
		if( isVoxelInsideCell( cellPairs.second, newPoint) ) //Move one coordinate back and test against the other cell.
			return Point3i(0,0,1);

		newPoint = minPoint;
		newPoint.z--;
		if( isVoxelInsideCell( cellPairs.second, newPoint) ) //Move one coordinate front and test against the other cell.
			return Point3i(0,0,-1);

		//Shouldn't get here.
		throw new logic_error("Wrong portal shared cells.");
		
}



void PVSGenerator::findVisibleCells(const shared_ptr<Cell>& startingCell, vector<shared_ptr<Portal>>& portalSequence, vector<shared_ptr<Cell>>& visibleCellSet, const VoxelContainer& voxelContainer, int &callDepth)
{

	callDepth++;

	//To stop stack overflow.
	if( callDepth > MAX_STACK_DEPTH )
		throw new logic_error("out of stack");

	//The starting cell is itself visible.
	visibleCellSet.push_back(startingCell);


	const vector<shared_ptr<Portal>>& neighbourPortals = startingCell->getPortals();

	//Get the list of cells that connect to the starting cell.
	for(vector<shared_ptr<Portal>>::size_type c = 0 ; c < neighbourPortals.size(); ++c)
	{

		shared_ptr<Portal> nPortal = neighbourPortals[c];

		//The other cell.
		shared_ptr<Cell> nCell = nPortal->toCell;

		//Not in the already visible set.
		if( std::find(visibleCellSet.begin(), visibleCellSet.end(), nCell) != visibleCellSet.end() )
			continue;

		#ifdef _DEBUG
			//Assert that it connects the two cells.
			assert( nPortal->fromCell == startingCell && nPortal->toCell == nCell );
		#endif

		portalSequence.push_back( nPortal );

		if( stabbingLineExists(startingCell, portalSequence, nPortal, voxelContainer) )
			findVisibleCells(nCell, portalSequence, visibleCellSet, voxelContainer, callDepth); //recursive call
			
		portalSequence.pop_back();
	}

}				

bool PVSGenerator::portalSequenceContainsCoplanarPortals( const vector<PortalQuad>& portalQuads ) const
{

	Vector3f v1, v2, normal;
	
	int pointsInPlane;

	//Try all the portal combinations.
	for( unsigned int c = 0 ; c < portalQuads.size() - 1; ++c)
	{

		const PortalQuad& quad = portalQuads[c];

		v1 = quad.points[0] - quad.points[1];
		v2 = quad.points[1] - quad.points[2];
		normal = v1.Cross(v2);
		normal.Normalize();

		float planeD = -normal.Dot(quad.points[0]);

		for( unsigned int d = c + 1 ; d < portalQuads.size() ; ++d)
		{
			pointsInPlane = 0;

			//Test the four points
			for( int i = 0 ; i < 4 ; i++ )
			{
				if( fabs( normal.Dot(portalQuads[d].points[i]) + planeD ) <= PLANE_EPSILON )
					pointsInPlane++;
			}

			//If at least 3 points of another portal are contained in the plane of the other, then are coplanar.
			if( pointsInPlane >= 3 )
				return true;

		}

	}

	return false;
}

bool PVSGenerator::stabbingLineExists(const shared_ptr<Cell>& cell, const vector<shared_ptr<Portal>>& portalSequence, const shared_ptr<Portal>& nPortal, const VoxelContainer& voxelContainer) const
{

	if( portalSequence.size() <= 1)
		return true;

	if( portalSequence.size() > MAX_PORTAL_SEQUENCE ) //If for any reason enters in a cycle...
		return false;

	vector<PortalQuad> portalQuads;
	portalQuads.reserve(portalSequence.size());

	for(unsigned int p = 0 ; p < portalSequence.size() ; ++p)
	{
		//Get all the portal quads in the sequence.
		portalQuads.push_back( getPortalRectangle( *portalSequence[p], voxelContainer.getVoxelSize() ));
	}

	//If at least two pairs of portals are coplanar no ray could possibly pass through the sequence.
	if( portalSequenceContainsCoplanarPortals( portalQuads ) == true )
		return false;

	return StabbingLine::StabbingLineBetweenPortalsExist( portalQuads );
}

//Given a portal returns the rectangle that is shared between the two cells.
//The rectangle is always axis aligned, planar.
PortalQuad PVSGenerator::getPortalRectangle(const Portal& portal, const Vector3f& voxelSize) const
{

	Vector3f minPoint, maxPoint;
	
	minPoint = Vector3f(static_cast<float>(portal.minPoint.x), static_cast<float>(portal.minPoint.y), static_cast<float>(portal.minPoint.z));
	maxPoint = Vector3f(static_cast<float>(portal.maxPoint.x), static_cast<float>(portal.maxPoint.y), static_cast<float>(portal.maxPoint.z));

	const Vector3f halfVoxelSize = 0.5f * voxelSize;

	
	minPoint *= voxelSize;
	maxPoint *= voxelSize;

	//Move the position to the middle of the voxel
	minPoint += halfVoxelSize;
	maxPoint += halfVoxelSize;


	//If the portal is facing into one direction, move towards that face of the voxel.
	minPoint.x += halfVoxelSize.x * portal.facingPlane.x;
	minPoint.y += halfVoxelSize.y * portal.facingPlane.y;
	minPoint.z += halfVoxelSize.z * portal.facingPlane.z;
	
	maxPoint.x += halfVoxelSize.x * portal.facingPlane.x;
	maxPoint.y += halfVoxelSize.y * portal.facingPlane.y;
	maxPoint.z += halfVoxelSize.z * portal.facingPlane.z;
	
	//Move half voxel for the extreme points.
	if( portal.facingPlane.x == 0 )
	{
		minPoint.x -= halfVoxelSize.x;
		maxPoint.x += halfVoxelSize.x;
	}

	if( portal.facingPlane.y == 0 )
	{
		minPoint.y -= halfVoxelSize.y;
		maxPoint.y += halfVoxelSize.y;
	}

	if( portal.facingPlane.z == 0 )
	{
		minPoint.z -= halfVoxelSize.z;
		maxPoint.z += halfVoxelSize.z;
	}

	const Vector3f rectangleSize = maxPoint - minPoint;

	Vector3f portalQuadPoints[4];
	
	//Define the diagonal, that indicates the max and min points of the quad
	portalQuadPoints[0] = minPoint;
	portalQuadPoints[2] = maxPoint;

	//Given the two extreme points, calculate the other two points that make a quad.
	//They have to be counter clock wise respect of the facing normal.


	portalQuadPoints[1] = minPoint;
	portalQuadPoints[3] = minPoint;

	//+X
	if( portal.facingPlane.x > 0 )
	{
		portalQuadPoints[1].z += rectangleSize.z;
		portalQuadPoints[3].y += rectangleSize.y;
	}

	//-X
	if( portal.facingPlane.x < 0 )
	{
		portalQuadPoints[1].y += rectangleSize.y;
		portalQuadPoints[3].z += rectangleSize.z;
	}

	//+Y
	if( portal.facingPlane.y > 0 )
	{
		portalQuadPoints[1].x += rectangleSize.x;
		portalQuadPoints[3].z += rectangleSize.z;
	}
	
	//-Y
	if( portal.facingPlane.y < 0 )
	{
		portalQuadPoints[1].z += rectangleSize.z;
		portalQuadPoints[3].x += rectangleSize.x;
	}
		
	//+Z
	if( portal.facingPlane.z > 0 )
	{
		portalQuadPoints[1].y += rectangleSize.y;
		portalQuadPoints[3].x += rectangleSize.x;
	}

	//-Z
	if( portal.facingPlane.z < 0 )
	{
		portalQuadPoints[1].x += rectangleSize.x;
		portalQuadPoints[3].y += rectangleSize.y;
	}


	return PortalQuad( portalQuadPoints );
}


vector<Vector3f> PVSGenerator::getAllSolidVoxelPositionsInWorldSpace() const
{
	if( m_voxelContainer->getAllSolidVoxelsCount() == 0 )
		return vector<Vector3f>();
	else	
		return m_voxelContainer->getAllSolidVoxelPositionsInWorldSpace(m_SceneAABB);
}
