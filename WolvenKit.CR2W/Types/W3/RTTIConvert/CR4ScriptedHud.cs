using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4ScriptedHud : CR4Hud
	{
		[RED("m_hudSize")] 		public CInt32 M_hudSize { get; set;}

		[RED("m_minimapRotationEnabled")] 		public CBool M_minimapRotationEnabled { get; set;}

		[RED("m_minimapZoom")] 		public CFloat M_minimapZoom { get; set;}

		[RED("m_enabledEnemyFocus")] 		public CBool M_enabledEnemyFocus { get; set;}

		[RED("m_enabledNPCNames")] 		public CBool M_enabledNPCNames { get; set;}

		[RED("m_enemyHitEffects")] 		public CBool M_enemyHitEffects { get; set;}

		[RED("m_dlcMessagePending")] 		public CBool M_dlcMessagePending { get; set;}

		[RED("m_HudFlashSFS")] 		public CHandle<CScriptedFlashSprite> M_HudFlashSFS { get; set;}

		[RED("m_fxShowModulesSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowModulesSFF { get; set;}

		[RED("m_fxPrintInfoSFF")] 		public CHandle<CScriptedFlashFunction> M_fxPrintInfoSFF { get; set;}

		[RED("m_fxSetInputContextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInputContextSFF { get; set;}

		[RED("m_fxSetIsDynamicSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetIsDynamicSFF { get; set;}

		[RED("m_fxSetControllerType")] 		public CHandle<CScriptedFlashFunction> M_fxSetControllerType { get; set;}

		[RED("m_fxSwapAcceptCancel")] 		public CHandle<CScriptedFlashFunction> M_fxSwapAcceptCancel { get; set;}

		[RED("m_fxSetGamepadType")] 		public CHandle<CScriptedFlashFunction> M_fxSetGamepadType { get; set;}

		[RED("m_fxLockControlScheme")] 		public CHandle<CScriptedFlashFunction> M_fxLockControlScheme { get; set;}

		[RED("m_fxSetGameLanguage")] 		public CHandle<CScriptedFlashFunction> M_fxSetGameLanguage { get; set;}

		[RED("m_fxOnCutscene")] 		public CHandle<CScriptedFlashFunction> M_fxOnCutscene { get; set;}

		[RED("hudModules", 2,0)] 		public CArray<CHandle<CR4HudModuleBase>> HudModules { get; set;}

		[RED("hudModulesNames", 2,0)] 		public CArray<CName> HudModulesNames { get; set;}

		[RED("currentInputContext")] 		public CName CurrentInputContext { get; set;}

		[RED("previousInputContext")] 		public CName PreviousInputContext { get; set;}

		[RED("m_isDynamic")] 		public CBool M_isDynamic { get; set;}

		[RED("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		[RED("m_deathTimerActive")] 		public CBool M_deathTimerActive { get; set;}

		[RED("m_deathTimer")] 		public CFloat M_deathTimer { get; set;}

		[RED("m_scaleformWidth")] 		public CInt32 M_scaleformWidth { get; set;}

		[RED("m_scaleformHeight")] 		public CInt32 M_scaleformHeight { get; set;}

		[RED("m_scaleformOffsetX")] 		public CInt32 M_scaleformOffsetX { get; set;}

		[RED("m_scaleformOffsetY")] 		public CInt32 M_scaleformOffsetY { get; set;}

		[RED("m_visibleHudBySystem")] 		public CBool M_visibleHudBySystem { get; set;}

		[RED("m_visibleHudByUser")] 		public CBool M_visibleHudByUser { get; set;}

		[RED("m_visibleHudByScene")] 		public CBool M_visibleHudByScene { get; set;}

		[RED("m_visibleHudByRadial")] 		public CBool M_visibleHudByRadial { get; set;}

		[RED("languageName")] 		public CString LanguageName { get; set;}

		[RED("m_lastUsedDeviceName")] 		public CEnum<EInputDeviceType> M_lastUsedDeviceName { get; set;}

		[RED("_cachedEntity")] 		public CHandle<CEntity> _cachedEntity { get; set;}

		[RED("_cachedEntityPosition")] 		public Vector _cachedEntityPosition { get; set;}

		public CR4ScriptedHud(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4ScriptedHud(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}