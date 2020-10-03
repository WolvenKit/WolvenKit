#pragma once

#include "stdafx.h"
#include "ReferenceCounted.h"

using namespace irr;
using namespace System;
using namespace IrrlichtLime::Core;

namespace IrrlichtLime {
namespace GUI {

ref class GUITreeView;

public ref class GUITreeViewNode : ReferenceCounted
{
public:

	GUITreeViewNode^ AddChildBack(String^ text, String^ icon, int imageIndex, int selectedImageIndex, int data);
	GUITreeViewNode^ AddChildBack(String^ text, String^ icon, int imageIndex, int selectedImageIndex);
	GUITreeViewNode^ AddChildBack(String^ text, String^ icon, int imageIndex);
	GUITreeViewNode^ AddChildBack(String^ text, String^ icon);
	GUITreeViewNode^ AddChildBack(String^ text);

	GUITreeViewNode^ AddChildFront(String^ text, String^ icon, int imageIndex, int selectedImageIndex, int data);
	GUITreeViewNode^ AddChildFront(String^ text, String^ icon, int imageIndex, int selectedImageIndex);
	GUITreeViewNode^ AddChildFront(String^ text, String^ icon, int imageIndex);
	GUITreeViewNode^ AddChildFront(String^ text, String^ icon);
	GUITreeViewNode^ AddChildFront(String^ text);

	GUITreeViewNode^ InsertChildAfter(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex, int selectedImageIndex, int data);
	GUITreeViewNode^ InsertChildAfter(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex, int selectedImageIndex);
	GUITreeViewNode^ InsertChildAfter(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex);
	GUITreeViewNode^ InsertChildAfter(GUITreeViewNode^ other, String^ text, String^ icon);
	GUITreeViewNode^ InsertChildAfter(GUITreeViewNode^ other, String^ text);

	GUITreeViewNode^ InsertChildBefore(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex, int selectedImageIndex, int data);
	GUITreeViewNode^ InsertChildBefore(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex, int selectedImageIndex);
	GUITreeViewNode^ InsertChildBefore(GUITreeViewNode^ other, String^ text, String^ icon, int imageIndex);
	GUITreeViewNode^ InsertChildBefore(GUITreeViewNode^ other, String^ text, String^ icon);
	GUITreeViewNode^ InsertChildBefore(GUITreeViewNode^ other, String^ text);

	bool MoveChildDown(GUITreeViewNode^ child);
	bool MoveChildUp(GUITreeViewNode^ child);

	void RemoveChild(GUITreeViewNode^ child);
	void RemoveChildren();

	property int ChildCount { int get(); }
	property int Data { int get(); void set(int value); }
	property bool Expanded { bool get(); void set(bool value); }
	property GUITreeViewNode^ FirstChild { GUITreeViewNode^ get(); }
	property bool HasChildren { bool get(); }
	property String^ Icon { String^ get(); void set(String^ value); }
	property int ImageIndex { int get(); void set(int value); }
	property GUITreeViewNode^ LastChild { GUITreeViewNode^ get(); }
	property int Level { int get(); }
	property GUITreeViewNode^ NextSibling { GUITreeViewNode^ get(); }
	property GUITreeViewNode^ NextVisible { GUITreeViewNode^ get(); }
	property GUITreeViewNode^ Parent { GUITreeViewNode^ get(); }
	property GUITreeViewNode^ PrevSibling { GUITreeViewNode^ get(); }
	property bool Root { bool get(); }
	property bool Selected { bool get(); void set(bool value); }
	property int SelectedImageIndex { int get(); void set(int value); }
	property String^ Text { String^ get(); void set(String^ value); }
	property GUITreeView^ TreeView { GUITreeView^ get(); }
	property bool Visible { bool get(); }

	virtual String^ ToString() override;

internal:

	static GUITreeViewNode^ Wrap(gui::IGUITreeViewNode* ref);
	GUITreeViewNode(gui::IGUITreeViewNode* ref);

	gui::IGUITreeViewNode* m_GUITreeViewNode;
};

} // end namespace GUI
} // end namespace IrrlichtLime