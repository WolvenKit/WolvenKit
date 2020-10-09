#pragma once

#include "stdafx.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace IO {

public ref class NamedPath : Lime::NativeValue<io::SNamedPath>
{
public:

	NamedPath()
		: Lime::NativeValue<io::SNamedPath>(true)
	{
		m_NativeValue = new io::SNamedPath();
	}

	NamedPath(String^ path)
		: Lime::NativeValue<io::SNamedPath>(true)
	{
		LIME_ASSERT(path != nullptr);
		m_NativeValue = new io::SNamedPath(Lime::StringToPath(path));
	}

	property String^ InternalName
	{
		String^ get()
		{
			return gcnew String(m_NativeValue->getInternalName().c_str());
		}
	}

	property String^ Path
	{
		String^ get()
		{
			return gcnew String(m_NativeValue->getPath().c_str());
		}

		void set(String^ value)
		{
			LIME_ASSERT(value != nullptr);
			m_NativeValue->setPath(Lime::StringToPath(value));
		}
	}

	virtual String^ ToString() override
	{
		return String::Format("NamedPath: Path={0}", Path);
	}

internal:

	NamedPath(const io::SNamedPath& value)
		: Lime::NativeValue<io::SNamedPath>(true)
	{
		m_NativeValue = new io::SNamedPath(value);
	}

	NamedPath(io::SNamedPath* ref)
		: Lime::NativeValue<io::SNamedPath>(false)
	{
		LIME_ASSERT(ref != nullptr);
		m_NativeValue = ref;
	}
};

} // end namespace IO
} // end namespace IrrlichtLime