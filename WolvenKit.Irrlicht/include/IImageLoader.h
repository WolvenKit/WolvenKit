// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_SURFACE_LOADER_H_INCLUDED__
#define __I_SURFACE_LOADER_H_INCLUDED__

#include "IReferenceCounted.h"
#include "IImage.h"
#include "ITexture.h"
#include "path.h"
#include "irrArray.h"

namespace irr
{
namespace io
{
	class IReadFile;
} // end namespace io
namespace video
{

//! Class which is able to create a image from a file.
/** If you want the Irrlicht Engine be able to load textures of
currently unsupported file formats (e.g .gif), then implement
this and add your new Surface loader with
IVideoDriver::addExternalImageLoader() to the engine. */
class IImageLoader : public virtual IReferenceCounted
{
public:

	//! Check if the file might be loaded by this class
	/** Check is based on the file extension (e.g. ".tga")
	\param filename Name of file to check.
	\return True if file seems to be loadable. */
	virtual bool isALoadableFileExtension(const io::path& filename) const = 0;

	//! Check if the file might be loaded by this class
	/** Check might look into the file.
	\param file File handle to check.
	\return True if file seems to be loadable. */
	virtual bool isALoadableFileFormat(io::IReadFile* file) const = 0;

	//! Creates a surface from the file
	/** \param file File handle to check.
	\return Pointer to newly created image, or 0 upon error. */
	virtual IImage* loadImage(io::IReadFile* file) const = 0;

	//! Creates a multiple surfaces from the file eg. whole cube map.
	/** \param file File handle to check.
	\param type Pointer to E_TEXTURE_TYPE where a recommended type of the texture will be stored.
	\return Array of pointers to newly created images. */
	virtual core::array<IImage*> loadImages(io::IReadFile* file, E_TEXTURE_TYPE* type) const
	{
		core::array<IImage*> image;

		return image;
	}
};


} // end namespace video
} // end namespace irr

#endif

