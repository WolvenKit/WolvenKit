#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	[Flags]
	/// <summary>
	/// Enumeration for message box layout flags.
	/// </summary>
	public enum class GUIMessageBoxFlag
	{
		/// <summary>
		/// Flag for the OK button.
		/// </summary>
		OK = EMBF_OK,

		/// <summary>
		/// Flag for the cancel button.
		/// </summary>
		Cancel = EMBF_CANCEL,

		/// <summary>
		/// Flag for the yes button.
		/// </summary>
		Yes = EMBF_YES,

		/// <summary>
		/// Flag for the no button.
		/// </summary>
		No = EMBF_NO
	};

} // end namespace GUI
} // end namespace IrrlichtLime
