using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGlobalLightParameters : CVariable
	{
		[Ordinal(0)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("activatedGlobalLightActivated")] 		public CBool ActivatedGlobalLightActivated { get; set;}

		[Ordinal(0)] [RED("globalLightActivated")] 		public CFloat GlobalLightActivated { get; set;}

		[Ordinal(0)] [RED("activatedActivatedFactorLightDir")] 		public CBool ActivatedActivatedFactorLightDir { get; set;}

		[Ordinal(0)] [RED("activatedFactorLightDir")] 		public CFloat ActivatedFactorLightDir { get; set;}

		[Ordinal(0)] [RED("sunColor")] 		public SSimpleCurve SunColor { get; set;}

		[Ordinal(0)] [RED("sunColorLightSide")] 		public SSimpleCurve SunColorLightSide { get; set;}

		[Ordinal(0)] [RED("sunColorLightOppositeSide")] 		public SSimpleCurve SunColorLightOppositeSide { get; set;}

		[Ordinal(0)] [RED("sunColorCenterArea")] 		public SSimpleCurve SunColorCenterArea { get; set;}

		[Ordinal(0)] [RED("sunColorSidesMargin")] 		public SSimpleCurve SunColorSidesMargin { get; set;}

		[Ordinal(0)] [RED("sunColorBottomHeight")] 		public SSimpleCurve SunColorBottomHeight { get; set;}

		[Ordinal(0)] [RED("sunColorTopHeight")] 		public SSimpleCurve SunColorTopHeight { get; set;}

		[Ordinal(0)] [RED("forcedLightDirAnglesYaw")] 		public SSimpleCurve ForcedLightDirAnglesYaw { get; set;}

		[Ordinal(0)] [RED("forcedLightDirAnglesPitch")] 		public SSimpleCurve ForcedLightDirAnglesPitch { get; set;}

		[Ordinal(0)] [RED("forcedLightDirAnglesRoll")] 		public SSimpleCurve ForcedLightDirAnglesRoll { get; set;}

		[Ordinal(0)] [RED("forcedSunDirAnglesYaw")] 		public SSimpleCurve ForcedSunDirAnglesYaw { get; set;}

		[Ordinal(0)] [RED("forcedSunDirAnglesPitch")] 		public SSimpleCurve ForcedSunDirAnglesPitch { get; set;}

		[Ordinal(0)] [RED("forcedSunDirAnglesRoll")] 		public SSimpleCurve ForcedSunDirAnglesRoll { get; set;}

		[Ordinal(0)] [RED("forcedMoonDirAnglesYaw")] 		public SSimpleCurve ForcedMoonDirAnglesYaw { get; set;}

		[Ordinal(0)] [RED("forcedMoonDirAnglesPitch")] 		public SSimpleCurve ForcedMoonDirAnglesPitch { get; set;}

		[Ordinal(0)] [RED("forcedMoonDirAnglesRoll")] 		public SSimpleCurve ForcedMoonDirAnglesRoll { get; set;}

		[Ordinal(0)] [RED("translucencyViewDependency")] 		public SSimpleCurve TranslucencyViewDependency { get; set;}

		[Ordinal(0)] [RED("translucencyBaseFlatness")] 		public SSimpleCurve TranslucencyBaseFlatness { get; set;}

		[Ordinal(0)] [RED("translucencyFlatBrightness")] 		public SSimpleCurve TranslucencyFlatBrightness { get; set;}

		[Ordinal(0)] [RED("translucencyGainBrightness")] 		public SSimpleCurve TranslucencyGainBrightness { get; set;}

		[Ordinal(0)] [RED("translucencyFresnelScaleLight")] 		public SSimpleCurve TranslucencyFresnelScaleLight { get; set;}

		[Ordinal(0)] [RED("translucencyFresnelScaleReflection")] 		public SSimpleCurve TranslucencyFresnelScaleReflection { get; set;}

		[Ordinal(0)] [RED("envProbeBaseLightingAmbient")] 		public CEnvAmbientProbesGenParameters EnvProbeBaseLightingAmbient { get; set;}

		[Ordinal(0)] [RED("envProbeBaseLightingReflection")] 		public CEnvReflectionProbesGenParameters EnvProbeBaseLightingReflection { get; set;}

		[Ordinal(0)] [RED("charactersLightingBoostAmbientLight")] 		public SSimpleCurve CharactersLightingBoostAmbientLight { get; set;}

		[Ordinal(0)] [RED("charactersLightingBoostAmbientShadow")] 		public SSimpleCurve CharactersLightingBoostAmbientShadow { get; set;}

		[Ordinal(0)] [RED("charactersLightingBoostReflectionLight")] 		public SSimpleCurve CharactersLightingBoostReflectionLight { get; set;}

		[Ordinal(0)] [RED("charactersLightingBoostReflectionShadow")] 		public SSimpleCurve CharactersLightingBoostReflectionShadow { get; set;}

		[Ordinal(0)] [RED("charactersEyeBlicksColor")] 		public SSimpleCurve CharactersEyeBlicksColor { get; set;}

		[Ordinal(0)] [RED("charactersEyeBlicksShadowedScale")] 		public SSimpleCurve CharactersEyeBlicksShadowedScale { get; set;}

		[Ordinal(0)] [RED("envProbeAmbientScaleLight")] 		public SSimpleCurve EnvProbeAmbientScaleLight { get; set;}

		[Ordinal(0)] [RED("envProbeAmbientScaleShadow")] 		public SSimpleCurve EnvProbeAmbientScaleShadow { get; set;}

		[Ordinal(0)] [RED("envProbeReflectionScaleLight")] 		public SSimpleCurve EnvProbeReflectionScaleLight { get; set;}

		[Ordinal(0)] [RED("envProbeReflectionScaleShadow")] 		public SSimpleCurve EnvProbeReflectionScaleShadow { get; set;}

		[Ordinal(0)] [RED("envProbeDistantScaleFactor")] 		public SSimpleCurve EnvProbeDistantScaleFactor { get; set;}

		public CEnvGlobalLightParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGlobalLightParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}