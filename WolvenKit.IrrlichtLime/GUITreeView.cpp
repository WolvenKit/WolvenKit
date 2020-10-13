#include "stdafx.h"
#include "GUIElement.h"
#include "GUIFont.h"
#include "GUIImageList.h"
#include "GUITreeView.h"
#include "GUITreeViewNode.h"

using namespace irr;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

GUITreeView^ GUITreeView::Wrap(gui::IGUITreeView* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUITreeView(ref);
}

GUITreeView::GUITreeView(gui::IGUITreeView* ref)
	: GUIElement(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUITreeView = ref;
}

void GUITreeView::SetIconFont(GUIFont^ font)
{
	m_GUITreeView->setIconFont(LIME_SAFEREF(font, m_GUIFont));
}

bool GUITreeView::ImageLeftOfIcon::get()
{
	return m_GUITreeView->getImageLeftOfIcon();
}

void GUITreeView::ImageLeftOfIcon::set(bool value)
{
	m_GUITreeView->setImageLeftOfIcon(value);
}

GUIImageList^ GUITreeView::ImageList::get()
{
	gui::IGUIImageList* l = m_GUITreeView->getImageList();
	return GUIImageList::Wrap(l);
}

void GUITreeView::ImageList::set(GUIImageList^ value)
{
	m_GUITreeView->setImageList(LIME_SAFEREF(value, m_GUIImageList));
}

GUITreeViewNode^ GUITreeView::LastEventNode::get()
{
	gui::IGUITreeViewNode* n = m_GUITreeView->getLastEventNode();
	return GUITreeViewNode::Wrap(n);
}

bool GUITreeView::LinesVisible::get()
{
	return m_GUITreeView->getLinesVisible();
}

void GUITreeView::LinesVisible::set(bool value)
{
	m_GUITreeView->setLinesVisible(value);
}

GUITreeViewNode^ GUITreeView::RootNode::get()
{
	gui::IGUITreeViewNode* n = m_GUITreeView->getRoot();
	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeView::SelectedNode::get()
{
	gui::IGUITreeViewNode* n = m_GUITreeView->getSelected();
	return GUITreeViewNode::Wrap(n);
}

} // end namespace GUI
} // end namespace IrrlichtLime