#include "stdafx.h"
#include "GUIButton.h"
#include "GUIElement.h"
#include "GUIFileOpenDialog.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIFileOpenDialog^ GUIFileOpenDialog::Wrap(gui::IGUIFileOpenDialog* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIFileOpenDialog(ref);
}

GUIFileOpenDialog::GUIFileOpenDialog(gui::IGUIFileOpenDialog* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIFileOpenDialog = ref;
}

String^ GUIFileOpenDialog::DirectoryName::get()
{
	io::path p = m_GUIFileOpenDialog->getDirectoryName();
	return p == nullptr ? nullptr : gcnew String(p.c_str());
}

String^ GUIFileOpenDialog::FileName::get()
{
	io::path p = m_GUIFileOpenDialog->getFileName(); // Note: gui::IGUIFileOpenDialog::getFileName() returns wchar_t*
	return p == nullptr ? nullptr : gcnew String(p.c_str());
}

} // end namespace GUI
} // end namespace IrrlichtLime