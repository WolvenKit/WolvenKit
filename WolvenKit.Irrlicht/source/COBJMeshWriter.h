// Copyright (C) 2008-2012 Christian Stehno
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __IRR_OBJ_MESH_WRITER_H_INCLUDED__
#define __IRR_OBJ_MESH_WRITER_H_INCLUDED__

#include "IMeshWriter.h"
#include "S3DVertex.h"
#include "irrString.h"

namespace irr
{
namespace io
{
	class IFileSystem;
} // end namespace io
namespace scene
{
	class IMeshBuffer;
	class ISceneManager;

	//! class to write meshes, implementing a OBJ writer
	class COBJMeshWriter : public IMeshWriter
	{
	public:

		COBJMeshWriter(scene::ISceneManager* smgr, io::IFileSystem* fs);
		~COBJMeshWriter();

		//! Returns the type of the mesh writer
		EMESH_WRITER_TYPE getType() const _IRR_OVERRIDE_;

        //! Sets a matrix to use for local to world transformation
        void setTransform(const irr::core::matrix4& m) noexcept _IRR_OVERRIDE_
        {
            LocalToWorld = m;
        }

        void setImageType(core::stringc extension) noexcept _IRR_OVERRIDE_
        {
            TexExtension = extension;
        }

		//! writes a mesh
		bool writeMesh(io::IWriteFile* file, scene::IMesh* mesh, s32 flags=EMWF_NONE) _IRR_OVERRIDE_;

	protected:
		// create vector output with line end into string
		void getVectorAsStringLine(const core::vector3df& v,
				core::stringc& s) const;

		// create vector output with line end into string
		void getVectorAsStringLine(const core::vector2df& v,
				core::stringc& s) const;

		// create color output with line end into string
		void getColorAsStringLine(const video::SColor& color,
				const c8* const prefix, core::stringc& s) const;

		scene::ISceneManager* SceneManager;
		io::IFileSystem* FileSystem;
        core::stringc TexExtension;
        core::matrix4 LocalToWorld;
	};

} // end namespace
} // end namespace

#endif

