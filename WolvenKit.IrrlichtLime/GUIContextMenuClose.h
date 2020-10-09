#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Close behavior for a context menu. Default is <see cref="Remove"/>.
	/// </summary>
	public enum class GUIContextMenuClose
	{
		/// <summary>
		/// Do nothing - menu stays open.
		/// </summary>
		Ignore = ECMC_IGNORE,

		/// <summary>
		/// Remove the GUI element.
		/// </summary>
		Remove = ECMC_REMOVE,

		/// <summary>
		/// Do <c>element.Visible = false</c>.
		/// </summary>
		Hide = ECMC_HIDE
	};

} // end namespace GUI
} // end namespace IrrlichtLime
