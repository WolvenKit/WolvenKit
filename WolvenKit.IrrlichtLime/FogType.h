#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Enumeration for the types of fog distributions to choose from.
	/// </summary>
	public enum class FogType
	{
		/// <summary>
		/// f = e ^ (-density * z).
		/// </summary>
		Exp = EFT_FOG_EXP,

		/// <summary>
		/// f = (end-z) / (end-start).
		/// </summary>
		Linear = EFT_FOG_LINEAR,

		/// <summary>
		/// f = e ^ (-density * z) ^ 2.
		/// </summary>
		Exp2 = EFT_FOG_EXP2
	};

} // end namespace Video
} // end namespace IrrlichtLime
