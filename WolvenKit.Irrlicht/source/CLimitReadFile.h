// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_LIMIT_READ_FILE_H_INCLUDED__
#define __C_LIMIT_READ_FILE_H_INCLUDED__

#include "IReadFile.h"
#include "irrString.h"

namespace irr
{
	class CUnicodeConverter;

namespace io
{

	/*! this is a read file, which is limited to some boundaries,
		so that it may only start from a certain file position
		and may only read until a certain file position.
		This can be useful, for example for reading uncompressed files
		in an archive (zip, tar).
	!*/
	class CLimitReadFile : public IReadFile
	{
	public:

		CLimitReadFile(IReadFile* alreadyOpenedFile, long pos, long areaSize, const io::path& name);

		virtual ~CLimitReadFile();

		//! returns how much was read
		virtual size_t read(void* buffer, size_t sizeToRead) _IRR_OVERRIDE_;

		//! changes position in file, returns true if successful
		//! if relativeMovement==true, the pos is changed relative to current pos,
		//! otherwise from begin of file
		virtual bool seek(long finalPos, bool relativeMovement = false) _IRR_OVERRIDE_;

		//! returns size of file
		virtual long getSize() const _IRR_OVERRIDE_;

		//! returns where in the file we are.
		virtual long getPos() const _IRR_OVERRIDE_;

		//! returns name of file
		virtual const io::path& getFileName() const _IRR_OVERRIDE_;

		//! Get the type of the class implementing this interface
		virtual EREAD_FILE_TYPE getType() const _IRR_OVERRIDE_
		{
			return ERFT_LIMIT_READ_FILE;
		}

	private:

		io::path Filename;
		long AreaStart;
		long AreaEnd;
		long Pos;
		IReadFile* File;
	};

} // end namespace io
} // end namespace irr

#endif

