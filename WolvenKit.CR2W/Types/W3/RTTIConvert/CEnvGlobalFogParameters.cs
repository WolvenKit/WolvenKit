using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGlobalFogParameters : CVariable
	{
		[Ordinal(0)] [RED("fogActivated")] 		public CBool FogActivated { get; set;}

		[Ordinal(0)] [RED("fogAppearDistance")] 		public SSimpleCurve FogAppearDistance { get; set;}

		[Ordinal(0)] [RED("fogAppearRange")] 		public SSimpleCurve FogAppearRange { get; set;}

		[Ordinal(0)] [RED("fogColorFront")] 		public SSimpleCurve FogColorFront { get; set;}

		[Ordinal(0)] [RED("fogColorMiddle")] 		public SSimpleCurve FogColorMiddle { get; set;}

		[Ordinal(0)] [RED("fogColorBack")] 		public SSimpleCurve FogColorBack { get; set;}

		[Ordinal(0)] [RED("fogDensity")] 		public SSimpleCurve FogDensity { get; set;}

		[Ordinal(0)] [RED("fogFinalExp")] 		public SSimpleCurve FogFinalExp { get; set;}

		[Ordinal(0)] [RED("fogDistClamp")] 		public SSimpleCurve FogDistClamp { get; set;}

		[Ordinal(0)] [RED("fogVertOffset")] 		public SSimpleCurve FogVertOffset { get; set;}

		[Ordinal(0)] [RED("fogVertDensity")] 		public SSimpleCurve FogVertDensity { get; set;}

		[Ordinal(0)] [RED("fogVertDensityLightFront")] 		public SSimpleCurve FogVertDensityLightFront { get; set;}

		[Ordinal(0)] [RED("fogVertDensityLightBack")] 		public SSimpleCurve FogVertDensityLightBack { get; set;}

		[Ordinal(0)] [RED("fogSkyDensityScale")] 		public SSimpleCurve FogSkyDensityScale { get; set;}

		[Ordinal(0)] [RED("fogCloudsDensityScale")] 		public SSimpleCurve FogCloudsDensityScale { get; set;}

		[Ordinal(0)] [RED("fogSkyVertDensityLightFrontScale")] 		public SSimpleCurve FogSkyVertDensityLightFrontScale { get; set;}

		[Ordinal(0)] [RED("fogSkyVertDensityLightBackScale")] 		public SSimpleCurve FogSkyVertDensityLightBackScale { get; set;}

		[Ordinal(0)] [RED("fogVertDensityRimRange")] 		public SSimpleCurve FogVertDensityRimRange { get; set;}

		[Ordinal(0)] [RED("fogCustomColor")] 		public SSimpleCurve FogCustomColor { get; set;}

		[Ordinal(0)] [RED("fogCustomColorStart")] 		public SSimpleCurve FogCustomColorStart { get; set;}

		[Ordinal(0)] [RED("fogCustomColorRange")] 		public SSimpleCurve FogCustomColorRange { get; set;}

		[Ordinal(0)] [RED("fogCustomAmountScale")] 		public SSimpleCurve FogCustomAmountScale { get; set;}

		[Ordinal(0)] [RED("fogCustomAmountScaleStart")] 		public SSimpleCurve FogCustomAmountScaleStart { get; set;}

		[Ordinal(0)] [RED("fogCustomAmountScaleRange")] 		public SSimpleCurve FogCustomAmountScaleRange { get; set;}

		[Ordinal(0)] [RED("aerialColorFront")] 		public SSimpleCurve AerialColorFront { get; set;}

		[Ordinal(0)] [RED("aerialColorMiddle")] 		public SSimpleCurve AerialColorMiddle { get; set;}

		[Ordinal(0)] [RED("aerialColorBack")] 		public SSimpleCurve AerialColorBack { get; set;}

		[Ordinal(0)] [RED("aerialFinalExp")] 		public SSimpleCurve AerialFinalExp { get; set;}

		[Ordinal(0)] [RED("ssaoImpactClamp")] 		public SSimpleCurve SsaoImpactClamp { get; set;}

		[Ordinal(0)] [RED("ssaoImpactNearValue")] 		public SSimpleCurve SsaoImpactNearValue { get; set;}

		[Ordinal(0)] [RED("ssaoImpactFarValue")] 		public SSimpleCurve SsaoImpactFarValue { get; set;}

		[Ordinal(0)] [RED("ssaoImpactNearDistance")] 		public SSimpleCurve SsaoImpactNearDistance { get; set;}

		[Ordinal(0)] [RED("ssaoImpactFarDistance")] 		public SSimpleCurve SsaoImpactFarDistance { get; set;}

		[Ordinal(0)] [RED("distantLightsIntensityScale")] 		public SSimpleCurve DistantLightsIntensityScale { get; set;}

		public CEnvGlobalFogParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGlobalFogParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}