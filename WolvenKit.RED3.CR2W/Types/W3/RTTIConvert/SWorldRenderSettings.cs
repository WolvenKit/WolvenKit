using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldRenderSettings : CVariable
	{
		[Ordinal(1)] [RED("cameraNearPlane")] 		public CFloat CameraNearPlane { get; set;}

		[Ordinal(2)] [RED("cameraFarPlane")] 		public CFloat CameraFarPlane { get; set;}

		[Ordinal(3)] [RED("ssaoBlurEnable")] 		public CBool SsaoBlurEnable { get; set;}

		[Ordinal(4)] [RED("ssaoNormalsEnable")] 		public CBool SsaoNormalsEnable { get; set;}

		[Ordinal(5)] [RED("envProbeSecondAmbientFilterSize")] 		public CFloat EnvProbeSecondAmbientFilterSize { get; set;}

		[Ordinal(6)] [RED("fakeCloudsShadowSize")] 		public CFloat FakeCloudsShadowSize { get; set;}

		[Ordinal(7)] [RED("fakeCloudsShadowSpeed")] 		public CFloat FakeCloudsShadowSpeed { get; set;}

		[Ordinal(8)] [RED("fakeCloudsShadowTexture")] 		public CHandle<CTextureArray> FakeCloudsShadowTexture { get; set;}

		[Ordinal(9)] [RED("bloomLevelsRange")] 		public CUInt32 BloomLevelsRange { get; set;}

		[Ordinal(10)] [RED("bloomLevelsOffset")] 		public CUInt32 BloomLevelsOffset { get; set;}

		[Ordinal(11)] [RED("bloomScaleConst")] 		public CFloat BloomScaleConst { get; set;}

		[Ordinal(12)] [RED("bloomDownscaleDivBase")] 		public CFloat BloomDownscaleDivBase { get; set;}

		[Ordinal(13)] [RED("bloomDownscaleDivExp")] 		public CFloat BloomDownscaleDivExp { get; set;}

		[Ordinal(14)] [RED("bloomLevelScale0")] 		public CFloat BloomLevelScale0 { get; set;}

		[Ordinal(15)] [RED("bloomLevelScale1")] 		public CFloat BloomLevelScale1 { get; set;}

		[Ordinal(16)] [RED("bloomLevelScale2")] 		public CFloat BloomLevelScale2 { get; set;}

		[Ordinal(17)] [RED("bloomLevelScale3")] 		public CFloat BloomLevelScale3 { get; set;}

		[Ordinal(18)] [RED("bloomLevelScale4")] 		public CFloat BloomLevelScale4 { get; set;}

		[Ordinal(19)] [RED("bloomLevelScale5")] 		public CFloat BloomLevelScale5 { get; set;}

		[Ordinal(20)] [RED("bloomLevelScale6")] 		public CFloat BloomLevelScale6 { get; set;}

		[Ordinal(21)] [RED("bloomLevelScale7")] 		public CFloat BloomLevelScale7 { get; set;}

		[Ordinal(22)] [RED("bloomPrecision")] 		public CFloat BloomPrecision { get; set;}

		[Ordinal(23)] [RED("shaftsLevelIndex")] 		public CUInt32 ShaftsLevelIndex { get; set;}

		[Ordinal(24)] [RED("shaftsIntensity")] 		public CFloat ShaftsIntensity { get; set;}

		[Ordinal(25)] [RED("shaftsThresholdsScale")] 		public CFloat ShaftsThresholdsScale { get; set;}

		[Ordinal(26)] [RED("fresnelScaleLights")] 		public CFloat FresnelScaleLights { get; set;}

		[Ordinal(27)] [RED("fresnelScaleEnvProbes")] 		public CFloat FresnelScaleEnvProbes { get; set;}

		[Ordinal(28)] [RED("fresnelRoughnessShape")] 		public CFloat FresnelRoughnessShape { get; set;}

		[Ordinal(29)] [RED("interiorDimmerAmbientLevel")] 		public CFloat InteriorDimmerAmbientLevel { get; set;}

		[Ordinal(30)] [RED("interiorVolumeSmoothExtent")] 		public CFloat InteriorVolumeSmoothExtent { get; set;}

		[Ordinal(31)] [RED("interiorVolumeSmoothRemovalRange")] 		public CFloat InteriorVolumeSmoothRemovalRange { get; set;}

		[Ordinal(32)] [RED("interiorVolumesFadeStartDist")] 		public CFloat InteriorVolumesFadeStartDist { get; set;}

		[Ordinal(33)] [RED("interiorVolumesFadeRange")] 		public CFloat InteriorVolumesFadeRange { get; set;}

		[Ordinal(34)] [RED("interiorVolumesFadeEncodeRange")] 		public CFloat InteriorVolumesFadeEncodeRange { get; set;}

		[Ordinal(35)] [RED("distantLightStartDistance")] 		public CFloat DistantLightStartDistance { get; set;}

		[Ordinal(36)] [RED("distantLightFadeDistance")] 		public CFloat DistantLightFadeDistance { get; set;}

		[Ordinal(37)] [RED("globalFlaresTransparencyThreshold")] 		public CFloat GlobalFlaresTransparencyThreshold { get; set;}

		[Ordinal(38)] [RED("globalFlaresTransparencyRange")] 		public CFloat GlobalFlaresTransparencyRange { get; set;}

		[Ordinal(39)] [RED("motionBlurSettings")] 		public SWorldMotionBlurSettings MotionBlurSettings { get; set;}

		[Ordinal(40)] [RED("chromaticAberrationStart")] 		public CFloat ChromaticAberrationStart { get; set;}

		[Ordinal(41)] [RED("chromaticAberrationRange")] 		public CFloat ChromaticAberrationRange { get; set;}

		[Ordinal(42)] [RED("interiorFallbackReflectionThresholdLow")] 		public CFloat InteriorFallbackReflectionThresholdLow { get; set;}

		[Ordinal(43)] [RED("interiorFallbackReflectionThresholdHigh")] 		public CFloat InteriorFallbackReflectionThresholdHigh { get; set;}

		[Ordinal(44)] [RED("interiorFallbackReflectionBlendLow")] 		public CFloat InteriorFallbackReflectionBlendLow { get; set;}

		[Ordinal(45)] [RED("interiorFallbackReflectionBlendHigh")] 		public CFloat InteriorFallbackReflectionBlendHigh { get; set;}

		[Ordinal(46)] [RED("enableEnvProbeLights")] 		public CBool EnableEnvProbeLights { get; set;}

		public SWorldRenderSettings(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWorldRenderSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}