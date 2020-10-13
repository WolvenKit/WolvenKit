#pragma once

#include "stdafx.h"

using namespace irr;
using namespace scene;
using namespace System;

namespace IrrlichtLime {
namespace Scene {

	/// <summary>
	/// Scene parameters for modifying mesh loading etc.
	/// Check <c>SceneManager.Attributes</c> for actual values. To set an attribute you need to do <c>SceneManager.Attributes.SetValue()</c>.
	/// </summary>
	public ref class SceneParameters abstract sealed
	{
	public:

		/// <summary>
		/// Parameter for changing how Irrlicht handles the ZWrite flag for transparent (blending) materials.
		/// The default behavior in Irrlicht is to disable writing to the z-buffer for all really transparent, i.e. blending materials.
		/// This avoids problems with intersecting faces, but can also break renderings.
		/// If transparent materials should use the <c>MaterialFlag.ZWrite</c> flag just as other material types use this attribute.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.AllowZWriteOnTransparent, true);</c>
		/// </summary>
		static property String^ AllowZWriteOnTransparent { String^ get() { return gcnew String(ALLOW_ZWRITE_ON_TRANSPARENT); }}
	
		/// <summary>
		/// Flag to ignore the b3d file's mipmapping flag. Instead Irrlicht's texture creation flag is used.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.B3D_IgnoreMipmapFlag, true);</c>
		/// </summary>
		static property String^ B3D_IgnoreMipmapFlag { String^ get() { return gcnew String(B3D_LOADER_IGNORE_MIPMAP_FLAG); }}

		[Obsolete("Deprecated, use IMeshLoader::getMeshTextureLoader()->setTexturePath instead. LIME_NO_SUPPORT_YET")]
		/// <summary>
		/// Deprecated. Was used for changing the texture path of the built-in b3d loader
		/// like this: <c>SceneManager.Attributes.SetValue(SceneParameters.B3D_TexturePath, "path/to/your/textures");</c>
		/// </summary>
		static property String^ B3D_TexturePath { String^ get() { return gcnew String(B3D_TEXTURE_PATH); }}
	
		/// <summary>
		/// The parameter specifying the COLLADA mesh loading mode.
		/// Specifies if the COLLADA loader should create instances of the models, lights and cameras when loading COLLADA meshes.
		/// By default, this is set to false. If this is set to true, the <c>SceneManager.GetMesh()</c> method will only return a pointer to a dummy mesh
		/// and create instances of all meshes and lights and cameras in the collada file by itself.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.COLLADA_CreateSceneInstances, true);</c>
		/// </summary>
		static property String^ COLLADA_CreateSceneInstances { String^ get() { return gcnew String(COLLADA_CREATE_SCENE_INSTANCES); }}
	
		[Obsolete("Deprecated, use IMeshLoader::getMeshTextureLoader()->setTexturePath instead. LIME_NO_SUPPORT_YET")]
		/// <summary>
		/// Deprecated. Was used for changing the texture path of the built-in csm loader
		/// like this: <c>SceneManager.Attributes.SetValue(SceneParameters.CSM_TexturePath, "path/to/your/textures");</c>
		/// </summary>
		static property String^ CSM_TexturePath { String^ get() { return gcnew String(CSM_TEXTURE_PATH); }}
	
		/// <summary>
		/// The parameter for setting the color of debug normals.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.DebugNormalColor, new Color(255, 255, 255, 255));</c>
		/// </summary>
		static property String^ DebugNormalColor { String^ get() { return gcnew String(DEBUG_NORMAL_COLOR); }}

		/// <summary>
		/// The parameter for setting the length of debug normals.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.DebugNormalLength, 1.5f);</c>
		/// </summary>
		static property String^ DebugNormalLength { String^ get() { return gcnew String(DEBUG_NORMAL_LENGTH); }}

		/// <summary>
		/// The parameter for setting reference value of alpha in transparent materials.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.DMF_AlphaChannelRef, 0.1f);</c>
		/// </summary>
		static property String^ DMF_AlphaChannelRef { String^ get() { return gcnew String(DMF_ALPHA_CHANNEL_REF); }}

		/// <summary>
		/// The parameter for choose to flip or not tga files.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.DMF_FlipAlphaTextures, true);</c>
		/// </summary>
		static property String^ DMF_FlipAlphaTextures { String^ get() { return gcnew String(DMF_FLIP_ALPHA_TEXTURES); }}

		/// <summary>
		/// The parameter for preserving DMF textures dir structure with built-in DMF loader.
		/// If this parameter is set to true, the texture directory defined in the Deled file is ignored, and only the texture name is used to find the proper file.
		/// Otherwise, the texture path is also used, which allows to use a nicer media layout. By default this parameter is false.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.DMF_IgnoreMaterialsDir, true);</c>
		/// </summary>
		static property String^ DMF_IgnoreMaterialsDir { String^ get() { return gcnew String(DMF_IGNORE_MATERIALS_DIRS); }}

		[Obsolete("Deprecated, use IMeshLoader::getMeshTextureLoader()->setTexturePath instead. LIME_NO_SUPPORT_YET")]
		/// <summary>
		/// Deprecated. Was used to set path which will get prefixed to the file names defined in the Deled file when loading textures.
		/// This allows to alter the paths for a specific project setting
		/// like this: <c>SceneManager.Attributes.SetValue(SceneParameters.DMF_TexturePath, "path/to/your/textures");</c>
		/// </summary>
		static property String^ DMF_TexturePath { String^ get() { return gcnew String(DMF_TEXTURE_PATH); }}
	
		/// <summary>
		/// Flag set as parameter when the scene manager is used as editor.
		/// In this way special animators like deletion animators can be stopped from deleting scene nodes for example.
		/// </summary>
		static property String^ IRR_Editor { String^ get() { return gcnew String(IRR_SCENE_MANAGER_IS_EDITOR); }}
	
		[Obsolete("Deprecated, use IMeshLoader::getMeshTextureLoader()->setTexturePath instead. LIME_NO_SUPPORT_YET")]
		/// <summary>
		/// Deprecated. Was used for changing the texture path of the built-in lmts loader
		/// like this: <c>SceneManager.Attributes.SetValue(SceneParameters.LMTS_TexturePath, "path/to/your/textures");</c>
		/// </summary>
		static property String^ LMTS_TexturePath { String^ get() { return gcnew String(LMTS_TEXTURE_PATH); }}
	
		[Obsolete("Deprecated, use IMeshLoader::getMeshTextureLoader()->setTexturePath instead. LIME_NO_SUPPORT_YET")]
		/// <summary>
		/// Deprecated. Was used for changing the texture path of the built-in MY3D loader
		/// like this: <c>SceneManager.Attributes.SetValue(SceneParameters.MY3D_TexturePath, "path/to/your/textures");</c>
		/// </summary>
		static property String^ MY3D_TexturePath { String^ get() { return gcnew String(MY3D_TEXTURE_PATH); }}
	
		/// <summary>
		/// Flag to avoid loading group structures in .obj files.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.OBJ_IgnoreGroups, true);</c>
		/// </summary>
		static property String^ OBJ_IgnoreGroups { String^ get() { return gcnew String(OBJ_LOADER_IGNORE_GROUPS); }}

		/// <summary>
		/// Flag to avoid loading material .mtl file for .obj files.
		/// Use it like this: <c>SceneManager.Attributes.SetValue(SceneParameters.OBJ_IgnoreMaterialFiles, true);</c>
		/// </summary>
		static property String^ OBJ_IgnoreMaterialFiles { String^ get() { return gcnew String(OBJ_LOADER_IGNORE_MATERIAL_FILES); }}

		[Obsolete("Deprecated, use IMeshLoader::getMeshTextureLoader()->setTexturePath instead. LIME_NO_SUPPORT_YET")]
		/// <summary>
		/// Deprecated. Was used for changing the texture path of the built-in obj loader
		/// like this: <c>SceneManager.Attributes.SetValue(SceneParameters.OBJ_TexturePath, "path/to/your/textures");</c>
		/// </summary>
		static property String^ OBJ_TexturePath { String^ get() { return gcnew String(OBJ_TEXTURE_PATH); }}
	};

} // end namespace Scene
} // end namespace IrrlichtLime
