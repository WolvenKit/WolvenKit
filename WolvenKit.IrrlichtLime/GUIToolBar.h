#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video { ref class Texture; }
namespace GUI {

ref class GUIButton;

public ref class GUIToolBar : GUIElement
{
public:

	GUIButton^ AddButton(int id, String^ text, String^ toolTipText, Video::Texture^ img, Video::Texture^ pressedImg, bool isPushButton, bool useAlphaChannel);
	GUIButton^ AddButton(int id, String^ text, String^ toolTipText, Video::Texture^ img, Video::Texture^ pressedImg, bool isPushButton);
	GUIButton^ AddButton(int id, String^ text, String^ toolTipText, Video::Texture^ img, Video::Texture^ pressedImg);
	GUIButton^ AddButton(int id, String^ text, String^ toolTipText, Video::Texture^ img);
	GUIButton^ AddButton(int id, String^ text, String^ toolTipText);
	GUIButton^ AddButton(int id, String^ text);
	GUIButton^ AddButton(int id);
	GUIButton^ AddButton();

internal:

	static GUIToolBar^ Wrap(gui::IGUIToolBar* ref);
	GUIToolBar(gui::IGUIToolBar* ref);

	gui::IGUIToolBar* m_GUIToolBar;
};

} // end namespace GUI
} // end namespace IrrlichtLime