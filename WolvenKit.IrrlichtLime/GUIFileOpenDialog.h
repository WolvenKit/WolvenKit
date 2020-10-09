#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

public ref class GUIFileOpenDialog : GUIElement
{
public:

	property String^ DirectoryName { String^ get(); }
	property String^ FileName { String^ get(); }

internal:

	static GUIFileOpenDialog^ Wrap(gui::IGUIFileOpenDialog* ref);
	GUIFileOpenDialog(gui::IGUIFileOpenDialog* ref);

	gui::IGUIFileOpenDialog* m_GUIFileOpenDialog;
};

} // end namespace GUI
} // end namespace IrrlichtLime