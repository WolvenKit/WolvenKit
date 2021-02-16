using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entEnvProbeComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(9)] [RED("size")] public Vector3 Size { get; set; }
		[Ordinal(10)] [RED("edgeScale")] public Vector3 EdgeScale { get; set; }
		[Ordinal(11)] [RED("emissiveScale")] public CFloat EmissiveScale { get; set; }
		[Ordinal(12)] [RED("globalProbe")] public CBool GlobalProbe { get; set; }
		[Ordinal(13)] [RED("boxProjection")] public CBool BoxProjection { get; set; }
		[Ordinal(14)] [RED("allInShadow")] public CBool AllInShadow { get; set; }
		[Ordinal(15)] [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(16)] [RED("streamingHeight")] public CFloat StreamingHeight { get; set; }
		[Ordinal(17)] [RED("blendRange")] public CUInt8 BlendRange { get; set; }
		[Ordinal(18)] [RED("neighborMode")] public CEnum<envUtilsNeighborMode> NeighborMode { get; set; }
		[Ordinal(19)] [RED("hideSkyColor")] public CBool HideSkyColor { get; set; }
		[Ordinal(20)] [RED("ambientMode")] public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode { get; set; }
		[Ordinal(21)] [RED("brightnessEVClamp")] public CUInt8 BrightnessEVClamp { get; set; }
		[Ordinal(22)] [RED("probeDataRef")] public raRef<CReflectionProbeDataResource> ProbeDataRef { get; set; }
		[Ordinal(23)] [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(24)] [RED("lightChannels")] public CEnum<rendLightChannel> LightChannels { get; set; }
		[Ordinal(25)] [RED("volumeChannels")] public CEnum<rendLightChannel> VolumeChannels { get; set; }

		public entEnvProbeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
