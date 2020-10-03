#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	[Flags]
	/// <summary>
	/// Enumeration for render passes.
	/// A parameter passed to the <c>SceneManager.RegisterNodeForRendering()</c>, specifying when the node wants to be drawn in relation to the other nodes.
	/// </summary>
	public enum class SceneNodeRenderPass
	{
		/// <summary>
		/// No pass currently active.
		/// </summary>
		None = ESNRP_NONE,

		/// <summary>
		/// Camera pass. The active view is set up here. The very first pass.
		/// </summary>
		Camera = ESNRP_CAMERA,

		/// <summary>
		/// In this pass, lights are transformed into camera space and added to the driver.
		/// </summary>
		Light = ESNRP_LIGHT,

		/// <summary>
		/// This is used for sky boxes.
		/// </summary>
		SkyBox = ESNRP_SKY_BOX,

		/// <summary>
		/// All normal objects can use this for registering themselves.
		/// <para>This value will never be returned by <c>SceneManager.SceneNodeRenderPass</c>.
		/// The scene manager will determine by itself if an object is transparent or solid and register the object as <c>Transparent</c> or <c>Solid</c>
		/// automatically if you call <c>SceneManager.RegisterNodeForRendering()</c> with this value (which is default).
		/// Note that it will register the node only as ONE type. If your scene node has both solid and transparent material types register it twice
		/// (one time as <c>Solid</c>, the other time as <c>Transparent</c>) and in the <c>SceneNode.Render()</c>
		/// check <c>SceneManager.SceneNodeRenderPass</c> to find out the current render pass and render only the corresponding parts of the node.</para>
		/// </summary>
		Automatic = ESNRP_AUTOMATIC,

		/// <summary>
		/// Solid scene nodes or special scene nodes without materials.
		/// </summary>
		Solid = ESNRP_SOLID,

		/// <summary>
		/// Transparent scene nodes, drawn after solid nodes. They are sorted from back to front and drawn in that order.
		/// </summary>
		Transparent = ESNRP_TRANSPARENT,

		/// <summary>
		/// Transparent effect scene nodes, drawn after transparent nodes. They are sorted from back to front and drawn in that order.
		/// </summary>
		TransparentEffect = ESNRP_TRANSPARENT_EFFECT,

		/// <summary>
		/// Drawn after the solid nodes, before the transparent nodes, the time for drawing shadow volumes.
		/// </summary>
		Shadow = ESNRP_SHADOW
	};

} // end namespace Scene
} // end namespace IrrlichtLime
