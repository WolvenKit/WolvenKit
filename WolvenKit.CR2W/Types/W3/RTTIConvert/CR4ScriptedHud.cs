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
		[Ordinal(0)] [RED("m_hudSize")] 		public CInt32 M_hudSize { get; set;}

		[Ordinal(0)] [RED("m_minimapRotationEnabled")] 		public CBool M_minimapRotationEnabled { get; set;}

		[Ordinal(0)] [RED("m_minimapZoom")] 		public CFloat M_minimapZoom { get; set;}

		[Ordinal(0)] [RED("m_enabledEnemyFocus")] 		public CBool M_enabledEnemyFocus { get; set;}

		[Ordinal(0)] [RED("m_enabledNPCNames")] 		public CBool M_enabledNPCNames { get; set;}

		[Ordinal(0)] [RED("m_enemyHitEffects")] 		public CBool M_enemyHitEffects { get; set;}

		[Ordinal(0)] [RED("m_dlcMessagePending")] 		public CBool M_dlcMessagePending { get; set;}

		[Ordinal(0)] [RED("m_HudFlashSFS")] 		public CHandle<CScriptedFlashSprite> M_HudFlashSFS { get; set;}

		[Ordinal(0)] [RED("m_fxShowModulesSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowModulesSFF { get; set;}

		[Ordinal(0)] [RED("m_fxPrintInfoSFF")] 		public CHandle<CScriptedFlashFunction> M_fxPrintInfoSFF { get; set;}

		[Ordinal(0)] [RED("m_fxSetInputContextSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetInputContextSFF { get; set;}

		[Ordinal(0)] [RED("m_fxSetIsDynamicSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetIsDynamicSFF { get; set;}

		[Ordinal(0)] [RED("m_fxSetControllerType")] 		public CHandle<CScriptedFlashFunction> M_fxSetControllerType { get; set;}

		[Ordinal(0)] [RED("m_fxSwapAcceptCancel")] 		public CHandle<CScriptedFlashFunction> M_fxSwapAcceptCancel { get; set;}

		[Ordinal(0)] [RED("m_fxSetGamepadType")] 		public CHandle<CScriptedFlashFunction> M_fxSetGamepadType { get; set;}

		[Ordinal(0)] [RED("m_fxLockControlScheme")] 		public CHandle<CScriptedFlashFunction> M_fxLockControlScheme { get; set;}

		[Ordinal(0)] [RED("m_fxSetGameLanguage")] 		public CHandle<CScriptedFlashFunction> M_fxSetGameLanguage { get; set;}

		[Ordinal(0)] [RED("m_fxOnCutscene")] 		public CHandle<CScriptedFlashFunction> M_fxOnCutscene { get; set;}

		[Ordinal(0)] [RED("hudModules", 2,0)] 		public CArray<CHandle<CR4HudModuleBase>> HudModules { get; set;}

		[Ordinal(0)] [RED("hudModulesNames", 2,0)] 		public CArray<CName> HudModulesNames { get; set;}

		[Ordinal(0)] [RED("currentInputContext")] 		public CName CurrentInputContext { get; set;}

		[Ordinal(0)] [RED("previousInputContext")] 		public CName PreviousInputContext { get; set;}

		[Ordinal(0)] [RED("m_isDynamic")] 		public CBool M_isDynamic { get; set;}

		[Ordinal(0)] [RED("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		[Ordinal(0)] [RED("m_deathTimerActive")] 		public CBool M_deathTimerActive { get; set;}

		[Ordinal(0)] [RED("m_deathTimer")] 		public CFloat M_deathTimer { get; set;}

		[Ordinal(0)] [RED("m_scaleformWidth")] 		public CInt32 M_scaleformWidth { get; set;}

		[Ordinal(0)] [RED("m_scaleformHeight")] 		public CInt32 M_scaleformHeight { get; set;}

		[Ordinal(0)] [RED("m_scaleformOffsetX")] 		public CInt32 M_scaleformOffsetX { get; set;}

		[Ordinal(0)] [RED("m_scaleformOffsetY")] 		public CInt32 M_scaleformOffsetY { get; set;}

		[Ordinal(0)] [RED("m_visibleHudBySystem")] 		public CBool M_visibleHudBySystem { get; set;}

		[Ordinal(0)] [RED("m_visibleHudByUser")] 		public CBool M_visibleHudByUser { get; set;}

		[Ordinal(0)] [RED("m_visibleHudByScene")] 		public CBool M_visibleHudByScene { get; set;}

		[Ordinal(0)] [RED("m_visibleHudByRadial")] 		public CBool M_visibleHudByRadial { get; set;}

		[Ordinal(0)] [RED("languageName")] 		public CString LanguageName { get; set;}

		[Ordinal(0)] [RED("m_lastUsedDeviceName")] 		public CEnum<EInputDeviceType> M_lastUsedDeviceName { get; set;}

		[Ordinal(0)] [RED("_cachedEntity")] 		public CHandle<CEntity> _cachedEntity { get; set;}

		[Ordinal(0)] [RED("_cachedEntityPosition")] 		public Vector _cachedEntityPosition { get; set;}

		public CR4ScriptedHud(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4ScriptedHud(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}