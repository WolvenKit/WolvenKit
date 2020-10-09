#include "stdafx.h"
#include "GUIColorSelectDialog.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIColorSelectDialog^ GUIColorSelectDialog::Wrap(gui::IGUIColorSelectDialog* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIColorSelectDialog(ref);
}

GUIColorSelectDialog::GUIColorSelectDialog(gui::IGUIColorSelectDialog* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIColorSelectDialog = ref;
}

} // end namespace GUI
} // end namespace IrrlichtLime