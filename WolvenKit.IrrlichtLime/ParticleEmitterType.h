#pragma once
#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Types of built in particle emitters.
	/// </summary>
	public enum class ParticleEmitterType
	{
		/// <summary>
		/// Point emitter.
		/// </summary>
		Point = EPET_POINT,

		/// <summary>
		/// Animated mesh emitter.
		/// </summary>
		AnimatedMesh = EPET_ANIMATED_MESH,

		/// <summary>
		/// Box shape emitter.
		/// </summary>
		Box = EPET_BOX,

		/// <summary>
		/// Cylinder shape emitter.
		/// </summary>
		Cylinder = EPET_CYLINDER,

		/// <summary>
		/// Mesh emitter.
		/// </summary>
		Mesh = EPET_MESH,

		/// <summary>
		/// Ring shape emitter.
		/// </summary>
		Ring = EPET_RING,

		/// <summary>
		/// Sphere shape emitter.
		/// </summary>
		Sphere = EPET_SPHERE
	};

} // end namespace Scene
} // end namespace IrrlichtLime
