#pragma once

#include <vcclr.h> // for gcroot
#include "stdafx.h"
#include "GUIElement.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

class GUIElementInheritor : public gui::IGUIElement
{
public:

	GUIElementInheritor(gui::EGUI_ELEMENT_TYPE type, gui::IGUIEnvironment* environment, gui::IGUIElement* parent,
		s32 id, const core::rect<s32>& rectangle)
		: gui::IGUIElement(type, environment, parent, id, rectangle)
	{
	}

	gcroot<GUIElement::DrawEventHandler^> m_drawHandler;
	virtual void draw()
	{
		m_drawHandler->Invoke();
		gui::IGUIElement::draw();
	}

	gcroot<GUIElement::OnEventEventHandler^> m_OnEventHandler;
	virtual bool OnEvent(const SEvent& e)
	{
		bool b = m_OnEventHandler->Invoke(gcnew Event(e));

		if (!b)
			b = gui::IGUIElement::OnEvent(e);

		return b;
	}

// internal:

	gui::IGUIEnvironment* Environment_get()
	{
		return this->Environment;
	}

	void Environment_set(gui::IGUIEnvironment* newEnv)
	{
		this->Environment = newEnv;
	}
};

} // end namespace GUI
} // end namespace IrrlichtLime