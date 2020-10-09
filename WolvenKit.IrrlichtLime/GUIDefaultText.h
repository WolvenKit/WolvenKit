#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Default GUI texts.
	/// </summary>
	public enum class GUIDefaultText
	{
		/// <summary>
		/// Text for the OK button on a message box.
		/// </summary>
		MsgBoxOK = EGDT_MSG_BOX_OK,

		/// <summary>
		/// Text for the Cancel button on a message box.
		/// </summary>
		MsgBoxCancel = EGDT_MSG_BOX_CANCEL,

		/// <summary>
		/// Text for the Yes button on a message box.
		/// </summary>
		MsgBoxYes = EGDT_MSG_BOX_YES,

		/// <summary>
		/// Text for the No button on a message box.
		/// </summary>
		MsgBoxNo = EGDT_MSG_BOX_NO,

		/// <summary>
		/// Tooltip text for window close button.
		/// </summary>
		WindowClose = EGDT_WINDOW_CLOSE,

		/// <summary>
		/// Tooltip text for window maximize button.
		/// </summary>
		WindowMaximize = EGDT_WINDOW_MAXIMIZE,

		/// <summary>
		/// Tooltip text for window minimize button.
		/// </summary>
		WindowMinimize = EGDT_WINDOW_MINIMIZE,

		/// <summary>
		/// Tooltip text for window restore button.
		/// </summary>
		WindowRestore = EGDT_WINDOW_RESTORE
	};

} // end namespace GUI
} // end namespace IrrlichtLime
