#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	[Flags]
	/// <summary>
	/// GUI table draw flags.
	/// </summary>
	public enum class GUITableDrawFlag
	{
		/// <summary>
		/// Draw rows.
		/// </summary>
		Rows = EGTDF_ROWS,

		/// <summary>
		/// Draw columns.
		/// </summary>
		Columns = EGTDF_COLUMNS,

		/// <summary>
		/// Draw active row.
		/// </summary>
		ActiveRow = EGTDF_ACTIVE_ROW
	};

} // end namespace GUI
} // end namespace IrrlichtLime
