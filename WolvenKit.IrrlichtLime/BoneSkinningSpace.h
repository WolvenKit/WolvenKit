#pragma once
#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Enumeration for different bone skinning spaces.
	/// </summary>
	public enum class BoneSkinningSpace
	{
		/// <summary>
		/// Local skinning, standard.
		/// </summary>
		Local = EBSS_LOCAL,

		/// <summary>
		/// Global skinning.
		/// </summary>
		Global = EBSS_GLOBAL
	};

} // end namespace Scene
} // end namespace IrrlichtLime
