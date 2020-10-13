#include "stdafx.h"
#include "AttributeExchangingObject.h"
#include "Attributes.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace IO {

AttributeExchangingObject::AttributeExchangingObject(io::IAttributeExchangingObject* ref_or_null)
	: ReferenceCounted(ref_or_null)
{
	m_AttributeExchangingObject = ref_or_null;
}

void AttributeExchangingObject::DeserializeAttributes(Attributes^ deserializeFrom, AttributeReadWriteOptions^ options)
{
	LIME_ASSERT(deserializeFrom != nullptr);

	io::SAttributeReadWriteOptions* o = AttributeReadWriteOptions::Allocate_SAttributeReadWriteOptions(options);
	m_AttributeExchangingObject->deserializeAttributes(LIME_SAFEREF(deserializeFrom, m_Attributes), o);
	AttributeReadWriteOptions::Free_SAttributeReadWriteOptions(o);
}

void AttributeExchangingObject::DeserializeAttributes(Attributes^ deserializeFrom)
{
	LIME_ASSERT(deserializeFrom != nullptr);
	m_AttributeExchangingObject->deserializeAttributes(LIME_SAFEREF(deserializeFrom, m_Attributes));
}

void AttributeExchangingObject::SerializeAttributes(Attributes^ serializeTo, AttributeReadWriteOptions^ options)
{
	LIME_ASSERT(serializeTo != nullptr);

	io::SAttributeReadWriteOptions* o = AttributeReadWriteOptions::Allocate_SAttributeReadWriteOptions(options);
	m_AttributeExchangingObject->serializeAttributes(LIME_SAFEREF(serializeTo, m_Attributes), o);
	AttributeReadWriteOptions::Free_SAttributeReadWriteOptions(o);
}

void AttributeExchangingObject::SerializeAttributes(Attributes^ serializeTo)
{
	LIME_ASSERT(serializeTo != nullptr);
	m_AttributeExchangingObject->serializeAttributes(LIME_SAFEREF(serializeTo, m_Attributes));
}

void AttributeExchangingObject::setAttributeExchangingObject(io::IAttributeExchangingObject* ref)
{
	LIME_ASSERT(ref != nullptr);

	m_ReferenceCounted = ref;
	m_AttributeExchangingObject = ref;
}

} // end namespace IO
} // end namespace IrrlichtLime