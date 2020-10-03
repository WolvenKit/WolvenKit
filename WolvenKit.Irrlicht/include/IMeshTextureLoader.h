// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef IRR_I_MESH_TEXTURE_LOADER_H_INCLUDED__
#define IRR_I_MESH_TEXTURE_LOADER_H_INCLUDED__

#include "path.h"
#include "IReferenceCounted.h"

namespace irr
{

namespace video
{
	class ITexture;
}
namespace io
{
	class IReadFile;
}

namespace scene
{

//! Finding and loading textures inside meshloaders.
/** A texture loader can search for a texture in several paths.
For example relative to a given texture-path, relative to the current
working directory or relative to a mesh- and/or material-file.
*/
class IMeshTextureLoader : public virtual IReferenceCounted
{
public:

	//! Destructor
	virtual ~IMeshTextureLoader() {}

	//! Set a custom texture path.
    /**	This is the first path the texture-loader should search.  */
	virtual void setTexturePath(const irr::io::path& path) = 0;

	//! Get the current custom texture path.
	virtual const irr::io::path& getTexturePath() const = 0;

	//! Get the texture by searching for it in all paths that makes sense for the given textureName.
	/** Usually you do not have to use this method, it is used internally by IMeshLoader's.
	\param textureName Texturename as used in the mesh-format
	\return Pointer to the texture. Returns 0 if loading failed.*/
	virtual irr::video::ITexture* getTexture(const irr::io::path& textureName) = 0;

	//! Meshloaders will search paths relative to the meshFile.
	/** Usually you do not have to use this method, it is used internally by IMeshLoader's.
		Any values you set here will likely be overwritten internally. */
	virtual void setMeshFile(const irr::io::IReadFile* meshFile)  = 0;

	//! Meshloaders will try to look relative to the path of the materialFile
	/** Usually you do not have to use this method, it is used internally by IMeshLoader's.
	Any values you set here will likely be overwritten internally.	*/
	virtual void setMaterialFile(const irr::io::IReadFile* materialFile)  = 0;
};


} // end namespace scene
} // end namespace irr

#endif
