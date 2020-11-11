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
#include "CDynamicMeshBuffer.h"
#include "debug.h"

inline float lerp(float a, float b, float t)
{
    return a + t * (b - a);
}

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
        if (Mesh)
            Mesh->drop();
	}

    IMesh* CTerrainSceneNodeWolvenKit::getMesh() { return Mesh; }

    void CTerrainSceneNodeWolvenKit::OnRegisterSceneNode()
    {
        if (!IsVisible || !SceneManager->getActiveCamera())
            return;

        SceneManager->registerNodeForRendering(this);
    }

    void CTerrainSceneNodeWolvenKit::render()
    {
        video::IVideoDriver* driver = SceneManager->getVideoDriver();

        if (!Mesh || !driver)
            return;

        driver->setTransform(video::ETS_WORLD, AbsoluteTransformation);

        video::SMaterial m;
        m.Lighting = false;
        m.AntiAliasing = 1;
        driver->setMaterial(m);

        scene::IMeshBuffer* mb = Mesh->getMeshBuffer(0);
        driver->drawMeshBuffer(mb);
    }

    const core::aabbox3d<f32>& CTerrainSceneNodeWolvenKit::getBoundingBox() const
    {
        return Mesh->getBoundingBox();
    }

	//! Initializes the terrain data. Loads the vertices from the heightMapFile
	bool CTerrainSceneNodeWolvenKit::loadHeightMap(io::IReadFile* file, u32 dimension,
		f32 maxHeight, f32 minHeight, f32 tileSize)
	{
		if (!file)
			return false;

		Mesh = DBG_NEW scene::SMesh();

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
        f32 currY = 0.0f;
        f32 stepSize = tileSize / dimension;
		u16* val = bytes;

        u32 r = 0;
        u32 g = 0;
        u32 b = 0;

        scene::IVertexBuffer& vb = mb->getVertexBuffer();
        vb.setHardwareMappingHint(EHM_STATIC);

        f32 minZ = 1.0E9f;
        f32 maxZ = -1.0E9f;

		for (u32 y = 0; y < dimension; ++y)
		{
            f32 currX = 0.0f;

			for (u32 x = 0; x < dimension; ++x)
			{
                f32 hN = (f32)(*val++ / 65535.0f);
                f32 h = hN * heightScale + minHeight;

                if (h < 0.0f)
                {
                    r = 0;
                    g = 0;
                    b = 153;
                }
                else
                {
                    f32 hscaled = h / maxHeight * 2.0f - 1e-05f; // hscaled should range in [0,2)
                    s32 hi = s32(hscaled); // hi should range in [0,1]
                    f32 hfrac = hscaled - f32(hi); // hfrac should range in [0,1]
                    if (hi == 0)
                    {
                        r = u32(lerp(0.1f, 0.4f, hfrac) * 255.0f);
                        g = u32(lerp(0.3f, 0.8f, hfrac) * 255.0f);
                        b = u32(lerp(0.1f, 0.4f, hfrac) * 255.0f);
                    }
                    else
                    {
                        r = u32(lerp(0.4f, 1.0f, hfrac) * 255.0f);
                        g = u32(lerp(0.8f, 1.0f, hfrac) * 255.0f);
                        b = u32(lerp(0.4f, 1.0f, hfrac) * 255.0f);
                    }
                }

                video::S3DVertex & vertex = static_cast<video::S3DVertex*>(vb.pointer())[index++];
                vertex.Normal.set(0.0f, 0.0f, 1.0f);
                vertex.Color.set(255, r, g, b);
                vertex.Pos.X = currX;
                vertex.Pos.Y = currY;
                vertex.Pos.Z = h;

                if (h < minZ)
                    minZ = h;
                else if (h > maxZ)
                    maxZ = h;

				currX += stepSize;
			}

			currY += stepSize;
		}

        // create faces
        index = 0;
        s32 row0Index = 0;
        s32 row1Index = dimension;

        scene::IIndexBuffer& ib = mb->getIndexBuffer();

        for (u32 z = 0; z < dimension - 2; ++z)
        {
            // do two rows at a time to make a triangle strip
            for (u32 x = 0; x < dimension; ++x)
            {
                ib.setValue(index++, row0Index++);
                ib.setValue(index++, row1Index++);
            }

            // add degenerate triangle to get to next row
            ib.setValue(index++, row1Index - 1);
            ib.setValue(index++, row0Index);
        }

        // do two rows at a time to make a triangle strip
        for (u32 x = 0; x < dimension; ++x)
        {
            ib.setValue(index++, row0Index++);
            ib.setValue(index++, row1Index++);
        }

        ib.setHardwareMappingHint(EHM_STATIC);
        mb->setPrimitiveType(EPT_TRIANGLE_STRIP);
        
        for (u32 y = 1; y < dimension - 1; ++y)
        {
            index = y * dimension + 1;

            for (u32 x = 1; x < dimension - 1; ++x, ++index)
            {
                video::S3DVertex& vback = static_cast<video::S3DVertex*>(vb.pointer())[index - dimension];
                video::S3DVertex& vforward = static_cast<video::S3DVertex*>(vb.pointer())[index + dimension];
                video::S3DVertex& vleft = static_cast<video::S3DVertex*>(vb.pointer())[index - 1];
                video::S3DVertex& vright = static_cast<video::S3DVertex*>(vb.pointer())[index + 1];

                f32 nX = vleft.Pos.X - vright.Pos.X;
                f32 nY = vback.Pos.Y - vforward.Pos.Y;
                f32 nZ = 100.0f;

                video::S3DVertex& vertex = static_cast<video::S3DVertex*>(vb.pointer())[index];
                vertex.Normal.set(nX, nY, nZ);
                vertex.Normal.normalize();
            }
        }

		// add the MeshBuffer to the mesh
		Mesh->addMeshBuffer(mb);

        irr::core::aabbox3df bounds(0.0f, 0.0f, minZ, tileSize, tileSize, maxZ);
        Mesh->setBoundingBox(bounds);

		// We no longer need the mb
		mb->drop();

        delete[] bytes;

        // update relative position
        
		return true;
	}


} // end namespace scene
} // end namespace irr

#endif // _IRR_COMPILE_WITH_TERRAIN_SCENENODE_
