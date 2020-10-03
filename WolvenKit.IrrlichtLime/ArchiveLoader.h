#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

ref class FileArchive;
ref class ReadFile;

public ref class ArchiveLoader : ReferenceCounted
{
public:

	FileArchive^ CreateArchive(String^ filename, bool ignoreCase, bool ignorePaths);
	FileArchive^ CreateArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths);

	bool IsALoadableFileFormat(String^ filename);
	bool IsALoadableFileFormat(ReadFile^ file);
	bool IsALoadableFileFormat(FileArchiveType fileType);

internal:

	static ArchiveLoader^ Wrap(io::IArchiveLoader* ref);
	ArchiveLoader(io::IArchiveLoader* ref);

	io::IArchiveLoader* m_ArchiveLoader;
};

} // end namespace IO
} // end namespace IrrlichtLime