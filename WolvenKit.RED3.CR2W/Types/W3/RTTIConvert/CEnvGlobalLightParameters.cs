using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGlobalLightParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("activatedGlobalLightActivated")] 		public CBool ActivatedGlobalLightActivated { get; set;}

		[Ordinal(3)] [RED("globalLightActivated")] 		public CFloat GlobalLightActivated { get; set;}

		[Ordinal(4)] [RED("activatedActivatedFactorLightDir")] 		public CBool ActivatedActivatedFactorLightDir { get; set;}

		[Ordinal(5)] [RED("activatedFactorLightDir")] 		public CFloat ActivatedFactorLightDir { get; set;}

		[Ordinal(6)] [RED("sunColor")] 		public SSimpleCurve SunColor { get; set;}

		[Ordinal(7)] [RED("sunColorLightSide")] 		public SSimpleCurve SunColorLightSide { get; set;}

		[Ordinal(8)] [RED("sunColorLightOppositeSide")] 		public SSimpleCurve SunColorLightOppositeSide { get; set;}

		[Ordinal(9)] [RED("sunColorCenterArea")] 		public SSimpleCurve SunColorCenterArea { get; set;}

		[Ordinal(10)] [RED("sunColorSidesMargin")] 		public SSimpleCurve SunColorSidesMargin { get; set;}

		[Ordinal(11)] [RED("sunColorBottomHeight")] 		public SSimpleCurve SunColorBottomHeight { get; set;}

		[Ordinal(12)] [RED("sunColorTopHeight")] 		public SSimpleCurve SunColorTopHeight { get; set;}

		[Ordinal(13)] [RED("forcedLightDirAnglesYaw")] 		public SSimpleCurve ForcedLightDirAnglesYaw { get; set;}

		[Ordinal(14)] [RED("forcedLightDirAnglesPitch")] 		public SSimpleCurve ForcedLightDirAnglesPitch { get; set;}

		[Ordinal(15)] [RED("forcedLightDirAnglesRoll")] 		public SSimpleCurve ForcedLightDirAnglesRoll { get; set;}

		[Ordinal(16)] [RED("forcedSunDirAnglesYaw")] 		public SSimpleCurve ForcedSunDirAnglesYaw { get; set;}

		[Ordinal(17)] [RED("forcedSunDirAnglesPitch")] 		public SSimpleCurve ForcedSunDirAnglesPitch { get; set;}

		[Ordinal(18)] [RED("forcedSunDirAnglesRoll")] 		public SSimpleCurve ForcedSunDirAnglesRoll { get; set;}

		[Ordinal(19)] [RED("forcedMoonDirAnglesYaw")] 		public SSimpleCurve ForcedMoonDirAnglesYaw { get; set;}

		[Ordinal(20)] [RED("forcedMoonDirAnglesPitch")] 		public SSimpleCurve ForcedMoonDirAnglesPitch { get; set;}

		[Ordinal(21)] [RED("forcedMoonDirAnglesRoll")] 		public SSimpleCurve ForcedMoonDirAnglesRoll { get; set;}

		[Ordinal(22)] [RED("translucencyViewDependency")] 		public SSimpleCurve TranslucencyViewDependency { get; set;}

		[Ordinal(23)] [RED("translucencyBaseFlatness")] 		public SSimpleCurve TranslucencyBaseFlatness { get; set;}

		[Ordinal(24)] [RED("translucencyFlatBrightness")] 		public SSimpleCurve TranslucencyFlatBrightness { get; set;}

		[Ordinal(25)] [RED("translucencyGainBrightness")] 		public SSimpleCurve TranslucencyGainBrightness { get; set;}

		[Ordinal(26)] [RED("translucencyFresnelScaleLight")] 		public SSimpleCurve TranslucencyFresnelScaleLight { get; set;}

		[Ordinal(27)] [RED("translucencyFresnelScaleReflection")] 		public SSimpleCurve TranslucencyFresnelScaleReflection { get; set;}

		[Ordinal(28)] [RED("envProbeBaseLightingAmbient")] 		public CEnvAmbientProbesGenParameters EnvProbeBaseLightingAmbient { get; set;}

		[Ordinal(29)] [RED("envProbeBaseLightingReflection")] 		public CEnvReflectionProbesGenParameters EnvProbeBaseLightingReflection { get; set;}

		[Ordinal(30)] [RED("charactersLightingBoostAmbientLight")] 		public SSimpleCurve CharactersLightingBoostAmbientLight { get; set;}

		[Ordinal(31)] [RED("charactersLightingBoostAmbientShadow")] 		public SSimpleCurve CharactersLightingBoostAmbientShadow { get; set;}

		[Ordinal(32)] [RED("charactersLightingBoostReflectionLight")] 		public SSimpleCurve CharactersLightingBoostReflectionLight { get; set;}

		[Ordinal(33)] [RED("charactersLightingBoostReflectionShadow")] 		public SSimpleCurve CharactersLightingBoostReflectionShadow { get; set;}

		[Ordinal(34)] [RED("charactersEyeBlicksColor")] 		public SSimpleCurve CharactersEyeBlicksColor { get; set;}

		[Ordinal(35)] [RED("charactersEyeBlicksShadowedScale")] 		public SSimpleCurve CharactersEyeBlicksShadowedScale { get; set;}

		[Ordinal(36)] [RED("envProbeAmbientScaleLight")] 		public SSimpleCurve EnvProbeAmbientScaleLight { get; set;}

		[Ordinal(37)] [RED("envProbeAmbientScaleShadow")] 		public SSimpleCurve EnvProbeAmbientScaleShadow { get; set;}

		[Ordinal(38)] [RED("envProbeReflectionScaleLight")] 		public SSimpleCurve EnvProbeReflectionScaleLight { get; set;}

		[Ordinal(39)] [RED("envProbeReflectionScaleShadow")] 		public SSimpleCurve EnvProbeReflectionScaleShadow { get; set;}

		[Ordinal(40)] [RED("envProbeDistantScaleFactor")] 		public SSimpleCurve EnvProbeDistantScaleFactor { get; set;}

		public CEnvGlobalLightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGlobalLightParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}