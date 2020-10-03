#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

ref class FileList;
ref class ReadFile;

public ref class FileArchive : ReferenceCounted
{
public:

	ReadFile^ CreateAndOpenFile(int index);
	ReadFile^ CreateAndOpenFile(String^ filename);

	property IrrlichtLime::IO::FileList^ FileList { IrrlichtLime::IO::FileList^ get(); }
	property String^ Password { String^ get(); void set(String^ value); }
	property FileArchiveType Type { FileArchiveType get(); }

internal:

	static FileArchive^ Wrap(io::IFileArchive* ref);
	FileArchive(io::IFileArchive* ref);

	io::IFileArchive* m_FileArchive;
};

} // end namespace IO
} // end namespace IrrlichtLime