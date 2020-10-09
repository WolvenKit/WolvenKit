#include "stdafx.h"
#include "ReadFile.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

ReadFile^ ReadFile::Wrap(io::IReadFile* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew ReadFile(ref);
}

ReadFile::ReadFile(io::IReadFile* ref)
	: ReferenceCounted(ref)
{
	m_ReadFile = ref;
}

array<unsigned char>^ ReadFile::Read(int bytesToRead)
{
	LIME_ASSERT(bytesToRead > 0);

	unsigned char* b = new unsigned char[bytesToRead];

	int s = (int)m_ReadFile->read(b, (size_t) bytesToRead);
	LIME_ASSERT(s >= 0);

	array<unsigned char>^ a = gcnew array<unsigned char>(s);
	for (int i = 0; i < s; i++)
		a[i] = b[i];

	delete[] b;
	return a;
}

bool ReadFile::Seek(long position, bool relativeMovement)
{
#ifdef _DEBUG
	if (!relativeMovement)
		LIME_ASSERT(position >= 0 && position < Size);
#endif

	return m_ReadFile->seek(position, relativeMovement);
}

bool ReadFile::Seek(long position)
{
	LIME_ASSERT(position >= 0 && position < Size);
	return m_ReadFile->seek(position);
}

String^ ReadFile::FileName::get()
{
	return gcnew String(m_ReadFile->getFileName().c_str());
}

long ReadFile::Position::get()
{
	return m_ReadFile->getPos();
}

long ReadFile::Size::get()
{
	return m_ReadFile->getSize();
}

String^ ReadFile::ToString()
{
	return String::Format("ReadFile: FileName={0}; Position={1}", FileName, Position);
}

} // end namespace IO
} // end namespace IrrlichtLime