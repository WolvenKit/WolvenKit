#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Types of standard md2 animations.
	/// </summary>
	public enum class AnimationTypeMD2
	{
		/// <summary>
		/// Stand animation.
		/// </summary>
		Stand = EMAT_STAND,

		/// <summary>
		/// Run animation.
		/// </summary>
		Run = EMAT_RUN,

		/// <summary>
		/// Attack animation.
		/// </summary>
		Attack = EMAT_ATTACK,

		/// <summary>
		/// Pain animation (variant A)
		/// </summary>
		Pain_A = EMAT_PAIN_A,

		/// <summary>
		/// Pain animation (variant B)
		/// </summary>
		Pain_B = EMAT_PAIN_B,

		/// <summary>
		/// Pain animation (variant C)
		/// </summary>
		Pain_C = EMAT_PAIN_C,

		/// <summary>
		/// Jump animation.
		/// </summary>
		Jump = EMAT_JUMP,

		/// <summary>
		/// Flip animation.
		/// </summary>
		Flip = EMAT_FLIP,

		/// <summary>
		/// Salute animation.
		/// </summary>
		Salute = EMAT_SALUTE,

		/// <summary>
		/// Fall back animation.
		/// </summary>
		Fallback = EMAT_FALLBACK,

		/// <summary>
		/// Wave animation.
		/// </summary>
		Wave = EMAT_WAVE,

		/// <summary>
		/// Point animation.
		/// </summary>
		Point = EMAT_POINT,

		/// <summary>
		/// Stand animation for crouch pose.
		/// </summary>
		Crouch_Stand = EMAT_CROUCH_STAND,

		/// <summary>
		/// Walk animation for crouch pose.
		/// </summary>
		Crouch_Walk = EMAT_CROUCH_WALK,

		/// <summary>
		/// Attack animation for crouch pose.
		/// </summary>
		Crouch_Attack = EMAT_CROUCH_ATTACK,

		/// <summary>
		/// Pain animation for crouch pose.
		/// </summary>
		Crouch_Pain = EMAT_CROUCH_PAIN,

		/// <summary>
		/// Death animation for crouch pose.
		/// </summary>
		Crouch_Death = EMAT_CROUCH_DEATH,

		/// <summary>
		/// Death fall back animation.
		/// </summary>
		Death_Fall_Back = EMAT_DEATH_FALLBACK,

		/// <summary>
		/// Death fall forward animation.
		/// </summary>
		Death_Fall_Forward = EMAT_DEATH_FALLFORWARD,

		/// <summary>
		/// Death fall back slow animation.
		/// </summary>
		Death_Fall_Back_Slow = EMAT_DEATH_FALLBACKSLOW,

		/// <summary>
		/// Boom animation.
		/// </summary>
		Boom = EMAT_BOOM
	};

} // end namespace Scene
} // end namespace IrrlichtLime
