#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

public ref class WriteFile : ReferenceCounted
{
public:

	bool Seek(long position, bool relativeMovement);
	bool Seek(long position);

	int Write(array<unsigned char>^ buffer);

	property String^ FileName { String^ get(); }
	property long Position { long get(); }

	virtual String^ ToString() override;

internal:

	static WriteFile^ Wrap(io::IWriteFile* ref);
	WriteFile(io::IWriteFile* ref);

	io::IWriteFile* m_WriteFile;
};

} // end namespace IO
} // end namespace IrrlichtLime