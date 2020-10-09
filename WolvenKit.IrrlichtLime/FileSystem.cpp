#include "stdafx.h"
#include "ArchiveLoader.h"
#include "Attributes.h"
#include "FileArchive.h"
#include "FileList.h"
#include "FileSystem.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"
#include "VideoDriver.h"
#include "WriteFile.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

FileSystem^ FileSystem::Wrap(io::IFileSystem* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew FileSystem(ref);
}

FileSystem::FileSystem(io::IFileSystem* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_FileSystem = ref;
}

void FileSystem::AddArchiveLoader(ArchiveLoader^ loader)
{
	LIME_ASSERT(loader != nullptr);
	m_FileSystem->addArchiveLoader(loader->m_ArchiveLoader);
}

bool FileSystem::AddFileArchive(String^ filename, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType, String^ password, [Out] FileArchive^% addedArchive)
{
	LIME_ASSERT(filename != nullptr);
	LIME_ASSERT(password != nullptr);

	io::IFileArchive* a;

	bool b = m_FileSystem->addFileArchive(
		Lime::StringToPath(filename),
		ignoreCase,
		ignorePaths,
		(io::E_FILE_ARCHIVE_TYPE) archiveType,
		Lime::StringToStringC(password),
		&a);

	if (b && a != nullptr)
		addedArchive = FileArchive::Wrap(a);

	return b;
}

bool FileSystem::AddFileArchive(String^ filename, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType, String^ password)
{
	LIME_ASSERT(filename != nullptr);
	LIME_ASSERT(password != nullptr);

	return m_FileSystem->addFileArchive(
		Lime::StringToPath(filename),
		ignoreCase,
		ignorePaths,
		(io::E_FILE_ARCHIVE_TYPE) archiveType,
		Lime::StringToStringC(password));
}

bool FileSystem::AddFileArchive(String^ filename, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType)
{
	LIME_ASSERT(filename != nullptr);

	return m_FileSystem->addFileArchive(
		Lime::StringToPath(filename),
		ignoreCase,
		ignorePaths,
		(io::E_FILE_ARCHIVE_TYPE) archiveType);
}

bool FileSystem::AddFileArchive(String^ filename, bool ignoreCase, bool ignorePaths)
{
	LIME_ASSERT(filename != nullptr);

	return m_FileSystem->addFileArchive(
		Lime::StringToPath(filename),
		ignoreCase,
		ignorePaths);
}

bool FileSystem::AddFileArchive(String^ filename, bool ignoreCase)
{
	LIME_ASSERT(filename != nullptr);

	return m_FileSystem->addFileArchive(
		Lime::StringToPath(filename),
		ignoreCase);
}

bool FileSystem::AddFileArchive(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	return m_FileSystem->addFileArchive(
		Lime::StringToPath(filename));
}

bool FileSystem::AddFileArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType, String^ password, [Out] FileArchive^% addedArchive)
{
	LIME_ASSERT(file != nullptr);
	LIME_ASSERT(password != nullptr);

	io::IFileArchive* a;

	bool b = m_FileSystem->addFileArchive(
		file->m_ReadFile,
		ignoreCase,
		ignorePaths,
		(io::E_FILE_ARCHIVE_TYPE) archiveType,
		Lime::StringToStringC(password),
		&a);

	if (b && a != nullptr)
		addedArchive = FileArchive::Wrap(a);

	return b;
}

bool FileSystem::AddFileArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType, String^ password)
{
	LIME_ASSERT(file != nullptr);
	LIME_ASSERT(password != nullptr);

	return m_FileSystem->addFileArchive(
		file->m_ReadFile,
		ignoreCase,
		ignorePaths,
		(io::E_FILE_ARCHIVE_TYPE) archiveType,
		Lime::StringToStringC(password));
}

bool FileSystem::AddFileArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType)
{
	LIME_ASSERT(file != nullptr);

	return m_FileSystem->addFileArchive(
		file->m_ReadFile,
		ignoreCase,
		ignorePaths,
		(io::E_FILE_ARCHIVE_TYPE)archiveType);
}

bool FileSystem::AddFileArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths)
{
	LIME_ASSERT(file != nullptr);

	return m_FileSystem->addFileArchive(
		file->m_ReadFile,
		ignoreCase,
		ignorePaths);
}

bool FileSystem::AddFileArchive(ReadFile^ file, bool ignoreCase)
{
	LIME_ASSERT(file != nullptr);

	return m_FileSystem->addFileArchive(
		file->m_ReadFile,
		ignoreCase);
}

bool FileSystem::AddFileArchive(ReadFile^ file)
{
	LIME_ASSERT(file != nullptr);

	return m_FileSystem->addFileArchive(
		file->m_ReadFile);
}

bool FileSystem::AddFileArchive(FileArchive^ archive)
{
	LIME_ASSERT(archive != nullptr);
	return m_FileSystem->addFileArchive(archive->m_FileArchive);
}

Attributes^ FileSystem::CreateAttributes(Video::VideoDriver^ driver)
{
	io::IAttributes* a = m_FileSystem->createEmptyAttributes(LIME_SAFEREF(driver, m_VideoDriver));
	return Attributes::Wrap(a);
}

Attributes^ FileSystem::CreateAttributes()
{
	io::IAttributes* a = m_FileSystem->createEmptyAttributes();
	return Attributes::Wrap(a);
}

ReadFile^ FileSystem::CreateReadFile(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	io::IReadFile* f = m_FileSystem->createAndOpenFile(Lime::StringToPath(filename));
	return ReadFile::Wrap(f);
}

WriteFile^ FileSystem::CreateWriteFile(String^ filename, bool append)
{
	LIME_ASSERT(filename != nullptr);

	io::IWriteFile* f = m_FileSystem->createAndWriteFile(
		Lime::StringToPath(filename),
		append);

	return WriteFile::Wrap(f);
}

WriteFile^ FileSystem::CreateWriteFile(String^ filename)
{
	LIME_ASSERT(filename != nullptr);

	io::IWriteFile* f = m_FileSystem->createAndWriteFile(Lime::StringToPath(filename));
	return WriteFile::Wrap(f);
}

FileList^ FileSystem::CreateFileList(String^ path, bool ignoreCase, bool ignorePaths)
{
	LIME_ASSERT(path != nullptr);

	io::IFileList* l = m_FileSystem->createEmptyFileList(
		Lime::StringToPath(path),
		ignoreCase,
		ignorePaths);

	return FileList::Wrap(l);
}

FileList^ FileSystem::CreateFileListFromWorkingDirectory()
{
	io::IFileList* l = m_FileSystem->createFileList();
	return FileList::Wrap(l);
}

ReadFile^ FileSystem::CreateLimitReadFile(String^ filename, ReadFile^ alreadyOpenedFile, long areaPosition, long areaSize)
{
	LIME_ASSERT(filename != nullptr);
	LIME_ASSERT(alreadyOpenedFile != nullptr);
	LIME_ASSERT(areaSize >= 0);

	io::IReadFile* f = m_FileSystem->createLimitReadFile(
		Lime::StringToPath(filename),
		LIME_SAFEREF(alreadyOpenedFile, m_ReadFile),
		areaPosition,
		areaSize);

	return ReadFile::Wrap(f);
}

ReadFile^ FileSystem::CreateMemoryReadFile(String^ filename, array<unsigned char>^ content)
{
	LIME_ASSERT(filename != nullptr);
	LIME_ASSERT(content != nullptr);

	int c = content->Length;
	unsigned char* m = new unsigned char[c];

	for (int i = 0; i < c; i++)
		m[i] = content[i];

	io::IReadFile* f = m_FileSystem->createMemoryReadFile(
		m,
		c,
		Lime::StringToPath(filename),
		true /* allocated m will be deleted automatically on drop() */);

	return ReadFile::Wrap(f);
}

WriteFile^ FileSystem::CreateMemoryWriteFile(String^ filename, int length)
{
	LIME_ASSERT(filename != nullptr);
	LIME_ASSERT(length > 0);

	unsigned char* m = new unsigned char[length];

	io::IWriteFile* f = m_FileSystem->createMemoryWriteFile(
		m,
		length,
		Lime::StringToPath(filename),
		true /* allocated m will be deleted automatically on drop() */);

	return WriteFile::Wrap(f);
}

ArchiveLoader^ FileSystem::GetArchiveLoader(int index)
{
	LIME_ASSERT(index >= 0 && index < ArchiveLoaderCount);

	io::IArchiveLoader* l = m_FileSystem->getArchiveLoader(index);
	return ArchiveLoader::Wrap(l);
}

String^ FileSystem::GetFileAbsolutePath(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return gcnew String(m_FileSystem->getAbsolutePath(Lime::StringToPath(filename)).c_str());
}

FileArchive^ FileSystem::GetFileArchive(int index)
{
	LIME_ASSERT(index >= 0 && index < FileArchiveCount);

	io::IFileArchive* a = m_FileSystem->getFileArchive(index);
	return FileArchive::Wrap(a);
}

String^ FileSystem::GetFileBasename(String^ filename, bool keepExtension)
{
	LIME_ASSERT(filename != nullptr);
	return gcnew String(m_FileSystem->getFileBasename(Lime::StringToPath(filename), keepExtension).c_str());
}

String^ FileSystem::GetFileBasename(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return gcnew String(m_FileSystem->getFileBasename(Lime::StringToPath(filename)).c_str());
}

String^ FileSystem::GetFileDirectory(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return gcnew String(m_FileSystem->getFileDir(Lime::StringToPath(filename)).c_str());
}

String^ FileSystem::GetRelativeFilename(String^ filename, String^ directory)
{
	LIME_ASSERT(filename != nullptr);
	LIME_ASSERT(directory != nullptr);

	return gcnew String(
		m_FileSystem->getRelativeFilename(
			Lime::StringToPath(filename),
			Lime::StringToPath(directory)).c_str());
}

bool FileSystem::MoveFileArchive(int index, int relative)
{
	LIME_ASSERT(index >= 0 && index < FileArchiveCount);
	return m_FileSystem->moveFileArchive(index, relative);
}

bool FileSystem::RemoveFileArchive(int index)
{
	LIME_ASSERT(index >= 0 && index < FileArchiveCount);
	return m_FileSystem->removeFileArchive(index);
}

bool FileSystem::RemoveFileArchive(String^ filename)
{
	LIME_ASSERT(filename != nullptr);
	return m_FileSystem->removeFileArchive(Lime::StringToPath(filename));
}

bool FileSystem::RemoveFileArchive(FileArchive^ archive)
{
	LIME_ASSERT(archive != nullptr);
	return m_FileSystem->removeFileArchive(archive->m_FileArchive);
}

FileSystemType FileSystem::SetFileSystemType(FileSystemType newType)
{
	return (FileSystemType)m_FileSystem->setFileListSystem((io::EFileSystemType)newType);
}

int FileSystem::ArchiveLoaderCount::get()
{
	return m_FileSystem->getArchiveLoaderCount();
}

int FileSystem::FileArchiveCount::get()
{
	return m_FileSystem->getFileArchiveCount();
}

String^ FileSystem::WorkingDirectory::get()
{
	return gcnew String(m_FileSystem->getWorkingDirectory().c_str());
}

void FileSystem::WorkingDirectory::set(String^ value)
{
	LIME_ASSERT(value != nullptr);

	m_FileSystem->changeWorkingDirectoryTo(Lime::StringToPath(value));
	// we do not report bool result here; if this in future will be completly necessary --
	// we will provide separate "bool ChangeWorkingDirectory(String^)" method
}

String^ FileSystem::ToString()
{
	return String::Format("FileSystem: WorkingDirectory={0}; FileArchiveCount={1}", WorkingDirectory, FileArchiveCount);
}

} // end namespace IO
} // end namespace IrrlichtLime