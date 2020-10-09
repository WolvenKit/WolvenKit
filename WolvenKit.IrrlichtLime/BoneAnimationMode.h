#pragma once
#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Enumeration for different bone animation modes.
	/// </summary>
	public enum class BoneAnimationMode
	{
		/// <summary>
		/// The bone is usually animated, unless it's parent is not animated.
		/// </summary>
		Automatic = EBAM_AUTOMATIC,

		/// <summary>
		/// The bone is animated by the skin, if it's parent is not animated then animation will resume from this bone onward.
		/// </summary>
		Animated = EBAM_ANIMATED,

		/// <summary>
		/// The bone is not animated by the skin.
		/// </summary>
		NotAnimated = EBAM_UNANIMATED
	};

} // end namespace Scene
} // end namespace IrrlichtLime
