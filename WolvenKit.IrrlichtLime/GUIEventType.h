#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Enumeration for all events which are sendable by the gui system.
	/// </summary>
	public enum class GUIEventType
	{
		/// <summary>
		/// A gui element has lost its focus.
		/// <c>GUIEvent.Caller</c> is losing the focus to <c>GUIEvent.Element</c>. If the event is absorbed then the focus will not be changed.
		/// </summary>
		ElementFocusLost = EGET_ELEMENT_FOCUS_LOST,

		/// <summary>
		/// A gui element has got the focus.
		/// If the event is absorbed then the focus will not be changed.
		/// </summary>
		ElementFocused = EGET_ELEMENT_FOCUSED,

		/// <summary>
		/// The mouse cursor hovered over a gui element.
		/// If an element has sub-elements you also get this message for the subelements.
		/// </summary>
		ElementMouseHovered = EGET_ELEMENT_HOVERED,

		/// <summary>
		/// The mouse cursor left the hovered element.
		/// If an element has sub-elements you also get this message for the subelements.
		/// </summary>
		ElementMouseLeft = EGET_ELEMENT_LEFT,

		/// <summary>
		/// An element would like to close.
		/// Windows and context menus use this event when they would like to close, this can be canceled by absorbing the event.
		/// </summary>
		ElementClosed = EGET_ELEMENT_CLOSED,

		/// <summary>
		/// A button was clicked.
		/// </summary>
		ButtonClicked = EGET_BUTTON_CLICKED,

		/// <summary>
		/// A scrollbar has changed its position.
		/// </summary>
		ScrollBarChanged = EGET_SCROLL_BAR_CHANGED,

		/// <summary>
		/// A checkbox has changed its check state.
		/// </summary>
		CheckBoxChanged = EGET_CHECKBOX_CHANGED,

		/// <summary>
		/// A new item in a listbox was selected.
		/// NOTE: You also get this event currently when the same item was clicked again after more than 500 ms.
		/// </summary>
		ListBoxChanged = EGET_LISTBOX_CHANGED,

		/// <summary>
		/// An item in the listbox was selected, which was already selected.
		/// NOTE: You get the event currently only if the item was clicked again within 500 ms or selected by "enter" or "space".
		/// </summary>
		ListBoxSelectedAgain = EGET_LISTBOX_SELECTED_AGAIN,

		/// <summary>
		/// A file has been selected in the file dialog.
		/// </summary>
		FileDialogFileSelected = EGET_FILE_SELECTED,

		/// <summary>
		/// A directory has been selected in the file dialog.
		/// </summary>
		FileDialogDirectorySelected = EGET_DIRECTORY_SELECTED,

		/// <summary>
		/// A file open dialog has been closed without choosing a file.
		/// </summary>
		FileDialogCancelled = EGET_FILE_CHOOSE_DIALOG_CANCELLED,

		/// <summary>
		/// 'Yes' was clicked on a messagebox.
		/// </summary>
		MessageBoxYes = EGET_MESSAGEBOX_YES,

		/// <summary>
		/// 'No' was clicked on a messagebox.
		/// </summary>
		MessageBoxNo = EGET_MESSAGEBOX_NO,

		/// <summary>
		/// 'OK' was clicked on a messagebox.
		/// </summary>
		MessageBoxOK = EGET_MESSAGEBOX_OK,

		/// <summary>
		/// 'Cancel' was clicked on a messagebox.
		/// </summary>
		MessageBoxCancel = EGET_MESSAGEBOX_CANCEL,

		/// <summary>
		/// In an editbox 'ENTER' was pressed.
		/// </summary>
		EditBoxEnter = EGET_EDITBOX_ENTER,

		/// <summary>
		/// The text in an editbox was changed. This does not include automatic changes in text-breaking.
		/// </summary>
		EditBoxChanged = EGET_EDITBOX_CHANGED,

		/// <summary>
		/// The marked area in an editbox was changed.
		/// </summary>
		EditBoxMarkingChanged = EGET_EDITBOX_MARKING_CHANGED,

		/// <summary>
		/// The tab was changed in an tab control.
		/// </summary>
		TabChanged = EGET_TAB_CHANGED,

		/// <summary>
		/// A menu item was selected in a (context) menu.
		/// </summary>
		MenuItemSelected = EGET_MENU_ITEM_SELECTED,

		/// <summary>
		/// The selection in a combo box has been changed.
		/// </summary>
		ComboBoxChanged = EGET_COMBO_BOX_CHANGED,

		/// <summary>
		/// The value of a spin box has changed.
		/// </summary>
		SpinBoxChanged = EGET_SPINBOX_CHANGED,

		/// <summary>
		/// A table has changed.
		/// </summary>
		TableChanged = EGET_TABLE_CHANGED,

		/// <summary>
		/// A table header has changed.
		/// </summary>
		TableHeaderChanged = EGET_TABLE_HEADER_CHANGED,

		/// <summary>
		/// A table selected again.
		/// </summary>
		TableSelectedAgain = EGET_TABLE_SELECTED_AGAIN,

		/// <summary>
		/// A tree view node lost selection. See <c>GUITreeView.LastEventNode</c>.
		/// </summary>
		TreeViewNodeDeselect = EGET_TREEVIEW_NODE_DESELECT,

		/// <summary>
		/// A tree view node was selected. See <c>GUITreeView.LastEventNode</c>.
		/// </summary>
		TreeViewNodeSelect = EGET_TREEVIEW_NODE_SELECT,

		/// <summary>
		/// A tree view node was expanded. See <c>GUITreeView.LastEventNode</c>.
		/// </summary>
		TreeViewNodeExpand = EGET_TREEVIEW_NODE_EXPAND,

		/// <summary>
		/// A tree view node was collapsed. See <c>GUITreeView.LastEventNode</c>.
		/// </summary>
		TreeViewNodeCollapse = EGET_TREEVIEW_NODE_COLLAPSE
	};

} // end namespace GUI
} // end namespace IrrlichtLime
