using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entEnvProbeComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("allInShadow")] public CBool AllInShadow { get; set; }
		[Ordinal(1)]  [RED("ambientMode")] public CEnum<envUtilsReflectionProbeAmbientContributionMode> AmbientMode { get; set; }
		[Ordinal(2)]  [RED("blendRange")] public CUInt8 BlendRange { get; set; }
		[Ordinal(3)]  [RED("boxProjection")] public CBool BoxProjection { get; set; }
		[Ordinal(4)]  [RED("brightnessEVClamp")] public CUInt8 BrightnessEVClamp { get; set; }
		[Ordinal(5)]  [RED("edgeScale")] public Vector3 EdgeScale { get; set; }
		[Ordinal(6)]  [RED("emissiveScale")] public CFloat EmissiveScale { get; set; }
		[Ordinal(7)]  [RED("globalProbe")] public CBool GlobalProbe { get; set; }
		[Ordinal(8)]  [RED("hideSkyColor")] public CBool HideSkyColor { get; set; }
		[Ordinal(9)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(10)]  [RED("lightChannels")] public CEnum<rendLightChannel> LightChannels { get; set; }
		[Ordinal(11)]  [RED("neighborMode")] public CEnum<envUtilsNeighborMode> NeighborMode { get; set; }
		[Ordinal(12)]  [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(13)]  [RED("probeDataRef")] public raRef<CReflectionProbeDataResource> ProbeDataRef { get; set; }
		[Ordinal(14)]  [RED("size")] public Vector3 Size { get; set; }
		[Ordinal(15)]  [RED("streamingDistance")] public CFloat StreamingDistance { get; set; }
		[Ordinal(16)]  [RED("streamingHeight")] public CFloat StreamingHeight { get; set; }
		[Ordinal(17)]  [RED("volumeChannels")] public CEnum<rendLightChannel> VolumeChannels { get; set; }

		public entEnvProbeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
