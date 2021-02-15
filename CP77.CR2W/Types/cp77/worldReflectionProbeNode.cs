using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldReflectionProbeNode : worldNode
	{
		[Ordinal(2)] [RED("probeDataRef")] public raRef<CReflectionProbeDataResource> ProbeDataRef { get; set; }
		[Ordinal(3)] [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(4)] [RED("globalProbe")] public CBool GlobalProbe { get; set; }
		[Ordinal(5)] [RED("boxProjection")] public CBool BoxProjection { get; set; }
		[Ordinal(6)] [RED("neighborMode")] public CEnum<envUtilsNeighborMode> NeighborMode { get; set; }
		[Ordinal(7)] [RED("edgeScale")] public Vector3 EdgeScale { get; set; }
		[Ordinal(8)] [RED("lightChannels")] public CEnum<rendLightChannel> LightChannels { get; set; }
		[Ordinal(9)] [RED("emissiveScale")] public CFloat EmissiveScale { get; set; }
		[Ordinal(10)] [RED("reflectionDimming")] public CFloat ReflectionDimming { get; set; }
		[Ordinal(11)] [RED("simpleFogColor")] public HDRColor SimpleFogColor { get; set; }
		[Ordinal(12)] [RED("simpleFogDensity")] public CFloat SimpleFogDensity { get; set; }
		[Ordinal(13)] [RED("skyScale")] public CFloat SkyScale { get; set; }
		[Ordinal(14)] [RED("allInShadow")] public CBool AllInShadow { get; set; }
		[Ordinal(15)] [RED("hideSkyColor")] public CBool HideSkyColor { get; set; }
		[Ordinal(16)] [RED("volFogAmbient")] public CBool VolFogAmbient { get; set; }
		[Ordinal(17)] [RED("brightnessEVClamp")] public CInt8 BrightnessEVClamp { get; set; }
		[Ordinal(18)] [RED("ambientMode")] public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode { get; set; }
		[Ordinal(19)] [RED("captureOffset")] public Vector3 CaptureOffset { get; set; }
		[Ordinal(20)] [RED("nearClipDistance")] public CFloat NearClipDistance { get; set; }
		[Ordinal(21)] [RED("farClipDistance")] public CFloat FarClipDistance { get; set; }
		[Ordinal(22)] [RED("volumeChannels")] public CEnum<rendLightChannel> VolumeChannels { get; set; }
		[Ordinal(23)] [RED("blendRange")] public CUInt8 BlendRange { get; set; }
		[Ordinal(24)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(25)] [RED("streamingHeight")] public CFloat StreamingHeight { get; set; }
		[Ordinal(26)] [RED("subScene")] public CBool SubScene { get; set; }
		[Ordinal(27)] [RED("noFadeBlend")] public CBool NoFadeBlend { get; set; }

		public worldReflectionProbeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
