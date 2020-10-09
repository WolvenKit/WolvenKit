#include "stdafx.h"
#include "CursorControl.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace GUI {

CursorControl^ CursorControl::Wrap(gui::ICursorControl* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew CursorControl(ref);
}

CursorControl::CursorControl(gui::ICursorControl* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_CursorControl = ref;
}

void CursorControl::SetReferenceRect(Recti^ rect_or_null)
{
	m_CursorControl->setReferenceRect(LIME_SAFEREF(rect_or_null, m_NativeValue));
}

CursorPlatformBehavior CursorControl::PlatformBehavior::get()
{
	return (CursorPlatformBehavior)m_CursorControl->getPlatformBehavior();
}

void CursorControl::PlatformBehavior::set(CursorPlatformBehavior value)
{
	m_CursorControl->setPlatformBehavior((gui::ECURSOR_PLATFORM_BEHAVIOR)value);
}

Vector2Di^ CursorControl::Position::get()
{
	return gcnew Vector2Di(m_CursorControl->getPosition());
}

void CursorControl::Position::set(Vector2Di^ value)
{
	LIME_ASSERT(value != nullptr);
	m_CursorControl->setPosition(*value->m_NativeValue);
}

Vector2Df^ CursorControl::RelativePosition::get()
{
	return gcnew Vector2Df(m_CursorControl->getRelativePosition());
}

void CursorControl::RelativePosition::set(Vector2Df^ value)
{
	LIME_ASSERT(value != nullptr);
	m_CursorControl->setPosition(*value->m_NativeValue);
}

bool CursorControl::Visible::get()
{
	return m_CursorControl->isVisible();
}

void CursorControl::Visible::set(bool value)
{
	m_CursorControl->setVisible(value);
}

String^ CursorControl::ToString()
{
	return String::Format("CursorControl: Position={{{0}}}; Visible={1}", Position, Visible);
}

} // end namespace GUI
} // end namespace IrrlichtLime