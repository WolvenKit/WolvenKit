// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

// The code for the TerrainSceneNode is based on the GeoMipMapSceneNode
// developed by Spintz. He made it available for Irrlicht and allowed it to be
// distributed under this licence. I only modified some parts. A lot of thanks
// go to him.

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_TERRAIN_SCENENODE_

#include "CTerrainSceneNodeWolvenKit.h"
#include "IVideoDriver.h"
#include "ISceneManager.h"
#include "irrMath.h"
#include "os.h"
#include "IFileSystem.h"
#include "IReadFile.h"
#include "ITextSceneNode.h"
#include "IAnimatedMesh.h"
#include "SMesh.h"
#include "CDynamicMeshBuffer.h"
#include "debug.h"

namespace irr
{
namespace scene
{

	//! constructor
	CTerrainSceneNodeWolvenKit::CTerrainSceneNodeWolvenKit(ISceneNode* parent, ISceneManager* mgr,
			io::IFileSystem* fs, s32 id, s32 maxLOD, E_TERRAIN_PATCH_SIZE patchSize,
			const core::vector3df& position,
			const core::vector3df& rotation,
			const core::vector3df& scale)
	: CTerrainSceneNode(parent, mgr, fs, id, maxLOD, patchSize, position, rotation, scale)
	{
		UseDefaultRotationPivot = false;

		#ifdef _DEBUG
		setDebugName("CTerrainSceneNodeWolvenKit");
		#endif
	}


	//! destructor
	CTerrainSceneNodeWolvenKit::~CTerrainSceneNodeWolvenKit()
	{
	}


	//! Initializes the terrain data. Loads the vertices from the heightMapFile
	bool CTerrainSceneNodeWolvenKit::loadHeightMap(io::IReadFile* file, s32 dimension,
		f32 maxHeight, f32 minHeight, float tileSize, const core::vector3df& anchor)
	{
		if (!file)
			return false;

		Mesh->MeshBuffers.clear();

		//-----------------------------------
		const u32 startTime = os::Timer::getRealTime();
		//-----------------------------------

		f32 heightScale = maxHeight - minHeight;
		u16* bytes = DBG_NEW u16[dimension * dimension];

		file->read(bytes, dimension * dimension * sizeof(u16));

		HeightmapFile = file->getFileName();

		// Get the dimension of the heightmap data
		TerrainData.Size = dimension;

		switch (TerrainData.PatchSize)
		{
		case ETPS_9:
			if (TerrainData.MaxLOD > 3)
			{
				TerrainData.MaxLOD = 3;
			}
			break;
		case ETPS_17:
			if (TerrainData.MaxLOD > 4)
			{
				TerrainData.MaxLOD = 4;
			}
			break;
		case ETPS_33:
			if (TerrainData.MaxLOD > 5)
			{
				TerrainData.MaxLOD = 5;
			}
			break;
		case ETPS_65:
			if (TerrainData.MaxLOD > 6)
			{
				TerrainData.MaxLOD = 6;
			}
			break;
		case ETPS_129:
			if (TerrainData.MaxLOD > 7)
			{
				TerrainData.MaxLOD = 7;
			}
			break;
		}

		// --- Generate vertex data from heightmap ----
		// resize the vertex array for the mesh buffer one time (makes loading faster)
		scene::CDynamicMeshBuffer* mb = 0;

		const u32 numVertices = TerrainData.Size * TerrainData.Size;
		if (numVertices <= 65536)
		{
			//small enough for 16bit buffers
			mb = DBG_NEW scene::CDynamicMeshBuffer(video::EVT_2TCOORDS, video::EIT_16BIT);
			RenderBuffer->getIndexBuffer().setType(video::EIT_16BIT);
		}
		else
		{
			//we need 32bit buffers
			mb = DBG_NEW scene::CDynamicMeshBuffer(video::EVT_2TCOORDS, video::EIT_32BIT);
			RenderBuffer->getIndexBuffer().setType(video::EIT_32BIT);
		}

		mb->getVertexBuffer().set_used(numVertices);

        s32 index = 0;
        f32 currY = anchor.Y;
		f32 stepSize = tileSize / dimension;
        f32 tdSize = 1.0f / (f32)(dimension - 1);
		u16* val = bytes;

        s32 r = 0;
        s32 g = 0;
        s32 b = 0;

		f32 dv = 0.0f;

		for (s32 y = 0; y < TerrainData.Size; ++y)
		{
			f32 currX = anchor.X;
			f32 du = 0.0f;

			for (s32 x = 0; x < TerrainData.Size; ++x)
			{
                f32 hN = (f32)(*val++ / 65535.0f);
                f32 h = hN * heightScale + minHeight;

                if (h < 0.0f)
                {
                    r = 0;
                    g = 0;
                    b = (s32)(h / minHeight * 255);
                }
                else
                {
                    r = (s32)(h / maxHeight * 255);
                    g = r;
                    b = r;
                }

                video::S3DVertex2TCoords& vertex = static_cast<video::S3DVertex2TCoords*>(mb->getVertexBuffer().pointer())[index++];
                vertex.Normal.set(0.0f, 0.0f, 1.0f);
                vertex.Color.set(255, r, g, b);
                vertex.Pos.X = -currX;
                vertex.Pos.Y = currY;
                vertex.Pos.Z = h;

                vertex.TCoords.X = vertex.TCoords2.X = 1.f - du;
                vertex.TCoords.Y = vertex.TCoords2.Y = dv;

				currX += stepSize;
				du += tdSize;
			}

			currY += stepSize;
			dv += tdSize;
		}

		// calculate smooth normals for the vertices
		//calculateNormals(mb);

		// add the MeshBuffer to the mesh
		Mesh->addMeshBuffer(mb);

		// We copy the data to the renderBuffer, after the normals have been calculated.
		RenderBuffer->getVertexBuffer().set_used(numVertices);

		for (u32 i = 0; i < numVertices; ++i)
		{
			RenderBuffer->getVertexBuffer()[i] = mb->getVertexBuffer()[i];
			//RenderBuffer->getVertexBuffer()[i].Pos *= TerrainData.Scale;
			//RenderBuffer->getVertexBuffer()[i].Pos += TerrainData.Position;
		}

		// We no longer need the mb
		mb->drop();

		// calculate all the necessary data for the patches and the terrain
		calculateDistanceThresholds();
		createPatches();
		calculatePatchData();

		// Pre-allocate memory for indices

		RenderBuffer->getIndexBuffer().set_used(
				TerrainData.PatchCount * TerrainData.PatchCount *
				TerrainData.CalcPatchSize * TerrainData.CalcPatchSize * 6);

		RenderBuffer->setDirty();

        delete[] bytes;

		//-----------------------------------
		const u32 endTime = os::Timer::getRealTime();

		c8 tmp[255];
		snprintf_irr(tmp, 255, "Generated terrain data (%dx%d) in %.4f seconds",
			TerrainData.Size, TerrainData.Size, (endTime - startTime) / 1000.0f );
		os::Printer::log(tmp);
		//-----------------------------------

		return true;
	}


} // end namespace scene
} // end namespace irr

#endif // _IRR_COMPILE_WITH_TERRAIN_SCENENODE_
