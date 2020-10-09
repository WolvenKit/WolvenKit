// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __I_XML_WRITER_H_INCLUDED__
#define __I_XML_WRITER_H_INCLUDED__

#include "IReferenceCounted.h"
#include "irrXML.h"

namespace irr
{
namespace io
{
	//! An xml writer for wide characters, derived from IReferenceCounted.
	/** Call IFileSystem::createXMLReader(). to create an IXMLWriter */
	typedef IIrrXMLWriter<wchar_t, IReferenceCounted> IXMLWriter;

	//! An xml writer for ASCII or UTF-8 characters, derived from IReferenceCounted.
	/** Call IFileSystem::createXMLReaderUtf8(). to create an IXMLWriter */
	typedef IIrrXMLWriter<c8, IReferenceCounted> IXMLWriterUTF8;

} // end namespace io
} // end namespace irr

#endif
