#include "stdafx.h"
#include "GUISpriteBank.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace GUI {

GUISpriteBank^ GUISpriteBank::Wrap(gui::IGUISpriteBank* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUISpriteBank(ref);
}

GUISpriteBank::GUISpriteBank(gui::IGUISpriteBank* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUISpriteBank = ref;
}

} // end namespace GUI
} // end namespace IrrlichtLime