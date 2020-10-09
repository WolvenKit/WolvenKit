#include "stdafx.h"
#include "GUIImageList.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUIImageList^ GUIImageList::Wrap(gui::IGUIImageList* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUIImageList(ref);
}

GUIImageList::GUIImageList(gui::IGUIImageList* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUIImageList = ref;
}

void GUIImageList::Draw(int index, Vector2Di^ destPos, Recti^ clip)
{
	LIME_ASSERT(index >= 0 && index < ImageCount);
	LIME_ASSERT(destPos != nullptr);
	LIME_ASSERT(clip != nullptr);

	m_GUIImageList->draw(
		index,
		*destPos->m_NativeValue,
		clip->m_NativeValue);
}

void GUIImageList::Draw(int index, Vector2Di^ destPos)
{
	LIME_ASSERT(index >= 0 && index < ImageCount);
	LIME_ASSERT(destPos != nullptr);

	m_GUIImageList->draw(
		index,
		*destPos->m_NativeValue);
}

int GUIImageList::ImageCount::get()
{
	return m_GUIImageList->getImageCount();
}

Dimension2Di^ GUIImageList::ImageSize::get()
{
	return gcnew Dimension2Di(m_GUIImageList->getImageSize());
}

} // end namespace GUI
} // end namespace IrrlichtLime