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
		[RED("detectedCluesTags", 2,0)] 		public CArray<CName> DetectedCluesTags { get; set;}

		[RED("medallionIntensity")] 		public CHandle<W3FocusModeEffectIntensity> MedallionIntensity { get; set;}

		[RED("dimmingClue")] 		public CHandle<W3MonsterClue> DimmingClue { get; set;}

		[RED("blockVibrations")] 		public CBool BlockVibrations { get; set;}

		[RED("focusAreaIntensity")] 		public CFloat FocusAreaIntensity { get; set;}

		[RED("effectFadeTime")] 		public CFloat EffectFadeTime { get; set;}

		[RED("controllerVibrationFactor")] 		public CFloat ControllerVibrationFactor { get; set;}

		[RED("controllerVibrationDuration")] 		public CFloat ControllerVibrationDuration { get; set;}

		[RED("activationSoundTimer")] 		public CFloat ActivationSoundTimer { get; set;}

		[RED("activationSoundInterval")] 		public CFloat ActivationSoundInterval { get; set;}

		[RED("fastFocusTimer")] 		public CFloat FastFocusTimer { get; set;}

		[RED("activateAfterFastFocus")] 		public CBool ActivateAfterFastFocus { get; set;}

		[RED("fastFocusDuration")] 		public CFloat FastFocusDuration { get; set;}

		[RED("isUnderwaterFocus")] 		public CBool IsUnderwaterFocus { get; set;}

		[RED("isInCombat")] 		public CBool IsInCombat { get; set;}

		[RED("isNight")] 		public CBool IsNight { get; set;}

		[RED("lastDarkPlaceCheck")] 		public CFloat LastDarkPlaceCheck { get; set;}

		[RED("DARK_PLACE_CHECK_INTERVAL")] 		public CFloat DARK_PLACE_CHECK_INTERVAL { get; set;}

		[RED("focusInteractionsInterval")] 		public CFloat FocusInteractionsInterval { get; set;}

		public CFocusModeController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFocusModeController(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}