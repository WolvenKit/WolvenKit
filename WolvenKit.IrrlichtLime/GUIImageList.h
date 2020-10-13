#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

public ref class GUIImageList : ReferenceCounted
{
public:

	void Draw(int index, Vector2Di^ destPos, Recti^ clip);
	void Draw(int index, Vector2Di^ destPos);

	property int ImageCount { int get(); }
	property Dimension2Di^ ImageSize { Dimension2Di^ get(); }

internal:

	static GUIImageList^ Wrap(gui::IGUIImageList* ref);
	GUIImageList(gui::IGUIImageList* ref);

	gui::IGUIImageList* m_GUIImageList;
};

} // end namespace GUI
} // end namespace IrrlichtLime