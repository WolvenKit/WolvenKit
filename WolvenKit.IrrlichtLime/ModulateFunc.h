#pragma once

#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// MaterialTypeParam: e.g. DirectX: D3DTOP_MODULATE, D3DTOP_MODULATE2X, D3DTOP_MODULATE4X.
	/// </summary>
	public enum class ModulateFunc
	{
		/// <summary>
		/// Multiply the components of the arguments.
		/// </summary>
		_1x = EMFN_MODULATE_1X,

		/// <summary>
		/// Multiply the components of the arguments, and shift the products to the left 1 bit (effectively multiplying them by 2) for brightening.
		/// </summary>
		_2x = EMFN_MODULATE_2X,

		/// <summary>
		/// Multiply the components of the arguments, and shift the products to the left 2 bits (effectively multiplying them by 4) for brightening.
		/// </summary>
		_4x = EMFN_MODULATE_4X
	};

} // end namespace Video
} // end namespace IrrlichtLime
