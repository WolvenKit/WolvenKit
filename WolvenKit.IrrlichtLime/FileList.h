#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

public ref class FileList : ReferenceCounted
{
public:

	int AddFile(String^ fullPath, int offset, int size, bool isDirectory, int id);
	int AddFile(String^ fullPath, int offset, int size, bool isDirectory);

	int FindFile(String^ filename, bool isDirectory);
	int FindFile(String^ filename);

	int GetFileID(int index);
	String^ GetFileName(int index);
	int GetFileOffset(int index);
	int GetFileSize(int index);
	String^ GetFullFileName(int index);

	bool IsDirectory(int index);

	void Sort();

	property int Count { int get(); }
	property String^ Path { String^ get(); }

internal:

	static FileList^ Wrap(io::IFileList* ref);
	FileList(io::IFileList* ref);

	io::IFileList* m_FileList;
};

} // end namespace IO
} // end namespace IrrlichtLime