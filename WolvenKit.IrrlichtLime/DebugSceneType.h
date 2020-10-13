#pragma once
#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	[Flags]
	/// <summary>
	/// An enumeration for all types of debug data for built-in scene nodes (flags).
	/// </summary>
	public enum class DebugSceneType
	{
		/// <summary>
		/// No Debug Data. Default.
		/// </summary>
		Off = EDS_OFF,

		/// <summary>
		/// Show bounding boxes of SceneNode.
		/// </summary>
		BBox = EDS_BBOX,

		/// <summary>
		/// Show vertex normals.
		/// </summary>
		Normals = EDS_NORMALS,

		/// <summary>
		/// Shows skeleton/tags.
		/// </summary>
		Skeleton = EDS_SKELETON,

		/// <summary>
		/// Overlays mesh wireframe.
		/// </summary>
		MeshWireOverlay = EDS_MESH_WIRE_OVERLAY,

		/// <summary>
		/// Temporary use transparency material type.
		/// </summary>
		HalfTransparency = EDS_HALF_TRANSPARENCY,

		/// <summary>
		/// Show bounding boxes of all mesh buffers.
		/// </summary>
		BBoxBuffers = EDS_BBOX_BUFFERS,

		/// <summary>
		/// Show all bounding boxes. Same as <see cref="BBox"/> | <see cref="BBoxBuffers"/>.
		/// </summary>
		BBoxAll = EDS_BBOX_ALL,

		/// <summary>
		/// Show all debug infos.
		/// </summary>
		Full = EDS_FULL
	};

} // end namespace Scene
} // end namespace IrrlichtLime
