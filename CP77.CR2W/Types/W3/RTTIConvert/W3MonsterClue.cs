using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3MonsterClue : W3AnimationInteractionEntity
	{
		[Ordinal(1)] [RED("isAvailable")] 		public CBool IsAvailable { get; set;}

		[Ordinal(2)] [RED("isInteractive")] 		public CBool IsInteractive { get; set;}

		[Ordinal(3)] [RED("isReusable")] 		public CBool IsReusable { get; set;}

		[Ordinal(4)] [RED("isVisible")] 		public CBool IsVisible { get; set;}

		[Ordinal(5)] [RED("isIgnoringFM")] 		public CBool IsIgnoringFM { get; set;}

		[Ordinal(6)] [RED("playerVoiceset")] 		public CEnum<EPlayerVoicesetType> PlayerVoiceset { get; set;}

		[Ordinal(7)] [RED("clueEntries", 2,0)] 		public CArray<CString> ClueEntries { get; set;}

		[Ordinal(8)] [RED("maxDetectionDistance")] 		public CFloat MaxDetectionDistance { get; set;}

		[Ordinal(9)] [RED("testLineOfSight")] 		public CBool TestLineOfSight { get; set;}

		[Ordinal(10)] [RED("medallionVibration")] 		public CBool MedallionVibration { get; set;}

		[Ordinal(11)] [RED("medallionVibrationDistance")] 		public CFloat MedallionVibrationDistance { get; set;}

		[Ordinal(12)] [RED("medallionVibrationBehavior")] 		public CEnum<EFocusClueMedallionReaction> MedallionVibrationBehavior { get; set;}

		[Ordinal(13)] [RED("medallionVibratedEver")] 		public CBool MedallionVibratedEver { get; set;}

		[Ordinal(14)] [RED("medallionVibratedInSession")] 		public CBool MedallionVibratedInSession { get; set;}

		[Ordinal(15)] [RED("accuracyTreshold")] 		public CFloat AccuracyTreshold { get; set;}

		[Ordinal(16)] [RED("eventOnDetected", 2,0)] 		public CArray<CHandle<IPerformableAction>> EventOnDetected { get; set;}

		[Ordinal(17)] [RED("detectionDelay")] 		public CFloat DetectionDelay { get; set;}

		[Ordinal(18)] [RED("wasDetected")] 		public CBool WasDetected { get; set;}

		[Ordinal(19)] [RED("wasSeen")] 		public CBool WasSeen { get; set;}

		[Ordinal(20)] [RED("isVisibleAsClue")] 		public CBool IsVisibleAsClue { get; set;}

		[Ordinal(21)] [RED("linkedFocusArea")] 		public CHandle<W3FocusAreaTrigger> LinkedFocusArea { get; set;}

		[Ordinal(22)] [RED("dimmingStarted")] 		public CBool DimmingStarted { get; set;}

		[Ordinal(23)] [RED("focusModeController")] 		public CHandle<CFocusModeController> FocusModeController { get; set;}

		[Ordinal(24)] [RED("INTERACTION_COMPONENT_NAME")] 		public CString INTERACTION_COMPONENT_NAME { get; set;}

		public W3MonsterClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3MonsterClue(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}