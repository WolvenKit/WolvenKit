#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace Video { ref class VideoDriver; }
namespace IO {

ref class ArchiveLoader;
ref class Attributes;
ref class FileArchive;
ref class FileList;
ref class ReadFile;
ref class WriteFile;

public ref class FileSystem : ReferenceCounted
{
public:

	void AddArchiveLoader(ArchiveLoader^ loader);

	bool AddFileArchive(String^ filename, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType, String^ password, [Out] FileArchive^% addedArchive);
	bool AddFileArchive(String^ filename, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType, String^ password);
	bool AddFileArchive(String^ filename, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType);
	bool AddFileArchive(String^ filename, bool ignoreCase, bool ignorePaths);
	bool AddFileArchive(String^ filename, bool ignoreCase);
	bool AddFileArchive(String^ filename);

	bool AddFileArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType, String^ password, [Out] FileArchive^% addedArchive);
	bool AddFileArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType, String^ password);
	bool AddFileArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths, FileArchiveType archiveType);
	bool AddFileArchive(ReadFile^ file, bool ignoreCase, bool ignorePaths);
	bool AddFileArchive(ReadFile^ file, bool ignoreCase);
	bool AddFileArchive(ReadFile^ file);

	bool AddFileArchive(FileArchive^ archive);

	Attributes^ CreateAttributes(Video::VideoDriver^ driver);
	Attributes^ CreateAttributes();

	ReadFile^ CreateReadFile(String^ filename);
	WriteFile^ CreateWriteFile(String^ filename, bool append);
	WriteFile^ CreateWriteFile(String^ filename);

	FileList^ CreateFileList(String^ path, bool ignoreCase, bool ignorePaths);
	FileList^ CreateFileListFromWorkingDirectory();

	ReadFile^ CreateLimitReadFile(String^ filename, ReadFile^ alreadyOpenedFile, long areaPosition, long areaSize);
	ReadFile^ CreateMemoryReadFile(String^ filename, array<unsigned char>^ content);
	WriteFile^ CreateMemoryWriteFile(String^ filename, int length);

	ArchiveLoader^ GetArchiveLoader(int index);
	String^ GetFileAbsolutePath(String^ filename);
	FileArchive^ GetFileArchive(int index);
	String^ GetFileBasename(String^ filename, bool keepExtension);
	String^ GetFileBasename(String^ filename);
	String^ GetFileDirectory(String^ filename);
	String^ GetRelativeFilename(String^ filename, String^ directory);

	bool MoveFileArchive(int index, int relative);
	bool RemoveFileArchive(int index);
	bool RemoveFileArchive(String^ filename);
	bool RemoveFileArchive(FileArchive^ archive);

	FileSystemType SetFileSystemType(FileSystemType newType);

	property int ArchiveLoaderCount { int get(); }
	property int FileArchiveCount { int get(); }
	property String^ WorkingDirectory { String^ get(); void set(String^ value); }

	virtual String^ ToString() override;

internal:

	static FileSystem^ Wrap(io::IFileSystem* ref);
	FileSystem(io::IFileSystem* ref);

	io::IFileSystem* m_FileSystem;
};

} // end namespace IO
} // end namespace IrrlichtLime