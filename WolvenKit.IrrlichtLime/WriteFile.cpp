#include "stdafx.h"
#include "ReferenceCounted.h"
#include "WriteFile.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

WriteFile^ WriteFile::Wrap(io::IWriteFile* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew WriteFile(ref);
}

WriteFile::WriteFile(io::IWriteFile* ref)
	: ReferenceCounted(ref)
{
	m_WriteFile = ref;
}

bool WriteFile::Seek(long position, bool relativeMovement)
{
#ifdef _DEBUG
	if (!relativeMovement)
		LIME_ASSERT(position >= 0);
#endif

	return m_WriteFile->seek(position, relativeMovement);
}

bool WriteFile::Seek(long position)
{
	LIME_ASSERT(position >= 0);
	return m_WriteFile->seek(position);
}

int WriteFile::Write(array<unsigned char>^ buffer)
{
	LIME_ASSERT(buffer != nullptr);

	int c = buffer->Length;
	unsigned char* b = new unsigned char[c];

	for (int i = 0; i < c; i++)
		b[i] = buffer[i];

	int r = (int) m_WriteFile->write(b, c);

	delete[] b;
	return r;
}

String^ WriteFile::FileName::get()
{
	return gcnew String(m_WriteFile->getFileName().c_str());
}

long WriteFile::Position::get()
{
	return m_WriteFile->getPos();
}

String^ WriteFile::ToString()
{
	return String::Format("WriteFile: FileName={0}; Position={1}", FileName, Position);
}

} // end namespace IO
} // end namespace IrrlichtLime