// Copyright (C) 2002-2012 Nikolaus Gebhardt
// This file is part of the "Irrlicht Engine".
// For conditions of distribution and use, see copyright notice in irrlicht.h

#ifndef __C_XML_WRITER_H_INCLUDED__
#define __C_XML_WRITER_H_INCLUDED__

#include "IXMLWriter.h"

#ifdef _IRR_COMPILE_WITH_XML_

#include <wchar.h>
#include "IWriteFile.h"

namespace irr
{
namespace io
{

	//! creates an IXMLReader
	IXMLWriter* createIXMLWriter(IWriteFile* file);

	//! creates an IXMLReader
	IXMLWriterUTF8* createIXMLWriterUTF8(IWriteFile* file);

	// Stuff needed by implementations for all character types
	// TODO: With some more work it could maybe become a pure template based thing like CXMLReaderImpl
	//		and replace the type based writer implementations. Sorry, too lazy for now :-/
	template<class char_type>
	class CXMLWriterCommon
	{
	public:
		//! Constructor
		CXMLWriterCommon(IWriteFile* file): File(file), Tabs(0), TextWrittenLast(false)
		{
			if (File)
				File->grab();
		}

		//! Destructor
		virtual ~CXMLWriterCommon()
		{
			if (File)
				File->drop();
		}

		struct XMLSpecialCharacters
		{
			char_type Character;
			const char_type* Symbol;
		};

	protected:
		IWriteFile* File;
		s32 Tabs;

		bool TextWrittenLast;
	};


	//! Implementation providing methods for making it easier to write XML files.
	class CXMLWriter : public IXMLWriter, public CXMLWriterCommon<wchar_t>
	{
	public:

		//! Constructor
		CXMLWriter(IWriteFile* file);

		//! Destructor
		virtual ~CXMLWriter() {}

		//! Writes a xml 1.0 header like <?xml version="1.0"?>
		virtual void writeXMLHeader() _IRR_OVERRIDE_;

		//! Writes an xml element with maximal 5 attributes
		virtual void writeElement(const wchar_t* name, bool empty=false,
			const wchar_t* attr1Name = 0, const wchar_t* attr1Value = 0,
			const wchar_t* attr2Name = 0, const wchar_t* attr2Value = 0,
			const wchar_t* attr3Name = 0, const wchar_t* attr3Value = 0,
			const wchar_t* attr4Name = 0, const wchar_t* attr4Value = 0,
			const wchar_t* attr5Name = 0, const wchar_t* attr5Value = 0) _IRR_OVERRIDE_;

		//! Writes an xml element with any number of attributes
		virtual void writeElement(const wchar_t* name, bool empty,
				core::array<core::stringw> &names, core::array<core::stringw> &values) _IRR_OVERRIDE_;

		//! Writes a comment into the xml file
		virtual void writeComment(const wchar_t* comment) _IRR_OVERRIDE_;

		//! Writes the closing tag for an element. Like </foo>
		virtual void writeClosingTag(const wchar_t* name) _IRR_OVERRIDE_;

		//! Writes a text into the file. All occurrences of special characters like
		//! & (&amp;), < (&lt;), > (&gt;), and " (&quot;) are automatically replaced.
		virtual void writeText(const wchar_t* text) _IRR_OVERRIDE_;

		//! Writes a line break
		virtual void writeLineBreak() _IRR_OVERRIDE_;

	private:

		void writeAttribute(const wchar_t* att, const wchar_t* name);
	};

	//! Implementation providing methods for making it easier to write XML files.
	class CXMLWriterUTF8 : public IXMLWriterUTF8, public CXMLWriterCommon<c8>
	{
	public:

		//! Constructor
		CXMLWriterUTF8(IWriteFile* file);

		//! Destructor
		virtual ~CXMLWriterUTF8() {}

		//! Writes a xml 1.0 header like <?xml version="1.0"?>
		virtual void writeXMLHeader() _IRR_OVERRIDE_;

		//! Writes an xml element with maximal 5 attributes
		virtual void writeElement(const c8* name, bool empty=false,
			const c8* attr1Name = 0, const c8* attr1Value = 0,
			const c8* attr2Name = 0, const c8* attr2Value = 0,
			const c8* attr3Name = 0, const c8* attr3Value = 0,
			const c8* attr4Name = 0, const c8* attr4Value = 0,
			const c8* attr5Name = 0, const c8* attr5Value = 0) _IRR_OVERRIDE_;

		//! Writes an xml element with any number of attributes
		virtual void writeElement(const c8* name, bool empty,
				core::array<core::stringc> &names, core::array<core::stringc> &values) _IRR_OVERRIDE_;

		//! Writes a comment into the xml file
		virtual void writeComment(const c8* comment) _IRR_OVERRIDE_;

		//! Writes the closing tag for an element. Like </foo>
		virtual void writeClosingTag(const c8* name) _IRR_OVERRIDE_;

		//! Writes a text into the file. All occurrences of special characters like
		//! & (&amp;), < (&lt;), > (&gt;), and " (&quot;) are automatically replaced.
		virtual void writeText(const c8* text) _IRR_OVERRIDE_;

		//! Writes a line break
		virtual void writeLineBreak() _IRR_OVERRIDE_;

	private:

		void writeAttribute(const c8* att, const c8* name);
	};


} // end namespace irr
} // end namespace io

#endif // _IRR_COMPILE_WITH_XML_

#endif

