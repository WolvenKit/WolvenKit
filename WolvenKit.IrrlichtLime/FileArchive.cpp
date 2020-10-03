#include "stdafx.h"
#include "FileArchive.h"
#include "FileList.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

FileArchive^ FileArchive::Wrap(io::IFileArchive* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew FileArchive(ref);
}

FileArchive::FileArchive(io::IFileArchive* ref)
	: ReferenceCounted(ref)
{
	m_FileArchive = ref;
}

ReadFile^ FileArchive::CreateAndOpenFile(int index)
{
	LIME_ASSERT(index >= 0 && index < FileList->Count);

	io::IReadFile* f = m_FileArchive->createAndOpenFile(index);
	return ReadFile::Wrap(f);
}

ReadFile^ FileArchive::CreateAndOpenFile(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	io::IReadFile* f = m_FileArchive->createAndOpenFile(Lime::StringToPath(filename));
	return ReadFile::Wrap(f);
}

IrrlichtLime::IO::FileList^ FileArchive::FileList::get()
{
	io::IFileList* l = (io::IFileList*)m_FileArchive->getFileList(); // !!! cast to non-const
	return IrrlichtLime::IO::FileList::Wrap(l);
}

String^ FileArchive::Password::get()
{
	return gcnew String(m_FileArchive->Password.c_str());
}

void FileArchive::Password::set(String^ value)
{
	LIME_ASSERT(value != nullptr);
	m_FileArchive->Password = Lime::StringToStringC(value);
}

FileArchiveType FileArchive::Type::get()
{
	return (FileArchiveType)m_FileArchive->getType();
}

} // end namespace IO
} // end namespace IrrlichtLime