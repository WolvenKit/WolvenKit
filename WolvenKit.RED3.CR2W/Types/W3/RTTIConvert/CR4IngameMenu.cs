using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4IngameMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("mInGameConfigWrapper")] 		public CHandle<CInGameConfigWrapper> MInGameConfigWrapper { get; set;}

		[Ordinal(2)] [RED("inGameConfigBufferedWrapper")] 		public CHandle<CInGameConfigBufferedWrapper> InGameConfigBufferedWrapper { get; set;}

		[Ordinal(3)] [RED("currentNewGameConfig")] 		public newGameConfig CurrentNewGameConfig { get; set;}

		[Ordinal(4)] [RED("m_fxNavigateBack")] 		public CHandle<CScriptedFlashFunction> M_fxNavigateBack { get; set;}

		[Ordinal(5)] [RED("m_fxSetIsMainMenu")] 		public CHandle<CScriptedFlashFunction> M_fxSetIsMainMenu { get; set;}

		[Ordinal(6)] [RED("m_fxSetCurrentUsername")] 		public CHandle<CScriptedFlashFunction> M_fxSetCurrentUsername { get; set;}

		[Ordinal(7)] [RED("m_fxSetVersion")] 		public CHandle<CScriptedFlashFunction> M_fxSetVersion { get; set;}

		[Ordinal(8)] [RED("m_fxShowHelp")] 		public CHandle<CScriptedFlashFunction> M_fxShowHelp { get; set;}

		[Ordinal(9)] [RED("m_fxSetVisible")] 		public CHandle<CScriptedFlashFunction> M_fxSetVisible { get; set;}

		[Ordinal(10)] [RED("m_fxSetPanelMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetPanelMode { get; set;}

		[Ordinal(11)] [RED("m_fxRemoveOption")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveOption { get; set;}

		[Ordinal(12)] [RED("m_fxSetGameLogoLanguage")] 		public CHandle<CScriptedFlashFunction> M_fxSetGameLogoLanguage { get; set;}

		[Ordinal(13)] [RED("m_fxUpdateOptionValue")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateOptionValue { get; set;}

		[Ordinal(14)] [RED("m_fxUpdateInputFeedback")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateInputFeedback { get; set;}

		[Ordinal(15)] [RED("m_fxOnSaveScreenshotRdy")] 		public CHandle<CScriptedFlashFunction> M_fxOnSaveScreenshotRdy { get; set;}

		[Ordinal(16)] [RED("m_fxSetIgnoreInput")] 		public CHandle<CScriptedFlashFunction> M_fxSetIgnoreInput { get; set;}

		[Ordinal(17)] [RED("m_fxForceEnterCurEntry")] 		public CHandle<CScriptedFlashFunction> M_fxForceEnterCurEntry { get; set;}

		[Ordinal(18)] [RED("m_fxForceBackgroundVis")] 		public CHandle<CScriptedFlashFunction> M_fxForceBackgroundVis { get; set;}

		[Ordinal(19)] [RED("m_fxSetHardwareCursorOn")] 		public CHandle<CScriptedFlashFunction> M_fxSetHardwareCursorOn { get; set;}

		[Ordinal(20)] [RED("m_fxSetExpansionText")] 		public CHandle<CScriptedFlashFunction> M_fxSetExpansionText { get; set;}

		[Ordinal(21)] [RED("m_fxUpdateAnchorsAspectRatio")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateAnchorsAspectRatio { get; set;}

		[Ordinal(22)] [RED("loadConfPopup")] 		public CHandle<W3ApplyLoadConfirmation> LoadConfPopup { get; set;}

		[Ordinal(23)] [RED("saveConfPopup")] 		public CHandle<W3SaveGameConfirmation> SaveConfPopup { get; set;}

		[Ordinal(24)] [RED("newGameConfPopup")] 		public CHandle<W3NewGameConfirmation> NewGameConfPopup { get; set;}

		[Ordinal(25)] [RED("actionConfPopup")] 		public CHandle<W3ActionConfirmation> ActionConfPopup { get; set;}

		[Ordinal(26)] [RED("deleteConfPopup")] 		public CHandle<W3DeleteSaveConf> DeleteConfPopup { get; set;}

		[Ordinal(27)] [RED("diffChangeConfPopup")] 		public CHandle<W3DifficultyChangeConfirmation> DiffChangeConfPopup { get; set;}

		[Ordinal(28)] [RED("isShowingSaveList")] 		public CBool IsShowingSaveList { get; set;}

		[Ordinal(29)] [RED("isShowingLoadList")] 		public CBool IsShowingLoadList { get; set;}

		[Ordinal(30)] [RED("smartKeybindingEnabled")] 		public CBool SmartKeybindingEnabled { get; set;}

		[Ordinal(31)] [RED("m_structureCreator")] 		public CHandle<IngameMenuStructureCreator> M_structureCreator { get; set;}

		[Ordinal(32)] [RED("isInLoadselector")] 		public CBool IsInLoadselector { get; set;}

		[Ordinal(33)] [RED("swapAcceptCancelChanged")] 		public CBool SwapAcceptCancelChanged { get; set;}

		[Ordinal(34)] [RED("alternativeRadialInputChanged")] 		public CBool AlternativeRadialInputChanged { get; set;}

		[Ordinal(35)] [RED("EnableUberMovement")] 		public CBool EnableUberMovement { get; set;}

		[Ordinal(36)] [RED("shouldRefreshKinect")] 		public CBool ShouldRefreshKinect { get; set;}

		[Ordinal(37)] [RED("isMainMenu")] 		public CBool IsMainMenu { get; set;}

		[Ordinal(38)] [RED("managingPause")] 		public CBool ManagingPause { get; set;}

		[Ordinal(39)] [RED("updateInputDeviceRequired")] 		public CBool UpdateInputDeviceRequired { get; set;}

		[Ordinal(40)] [RED("hasChangedOption")] 		public CBool HasChangedOption { get; set;}

		[Ordinal(41)] [RED("ignoreInput")] 		public CBool IgnoreInput { get; set;}

		[Ordinal(42)] [RED("disableAccountPicker")] 		public CBool DisableAccountPicker { get; set;}

		[Ordinal(43)] [RED("lastSetTag")] 		public CInt32 LastSetTag { get; set;}

		[Ordinal(44)] [RED("currentLangValue")] 		public CString CurrentLangValue { get; set;}

		[Ordinal(45)] [RED("lastUsedLangValue")] 		public CString LastUsedLangValue { get; set;}

		[Ordinal(46)] [RED("currentSpeechLang")] 		public CString CurrentSpeechLang { get; set;}

		[Ordinal(47)] [RED("lastUsedSpeechLang")] 		public CString LastUsedSpeechLang { get; set;}

		[Ordinal(48)] [RED("languageName")] 		public CString LanguageName { get; set;}

		[Ordinal(49)] [RED("panelMode")] 		public CBool PanelMode { get; set;}

		[Ordinal(50)] [RED("lastSetDifficulty")] 		public CInt32 LastSetDifficulty { get; set;}

		public CR4IngameMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4IngameMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}