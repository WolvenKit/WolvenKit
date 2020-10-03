#pragma once

#include "stdafx.h"
#include "AttributeExchangingObject.h"
#include "GUIEnvironment.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace GUI {

class GUIElementInheritor;

public ref class GUIElement : IO::AttributeExchangingObject
{
public:

	void AddChild(GUIElement^ child);

	bool SendToBack(GUIElement^ child);
	bool BringToFront(GUIElement^ child);

	void Draw();
	bool Event(Event^ evnt);

	GUIElement^ GetElementFromID(int id, bool searchchildren);
	GUIElement^ GetElementFromID(int id);
	GUIElement^ GetElementFromPoint(Vector2Di^ point);

	bool GetNextElement(int startOrder, bool reverse, bool group, [Out] GUIElement^% first, [Out] GUIElement^% closest, bool includeInvisible);
	bool GetNextElement(int startOrder, bool reverse, bool group, [Out] GUIElement^% first, [Out] GUIElement^% closest);

	bool IsMyChild(GUIElement^ child);
	bool IsPointInside(Vector2Di^ point);

	void Move(Vector2Di^ absoluteMovement);

	void Remove();
	void RemoveChild(GUIElement^ child);

	void SetAlignment(GUIAlignment left, GUIAlignment right, GUIAlignment top, GUIAlignment bottom);

	void SetMaxSize(Dimension2Di^ size);
	void SetMinSize(Dimension2Di^ size);

	void SetRelativePositionProportional(Rectf^ relativePosition);

	void UpdateAbsolutePosition();

	property Recti^ AbsoluteClippingRect { Recti^ get(); }
	property Recti^ AbsolutePosition { Recti^ get(); }
	property array<GUIElement^>^ Children { array<GUIElement^>^ get(); }
	property bool Clipped { bool get(); void set(bool value); }
	property bool Enabled { bool get(); void set(bool value); }
	property int ID { int get(); void set(int value); }
	property String^ Name { String^ get(); void set(String^ value); }
	property GUIElement^ Parent { GUIElement^ get(); }
	property Recti^ RelativePosition { Recti^ get(); void set(Recti^ value); }
	property bool SubElement { bool get(); void set(bool value); }
	property bool TabGroup { bool get(); void set(bool value); }
	property GUIElement^ TabGroupElement { GUIElement^ get(); }
	property int TabOrder { int get(); void set(int value); }
	property bool TabStop { bool get(); void set(bool value); }
	property String^ Text { String^ get(); void set(String^ value); }
	property String^ ToolTipText { String^ get(); void set(String^ value); }
	property bool TrulyVisible { bool get(); }
	property GUIElementType Type { GUIElementType get(); }
	property String^ TypeName { String^ get(); }
	property bool Visible { bool get(); void set(bool value); }

	virtual String^ ToString() override;

	delegate void DrawEventHandler();
	delegate bool OnEventEventHandler(IrrlichtLime::Event^ evnt);

protected:

	GUIElement(GUIElementType type, GUIEnvironment^ environment, GUIElement^ parent, Recti^ rectangle, int id);
	GUIElement(GUIElementType type, GUIEnvironment^ environment, GUIElement^ parent, Recti^ rectangle);

	event DrawEventHandler^ OnDraw;
	event OnEventEventHandler^ OnEvent;

	property GUIEnvironment^ Environment { GUIEnvironment^ get(); void set(GUIEnvironment^ value); }

internal:

	static GUIElement^ Wrap(gui::IGUIElement* ref);
	GUIElement(gui::IGUIElement* ref);

	gui::IGUIElement* m_GUIElement;
	bool m_Inherited;

private:

	void initInheritor(GUIElementInheritor* i);
};

} // end namespace GUI
} // end namespace IrrlichtLime