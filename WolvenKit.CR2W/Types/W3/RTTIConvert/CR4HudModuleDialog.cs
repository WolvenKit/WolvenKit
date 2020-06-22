using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4HudModuleDialog : CR4HudModuleBase
	{
		[RED("m_fxSentenceSetSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSentenceSetSFF { get; set;}

		[RED("m_fxPreviousSentenceSetSFF")] 		public CHandle<CScriptedFlashFunction> M_fxPreviousSentenceSetSFF { get; set;}

		[RED("m_fxPreviousSentenceHideSFF")] 		public CHandle<CScriptedFlashFunction> M_fxPreviousSentenceHideSFF { get; set;}

		[RED("m_fxSentenceHideSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSentenceHideSFF { get; set;}

		[RED("m_fxChoiceTimeoutSetSFF")] 		public CHandle<CScriptedFlashFunction> M_fxChoiceTimeoutSetSFF { get; set;}

		[RED("m_fxChoiceTimeoutHideSFF")] 		public CHandle<CScriptedFlashFunction> M_fxChoiceTimeoutHideSFF { get; set;}

		[RED("m_fxSkipConfirmShowSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSkipConfirmShowSFF { get; set;}

		[RED("m_fxSkipConfirmHideSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSkipConfirmHideSFF { get; set;}

		[RED("m_fxSetBarValueSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetBarValueSFF { get; set;}

		[RED("m_fxSetCanBeSkipped")] 		public CHandle<CScriptedFlashFunction> M_fxSetCanBeSkipped { get; set;}

		[RED("m_fxSetAlternativeDialogOptionView")] 		public CHandle<CScriptedFlashFunction> M_fxSetAlternativeDialogOptionView { get; set;}

		[RED("monsterBarganingPopupMenu")] 		public CHandle<CR4MenuPopup> MonsterBarganingPopupMenu { get; set;}

		[RED("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		[RED("m_LastNegotiationResult")] 		public CEnum<ENegotiationResult> M_LastNegotiationResult { get; set;}

		[RED("currentRewardName")] 		public CName CurrentRewardName { get; set;}

		[RED("currentRewardMultiply")] 		public CFloat CurrentRewardMultiply { get; set;}

		[RED("isBet")] 		public CBool IsBet { get; set;}

		[RED("isReverseHaggling")] 		public CBool IsReverseHaggling { get; set;}

		[RED("isPopupOpened")] 		public CBool IsPopupOpened { get; set;}

		[RED("isGwentMode")] 		public CBool IsGwentMode { get; set;}

		[RED("anger")] 		public CFloat Anger { get; set;}

		[RED("currentReward")] 		public CInt32 CurrentReward { get; set;}

		[RED("minimalHagglingReward")] 		public CInt32 MinimalHagglingReward { get; set;}

		[RED("maxHaggleValue")] 		public CInt32 MaxHaggleValue { get; set;}

		[RED("NPCsPrettyClose")] 		public CFloat NPCsPrettyClose { get; set;}

		[RED("NPCsTooMuch")] 		public CFloat NPCsTooMuch { get; set;}

		[RED("LowestPriceControlFact")] 		public CString LowestPriceControlFact { get; set;}

		[RED("lastSetChoices", 2,0)] 		public CArray<SSceneChoice> LastSetChoices { get; set;}

		public CR4HudModuleDialog(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleDialog(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}