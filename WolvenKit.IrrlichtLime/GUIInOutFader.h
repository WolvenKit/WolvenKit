#pragma once

#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

public ref class GUIInOutFader : GUIElement
{
public:

	void FadeIn(unsigned int time);
	void FadeOut(unsigned int time);

	void SetColor(Video::Color^ source, Video::Color^ dest);
	void SetColor(Video::Color^ bothAplhaIgnored);

	property bool Ready { bool get(); }

internal:

	static GUIInOutFader^ Wrap(gui::IGUIInOutFader* ref);
	GUIInOutFader(gui::IGUIInOutFader* ref);

	gui::IGUIInOutFader* m_GUIInOutFader;
};

} // end namespace GUI
} // end namespace IrrlichtLime