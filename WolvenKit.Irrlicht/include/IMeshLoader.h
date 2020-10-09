// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_MESH_LOADER_H_INCLUDED__
#define __I_MESH_LOADER_H_INCLUDED__

#include "IReferenceCounted.h"
#include "path.h"
#include "IMeshTextureLoader.h"
#include "IMeshLoaderHelper.h"

namespace irr
{
namespace io
{
	class IReadFile;
} // end namespace io
namespace scene
{
	class IAnimatedMesh;
	
//! Class which is able to load an animated mesh from a file.
/** If you want Irrlicht be able to load meshes of
currently unsupported file formats (e.g. .cob), then implement
this and add your new Meshloader with
ISceneManager::addExternalMeshLoader() to the engine. */
class IMeshLoader : public virtual IReferenceCounted
{
public:

	//! Constructor
	IMeshLoader() : TextureLoader(0), LoaderHelper(0) {}

	//! Destructor
	virtual ~IMeshLoader()
	{
		if ( TextureLoader )
			TextureLoader->drop();
		if (LoaderHelper)
			LoaderHelper->drop();
	}

	//! Returns true if the file might be loaded by this class.
	/** This decision should be based on the file extension (e.g. ".cob")
	only.
	\param filename Name of the file to test.
	\return True if the file might be loaded by this class. */
	virtual bool isALoadableFileExtension(const io::path& filename) const = 0;

	//! Creates/loads an animated mesh from the file.
	/** \param file File handler to load the file from.
	\return Pointer to the created mesh. Returns 0 if loading failed.
	If you no longer need the mesh, you should call IAnimatedMesh::drop().
	See IReferenceCounted::drop() for more information. */
	virtual IAnimatedMesh* createMesh(io::IReadFile* file) = 0;

	//! Set a new texture loader which this meshloader can use when searching for textures.
	/** NOTE: Not all meshloaders do support this interface. Meshloaders which
	support it will return a non-null value in getMeshTextureLoader from the start. Setting a
	texture-loader to a meshloader which doesn't support it won't help.
	\param textureLoader The textureloader to use. When set to NULL the mesh will not load any textures.
	*/
	virtual void setMeshTextureLoader(IMeshTextureLoader* textureLoader)
	{
		if ( textureLoader != TextureLoader )
		{
			if ( textureLoader )
				textureLoader->grab();
			if ( TextureLoader )
				TextureLoader->drop();
			TextureLoader = textureLoader;
		}
	}

	//! Get the texture loader used when this meshloader searches for textures.
	/** NOTE: not all meshloaders support this interface so this can return NULL.
	*/
	virtual IMeshTextureLoader* getMeshTextureLoader() const
	{
		return TextureLoader;
	}

	virtual IMeshLoaderHelper* getMeshLoaderHelper() const
	{
		return LoaderHelper;
	}

protected:
	IMeshTextureLoader* TextureLoader;
	IMeshLoaderHelper* LoaderHelper;
};


} // end namespace scene
} // end namespace irr

#endif
