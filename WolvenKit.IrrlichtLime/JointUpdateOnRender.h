#pragma once
#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Joint update modes.
	/// </summary>
	public enum class JointUpdateOnRender
	{
		/// <summary>
		/// Do nothing.
		/// </summary>
		None = EJUOR_NONE,

		/// <summary>
		/// Get joints positions from the mesh (for attached nodes, etc).
		/// </summary>
		Read = EJUOR_READ,

		/// <summary>
		/// Control joint positions in the mesh (e.g. ragdolls, or set the animation from <c>AnimateJoints()</c>).
		/// </summary>
		Control = EJUOR_CONTROL
	};

} // end namespace Scene
} // end namespace IrrlichtLime
