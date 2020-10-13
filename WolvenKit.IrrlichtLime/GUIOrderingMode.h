#pragma once

#include "stdafx.h"

using namespace irr;
using namespace gui;
using namespace System;

namespace IrrlichtLime {
namespace GUI {

	/// <summary>
	/// Ordering modes.
	/// </summary>
	public enum class GUIOrderingMode
	{
		/// <summary>
		/// No element ordering.
		/// </summary>
		None = EGOM_NONE,

		/// <summary>
		/// Elements are ordered from the smallest to the largest.
		/// </summary>
		Ascending = EGOM_ASCENDING,

		/// <summary>
		/// Elements are ordered from the largest to the smallest.
		/// </summary>
		Descending = EGOM_DESCENDING
	};

} // end namespace GUI
} // end namespace IrrlichtLime
