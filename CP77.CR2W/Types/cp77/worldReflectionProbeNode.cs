using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldReflectionProbeNode : worldNode
	{
		[Ordinal(0)]  [RED("probeDataRef")] public raRef<CReflectionProbeDataResource> ProbeDataRef { get; set; }
		[Ordinal(1)]  [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(2)]  [RED("globalProbe")] public CBool GlobalProbe { get; set; }
		[Ordinal(3)]  [RED("boxProjection")] public CBool BoxProjection { get; set; }
		[Ordinal(4)]  [RED("neighborMode")] public CEnum<envUtilsNeighborMode> NeighborMode { get; set; }
		[Ordinal(5)]  [RED("edgeScale")] public Vector3 EdgeScale { get; set; }
		[Ordinal(6)]  [RED("lightChannels")] public CEnum<rendLightChannel> LightChannels { get; set; }
		[Ordinal(7)]  [RED("emissiveScale")] public CFloat EmissiveScale { get; set; }
		[Ordinal(8)]  [RED("reflectionDimming")] public CFloat ReflectionDimming { get; set; }
		[Ordinal(9)]  [RED("simpleFogColor")] public HDRColor SimpleFogColor { get; set; }
		[Ordinal(10)]  [RED("simpleFogDensity")] public CFloat SimpleFogDensity { get; set; }
		[Ordinal(11)]  [RED("skyScale")] public CFloat SkyScale { get; set; }
		[Ordinal(12)]  [RED("allInShadow")] public CBool AllInShadow { get; set; }
		[Ordinal(13)]  [RED("hideSkyColor")] public CBool HideSkyColor { get; set; }
		[Ordinal(14)]  [RED("volFogAmbient")] public CBool VolFogAmbient { get; set; }
		[Ordinal(15)]  [RED("brightnessEVClamp")] public CInt8 BrightnessEVClamp { get; set; }
		[Ordinal(16)]  [RED("ambientMode")] public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode { get; set; }
		[Ordinal(17)]  [RED("captureOffset")] public Vector3 CaptureOffset { get; set; }
		[Ordinal(18)]  [RED("nearClipDistance")] public CFloat NearClipDistance { get; set; }
		[Ordinal(19)]  [RED("farClipDistance")] public CFloat FarClipDistance { get; set; }
		[Ordinal(20)]  [RED("volumeChannels")] public CEnum<rendLightChannel> VolumeChannels { get; set; }
		[Ordinal(21)]  [RED("blendRange")] public CUInt8 BlendRange { get; set; }
		[Ordinal(22)]  [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(23)]  [RED("streamingHeight")] public CFloat StreamingHeight { get; set; }
		[Ordinal(24)]  [RED("subScene")] public CBool SubScene { get; set; }
		[Ordinal(25)]  [RED("noFadeBlend")] public CBool NoFadeBlend { get; set; }

		public worldReflectionProbeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
