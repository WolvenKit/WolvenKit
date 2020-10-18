#ifndef __C_TERRAIN_SCENE_NODE_WOLVENKIT_H__
#define __C_TERRAIN_SCENE_NODE_WOLVENKIT_H__

#include "CTerrainSceneNode.h"
#include "IDynamicMeshBuffer.h"
#include "path.h"

namespace irr
{
namespace io
{
	class IFileSystem;
	class IReadFile;
}
namespace scene
{
	struct SMesh;
	class ITextSceneNode;

	//! A scene node for displaying terrain using the geo mip map algorithm.
	class CTerrainSceneNodeWolvenKit : public CTerrainSceneNode
	{
	public:

		//! constructor
		//! \param parent: The node which this node is a child of.  Making this node a child of another node, or
		//! making it a parent of another node is yet untested and most likely does not work properly.
		//! \param mgr: Pointer to the scene manager.
		//! \param id: The id of the node
		//! \param maxLOD: The maximum LOD ( Level of Detail ) for the node.
		//! \param patchSize: An E_GEOMIPMAP_PATCH_SIZE enumeration defining the size of each patch of the terrain.
		//! \param position: The absolute position of this node.
		//! \param rotation: The absolute rotation of this node. ( NOT YET IMPLEMENTED )
		//! \param scale: The scale factor for the terrain.  If you're using a heightmap of size 128x128 and would like
		//! your terrain to be 12800x12800 in game units, then use a scale factor of ( core::vector ( 100.0f, 100.0f, 100.0f ).
		//! If you use a Y scaling factor of 0.0f, then your terrain will be flat.
		CTerrainSceneNodeWolvenKit(ISceneNode* parent, ISceneManager* mgr, io::IFileSystem* fs, s32 id,
			s32 maxLOD = 4, E_TERRAIN_PATCH_SIZE patchSize = ETPS_17,
			const core::vector3df& position = core::vector3df(0.0f, 0.0f, 0.0f),
			const core::vector3df& rotation = core::vector3df(0.0f, 0.0f, 0.0f),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f));

		~CTerrainSceneNodeWolvenKit();

		//! Initializes the terrain data.  Loads the vertices from the heightMapFile.
		bool loadHeightMap(io::IReadFile* file, s32 dimension,
			f32 maxHeight, f32 minHeight, float tileSize, const core::vector3df& anchor) _IRR_OVERRIDE_;
	};


} // end namespace scene
} // end namespace irr

#endif // __C_TERRAIN_SCENE_NODE_WOLVENKIT_H__


