// Copyright (C) 2008-2012 Christian Stehno
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_PLY_WRITER_

#include "CPLYMeshWriter.h"
#include "os.h"
#include "IMesh.h"
#include "IMeshBuffer.h"
#include "IWriteFile.h"

namespace irr
{
namespace scene
{

CPLYMeshWriter::CPLYMeshWriter()
{
	#ifdef _DEBUG
	setDebugName("CPLYMeshWriter");
	#endif
}


//! Returns the type of the mesh writer
EMESH_WRITER_TYPE CPLYMeshWriter::getType() const
{
	return EMWT_PLY;
}

//! writes a mesh
bool CPLYMeshWriter::writeMesh(io::IWriteFile* file, scene::IMesh* mesh, s32 flags)
{
	if (!file || !mesh)
		return false;

	os::Printer::log("Writing mesh", file->getFileName());

    // write PLY header
	core::stringc header = "ply\n";

	if (flags & scene::EMWF_WRITE_BINARY)
	{
		#ifdef __BIG_ENDIAN__
		header += "format binary_big_endian 1.0\n";
		#else
		header += "format binary_little_endian 1.0\n";
		#endif
	}
	else
		header += "format ascii 1.0\n";

	header +=  "comment Irrlicht Engine ";
	header +=  IRRLICHT_SDK_VERSION;

	// get vertex and triangle counts
	u32 VertexCount   = 0;
	u32 TriangleCount = 0;

	for (u32 i=0; i < mesh->getMeshBufferCount(); ++i)
	{
		VertexCount   += mesh->getMeshBuffer(i)->getVertexCount();
		TriangleCount += mesh->getMeshBuffer(i)->getIndexCount() / 3;
	}

	// vertex definition
	header += "\nelement vertex ";
	header += VertexCount;

	header += "\n"
		"property float x\n"
		"property float y\n"
		"property float z\n"
		"property float nx\n"
		"property float ny\n"
		"property float nz\n"
		"property float s\n"
		"property float t\n"
		"property uchar red\n"
		"property uchar green\n"
		"property uchar blue\n";
	//	"property float tx\n"
	//	"property float ty\n"
	//	"property float tz\n"

	// face definition

	header += "element face ";
	header += TriangleCount;
	header += "\n"
		"property list uchar int vertex_indices\n"
		"end_header\n";

	// write header
	file->write(header.c_str(), header.size());

	// write vertices

	c8 outLine[1024];

	for (u32 i=0; i < mesh->getMeshBufferCount(); ++i)
	{
		const scene::IMeshBuffer* mb = mesh->getMeshBuffer(i);
		u32 vertexSize = 0;
		switch(mb->getVertexType())
		{
		case video::EVT_STANDARD:
			vertexSize = sizeof(video::S3DVertex);
			break;
		case video::EVT_2TCOORDS:
			vertexSize = sizeof(video::S3DVertex2TCoords);
			break;
		case video::EVT_TANGENTS:
			vertexSize = sizeof(video::S3DVertexTangents);
			break;
		}
		u8 *vertices  = (u8*)mb->getVertices() ;

		for (u32 j=0; j < mb->getVertexCount(); ++j)
		{
        	u8 *buf = vertices + j * vertexSize;
			const video::S3DVertex* vertex = ( (video::S3DVertex*)buf );
			const core::vector3df& pos    = vertex->Pos;
			const core::vector3df& n      = vertex->Normal;
			const core::vector2df& uv     = vertex->TCoords;
			const video::SColor& color    = vertex->Color;

			if (flags & scene::EMWF_WRITE_BINARY)
			{
				// Y and Z are flipped
				file->write(&pos.X, 4);
				file->write(&pos.Z, 4);
				file->write(&pos.Y, 4);

				file->write(&n.X, 4);
				file->write(&n.Z, 4);
				file->write(&n.Y, 4);

				file->write(&uv, 8);

				const u32 r = color.getRed(), g = color.getGreen(), b = color.getBlue();
				file->write(&r, 1);
				file->write(&g, 1);
				file->write(&b, 1);
			}
			else
			{
				// x y z nx ny nz u v red green blue [u1 v1 | tx ty tz]\n
				snprintf_irr(outLine, 1024,
					"%f %f %f %f %f %f %f %f %d %d %d\n",// %u %u %u %u %f %f\n",
					pos.X, pos.Z, pos.Y, // Y and Z are flipped
					n.X, n.Z, n.Y,
					uv.X, uv.Y,
					color.getRed(), color.getGreen(), color.getBlue());

					file->write(outLine, strlen(outLine));
			}
		}
	}

	// index of the first vertex in the current mesh buffer
	u32 StartOffset = 0;

	// write triangles
	const unsigned char nbIndicesParFace = 3;
	for (u32 i=0; i < mesh->getMeshBufferCount(); ++i)
	{
		scene::IMeshBuffer* mb = mesh->getMeshBuffer(i);
		for (u32 j=0; j < mb->getIndexCount(); j+=3)
		{
			// y and z are flipped so triangles are reversed
			u32 a=StartOffset;
			u32 b=StartOffset;
			u32 c=StartOffset;

			switch(mb->getIndexType())
			{
			case video::EIT_16BIT:
				a += mb->getIndices()[j+0];
				c += mb->getIndices()[j+1];
				b += mb->getIndices()[j+2];
				break;
			case video::EIT_32BIT:
				a += ((u32*)mb->getIndices()) [j+0];
				c += ((u32*)mb->getIndices()) [j+1];
				b += ((u32*)mb->getIndices()) [j+2];
				break;
			}

			if (flags & scene::EMWF_WRITE_BINARY)
			{
				file->write(&nbIndicesParFace, 1);
				file->write(&a, 4);
				file->write(&b, 4);
				file->write(&c, 4);
			}
			else
			{
				// count a b c\n
				snprintf_irr(outLine, 1024, "3 %u %u %u\n", a, b, c);
				file->write(outLine, strlen(outLine));
			}
		}

		// increment offset
		StartOffset += mb->getVertexCount();
	}

	// all done!
	return true;
}

} // end namespace
} // end namespace

#endif // _IRR_COMPILE_WITH_PLY_WRITER_

