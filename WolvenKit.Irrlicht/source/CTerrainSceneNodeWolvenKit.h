#ifndef __C_TERRAIN_SCENE_NODE_WOLVENKIT_H__
#define __C_TERRAIN_SCENE_NODE_WOLVENKIT_H__

#include "ITerrainSceneNodeWolvenKit.h"
#include "SMesh.h"

namespace irr
{
namespace io
{
	class IReadFile;
}
namespace scene
{
	class CTerrainSceneNodeWolvenKit : public ITerrainSceneNodeWolvenKit
	{
	public:

		//! constructor
		//! \param parent: The node which this node is a child of.
		//! \param id: The id of the node
		CTerrainSceneNodeWolvenKit(ISceneNode* parent, ISceneManager* mgr, s32 id,
			const core::vector3df& position = core::vector3df(0.0f, 0.0f, 0.0f),
			const core::vector3df& rotation = core::vector3df(0.0f, 0.0f, 0.0f),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f));

		~CTerrainSceneNodeWolvenKit();

		IMesh* getMesh() _IRR_OVERRIDE_;
		void render() _IRR_OVERRIDE_;
		const core::aabbox3d<f32>& getBoundingBox() const _IRR_OVERRIDE_;
		void OnRegisterSceneNode() _IRR_OVERRIDE_;

		//! Initializes the terrain data.  Loads the vertices from the heightMapFile.
		bool loadHeightMap(io::IReadFile* file, s32 dimension,
			f32 maxHeight, f32 minHeight, f32 tileSize);

	private:
		SMesh* Mesh;
	};


} // end namespace scene
} // end namespace irr

#endif // __C_TERRAIN_SCENE_NODE_WOLVENKIT_H__


