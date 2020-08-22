using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MonsterClue : W3AnimationInteractionEntity
	{
		[RED("isAvailable")] 		public CBool IsAvailable { get; set;}

		[RED("isInteractive")] 		public CBool IsInteractive { get; set;}

		[RED("isReusable")] 		public CBool IsReusable { get; set;}

		[RED("isVisible")] 		public CBool IsVisible { get; set;}

		[RED("isIgnoringFM")] 		public CBool IsIgnoringFM { get; set;}

		[RED("playerVoiceset")] 		public CEnum<EPlayerVoicesetType> PlayerVoiceset { get; set;}

		[RED("clueEntries", 2,0)] 		public CArray<CString> ClueEntries { get; set;}

		[RED("maxDetectionDistance")] 		public CFloat MaxDetectionDistance { get; set;}

		[RED("testLineOfSight")] 		public CBool TestLineOfSight { get; set;}

		[RED("medallionVibration")] 		public CBool MedallionVibration { get; set;}

		[RED("medallionVibrationDistance")] 		public CFloat MedallionVibrationDistance { get; set;}

		[RED("medallionVibrationBehavior")] 		public CEnum<EFocusClueMedallionReaction> MedallionVibrationBehavior { get; set;}

		[RED("medallionVibratedEver")] 		public CBool MedallionVibratedEver { get; set;}

		[RED("medallionVibratedInSession")] 		public CBool MedallionVibratedInSession { get; set;}

		[RED("accuracyTreshold")] 		public CFloat AccuracyTreshold { get; set;}

		[RED("eventOnDetected", 2,0)] 		public CArray<CHandle<IPerformableAction>> EventOnDetected { get; set;}

		[RED("detectionDelay")] 		public CFloat DetectionDelay { get; set;}

		[RED("wasDetected")] 		public CBool WasDetected { get; set;}

		[RED("wasSeen")] 		public CBool WasSeen { get; set;}

		[RED("isVisibleAsClue")] 		public CBool IsVisibleAsClue { get; set;}

		[RED("linkedFocusArea")] 		public CHandle<W3FocusAreaTrigger> LinkedFocusArea { get; set;}

		[RED("dimmingStarted")] 		public CBool DimmingStarted { get; set;}

		[RED("focusModeController")] 		public CHandle<CFocusModeController> FocusModeController { get; set;}

		[RED("INTERACTION_COMPONENT_NAME")] 		public CString INTERACTION_COMPONENT_NAME { get; set;}

		public W3MonsterClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MonsterClue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}