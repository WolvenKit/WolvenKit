#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

public ref class Attributes : ReferenceCounted
{
public:

	static int MaxByteArraySize = 64 * 1024;
	static AttributeType GetAttributeTypeFromValue(Object^ value);

	void AddValue(String^ attributeName, Object^ value);

	void Clear();

	bool Exists(String^ attributeName);

	int GetIndex(String^ attributeName);

	String^ GetName(int attributeIndex);

	AttributeType GetType(String^ attributeName);
	AttributeType GetType(int attributeIndex);

	String^ GetTypeString(String^ attributeName);
	String^ GetTypeString(int attributeIndex);

	Object^ GetValue(String^ attributeName);
	Object^ GetValue(int attributeIndex);

	void SetValue(String^ attributeName, Object^ value);
	void SetValue(int attributeIndex, Object^ value);

	property int Count { int get(); }
	property Dictionary<String^, Object^>^ List { Dictionary<String^, Object^>^ get(); }

	virtual String^ ToString() override;

internal:

	static Attributes^ Wrap(io::IAttributes* ref);
	Attributes(io::IAttributes* ref);

	io::IAttributes* m_Attributes;
};

} // end namespace IO
} // end namespace IrrlichtLime