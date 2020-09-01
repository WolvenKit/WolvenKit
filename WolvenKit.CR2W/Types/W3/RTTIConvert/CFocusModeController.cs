using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFocusModeController : IGameSystem
	{
		[Ordinal(0)] [RED("("detectedCluesTags", 2,0)] 		public CArray<CName> DetectedCluesTags { get; set;}

		[Ordinal(0)] [RED("("medallionIntensity")] 		public CHandle<W3FocusModeEffectIntensity> MedallionIntensity { get; set;}

		[Ordinal(0)] [RED("("dimmingClue")] 		public CHandle<W3MonsterClue> DimmingClue { get; set;}

		[Ordinal(0)] [RED("("blockVibrations")] 		public CBool BlockVibrations { get; set;}

		[Ordinal(0)] [RED("("focusAreaIntensity")] 		public CFloat FocusAreaIntensity { get; set;}

		[Ordinal(0)] [RED("("effectFadeTime")] 		public CFloat EffectFadeTime { get; set;}

		[Ordinal(0)] [RED("("controllerVibrationFactor")] 		public CFloat ControllerVibrationFactor { get; set;}

		[Ordinal(0)] [RED("("controllerVibrationDuration")] 		public CFloat ControllerVibrationDuration { get; set;}

		[Ordinal(0)] [RED("("activationSoundTimer")] 		public CFloat ActivationSoundTimer { get; set;}

		[Ordinal(0)] [RED("("activationSoundInterval")] 		public CFloat ActivationSoundInterval { get; set;}

		[Ordinal(0)] [RED("("fastFocusTimer")] 		public CFloat FastFocusTimer { get; set;}

		[Ordinal(0)] [RED("("activateAfterFastFocus")] 		public CBool ActivateAfterFastFocus { get; set;}

		[Ordinal(0)] [RED("("fastFocusDuration")] 		public CFloat FastFocusDuration { get; set;}

		[Ordinal(0)] [RED("("isUnderwaterFocus")] 		public CBool IsUnderwaterFocus { get; set;}

		[Ordinal(0)] [RED("("isInCombat")] 		public CBool IsInCombat { get; set;}

		[Ordinal(0)] [RED("("isNight")] 		public CBool IsNight { get; set;}

		[Ordinal(0)] [RED("("lastDarkPlaceCheck")] 		public CFloat LastDarkPlaceCheck { get; set;}

		[Ordinal(0)] [RED("("DARK_PLACE_CHECK_INTERVAL")] 		public CFloat DARK_PLACE_CHECK_INTERVAL { get; set;}

		[Ordinal(0)] [RED("("focusInteractionsInterval")] 		public CFloat FocusInteractionsInterval { get; set;}

		public CFocusModeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFocusModeController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}