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
#include "irrMath.h"
#include "os.h"
#include "IReadFile.h"
#include "ISceneManager.h"
#include "debug.h"
#include "CDynamicMeshBuffer.h"

namespace irr
{
namespace scene
{

	//! constructor
	CTerrainSceneNodeWolvenKit::CTerrainSceneNodeWolvenKit(ISceneNode* parent, ISceneManager* mgr, s32 id,
            const core::vector3df& position, const core::vector3df& rotation, const core::vector3df& scale)
        : ITerrainSceneNodeWolvenKit(parent, mgr, id, position, rotation, scale)
	{
		#ifdef _DEBUG
		setDebugName("CTerrainSceneNodeWolvenKit");
		#endif
	}


	//! destructor
	CTerrainSceneNodeWolvenKit::~CTerrainSceneNodeWolvenKit()
	{
	}

    IMesh* CTerrainSceneNodeWolvenKit::getMesh() { return Mesh; }

    void CTerrainSceneNodeWolvenKit::OnRegisterSceneNode()
    {
        if (!IsVisible || !SceneManager->getActiveCamera())
            return;

        SceneManager->registerNodeForRendering(this);

        //ISceneNode::OnRegisterSceneNode();
    }

    void CTerrainSceneNodeWolvenKit::render()
    {
        video::IVideoDriver* driver = SceneManager->getVideoDriver();

        if (!Mesh || !driver)
            return;

        //driver->setTransform(video::ETS_WORLD, AbsoluteTransformation);

        scene::IMeshBuffer* mb = Mesh->getMeshBuffer(0);
        driver->drawMeshBuffer(mb);
    }

    const core::aabbox3d<f32>& CTerrainSceneNodeWolvenKit::getBoundingBox() const
    {
        return Mesh->getBoundingBox();
    }

	//! Initializes the terrain data. Loads the vertices from the heightMapFile
	bool CTerrainSceneNodeWolvenKit::loadHeightMap(io::IReadFile* file, s32 dimension,
		f32 maxHeight, f32 minHeight, f32 tileSize, const core::vector3df& anchor)
	{
		if (!file)
			return false;

		Mesh = DBG_NEW scene::SMesh();

		//-----------------------------------
		const u32 startTime = os::Timer::getRealTime();
		//-----------------------------------

		f32 heightScale = maxHeight - minHeight;
		u16* bytes = DBG_NEW u16[dimension * dimension];

		file->read(bytes, dimension * dimension * sizeof(u16));


		// --- Generate vertex data from heightmap ----
		// resize the vertex array for the mesh buffer one time (makes loading faster)


		//we need 32bit buffers
		scene::CDynamicMeshBuffer* mb = DBG_NEW scene::CDynamicMeshBuffer(video::E_VERTEX_TYPE::EVT_STANDARD, video::EIT_32BIT);

        const u32 numVertices = dimension * dimension;
        mb->getVertexBuffer().set_used(numVertices);

        const u32 nIndices = (dimension - 1) * (dimension * 2) + (dimension - 2) * 2;
        mb->getIndexBuffer().set_used(nIndices);

        s32 index = 0;
        f32 currY = anchor.Y;
		f32 stepSize = tileSize / dimension;
		u16* val = bytes;

        s32 r = 0;
        s32 g = 0;
        s32 b = 0;

        scene::IVertexBuffer& vb = mb->getVertexBuffer();
        vb.setHardwareMappingHint(EHM_STATIC);

		for (s32 y = 0; y < dimension; ++y)
		{
			f32 currX = anchor.X;

			for (s32 x = 0; x < dimension; ++x)
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

                video::S3DVertex& vertex = static_cast<video::S3DVertex*>(vb.pointer())[index++];
                vertex.Normal.set(0.0f, 0.0f, 1.0f);
                vertex.Color.set(255, r, g, b);
                vertex.Pos.X = -currX;
                vertex.Pos.Y = currY;
                vertex.Pos.Z = h;

				currX += stepSize;
			}

			currY += stepSize;
		}

        // create faces
        index = 0;
        s32 row0Index = 0;
        s32 row1Index = dimension;

        scene::IIndexBuffer& ib = mb->getIndexBuffer();

        for (s32 z = 0; z < dimension - 2; ++z)
        {
            // do two rows at a time to make a triangle strip
            for (s32 x = 0; x < dimension; ++x)
            {
                ib.setValue(index++, row0Index++);
                ib.setValue(index++, row1Index++);
            }

            // add degenerate triangle to get to next row
            ib.setValue(index++, row1Index - 1);
            ib.setValue(index++, row0Index);
        }

        // do two rows at a time to make a triangle strip
        for (int x = 0; x < dimension; ++x)
        {
            ib.setValue(index++, row0Index++);
            ib.setValue(index++, row1Index++);
        }

        ib.setHardwareMappingHint(EHM_STATIC);
        mb->setPrimitiveType(EPT_TRIANGLE_STRIP);
        
        //calculateNormals(mb);

		// add the MeshBuffer to the mesh
		Mesh->addMeshBuffer(mb);

        irr::core::aabbox3df bounds(-anchor.X, anchor.Y, minHeight, -(anchor.X + tileSize), anchor.Y + tileSize, maxHeight);
        Mesh->setBoundingBox(bounds);

		// We no longer need the mb
		mb->drop();

        delete[] bytes;

		//-----------------------------------
		const u32 endTime = os::Timer::getRealTime();

		c8 tmp[255];
		snprintf_irr(tmp, 255, "Generated terrain data (%dx%d) in %.4f seconds",
			dimension, dimension, (endTime - startTime) / 1000.0f );
		os::Printer::log(tmp);
		//-----------------------------------

		return true;
	}


} // end namespace scene
} // end namespace irr

#endif // _IRR_COMPILE_WITH_TERRAIN_SCENENODE_
