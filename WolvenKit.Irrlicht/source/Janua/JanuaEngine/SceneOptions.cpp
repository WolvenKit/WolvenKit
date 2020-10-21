#include "SceneOptions.h"
#include <stdexcept>

using std::logic_error;

#define DEFAULT_TILE_SIZE 10

namespace Janua
{
	SceneOptions::SceneOptions()
	{
		m_voxelSize = Vector3f(DEFAULT_TILE_SIZE / 10, DEFAULT_TILE_SIZE / 10, DEFAULT_TILE_SIZE / 10);
		m_maxCellSize = Point3i(INT_MAX, INT_MAX, INT_MAX);
		m_sceneTileSize = Point3i(DEFAULT_TILE_SIZE, DEFAULT_TILE_SIZE, DEFAULT_TILE_SIZE);
	}


	void SceneOptions::setVoxelSize(float sizeX, float sizeY, float sizeZ)
	{
		if (sizeX <= 0 && sizeY <= 0 && sizeZ <= 0)
			throw new std::invalid_argument("Max cell size cannot be zero or less in any dimension");

		m_voxelSize = Vector3f(sizeX, sizeY, sizeZ);
	}

	void SceneOptions::setMaxCellSize(int sizeX, int sizeY, int sizeZ)
	{
		if (sizeX <= 0 && sizeY <= 0 && sizeZ <= 0)
			throw new logic_error("Max cell size cannot be zero or less in any dimension");

		m_maxCellSize = Point3i(sizeX, sizeY, sizeZ);
	}

	void SceneOptions::setSceneTileSize(int sizeX, int sizeY, int sizeZ)
	{
		if (sizeX <= 0 && sizeY <= 0 && sizeZ <= 0)
			throw new logic_error("The scene tile size cannot be zero or less in any dimension");

		m_sceneTileSize = Point3i(sizeX, sizeY, sizeZ);
	}

	SceneOptions::~SceneOptions(void)
	{
	}
}
