#include "stdafx.h"
#include "FileList.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

FileList^ FileList::Wrap(io::IFileList* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew FileList(ref);
}

FileList::FileList(io::IFileList* ref)
	: ReferenceCounted(ref)
{
	m_FileList = ref;
}

int FileList::AddFile(String^ fullPath, int offset, int size, bool isDirectory, int id)
{
	LIME_ASSERT(fullPath != nullptr);
	LIME_ASSERT(offset >= 0);
	LIME_ASSERT(size >= 0);
	LIME_ASSERT(id >= 0);

	return m_FileList->addItem(Lime::StringToPath(fullPath), offset, size, isDirectory, id);
}

int FileList::AddFile(String^ fullPath, int offset, int size, bool isDirectory)
{
	LIME_ASSERT(fullPath != nullptr);
	LIME_ASSERT(offset >= 0);
	LIME_ASSERT(size >= 0);

	return m_FileList->addItem(Lime::StringToPath(fullPath), offset, size, isDirectory);
}

int FileList::FindFile(String^ filename, bool isDirectory)
{
	LIME_ASSERT(filename != nullptr);
	return m_FileList->findFile(Lime::StringToPath(filename), isDirectory);
}

int FileList::FindFile(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return m_FileList->findFile(Lime::StringToPath(filename));
}

int FileList::GetFileID(int index)
{
	LIME_ASSERT(index >= 0 && index < Count);
	return m_FileList->getID(index);
}

String^ FileList::GetFileName(int index)
{
	LIME_ASSERT(index >= 0 && index < Count);
	return gcnew String(m_FileList->getFileName(index).c_str());
}

int FileList::GetFileOffset(int index)
{
	LIME_ASSERT(index >= 0 && index < Count);
	return m_FileList->getFileOffset(index);
}

int FileList::GetFileSize(int index)
{
	LIME_ASSERT(index >= 0 && index < Count);
	return m_FileList->getFileSize(index);
}

String^ FileList::GetFullFileName(int index)
{
	LIME_ASSERT(index >= 0 && index < Count);
	return gcnew String(m_FileList->getFullFileName(index).c_str());
}

bool FileList::IsDirectory(int index)
{
	LIME_ASSERT(index >= 0 && index < Count);
	return m_FileList->isDirectory(index);
}

void FileList::Sort()
{
	m_FileList->sort();
}

int FileList::Count::get()
{
	return m_FileList->getFileCount();
}

String^ FileList::Path::get()
{
	return gcnew String(m_FileList->getPath().c_str());
}

} // end namespace IO
} // end namespace IrrlichtLime