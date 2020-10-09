#include "stdafx.h"
#include "ArchiveLoader.h"
#include "FileArchive.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

ArchiveLoader^ ArchiveLoader::Wrap(io::IArchiveLoader* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ArchiveLoader(ref);
}

ArchiveLoader::ArchiveLoader(io::IArchiveLoader* ref)
	: ReferenceCounted(ref)
{
	m_ArchiveLoader = ref;
}

FileArchive^ ArchiveLoader::CreateArchive(String^ filename, bool ignoreCase, bool ignorePaths)
{
	LIME_ASSERT(filename != nullptr);

	io::IFileArchive* a = m_ArchiveLoader->createArchive(
		Lime::StringToPath(filename),
		ignoreCase,
		ignorePaths);

	return FileArchive::Wrap(a);
}

FileArchive^ ArchiveLoader::CreateArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths)
{
	LIME_ASSERT(file != nullptr);

	io::IFileArchive* a = m_ArchiveLoader->createArchive(file->m_ReadFile, ignoreCase, ignorePaths);
	return FileArchive::Wrap(a);
}

bool ArchiveLoader::IsALoadableFileFormat(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	return m_ArchiveLoader->isALoadableFileFormat(
		Lime::StringToPath(filename));
}

bool ArchiveLoader::IsALoadableFileFormat(ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);
	return m_ArchiveLoader->isALoadableFileFormat(file->m_ReadFile);
}

bool ArchiveLoader::IsALoadableFileFormat(FileArchiveType fileType)
{
	return m_ArchiveLoader->isALoadableFileFormat((io::E_FILE_ARCHIVE_TYPE)fileType);
}

} // end namespace IO
} // end namespace IrrlichtLime