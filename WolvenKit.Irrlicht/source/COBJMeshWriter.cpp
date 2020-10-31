// Copyright (C) 2008-2012 Christian Stehno
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#include "IrrCompileConfig.h"

#ifdef _IRR_COMPILE_WITH_OBJ_WRITER_

#include "COBJMeshWriter.h"
#include "os.h"
#include "IMesh.h"
#include "IMeshBuffer.h"
#include "IAttributes.h"
#include "ISceneManager.h"
#include "IMeshCache.h"
#include "IWriteFile.h"
#include "IFileSystem.h"
#include "ITexture.h"
#include <CDynamicMeshBuffer.h>

namespace irr
{
namespace scene
{

COBJMeshWriter::COBJMeshWriter(scene::ISceneManager* smgr, io::IFileSystem* fs)
	: SceneManager(smgr), FileSystem(fs)
{
	#ifdef _DEBUG
	setDebugName("COBJMeshWriter");
	#endif

	if (SceneManager)
		SceneManager->grab();

	if (FileSystem)
		FileSystem->grab();
}


COBJMeshWriter::~COBJMeshWriter()
{
	if (SceneManager)
		SceneManager->drop();

	if (FileSystem)
		FileSystem->drop();
}


//! Returns the type of the mesh writer
EMESH_WRITER_TYPE COBJMeshWriter::getType() const
{
	return EMWT_OBJ;
}


//! writes a mesh
bool COBJMeshWriter::writeMesh(io::IWriteFile* file, scene::IMesh* mesh, s32 flags)
{
	if (!file)
		return false;

	os::Printer::log("Writing mesh", file->getFileName());

	// write OBJ MESH header

	io::path name;
	core::cutFilenameExtension(name,file->getFileName()) += ".mtl";
	io::path matName = name;
    core::stringc mtlName = core::deletePathFromFilename(matName);
	
    file->write("# exported by Irrlicht\n", 23);
	file->write("mtllib ",7);
	file->write(mtlName.c_str(), mtlName.size());
	file->write("\n\n",2);

	// write mesh buffers

	core::array<video::SMaterial*> mat;

	u32 allVertexCount=1; // count vertices over the whole file
	for (u32 i=0; i<mesh->getMeshBufferCount(); ++i)
	{
		core::stringc num(i+1);
		scene::CDynamicMeshBuffer* buffer = (scene::CDynamicMeshBuffer*)(mesh->getMeshBuffer(i));
		if (buffer && buffer->getVertexCount())
		{
			file->write("g grp", 5);
			file->write(num.c_str(), num.size());
			file->write("\n",1);

			u32 j;
			const u32 vertexCount = buffer->getVertexCount();
			for (j=0; j<vertexCount; ++j)
			{
				file->write("v ",2);
                irr::core::vector3df v = buffer->getPosition(j);
                LocalToWorld.transformVect(v);

				getVectorAsStringLine(v, num);
				file->write(num.c_str(), num.size());
			}

			for (j=0; j<vertexCount; ++j)
			{
				file->write("vt ",3);
				getVectorAsStringLine(buffer->getTCoords(j), num);
				file->write(num.c_str(), num.size());
			}

			for (j=0; j<vertexCount; ++j)
			{
				file->write("vn ",3);
				getVectorAsStringLine(buffer->getNormal(j), num);
				file->write(num.c_str(), num.size());
			}

			file->write("usemtl mat",10);
			num = "";
			for (j=0; j<mat.size(); ++j)
			{
				if (*mat[j]==buffer->getMaterial())
				{
					num = core::stringc(j);
					break;
				}
			}
			if (num == "")
			{
				num = core::stringc(mat.size());
				mat.push_back(&buffer->getMaterial());
			}
			file->write(num.c_str(), num.size());
			file->write("\n",1);

			const u32 indexCount = buffer->getIndexCount();
			const scene::IIndexBuffer& indices = buffer->getIndexBuffer();
			if (indexCount == vertexCount * 3)
			{
				for (j = 0; j < indexCount; j += 3)
				{
					file->write("f ", 2);
					u32 idx = indices[j + 2] + allVertexCount;
					num = core::stringc(idx);
					file->write(num.c_str(), num.size());
					file->write("/", 1);
					file->write(num.c_str(), num.size());
					file->write("/", 1);
					file->write(num.c_str(), num.size());
					file->write(" ", 1);

                    idx = indices[j + 1] + allVertexCount;
                    num = core::stringc(idx);
					file->write(num.c_str(), num.size());
					file->write("/", 1);
					file->write(num.c_str(), num.size());
					file->write("/", 1);
					file->write(num.c_str(), num.size());
					file->write(" ", 1);

                    idx = indices[j] + allVertexCount;
                    num = core::stringc(idx);
					file->write(num.c_str(), num.size());
					file->write("/", 1);
					file->write(num.c_str(), num.size());
					file->write("/", 1);
					file->write(num.c_str(), num.size());

					file->write("\n", 1);
				}
			}
			else // triangle strip!
			{
                for (j = 0; j < indexCount - 2; j += 2)
                {
                    file->write("f ", 2);
                    u32 idx = indices[j] + allVertexCount;
                    num = core::stringc(idx);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write(" ", 1);

                    idx = indices[j + 1] + allVertexCount;
                    num = core::stringc(idx);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write(" ", 1);

                    idx = indices[j + 2] + allVertexCount;
                    num = core::stringc(idx);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write("\n", 1);

                    file->write("f ", 2);
                    idx = indices[j + 3] + allVertexCount;
                    num = core::stringc(idx);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write(" ", 1);

                    idx = indices[j + 2] + allVertexCount;
                    num = core::stringc(idx);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write(" ", 1);

                    idx = indices[j + 1] + allVertexCount;
                    num = core::stringc(idx);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
                    file->write("/", 1);
                    file->write(num.c_str(), num.size());
					file->write("\n", 1);
                }
			}
			file->write("\n",1);
            file->flush();
			allVertexCount += vertexCount;
		}
	}

    file->drop();

	if (mat.size() == 0)
		return true;

	io::IWriteFile* mtlFile = FileSystem->createAndWriteFile( name );
	if (mtlFile)
	{
		os::Printer::log("Writing material", mtlFile->getFileName());

        mtlFile->write("# exported by Irrlicht\n\n",24);
		for (u32 i=0; i<mat.size(); ++i)
		{
			core::stringc num(i);
            mtlFile->write("newmtl mat",10);
            mtlFile->write(num.c_str(),num.size());
            mtlFile->write("\n",1);

			getColorAsStringLine(mat[i]->AmbientColor, "Ka", num);
            mtlFile->write(num.c_str(),num.size());
			getColorAsStringLine(mat[i]->DiffuseColor, "Kd", num);
            mtlFile->write(num.c_str(),num.size());
			getColorAsStringLine(mat[i]->SpecularColor, "Ks", num);
            mtlFile->write(num.c_str(),num.size());
			getColorAsStringLine(mat[i]->EmissiveColor, "Ke", num);
            mtlFile->write(num.c_str(),num.size());
			num = core::stringc((double)(mat[i]->Shininess/0.128f));
            mtlFile->write("Ns ", 3);
            mtlFile->write(num.c_str(),num.size());
            mtlFile->write("\n", 1);
			if (mat[i]->getTexture(0))
			{
                mtlFile->write("map_Kd ", 7);

				f32 tposX, tposY, tscaleX, tscaleY;
				const core::matrix4& textureMatrix =  mat[i]->getTextureMatrix(0);
				textureMatrix.getTextureTranslate(tposX, tposY);
				textureMatrix.getTextureScale(tscaleX, tscaleY);

			   //Write texture translation values
				if ( !core::equals(tposX, 0.f) || !core::equals(tposY, 0.f) )
				{
                    mtlFile->write("-o ", 3);
			   		core::stringc tx(tposX);
			   		core::stringc ty(tposY);

                    mtlFile->write(tx.c_str(), tx.size());
                    mtlFile->write(" ", 1);
                    mtlFile->write(ty.c_str(), ty.size());
                    mtlFile->write(" ", 1);
				}

				//Write texture scaling values
				if ( !core::equals(tscaleX, 1.f) || !core::equals(tscaleY, 1.f) )
				{
                    mtlFile->write("-s ", 3);

					core::stringc sx(tscaleX);
					core::stringc sy(tscaleY);

                    mtlFile->write(sx.c_str(), sx.size());
                    mtlFile->write(" ", 1);
                    mtlFile->write(sy.c_str(), sy.size());
                    mtlFile->write(" ", 1);
				}

                core::stringc tname = (core::stringc)(FileSystem->getFileBasename(mat[i]->getTexture(0)->getName()));
                if (!TexExtension.empty())
                {
                    core::stringc ext = tname.subString(tname.findLastChar("."), 4);
                    tname = tname.replace(ext, TexExtension);
                }

                mtlFile->write(tname.c_str(), tname.size());
                mtlFile->write("\n",1);
            }
            if (mat[i]->getTexture(1))
            {
                mtlFile->write("map_Bump ", 9);
                core::stringc tname = (core::stringc)(FileSystem->getFileBasename(mat[i]->getTexture(1)->getName()));
                if (!TexExtension.empty())
                {
                    core::stringc ext = tname.subString(tname.findLastChar("."), 4);
                    tname = tname.replace(ext, TexExtension);
                }

                mtlFile->write(tname.c_str(), tname.size());
                mtlFile->write("\n", 1);
            }
            mtlFile->write("\n",1);
		}
        mtlFile->drop();
	}
	return true;
}


void COBJMeshWriter::getVectorAsStringLine(const core::vector3df& v, core::stringc& s) const
{
	s = core::stringc(-v.X);
	s += " ";
	s += core::stringc(v.Y);
	s += " ";
	s += core::stringc(v.Z);
	s += "\n";
}


void COBJMeshWriter::getVectorAsStringLine(const core::vector2df& v, core::stringc& s) const
{
	s = core::stringc(v.X);
	s += " ";
	s += core::stringc(1-v.Y);
	s += "\n";
}


void COBJMeshWriter::getColorAsStringLine(const video::SColor& color, const c8* const prefix, core::stringc& s) const
{
	s = prefix;
	s += " ";
	s += core::stringc((double)(color.getRed()/255.f));
	s += " ";
	s += core::stringc((double)(color.getGreen()/255.f));
	s += " ";
	s += core::stringc((double)(color.getBlue()/255.f));
	s += "\n";
}


} // end namespace
} // end namespace

#endif

