#pragma once
#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Types of built in particle affectors.
	/// </summary>
	public enum class ParticleAffectorType
	{
		/// <summary>
		/// Particles are not affected.
		/// </summary>
		None = EPAT_NONE,

		/// <summary>
		/// Particles are attracted.
		/// </summary>
		Attract = EPAT_ATTRACT,

		/// <summary>
		/// Particles fade out over time.
		/// </summary>
		FadeOut = EPAT_FADE_OUT,

		/// <summary>
		/// Particles are affected by the gravity.
		/// </summary>
		Gravity = EPAT_GRAVITY,

		/// <summary>
		/// Particles are rotated over time.
		/// </summary>
		Rotate = EPAT_ROTATE,

		/// <summary>
		/// Particles are scaled over time.
		/// </summary>
		Scale = EPAT_SCALE
	};

} // end namespace Scene
} // end namespace IrrlichtLime
