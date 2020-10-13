#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// An enumeration for all types of built-in scene nodes.
	/// A scene node type is represented by a four character code such as 'cube' or 'mesh' instead of simple numbers, to avoid name clashes with external scene nodes.
	/// </summary>
	public enum class SceneNodeType
	{
		/// <summary>
		/// Type for <c>SceneManager</c> (note that <c>SceneManager</c> is not(!) a <c>SceneNode</c>).
		/// </summary>
		SceneManager = ESNT_SCENE_MANAGER,

		/// <summary>
		/// Simple cube scene node.
		/// </summary>
		Cube = ESNT_CUBE,

		/// <summary>
		/// Sphere scene node.
		/// </summary>
		Sphere = ESNT_SPHERE,

		/// <summary>
		/// Text scene node.
		/// </summary>
		Text = ESNT_TEXT,

		/// <summary>
		/// Water surface scene node.
		/// </summary>
		WaterSurface = ESNT_WATER_SURFACE,

		/// <summary>
		/// Terrain scene node.
		/// </summary>
		Terrain = ESNT_TERRAIN,

		/// <summary>
		/// Sky box scene node.
		/// </summary>
		SkyBox = ESNT_SKY_BOX,

		/// <summary>
		/// Sky dome scene node.
		/// </summary>
		SkyDome = ESNT_SKY_DOME,

		/// <summary>
		/// Shadow volume scene node.
		/// </summary>
		ShadowVolume = ESNT_SHADOW_VOLUME,

		/// <summary>
		/// Octree scene node.
		/// </summary>
		Octree = ESNT_OCTREE,

		/// <summary>
		/// Mesh scene node.
		/// </summary>
		Mesh = ESNT_MESH,

		/// <summary>
		/// Light scene node.
		/// </summary>
		Light = ESNT_LIGHT,

		/// <summary>
		/// Empty scene node.
		/// </summary>
		Empty = ESNT_EMPTY,

		/// <summary>
		/// Dummy transformation scene node.
		/// </summary>
		DummyTransformation = ESNT_DUMMY_TRANSFORMATION,

		/// <summary>
		/// Camera scene node.
		/// </summary>
		Camera = ESNT_CAMERA,

		/// <summary>
		/// Billboard scene node.
		/// </summary>
		Billboard = ESNT_BILLBOARD,

		/// <summary>
		/// Animated mesh scene node.
		/// </summary>
		AnimatedMesh = ESNT_ANIMATED_MESH,

		/// <summary>
		/// Particle system scene node.
		/// </summary>
		ParticleSystem = ESNT_PARTICLE_SYSTEM,

		/// <summary>
		/// Quake3 shader scene node.
		/// </summary>
		Quake3_Shader = ESNT_Q3SHADER_SCENE_NODE,

		/// <summary>
		/// Quake3 model scene node (has tag to link to).
		/// </summary>
		Quake3_Model = ESNT_MD3_SCENE_NODE,

		/// <summary>
		/// Volume light scene node.
		/// </summary>
		VolumeLight = ESNT_VOLUME_LIGHT,

		/// <summary>
		/// Maya camera scene node.
		/// Legacy, for loading version &lt;= 1.4.x .irr files.
		/// </summary>
		Camera_Maya = ESNT_CAMERA_MAYA,

		/// <summary>
		/// First person shooter camera.
		/// Legacy, for loading version &lt;= 1.4.x .irr files.
		/// </summary>
		Camera_FPS = ESNT_CAMERA_FPS,

		/// <summary>
		/// Unknown scene node.
		/// </summary>
		Unknown = ESNT_UNKNOWN,

		/// <summary>
		/// Will match with any scene node when checking types.
		/// </summary>
		Any = ESNT_ANY
	};

} // end namespace Scene
} // end namespace IrrlichtLime
