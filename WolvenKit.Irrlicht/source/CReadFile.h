// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_READ_FILE_H_INCLUDED__
#define __C_READ_FILE_H_INCLUDED__

#include <stdio.h>
#include "IReadFile.h"
#include "irrString.h"

namespace irr
{

namespace io
{

	/*!
		Class for reading a real file from disk.
	*/
	class CReadFile : public IReadFile
	{
	public:

		CReadFile(const io::path& fileName);

		virtual ~CReadFile();

		//! returns how much was read
		virtual size_t read(void* buffer, size_t sizeToRead) _IRR_OVERRIDE_;

		//! changes position in file, returns true if successful
		virtual bool seek(long finalPos, bool relativeMovement = false) _IRR_OVERRIDE_;

		//! returns size of file
		virtual long getSize() const _IRR_OVERRIDE_;

		//! returns if file is open
		bool isOpen() const
		{
			return File != 0;
		}

		//! returns where in the file we are.
		virtual long getPos() const _IRR_OVERRIDE_;

		//! returns name of file
		virtual const io::path& getFileName() const _IRR_OVERRIDE_;

		//! Get the type of the class implementing this interface
		virtual EREAD_FILE_TYPE getType() const _IRR_OVERRIDE_
		{
			return ERFT_READ_FILE;
		}

		//! create read file on disk.
		static IReadFile* createReadFile(const io::path& fileName);

	private:

		//! opens the file
		void openFile();

		FILE* File;
		long FileSize;
		io::path Filename;
	};

} // end namespace io
} // end namespace irr

#endif

