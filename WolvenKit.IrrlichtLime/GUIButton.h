#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace Video { ref class Texture; }
namespace GUI {

ref class GUIFont;
ref class GUISpriteBank;

public ref class GUIButton : GUIElement
{
public:

	void SetNormalImage(Video::Texture^ image, Recti^ pos);
	void SetNormalImage(Video::Texture^ image);
	void SetNormalImage();

	void SetPressedImage(Video::Texture^ image, Recti^ pos);
	void SetPressedImage(Video::Texture^ image);
	void SetPressedImage();

	void SetSprite(GUIButtonState state, int index, Video::Color^ color, bool loop);
	void SetSprite(GUIButtonState state, int index, Video::Color^ color);
	void SetSprite(GUIButtonState state, int index);

	void SetSpriteBank(GUISpriteBank^ bank);
	void SetSpriteBank();

	property GUIFont^ ActiveFont { GUIFont^ get(); }
	property bool AlphaChannel { bool get(); void set(bool value); }
	property bool Border { bool get(); void set(bool value); }
	property GUIFont^ OverrideFont { GUIFont^ get(); void set(GUIFont^ value); }
	property bool Pressed { bool get(); void set(bool value); }
	property bool PushButton { bool get(); void set(bool value); }
	property bool ScaleImage { bool get(); void set(bool value); }

internal:

	static GUIButton^ Wrap(gui::IGUIButton* ref);
	GUIButton(gui::IGUIButton* ref);

	gui::IGUIButton* m_GUIButton;
};

} // end namespace GUI
} // end namespace IrrlichtLime