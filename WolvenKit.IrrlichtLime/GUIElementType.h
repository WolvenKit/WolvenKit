#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// List of all basic Irrlicht GUI elements.
	/// </summary>
	public enum class GUIElementType
	{
		/// <summary>
		/// A button.
		/// </summary>
		Button = EGUIET_BUTTON,

		/// <summary>
		/// A check box.
		/// </summary>
		CheckBox = EGUIET_CHECK_BOX,

		/// <summary>
		/// A combo box.
		/// </summary>
		ComboBox = EGUIET_COMBO_BOX,

		/// <summary>
		/// A context menu.
		/// </summary>
		ContextMenu = EGUIET_CONTEXT_MENU,

		/// <summary>
		/// A menu.
		/// </summary>
		Menu = EGUIET_MENU,

		/// <summary>
		/// An edit box.
		/// </summary>
		EditBox = EGUIET_EDIT_BOX,

		/// <summary>
		/// A file open dialog.
		/// </summary>
		FileOpenDialog = EGUIET_FILE_OPEN_DIALOG,

		/// <summary>
		/// A color select dialog.
		/// </summary>
		ColorSelectDialog = EGUIET_COLOR_SELECT_DIALOG,

		/// <summary>
		/// An in/out fader.
		/// </summary>
		InOutFader = EGUIET_IN_OUT_FADER,

		/// <summary>
		/// An image.
		/// </summary>
		Image = EGUIET_IMAGE,

		/// <summary>
		/// A list box.
		/// </summary>
		ListBox = EGUIET_LIST_BOX,

		/// <summary>
		/// A mesh viewer.
		/// </summary>
		MeshViewer = EGUIET_MESH_VIEWER,

		/// <summary>
		/// A message box.
		/// </summary>
		MessageBox = EGUIET_MESSAGE_BOX,

		/// <summary>
		/// A modal screen.
		/// </summary>
		ModalScreen = EGUIET_MODAL_SCREEN,

		/// <summary>
		/// A scroll bar.
		/// </summary>
		ScrollBar = EGUIET_SCROLL_BAR,

		/// <summary>
		/// A spin box.
		/// </summary>
		SpinBox = EGUIET_SPIN_BOX,

		/// <summary>
		/// A static text.
		/// </summary>
		StaticText = EGUIET_STATIC_TEXT,

		/// <summary>
		/// A tab.
		/// </summary>
		Tab = EGUIET_TAB,

		/// <summary>
		/// A tab control.
		/// </summary>
		TabControl = EGUIET_TAB_CONTROL,

		/// <summary>
		/// A Table.
		/// </summary>
		Table = EGUIET_TABLE,

		/// <summary>
		/// A tool bar.
		/// </summary>
		ToolBar = EGUIET_TOOL_BAR,

		/// <summary>
		/// A tree view.
		/// </summary>
		TreeView = EGUIET_TREE_VIEW,

		/// <summary>
		/// A window.
		/// </summary>
		Window = EGUIET_WINDOW,

		/// <summary>
		/// Unknown element.
		/// </summary>
		Unknown = EGUIET_ELEMENT,

		/// <summary>
		/// The root of the GUI.
		/// </summary>
		Root = EGUIET_ROOT,

		/// <summary>
		/// GUI profiler.
		/// </summary>
		Profiler = EGUIET_PROFILER
	};

} // end namespace GUI
} // end namespace IrrlichtLime
