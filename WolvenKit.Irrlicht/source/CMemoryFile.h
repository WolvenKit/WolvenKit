// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_MEMORY_READ_FILE_H_INCLUDED__
#define __C_MEMORY_READ_FILE_H_INCLUDED__

#include "IMemoryReadFile.h"
#include "IWriteFile.h"
#include "irrString.h"

namespace irr
{

namespace io
{

	/*!
		Class for reading from memory.
	*/
	class CMemoryReadFile : public IMemoryReadFile
	{
	public:

		//! Constructor
		CMemoryReadFile(const void* memory, long len, const io::path& fileName, bool deleteMemoryWhenDropped);

		//! Destructor
		virtual ~CMemoryReadFile();

		//! returns how much was read
		virtual size_t read(void* buffer, size_t sizeToRead) _IRR_OVERRIDE_;

		//! changes position in file, returns true if successful
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
			return ERFT_MEMORY_READ_FILE;
		}

		//! Get direct access to internal buffer
		virtual const void *getBuffer() const _IRR_OVERRIDE_
		{
			return Buffer;
		}

	private:

		const void *Buffer;
		long Len;
		long Pos;
		io::path Filename;
		bool deleteMemoryWhenDropped;
	};

	/*!
		Class for writing to memory.
	*/
	class CMemoryWriteFile : public IWriteFile
	{
	public:

		//! Constructor
		CMemoryWriteFile(void* memory, long len, const io::path& fileName, bool deleteMemoryWhenDropped);

		//! Destructor
		virtual ~CMemoryWriteFile();

		//! returns how much was written
		virtual size_t write(const void* buffer, size_t sizeToWrite) _IRR_OVERRIDE_;

		//! changes position in file, returns true if successful
		virtual bool seek(long finalPos, bool relativeMovement = false) _IRR_OVERRIDE_;

		//! returns where in the file we are.
		virtual long getPos() const _IRR_OVERRIDE_;

		//! returns name of file
		virtual const io::path& getFileName() const _IRR_OVERRIDE_;

		virtual bool flush() _IRR_OVERRIDE_;

	private:

		void *Buffer;
		long Len;
		long Pos;
		io::path Filename;
		bool deleteMemoryWhenDropped;
	};

} // end namespace io
} // end namespace irr

#endif

