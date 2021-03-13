using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldReflectionProbeNode : worldNode
	{
		[Ordinal(4)] [RED("probeDataRef")] public raRef<CReflectionProbeDataResource> ProbeDataRef { get; set; }
		[Ordinal(5)] [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(6)] [RED("globalProbe")] public CBool GlobalProbe { get; set; }
		[Ordinal(7)] [RED("boxProjection")] public CBool BoxProjection { get; set; }
		[Ordinal(8)] [RED("neighborMode")] public CEnum<envUtilsNeighborMode> NeighborMode { get; set; }
		[Ordinal(9)] [RED("edgeScale")] public Vector3 EdgeScale { get; set; }
		[Ordinal(10)] [RED("lightChannels")] public CEnum<rendLightChannel> LightChannels { get; set; }
		[Ordinal(11)] [RED("emissiveScale")] public CFloat EmissiveScale { get; set; }
		[Ordinal(12)] [RED("reflectionDimming")] public CFloat ReflectionDimming { get; set; }
		[Ordinal(13)] [RED("simpleFogColor")] public HDRColor SimpleFogColor { get; set; }
		[Ordinal(14)] [RED("simpleFogDensity")] public CFloat SimpleFogDensity { get; set; }
		[Ordinal(15)] [RED("skyScale")] public CFloat SkyScale { get; set; }
		[Ordinal(16)] [RED("allInShadow")] public CBool AllInShadow { get; set; }
		[Ordinal(17)] [RED("hideSkyColor")] public CBool HideSkyColor { get; set; }
		[Ordinal(18)] [RED("volFogAmbient")] public CBool VolFogAmbient { get; set; }
		[Ordinal(19)] [RED("brightnessEVClamp")] public CInt8 BrightnessEVClamp { get; set; }
		[Ordinal(20)] [RED("ambientMode")] public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode { get; set; }
		[Ordinal(21)] [RED("captureOffset")] public Vector3 CaptureOffset { get; set; }
		[Ordinal(22)] [RED("nearClipDistance")] public CFloat NearClipDistance { get; set; }
		[Ordinal(23)] [RED("farClipDistance")] public CFloat FarClipDistance { get; set; }
		[Ordinal(24)] [RED("volumeChannels")] public CEnum<rendLightChannel> VolumeChannels { get; set; }
		[Ordinal(25)] [RED("blendRange")] public CUInt8 BlendRange { get; set; }
		[Ordinal(26)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(27)] [RED("streamingHeight")] public CFloat StreamingHeight { get; set; }
		[Ordinal(28)] [RED("subScene")] public CBool SubScene { get; set; }
		[Ordinal(29)] [RED("noFadeBlend")] public CBool NoFadeBlend { get; set; }

		public worldReflectionProbeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
