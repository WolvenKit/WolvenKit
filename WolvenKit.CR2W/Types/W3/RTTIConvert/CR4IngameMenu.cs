using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4IngameMenu : CR4MenuBase
	{
		[RED("mInGameConfigWrapper")] 		public CHandle<CInGameConfigWrapper> MInGameConfigWrapper { get; set;}

		[RED("inGameConfigBufferedWrapper")] 		public CHandle<CInGameConfigBufferedWrapper> InGameConfigBufferedWrapper { get; set;}

		[RED("currentNewGameConfig")] 		public newGameConfig CurrentNewGameConfig { get; set;}

		[RED("m_fxNavigateBack")] 		public CHandle<CScriptedFlashFunction> M_fxNavigateBack { get; set;}

		[RED("m_fxSetIsMainMenu")] 		public CHandle<CScriptedFlashFunction> M_fxSetIsMainMenu { get; set;}

		[RED("m_fxSetCurrentUsername")] 		public CHandle<CScriptedFlashFunction> M_fxSetCurrentUsername { get; set;}

		[RED("m_fxSetVersion")] 		public CHandle<CScriptedFlashFunction> M_fxSetVersion { get; set;}

		[RED("m_fxShowHelp")] 		public CHandle<CScriptedFlashFunction> M_fxShowHelp { get; set;}

		[RED("m_fxSetVisible")] 		public CHandle<CScriptedFlashFunction> M_fxSetVisible { get; set;}

		[RED("m_fxSetPanelMode")] 		public CHandle<CScriptedFlashFunction> M_fxSetPanelMode { get; set;}

		[RED("m_fxRemoveOption")] 		public CHandle<CScriptedFlashFunction> M_fxRemoveOption { get; set;}

		[RED("m_fxSetGameLogoLanguage")] 		public CHandle<CScriptedFlashFunction> M_fxSetGameLogoLanguage { get; set;}

		[RED("m_fxUpdateOptionValue")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateOptionValue { get; set;}

		[RED("m_fxUpdateInputFeedback")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateInputFeedback { get; set;}

		[RED("m_fxOnSaveScreenshotRdy")] 		public CHandle<CScriptedFlashFunction> M_fxOnSaveScreenshotRdy { get; set;}

		[RED("m_fxSetIgnoreInput")] 		public CHandle<CScriptedFlashFunction> M_fxSetIgnoreInput { get; set;}

		[RED("m_fxForceEnterCurEntry")] 		public CHandle<CScriptedFlashFunction> M_fxForceEnterCurEntry { get; set;}

		[RED("m_fxForceBackgroundVis")] 		public CHandle<CScriptedFlashFunction> M_fxForceBackgroundVis { get; set;}

		[RED("m_fxSetHardwareCursorOn")] 		public CHandle<CScriptedFlashFunction> M_fxSetHardwareCursorOn { get; set;}

		[RED("m_fxSetExpansionText")] 		public CHandle<CScriptedFlashFunction> M_fxSetExpansionText { get; set;}

		[RED("m_fxUpdateAnchorsAspectRatio")] 		public CHandle<CScriptedFlashFunction> M_fxUpdateAnchorsAspectRatio { get; set;}

		[RED("loadConfPopup")] 		public CHandle<W3ApplyLoadConfirmation> LoadConfPopup { get; set;}

		[RED("saveConfPopup")] 		public CHandle<W3SaveGameConfirmation> SaveConfPopup { get; set;}

		[RED("newGameConfPopup")] 		public CHandle<W3NewGameConfirmation> NewGameConfPopup { get; set;}

		[RED("actionConfPopup")] 		public CHandle<W3ActionConfirmation> ActionConfPopup { get; set;}

		[RED("deleteConfPopup")] 		public CHandle<W3DeleteSaveConf> DeleteConfPopup { get; set;}

		[RED("diffChangeConfPopup")] 		public CHandle<W3DifficultyChangeConfirmation> DiffChangeConfPopup { get; set;}

		[RED("isShowingSaveList")] 		public CBool IsShowingSaveList { get; set;}

		[RED("isShowingLoadList")] 		public CBool IsShowingLoadList { get; set;}

		[RED("smartKeybindingEnabled")] 		public CBool SmartKeybindingEnabled { get; set;}

		[RED("m_structureCreator")] 		public CHandle<IngameMenuStructureCreator> M_structureCreator { get; set;}

		[RED("isInLoadselector")] 		public CBool IsInLoadselector { get; set;}

		[RED("swapAcceptCancelChanged")] 		public CBool SwapAcceptCancelChanged { get; set;}

		[RED("alternativeRadialInputChanged")] 		public CBool AlternativeRadialInputChanged { get; set;}

		[RED("EnableUberMovement")] 		public CBool EnableUberMovement { get; set;}

		[RED("shouldRefreshKinect")] 		public CBool ShouldRefreshKinect { get; set;}

		[RED("isMainMenu")] 		public CBool IsMainMenu { get; set;}

		[RED("managingPause")] 		public CBool ManagingPause { get; set;}

		[RED("updateInputDeviceRequired")] 		public CBool UpdateInputDeviceRequired { get; set;}

		[RED("hasChangedOption")] 		public CBool HasChangedOption { get; set;}

		[RED("ignoreInput")] 		public CBool IgnoreInput { get; set;}

		[RED("disableAccountPicker")] 		public CBool DisableAccountPicker { get; set;}

		[RED("lastSetTag")] 		public CInt32 LastSetTag { get; set;}

		[RED("currentLangValue")] 		public CString CurrentLangValue { get; set;}

		[RED("lastUsedLangValue")] 		public CString LastUsedLangValue { get; set;}

		[RED("currentSpeechLang")] 		public CString CurrentSpeechLang { get; set;}

		[RED("lastUsedSpeechLang")] 		public CString LastUsedSpeechLang { get; set;}

		[RED("languageName")] 		public CString LanguageName { get; set;}

		[RED("panelMode")] 		public CBool PanelMode { get; set;}

		[RED("lastSetDifficulty")] 		public CInt32 LastSetDifficulty { get; set;}

		public CR4IngameMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4IngameMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}