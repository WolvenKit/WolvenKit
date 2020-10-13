// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_WRITE_FILE_H_INCLUDED__
#define __C_WRITE_FILE_H_INCLUDED__

#include <stdio.h>
#include "IWriteFile.h"
#include "irrString.h"

namespace irr
{

namespace io
{

	/*!
		Class for writing a real file to disk.
	*/
	class CWriteFile : public IWriteFile
	{
	public:

		CWriteFile(const io::path& fileName, bool append);

		virtual ~CWriteFile();

		//! Reads an amount of bytes from the file.
		virtual size_t write(const void* buffer, size_t sizeToWrite) _IRR_OVERRIDE_;

		//! Changes position in file, returns true if successful.
		virtual bool seek(long finalPos, bool relativeMovement = false) _IRR_OVERRIDE_;

		//! Returns the current position in the file.
		virtual long getPos() const _IRR_OVERRIDE_;

		//! Returns name of file.
		virtual const io::path& getFileName() const _IRR_OVERRIDE_;

		//! Flush the content of the buffer in the file
		virtual bool flush() _IRR_OVERRIDE_;

		//! returns if file is open
		bool isOpen() const;

		//! creator method
		static IWriteFile* createWriteFile(const io::path& fileName, bool append);

	private:

		//! opens the file
		void openFile(bool append);

		io::path Filename;
		FILE* File;
		long FileSize;
	};

} // end namespace io
} // end namespace irr

#endif

