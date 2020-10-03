#include "stdafx.h"
#include "AttributeExchangingObject.h"
#include "GUIButton.h"
#include "GUICheckBox.h"
#include "GUIColorSelectDialog.h"
#include "GUIComboBox.h"
#include "GUIContextMenu.h"
#include "GUIEditBox.h"
#include "GUIElement.h"
#include "GUIEnvironment.h"
#include "GUIFileOpenDialog.h"
#include "GUIImage.h"
#include "GUIInOutFader.h"
#include "GUIListBox.h"
#include "GUIMeshViewer.h"
#include "GUIScrollBar.h"
#include "GUISpinBox.h"
#include "GUIStaticText.h"
#include "GUITab.h"
#include "GUITabControl.h"
#include "GUITable.h"
#include "GUIToolBar.h"
#include "GUITreeView.h"
#include "GUIWindow.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace GUI {

GUIElement^ GUIElement::Wrap(gui::IGUIElement* ref)
{
	if (ref == nullptr)
		return nullptr;

	switch (ref->getType())
	{
	case gui::EGUIET_BUTTON:
		return gcnew GUIButton((gui::IGUIButton*)ref);

	case gui::EGUIET_CHECK_BOX:
		return gcnew GUICheckBox((gui::IGUICheckBox*)ref);

	case gui::EGUIET_COMBO_BOX:
		return gcnew GUIComboBox((gui::IGUIComboBox*)ref);

	case gui::EGUIET_CONTEXT_MENU:
		return gcnew GUIContextMenu((gui::IGUIContextMenu*)ref);

	case gui::EGUIET_MENU:
		return gcnew GUIContextMenu((gui::IGUIContextMenu*)ref);

	case gui::EGUIET_EDIT_BOX:
		return gcnew GUIEditBox((gui::IGUIEditBox*)ref);

	case gui::EGUIET_FILE_OPEN_DIALOG:
		return gcnew GUIFileOpenDialog((gui::IGUIFileOpenDialog*)ref);

	case gui::EGUIET_COLOR_SELECT_DIALOG:
		return gcnew GUIColorSelectDialog((gui::IGUIColorSelectDialog*)ref);

	case gui::EGUIET_IN_OUT_FADER:
		return gcnew GUIInOutFader((gui::IGUIInOutFader*)ref);

	case gui::EGUIET_IMAGE:
		return gcnew GUIImage((gui::IGUIImage*)ref);

	case gui::EGUIET_LIST_BOX:
		return gcnew GUIListBox((gui::IGUIListBox*)ref);

	case gui::EGUIET_MESH_VIEWER:
		return gcnew GUIMeshViewer((gui::IGUIMeshViewer*)ref);

	case gui::EGUIET_MESSAGE_BOX:
		return gcnew GUIWindow((gui::IGUIWindow*)ref);

	case gui::EGUIET_SCROLL_BAR:
		return gcnew GUIScrollBar((gui::IGUIScrollBar*)ref);

	case gui::EGUIET_SPIN_BOX:
		return gcnew GUISpinBox((gui::IGUISpinBox*)ref);

	case gui::EGUIET_STATIC_TEXT:
		return gcnew GUIStaticText((gui::IGUIStaticText*)ref);

	case gui::EGUIET_TAB:
		return gcnew GUITab((gui::IGUITab*)ref);

	case gui::EGUIET_TAB_CONTROL:
		return gcnew GUITabControl((gui::IGUITabControl*)ref);

	case gui::EGUIET_TABLE:
		return gcnew GUITable((gui::IGUITable*)ref);

	case gui::EGUIET_TOOL_BAR:
		return gcnew GUIToolBar((gui::IGUIToolBar*)ref);

	case gui::EGUIET_TREE_VIEW:
		return gcnew GUITreeView((gui::IGUITreeView*)ref);

	case gui::EGUIET_WINDOW:
		return gcnew GUIWindow((gui::IGUIWindow*)ref);

	case gui::EGUIET_MODAL_SCREEN:
	case gui::EGUIET_ELEMENT:
	case gui::EGUIET_ROOT:
	default:
		return gcnew GUIElement(ref);
	}
}

GUIElement::GUIElement(gui::IGUIElement* ref)
	: IO::AttributeExchangingObject(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIElement = ref;
}

GUIElement::GUIElement(GUIElementType type, GUIEnvironment^ environment, GUIElement^ parent, Recti^ rectangle, int id)
	: IO::AttributeExchangingObject(nullptr)
{
	LIME_ASSERT(rectangle != nullptr);

	GUIElementInheritor* i = new GUIElementInheritor(
		(gui::EGUI_ELEMENT_TYPE)type,
		LIME_SAFEREF(environment, m_GUIEnvironment),
		LIME_SAFEREF(parent, m_GUIElement),
		id,
		*rectangle->m_NativeValue);

	initInheritor(i);
	setAttributeExchangingObject(i);
	m_GUIElement = i;
	m_Inherited = true;
}

GUIElement::GUIElement(GUIElementType type, GUIEnvironment^ environment, GUIElement^ parent, Recti^ rectangle)
	: IO::AttributeExchangingObject(nullptr)
{
	LIME_ASSERT(rectangle != nullptr);

	GUIElementInheritor* i = new GUIElementInheritor(
		(gui::EGUI_ELEMENT_TYPE)type,
		LIME_SAFEREF(environment, m_GUIEnvironment),
		LIME_SAFEREF(parent, m_GUIElement),
		-1,
		*rectangle->m_NativeValue);

	initInheritor(i);
	setAttributeExchangingObject(i);
	m_GUIElement = i;
	m_Inherited = true;
}

void GUIElement::AddChild(GUIElement^ child)
{
	LIME_ASSERT(child != nullptr);
	m_GUIElement->addChild(LIME_SAFEREF(child, m_GUIElement));
}

bool GUIElement::SendToBack(GUIElement^ child)
{
	LIME_ASSERT(child != nullptr);
	return m_GUIElement->sendToBack(LIME_SAFEREF(child, m_GUIElement));
}

bool GUIElement::BringToFront(GUIElement^ child)
{
	LIME_ASSERT(child != nullptr);
	return m_GUIElement->bringToFront(LIME_SAFEREF(child, m_GUIElement));
}

void GUIElement::Draw()
{
	if (m_Inherited)
	{
		OnDraw();
		return;
	}

	m_GUIElement->draw();
}

bool GUIElement::Event(IrrlichtLime::Event^ evnt)
{
	LIME_ASSERT(evnt != nullptr);

	if (m_Inherited)
		return OnEvent(evnt);

	return m_GUIElement->OnEvent(*evnt->m_NativeValue);
}

GUIElement^ GUIElement::GetElementFromID(int id, bool searchchildren)
{
	gui::IGUIElement *e = m_GUIElement->getElementFromId(id, searchchildren);
	return Wrap(e);
}

GUIElement^ GUIElement::GetElementFromID(int id)
{
	gui::IGUIElement *e = m_GUIElement->getElementFromId(id);
	return Wrap(e);
}

GUIElement^ GUIElement::GetElementFromPoint(Vector2Di^ point)
{
	LIME_ASSERT(point != nullptr);
	gui::IGUIElement *e = m_GUIElement->getElementFromPoint(*point->m_NativeValue);
	return Wrap(e);
}

bool GUIElement::GetNextElement(int startOrder, bool reverse, bool group, [Out] GUIElement^% first, [Out] GUIElement^% closest, bool includeInvisible)
{
	gui::IGUIElement* f;
	gui::IGUIElement* c;

	bool b = m_GUIElement->getNextElement(startOrder, reverse, group, f, c, includeInvisible);

	if (b)
	{
		first = GUIElement::Wrap(f);
		closest = GUIElement::Wrap(c);
	}

	return b;
}

bool GUIElement::GetNextElement(int startOrder, bool reverse, bool group, [Out] GUIElement^% first, [Out] GUIElement^% closest)
{
	gui::IGUIElement* f;
	gui::IGUIElement* c;

	bool b = m_GUIElement->getNextElement(startOrder, reverse, group, f, c);

	if (b)
	{
		first = GUIElement::Wrap(f);
		closest = GUIElement::Wrap(c);
	}

	return b;
}

bool GUIElement::IsMyChild(GUIElement^ child)
{
	LIME_ASSERT(child != nullptr);
	return m_GUIElement->isMyChild(LIME_SAFEREF(child, m_GUIElement));
}

bool GUIElement::IsPointInside(Vector2Di^ point)
{
	LIME_ASSERT(point != nullptr);
	return m_GUIElement->isPointInside(*point->m_NativeValue);
}

void GUIElement::Move(Vector2Di^ absoluteMovement)
{
	LIME_ASSERT(absoluteMovement != nullptr);
	m_GUIElement->move(*absoluteMovement->m_NativeValue);
}

void GUIElement::Remove()
{
	m_GUIElement->remove();
}

void GUIElement::RemoveChild(GUIElement^ child)
{
	LIME_ASSERT(child != nullptr);
	m_GUIElement->removeChild(LIME_SAFEREF(child, m_GUIElement));
}

void GUIElement::SetAlignment(GUIAlignment left, GUIAlignment right, GUIAlignment top, GUIAlignment bottom)
{
	m_GUIElement->setAlignment(
		(gui::EGUI_ALIGNMENT)left,
		(gui::EGUI_ALIGNMENT)right,
		(gui::EGUI_ALIGNMENT)top,
		(gui::EGUI_ALIGNMENT)bottom);
}

void GUIElement::SetMaxSize(Dimension2Di^ size)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width >= 0);
	LIME_ASSERT(size->Height >= 0);

	m_GUIElement->setMaxSize((core::dimension2du&)*size->m_NativeValue);
}

void GUIElement::SetMinSize(Dimension2Di^ size)
{
	LIME_ASSERT(size != nullptr);
	LIME_ASSERT(size->Width >= 0);
	LIME_ASSERT(size->Height >= 0);

	m_GUIElement->setMinSize((core::dimension2du&)*size->m_NativeValue);
}

void GUIElement::SetRelativePositionProportional(Rectf^ relativePosition)
{
	LIME_ASSERT(relativePosition != nullptr);
	m_GUIElement->setRelativePositionProportional(*relativePosition->m_NativeValue);
}

void GUIElement::UpdateAbsolutePosition()
{
	m_GUIElement->updateAbsolutePosition();
}

Recti^ GUIElement::AbsoluteClippingRect::get()
{
	return gcnew Recti(m_GUIElement->getAbsoluteClippingRect());
}

Recti^ GUIElement::AbsolutePosition::get()
{
	return gcnew Recti(m_GUIElement->getAbsolutePosition());
}

array<GUIElement^>^ GUIElement::Children::get()
{
	array<GUIElement^>^ l = gcnew array<GUIElement^>(m_GUIElement->getChildren().size());
	int li = 0;

	core::list<IGUIElement*> u = m_GUIElement->getChildren();
	for (core::list<gui::IGUIElement*>::ConstIterator i = u.begin(); i != u.end(); ++i)
	{
		GUIElement^ e = Wrap(*i);
		if (e != nullptr)
			l[li++] = e;
	}

	return l;
}

bool GUIElement::Clipped::get()
{
	return !m_GUIElement->isNotClipped();
}

void GUIElement::Clipped::set(bool value)
{
	m_GUIElement->setNotClipped(!value);
}

bool GUIElement::Enabled::get()
{
	return m_GUIElement->isEnabled();
}

void GUIElement::Enabled::set(bool value)
{
	m_GUIElement->setEnabled(value);
}

GUIEnvironment^ GUIElement::Environment::get()
{
	LIME_ASSERT(m_Inherited == true);

	GUIElementInheritor* i = (GUIElementInheritor*)m_GUIElement;
	gui::IGUIEnvironment* g = i->Environment_get();

	return GUIEnvironment::Wrap(g);
}

void GUIElement::Environment::set(GUIEnvironment^ value)
{
	LIME_ASSERT(m_Inherited == true);
	LIME_ASSERT(value != nullptr);

	GUIElementInheritor* i = (GUIElementInheritor*)m_GUIElement;
	i->Environment_set(value->m_GUIEnvironment);
}

int GUIElement::ID::get()
{
	return m_GUIElement->getID();
}

void GUIElement::ID::set(int value)
{
	m_GUIElement->setID(value);
}

String^ GUIElement::Name::get()
{
	return gcnew String(m_GUIElement->getName());
}

void GUIElement::Name::set(String^ value)
{
	m_GUIElement->setName(LIME_SAFESTRINGTOSTRINGC_C_STR(value));
}

GUIElement^ GUIElement::Parent::get()
{
	gui::IGUIElement* e = m_GUIElement->getParent();
	return GUIElement::Wrap(e);
}

Recti^ GUIElement::RelativePosition::get()
{
	return gcnew Recti(m_GUIElement->getRelativePosition());
}

void GUIElement::RelativePosition::set(Recti^ value)
{
	LIME_ASSERT(value != nullptr);
	m_GUIElement->setRelativePosition(*value->m_NativeValue);
}

bool GUIElement::SubElement::get()
{
	return m_GUIElement->isSubElement();
}

void GUIElement::SubElement::set(bool value)
{
	m_GUIElement->setSubElement(value);
}

bool GUIElement::TabGroup::get()
{
	return m_GUIElement->isTabGroup();
}

void GUIElement::TabGroup::set(bool value)
{
	m_GUIElement->setTabGroup(value);
}

GUIElement^ GUIElement::TabGroupElement::get()
{
	gui::IGUIElement* e = m_GUIElement->getTabGroup();
	return GUIElement::Wrap(e);
}

int GUIElement::TabOrder::get()
{
	return m_GUIElement->getTabOrder();
}

void GUIElement::TabOrder::set(int value)
{
	m_GUIElement->setTabOrder(value);
}

bool GUIElement::TabStop::get()
{
	return m_GUIElement->isTabStop();
}

void GUIElement::TabStop::set(bool value)
{
	m_GUIElement->setTabStop(value);
}

String^ GUIElement::Text::get()
{
	return gcnew String(m_GUIElement->getText());
}

void GUIElement::Text::set(String^ value)
{
	m_GUIElement->setText(LIME_SAFESTRINGTOSTRINGW_C_STR(value));
}

String^ GUIElement::ToolTipText::get()
{
	return gcnew String(m_GUIElement->getToolTipText().c_str());
}

void GUIElement::ToolTipText::set(String^ value)
{
	m_GUIElement->setToolTipText(LIME_SAFESTRINGTOSTRINGW_C_STR(value));
}

bool GUIElement::TrulyVisible::get()
{
	return m_GUIElement->isTrulyVisible();
}

GUIElementType GUIElement::Type::get()
{
	return (GUIElementType)m_GUIElement->getType();
}

String^ GUIElement::TypeName::get()
{
	return gcnew String(m_GUIElement->getTypeName());
}

bool GUIElement::Visible::get()
{
	return m_GUIElement->isVisible();
}

void GUIElement::Visible::set(bool value)
{
	m_GUIElement->setVisible(value);
}

String^ GUIElement::ToString()
{
	return String::Format("GUIElement: Type={0}; ID={1}; Text={2}", Type, ID, Text);
}

void GUIElement::initInheritor(GUIElementInheritor* i)
{
	i->m_drawHandler = gcnew DrawEventHandler(this, &GUIElement::Draw);
	i->m_OnEventHandler = gcnew OnEventEventHandler(this, &GUIElement::Event);
}

} // end namespace GUI
} // end namespace IrrlichtLime