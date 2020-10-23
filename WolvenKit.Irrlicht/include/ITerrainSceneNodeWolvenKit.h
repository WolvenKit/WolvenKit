// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

// The code for the TerrainSceneNode is based on the terrain renderer by
// Soconne and the GeoMipMapSceneNode developed by Spintz. They made their
// code available for Irrlicht and allowed it to be distributed under this
// licence. I only modified some parts. A lot of thanks go to them.

#ifndef __I_TERRAIN_SCENE_NODE_WOLVENKIT_H__
#define __I_TERRAIN_SCENE_NODE_WOLVENKIT_H__

#include "ETerrainElements.h"
#include "ISceneNode.h"
#include "IDynamicMeshBuffer.h"
#include "irrArray.h"

namespace irr
{
namespace io
{
	class IReadFile;
} // end namespace io
namespace scene
{
	class IMesh;

	//! A scene node for displaying terrain using the geo mip map algorithm.
	/** The code for the TerrainSceneNode is based on the Terrain renderer by Soconne and
	 * the GeoMipMapSceneNode developed by Spintz. They made their code available for Irrlicht
	 * and allowed it to be distributed under this licence. I only modified some parts.
	 * A lot of thanks go to them.
	 *
	 * This scene node is capable of very quickly loading
	 * terrains and updating the indices at runtime to enable viewing very large terrains. It uses a
	 * CLOD (Continuous Level of Detail) algorithm which updates the indices for each patch based on
	 * a LOD (Level of Detail) which is determined based on a patch's distance from the camera.
	 *
	 * The Patch Size of the terrain must always be a size of ( 2^N+1, i.e. 8+1(9), 16+1(17), etc. ).
	 * The MaxLOD available is directly dependent on the patch size of the terrain. LOD 0 contains all
	 * of the indices to draw all the triangles at the max detail for a patch. As each LOD goes up by 1
	 * the step taken, in generating indices increases by - 2^LOD, so for LOD 1, the step taken is 2, for
	 * LOD 2, the step taken is 4, LOD 3 - 8, etc. The step can be no larger than the size of the patch,
	 * so having a LOD of 8, with a patch size of 17, is asking the algorithm to generate indices every
	 * 2^8 ( 256 ) vertices, which is not possible with a patch size of 17. The maximum LOD for a patch
	 * size of 17 is 2^4 ( 16 ). So, with a MaxLOD of 5, you'll have LOD 0 ( full detail ), LOD 1 ( every
	 * 2 vertices ), LOD 2 ( every 4 vertices ), LOD 3 ( every 8 vertices ) and LOD 4 ( every 16 vertices ).
	 **/
	class ITerrainSceneNodeWolvenKit : public ISceneNode
	{
	public:
		//! Constructor
		ITerrainSceneNodeWolvenKit(ISceneNode* parent, ISceneManager* mgr, s32 id,
			const core::vector3df& position = core::vector3df(0.0f, 0.0f, 0.0f),
			const core::vector3df& rotation = core::vector3df(0.0f, 0.0f, 0.0f),
			const core::vector3df& scale = core::vector3df(1.0f, 1.0f, 1.0f) )
			: ISceneNode (parent, mgr, id, position, rotation, scale) {}

		//! Get the bounding box of the terrain.
		/** \return The bounding box of the entire terrain. */
		virtual const core::aabbox3d<f32>& getBoundingBox() const =0;

        //! Get pointer to the mesh
        /** \return Pointer to the mesh. */
        virtual IMesh* getMesh() = 0;

		virtual bool loadHeightMap(io::IReadFile* file,
			s32 dimension, f32 maxHeight, f32 minHeight, f32 tileSize) =0;


	};

} // end namespace scene
} // end namespace irr


#endif // __I_TERRAIN_SCENE_NODE_WOLVENKIT_H__

