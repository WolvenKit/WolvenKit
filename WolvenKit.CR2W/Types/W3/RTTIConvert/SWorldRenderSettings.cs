using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldRenderSettings : CVariable
	{
		[Ordinal(0)] [RED("("cameraNearPlane")] 		public CFloat CameraNearPlane { get; set;}

		[Ordinal(0)] [RED("("cameraFarPlane")] 		public CFloat CameraFarPlane { get; set;}

		[Ordinal(0)] [RED("("ssaoBlurEnable")] 		public CBool SsaoBlurEnable { get; set;}

		[Ordinal(0)] [RED("("ssaoNormalsEnable")] 		public CBool SsaoNormalsEnable { get; set;}

		[Ordinal(0)] [RED("("envProbeSecondAmbientFilterSize")] 		public CFloat EnvProbeSecondAmbientFilterSize { get; set;}

		[Ordinal(0)] [RED("("fakeCloudsShadowSize")] 		public CFloat FakeCloudsShadowSize { get; set;}

		[Ordinal(0)] [RED("("fakeCloudsShadowSpeed")] 		public CFloat FakeCloudsShadowSpeed { get; set;}

		[Ordinal(0)] [RED("("fakeCloudsShadowTexture")] 		public CHandle<CTextureArray> FakeCloudsShadowTexture { get; set;}

		[Ordinal(0)] [RED("("bloomLevelsRange")] 		public CUInt32 BloomLevelsRange { get; set;}

		[Ordinal(0)] [RED("("bloomLevelsOffset")] 		public CUInt32 BloomLevelsOffset { get; set;}

		[Ordinal(0)] [RED("("bloomScaleConst")] 		public CFloat BloomScaleConst { get; set;}

		[Ordinal(0)] [RED("("bloomDownscaleDivBase")] 		public CFloat BloomDownscaleDivBase { get; set;}

		[Ordinal(0)] [RED("("bloomDownscaleDivExp")] 		public CFloat BloomDownscaleDivExp { get; set;}

		[Ordinal(0)] [RED("("bloomLevelScale0")] 		public CFloat BloomLevelScale0 { get; set;}

		[Ordinal(0)] [RED("("bloomLevelScale1")] 		public CFloat BloomLevelScale1 { get; set;}

		[Ordinal(0)] [RED("("bloomLevelScale2")] 		public CFloat BloomLevelScale2 { get; set;}

		[Ordinal(0)] [RED("("bloomLevelScale3")] 		public CFloat BloomLevelScale3 { get; set;}

		[Ordinal(0)] [RED("("bloomLevelScale4")] 		public CFloat BloomLevelScale4 { get; set;}

		[Ordinal(0)] [RED("("bloomLevelScale5")] 		public CFloat BloomLevelScale5 { get; set;}

		[Ordinal(0)] [RED("("bloomLevelScale6")] 		public CFloat BloomLevelScale6 { get; set;}

		[Ordinal(0)] [RED("("bloomLevelScale7")] 		public CFloat BloomLevelScale7 { get; set;}

		[Ordinal(0)] [RED("("bloomPrecision")] 		public CFloat BloomPrecision { get; set;}

		[Ordinal(0)] [RED("("shaftsLevelIndex")] 		public CUInt32 ShaftsLevelIndex { get; set;}

		[Ordinal(0)] [RED("("shaftsIntensity")] 		public CFloat ShaftsIntensity { get; set;}

		[Ordinal(0)] [RED("("shaftsThresholdsScale")] 		public CFloat ShaftsThresholdsScale { get; set;}

		[Ordinal(0)] [RED("("fresnelScaleLights")] 		public CFloat FresnelScaleLights { get; set;}

		[Ordinal(0)] [RED("("fresnelScaleEnvProbes")] 		public CFloat FresnelScaleEnvProbes { get; set;}

		[Ordinal(0)] [RED("("fresnelRoughnessShape")] 		public CFloat FresnelRoughnessShape { get; set;}

		[Ordinal(0)] [RED("("interiorDimmerAmbientLevel")] 		public CFloat InteriorDimmerAmbientLevel { get; set;}

		[Ordinal(0)] [RED("("interiorVolumeSmoothExtent")] 		public CFloat InteriorVolumeSmoothExtent { get; set;}

		[Ordinal(0)] [RED("("interiorVolumeSmoothRemovalRange")] 		public CFloat InteriorVolumeSmoothRemovalRange { get; set;}

		[Ordinal(0)] [RED("("interiorVolumesFadeStartDist")] 		public CFloat InteriorVolumesFadeStartDist { get; set;}

		[Ordinal(0)] [RED("("interiorVolumesFadeRange")] 		public CFloat InteriorVolumesFadeRange { get; set;}

		[Ordinal(0)] [RED("("interiorVolumesFadeEncodeRange")] 		public CFloat InteriorVolumesFadeEncodeRange { get; set;}

		[Ordinal(0)] [RED("("distantLightStartDistance")] 		public CFloat DistantLightStartDistance { get; set;}

		[Ordinal(0)] [RED("("distantLightFadeDistance")] 		public CFloat DistantLightFadeDistance { get; set;}

		[Ordinal(0)] [RED("("globalFlaresTransparencyThreshold")] 		public CFloat GlobalFlaresTransparencyThreshold { get; set;}

		[Ordinal(0)] [RED("("globalFlaresTransparencyRange")] 		public CFloat GlobalFlaresTransparencyRange { get; set;}

		[Ordinal(0)] [RED("("motionBlurSettings")] 		public SWorldMotionBlurSettings MotionBlurSettings { get; set;}

		[Ordinal(0)] [RED("("chromaticAberrationStart")] 		public CFloat ChromaticAberrationStart { get; set;}

		[Ordinal(0)] [RED("("chromaticAberrationRange")] 		public CFloat ChromaticAberrationRange { get; set;}

		[Ordinal(0)] [RED("("interiorFallbackReflectionThresholdLow")] 		public CFloat InteriorFallbackReflectionThresholdLow { get; set;}

		[Ordinal(0)] [RED("("interiorFallbackReflectionThresholdHigh")] 		public CFloat InteriorFallbackReflectionThresholdHigh { get; set;}

		[Ordinal(0)] [RED("("interiorFallbackReflectionBlendLow")] 		public CFloat InteriorFallbackReflectionBlendLow { get; set;}

		[Ordinal(0)] [RED("("interiorFallbackReflectionBlendHigh")] 		public CFloat InteriorFallbackReflectionBlendHigh { get; set;}

		[Ordinal(0)] [RED("("enableEnvProbeLights")] 		public CBool EnableEnvProbeLights { get; set;}

		public SWorldRenderSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWorldRenderSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}