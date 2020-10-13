#include "stdafx.h"
#include "GUITreeView.h"
#include "GUITreeViewNode.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace GUI {

GUITreeViewNode^ GUITreeViewNode::Wrap(gui::IGUITreeViewNode* ref)
{
	if (ref == nullptr)
		return nullptr;

	return gcnew GUITreeViewNode(ref);
}

GUITreeViewNode::GUITreeViewNode(gui::IGUITreeViewNode* ref)
	: ReferenceCounted(ref)
{
	LIME_ASSERT(ref != nullptr);
	m_GUITreeViewNode = ref;
}

GUITreeViewNode^ GUITreeViewNode::AddChildBack(String^ text, String^ icon, int imageIndex, int selectedImageIndex, int data)
{
	LIME_ASSERT(imageIndex >= -1);
	LIME_ASSERT(selectedImageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildBack(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex,
		selectedImageIndex,
		(void*) data);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::AddChildBack(String^ text, String^ icon, int imageIndex, int selectedImageIndex)
{
	LIME_ASSERT(imageIndex >= -1);
	LIME_ASSERT(selectedImageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildBack(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex,
		selectedImageIndex);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::AddChildBack(String^ text, String^ icon, int imageIndex)
{
	LIME_ASSERT(imageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildBack(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::AddChildBack(String^ text, String^ icon)
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildBack(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon));

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::AddChildBack(String^ text)
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildBack(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::AddChildFront(String^ text, String^ icon, int imageIndex, int selectedImageIndex, int data)
{
	LIME_ASSERT(imageIndex >= -1);
	LIME_ASSERT(selectedImageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildFront(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex,
		selectedImageIndex,
		(void*) data);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::AddChildFront(String^ text, String^ icon, int imageIndex, int selectedImageIndex)
{
	LIME_ASSERT(imageIndex >= -1);
	LIME_ASSERT(selectedImageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildFront(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex,
		selectedImageIndex);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::AddChildFront(String^ text, String^ icon, int imageIndex)
{
	LIME_ASSERT(imageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildFront(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::AddChildFront(String^ text, String^ icon)
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildFront(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon));

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::AddChildFront(String^ text)
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->addChildFront(
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildAfter(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex, int selectedImageIndex, int data)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);
	LIME_ASSERT(imageIndex >= -1);
	LIME_ASSERT(selectedImageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildAfter(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex,
		selectedImageIndex,
		(void*) data);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildAfter(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex, int selectedImageIndex)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);
	LIME_ASSERT(imageIndex >= -1);
	LIME_ASSERT(selectedImageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildAfter(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex,
		selectedImageIndex);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildAfter(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);
	LIME_ASSERT(imageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildAfter(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildAfter(GUITreeViewNode^ other, String^ text, String^ icon)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildAfter(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon));

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildAfter(GUITreeViewNode^ other, String^ text)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildAfter(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildBefore(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex, int selectedImageIndex, int data)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);
	LIME_ASSERT(imageIndex >= -1);
	LIME_ASSERT(selectedImageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildBefore(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex,
		selectedImageIndex,
		(void*) data);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildBefore(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex, int selectedImageIndex)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);
	LIME_ASSERT(imageIndex >= -1);
	LIME_ASSERT(selectedImageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildBefore(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex,
		selectedImageIndex);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildBefore(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);
	LIME_ASSERT(imageIndex >= -1);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildBefore(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon),
		imageIndex);

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildBefore(GUITreeViewNode^ other, String^ text, String^ icon)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildBefore(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text),
		LIME_SAFESTRINGTOSTRINGW_C_STR(icon));

	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::InsertChildBefore(GUITreeViewNode^ other, String^ text)
{
	LIME_ASSERT(other != nullptr);
	LIME_ASSERT(other->Parent == this);

	gui::IGUITreeViewNode* n = m_GUITreeViewNode->insertChildBefore(
		LIME_SAFEREF(other, m_GUITreeViewNode),
		LIME_SAFESTRINGTOSTRINGW_C_STR(text));

	return GUITreeViewNode::Wrap(n);
}

bool GUITreeViewNode::MoveChildDown(GUITreeViewNode^ child)
{
	LIME_ASSERT(child != nullptr);
	LIME_ASSERT(child->Parent == this);

	return m_GUITreeViewNode->moveChildDown(LIME_SAFEREF(child, m_GUITreeViewNode));
}

bool GUITreeViewNode::MoveChildUp(GUITreeViewNode^ child)
{
	LIME_ASSERT(child != nullptr);
	LIME_ASSERT(child->Parent == this);

	return m_GUITreeViewNode->moveChildUp(LIME_SAFEREF(child, m_GUITreeViewNode));
}

void GUITreeViewNode::RemoveChild(GUITreeViewNode^ child)
{
	LIME_ASSERT(child != nullptr);
	LIME_ASSERT(child->Parent == this);

	m_GUITreeViewNode->deleteChild(LIME_SAFEREF(child, m_GUITreeViewNode));
}

void GUITreeViewNode::RemoveChildren()
{
	m_GUITreeViewNode->clearChildren();
}

int GUITreeViewNode::ChildCount::get()
{
	return m_GUITreeViewNode->getChildCount();
}

int GUITreeViewNode::Data::get()
{
	return (int) m_GUITreeViewNode->getData();
}

void GUITreeViewNode::Data::set(int value)
{
	m_GUITreeViewNode->setData((void*) value);
}

bool GUITreeViewNode::Expanded::get()
{
	return m_GUITreeViewNode->getExpanded();
}

void GUITreeViewNode::Expanded::set(bool value)
{
	m_GUITreeViewNode->setExpanded(value);
}

GUITreeViewNode^ GUITreeViewNode::FirstChild::get()
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->getFirstChild();
	return GUITreeViewNode::Wrap(n);
}

bool GUITreeViewNode::HasChildren::get()
{
	return m_GUITreeViewNode->hasChildren();
}

String^ GUITreeViewNode::Icon::get()
{
	return gcnew String(m_GUITreeViewNode->getIcon());
}

void GUITreeViewNode::Icon::set(String^ value)
{
	m_GUITreeViewNode->setIcon(LIME_SAFESTRINGTOSTRINGW_C_STR(value));
}

int GUITreeViewNode::ImageIndex::get()
{
	return m_GUITreeViewNode->getImageIndex();
}

void GUITreeViewNode::ImageIndex::set(int value)
{
	LIME_ASSERT(value >= -1);
	m_GUITreeViewNode->setImageIndex(value);
}

GUITreeViewNode^ GUITreeViewNode::LastChild::get()
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->getLastChild();
	return GUITreeViewNode::Wrap(n);
}

int GUITreeViewNode::Level::get()
{
	return m_GUITreeViewNode->getLevel();
}

GUITreeViewNode^ GUITreeViewNode::NextSibling::get()
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->getNextSibling();
	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::NextVisible::get()
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->getNextVisible();
	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::Parent::get()
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->getParent();
	return GUITreeViewNode::Wrap(n);
}

GUITreeViewNode^ GUITreeViewNode::PrevSibling::get()
{
	gui::IGUITreeViewNode* n = m_GUITreeViewNode->getPrevSibling();
	return GUITreeViewNode::Wrap(n);
}

bool GUITreeViewNode::Root::get()
{
	return m_GUITreeViewNode->isRoot();
}

bool GUITreeViewNode::Selected::get()
{
	return m_GUITreeViewNode->getSelected();
}

void GUITreeViewNode::Selected::set(bool value)
{
	m_GUITreeViewNode->setSelected(value);
}

int GUITreeViewNode::SelectedImageIndex::get()
{
	return m_GUITreeViewNode->getSelectedImageIndex();
}

void GUITreeViewNode::SelectedImageIndex::set(int value)
{
	LIME_ASSERT(value >= -1);
	m_GUITreeViewNode->setSelectedImageIndex(value);
}

String^ GUITreeViewNode::Text::get()
{
	return gcnew String(m_GUITreeViewNode->getText());
}

void GUITreeViewNode::Text::set(String^ value)
{
	m_GUITreeViewNode->setText(LIME_SAFESTRINGTOSTRINGW_C_STR(value));
}

GUITreeView^ GUITreeViewNode::TreeView::get()
{
	gui::IGUITreeView* v = m_GUITreeViewNode->getOwner();
	return GUITreeView::Wrap(v);
}

bool GUITreeViewNode::Visible::get()
{
	return m_GUITreeViewNode->isVisible();
}

String^ GUITreeViewNode::ToString()
{
	return String::Format("GUITreeViewNode: Text={0}; ChildCount={1}", Text, ChildCount);
}

} // end namespace GUI
} // end namespace IrrlichtLime