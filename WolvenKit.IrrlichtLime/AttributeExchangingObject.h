#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

ref class Attributes;

public ref class AttributeExchangingObject : ReferenceCounted
{
public:

	void DeserializeAttributes(Attributes^ deserializeFrom, AttributeReadWriteOptions^ options);
	void DeserializeAttributes(Attributes^ deserializeFrom);

	void SerializeAttributes(Attributes^ serializeTo, AttributeReadWriteOptions^ options);
	void SerializeAttributes(Attributes^ serializeTo);

internal:

	AttributeExchangingObject(io::IAttributeExchangingObject* ref_or_null);
	void setAttributeExchangingObject(io::IAttributeExchangingObject* ref);

	io::IAttributeExchangingObject* m_AttributeExchangingObject;
};

} // end namespace IO
} // end namespace IrrlichtLime