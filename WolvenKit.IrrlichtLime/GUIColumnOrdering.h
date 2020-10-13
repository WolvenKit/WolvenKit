#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Modes for ordering used when a column header is clicked.
	/// </summary>
	public enum class GUIColumnOrdering
	{
		/// <summary>
		/// Do not use ordering.
		/// </summary>
		None = EGCO_NONE,

		/// <summary>
		/// Send a <c>GUIEventType.TableHeaderChanged</c> message when a column header is clicked.
		/// </summary>
		Custom = EGCO_CUSTOM,

		/// <summary>
		/// Sort it ascending by it's ASCII value like: a,b,c,...
		/// </summary>
		Ascending = EGCO_ASCENDING,

		/// <summary>
		/// Sort it descending by it's ASCII value like: z,x,y,...
		/// </summary>
		Descending = EGCO_DESCENDING,

		/// <summary>
		/// Sort it ascending on first click, descending on next, etc.
		/// </summary>
		FlipAscendingDescending = EGCO_FLIP_ASCENDING_DESCENDING
	};

} // end namespace GUI
} // end namespace IrrlichtLime
