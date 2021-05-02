using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFocusModeController : IGameSystem
	{
		[Ordinal(1)] [RED("detectedCluesTags", 2,0)] 		public CArray<CName> DetectedCluesTags { get; set;}

		[Ordinal(2)] [RED("medallionIntensity")] 		public CHandle<W3FocusModeEffectIntensity> MedallionIntensity { get; set;}

		[Ordinal(3)] [RED("dimmingClue")] 		public CHandle<W3MonsterClue> DimmingClue { get; set;}

		[Ordinal(4)] [RED("blockVibrations")] 		public CBool BlockVibrations { get; set;}

		[Ordinal(5)] [RED("focusAreaIntensity")] 		public CFloat FocusAreaIntensity { get; set;}

		[Ordinal(6)] [RED("effectFadeTime")] 		public CFloat EffectFadeTime { get; set;}

		[Ordinal(7)] [RED("controllerVibrationFactor")] 		public CFloat ControllerVibrationFactor { get; set;}

		[Ordinal(8)] [RED("controllerVibrationDuration")] 		public CFloat ControllerVibrationDuration { get; set;}

		[Ordinal(9)] [RED("activationSoundTimer")] 		public CFloat ActivationSoundTimer { get; set;}

		[Ordinal(10)] [RED("activationSoundInterval")] 		public CFloat ActivationSoundInterval { get; set;}

		[Ordinal(11)] [RED("fastFocusTimer")] 		public CFloat FastFocusTimer { get; set;}

		[Ordinal(12)] [RED("activateAfterFastFocus")] 		public CBool ActivateAfterFastFocus { get; set;}

		[Ordinal(13)] [RED("fastFocusDuration")] 		public CFloat FastFocusDuration { get; set;}

		[Ordinal(14)] [RED("isUnderwaterFocus")] 		public CBool IsUnderwaterFocus { get; set;}

		[Ordinal(15)] [RED("isInCombat")] 		public CBool IsInCombat { get; set;}

		[Ordinal(16)] [RED("isNight")] 		public CBool IsNight { get; set;}

		[Ordinal(17)] [RED("lastDarkPlaceCheck")] 		public CFloat LastDarkPlaceCheck { get; set;}

		[Ordinal(18)] [RED("DARK_PLACE_CHECK_INTERVAL")] 		public CFloat DARK_PLACE_CHECK_INTERVAL { get; set;}

		[Ordinal(19)] [RED("focusInteractionsInterval")] 		public CFloat FocusInteractionsInterval { get; set;}

		public CFocusModeController(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFocusModeController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}