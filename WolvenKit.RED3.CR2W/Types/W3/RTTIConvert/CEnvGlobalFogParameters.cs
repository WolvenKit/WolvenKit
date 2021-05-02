using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvGlobalFogParameters : CVariable
	{
		[Ordinal(1)] [RED("fogActivated")] 		public CBool FogActivated { get; set;}

		[Ordinal(2)] [RED("fogAppearDistance")] 		public SSimpleCurve FogAppearDistance { get; set;}

		[Ordinal(3)] [RED("fogAppearRange")] 		public SSimpleCurve FogAppearRange { get; set;}

		[Ordinal(4)] [RED("fogColorFront")] 		public SSimpleCurve FogColorFront { get; set;}

		[Ordinal(5)] [RED("fogColorMiddle")] 		public SSimpleCurve FogColorMiddle { get; set;}

		[Ordinal(6)] [RED("fogColorBack")] 		public SSimpleCurve FogColorBack { get; set;}

		[Ordinal(7)] [RED("fogDensity")] 		public SSimpleCurve FogDensity { get; set;}

		[Ordinal(8)] [RED("fogFinalExp")] 		public SSimpleCurve FogFinalExp { get; set;}

		[Ordinal(9)] [RED("fogDistClamp")] 		public SSimpleCurve FogDistClamp { get; set;}

		[Ordinal(10)] [RED("fogVertOffset")] 		public SSimpleCurve FogVertOffset { get; set;}

		[Ordinal(11)] [RED("fogVertDensity")] 		public SSimpleCurve FogVertDensity { get; set;}

		[Ordinal(12)] [RED("fogVertDensityLightFront")] 		public SSimpleCurve FogVertDensityLightFront { get; set;}

		[Ordinal(13)] [RED("fogVertDensityLightBack")] 		public SSimpleCurve FogVertDensityLightBack { get; set;}

		[Ordinal(14)] [RED("fogSkyDensityScale")] 		public SSimpleCurve FogSkyDensityScale { get; set;}

		[Ordinal(15)] [RED("fogCloudsDensityScale")] 		public SSimpleCurve FogCloudsDensityScale { get; set;}

		[Ordinal(16)] [RED("fogSkyVertDensityLightFrontScale")] 		public SSimpleCurve FogSkyVertDensityLightFrontScale { get; set;}

		[Ordinal(17)] [RED("fogSkyVertDensityLightBackScale")] 		public SSimpleCurve FogSkyVertDensityLightBackScale { get; set;}

		[Ordinal(18)] [RED("fogVertDensityRimRange")] 		public SSimpleCurve FogVertDensityRimRange { get; set;}

		[Ordinal(19)] [RED("fogCustomColor")] 		public SSimpleCurve FogCustomColor { get; set;}

		[Ordinal(20)] [RED("fogCustomColorStart")] 		public SSimpleCurve FogCustomColorStart { get; set;}

		[Ordinal(21)] [RED("fogCustomColorRange")] 		public SSimpleCurve FogCustomColorRange { get; set;}

		[Ordinal(22)] [RED("fogCustomAmountScale")] 		public SSimpleCurve FogCustomAmountScale { get; set;}

		[Ordinal(23)] [RED("fogCustomAmountScaleStart")] 		public SSimpleCurve FogCustomAmountScaleStart { get; set;}

		[Ordinal(24)] [RED("fogCustomAmountScaleRange")] 		public SSimpleCurve FogCustomAmountScaleRange { get; set;}

		[Ordinal(25)] [RED("aerialColorFront")] 		public SSimpleCurve AerialColorFront { get; set;}

		[Ordinal(26)] [RED("aerialColorMiddle")] 		public SSimpleCurve AerialColorMiddle { get; set;}

		[Ordinal(27)] [RED("aerialColorBack")] 		public SSimpleCurve AerialColorBack { get; set;}

		[Ordinal(28)] [RED("aerialFinalExp")] 		public SSimpleCurve AerialFinalExp { get; set;}

		[Ordinal(29)] [RED("ssaoImpactClamp")] 		public SSimpleCurve SsaoImpactClamp { get; set;}

		[Ordinal(30)] [RED("ssaoImpactNearValue")] 		public SSimpleCurve SsaoImpactNearValue { get; set;}

		[Ordinal(31)] [RED("ssaoImpactFarValue")] 		public SSimpleCurve SsaoImpactFarValue { get; set;}

		[Ordinal(32)] [RED("ssaoImpactNearDistance")] 		public SSimpleCurve SsaoImpactNearDistance { get; set;}

		[Ordinal(33)] [RED("ssaoImpactFarDistance")] 		public SSimpleCurve SsaoImpactFarDistance { get; set;}

		[Ordinal(34)] [RED("distantLightsIntensityScale")] 		public SSimpleCurve DistantLightsIntensityScale { get; set;}

		public CEnvGlobalFogParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGlobalFogParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}