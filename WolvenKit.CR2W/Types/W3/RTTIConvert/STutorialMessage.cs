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
		[RED("type")] 		public CEnum<ETutorialMessageType> Type { get; set;}

		[RED("tutorialScriptTag")] 		public CName TutorialScriptTag { get; set;}

		[RED("journalEntryName")] 		public CName JournalEntryName { get; set;}

		[RED("canBeShownInMenus")] 		public CBool CanBeShownInMenus { get; set;}

		[RED("canBeShownInDialogs")] 		public CBool CanBeShownInDialogs { get; set;}

		[RED("glossaryLink")] 		public CBool GlossaryLink { get; set;}

		[RED("enableAcceptButton")] 		public CBool EnableAcceptButton { get; set;}

		[RED("force")] 		public CBool Force { get; set;}

		[RED("disableHorizontalResize")] 		public CBool DisableHorizontalResize { get; set;}

		[RED("forceToQueueFront")] 		public CBool ForceToQueueFront { get; set;}

		[RED("hintPositionType")] 		public CEnum<ETutorialHintPositionType> HintPositionType { get; set;}

		[RED("hintPosX")] 		public CFloat HintPosX { get; set;}

		[RED("hintPosY")] 		public CFloat HintPosY { get; set;}

		[RED("hintDuration")] 		public CFloat HintDuration { get; set;}

		[RED("hintCloseOnFactExist")] 		public CString HintCloseOnFactExist { get; set;}

		[RED("highlightAreas", 2,0)] 		public CArray<STutorialHighlight> HighlightAreas { get; set;}

		[RED("disabledPanelsExceptions", 2,0)] 		public CArray<CName> DisabledPanelsExceptions { get; set;}

		[RED("hintPromptScriptTag")] 		public CName HintPromptScriptTag { get; set;}

		[RED("hintPromptPosX")] 		public CFloat HintPromptPosX { get; set;}

		[RED("hintPromptPosY")] 		public CFloat HintPromptPosY { get; set;}

		[RED("hintPromptDuration")] 		public CFloat HintPromptDuration { get; set;}

		[RED("hintPromptCloseFact")] 		public CString HintPromptCloseFact { get; set;}

		[RED("markAsSeenOnShow")] 		public CBool MarkAsSeenOnShow { get; set;}

		[RED("isHUDTutorial")] 		public CBool IsHUDTutorial { get; set;}

		[RED("hintDurationType")] 		public CEnum<ETutorialHintDurationType> HintDurationType { get; set;}

		[RED("blockInput")] 		public CBool BlockInput { get; set;}

		[RED("pauseGame")] 		public CBool PauseGame { get; set;}

		[RED("fullscreen")] 		public CBool Fullscreen { get; set;}

		[RED("minDuration")] 		public CFloat MinDuration { get; set;}

		[RED("remainingMinDuration")] 		public CFloat RemainingMinDuration { get; set;}

		[RED("hideOnMinDurationEnd")] 		public CBool HideOnMinDurationEnd { get; set;}

		[RED("factOnFinishedDisplay")] 		public CString FactOnFinishedDisplay { get; set;}

		public STutorialMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STutorialMessage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}