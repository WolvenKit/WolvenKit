using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4MenuBase : CR4Menu
	{
		[Ordinal(0)] [RED("("m_flashValueStorage")] 		public CHandle<CScriptedFlashValueStorage> M_flashValueStorage { get; set;}

		[Ordinal(0)] [RED("("m_flashModule")] 		public CHandle<CScriptedFlashSprite> M_flashModule { get; set;}

		[Ordinal(0)] [RED("("m_parentMenu")] 		public CHandle<CR4MenuBase> M_parentMenu { get; set;}

		[Ordinal(0)] [RED("("m_fxBlurLayer")] 		public CHandle<CScriptedFlashFunction> M_fxBlurLayer { get; set;}

		[Ordinal(0)] [RED("("m_fxSetState")] 		public CHandle<CScriptedFlashFunction> M_fxSetState { get; set;}

		[Ordinal(0)] [RED("("m_fxSetColorBlindMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetColorBlindMode { get; set;}

		[Ordinal(0)] [RED("("m_fxSetCurrentModule")] 		public CHandle<CScriptedFlashFunction> M_fxSetCurrentModule { get; set;}

		[Ordinal(0)] [RED("("m_fxSetIsInCombat")] 		public CHandle<CScriptedFlashFunction> M_fxSetIsInCombat { get; set;}

		[Ordinal(0)] [RED("("m_fxShowSecondaryModulesSFF")] 		public CHandle<CScriptedFlashFunction> M_fxShowSecondaryModulesSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSetArabicAligmentMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetArabicAligmentMode { get; set;}

		[Ordinal(0)] [RED("("m_fxSetGameLanguage")] 		public CHandle<CScriptedFlashFunction> M_fxSetGameLanguage { get; set;}

		[Ordinal(0)] [RED("("m_fxSetRestrictDirectClosing")] 		public CHandle<CScriptedFlashFunction> M_fxSetRestrictDirectClosing { get; set;}

		[Ordinal(0)] [RED("("m_fxSwapAcceptCancel")] 		public CHandle<CScriptedFlashFunction> M_fxSwapAcceptCancel { get; set;}

		[Ordinal(0)] [RED("("m_fxSetControllerType")] 		public CHandle<CScriptedFlashFunction> M_fxSetControllerType { get; set;}

		[Ordinal(0)] [RED("("m_fxSetPlatform")] 		public CHandle<CScriptedFlashFunction> M_fxSetPlatform { get; set;}

		[Ordinal(0)] [RED("("m_fxSetGamepadType")] 		public CHandle<CScriptedFlashFunction> M_fxSetGamepadType { get; set;}

		[Ordinal(0)] [RED("("m_fxLockControlScheme")] 		public CHandle<CScriptedFlashFunction> M_fxLockControlScheme { get; set;}

		[Ordinal(0)] [RED("("m_fxSetTooltipState")] 		public CHandle<CScriptedFlashFunction> M_fxSetTooltipState { get; set;}

		[Ordinal(0)] [RED("("m_fxEnableDebugInput")] 		public CHandle<CScriptedFlashFunction> M_fxEnableDebugInput { get; set;}

		[Ordinal(0)] [RED("("m_fxSetPaperdollPreviewIcon")] 		public CHandle<CScriptedFlashFunction> M_fxSetPaperdollPreviewIcon { get; set;}

		[Ordinal(0)] [RED("("m_menuState")] 		public CName M_menuState { get; set;}

		[Ordinal(0)] [RED("("m_notificationData")] 		public CHandle<W3TutorialPopupData> M_notificationData { get; set;}

		[Ordinal(0)] [RED("("m_currentContext")] 		public CHandle<W3UIContext> M_currentContext { get; set;}

		[Ordinal(0)] [RED("("m_defaultInputBindings", 2,0)] 		public CArray<SKeyBinding> M_defaultInputBindings { get; set;}

		[Ordinal(0)] [RED("("m_GFxInputBindings", 2,0)] 		public CArray<SKeyBinding> M_GFxInputBindings { get; set;}

		[Ordinal(0)] [RED("("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		[Ordinal(0)] [RED("("m_commonMenu")] 		public CHandle<CR4CommonMenu> M_commonMenu { get; set;}

		[Ordinal(0)] [RED("("UISavedData")] 		public SUISavedData UISavedData { get; set;}

		[Ordinal(0)] [RED("("m_lastSelectedModule")] 		public CInt32 M_lastSelectedModule { get; set;}

		[Ordinal(0)] [RED("("mouseCursorType")] 		public CEnum<ECursorType> MouseCursorType { get; set;}

		[Ordinal(0)] [RED("("m_hideTutorial")] 		public CBool M_hideTutorial { get; set;}

		[Ordinal(0)] [RED("("m_forceHideTutorial")] 		public CBool M_forceHideTutorial { get; set;}

		[Ordinal(0)] [RED("("m_configUICalled")] 		public CBool M_configUICalled { get; set;}

		[Ordinal(0)] [RED("("m_initialSelectionsToIgnore")] 		public CInt32 M_initialSelectionsToIgnore { get; set;}

		[Ordinal(0)] [RED("("dontAutoCallOnOpeningMenuInOnConfigUIHaxxor")] 		public CBool DontAutoCallOnOpeningMenuInOnConfigUIHaxxor { get; set;}

		public CR4MenuBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4MenuBase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}