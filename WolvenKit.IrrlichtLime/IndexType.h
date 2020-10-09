#pragma once
#include "stdafx.h"

using namespace irr;
using namespace video;
using namespace System;

namespace IrrlichtLime {
namespace Video {

	/// <summary>
	/// Index types.
	/// </summary>
	public enum class IndexType
	{
		/// <summary>
		/// 16 bit indices.
		/// </summary>
		_16Bit = EIT_16BIT,

		/// <summary>
		/// 32 bit indices.
		/// </summary>
		_32Bit = EIT_32BIT
	};

} // end namespace Video
} // end namespace IrrlichtLime
