using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGlobalLightParameters : CVariable
	{
		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("activatedGlobalLightActivated")] 		public CBool ActivatedGlobalLightActivated { get; set;}

		[RED("globalLightActivated")] 		public CFloat GlobalLightActivated { get; set;}

		[RED("activatedActivatedFactorLightDir")] 		public CBool ActivatedActivatedFactorLightDir { get; set;}

		[RED("activatedFactorLightDir")] 		public CFloat ActivatedFactorLightDir { get; set;}

		[RED("sunColor")] 		public SSimpleCurve SunColor { get; set;}

		[RED("sunColorLightSide")] 		public SSimpleCurve SunColorLightSide { get; set;}

		[RED("sunColorLightOppositeSide")] 		public SSimpleCurve SunColorLightOppositeSide { get; set;}

		[RED("sunColorCenterArea")] 		public SSimpleCurve SunColorCenterArea { get; set;}

		[RED("sunColorSidesMargin")] 		public SSimpleCurve SunColorSidesMargin { get; set;}

		[RED("sunColorBottomHeight")] 		public SSimpleCurve SunColorBottomHeight { get; set;}

		[RED("sunColorTopHeight")] 		public SSimpleCurve SunColorTopHeight { get; set;}

		[RED("forcedLightDirAnglesYaw")] 		public SSimpleCurve ForcedLightDirAnglesYaw { get; set;}

		[RED("forcedLightDirAnglesPitch")] 		public SSimpleCurve ForcedLightDirAnglesPitch { get; set;}

		[RED("forcedLightDirAnglesRoll")] 		public SSimpleCurve ForcedLightDirAnglesRoll { get; set;}

		[RED("forcedSunDirAnglesYaw")] 		public SSimpleCurve ForcedSunDirAnglesYaw { get; set;}

		[RED("forcedSunDirAnglesPitch")] 		public SSimpleCurve ForcedSunDirAnglesPitch { get; set;}

		[RED("forcedSunDirAnglesRoll")] 		public SSimpleCurve ForcedSunDirAnglesRoll { get; set;}

		[RED("forcedMoonDirAnglesYaw")] 		public SSimpleCurve ForcedMoonDirAnglesYaw { get; set;}

		[RED("forcedMoonDirAnglesPitch")] 		public SSimpleCurve ForcedMoonDirAnglesPitch { get; set;}

		[RED("forcedMoonDirAnglesRoll")] 		public SSimpleCurve ForcedMoonDirAnglesRoll { get; set;}

		[RED("translucencyViewDependency")] 		public SSimpleCurve TranslucencyViewDependency { get; set;}

		[RED("translucencyBaseFlatness")] 		public SSimpleCurve TranslucencyBaseFlatness { get; set;}

		[RED("translucencyFlatBrightness")] 		public SSimpleCurve TranslucencyFlatBrightness { get; set;}

		[RED("translucencyGainBrightness")] 		public SSimpleCurve TranslucencyGainBrightness { get; set;}

		[RED("translucencyFresnelScaleLight")] 		public SSimpleCurve TranslucencyFresnelScaleLight { get; set;}

		[RED("translucencyFresnelScaleReflection")] 		public SSimpleCurve TranslucencyFresnelScaleReflection { get; set;}

		[RED("envProbeBaseLightingAmbient")] 		public CEnvAmbientProbesGenParameters EnvProbeBaseLightingAmbient { get; set;}

		[RED("envProbeBaseLightingReflection")] 		public CEnvReflectionProbesGenParameters EnvProbeBaseLightingReflection { get; set;}

		[RED("charactersLightingBoostAmbientLight")] 		public SSimpleCurve CharactersLightingBoostAmbientLight { get; set;}

		[RED("charactersLightingBoostAmbientShadow")] 		public SSimpleCurve CharactersLightingBoostAmbientShadow { get; set;}

		[RED("charactersLightingBoostReflectionLight")] 		public SSimpleCurve CharactersLightingBoostReflectionLight { get; set;}

		[RED("charactersLightingBoostReflectionShadow")] 		public SSimpleCurve CharactersLightingBoostReflectionShadow { get; set;}

		[RED("charactersEyeBlicksColor")] 		public SSimpleCurve CharactersEyeBlicksColor { get; set;}

		[RED("charactersEyeBlicksShadowedScale")] 		public SSimpleCurve CharactersEyeBlicksShadowedScale { get; set;}

		[RED("envProbeAmbientScaleLight")] 		public SSimpleCurve EnvProbeAmbientScaleLight { get; set;}

		[RED("envProbeAmbientScaleShadow")] 		public SSimpleCurve EnvProbeAmbientScaleShadow { get; set;}

		[RED("envProbeReflectionScaleLight")] 		public SSimpleCurve EnvProbeReflectionScaleLight { get; set;}

		[RED("envProbeReflectionScaleShadow")] 		public SSimpleCurve EnvProbeReflectionScaleShadow { get; set;}

		[RED("envProbeDistantScaleFactor")] 		public SSimpleCurve EnvProbeDistantScaleFactor { get; set;}

		public CEnvGlobalLightParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CEnvGlobalLightParameters(cr2w);

	}
}