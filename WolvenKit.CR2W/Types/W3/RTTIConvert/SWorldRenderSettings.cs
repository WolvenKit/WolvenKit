using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldRenderSettings : CVariable
	{
		[RED("cameraNearPlane")] 		public CFloat CameraNearPlane { get; set;}

		[RED("cameraFarPlane")] 		public CFloat CameraFarPlane { get; set;}

		[RED("ssaoBlurEnable")] 		public CBool SsaoBlurEnable { get; set;}

		[RED("ssaoNormalsEnable")] 		public CBool SsaoNormalsEnable { get; set;}

		[RED("envProbeSecondAmbientFilterSize")] 		public CFloat EnvProbeSecondAmbientFilterSize { get; set;}

		[RED("fakeCloudsShadowSize")] 		public CFloat FakeCloudsShadowSize { get; set;}

		[RED("fakeCloudsShadowSpeed")] 		public CFloat FakeCloudsShadowSpeed { get; set;}

		[RED("fakeCloudsShadowTexture")] 		public CHandle<CTextureArray> FakeCloudsShadowTexture { get; set;}

		[RED("bloomLevelsRange")] 		public CUInt32 BloomLevelsRange { get; set;}

		[RED("bloomLevelsOffset")] 		public CUInt32 BloomLevelsOffset { get; set;}

		[RED("bloomScaleConst")] 		public CFloat BloomScaleConst { get; set;}

		[RED("bloomDownscaleDivBase")] 		public CFloat BloomDownscaleDivBase { get; set;}

		[RED("bloomDownscaleDivExp")] 		public CFloat BloomDownscaleDivExp { get; set;}

		[RED("bloomLevelScale0")] 		public CFloat BloomLevelScale0 { get; set;}

		[RED("bloomLevelScale1")] 		public CFloat BloomLevelScale1 { get; set;}

		[RED("bloomLevelScale2")] 		public CFloat BloomLevelScale2 { get; set;}

		[RED("bloomLevelScale3")] 		public CFloat BloomLevelScale3 { get; set;}

		[RED("bloomLevelScale4")] 		public CFloat BloomLevelScale4 { get; set;}

		[RED("bloomLevelScale5")] 		public CFloat BloomLevelScale5 { get; set;}

		[RED("bloomLevelScale6")] 		public CFloat BloomLevelScale6 { get; set;}

		[RED("bloomLevelScale7")] 		public CFloat BloomLevelScale7 { get; set;}

		[RED("bloomPrecision")] 		public CFloat BloomPrecision { get; set;}

		[RED("shaftsLevelIndex")] 		public CUInt32 ShaftsLevelIndex { get; set;}

		[RED("shaftsIntensity")] 		public CFloat ShaftsIntensity { get; set;}

		[RED("shaftsThresholdsScale")] 		public CFloat ShaftsThresholdsScale { get; set;}

		[RED("fresnelScaleLights")] 		public CFloat FresnelScaleLights { get; set;}

		[RED("fresnelScaleEnvProbes")] 		public CFloat FresnelScaleEnvProbes { get; set;}

		[RED("fresnelRoughnessShape")] 		public CFloat FresnelRoughnessShape { get; set;}

		[RED("interiorDimmerAmbientLevel")] 		public CFloat InteriorDimmerAmbientLevel { get; set;}

		[RED("interiorVolumeSmoothExtent")] 		public CFloat InteriorVolumeSmoothExtent { get; set;}

		[RED("interiorVolumeSmoothRemovalRange")] 		public CFloat InteriorVolumeSmoothRemovalRange { get; set;}

		[RED("interiorVolumesFadeStartDist")] 		public CFloat InteriorVolumesFadeStartDist { get; set;}

		[RED("interiorVolumesFadeRange")] 		public CFloat InteriorVolumesFadeRange { get; set;}

		[RED("interiorVolumesFadeEncodeRange")] 		public CFloat InteriorVolumesFadeEncodeRange { get; set;}

		[RED("distantLightStartDistance")] 		public CFloat DistantLightStartDistance { get; set;}

		[RED("distantLightFadeDistance")] 		public CFloat DistantLightFadeDistance { get; set;}

		[RED("globalFlaresTransparencyThreshold")] 		public CFloat GlobalFlaresTransparencyThreshold { get; set;}

		[RED("globalFlaresTransparencyRange")] 		public CFloat GlobalFlaresTransparencyRange { get; set;}

		[RED("motionBlurSettings")] 		public SWorldMotionBlurSettings MotionBlurSettings { get; set;}

		[RED("chromaticAberrationStart")] 		public CFloat ChromaticAberrationStart { get; set;}

		[RED("chromaticAberrationRange")] 		public CFloat ChromaticAberrationRange { get; set;}

		[RED("interiorFallbackReflectionThresholdLow")] 		public CFloat InteriorFallbackReflectionThresholdLow { get; set;}

		[RED("interiorFallbackReflectionThresholdHigh")] 		public CFloat InteriorFallbackReflectionThresholdHigh { get; set;}

		[RED("interiorFallbackReflectionBlendLow")] 		public CFloat InteriorFallbackReflectionBlendLow { get; set;}

		[RED("interiorFallbackReflectionBlendHigh")] 		public CFloat InteriorFallbackReflectionBlendHigh { get; set;}

		[RED("enableEnvProbeLights")] 		public CBool EnableEnvProbeLights { get; set;}

		public SWorldRenderSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWorldRenderSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}