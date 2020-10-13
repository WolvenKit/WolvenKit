#include "stdafx.h"
#include "OSOperator.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {

OSOperator^ OSOperator::Wrap(irr::IOSOperator* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew OSOperator(ref);
}

OSOperator::OSOperator(irr::IOSOperator* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_OSOperator = ref;
}

String^ OSOperator::ClipboardText::get()
{
	return gcnew String(m_OSOperator->getTextFromClipboard());
}

void OSOperator::ClipboardText::set(String^ value)
{
	m_OSOperator->copyToClipboard(LIME_SAFESTRINGTOSTRINGC_C_STR(value));
}

String^ OSOperator::OSVersion::get()
{
	return gcnew String(m_OSOperator->getOperatingSystemVersion().c_str());
}

int OSOperator::ProcessorSpeedMHz::get()
{
	u32 s;
	bool b = m_OSOperator->getProcessorSpeedMHz(&s);

	return b ? s : -1;
}

int OSOperator::MemoryFreeKb::get()
{
	u32 t;
	u32 f;
	bool b = m_OSOperator->getSystemMemory(&t, &f);

	return b ? f : -1;
}

int OSOperator::MemoryTotalKb::get()
{
	u32 t;
	u32 f;
	bool b = m_OSOperator->getSystemMemory(&t, &f);

	return b ? t : -1;
}

String^ OSOperator::ToString()
{
	return String::Format("OSOperator: OSVersion={0}", OSVersion);
}

} // end namespace IrrlichtLime