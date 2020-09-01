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
		[Ordinal(0)] [RED("("m_fxSentenceSetSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSentenceSetSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxPreviousSentenceSetSFF")] 		public CHandle<CScriptedFlashFunction> M_fxPreviousSentenceSetSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxPreviousSentenceHideSFF")] 		public CHandle<CScriptedFlashFunction> M_fxPreviousSentenceHideSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSentenceHideSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSentenceHideSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxChoiceTimeoutSetSFF")] 		public CHandle<CScriptedFlashFunction> M_fxChoiceTimeoutSetSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxChoiceTimeoutHideSFF")] 		public CHandle<CScriptedFlashFunction> M_fxChoiceTimeoutHideSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSkipConfirmShowSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSkipConfirmShowSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSkipConfirmHideSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSkipConfirmHideSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSetBarValueSFF")] 		public CHandle<CScriptedFlashFunction> M_fxSetBarValueSFF { get; set;}

		[Ordinal(0)] [RED("("m_fxSetCanBeSkipped")] 		public CHandle<CScriptedFlashFunction> M_fxSetCanBeSkipped { get; set;}

		[Ordinal(0)] [RED("("m_fxSetAlternativeDialogOptionView")] 		public CHandle<CScriptedFlashFunction> M_fxSetAlternativeDialogOptionView { get; set;}

		[Ordinal(0)] [RED("("monsterBarganingPopupMenu")] 		public CHandle<CR4MenuPopup> MonsterBarganingPopupMenu { get; set;}

		[Ordinal(0)] [RED("("m_guiManager")] 		public CHandle<CR4GuiManager> M_guiManager { get; set;}

		[Ordinal(0)] [RED("("m_LastNegotiationResult")] 		public CEnum<ENegotiationResult> M_LastNegotiationResult { get; set;}

		[Ordinal(0)] [RED("("currentRewardName")] 		public CName CurrentRewardName { get; set;}

		[Ordinal(0)] [RED("("currentRewardMultiply")] 		public CFloat CurrentRewardMultiply { get; set;}

		[Ordinal(0)] [RED("("isBet")] 		public CBool IsBet { get; set;}

		[Ordinal(0)] [RED("("isReverseHaggling")] 		public CBool IsReverseHaggling { get; set;}

		[Ordinal(0)] [RED("("isPopupOpened")] 		public CBool IsPopupOpened { get; set;}

		[Ordinal(0)] [RED("("isGwentMode")] 		public CBool IsGwentMode { get; set;}

		[Ordinal(0)] [RED("("anger")] 		public CFloat Anger { get; set;}

		[Ordinal(0)] [RED("("currentReward")] 		public CInt32 CurrentReward { get; set;}

		[Ordinal(0)] [RED("("minimalHagglingReward")] 		public CInt32 MinimalHagglingReward { get; set;}

		[Ordinal(0)] [RED("("maxHaggleValue")] 		public CInt32 MaxHaggleValue { get; set;}

		[Ordinal(0)] [RED("("NPCsPrettyClose")] 		public CFloat NPCsPrettyClose { get; set;}

		[Ordinal(0)] [RED("("NPCsTooMuch")] 		public CFloat NPCsTooMuch { get; set;}

		[Ordinal(0)] [RED("("LowestPriceControlFact")] 		public CString LowestPriceControlFact { get; set;}

		[Ordinal(0)] [RED("("lastSetChoices", 2,0)] 		public CArray<SSceneChoice> LastSetChoices { get; set;}

		public CR4HudModuleDialog(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4HudModuleDialog(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}