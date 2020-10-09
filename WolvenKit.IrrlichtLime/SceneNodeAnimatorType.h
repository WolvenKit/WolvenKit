#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// An enumeration for all types of built-in scene node animators.
	/// </summary>
	public enum class SceneNodeAnimatorType
	{
		/// <summary>
		/// Fly circle scene node animator.
		/// </summary>
		FlyCircle = ESNAT_FLY_CIRCLE,

		/// <summary>
		/// Fly straight scene node animator.
		/// </summary>
		FlyStraight = ESNAT_FLY_STRAIGHT,

		/// <summary>
		/// Follow spline scene node animator.
		/// </summary>
		FollowSpline = ESNAT_FOLLOW_SPLINE,

		/// <summary>
		/// Rotation scene node animator.
		/// </summary>
		Rotation = ESNAT_ROTATION,

		/// <summary>
		/// Texture scene node animator.
		/// </summary>
		Texture = ESNAT_TEXTURE,

		/// <summary>
		/// Deletion scene node animator.
		/// </summary>
		Deletion = ESNAT_DELETION,

		/// <summary>
		/// Collision response scene node animator.
		/// </summary>
		CollisionResponse = ESNAT_COLLISION_RESPONSE,

		/// <summary>
		/// FPS camera animator.
		/// </summary>
		CameraFPS = ESNAT_CAMERA_FPS,

		/// <summary>
		/// Maya camera animator.
		/// </summary>
		CameraMaya = ESNAT_CAMERA_MAYA,

		/// <summary>
		/// Unknown scene node animator.
		/// </summary>
		Unknown = ESNAT_UNKNOWN
	};

} // end namespace Scene
} // end namespace IrrlichtLime
