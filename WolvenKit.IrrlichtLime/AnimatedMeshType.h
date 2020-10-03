#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Possible types of meshes.
	/// <para>Note: was previously only used in <c>AnimatedMesh</c> so it still has the "animated" in the name.
	/// But can now be used for all mesh-types as we need those casts as well.</para>
	/// </summary>
	public enum class AnimatedMeshType
	{
		/// <summary>
		/// Unknown animated mesh type.
		/// </summary>
		Unknown = EAMT_UNKNOWN,

		/// <summary>
		/// Quake 2 MD2 model file.
		/// </summary>
		MD2 = EAMT_MD2,

		/// <summary>
		/// Quake 3 MD3 model file.
		/// </summary>
		MD3 = EAMT_MD3,

		/// <summary>
		/// Maya .obj static model.
		/// </summary>
		OBJ = EAMT_OBJ,

		/// <summary>
		/// Quake 3 .bsp static map.
		/// </summary>
		BSP = EAMT_BSP,

		/// <summary>
		/// 3D Studio .3ds file.
		/// </summary>
		_3DS = EAMT_3DS,

		/// <summary>
		/// My3D Mesh, the file format by Zhuck Dimitry.
		/// </summary>
		MY3D = EAMT_MY3D,

		/// <summary>
		/// Pulsar LMTools .lmts file. This Irrlicht loader was written by Jonas Petersen.
		/// </summary>
		LMTS = EAMT_LMTS,

		/// <summary>
		/// Cartography Shop .csm file. This loader was created by Saurav Mohapatra.
		/// </summary>
		CSM = EAMT_CSM,

		/// <summary>
		/// .oct file for Paul Nette's FSRad or from Murphy McCauley's Blender .oct exporter.
		/// </summary>
		OCT = EAMT_OCT,

		/// <summary>
		/// Halflife MDL model file.
		/// </summary>
		MDL_HalfLife = EAMT_MDL_HALFLIFE,

		/// <summary>
		/// Generic skinned mesh.
		/// </summary>
		Skinned = EAMT_SKINNED,

		/// <summary>
		/// Generic non-animated mesh.
		/// </summary>
		Static = EAMT_STATIC
	};

} // end namespace Scene
} // end namespace IrrlichtLime
