using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STutorialMessage : CVariable
	{
		[Ordinal(1)] [RED("type")] 		public CEnum<ETutorialMessageType> Type { get; set;}

		[Ordinal(2)] [RED("tutorialScriptTag")] 		public CName TutorialScriptTag { get; set;}

		[Ordinal(3)] [RED("journalEntryName")] 		public CName JournalEntryName { get; set;}

		[Ordinal(4)] [RED("canBeShownInMenus")] 		public CBool CanBeShownInMenus { get; set;}

		[Ordinal(5)] [RED("canBeShownInDialogs")] 		public CBool CanBeShownInDialogs { get; set;}

		[Ordinal(6)] [RED("glossaryLink")] 		public CBool GlossaryLink { get; set;}

		[Ordinal(7)] [RED("enableAcceptButton")] 		public CBool EnableAcceptButton { get; set;}

		[Ordinal(8)] [RED("force")] 		public CBool Force { get; set;}

		[Ordinal(9)] [RED("disableHorizontalResize")] 		public CBool DisableHorizontalResize { get; set;}

		[Ordinal(10)] [RED("forceToQueueFront")] 		public CBool ForceToQueueFront { get; set;}

		[Ordinal(11)] [RED("hintPositionType")] 		public CEnum<ETutorialHintPositionType> HintPositionType { get; set;}

		[Ordinal(12)] [RED("hintPosX")] 		public CFloat HintPosX { get; set;}

		[Ordinal(13)] [RED("hintPosY")] 		public CFloat HintPosY { get; set;}

		[Ordinal(14)] [RED("hintDuration")] 		public CFloat HintDuration { get; set;}

		[Ordinal(15)] [RED("hintCloseOnFactExist")] 		public CString HintCloseOnFactExist { get; set;}

		[Ordinal(16)] [RED("highlightAreas", 2,0)] 		public CArray<STutorialHighlight> HighlightAreas { get; set;}

		[Ordinal(17)] [RED("disabledPanelsExceptions", 2,0)] 		public CArray<CName> DisabledPanelsExceptions { get; set;}

		[Ordinal(18)] [RED("hintPromptScriptTag")] 		public CName HintPromptScriptTag { get; set;}

		[Ordinal(19)] [RED("hintPromptPosX")] 		public CFloat HintPromptPosX { get; set;}

		[Ordinal(20)] [RED("hintPromptPosY")] 		public CFloat HintPromptPosY { get; set;}

		[Ordinal(21)] [RED("hintPromptDuration")] 		public CFloat HintPromptDuration { get; set;}

		[Ordinal(22)] [RED("hintPromptCloseFact")] 		public CString HintPromptCloseFact { get; set;}

		[Ordinal(23)] [RED("markAsSeenOnShow")] 		public CBool MarkAsSeenOnShow { get; set;}

		[Ordinal(24)] [RED("isHUDTutorial")] 		public CBool IsHUDTutorial { get; set;}

		[Ordinal(25)] [RED("hintDurationType")] 		public CEnum<ETutorialHintDurationType> HintDurationType { get; set;}

		[Ordinal(26)] [RED("blockInput")] 		public CBool BlockInput { get; set;}

		[Ordinal(27)] [RED("pauseGame")] 		public CBool PauseGame { get; set;}

		[Ordinal(28)] [RED("fullscreen")] 		public CBool Fullscreen { get; set;}

		[Ordinal(29)] [RED("minDuration")] 		public CFloat MinDuration { get; set;}

		[Ordinal(30)] [RED("remainingMinDuration")] 		public CFloat RemainingMinDuration { get; set;}

		[Ordinal(31)] [RED("hideOnMinDurationEnd")] 		public CBool HideOnMinDurationEnd { get; set;}

		[Ordinal(32)] [RED("factOnFinishedDisplay")] 		public CString FactOnFinishedDisplay { get; set;}

		public STutorialMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STutorialMessage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}