#pragma once

#include "stdafx.h"
#include "AttributeExchangingObject.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace GUI {

ref class GUIElement;
ref class GUIFont;
ref class GUISpriteBank;

public ref class GUISkin : IO::AttributeExchangingObject
{
public:

	void Draw2DRectangle(GUIElement^ element, Video::Color^ color, Recti^ pos, Recti^ clip);
	void Draw2DRectangle(GUIElement^ element, Video::Color^ color, Recti^ pos);

	void Draw3DButtonPanePressed(GUIElement^ element, Recti^ rect, Recti^ clip);
	void Draw3DButtonPanePressed(GUIElement^ element, Recti^ rect);

	void Draw3DButtonPaneStandard(GUIElement^ element, Recti^ rect, Recti^ clip);
	void Draw3DButtonPaneStandard(GUIElement^ element, Recti^ rect);

	void Draw3DMenuPane(GUIElement^ element, Recti^ rect, Recti^ clip);
	void Draw3DMenuPane(GUIElement^ element, Recti^ rect);

	void Draw3DSunkenPane(GUIElement^ element, Video::Color^ bgcolor, bool flat, bool fillBackGround, Recti^ rect, Recti^ clip);
	void Draw3DSunkenPane(GUIElement^ element, Video::Color^ bgcolor, bool flat, bool fillBackGround, Recti^ rect);

	void Draw3DTabBody(GUIElement^ element, bool border, bool background, Recti^ rect, Recti^ clip, int tabHeight, GUIAlignment alignment);
	void Draw3DTabBody(GUIElement^ element, bool border, bool background, Recti^ rect, Recti^ clip, int tabHeight);
	void Draw3DTabBody(GUIElement^ element, bool border, bool background, Recti^ rect, Recti^ clip);
	void Draw3DTabBody(GUIElement^ element, bool border, bool background, Recti^ rect);

	void Draw3DTabButton(GUIElement^ element, bool active, Recti^ rect, Recti^ clip, GUIAlignment alignment);
	void Draw3DTabButton(GUIElement^ element, bool active, Recti^ rect, Recti^ clip);
	void Draw3DTabButton(GUIElement^ element, bool active, Recti^ rect);

	void Draw3DToolBar(GUIElement^ element, Recti^ rect, Recti^ clip);
	void Draw3DToolBar(GUIElement^ element, Recti^ rect);

	Recti^ Draw3DWindowBackground(GUIElement^ element, bool drawTitleBar, Video::Color^ titleBarColor, Recti^ rect, Recti^ clip, [Out] Recti^ checkClientArea);
	Recti^ Draw3DWindowBackground(GUIElement^ element, bool drawTitleBar, Video::Color^ titleBarColor, Recti^ rect, Recti^ clip);
	Recti^ Draw3DWindowBackground(GUIElement^ element, bool drawTitleBar, Video::Color^ titleBarColor, Recti^ rect);

	void DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position, unsigned int starttime, unsigned int currenttime, bool loop, Recti^ clip);
	void DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position, unsigned int starttime, unsigned int currenttime, bool loop);
	void DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position, unsigned int starttime, unsigned int currenttime);
	void DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position, unsigned int starttime);
	void DrawIcon(GUIElement^ element, GUIDefaultIcon icon, Vector2Di^ position);

	Video::Color^ GetColor(GUIDefaultColor color);
	String^ GetText(GUIDefaultText text);
	GUIFont^ GetFont(GUIDefaultFont which);
	int GetIcon(GUIDefaultIcon icon);
	int GetSize(GUIDefaultSize size);

	void SetColor(Video::Color^ newColor, GUIDefaultColor which);
	void SetText(String^ newText, GUIDefaultText which);
	void SetFont(GUIFont^ font, GUIDefaultFont which);
	void SetFont(GUIFont^ font);
	void SetIcon(int index, GUIDefaultIcon which);
	void SetSize(int size, GUIDefaultSize which);

	property GUISpriteBank^ SpriteBank { GUISpriteBank^ get(); void set(GUISpriteBank^ value); }
	property GUISkinType Type { GUISkinType get(); }

	virtual String^ ToString() override;

internal:

	static GUISkin^ Wrap(gui::IGUISkin* ref);
	GUISkin(gui::IGUISkin* ref);

	gui::IGUISkin* m_GUISkin;
};

} // end namespace GUI
} // end namespace IrrlichtLime