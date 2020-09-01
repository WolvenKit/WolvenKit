using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STutorialMessage : CVariable
	{
		[Ordinal(0)] [RED("("type")] 		public CEnum<ETutorialMessageType> Type { get; set;}

		[Ordinal(0)] [RED("("tutorialScriptTag")] 		public CName TutorialScriptTag { get; set;}

		[Ordinal(0)] [RED("("journalEntryName")] 		public CName JournalEntryName { get; set;}

		[Ordinal(0)] [RED("("canBeShownInMenus")] 		public CBool CanBeShownInMenus { get; set;}

		[Ordinal(0)] [RED("("canBeShownInDialogs")] 		public CBool CanBeShownInDialogs { get; set;}

		[Ordinal(0)] [RED("("glossaryLink")] 		public CBool GlossaryLink { get; set;}

		[Ordinal(0)] [RED("("enableAcceptButton")] 		public CBool EnableAcceptButton { get; set;}

		[Ordinal(0)] [RED("("force")] 		public CBool Force { get; set;}

		[Ordinal(0)] [RED("("disableHorizontalResize")] 		public CBool DisableHorizontalResize { get; set;}

		[Ordinal(0)] [RED("("forceToQueueFront")] 		public CBool ForceToQueueFront { get; set;}

		[Ordinal(0)] [RED("("hintPositionType")] 		public CEnum<ETutorialHintPositionType> HintPositionType { get; set;}

		[Ordinal(0)] [RED("("hintPosX")] 		public CFloat HintPosX { get; set;}

		[Ordinal(0)] [RED("("hintPosY")] 		public CFloat HintPosY { get; set;}

		[Ordinal(0)] [RED("("hintDuration")] 		public CFloat HintDuration { get; set;}

		[Ordinal(0)] [RED("("hintCloseOnFactExist")] 		public CString HintCloseOnFactExist { get; set;}

		[Ordinal(0)] [RED("("highlightAreas", 2,0)] 		public CArray<STutorialHighlight> HighlightAreas { get; set;}

		[Ordinal(0)] [RED("("disabledPanelsExceptions", 2,0)] 		public CArray<CName> DisabledPanelsExceptions { get; set;}

		[Ordinal(0)] [RED("("hintPromptScriptTag")] 		public CName HintPromptScriptTag { get; set;}

		[Ordinal(0)] [RED("("hintPromptPosX")] 		public CFloat HintPromptPosX { get; set;}

		[Ordinal(0)] [RED("("hintPromptPosY")] 		public CFloat HintPromptPosY { get; set;}

		[Ordinal(0)] [RED("("hintPromptDuration")] 		public CFloat HintPromptDuration { get; set;}

		[Ordinal(0)] [RED("("hintPromptCloseFact")] 		public CString HintPromptCloseFact { get; set;}

		[Ordinal(0)] [RED("("markAsSeenOnShow")] 		public CBool MarkAsSeenOnShow { get; set;}

		[Ordinal(0)] [RED("("isHUDTutorial")] 		public CBool IsHUDTutorial { get; set;}

		[Ordinal(0)] [RED("("hintDurationType")] 		public CEnum<ETutorialHintDurationType> HintDurationType { get; set;}

		[Ordinal(0)] [RED("("blockInput")] 		public CBool BlockInput { get; set;}

		[Ordinal(0)] [RED("("pauseGame")] 		public CBool PauseGame { get; set;}

		[Ordinal(0)] [RED("("fullscreen")] 		public CBool Fullscreen { get; set;}

		[Ordinal(0)] [RED("("minDuration")] 		public CFloat MinDuration { get; set;}

		[Ordinal(0)] [RED("("remainingMinDuration")] 		public CFloat RemainingMinDuration { get; set;}

		[Ordinal(0)] [RED("("hideOnMinDurationEnd")] 		public CBool HideOnMinDurationEnd { get; set;}

		[Ordinal(0)] [RED("("factOnFinishedDisplay")] 		public CString FactOnFinishedDisplay { get; set;}

		public STutorialMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STutorialMessage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}