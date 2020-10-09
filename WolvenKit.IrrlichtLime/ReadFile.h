#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

public ref class ReadFile : ReferenceCounted
{
public:

	array<unsigned char>^ Read(int bytesToRead);

	bool Seek(long position, bool relativeMovement);
	bool Seek(long position);

	property String^ FileName { String^ get(); }
	property long Position { long get(); }
	property long Size { long get(); }

	virtual String^ ToString() override;

internal:

	static ReadFile^ Wrap(io::IReadFile* ref);
	ReadFile(io::IReadFile* ref);

	io::IReadFile* m_ReadFile;
};

} // end namespace IO
} // end namespace IrrlichtLime