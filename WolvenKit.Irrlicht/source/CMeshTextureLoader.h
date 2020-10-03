#ifndef IRR_C_MESH_TEXTURE_LOADER_H_INCLUDED
#define IRR_C_MESH_TEXTURE_LOADER_H_INCLUDED

#include "IMeshTextureLoader.h"

namespace irr
{
namespace io
{
	class IFileSystem;
} // end namespace io
namespace video
{
	class IVideoDriver;
}

namespace scene
{

class CMeshTextureLoader : public IMeshTextureLoader
{
public:
	CMeshTextureLoader(irr::io::IFileSystem* fs, irr::video::IVideoDriver* driver);

	//! Set a custom texture path.
    /**	This is the first path the texture-loader should search.  */
	virtual void setTexturePath(const irr::io::path& path)  _IRR_OVERRIDE_;

	//! Get the current custom texture path.
	virtual const irr::io::path& getTexturePath() const  _IRR_OVERRIDE_;

	//! Get the texture by searching for it in all paths that makes sense for the given textureName.
	/** Usually you do not have to use this method, it is used internally by IMeshLoader's.
	\param textureName Texturename as used in the mesh-format
	\return Pointer to the texture. Returns 0 if loading failed.*/
	virtual irr::video::ITexture* getTexture(const irr::io::path& textureName)  _IRR_OVERRIDE_;

	//! Meshloaders will search paths relative to the meshFile.
	/** Usually you do not have to use this method, it is used internally by IMeshLoader's.
		Any values you set here will likely be overwritten internally. */
	virtual void setMeshFile(const irr::io::IReadFile* meshFile) _IRR_OVERRIDE_;

	//! Meshloaders will try to look relative to the path of the materialFile
	/** Usually you do not have to use this method, it is used internally by IMeshLoader's.
	Any values you set here will likely be overwritten internally.	*/
	virtual void setMaterialFile(const irr::io::IReadFile* materialFile) _IRR_OVERRIDE_;

protected:
	// make certain path's have a certain internal format
	void preparePath(irr::io::path& directory)
	{
		if (!directory.empty())
		{
			if (directory == _IRR_TEXT("."))
				directory = _IRR_TEXT("");

			directory.replace(_IRR_TEXT('\\'),_IRR_TEXT('/'));
			if (directory.lastChar() != _IRR_TEXT('/'))
				directory.append(_IRR_TEXT('/'));
		}
	}

	// Save the texturename when it's a an existing file
	bool checkTextureName( const irr::io::path& filename);

private:
	irr::io::IFileSystem * FileSystem;
	irr::video::IVideoDriver* VideoDriver;
	irr::io::path TexturePath;
	const irr::io::IReadFile* MeshFile;
	irr::io::path MeshPath;
	const irr::io::IReadFile* MaterialFile;
	irr::io::path MaterialPath;
	irr::io::path TextureName;
};

} // end namespace scene
} // end namespace irr

#endif

