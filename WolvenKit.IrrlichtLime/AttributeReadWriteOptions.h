#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace IO {

// !!! Why do we not use Lime::NativeValue here? That is why:
//
//	void AttributeReadWriteOptions::Filename::set(String^ value)
//	{
//		// !!! i don't like it! Filename is not stringc but only c8* !!!
//		// !!! returned stringc by LIME_SAFESTRINGTOSTRINGC_C_STR() going to be destroyed after this method ends !!!
//		// TODO: maybe remove this method or even all the AttributeReadWriteOptions class, its used only in de/serialization
//		// and the pointer only required on this class, so maybe design own class and use it, and only when needed create internal
//		// io::SAttributeReadWriteOptions and pass to Irrlicht? Maybe!
//		m_NativeValue->Filename = LIME_SAFESTRINGTOSTRINGC_C_STR(value);
//	}
//
// So i decided to don't hesitate and i used ordinary managed struct-like class, because every usage of
// io::SAttributeReadWriteOptions in Irrlicht is just an input arg, so Irrlicht internally only reads it.
// We are going to prepare (convert) each time when we need our class to io::SAttributeReadWriteOptions.
// Only this way we can guarantee that memory won't leak.

public ref class AttributeReadWriteOptions
{
public:

	String^ Filename;
	AttributeReadWriteFlag Flags;

	AttributeReadWriteOptions(AttributeReadWriteFlag flags, String^ filename)
		: Flags(flags)
		, Filename(filename) {}

	AttributeReadWriteOptions(AttributeReadWriteFlag flags)
		: Flags(flags)
		, Filename(nullptr) {}

	AttributeReadWriteOptions()
		: Flags((AttributeReadWriteFlag)0)
		, Filename(nullptr) {}

	virtual String^ ToString() override
	{
		return String::Format("AttributeReadWriteOptions: Flags={0}; Filename={1}", Flags, Filename);
	}

internal:

	// Allocates io::SAttributeReadWriteOptions from managed representation and returns the pointer.
	// Note: Free_SAttributeReadWriteOptions() must be called for returned pointer after all.
	// Note: returns null if null argument passed.
	static io::SAttributeReadWriteOptions* Allocate_SAttributeReadWriteOptions(AttributeReadWriteOptions^ options)
	{
		if (options == nullptr)
			return nullptr;

		io::SAttributeReadWriteOptions* o = new io::SAttributeReadWriteOptions();
		
		o->Flags = (io::E_ATTRIBUTE_READ_WRITE_FLAGS)options->Flags;
		o->Filename = nullptr;

		if (!String::IsNullOrEmpty(options->Filename))
		{
			int s = options->Filename->Length + 1;
			o->Filename = new wchar_t[s];

			core::stringw w = Lime::StringToStringW(options->Filename);
			LIME_ASSERT(s == (int)(w.size() + 1));

			wcscpy_s((wchar_t*)o->Filename, s, w.c_str());
		}

		return o;
	}

	// Frees io::SAttributeReadWriteOptions pointer, previously allocated by Allocate_SAttributeReadWriteOptions().
	// Note: if argument null, then function will do nothing.
	static void Free_SAttributeReadWriteOptions(io::SAttributeReadWriteOptions* options)
	{
		if (options == nullptr)
			return;

		if (options->Filename != nullptr)
			delete[] options->Filename;

		delete options;
	}
};

} // end namespace IO
} // end namespace IrrlichtLime