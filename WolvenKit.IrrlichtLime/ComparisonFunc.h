#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Comparison function, e.g. for depth buffer test.
	/// </summary>
	public enum class ComparisonFunc
	{
		/// <summary>
		/// Depth test disabled (disable also write to depth buffer).
		/// </summary>
		Disabled = ECFN_DISABLED,

		/// <summary>
		/// &lt;= test, default for e.g. depth test.
		/// </summary>
		LessEqual = ECFN_LESSEQUAL,

		/// <summary>
		/// Exact equality.
		/// </summary>
		Equal = ECFN_EQUAL,

		/// <summary>
		/// Exclusive less comparison, i.e. &lt;.
		/// </summary>
		Less = ECFN_LESS,

		/// <summary>
		/// Succeeds almost always, except for exact equality.
		/// </summary>
		NotEqual = ECFN_NOTEQUAL,

		/// <summary>
		/// &gt;= test.
		/// </summary>
		GreaterEqual = ECFN_GREATEREQUAL,

		/// <summary>
		/// Inverse of &lt;=.
		/// </summary>
		Greater = ECFN_GREATER,

		/// <summary>
		/// Test succeeds always.
		/// </summary>
		Always = ECFN_ALWAYS,

		/// <summary>
		/// Test never succeeds.
		/// </summary>
		Never = ECFN_NEVER
	};

} // end namespace Video
} // end namespace IrrlichtLime
