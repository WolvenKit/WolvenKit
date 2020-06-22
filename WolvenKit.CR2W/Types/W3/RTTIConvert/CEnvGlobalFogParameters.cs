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
		[RED("fogActivated")] 		public CBool FogActivated { get; set;}

		[RED("fogAppearDistance")] 		public SSimpleCurve FogAppearDistance { get; set;}

		[RED("fogAppearRange")] 		public SSimpleCurve FogAppearRange { get; set;}

		[RED("fogColorFront")] 		public SSimpleCurve FogColorFront { get; set;}

		[RED("fogColorMiddle")] 		public SSimpleCurve FogColorMiddle { get; set;}

		[RED("fogColorBack")] 		public SSimpleCurve FogColorBack { get; set;}

		[RED("fogDensity")] 		public SSimpleCurve FogDensity { get; set;}

		[RED("fogFinalExp")] 		public SSimpleCurve FogFinalExp { get; set;}

		[RED("fogDistClamp")] 		public SSimpleCurve FogDistClamp { get; set;}

		[RED("fogVertOffset")] 		public SSimpleCurve FogVertOffset { get; set;}

		[RED("fogVertDensity")] 		public SSimpleCurve FogVertDensity { get; set;}

		[RED("fogVertDensityLightFront")] 		public SSimpleCurve FogVertDensityLightFront { get; set;}

		[RED("fogVertDensityLightBack")] 		public SSimpleCurve FogVertDensityLightBack { get; set;}

		[RED("fogSkyDensityScale")] 		public SSimpleCurve FogSkyDensityScale { get; set;}

		[RED("fogCloudsDensityScale")] 		public SSimpleCurve FogCloudsDensityScale { get; set;}

		[RED("fogSkyVertDensityLightFrontScale")] 		public SSimpleCurve FogSkyVertDensityLightFrontScale { get; set;}

		[RED("fogSkyVertDensityLightBackScale")] 		public SSimpleCurve FogSkyVertDensityLightBackScale { get; set;}

		[RED("fogVertDensityRimRange")] 		public SSimpleCurve FogVertDensityRimRange { get; set;}

		[RED("fogCustomColor")] 		public SSimpleCurve FogCustomColor { get; set;}

		[RED("fogCustomColorStart")] 		public SSimpleCurve FogCustomColorStart { get; set;}

		[RED("fogCustomColorRange")] 		public SSimpleCurve FogCustomColorRange { get; set;}

		[RED("fogCustomAmountScale")] 		public SSimpleCurve FogCustomAmountScale { get; set;}

		[RED("fogCustomAmountScaleStart")] 		public SSimpleCurve FogCustomAmountScaleStart { get; set;}

		[RED("fogCustomAmountScaleRange")] 		public SSimpleCurve FogCustomAmountScaleRange { get; set;}

		[RED("aerialColorFront")] 		public SSimpleCurve AerialColorFront { get; set;}

		[RED("aerialColorMiddle")] 		public SSimpleCurve AerialColorMiddle { get; set;}

		[RED("aerialColorBack")] 		public SSimpleCurve AerialColorBack { get; set;}

		[RED("aerialFinalExp")] 		public SSimpleCurve AerialFinalExp { get; set;}

		[RED("ssaoImpactClamp")] 		public SSimpleCurve SsaoImpactClamp { get; set;}

		[RED("ssaoImpactNearValue")] 		public SSimpleCurve SsaoImpactNearValue { get; set;}

		[RED("ssaoImpactFarValue")] 		public SSimpleCurve SsaoImpactFarValue { get; set;}

		[RED("ssaoImpactNearDistance")] 		public SSimpleCurve SsaoImpactNearDistance { get; set;}

		[RED("ssaoImpactFarDistance")] 		public SSimpleCurve SsaoImpactFarDistance { get; set;}

		[RED("distantLightsIntensityScale")] 		public SSimpleCurve DistantLightsIntensityScale { get; set;}

		public CEnvGlobalFogParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvGlobalFogParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}